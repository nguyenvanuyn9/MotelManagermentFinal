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
    public partial class RoomTypeEdit : Form
    {
        public delegate void EditCompleteDelegate(String roomTypeId);

        public EditCompleteDelegate EditCompletedHandler;

        private RoomTypeBLT roomTypeBLT;
        public RoomTypeEdit(RoomType roomType)
        {
            InitializeComponent();
            this.roomTypeBLT = new RoomTypeBLT();
            this.Text = "Edit room type";
            txtId.Text = roomType.Id;
            txtName.Text = roomType.Name;
            txtPrice.Text = roomType.Price.ToString();
            txtDeposit.Text = roomType.Deposit.ToString();
            txtNote.Text = roomType.Note;
        }

        public RoomTypeEdit()
        {
            InitializeComponent();
            this.roomTypeBLT = new RoomTypeBLT();
            this.Text = "Add room type";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkContraints())
            {
                RoomType rt = new RoomType()
                {
                    Id = txtId.Text,
                    Name = txtName.Text.Trim(),
                    Price = decimal.Parse(txtPrice.Text.Trim() == "" ? "0" : txtPrice.Text.Trim()),
                    Deposit = decimal.Parse(txtDeposit.Text.Trim() == "" ? "0" : txtDeposit.Text.Trim()),
                    Note = txtNote.Text.Trim()
                };

                if (this.Text == "Edit room type")
                {
                    //Edit
                    if(roomTypeBLT.updateRoomType(rt))
                    {
                        MessageBox.Show("Update " + txtId.Text.Trim().ToUpper() + " successfully!");
                        EditCompletedHandler(txtId.Text.Trim());
                        this.Close();
                    }
                    else
                        MessageBox.Show("Update " + txtId.Text.ToUpper() + " fail!");
                }
                else
                {
                    //Insert
                    string id;
                    if (roomTypeBLT.addRoomType(rt, out id))
                    {
                        MessageBox.Show("Insert " + txtName.Text.Trim().ToUpper() + " successfully!\nThe new room type Id = " + id + ".");
                        EditCompletedHandler(id);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Insert " + txtId.Text.ToUpper() + " fail! Try again later.");
                }
            }
        }

        private bool checkContraints()
        {
            if (txtDeposit.Text.Trim() == "" || txtName.Text.Trim() == "" || txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("Don't be empty the fields: Room type name, Price, Min deposit!");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
