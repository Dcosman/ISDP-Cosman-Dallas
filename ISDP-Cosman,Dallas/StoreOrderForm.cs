using ISDP_Cosman_Dallas.Accessors;
using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ISDP_Cosman_Dallas
{
    public partial class frmStoreOrder : Form
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["bullseye2024"].ConnectionString;
        Employee theEmployee;
        Site theSite;
        Site dispatchSite;
        List<Inventory> siteInventory;
        bool orderSubmitted = false;
        bool autoGenerating = true;
        bool firstRefresh = true;
        bool emergency;
        string orderTxnType;
        List<TransactionItems> removedInv = new List<TransactionItems>();
        List<TransactionItems> editInv = new List<TransactionItems>();
        List<OrderInventory> initialDispatch = new List<OrderInventory>();

        public Transaction Data { get; set; }

        public frmStoreOrder()
        {
            InitializeComponent();

        }

        private void frmStoreOrder_Load(object sender, EventArgs e)
        {
            
            theEmployee = this.Tag as Employee;

            if (this.Text.Contains("Emergency"))
            {
                emergency = true;
                orderTxnType = "Emergency";
            }
            else
            {
                emergency = false;
                orderTxnType = "Store Order";
            }

            if (this.Data == null)
            {
                initialDispatch = InventoryAccessor.GetSiteInventory(Constants.WAREHOUSE_SITE);
                int txnID = HelperMethods.GetNewID("select max(txnID) from txn");
                int siteTo = theEmployee.SiteID;
                int siteFrom = Constants.WAREHOUSE_SITE;

                DateTime today = DateTime.Today;
                DayOfWeek shipDayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), SiteAccessor.GetSiteByID(theEmployee.SiteID).DayOfWeek, true);
                DateTime shipDate = today.AddDays((shipDayOfWeek - today.DayOfWeek + 7) % 7);

                Transaction txn = new Transaction(txnID, siteTo, siteFrom, "", shipDate, orderTxnType, "", DateTime.Now, null, null, null);

                PopulateOrder(txn);

                siteInventory = InventoryAccessor.GetThresholdInventory(theEmployee.SiteID);

                GenerateOrderItems();
            }
            else
            {
                initialDispatch = InventoryAccessor.GetOrderInventory(this.Data.TxnID);
                List<OrderInventory> warehouseInv = InventoryAccessor.GetSiteInventory(Constants.WAREHOUSE_SITE);
                foreach (OrderInventory oi in warehouseInv)
                {
                    if (!initialDispatch.Any(item => item.ItemID == oi.ItemID))
                    {
                        initialDispatch.Add(oi);
                    }
                }
                PopulateOrder(this.Data);
                /*
                List<TransactionItems> items = TransactionItemsAccessor.GetTransactionItemsById(this.Data.TxnID);
                foreach (TransactionItems item in items)
                {
                    Item theItem = ItemAccessor.GetItemByID(item.ItemID);
                    Inventory inv = new Inventory(item.ItemID, this.Data.SiteIDTo, item.Quantity, txtOrderID.Text, , );
                }*/
                //availInv = InventoryAccessor.GetInventoryByLocation(txtOrderID.Text);
                siteInventory = InventoryAccessor.GetInventoryByLocation(txtOrderID.Text);
                editInv = TransactionItemsAccessor.GetTransactionItemsById(this.Data.TxnID);

                foreach (Inventory inv in siteInventory)
                {
                    int rowIndex = dgvSiteInventory.Rows.Add();
                    Item theItem = ItemAccessor.GetItemByID(inv.ItemID);
                    dgvSiteInventory.Rows[rowIndex].Cells["itemID"].Value = inv.ItemID;
                    dgvSiteInventory.Rows[rowIndex].Cells["name"].Value = theItem.Name;
                    dgvSiteInventory.Rows[rowIndex].Cells["quantity"].Value = InventoryAccessor.GetInventoryByItemIDAndSiteID(inv.ItemID, inv.SiteID).Quantity;
                    dgvSiteInventory.Rows[rowIndex].Cells["optimumThreshold"].Value = inv.OptimumThreshold;
                    if (inv.ReorderThreshold.HasValue)
                        dgvSiteInventory.Rows[rowIndex].Cells["reorderThreshold"].Value = inv.ReorderThreshold;
                    dgvSiteInventory.Rows[rowIndex].Cells["itemQuantity"].Value = TransactionItemsAccessor.GetTransactionItemByItemId(inv.ItemID).Quantity +
                        $"({ItemAccessor.GetItemByID(inv.ItemID).CaseSize * TransactionItemsAccessor.GetTransactionItemByItemId(inv.ItemID).Quantity})";
                }
                dgvSiteInventory.ClearSelection();
                autoGenerating = false;
            }
        }

        private void ClearItemInfo()
        {
            txtItemID.Clear();
            txtItemName.Clear();
            txtItemReorder.Clear();
            txtItemStock.Clear();
            txtItemThreshold.Clear();
            numItemQuantity.Value = 0;
        }

        private void PopulateOrder(Transaction inTxn)
        {

            theSite = SiteAccessor.GetSiteByID(inTxn.SiteIDTo);
            dispatchSite = SiteAccessor.GetSiteByID(inTxn.SiteIDFrom);

            dgvSiteInventory.AutoGenerateColumns = false;

            List<Site> sites = new List<Site>();

            txtOrderID.Text = inTxn.TxnID.ToString();
            txtEmployee.Text = theEmployee.FirstName + " " + theEmployee.LastName;
            txtOrderType.Text = inTxn.TxnType;

            cboOrderLocation.Items.Clear();
            cboDispatchLocation.Items.Clear();

            sites = SiteAccessor.GetAllSites();

            foreach (Site site in sites)
            {
                cboDispatchLocation.Items.Add(site.Name);
                cboOrderLocation.Items.Add(site.Name);
            }

            cboOrderLocation.SelectedIndex = cboOrderLocation.Items.IndexOf(theSite.Name);
            cboDispatchLocation.SelectedIndex = cboOrderLocation.Items.IndexOf(dispatchSite.Name);

            dtpOrderShipDate.Value = inTxn.ShipDate;
        }

        private void GenerateOrderItems()
        {
            foreach (Inventory inv in siteInventory)
            {
                if (inv.Quantity <= inv.ReorderThreshold)
                {
                    Inventory itemToAdd = InventoryAccessor.GetInventoryByItemIDAndSiteID(inv.ItemID, dispatchSite.SiteID);
                    Item theItem = ItemAccessor.GetItemByID(inv.ItemID);
                    int quantity = inv.OptimumThreshold - inv.Quantity;
                    quantity = (int)Math.Ceiling((double)quantity / (double)theItem.CaseSize);

                    if (quantity > 0)
                        AddToOrder(itemToAdd, quantity);
                }
            }
            dgvSiteInventory.ClearSelection();
            autoGenerating = false;
        }

        private void dgvDispatchInventory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (dgvDispatchInventory.SelectedRows.Count > 0 && numQuantity.Value > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dgvDispatchInventory.SelectedRows[0];
                    int selectedID = (int)selectedRow.Cells["ItemID"].Value;
                    int selctedSite = Constants.WAREHOUSE_SITE;
                    Inventory selectedItem = InventoryAccessor.GetInventoryByItemIDAndSiteID(selectedID, selctedSite);
                    AddToOrder(selectedItem, (int)numQuantity.Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void AddToOrder(Inventory inv, int quantity)
        {
            /*if (quantity <= inv.Quantity)
            {*/
            Inventory selectedItem = InventoryAccessor.GetInventoryByItemIDAndSiteID(inv.ItemID, theSite.SiteID);
            Item theItem = ItemAccessor.GetItemByID(selectedItem.ItemID);

            bool itemExists = false;

            if (quantity < 0)
            {
                int stock = initialDispatch.FirstOrDefault(inven => inven.ItemID == inv.ItemID).Quantity;
                if (stock > numItemQuantity.Value)
                {
                    HelperMethods.UpdateQuantity(stock - (int)numItemQuantity.Value, inv.ItemID, inv.SiteID);
                }
            }
            else if (quantity > inv.Quantity)
            {
                HelperMethods.UpdateQuantity(0, inv.ItemID, inv.SiteID);
            }
            else if (quantity != 0)
            {
                HelperMethods.UpdateQuantity(inv.Quantity - quantity, inv.ItemID, inv.SiteID);
            }

            foreach (DataGridViewRow row in dgvSiteInventory.Rows)
            {
                if (row.Cells["itemID"].Value != null && int.TryParse(row.Cells["itemID"].Value.ToString(), out int id))
                {
                    if (id == inv.ItemID)
                    {
                        int qMatch = HelperMethods.GetItemQuantity(row.Cells["itemQuantity"].Value.ToString());
                        row.Cells["itemQuantity"].Value = (qMatch + quantity) + $"({theItem.CaseSize * (quantity + qMatch)})";
                        itemExists = true;
                    }
                }
            }

            if (!itemExists)
            {
                int rowIndex = dgvSiteInventory.Rows.Add();

                dgvSiteInventory.Rows[rowIndex].Cells["itemID"].Value = selectedItem.ItemID;
                dgvSiteInventory.Rows[rowIndex].Cells["name"].Value = theItem.Name;
                dgvSiteInventory.Rows[rowIndex].Cells["quantity"].Value = selectedItem.Quantity;
                dgvSiteInventory.Rows[rowIndex].Cells["optimumThreshold"].Value = selectedItem.OptimumThreshold;
                if (selectedItem.ReorderThreshold.HasValue)
                    dgvSiteInventory.Rows[rowIndex].Cells["reorderThreshold"].Value = selectedItem.ReorderThreshold;
                dgvSiteInventory.Rows[rowIndex].Cells["itemQuantity"].Value = quantity + $"({theItem.CaseSize * quantity})";
            }

            if (removedInv.Count > 0 && removedInv.Any(inv => inv.ItemID == selectedItem.ItemID))
            {
                removedInv.RemoveAll(item => item.ItemID == selectedItem.ItemID);
            }
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            dgvDispatchInventory.DataSource = null;

            dgvDispatchInventory.DataSource = InventoryAccessor.GetSiteInventory(Constants.WAREHOUSE_SITE);

            dgvDispatchInventory.Columns["itemName"].DisplayIndex = 1;
            dgvDispatchInventory.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDispatchInventory.Columns["ItemID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDispatchInventory.Columns["caseSize"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            firstRefresh = false;
        }

        private void frmStoreOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!orderSubmitted)
            {
                DialogResult result = MessageBox.Show("Are you sure you would like to close the window?\nThe order will not be saved.", "Confirm Close", MessageBoxButtons.YesNo);

                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                else
                {
                    foreach (DataGridViewRow row in dgvSiteInventory.Rows)
                    {
                        if (row.Cells["itemID"].Value != null && int.TryParse(row.Cells["itemID"].Value.ToString(), out int id))
                        {
                            int quantity = HelperMethods.GetItemQuantity(row.Cells["itemQuantity"].Value.ToString());
                            int itemID = int.Parse(row.Cells["itemID"].Value.ToString());

                            if (siteInventory.Any(inv => inv.ItemID == itemID) && this.Data != null)
                            {
                                TransactionItems existingItem = editInv.FirstOrDefault(inv => inv.ItemID == itemID);
                                int initialQuantity = initialDispatch.FirstOrDefault(item => item.ItemID == itemID).Quantity;
                                Inventory invToUpdate = InventoryAccessor.GetInventoryByItemIDAndSiteID((int)row.Cells["itemID"].Value, Constants.WAREHOUSE_SITE);

                                if (existingItem.Quantity >= initialQuantity)
                                {
                                    HelperMethods.UpdateQuantity(0, invToUpdate.ItemID, invToUpdate.SiteID);
                                }
                                else
                                {
                                    HelperMethods.UpdateQuantity((initialQuantity - existingItem.Quantity), invToUpdate.ItemID, invToUpdate.SiteID);
                                }
                            }

                            else if (quantity > 0 || quantity < 0)
                            {
                                int prevQuantity;
                                Inventory invToUpdate = InventoryAccessor.GetInventoryByItemIDAndSiteID((int)row.Cells["itemID"].Value, Constants.WAREHOUSE_SITE);
                                prevQuantity = initialDispatch.FirstOrDefault(inven => inven.ItemID == itemID).Quantity;
                                
                                HelperMethods.UpdateQuantity(prevQuantity, invToUpdate.ItemID, invToUpdate.SiteID);
                            }
                        }
                    }
                    if (removedInv.Count > 0)
                    {
                        foreach (TransactionItems i in removedInv)
                        {
                            Inventory invToUpdate = InventoryAccessor.GetInventoryByItemIDAndSiteID(i.ItemID, Constants.WAREHOUSE_SITE);
                            int initialQuantity = initialDispatch.FirstOrDefault(item => item.ItemID == i.ItemID).Quantity;
                            if (i.Quantity >= initialQuantity)
                                HelperMethods.UpdateQuantity(0, invToUpdate.ItemID, invToUpdate.SiteID);
                            else
                                HelperMethods.UpdateQuantity((initialQuantity - i.Quantity), invToUpdate.ItemID, invToUpdate.SiteID);
                        }
                    }
                }
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSiteInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSiteInventory.SelectedRows.Count > 0 && !autoGenerating)
            {
                DataGridViewRow selectedRow = dgvSiteInventory.SelectedRows[0];


                string itemID = selectedRow.Cells["itemID"].Value.ToString();
                string itemName = selectedRow.Cells["name"].Value.ToString();
                string invQuantity = selectedRow.Cells["quantity"].Value.ToString();
                string optimumThreshold = selectedRow.Cells["optimumThreshold"].Value.ToString();
                string reorderThreshold = selectedRow.Cells["reorderThreshold"].Value?.ToString();
                int itemQuantity = HelperMethods.GetItemQuantity(selectedRow.Cells["itemQuantity"].Value.ToString());

                txtItemID.Text = itemID;
                txtItemName.Text = itemName;
                txtItemStock.Text = invQuantity;
                txtItemThreshold.Text = optimumThreshold;
                numItemQuantity.Value = itemQuantity;

                if (!string.IsNullOrEmpty(reorderThreshold))
                {
                    txtItemReorder.Text = reorderThreshold;
                }
            }
        }

        private void picRemoveInventory_Click(object sender, EventArgs e)
        {
            if (dgvSiteInventory.SelectedRows.Count > 0 && !string.IsNullOrEmpty(txtItemID.Text))
            {
                int itemID = int.Parse(txtItemID.Text);
                DialogResult result = MessageBox.Show($"Are you sure you would like to remove item {itemID} from the order?", "Confirm Item Removal", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (this.Data != null)
                        removedInv.Add(editInv.FirstOrDefault(inv => inv.ItemID == itemID));

                    int itemQuantity = HelperMethods.GetItemQuantity(dgvSiteInventory.SelectedRows[0].Cells["itemQuantity"].Value.ToString());

                    Inventory invToUpdate = InventoryAccessor.GetInventoryByItemIDAndSiteID(itemID, Constants.WAREHOUSE_SITE);
                    int quantity;
                    OrderInventory inventoryRemove = initialDispatch.FirstOrDefault(inv => inv.ItemID == itemID);

                    quantity = inventoryRemove.Quantity;

                    HelperMethods.UpdateQuantity(quantity, itemID, invToUpdate.SiteID);

                    int selectedIndex = dgvSiteInventory.SelectedRows[0].Index;
                    dgvSiteInventory.Rows.RemoveAt(selectedIndex);
                }
                ClearItemInfo();
            }
        }

        private void picConfirmInventory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtItemID.Text))
            {
                int itemID = int.Parse(txtItemID.Text);
                int newQuantity = (int)numItemQuantity.Value - HelperMethods.GetItemQuantity(dgvSiteInventory.SelectedRows[0].Cells["itemQuantity"].Value.ToString());


                DialogResult result = MessageBox.Show($"update quantity for item {itemID} to {numItemQuantity.Value}?", "Confirm Item Quantity", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Inventory invToUpdate = InventoryAccessor.GetInventoryByItemIDAndSiteID(itemID, Constants.WAREHOUSE_SITE);
                    AddToOrder(invToUpdate, newQuantity);
                }
            }

        }

        private void btnSearchDispatch_Click(object sender, EventArgs e)
        {
            List<OrderInventory> invList = InventoryAccessor.GetSiteInventory(Constants.WAREHOUSE_SITE);
            List<OrderInventory> filteredInv = new List<OrderInventory>();

            filteredInv = HelperMethods.FilterData(invList, txtSearchDispatch, dgvDispatchInventory, inv => inv.ItemID.ToString());
            filteredInv.AddRange(HelperMethods.FilterData(filteredInv, txtSearchDispatch, dgvDispatchInventory, inv => ItemAccessor.GetItemByID(inv.ItemID).Name));
            filteredInv = filteredInv.Distinct().ToList();

            dgvDispatchInventory.DataSource = filteredInv;

        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Confirm order: \nOrder ID {txtOrderID.Text} ({txtOrderType.Text})" +
                $"\nOrder to: {cboOrderLocation.Text}\nDispatch from: {cboDispatchLocation.Text}", "Confirm Order", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                frmOrderNotes orderNotes = new frmOrderNotes();
                orderNotes.Tag = txtOrderID.Text;
                orderNotes.ShowDialog();
                string notes = orderNotes.Tag.ToString();
                string txnSql;
                if (this.Data == null)
                {
                    txnSql = @"
                    INSERT INTO txn (txnID, siteIDTo, siteIDFrom, status, shipDate, txnType, barCode, createdDate, deliveryID, emergencyDelivery, notes)
                    VALUES (@txnID, @siteIDTo, @siteIDFrom, @status, @shipDate, @txnType, @barCode, @createdDate, @deliveryID, @emergencyDelivery, @notes)
                    ON DUPLICATE KEY UPDATE
                    txnID = @txnID,
                    siteIDTo = @siteIDTo,
                    siteIDFrom = @siteIDFrom,
                    status = @status,
                    shipDate = @shipDate,
                    txnType = @txnType,
                    barCode = @barCode,
                    createdDate = @createdDate,
                    deliveryID = @deliveryID,
                    emergencyDelivery = @emergencyDelivery,
                    notes = @notes";
                }
                else
                {
                    txnSql = @"
                        UPDATE txn 
                        SET siteIDTo = @siteIDTo,
                            siteIDFrom = @siteIDFrom,
                            status = @status,
                            shipDate = @shipDate,
                            txnType = @txnType,
                            barCode = @barCode,
                            deliveryID = @deliveryID,
                            emergencyDelivery = @emergencyDelivery,
                            notes = @notes
                        WHERE txnID = @txnID";

                }

                List<MySqlParameter> txnParameters = new List<MySqlParameter>
                {
                    new MySqlParameter("@siteIDTo", theSite.SiteID),
                    new MySqlParameter("@siteIDFrom", Constants.WAREHOUSE_SITE),
                    new MySqlParameter("@status", "New"),
                    new MySqlParameter("@shipDate", dtpOrderShipDate.Value),
                    new MySqlParameter("@txnType", orderTxnType),
                    new MySqlParameter("@barCode", Constants.ORDER_BARCODE),
                    new MySqlParameter("@deliveryID", DBNull.Value),
                    new MySqlParameter("@emergencyDelivery", emergency),
                    new MySqlParameter("@notes", notes),
                    new MySqlParameter("@txnID", int.Parse(txtOrderID.Text))
                };

                if (this.Data == null)
                {
                    txnParameters.Add(new MySqlParameter("@createdDate", DateTime.Now));
                }

                bool success = TransactionAccessor.AddUpdateTransaction(txnSql, txnParameters);

                string txnItemsSql = "";                    

                List<MySqlParameter> txnItemsParameters = new List<MySqlParameter>();

                txnItemsParameters.Add(new MySqlParameter("@txnID", int.Parse(txtOrderID.Text)));

                if (this.Data == null)
                {
                    txnItemsSql = "INSERT INTO txnItems (txnID, itemID, quantity, notes) VALUES ";

                    foreach (DataGridViewRow row in dgvSiteInventory.Rows)
                    {
                        if (row.Cells["itemID"].Value != null && !string.IsNullOrEmpty(row.Cells["itemID"].Value.ToString()))
                        {
                            int itemID = Convert.ToInt32(row.Cells["itemID"].Value);
                            int quantity = HelperMethods.GetItemQuantity(row.Cells["itemQuantity"].Value.ToString());

                            txnItemsSql += $"(@txnID, @itemID{itemID}, @quantity{itemID}, @notes{itemID}),";
                            txnItemsParameters.Add(new MySqlParameter($"@itemID{itemID}", itemID));
                            txnItemsParameters.Add(new MySqlParameter($"@quantity{itemID}", quantity));
                            txnItemsParameters.Add(new MySqlParameter($"@notes{itemID}", DBNull.Value));

                            string inventorySql;

                            inventorySql = @"
                                INSERT INTO inventory (itemID, siteID, quantity, itemLocation, reorderThreshold, optimumThreshold, notes)
                                VALUES (@itemID, @siteID, @quantity, @itemLocation, @reorderThreshold, @optimumThreshold, @notes)
                                ON DUPLICATE KEY UPDATE
                                itemID = @itemID,
                                siteID = @siteID,
                                quantity = @quantity,
                                itemLocation = @itemLocation,
                                reorderThreshold = @reorderThreshold,
                                optimumThreshold = @optimumThreshold,
                                notes = @notes";

                            int? reorderThreshold = null;
                            if (row.Cells["reorderThreshold"].Value != null && !string.IsNullOrEmpty(row.Cells["reorderThreshold"].Value.ToString()))
                            {
                                reorderThreshold = int.Parse(row.Cells["reorderThreshold"].Value.ToString());
                            }

                            List<MySqlParameter> inventoryParameters = new List<MySqlParameter>
                            {
                                new MySqlParameter("@itemID", itemID),
                                new MySqlParameter("@siteID", theSite.SiteID),
                                new MySqlParameter("@quantity", initialDispatch.FirstOrDefault(inv => inv.ItemID == itemID).Quantity),
                                new MySqlParameter("@itemLocation", int.Parse(txtOrderID.Text)),
                                new MySqlParameter("@reorderThreshold", reorderThreshold.HasValue ? reorderThreshold : DBNull.Value),
                                new MySqlParameter("@optimumThreshold", int.Parse(row.Cells["optimumThreshold"].Value.ToString())),
                                new MySqlParameter("@notes", DBNull.Value)
                            };

                            InventoryAccessor.AddUpdateInventory(inventorySql, inventoryParameters);
                        }
                    }
                }
                else
                {
                    string updateSql = "UPDATE txnItems SET quantity = @quantity WHERE itemID = @itemID AND txnID = @txnID";

                    foreach(DataGridViewRow row in dgvSiteInventory.Rows)
                    {
                        if (row.Cells["itemID"].Value != null && !string.IsNullOrEmpty(row.Cells["itemID"].Value.ToString()))
                        {
                            int itemID = Convert.ToInt32(row.Cells["itemID"].Value);
                            int quantity = HelperMethods.GetItemQuantity(row.Cells["itemQuantity"].Value.ToString());

                            if(!editInv.Any(item => item.ItemID == itemID))
                            {
                                string insertSql = "INSERT INTO txnItems (txnID, itemID, quantity, notes) VALUES " +
                                                   "(@txnID, @itemID, @quantity, @notes)";
                                List<MySqlParameter> txnItemInsert = new List<MySqlParameter>
                                {
                                    new MySqlParameter("@txnID", this.Data.TxnID),
                                    new MySqlParameter("@itemID", itemID),
                                    new MySqlParameter("@quantity", quantity),
                                    new MySqlParameter("@notes", DBNull.Value)
                                };

                                TransactionItemsAccessor.AddUpdateTransactionItems(insertSql, txnItemInsert);

                                string inventorySql = @"
                                    INSERT INTO inventory (itemID, siteID, quantity, itemLocation, reorderThreshold, optimumThreshold, notes)
                                    VALUES (@itemID, @siteID, @quantity, @itemLocation, @reorderThreshold, @optimumThreshold, @notes)
                                    ON DUPLICATE KEY UPDATE
                                    itemID = @itemID,
                                    siteID = @siteID,
                                    quantity = @quantity,
                                    itemLocation = @itemLocation,
                                    reorderThreshold = @reorderThreshold,
                                    optimumThreshold = @optimumThreshold,
                                    notes = @notes";

                                int? reorderThreshold = null;
                                if (row.Cells["reorderThreshold"].Value != null && !string.IsNullOrEmpty(row.Cells["reorderThreshold"].Value.ToString()))
                                {
                                    reorderThreshold = int.Parse(row.Cells["reorderThreshold"].Value.ToString());
                                }

                                List<MySqlParameter> inventoryParameters = new List<MySqlParameter>
                                {
                                    new MySqlParameter("@itemID", itemID),
                                    new MySqlParameter("@siteID", theSite.SiteID),
                                    new MySqlParameter("@quantity", initialDispatch.FirstOrDefault(inv => inv.ItemID == itemID).Quantity),
                                    new MySqlParameter("@itemLocation", this.Data.TxnID),
                                    new MySqlParameter("@reorderThreshold", reorderThreshold.HasValue ? reorderThreshold : DBNull.Value),
                                    new MySqlParameter("@optimumThreshold", int.Parse(row.Cells["optimumThreshold"].Value.ToString())),
                                    new MySqlParameter("@notes", DBNull.Value)
                                };

                                InventoryAccessor.AddUpdateInventory(inventorySql, inventoryParameters);
                            }
                            else
                            {
                                List<MySqlParameter> txnItemUpdate = new List<MySqlParameter>
                                {
                                    new MySqlParameter("@txnID", this.Data.TxnID),
                                    new MySqlParameter("@itemID", itemID),
                                    new MySqlParameter("@quantity", quantity),
                                };

                                TransactionItemsAccessor.AddUpdateTransactionItems(updateSql, txnItemUpdate);
                            }
                        }
                        
                    }
                }

                int auditID = HelperMethods.GetAuditID();
                TransactionAudit txnAudit;

                if (this.Data == null)
                {
                    txnItemsSql = txnItemsSql.TrimEnd(',');
                    TransactionItemsAccessor.AddUpdateTransactionItems(txnItemsSql, txnItemsParameters);

                    txnAudit = new TransactionAudit((int)auditID, int.Parse(txtOrderID.Text), txtOrderType.Text, "New",
                        DateTime.Now, theSite.SiteID, null, $"Order placed by {theEmployee.FirstName} {theEmployee.LastName}");
                }
                else
                {
                    txnAudit = new TransactionAudit((int)auditID, int.Parse(txtOrderID.Text), txtOrderType.Text, "New",
                       DateTime.Now, theSite.SiteID, null, $"Order editted by {theEmployee.FirstName} {theEmployee.LastName}");
                }

                txnAudit.CommitTransactionAudit();

                if (removedInv.Count > 0 && this.Data != null)
                {
                    string deleteInvSql = @"
                        DELETE FROM inventory 
                        WHERE itemID = @itemID 
                            AND siteID = @siteID 
                            AND itemLocation = @itemLocation";

                    string deleteTxnItemsSql = @"
                        DELETE FROM txnItems 
                        WHERE itemID = @itemID 
                            AND txnID = @txnID";

                    foreach (TransactionItems ti in removedInv)
                    {
                        List<MySqlParameter> deleteInvParameters = new List<MySqlParameter>
                        {
                            new MySqlParameter("@itemID", ti.ItemID),
                            new MySqlParameter("@siteID", theSite.SiteID),
                            new MySqlParameter("@itemLocation", this.Data.TxnID)
                        };

                        InventoryAccessor.AddUpdateInventory(deleteInvSql, deleteInvParameters);

                        List<MySqlParameter> deleteTxnItemsParameters = new List<MySqlParameter>
                        {
                            new MySqlParameter("@itemID", ti.ItemID),
                            new MySqlParameter("@txnID", this.Data.TxnID)
                        };

                        InventoryAccessor.AddUpdateInventory(deleteTxnItemsSql, deleteTxnItemsParameters);
                    }
                }

                orderSubmitted = true;

                this.Close();
            }
        }



        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearchOrder.Text.Trim();

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                // Iterate through rows and filter based on search keyword in specified columns
                foreach (DataGridViewRow row in dgvSiteInventory.Rows)
                {
                    string name = row.Cells["name"].Value.ToString();
                    string itemID = row.Cells["itemID"].Value.ToString();

                    // Check if the name or itemID contains the search keyword
                    if (name.Contains(searchKeyword) || itemID.Contains(searchKeyword))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
            else
            {
                // If search keyword is empty, show all rows
                foreach (DataGridViewRow row in dgvSiteInventory.Rows)
                {
                    row.Visible = true;
                }
            }
        }
    }
}
