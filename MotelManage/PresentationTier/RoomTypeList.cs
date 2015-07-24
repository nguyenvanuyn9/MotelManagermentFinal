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
    public partial class RoomTypeList : Form
    {
        private RoomTypeBLT roomTypeBLT;
        private string roomTypeIdPrevFocus;
        public RoomTypeList()
        {
            InitializeComponent();
            txtDeposit.KeyPress += TxtMoney_KeyPress;
            txtPrice.KeyPress += TxtMoney_KeyPress;
            Load += RoomTypeList_Load;
            dgvRoomType.SelectionChanged += DgvRoomType_SelectionChanged;

            this.resetUI();

            this.roomTypeBLT = new RoomTypeBLT();
            this.dgvRoomType.DataSource = roomTypeBLT.getListRoomType();
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

        private void RoomTypeList_Load(object sender, EventArgs e)
        {
        }

        private void DgvRoomType_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = (sender as DataGridView).CurrentRow;
            if(roomTypeIdPrevFocus != row.Cells["clID"].Value.ToString())
            {
                roomTypeIdPrevFocus = txtId.Text = row.Cells["clID"].Value.ToString();
                txtName.Text = row.Cells["clName"].Value.ToString();
                txtDeposit.Text = row.Cells["clDeposit"].Value.ToString();
                txtPrice.Text = row.Cells["clPrice"].Value.ToString();
                txtNote.Text = row.Cells["clNote"].Value.ToString();

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
                RoomType rt = new RoomType()
                {
                    Id = txtId.Text.Trim(),
                    Name = txtName.Text.Trim(),
                    Price = decimal.Parse(txtPrice.Text.Trim() == "" ? "0" : txtPrice.Text.Trim()),
                    Deposit = decimal.Parse(txtDeposit.Text.Trim() == "" ? "0" : txtDeposit.Text.Trim()),
                    Note = txtNote.Text.Trim()
                };

                this.dgvRoomType.DataSource = roomTypeBLT.searchRoomType(rt);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RoomTypeEdit roomTypeEdit = new RoomTypeEdit();
            roomTypeEdit.EditCompletedHandler += FormRoomTypeEdit_Completed;
            roomTypeEdit.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("You don't choose a room type to edit!", "Infomations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                RoomType rt = new RoomType()
                {
                    Id = txtId.Text,
                    Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text.Trim()),
                    Deposit = decimal.Parse(txtDeposit.Text.Trim()),
                    Note = txtNote.Text
                };

                RoomTypeEdit roomTypeEdit = new RoomTypeEdit(rt);
                roomTypeEdit.EditCompletedHandler += FormRoomTypeEdit_Completed;
                roomTypeEdit.ShowDialog();
            }
        }

        private void FormRoomTypeEdit_Completed(String roomTypeId)
        {
            dgvRoomType.DataSource = roomTypeBLT.getListRoomType();
            dgvRoomType.ClearSelection();

            foreach (DataGridViewRow row in dgvRoomType.Rows)
            {
                if (row.Cells["clID"].Value.ToString().Equals(roomTypeId))
                {
                    dgvRoomType.Rows[row.Index].Selected = true;
                    break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("You don't choose a room type to delete!", "Infomations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(MessageBox.Show("Do you realy want to delete " + txtId.Text + "?\n\nPress Yes to delete, No to cancel.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    bool flag = roomTypeBLT.deleteRoomType(txtId.Text);
                    if (flag == true)
                    {
                        this.resetUI();
                        this.changeModeEditUI(true);
                        this.dgvRoomType.DataSource = roomTypeBLT.getListRoomType();
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
            this.dgvRoomType.DataSource = roomTypeBLT.getListRoomType();
        }

        private void resetUI()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtDeposit.Text = "0";
            txtPrice.Text = "0";
            txtNote.Text = "";
        }

        private void changeModeEditUI(bool isCanEdit)
        {
            txtId.ReadOnly = !isCanEdit;
            txtName.ReadOnly = !isCanEdit;
            txtDeposit.ReadOnly = !isCanEdit;
            txtPrice.ReadOnly = !isCanEdit;
            txtNote.ReadOnly = !isCanEdit;
            btnEdit.Enabled = !isCanEdit;
            btnDelete.Enabled = !isCanEdit;
            if (isCanEdit)
                this.btnSearch.Text = "Search";
            else
                this.btnSearch.Text = "Reset";
        }
    }
}
