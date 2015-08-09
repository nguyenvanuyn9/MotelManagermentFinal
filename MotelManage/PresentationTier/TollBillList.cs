using MotelManage.BusinessLogicTier;
using MotelManage.DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotelManage.PresentationTier
{
    public partial class TollBillList : Form
    {
        private RoomBLT roomBLT;
        private TollBillsBLT tollBillsBLT;
        private ReceiptsBLT receiptsBLT;
        private ServiceNoteBLT serviceNoteBLT;

        private string tollBillsIdPrevFocus;
        public TollBillList()
        {
            InitializeComponent();
            Load += TollBillList_Load;
            dateTimePickerDate.MaxDate = DateTime.Now;
            dateTimePickerNoteService.MaxDate = DateTime.Now;
            dgvTollBills.AutoGenerateColumns = false;
            txtDebt.KeyPress += TxtMoney_KeyPress;
            txtDiscountMoney.KeyPress += TxtMoney_KeyPress;
            txtPriceRoom.KeyPress += TxtMoney_KeyPress;
            txtTotal.KeyPress += TxtMoney_KeyPress;
            txtTotalMoneyService.KeyPress += TxtMoney_KeyPress;
            Load += ServiceNoteList_Load;
            dgvTollBills.SelectionChanged += DgvTollBills_SelectionChanged;

            this.resetUI();
            
            this.roomBLT = new RoomBLT();
            this.tollBillsBLT = new TollBillsBLT();
            this.receiptsBLT = new ReceiptsBLT();
            this.serviceNoteBLT = new ServiceNoteBLT();

            cmbRoom.DataSource = roomBLT.getListRoom();
            cmbRoom.DisplayMember = "NAME";
            cmbRoom.ValueMember = "NAME";

            dgvTollBills.DataSource = tollBillsBLT.getListTollBill();
        }

        private void TollBillList_Load(object sender, EventArgs e)
        {
            //Chỗ này sẽ load cái gợi ý xem có cái ServiceNote nào ghi rồi mà chưa có xuất TollBills không?
        }

        private void ServiceNoteList_Load(object sender, EventArgs e)
        {
        }

        private void DgvTollBills_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = (sender as DataGridView).CurrentRow;
            if (row != null && tollBillsIdPrevFocus != row.Cells["clId"].Value.ToString())
            {
                tollBillsIdPrevFocus = txtId.Text = row.Cells["clId"].Value.ToString();
                cmbRoom.SelectedIndex = cmbRoom.FindStringExact(row.Cells["clRoomName"].Value.ToString());
                txtContractId.Text = row.Cells["clContractId"].Value.ToString();
                txtNote.Text = row.Cells["clNote"].Value.ToString();
                txtPriceRoom.Text = row.Cells["clRoomPrice"].Value.ToString();
                txtTotalMoneyService.Text = row.Cells["clServiceSumMoney"].Value.ToString();
                txtDebt.Text = (row.Cells["clDebt"].EditedFormattedValue.ToString() == "")?"0":row.Cells["clDebt"].Value.ToString();
                txtDiscountMoney.Text = row.Cells["clDiscountMoney"].Value.ToString();
                txtTotal.Text = row.Cells["clTotal"].Value.ToString();
                dateTimePickerDate.Value = DateTime.Parse(row.Cells["clDate"].Value.ToString()) > dateTimePickerDate.MaxDate ? dateTimePickerDate.MaxDate : DateTime.Parse(row.Cells["clDate"].Value.ToString());
                dateTimePickerNoteService.Value = DateTime.Parse(row.Cells["clDateServiceNote"].Value.ToString()) > dateTimePickerDate.MaxDate ? dateTimePickerDate.MaxDate : DateTime.Parse(row.Cells["clDateServiceNote"].Value.ToString());

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
                TollBills tb = new TollBills()
                {
                    Id = txtId.Text.Trim(),
                    Datetoll = dateTimePickerDate.Text,
                    DiscountMoney= decimal.Parse(txtDiscountMoney.Text.Trim() == "" ? "0" : txtDiscountMoney.Text.Trim()),
                    Note=txtNote.Text,
                    Total = decimal.Parse(txtTotal.Text.Trim() == "" ? "0" : txtTotal.Text.Trim())
                };

                this.dgvTollBills.DataSource = tollBillsBLT.searchTollBill(tb, 
                    txtContractId.Text,
                    (cmbRoom.SelectedValue == null) ? "" : cmbRoom.SelectedValue.ToString(),
                    dateTimePickerNoteService.Text,
                    decimal.Parse(txtPriceRoom.Text.Trim() == "" ? "0" : txtPriceRoom.Text.Trim()),
                    decimal.Parse(txtTotalMoneyService.Text.Trim() == "" ? "0" : txtTotalMoneyService.Text.Trim()),
                    decimal.Parse(txtDebt.Text.Trim() == "" ? "0" : txtDebt.Text.Trim()),
                    decimal.Parse(txtTotal.Text.Trim() == "" ? "0" : txtTotal.Text.Trim()));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TollBillEdit tollBillsEdit = new TollBillEdit("SN00000008", "CTR0000006", 769000, "2015-09-18");
            tollBillsEdit.EditCompletedHandler += FormTollBillsEdit_Completed;
            tollBillsEdit.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("You don't choose a tollbills to " + btnEdit.Text + "!", "Infomations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                TollBills tb = new TollBills()
                {
                    Id = txtId.Text.Trim(),
                    Datetoll = dateTimePickerDate.Text,
                    Servicenoteid =((dgvTollBills.DataSource as DataTable).Rows[dgvTollBills.CurrentCell.RowIndex] as DataRow).Field<string>("SERVICENOTEID"),
                    DiscountMoney = decimal.Parse(txtDiscountMoney.Text.Trim() == "" ? "0" : txtDiscountMoney.Text.Trim()),
                    Note = txtNote.Text, 
                    Total = decimal.Parse(txtTotal.Text.Trim() == "" ? "0" : txtTotal.Text.Trim())
                };

                TollBillEdit serviceNoteEdit = new TollBillEdit(tb, txtContractId.Text.Trim(), (cmbRoom.SelectedValue == null) ? "" : cmbRoom.SelectedValue.ToString(),
                    dateTimePickerNoteService.Text,
                    txtPriceRoom.Text.Trim() == "" ? "0" : txtPriceRoom.Text.Trim(),
                    txtTotalMoneyService.Text.Trim() == "" ? "0" : txtTotalMoneyService.Text.Trim(),
                    txtDebt.Text.Trim() == "" ? "0" : txtDebt.Text.Trim(),
                    txtTotal.Text.Trim() == "" ? "0" : txtTotal.Text.Trim(),
                    btnEdit.Text == "Edit" ? true : false);

                if (btnEdit.Text == "Edit")
                    serviceNoteEdit.EditCompletedHandler += FormTollBillsEdit_Completed;
                serviceNoteEdit.ShowDialog();
            }
        }

        private void FormTollBillsEdit_Completed(String ServiceNoteId)
        {
            dgvTollBills.DataSource = tollBillsBLT.getListTollBill();
            dgvTollBills.ClearSelection();

            foreach (DataGridViewRow row in dgvTollBills.Rows)
            {
                if (row.Cells["clId"].Value.ToString().Equals(ServiceNoteId))
                {
                    dgvTollBills.Rows[row.Index].Selected = true;
                    break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("You don't choose a tollbills to delete!", "Infomations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Do you realy want to delete " + txtId.Text + "?\n\nPress Yes to delete, No to cancel.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool flag = tollBillsBLT.deleteTollBill(txtId.Text);
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
            this.dgvTollBills.DataSource = tollBillsBLT.getListTollBill();
        }

        private void resetUI()
        {
            txtId.Text = "";
            dateTimePickerDate.Text = "";
            cmbRoom.SelectedIndex = -1;
            txtContractId.Text ="";
            txtNote.Text = "";
            txtPriceRoom.Text = "";
            txtTotalMoneyService.Text = "";
            txtDebt.Text = "";
            txtDiscountMoney.Text = "";
            txtTotal.Text = "";
            dateTimePickerNoteService.Text = "";
        }

        private void changeModeEditUI(bool isCanEdit)
        {
            txtId.ReadOnly = !isCanEdit;
            dateTimePickerDate.Enabled = isCanEdit;
            cmbRoom.Enabled = isCanEdit;
            txtContractId.ReadOnly = !isCanEdit;
            txtNote.ReadOnly = !isCanEdit;
            txtPriceRoom.ReadOnly = !isCanEdit;
            txtTotalMoneyService.ReadOnly = !isCanEdit;
            txtDebt.ReadOnly = !isCanEdit;
            txtDiscountMoney.ReadOnly = !isCanEdit;
            txtTotal.ReadOnly = !isCanEdit;
            dateTimePickerNoteService.Enabled = isCanEdit;
            
            btnEdit.Enabled = !isCanEdit;
            btnDelete.Enabled = !isCanEdit;
            if (isCanEdit)
                this.btnSearch.Text = "Search";
            else
                this.btnSearch.Text = "Reset";

            CheckEditTollBills(txtId.Text);
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
        /// Tìm xem trong bảng ReceiptBills đã có thông tin TollBillsID này chưa?
        ///    - Nếu có rồi thì không cho chỉnh sửa và xóa ServiceNoteId này nữa, chỉ cho xem thôi;
        ///    - Nếu chưa có thì cho phép chỉnh sửa và xóa.
        /// </summary>
        /// <param name="tollBillsId"></param>
        private void CheckEditTollBills(string tollBillsId)
        {
            var temp = new Receipts()
            {
                Billid = tollBillsId,
                Dateestablish = ""
            };
            DataTable result = receiptsBLT.searchReceipts(temp);
            if (result != null && result.Rows.Count>0)
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
