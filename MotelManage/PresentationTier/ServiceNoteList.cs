using MotelManage.BusinessLogicTier;
using MotelManage.DataTransferObject;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MotelManage.PresentationTier
{
    public partial class ServiceNoteList : Form
    {
        private ServiceNoteBLT serviceNoteBLT;
        private ContractBLT contractBLT;
        private RoomBLT roomBLT;
        private TollBillsBLT tollBillsBLT;

        private string serviceNoteIdPrevFocus;
        public ServiceNoteList()
        {
            InitializeComponent();
            dateTimePickerDate.MaxDate = DateTime.Now;
            dgvServiceNote.AutoGenerateColumns = false;
            txtTotalMoney.KeyPress += TxtMoney_KeyPress;
            Load += ServiceNoteList_Load;
            dgvServiceNote.SelectionChanged += DgvServiceNote_SelectionChanged;

            this.resetUI();

            this.serviceNoteBLT = new ServiceNoteBLT();
            this.contractBLT = new ContractBLT();
            this.roomBLT = new RoomBLT();
            this.tollBillsBLT = new TollBillsBLT();

            cmbContractId.DataSource = contractBLT.getListContract();
            cmbContractId.DisplayMember = "ID";
            cmbContractId.ValueMember = "ID";

            cmbRoomName.DataSource = roomBLT.getListRoom();
            cmbRoomName.DisplayMember = "NAME";
            cmbRoomName.ValueMember = "NAME";

            dgvServiceNote.DataSource = serviceNoteBLT.getListServiceNote();
        }

        private void ServiceNoteList_Load(object sender, EventArgs e)
        {
        }

        private void DgvServiceNote_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = (sender as DataGridView).CurrentRow;
            if (row != null && serviceNoteIdPrevFocus != row.Cells["clID"].Value.ToString())
            {
                serviceNoteIdPrevFocus = txtId.Text = row.Cells["clID"].Value.ToString();
                dateTimePickerDate.Text = DateTime.Parse(row.Cells["clDate"].Value.ToString()) > dateTimePickerDate.MaxDate? dateTimePickerDate.MaxDate.ToString(): row.Cells["clDate"].Value.ToString();
                cmbRoomName.SelectedIndex = cmbRoomName.FindStringExact(row.Cells["clRoomName"].Value.ToString());
                cmbContractId.SelectedIndex = cmbContractId.FindStringExact(row.Cells["clContractID"].Value.ToString());
                txtTotalMoney.Text = row.Cells["clTotalMoney"].Value.ToString();

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
                ServiceNote svcn = new ServiceNote()
                {
                    Id = txtId.Text.Trim(),
                    Date = dateTimePickerDate.Text,
                    Conntractid = (cmbContractId.SelectedValue == null) ? "" : cmbContractId.SelectedValue.ToString(),
                    Total= decimal.Parse(txtTotalMoney.Text.Trim() == "" ? "0" : txtTotalMoney.Text.Trim())
                };

                this.dgvServiceNote.DataSource = serviceNoteBLT.searchServiceNote(svcn, (cmbRoomName.SelectedIndex < 0) ? "" : cmbRoomName.SelectedValue.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ServiceNoteEdit svcNoteEdit = new ServiceNoteEdit();
            svcNoteEdit.EditCompletedHandler += FormServiceNoteEdit_Completed;
            svcNoteEdit.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("You don't choose a service note to " + btnEdit.Text + "!", "Infomations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ServiceNote svcn = new ServiceNote()
                {
                    Id = txtId.Text.Trim(),
                    Date = dateTimePickerDate.Text,
                    Conntractid = (cmbContractId.SelectedValue == null) ? "" : cmbContractId.SelectedValue.ToString(),
                    Total = decimal.Parse(txtTotalMoney.Text.Trim() == "" ? "0" : txtTotalMoney.Text.Trim())
                };

                ServiceNoteEdit serviceNoteEdit = new ServiceNoteEdit(svcn, (cmbRoomName.SelectedValue == null) ? "" : cmbRoomName.SelectedValue.ToString(), btnEdit.Text=="Edit"?true:false);
                if(btnEdit.Text=="Edit")
                    serviceNoteEdit.EditCompletedHandler += FormServiceNoteEdit_Completed;
                serviceNoteEdit.ShowDialog();
            }
        }

        private void FormServiceNoteEdit_Completed(String ServiceNoteId)
        {
            dgvServiceNote.DataSource = serviceNoteBLT.getListServiceNote();
            dgvServiceNote.ClearSelection();

            foreach (DataGridViewRow row in dgvServiceNote.Rows)
            {
                if (row.Cells["clID"].Value.ToString().Equals(ServiceNoteId))
                {
                    dgvServiceNote.Rows[row.Index].Selected = true;
                    break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("You don't choose a service note to delete!", "Infomations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Do you realy want to delete " + txtId.Text + "?\n\nPress Yes to delete, No to cancel.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool flag = serviceNoteBLT.deleteServiceNote(txtId.Text);
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
            this.dgvServiceNote.DataSource = serviceNoteBLT.getListServiceNote();
        }

        private void resetUI()
        {
            txtId.Text = "";
            dateTimePickerDate.Value = dateTimePickerDate.MaxDate;
            cmbRoomName.SelectedIndex = -1;
            cmbContractId.SelectedIndex = -1;
            txtTotalMoney.Text = "0";
        }

        private void changeModeEditUI(bool isCanEdit)
        {
            txtId.ReadOnly = !isCanEdit;
            dateTimePickerDate.Enabled = isCanEdit;
            cmbContractId.Enabled = isCanEdit;
            cmbRoomName.Enabled = isCanEdit;
            txtTotalMoney.ReadOnly = !isCanEdit;
            btnEdit.Enabled = !isCanEdit;
            btnDelete.Enabled = !isCanEdit;
            if (isCanEdit)
                this.btnSearch.Text = "Search";
            else
                this.btnSearch.Text = "Reset";

            CheckEditServiceNote(txtId.Text);
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
        
        /// <summary>
        /// //Tìm xem trong bảng TollBills đã có thông tin ServiceNoteID này chưa?
        //     - Nếu có rồi thì không cho chỉnh sửa và xóa ServiceNoteId này nữa, chỉ cho xem thôi;
        //     - Nếu chưa có thì cho phép chỉnh sửa và xóa.
        /// </summary>
        /// <param name="servicenoteid"></param>
        private void CheckEditServiceNote(string servicenoteid)
        {
            var temp = new TollBills()
            {
                Servicenoteid = servicenoteid
            };
            DataTable result = tollBillsBLT.searchTollBill(temp, "", "", "", 0,0,0,0);
            if (result != null && result.Rows.Count > 0)
            {
                this.btnEdit.Text = "View detail";
                this.btnDelete.Enabled = false;
            }
            else
            {
                this.btnEdit.Text = "Edit";
                this.btnDelete.Enabled = true;
            }
        }
    }
}
