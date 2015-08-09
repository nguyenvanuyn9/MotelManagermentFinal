using MotelManage.BusinessLogicTier;
using MotelManage.DataTransferObject;
using System;
using System.Windows.Forms;

namespace MotelManage.PresentationTier
{
    public partial class ServiceList : Form
    {
        private ServiceBLT serviceBLT;
        private string serviceIdPrevFocus;
        public ServiceList()
        {
            InitializeComponent();
            txtUnit.KeyPress += TxtMoney_KeyPress;
            txtPrice.KeyPress += TxtMoney_KeyPress;
            Load += ServiceList_Load;
            dgvService.SelectionChanged += DgvService_SelectionChanged;

            this.resetUI();

            this.serviceBLT = new ServiceBLT();
            this.dgvService.DataSource = serviceBLT.getListService();
        }

        private void TxtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void ServiceList_Load(object sender, EventArgs e)
        {
        }

        private void DgvService_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = (sender as DataGridView).CurrentRow;
            if (row != null && serviceIdPrevFocus != row.Cells["clID"].Value.ToString())
            {
                serviceIdPrevFocus = txtId.Text = row.Cells["clID"].Value.ToString();
                txtName.Text = row.Cells["clName"].Value.ToString();
                txtUnit.Text = row.Cells["clUnit"].Value.ToString();
                txtPrice.Text = row.Cells["clPrice"].Value.ToString();

                this.changeModeEditUI(false);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (btnSearch.Text == "Reset")
            {
                this.resetUI();
                this.changeModeEditUI(true);
            }
            else
            {
                Service rt = new Service()
                {
                    Id = txtId.Text.Trim(),
                    Name = txtName.Text.Trim(),
                    Price = decimal.Parse(txtPrice.Text.Trim() == "" ? "0" : txtPrice.Text.Trim()),
                    Unit = txtUnit.Text.Trim()
                };

                this.dgvService.DataSource = serviceBLT.searchService(rt);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ServiceEdit ServiceEdit = new ServiceEdit();
            ServiceEdit.EditCompletedHandler += FormServiceEdit_Completed;
            ServiceEdit.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("You don't choose a service to edit!", "Infomations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Service rt = new Service()
                {
                    Id = txtId.Text,
                    Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text.Trim()),
                    Unit = txtUnit.Text.Trim()
                };

                ServiceEdit ServiceEdit = new ServiceEdit(rt);
                ServiceEdit.EditCompletedHandler += FormServiceEdit_Completed;
                ServiceEdit.ShowDialog();
            }
        }

        private void FormServiceEdit_Completed(String ServiceId)
        {
            dgvService.DataSource = serviceBLT.getListService();
            dgvService.ClearSelection();

            foreach (DataGridViewRow row in dgvService.Rows)
            {
                if (row.Cells["clID"].Value.ToString().Equals(ServiceId))
                {
                    dgvService.Rows[row.Index].Selected = true;
                    break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("You don't choose a service to delete!", "Infomations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Do you realy want to delete " + txtId.Text + "?\n\nPress Yes to delete, No to cancel.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool flag = serviceBLT.deleteService(txtId.Text);
                    if (flag == true)
                    {
                        this.resetUI();
                        this.changeModeEditUI(true);
                        this.dgvService.DataSource = serviceBLT.getListService();
                        MessageBox.Show("Deleted " + txtId.Text.ToUpper() + " successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Deleted " + txtId.Text.ToUpper() + " fail!\n\nNot found " + txtId.Text.Trim().ToUpper() + " to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.resetUI();
            this.changeModeEditUI(true);
            this.dgvService.DataSource = serviceBLT.getListService();
        }

        private void resetUI()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtUnit.Text = "";
            txtPrice.Text = "0";
        }

        private void changeModeEditUI(bool isCanEdit)
        {
            txtId.ReadOnly = !isCanEdit;
            txtName.ReadOnly = !isCanEdit;
            txtUnit.ReadOnly = !isCanEdit;
            txtPrice.ReadOnly = !isCanEdit;
            btnEdit.Enabled = !isCanEdit;
            btnDelete.Enabled = !isCanEdit;
            if (isCanEdit)
                this.btnSearch.Text = "Search";
            else
                this.btnSearch.Text = "Reset";
        }
    }
}
