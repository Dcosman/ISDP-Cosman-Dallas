using ISDP_Cosman_Dallas.Accessors;
using ISDP_Cosman_Dallas.Models;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ISDP_Cosman_Dallas
{
    public partial class frmEditTxn : Form
    {
        Transaction theTxn;
        bool submitted = false;

        public Employee Data { get; set; }

        public frmEditTxn()
        {
            InitializeComponent();
        }

        private void frmEditTxn_Load(object sender, EventArgs e)
        {
            dgvDelivery.AutoGenerateColumns = false;

            theTxn = this.Tag as Transaction;

            cboSiteTo.Items.Clear();
            cboSiteFrom.Items.Clear();
            cboTxnType.Items.Clear();
            cboStatus.Items.Clear();

            List<TransactionStatus> statuses = TransactionStatusAccessor.GetAllTransactionStatus();
            List<TransactionType> txnTypes = TransactionAccessor.GetTransactionTypes();
            List<Site> sites = SiteAccessor.GetAllSites();

            foreach (Site site in sites)
            {
                cboSiteTo.Items.Add(site.Name);
                cboSiteFrom.Items.Add(site.Name);
            }

            foreach (TransactionType txnType in txnTypes)
            {
                cboTxnType.Items.Add(txnType.TxnType);
            }

            foreach (TransactionStatus status in statuses)
            {
                cboStatus.Items.Add(status.StatusName);
            }

            cboSiteTo.SelectedIndex = cboSiteTo.FindStringExact(SiteAccessor.GetSiteByID(theTxn.SiteIDTo).Name);
            cboSiteFrom.SelectedIndex = cboSiteFrom.FindStringExact(SiteAccessor.GetSiteByID(theTxn.SiteIDFrom).Name);
            cboTxnType.SelectedIndex = cboTxnType.FindStringExact(theTxn.TxnType);
            cboStatus.SelectedIndex = cboStatus.FindStringExact(theTxn.Status);

            txtTxnID.Text = theTxn.TxnID.ToString();
            txtDeliveryID.Text = theTxn.DeliveryID.ToString();
            txtBarCode.Text = theTxn.BarCode.ToString();
            txtCreateDate.Text = theTxn.CreatedDate.ToString();
            dtpShipDate.Value = theTxn.ShipDate;

            if (theTxn.Notes != null)
                txtTxnNotes.Text = theTxn.Notes.ToString();

            if (theTxn.EmergencyDelivery != null && theTxn.EmergencyDelivery == true)
                chkEmergency.Checked = true;
            else if (theTxn.EmergencyDelivery == null)
                chkEmergency.Enabled = false;
        }

        private void btnCancelTxn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditTxn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!submitted)
            {
                DialogResult result = MessageBox.Show("Are you sure you would like to close the window?\nThe transaction will not be saved.", "Confirm Close", MessageBoxButtons.YesNo);

                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnSaveTxn_Click(object sender, EventArgs e)
        {
            if (VerifyFields())
            {
                string txnSql = @"
                    UPDATE txn 
                    SET siteIDTo = @siteIDTo,
                        siteIDFrom = @siteIDFrom,
                        status = @status,
                        shipDate = @shipDate,
                        txnType = @txnType,
                        barCode = @barCode,
                        deliveryID = @deliveryID,
                        emergencyDelivery = @emergencyDelivery
                    WHERE txnID = @txnID";

                MySqlParameter emgParameter;

                if (chkEmergency.Enabled)
                {
                    emgParameter = new MySqlParameter("@emergencyDelivery", chkEmergency.Checked);
                }
                else
                {
                    emgParameter = new MySqlParameter("@emergencyDelivery", DBNull.Value);
                }

                MySqlParameter delParameter;
                int? delivery;

                if (string.IsNullOrEmpty(txtDeliveryID.Text))
                {
                    delParameter = new MySqlParameter("@deliveryID", DBNull.Value);
                    delivery = null;
                }
                else
                {
                    delParameter = new MySqlParameter("@deliveryID", txtDeliveryID.Text);
                    delivery = int.Parse(txtDeliveryID.Text);
                }

                List<MySqlParameter> txnParameters = new List<MySqlParameter>
                {
                    new MySqlParameter("@siteIDTo", SiteAccessor.GetSiteByName(cboSiteTo.Text).SiteID),
                    new MySqlParameter("@siteIDFrom", SiteAccessor.GetSiteByName(cboSiteFrom.Text).SiteID),
                    new MySqlParameter("@status", cboStatus.Text),
                    new MySqlParameter("@shipDate", dtpShipDate.Value),
                    new MySqlParameter("@txnType", cboTxnType.Text),
                    new MySqlParameter("@barCode", txtBarCode.Text),
                    delParameter,
                    emgParameter,
                    new MySqlParameter("@txnID", int.Parse(txtTxnID.Text))
                };

                TransactionAccessor.AddUpdateTransaction(txnSql, txnParameters);

                submitted = true;

                int auditID = HelperMethods.GetAuditID();
                TransactionAudit txnAudit;

                txnAudit = new TransactionAudit((int)auditID, int.Parse(txtTxnID.Text), cboTxnType.Text, cboStatus.Text,
                       DateTime.Now, this.Data.SiteID, delivery, $"Transaction editted by {this.Data.FirstName} {this.Data.LastName}");

                txnAudit.CommitTransactionAudit();

                this.Close();
            }
        }

        private bool VerifyFields()
        {
            string pattern = @"^\d{12,50}$";
            bool valid = true;

            lblErrBarCode.Visible = false;
            lblErrFrom.Visible = false;
            lblErrTo.Visible = false;
            lblErrBarCode.Visible = false;

            if (cboSiteTo.Text == cboSiteFrom.Text)
            {
                valid = false;
                lblErrTo.Visible = true;
                lblErrFrom.Visible = true;
            }
            if (!Regex.IsMatch(txtBarCode.Text, pattern))
            {
                valid = false;
                lblErrBarCode.Visible = true;
            }

            if (!valid)
            {
                lblModifyError.Visible = true;
            }

            return valid;
        }

        private void txtDeliveryID_Click(object sender, EventArgs e)
        {
            grpDeliveryID.Visible = true;
            pnlEdit.Visible = false;
            List<Delivery> deliveries = DeliveryAccessor.GetAllDeliveries();

            foreach (Delivery delivery in deliveries)
            {
                int rowIndex = dgvDelivery.Rows.Add();

                dgvDelivery.Rows[rowIndex].Cells["DeliveryID"].Value = delivery.DeliveryID;
                dgvDelivery.Rows[rowIndex].Cells["DistanceCost"].Value = delivery.DistanceCost;
                dgvDelivery.Rows[rowIndex].Cells["VehicleType"].Value = delivery.VehicleType;
            }
        }

        private void btnCancelSelect_Click(object sender, EventArgs e)
        {
            HideDeliverySelect();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvDelivery.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDelivery.SelectedRows[0];

                string deliveryID = selectedRow.Cells["deliveryID"].Value.ToString();

                txtDeliveryID.Text = deliveryID;

                HideDeliverySelect();
            }
        }

        private void HideDeliverySelect()
        {
            grpDeliveryID.Visible = false;
            pnlEdit.Visible = true;
            dgvDelivery.Rows.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HideDeliverySelect();
            txtDeliveryID.Text = "";
        }
    }
}
