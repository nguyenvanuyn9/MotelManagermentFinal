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
    public partial class RoomBookList : Form
    {
        RoomBookBLT roomBookBLT;
        int rowIndex = -1;


        public RoomBookList()
        {
            InitializeComponent();

            this.gridRoomBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            roomBookBLT = new RoomBookBLT();
        }

        private void RoomBookList_Load(object sender, EventArgs e)
        {
            this.cbRoom.DataSource = roomBookBLT.getListRoom();
            this.cbRoom.DisplayMember = "name";
            this.cbRoom.ValueMember = "id";

            this.cbCustomer.DataSource = roomBookBLT.getListCustomer();
            this.cbCustomer.DisplayMember = "name";
            this.cbCustomer.ValueMember = "id";

            this.cbStatusRoomBook.DataSource = roomBookBLT.getListRoomBookStatus();
            this.cbStatusRoomBook.DisplayMember = "name";
            this.cbStatusRoomBook.ValueMember = "id";

            //Update Roombook Delay
            DateTime now = DateTime.Now;
            string s = now.ToString("MM/dd/yyyy");
            roomBookBLT.updateRoomBookDelay("RMBS000002", s);

            //Load list data
            this.gridRoomBook.DataSource = roomBookBLT.getListData();

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            RoomBook newRoomBook = new RoomBook();

            this.Hide();

            RoomBookEdit editform = new RoomBookEdit(newRoomBook, 2);
            editform.Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

            RoomBook searchRoomBook = new RoomBook();

            searchRoomBook.Begindate = this.dateBegin.Value.Date.ToString("MM/dd/yyyy");
            searchRoomBook.Enddate = this.dateEnd.Value.Date.ToString("MM/dd/yyyy");
            searchRoomBook.Roomid = this.cbRoom.SelectedValue.ToString();
            searchRoomBook.Customerid = this.cbCustomer.SelectedValue.ToString();
            searchRoomBook.RoomBookStatusid = this.cbStatusRoomBook.SelectedValue.ToString();
            searchRoomBook.Note = this.tbNote.Text;
            searchRoomBook.Deposit = Convert.ToDecimal(this.tbDeposit.Text);

            this.gridRoomBook.DataSource = roomBookBLT.searchRoomBook(searchRoomBook);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //KO cho edit Cai da het han
            //
            //
            //

            if (gridRoomBook.Rows.Count > 1)
            {
                rowIndex = this.gridRoomBook.CurrentCell.RowIndex;

                if ((rowIndex < gridRoomBook.RowCount - 1) && (rowIndex >= 0))
                {
                    RoomBook editRoomBook = new RoomBook();

                    editRoomBook.Id = gridRoomBook.Rows[rowIndex].Cells[0].Value.ToString();
                    editRoomBook.Begindate = gridRoomBook.Rows[rowIndex].Cells[1].Value.ToString();
                    editRoomBook.Enddate = gridRoomBook.Rows[rowIndex].Cells[2].Value.ToString();
                    editRoomBook.Roomid = gridRoomBook.Rows[rowIndex].Cells[3].Value.ToString();
                    editRoomBook.Customerid = gridRoomBook.Rows[rowIndex].Cells[4].Value.ToString();

                    editRoomBook.RoomBookStatusid = gridRoomBook.Rows[rowIndex].Cells[5].Value.ToString();

                    if (editRoomBook.RoomBookStatusid == "Da het han")
                    {
                        //ko cho edit .........
                    }


                    editRoomBook.Note = gridRoomBook.Rows[rowIndex].Cells[6].Value.ToString();

                    editRoomBook.Deposit = Convert.ToDecimal(gridRoomBook.Rows[rowIndex].Cells[7].Value);

                    this.Hide();

                    RoomBookEdit editform = new RoomBookEdit(editRoomBook, 1);
                    editform.Show();
                }
            }
            else
            {
                MessageBox.Show("Not Select");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (gridRoomBook.Rows.Count > 1)
            {

                rowIndex = this.gridRoomBook.CurrentCell.RowIndex;

                if ((rowIndex < gridRoomBook.RowCount - 1) && (rowIndex >= 0))
                {
                    string idSelect = gridRoomBook.Rows[rowIndex].Cells[0].Value.ToString();

                    DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (rowIndex >= 0)
                        {

                            if (roomBookBLT.deleteRoomBook(idSelect))
                            {
                                MessageBox.Show("Delete Success!");
                                this.gridRoomBook.DataSource = roomBookBLT.getListData();
                            }
                            else
                            {
                                MessageBox.Show("Error Delete!");
                            }
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
                else
                {
                    MessageBox.Show("Not Select");
                }
            }
        }

        private void gridRoomBook_SelectionChanged(object sender, EventArgs e)
        {

            rowIndex = this.gridRoomBook.CurrentCell.RowIndex;

            if (rowIndex < gridRoomBook.RowCount - 1)
            {
                string id = gridRoomBook.Rows[rowIndex].Cells[0].Value.ToString();
                string room = gridRoomBook.Rows[rowIndex].Cells[3].Value.ToString();
                string customer = gridRoomBook.Rows[rowIndex].Cells[4].Value.ToString();
                string status = gridRoomBook.Rows[rowIndex].Cells[5].Value.ToString();
                string note = gridRoomBook.Rows[rowIndex].Cells[6].Value.ToString();
                string deposit = gridRoomBook.Rows[rowIndex].Cells[7].Value.ToString();
              
                this.tbID.Text = id;
                this.dateBegin.Value = Convert.ToDateTime(gridRoomBook.Rows[rowIndex].Cells[1].Value);
                this.dateEnd.Value = Convert.ToDateTime(gridRoomBook.Rows[rowIndex].Cells[2].Value);
                this.tbNote.Text = note;
                this.cbCustomer.SelectedIndex = this.cbCustomer.FindStringExact(customer);
                this.cbRoom.SelectedIndex = this.cbRoom.FindStringExact(room);
                this.cbStatusRoomBook.SelectedIndex = this.cbStatusRoomBook.FindStringExact(status);
                this.tbDeposit.Text = deposit;
            }
        }

        //only type number ...
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
    }
}
