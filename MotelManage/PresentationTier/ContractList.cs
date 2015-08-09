using MotelManage.BusinessLogicTier;
using MotelManage.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MotelManage.PresentationTier
{
    public partial class ContractList : Form
    {
        private ServiceNoteBLT serviceNoteBLT;
        private ContractBLT contractBLT;
        private RoomBLT roomBLT;

        private string contractIdPrevFocus;
        public ContractList()
        {
            InitializeComponent();

            dateTimePickerDateBegin.MaxDate = DateTime.Now;
            dgvContract.AutoGenerateColumns = false;
            txtPriceRoom.KeyPress += TxtMoney_KeyPress;
            Load += ContractList_Load;
            dgvContract.SelectionChanged += DgvContract_SelectionChanged;

            this.resetUI();

            this.serviceNoteBLT = new ServiceNoteBLT();
            this.contractBLT = new ContractBLT();
            this.roomBLT = new RoomBLT();

            cmbContractStatus.DataSource = new List<ContractStatus>()
            {
                new ContractStatus()
                {
                    Value = false,
                    Display = "InValid"
                },
                new ContractStatus()
                {
                    Value = true,
                    Display = "Valid"
                }
            };
            cmbContractStatus.DisplayMember = "Display";
            cmbContractStatus.ValueMember = "Value";

            cmbRoom.DataSource = roomBLT.getListRoom();
            cmbRoom.DisplayMember = "NAME";
            cmbRoom.ValueMember = "ID";

            dgvContract.DataSource = contractBLT.getListContract();
        }

        private void ContractList_Load(object sender, EventArgs e)
        {
        }

        private void DgvContract_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = (sender as DataGridView).CurrentRow;
            if (row != null && contractIdPrevFocus != row.Cells["clID"].Value.ToString())
            {
                contractIdPrevFocus = txtId.Text = row.Cells["clID"].Value.ToString();
                dateTimePickerDateBegin.Text = DateTime.Parse(row.Cells["clDateBegin"].Value.ToString()) > dateTimePickerDateBegin.MaxDate? dateTimePickerDateBegin.MaxDate.ToString(): row.Cells["clDateBegin"].Value.ToString();
                txtCustomerName.Text = row.Cells["clCustomerName"].Value.ToString();
                txtCustomerId.Text = (dgvContract.DataSource as DataTable).Rows[row.Index].Field<string>("CustomerId");
                txtPriceRoom.Text = row.Cells["clPriceRoom"].Value.ToString();
                txtNote.Text = row.Cells["clNote"].Value.ToString();
                
                cmbRoom.SelectedIndex = cmbRoom.FindStringExact(row.Cells["clRoomName"].Value.ToString());

                string tempContractStatus = row.Cells["clIsValid"].Value.ToString() == "True" ? "Valid" : "InValid";
                cmbContractStatus.SelectedIndex = cmbContractStatus.FindStringExact(tempContractStatus);

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
                Contract ctr = new Contract()
                {
                    Id = txtId.Text.Trim(),
                    Begindate = dateTimePickerDateBegin.Text,
                    Customerid = txtCustomerId.Text.Trim(),
                    IsValid = bool.Parse((cmbContractStatus.SelectedIndex < 0) ? "true" : cmbContractStatus.SelectedValue.ToString()),
                    Note=txtNote.Text,
                    Roomid= (cmbRoom.SelectedIndex < 0) ? "" : cmbRoom.SelectedValue.ToString(),
                    PriceRoom = decimal.Parse(txtPriceRoom.Text.Trim() == "" ? "0" : txtPriceRoom.Text.Trim())
                };

                this.dgvContract.DataSource = contractBLT.searchContract(ctr, "", txtCustomerName.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ContractEdit contractEdit = new ContractEdit();
            contractEdit.EditCompletedHandler += FormContractEdit_Completed;
            contractEdit.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("You don't choose a contract to " + btnEdit.Text + "!", "Infomations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int rowIndex = dgvContract.CurrentRow.Index;
                Contract ctr = new Contract()
                {
                    Id = txtId.Text.Trim(),
                    Begindate = dateTimePickerDateBegin.Text,
                    Customerid = txtCustomerId.Text.Trim(),
                    IsValid = bool.Parse(cmbContractStatus.SelectedValue.ToString()),
                    Note = txtNote.Text,
                    PriceRoom = decimal.Parse(txtPriceRoom.Text.Trim() == "" ? "0" : txtPriceRoom.Text.Trim()),
                    Roomid = (dgvContract.DataSource as DataTable).Rows[rowIndex].Field<string>("RoomId"),
                    Deposit = (dgvContract.DataSource as DataTable).Rows[rowIndex].Field<decimal>("Deposit"),
                    Enddate = (dgvContract.DataSource as DataTable).Rows[rowIndex].Field<DateTime>("Enddate").ToShortDateString(),
                    Setdate = (dgvContract.DataSource as DataTable).Rows[rowIndex].Field<DateTime>("Setdate").ToShortDateString()
                };

                ContractEdit contractEdit = new ContractEdit(ctr, txtCustomerName.Text.Trim(), (cmbRoom.SelectedValue == null) ? "" : (cmbRoom.SelectedItem as DataRowView).Row.Field<string>("Name").ToString(), btnEdit.Text == "Edit" ? true : false);
                if (btnEdit.Text != "Edit")
                    contractEdit.EditCompletedHandler += FormContractEdit_Completed;
                contractEdit.ShowDialog();
            }
        }

        private void FormContractEdit_Completed(String contractId)
        {
            dgvContract.DataSource = contractBLT.getListContract();
            dgvContract.ClearSelection();

            foreach (DataGridViewRow row in dgvContract.Rows)
            {
                if (row.Cells["clID"].Value.ToString().Equals(contractId))
                {
                    dgvContract.Rows[row.Index].Selected = true;
                    break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("You don't choose a contract to delete!", "Infomations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Do you realy want to delete " + txtId.Text + "?\n\nPress Yes to delete, No to cancel.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool flag = contractBLT.deleteContract(txtId.Text);
                    if (flag)
                    {
                        btnRefresh_Click(new object(), new EventArgs());
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
            this.dgvContract.DataSource = contractBLT.getListContract();
        }

        private void resetUI()
        {
            txtId.Text = "";
            dateTimePickerDateBegin.Value = dateTimePickerDateBegin.MaxDate;
            txtCustomerName.Text = "";
            txtCustomerId.Text = "";
            cmbRoom.SelectedIndex = -1;
            txtPriceRoom.Text = "0";
            txtNote.Text = "";
            cmbContractStatus.SelectedIndex = -1;
        }

        private void changeModeEditUI(bool isCanEdit)
        {
            txtId.ReadOnly = !isCanEdit;
            dateTimePickerDateBegin.Enabled = isCanEdit;
            txtCustomerName.ReadOnly = !isCanEdit;
            txtCustomerId.ReadOnly = !isCanEdit;
            cmbRoom.Enabled = isCanEdit;
            txtPriceRoom.ReadOnly = !isCanEdit;
            txtNote.ReadOnly = !isCanEdit;
            cmbContractStatus.Enabled = isCanEdit;
            btnEdit.Enabled = !isCanEdit;
            btnDelete.Enabled = !isCanEdit;
            if (isCanEdit)
                this.btnSearch.Text = "Search";
            else
                this.btnSearch.Text = "Reset";

            CheckEditContract(txtId.Text);
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
                
        private void CheckEditContract(string contractId)
        {
            var temp = new ServiceNote()
            {
                Conntractid = contractId
            };
            DataTable result = serviceNoteBLT.searchServiceNote(temp, "");
            if (result != null && result.Rows.Count > 0)
            {
                //this.btnEdit.Text = "View detail";
                this.btnDelete.Enabled = false;
            }
            else
            {
                //this.btnEdit.Text = "Edit";
                this.btnDelete.Enabled = true;
            }
        }
    }
}
