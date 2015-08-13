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
            //---
            DataTable dt = new DataTable();
            dt = roomBookBLT.getListRoom();

            this.cbRoom.DataSource = dt;
            this.cbRoom.DisplayMember = "name";
            this.cbRoom.ValueMember = "id";

            DataRow dr = dt.NewRow();
            dr["name"] = "";
            dr["id"] = "";

            dt.Rows.InsertAt(dr, 0);
            this.cbRoom.SelectedIndex = 0;

            //-------
            DataTable dt1 = new DataTable();
            dt1 = roomBookBLT.getListCustomer();

            this.cbCustomer.DataSource = dt1;
            this.cbCustomer.DisplayMember = "name";
            this.cbCustomer.ValueMember = "id";

            DataRow dr1 = dt1.NewRow();
            dr1["name"] = "";
            dr1["id"] = "";

            dt1.Rows.InsertAt(dr1, 0);
            this.cbCustomer.SelectedIndex = 0;

            //----------
            DataTable dt2 = new DataTable();
            dt2 = roomBookBLT.getListRoomBookStatus();

            this.cbStatusRoomBook.DataSource = dt2;
            this.cbStatusRoomBook.DisplayMember = "name";
            this.cbStatusRoomBook.ValueMember = "id";

            DataRow dr2 = dt2.NewRow();
            dr2["name"] = "";
            dr2["id"] = "";

            dt2.Rows.InsertAt(dr2, 0);
            this.cbStatusRoomBook.SelectedIndex = 0;


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

            if (!this.tbDeposit.Text.Equals(""))
                searchRoomBook.Deposit = Convert.ToDecimal(this.tbDeposit.Text);

            this.gridRoomBook.DataSource = roomBookBLT.searchRoomBook(searchRoomBook);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
          
            if (gridRoomBook.Rows.Count > 0)
            {

                if ((rowIndex < gridRoomBook.RowCount) && (rowIndex >= 0))
                {
                    RoomBook editRoomBook = new RoomBook();

                    editRoomBook.Id = gridRoomBook.Rows[rowIndex].Cells[0].Value.ToString();
                    editRoomBook.Begindate = gridRoomBook.Rows[rowIndex].Cells[1].Value.ToString();
                    editRoomBook.Enddate = gridRoomBook.Rows[rowIndex].Cells[2].Value.ToString();
                    editRoomBook.Roomid = gridRoomBook.Rows[rowIndex].Cells[3].Value.ToString();
                    editRoomBook.Customerid = gridRoomBook.Rows[rowIndex].Cells[4].Value.ToString();

                    editRoomBook.RoomBookStatusid = gridRoomBook.Rows[rowIndex].Cells[5].Value.ToString();

                    editRoomBook.Note = gridRoomBook.Rows[rowIndex].Cells[6].Value.ToString();

                    editRoomBook.Deposit = Convert.ToDecimal(gridRoomBook.Rows[rowIndex].Cells[7].Value);

                    this.Hide();

                    RoomBookEdit editform = new RoomBookEdit(editRoomBook, 1);
                    editform.Show();
                }
                else
                {
                    MessageBox.Show("Not Select");
                }
            }
            
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (gridRoomBook.Rows.Count > 0)
            {

                if ((rowIndex < gridRoomBook.RowCount) && (rowIndex >= 0))
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

        private void gridRoomBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;

            if (rowIndex > -1)
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

                String statusID = roomBookBLT.getRoomBookStatusId(id);

                if (statusID.Equals("RMBS000002"))
                {
                    this.btEdit.Enabled = false;
                }
                else
                {
                    this.btEdit.Enabled = true;
                }

            }
        }

       
    }
}
