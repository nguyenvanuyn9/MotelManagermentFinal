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
    public partial class RoomBookEdit : Form
    {
        RoomBookBLT roomBookBLT;
        private RoomBook roomBook;

        //=1: Edit
        //=2: Add
        private int typeHandle;

        public RoomBookEdit(RoomBook roomBooks, int type)
        {
            InitializeComponent();

            this.roomBook = roomBooks;
            this.typeHandle = type;

            this.tbID.Enabled = false;

            roomBookBLT = new RoomBookBLT();
        }

        private void RoomBookEdit_Load(object sender, EventArgs e)
        {
           // DataTable f = roomBookBLT.getNameRoomById(this.roomBook.Roomid);

            if (typeHandle == 1)
            {
                DataTable dt = roomBookBLT.getListRoom();

                this.cbRoom.DisplayMember = "name";
                this.cbRoom.ValueMember = "id";
                 this.cbRoom.DataSource = dt;

                DataRow dr = dt.NewRow();
                dr["name"] = roomBookBLT.getNameRoomById(this.roomBook.Roomid);
                dr["id"] = this.roomBook.Roomid;

                dt.Rows.InsertAt(dr, 0);
                this.cbRoom.SelectedIndex = 0;
                
            }

            if (typeHandle == 2)
            {
                this.cbRoom.DataSource = roomBookBLT.getListRoomAvaiable("RMS0000001"); 
                this.cbRoom.DisplayMember = "name";
                this.cbRoom.ValueMember = "id";
            }
          
            this.cbCustomer.DataSource = roomBookBLT.getListCustomer();
            this.cbCustomer.DisplayMember = "name";
            this.cbCustomer.ValueMember = "id";

            this.cbStatusRoomBook.DataSource = roomBookBLT.getListRoomBookStatus();
            this.cbStatusRoomBook.DisplayMember = "name";
            this.cbStatusRoomBook.ValueMember = "id";

            //-----------------
            this.tbID.Text = roomBook.Id;
            this.tbNote.Text = roomBook.Note;
            this.tbDeposit.Text = roomBook.Deposit.ToString();

            if (typeHandle == 1)
            {
                this.dateBegin.Value = Convert.ToDateTime(roomBook.Begindate);
                this.dateEnd.Value = Convert.ToDateTime(roomBook.Enddate);
            }

            this.cbCustomer.SelectedIndex = this.cbCustomer.FindStringExact(roomBook.Customerid);

            this.cbRoom.SelectedIndex = this.cbRoom.FindStringExact(roomBook.Roomid);
            this.cbStatusRoomBook.SelectedIndex = this.cbStatusRoomBook.FindStringExact(roomBook.RoomBookStatusid);
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            if (check_type())
            {
                roomBook.Id = this.tbID.Text;
                roomBook.Note = this.tbNote.Text;
                roomBook.Deposit = Convert.ToDecimal(this.tbDeposit.Text);

                roomBook.Customerid = this.cbCustomer.SelectedValue.ToString();
                roomBook.Roomid = this.cbRoom.SelectedValue.ToString();
                roomBook.RoomBookStatusid = this.cbStatusRoomBook.SelectedValue.ToString();

                roomBook.Begindate = this.dateBegin.Value.Date.ToString("MM/dd/yyyy");
                roomBook.Enddate = this.dateEnd.Value.Date.ToString("MM/dd/yyyy");

                if (typeHandle == 1)//Edit
                {

                    if (roomBookBLT.updateRoomBook(roomBook))
                    {
                        MessageBox.Show("Update Success!");
                    }
                    else
                    {
                        MessageBox.Show("Error Update");
                    }
                }

                if (typeHandle == 2)//New
                {
                    if (roomBookBLT.addRoomBook(roomBook))
                    {
                        MessageBox.Show("Add Success!");
                    }
                    else
                    {
                        MessageBox.Show("Error Add");
                    }
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Dispose();

            RoomBookList newform = new RoomBookList();
            newform.Show();
        }

        //Only type number.
        private void tbDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private Boolean check_type()
        {
            Boolean result = true;

            foreach (Control c in this.Controls)
            {
             
                //Combobox..
                if (c is ComboBox)
                {
                    ComboBox comboBox = c as ComboBox;

                    if (comboBox.Name == "cbRoom")
                    {
                        if (comboBox.SelectedIndex > -1)  
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                            MessageBox.Show("Room must not enmpty!");
                            return result;
                        }
                    }

                    if (comboBox.Name == "cbCustomer")
                    {
                        if (comboBox.SelectedIndex > -1)  
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                            MessageBox.Show("Customer must not enmpty!");
                            return result;
                        }
                    }

                    if (comboBox.Name == "cbStatusRoomBook")
                    {
                        if (comboBox.SelectedIndex > -1)  
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                            MessageBox.Show("Status must not enmpty!");
                            return result;
                        }
                    }
                }

                //Rich TextBox
                if (c is RichTextBox)
                {
                    RichTextBox richtextBox = c as RichTextBox;

                    if (richtextBox.Text == string.Empty)
                    {
                        result = false;
                        MessageBox.Show("Note must not enmpty!");
                        return result;
                    }
                    else
                    {
                        result = true;
                    }
                }

                if (c is DateTimePicker)
                {

                }

            }

            return result;
        }
    
    
    }



}
