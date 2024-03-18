using ISDP_Cosman_Dallas.Accessors;
using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace ISDP_Cosman_Dallas
{
    public partial class frmBackOrder : Form
    {
        Employee theEmployee;
        int backOrderID;
        bool autoGenerating = true;
        bool orderSubmitted = false;
        List<TransactionItems> orderItems = new List<TransactionItems>();

        public Transaction Data { get; set; }

        public frmBackOrder()
        {
            InitializeComponent();
        }

        private void frmBackOrder_Load(object sender, EventArgs e)
        {
            theEmployee = this.Tag as Employee;
            dgvItems.AutoGenerateColumns = false;
            if (this.Data == null)
            {
                backOrderID = HelperMethods.GetNewID("select max(txnID) from txn");

                PopulateOrderInfo();

                cboOrderLocation.SelectedIndex = 0;

                DateTime today = DateTime.Today;
                DayOfWeek shipDayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), SiteAccessor.GetSiteByName(cboOrderLocation.Text).DayOfWeek, true);
                DateTime shipDate = today.AddDays((shipDayOfWeek - today.DayOfWeek + 7) % 7);

                dtpOrderShipDate.Value = shipDate;
                autoGenerating = false;


            }
            else
            {
                backOrderID = this.Data.TxnID;

                PopulateOrderInfo();

                cboOrderLocation.Text = SiteAccessor.GetSiteByID(this.Data.SiteIDTo).Name;
                cboOrderLocation.Enabled = false;

                dtpOrderShipDate.Value = this.Data.ShipDate;

                orderItems = TransactionItemsAccessor.GetTransactionItemsById(backOrderID);
                MessageBox.Show(orderItems[0].ItemID.ToString() + " " + orderItems.Last().ItemID.ToString());

                PopulateOrder(orderItems);
            }

            PopulateItems();

            foreach (DataGridViewColumn column in dgvOrder.Columns)
            {
                if (column.Name != "ItemQuantity")
                {
                    column.ReadOnly = true;
                }
            }

            dgvOrder.Columns["itemQuantity"].ReadOnly = false;
        }

        private void cboOrderLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!autoGenerating)
            {
                DateTime today = DateTime.Today;
                DayOfWeek shipDayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), SiteAccessor.GetSiteByName(cboOrderLocation.Text).DayOfWeek, true);
                DateTime shipDate = today.AddDays((shipDayOfWeek - today.DayOfWeek + 7) % 7);

                dtpOrderShipDate.Value = shipDate;
            }
        }

        private void PopulateOrderInfo()
        {
            txtOrderID.Text = backOrderID.ToString();
            txtEmployee.Text = theEmployee.FirstName + " " + theEmployee.LastName;
            txtDispatch.Text = SiteAccessor.GetSiteByID(Constants.WAREHOUSE_SITE).Name;

            cboOrderLocation.Items.Clear();

            List<Site> sites = SiteAccessor.GetAllSites();

            foreach (Site site in sites)
            {
                cboOrderLocation.Items.Add(site.Name);
            }
        }

        private void PopulateItems()
        {
            List<Item> items = ItemAccessor.GetAllItems();

            foreach (Item item in items)
            {
                int rowIndex = dgvItems.Rows.Add();

                dgvItems.Rows[rowIndex].Cells["ItemID"].Value = item.ItemID;
                dgvItems.Rows[rowIndex].Cells["name"].Value = item.Name;
                dgvItems.Rows[rowIndex].Cells["caseSize"].Value = item.CaseSize;
            }
        }

        private void PopulateOrder(List<TransactionItems> inItems)
        {
            dgvOrder.Rows.Clear();
            foreach (TransactionItems item in inItems)
            {
                int rowIndex = dgvOrder.Rows.Add();
                Item theItem = ItemAccessor.GetItemByID(item.ItemID);
                dgvOrder.Rows[rowIndex].Cells["id"].Value = item.ItemID;
                dgvOrder.Rows[rowIndex].Cells["itemName"].Value = ItemAccessor.GetItemByID(item.ItemID).Name;
                dgvOrder.Rows[rowIndex].Cells["itemQuantity"].Value = item.Quantity + $"({theItem.CaseSize * item.Quantity})";
            }
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            SearchDGV(dgvItems, txtSearchItem.Text.ToLower());
        }

        private void SearchDGV(DataGridView inDGV, string inText)
        {
            foreach (DataGridViewRow row in inDGV.Rows)
            {
                string name = row.Cells["name"].Value.ToString().ToLower();
                string id = row.Cells["itemID"].Value.ToString();
                if (!name.Contains(inText) && !id.Contains(inText))
                {
                    row.Visible = false;
                }
                else if (!row.Visible)
                {
                    row.Visible = true;
                }
            }

        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0 && numQuantity.Value > 0)
            {
                if (dgvItems.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvItems.SelectedRows[0];
                    Item theItem = ItemAccessor.GetItemByID(int.Parse(selectedRow.Cells["ItemID"].Value.ToString()));

                    DataGridViewRow existingRow = dgvOrder.Rows.Cast<DataGridViewRow>()
                                          .FirstOrDefault(row => Convert.ToInt32(row.Cells["id"].Value) == theItem.ItemID);

                    TransactionItems existingItem = orderItems.FirstOrDefault(item => item.ItemID == theItem.ItemID);
                    if (existingRow != null)
                    {
                        int newQuantity = (int)numQuantity.Value + HelperMethods.GetItemQuantity(existingRow.Cells["itemQuantity"].Value.ToString());
                        existingRow.Cells["itemQuantity"].Value = newQuantity + $"({newQuantity * theItem.CaseSize})";
                    }
                    else
                    {
                        int rowIndex = dgvOrder.Rows.Add();
                        dgvOrder.Rows[rowIndex].Cells["id"].Value = theItem.ItemID;
                        dgvOrder.Rows[rowIndex].Cells["itemName"].Value = theItem.Name;
                        dgvOrder.Rows[rowIndex].Cells["itemQuantity"].Value = numQuantity.Value + $"({numQuantity.Value * theItem.CaseSize})";
                    }
                }
            }
        }

        private void btnConfirmBackOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm Back Order?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
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
                    new MySqlParameter("@siteIDTo", SiteAccessor.GetSiteByName(cboOrderLocation.Text).SiteID),
                    new MySqlParameter("@siteIDFrom", Constants.WAREHOUSE_SITE),
                    new MySqlParameter("@status", "Pending Back Order"),
                    new MySqlParameter("@shipDate", dtpOrderShipDate.Value),
                    new MySqlParameter("@txnType", "Back Order"),
                    new MySqlParameter("@barCode", Constants.ORDER_BARCODE),
                    new MySqlParameter("@deliveryID", DBNull.Value),
                    new MySqlParameter("@emergencyDelivery", null),
                    new MySqlParameter("@notes", null),
                    new MySqlParameter("@txnID", int.Parse(txtOrderID.Text))
                };

                if (this.Data == null)
                {
                    txnParameters.Add(new MySqlParameter("@createdDate", DateTime.Now));
                }

                TransactionAccessor.AddUpdateTransaction(txnSql, txnParameters);

                string txnItemsSql;

                if (this.Data == null)
                    txnItemsSql = "INSERT INTO txnItems (txnID, itemID, quantity, notes) VALUES ";
                else
                    txnItemsSql = "UPDATE txnItems SET quantity = @quantity WHERE itemID = @itemID AND txnID = @txnID";

                List<MySqlParameter> txnItemsParameters = new List<MySqlParameter>();

                txnItemsParameters.Add(new MySqlParameter("@txnID", int.Parse(txtOrderID.Text)));

                foreach (DataGridViewRow row in dgvOrder.Rows)
                {
                    if (row.Cells["id"].Value != null && !string.IsNullOrEmpty(row.Cells["id"].Value.ToString()))
                    {
                        int itemID = Convert.ToInt32(row.Cells["id"].Value);
                        int quantity = HelperMethods.GetItemQuantity(row.Cells["itemQuantity"].Value.ToString());

                        if (this.Data == null)
                        {
                            txnItemsSql += $"(@txnID, @itemID{itemID}, @quantity{itemID}, @notes{itemID}),";
                            txnItemsParameters.Add(new MySqlParameter($"@itemID{itemID}", itemID));
                            txnItemsParameters.Add(new MySqlParameter($"@quantity{itemID}", quantity));
                            txnItemsParameters.Add(new MySqlParameter($"@notes{itemID}", DBNull.Value));
                        }
                        else
                        {
                            txnItemsParameters.Add(new MySqlParameter($"@itemID", itemID));
                            txnItemsParameters.Add(new MySqlParameter($"@quantity", quantity));

                            TransactionItemsAccessor.AddUpdateTransactionItems(txnItemsSql, txnItemsParameters);
                            txnItemsParameters.Clear();
                            txnItemsParameters.Add(new MySqlParameter("@txnID", int.Parse(txtOrderID.Text)));
                        }
                    }
                }

                if(this.Data == null)
                {
                    txnItemsSql = txnItemsSql.TrimEnd(',');
                    TransactionItemsAccessor.AddUpdateTransactionItems(txnItemsSql, txnItemsParameters);
                }

                orderSubmitted = true;
                this.Close();
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBackOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!orderSubmitted)
            {
                DialogResult result = MessageBox.Show("Are you sure you would like to cancel?\nOrder will not be saved.", "Cancel Back Order", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
