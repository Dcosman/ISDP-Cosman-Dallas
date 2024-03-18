using ISDP_Cosman_Dallas.Accessors;
using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;

namespace ISDP_Cosman_Dallas
{
    public partial class frmFulfillStoreOrder : Form
    {
        Employee theEmployee;
        Site theSite;
        List<Inventory> siteOrder = new List<Inventory>();
        bool autoGenerating = true;
        bool fulfilled = false;
        bool backOrder = false;

        public Transaction Data { get; set; }

        public frmFulfillStoreOrder()
        {
            InitializeComponent();
        }

        private void frmFulfillStoreOrder_Load(object sender, EventArgs e)
        {
            theEmployee = this.Tag as Employee;

            siteOrder = InventoryAccessor.GetInventoryByLocation(this.Data.TxnID.ToString());

            if (siteOrder.Count == 0)
            {
                backOrder = true;
                List<TransactionItems> txns = TransactionItemsAccessor.GetTransactionItemsById(this.Data.TxnID);
                foreach (TransactionItems item in txns)
                {
                    Transaction txn = TransactionAccessor.GetTransactionByTxnID(this.Data.TxnID);
                    int site = txn.SiteIDTo;

                    Inventory inv = InventoryAccessor.GetInventoryByItemIDAndSiteID(item.ItemID, Constants.WAREHOUSE_SITE);

                    siteOrder.Add(inv);
                }
            }

            theSite = SiteAccessor.GetSiteByID(this.Data.SiteIDTo);

            foreach (Inventory inv in siteOrder)
            {
                int rowIndex = dgvOrder.Rows.Add();
                TransactionItems txnItem = TransactionItemsAccessor.GetTransactionItemByItemId(inv.ItemID);
                Item theItem = ItemAccessor.GetItemByID(inv.ItemID);

                int quantity;
                if (!backOrder)
                    quantity = inv.Quantity;
                else
                    quantity = InventoryAccessor.GetInventoryByItemIDAndSiteID(inv.ItemID, theEmployee.SiteID).Quantity;

                dgvOrder.Rows[rowIndex].Cells["itemID"].Value = inv.ItemID;
                dgvOrder.Rows[rowIndex].Cells["name"].Value = theItem.Name;
                dgvOrder.Rows[rowIndex].Cells["quantity"].Value = quantity;

                dgvOrder.Rows[rowIndex].Cells["optimumThreshold"].Value = inv.OptimumThreshold;

                if (inv.ReorderThreshold.HasValue)
                    dgvOrder.Rows[rowIndex].Cells["reorderThreshold"].Value = inv.ReorderThreshold;

                dgvOrder.Rows[rowIndex].Cells["itemQuantity"].Value = txnItem.Quantity +
                    $"({ItemAccessor.GetItemByID(inv.ItemID).CaseSize * txnItem.Quantity})";

                dgvOrder.Rows[rowIndex].Cells["quantityAssigned"].Value = 0;
            }
            dgvOrder.ClearSelection();
            autoGenerating = false;

            txtOrderID.Text = this.Data.TxnID.ToString();
            txtEmployee.Text = theEmployee.FirstName + " " + theEmployee.LastName;
            txtOrderType.Text = this.Data.TxnType.ToString();
            txtDispatch.Text = SiteAccessor.GetSiteByID(this.Data.SiteIDFrom).Name;
            txtSite.Text = SiteAccessor.GetSiteByID(this.Data.SiteIDTo).Name;
            txtShipDate.Text = this.Data.ShipDate.ToString();
            txtStatus.Text = this.Data.Status.ToString();
        }

        private void dgvOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0 && !autoGenerating)
            {
                DataGridViewRow selectedRow = dgvOrder.SelectedRows[0];

                string itemID = selectedRow.Cells["itemID"].Value.ToString();
                string itemName = selectedRow.Cells["name"].Value.ToString();
                string invQuantity = selectedRow.Cells["quantity"].Value.ToString();
                string optimumThreshold = selectedRow.Cells["optimumThreshold"].Value.ToString();
                string reorderThreshold = selectedRow.Cells["reorderThreshold"].Value?.ToString();
                string itemQuantity = selectedRow.Cells["itemQuantity"].Value.ToString();
                int quantityAssigned = int.Parse(selectedRow.Cells["quantityAssigned"].Value.ToString());

                txtItemID.Text = itemID;
                txtItemName.Text = itemName;
                txtItemStock.Text = invQuantity;
                txtItemThreshold.Text = optimumThreshold;
                txtQuantityOrdered.Text = itemQuantity;
                

                if (!string.IsNullOrEmpty(reorderThreshold))
                {
                    txtItemReorder.Text = reorderThreshold;
                }
                numQuantityAssigned.Enabled = true;
                btnFulfillItem.BackColor = Color.OrangeRed;
                btnFulfillItem.ForeColor = Color.White;
                numQuantityAssigned.Maximum = HelperMethods.GetItemQuantity(itemQuantity);
                numQuantityAssigned.Value = quantityAssigned;
            }
            else
            {
                numQuantityAssigned.Enabled = false;
                btnFulfillItem.BackColor = Color.White;
                btnFulfillItem.ForeColor = Color.OrangeRed;
            }
        }

        private void numQuantityAssigned_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFulfillItem_Click(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0 && btnFulfillItem.BackColor != Color.White)
            {
                DataGridViewRow selectedRow = dgvOrder.SelectedRows[0];
                selectedRow.Cells["quantityAssigned"].Value = numQuantityAssigned.Value;
                if (numQuantityAssigned.Value == HelperMethods.GetItemQuantity(txtQuantityOrdered.Text))
                {
                    selectedRow.DefaultCellStyle.BackColor = Color.PaleGreen;
                }
                else if (numQuantityAssigned.Value > 0)
                {
                    selectedRow.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#fef56a");
                }
                else
                {
                    selectedRow.DefaultCellStyle.BackColor = Color.Empty;
                }
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFulfillStoreOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!fulfilled)
            {
                DialogResult result = MessageBox.Show("Are you sure you would like to close the window?\nFulfilled items will not be saved.", "Confirm Close", MessageBoxButtons.YesNo);

                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnFulfillOrder_Click(object sender, EventArgs e)
        {
            if (VerifyFulfillment())
            {
                int txnID = this.Data.TxnID;
                string txnItemsSql = "UPDATE txnItems SET quantity = @quantity WHERE itemID = @itemID AND txnID = @txnID";
                List<MySqlParameter> txnItemsParameters = new List<MySqlParameter>();
                txnItemsParameters.Add(new MySqlParameter("@txnID", txnID));

                foreach (DataGridViewRow row in dgvOrder.Rows)
                {
                    if (row.Cells["itemID"].Value != null && !string.IsNullOrEmpty(row.Cells["itemID"].Value.ToString()))
                    {
                        int itemID = int.Parse(row.Cells["itemID"].Value.ToString());
                        int quantity = int.Parse(row.Cells["quantityAssigned"].Value.ToString());
                        txnItemsParameters.Add(new MySqlParameter($"@itemID", itemID));
                        txnItemsParameters.Add(new MySqlParameter($"@quantity", quantity));

                        TransactionItemsAccessor.AddUpdateTransactionItems(txnItemsSql, txnItemsParameters);
                        txnItemsParameters.Clear();
                        txnItemsParameters.Add(new MySqlParameter($"@txnID", txnID));
                    }
                }
                string txnSql = "UPDATE txn SET status = @status WHERE txnID = @txnID";
                List<MySqlParameter> txnParameters = new List<MySqlParameter>
                {
                    new MySqlParameter($"@status", "Delivered"), //Set for testing, needs assembled
                    new MySqlParameter($"@txnID", txnID)
                };

                int auditID = HelperMethods.GetAuditID();

                TransactionAudit txnAudit = new TransactionAudit((int)auditID, this.Data.TxnID,
                    this.Data.TxnType, "Assembled", DateTime.Now, theEmployee.SiteID, null,
                    $"Order fulfilled by {theEmployee.FirstName} {theEmployee.LastName}");

                txnAudit.CommitTransactionAudit();

                TransactionAccessor.AddUpdateTransaction(txnSql, txnParameters);

                foreach (DataGridViewRow row in dgvOrder.Rows)
                {
                    if (row.Cells["itemID"].Value != null && !string.IsNullOrEmpty(row.Cells["itemID"].Value.ToString()))
                    {
                        int itemID = Convert.ToInt32(row.Cells["itemID"].Value);
                        int quantity = HelperMethods.GetItemQuantity(row.Cells["itemQuantity"].Value.ToString());
                        Inventory siteInv = InventoryAccessor.GetInventoryByItemIDAndSiteID(itemID,theSite.SiteID);
                        string inventorySql;

                        if (backOrder)
                        {
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
                        }
                        else
                        {
                            inventorySql = @"
                                UPDATE inventory 
                                SET quantity = @quantity
                                WHERE itemID = @itemID 
                                AND siteID = @siteID 
                                AND itemLocation = @itemLocation";
                        }

                        List<MySqlParameter> inventoryParameters = new List<MySqlParameter>
                        {
                            new MySqlParameter("@itemID", itemID),
                            new MySqlParameter("@siteID", theSite.SiteID),
                            new MySqlParameter("@quantity", quantity),
                            new MySqlParameter("@itemLocation", txnID)
                        };

                        if(backOrder)
                        {
                            inventoryParameters.Add(new MySqlParameter("@reorderThreshold", siteInv.ReorderThreshold.HasValue ? siteInv.ReorderThreshold : DBNull.Value));
                            inventoryParameters.Add(new MySqlParameter("@optimumThreshold", siteInv.OptimumThreshold));
                            inventoryParameters.Add(new MySqlParameter("@notes", DBNull.Value));
                        }

                        InventoryAccessor.AddUpdateInventory(inventorySql, inventoryParameters);
                    }
                }

                fulfilled = true;
                this.Close();
            }
        }

        private bool VerifyFulfillment()
        {
            bool result = true;
            int missedFulfill = 0;
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                if (row.Cells["itemID"].Value != null && !string.IsNullOrEmpty(row.Cells["itemID"].Value.ToString()))
                {
                    int quantity = int.Parse(row.Cells["quantityAssigned"].Value.ToString());
                    if (quantity < 1)
                    {
                        missedFulfill++;
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
            if (missedFulfill > 0)
            {
                DialogResult dr = MessageBox.Show($"There are {missedFulfill} items that have not been fulfilled\nWould you still like to submit the order?", "Confirm Fulfill", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    result = true;

                    DateTime today = DateTime.Today;
                    DayOfWeek shipDayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), theSite.DayOfWeek, true);
                    DateTime shipDate = today.AddDays((shipDayOfWeek - today.DayOfWeek + 7) % 7);

                    string txnSql;
                    List<Transaction> backOrder = TransactionAccessor.GetBackOrder(theSite.SiteID);
                    int backOrderID;
                    if (backOrder.Count == 0)
                    {
                        backOrderID = HelperMethods.GetNewID("select max(txnID) from txn");

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

                        List<MySqlParameter> txnParameters = new List<MySqlParameter>
                        {
                            new MySqlParameter("@siteIDTo", theSite.SiteID),
                            new MySqlParameter("@siteIDFrom", Constants.WAREHOUSE_SITE),
                            new MySqlParameter("@status", "Pending Back Order"),
                            new MySqlParameter("@shipDate", shipDate),
                            new MySqlParameter("@txnType", "Back Order"),
                            new MySqlParameter("@barCode", Constants.ORDER_BARCODE),
                            new MySqlParameter("@createdDate", DateTime.Now),
                            new MySqlParameter("@deliveryID", DBNull.Value),
                            new MySqlParameter("@emergencyDelivery", null),
                            new MySqlParameter("@notes", null),
                            new MySqlParameter("@txnID", backOrderID)
                        };

                        TransactionAccessor.AddUpdateTransaction(txnSql, txnParameters);

                        string txnItemsSql;

                        txnItemsSql = "INSERT INTO txnItems (txnID, itemID, quantity, notes) VALUES ";

                        List<MySqlParameter> txnItemsParameters = new List<MySqlParameter>();

                        txnItemsParameters.Add(new MySqlParameter("@txnID", backOrderID));

                        foreach (DataGridViewRow row in dgvOrder.Rows)
                        {
                            if (row.Cells["itemID"].Value != null && !string.IsNullOrEmpty(row.Cells["itemID"].Value.ToString()))
                            {
                                int itemID = Convert.ToInt32(row.Cells["itemID"].Value);
                                int quantity =
                                    HelperMethods.GetItemQuantity(row.Cells["itemQuantity"].Value.ToString()) - int.Parse(row.Cells["quantityAssigned"].Value.ToString());

                                if (quantity > 0)
                                {
                                    txnItemsSql += $"(@txnID, @itemID{itemID}, @quantity{itemID}, @notes{itemID}),";
                                    txnItemsParameters.Add(new MySqlParameter($"@itemID{itemID}", itemID));
                                    txnItemsParameters.Add(new MySqlParameter($"@quantity{itemID}", quantity));
                                    txnItemsParameters.Add(new MySqlParameter($"@notes{itemID}", DBNull.Value));
                                }
                            }
                        }

                        txnItemsSql = txnItemsSql.TrimEnd(',');
                        TransactionItemsAccessor.AddUpdateTransactionItems(txnItemsSql, txnItemsParameters);
                    }
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                row.Visible = true;

                if (!chkFulfilled.Checked && row.DefaultCellStyle.BackColor == Color.PaleGreen)
                {
                    row.Visible = false;
                }
                if (!chkPartialFulfill.Checked && row.DefaultCellStyle.BackColor == ColorTranslator.FromHtml("#fef56a"))
                {
                    row.Visible = false;
                }
                if (!chkUnfulfilled.Checked && (row.DefaultCellStyle.BackColor == Color.Red || row.DefaultCellStyle.BackColor == Color.Empty))
                {
                    row.Visible = false;
                }

                bool nameMatch = row.Cells["name"].Value.ToString().ToLower().Contains(txtSearchOrder.Text.ToLower());
                bool idMatch = row.Cells["itemID"].Value.ToString().Contains(txtSearchOrder.Text);

                if ((!nameMatch && !idMatch) && row.Visible == true)
                {
                    row.Visible = false;
                }
            }
        }
    }
}
