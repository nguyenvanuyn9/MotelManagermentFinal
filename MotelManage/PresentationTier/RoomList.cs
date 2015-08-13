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
    public partial class RoomList : Form
    {
        RoomBLT roomBLT;
        int rowIndex = -1;

        public RoomList()
        {
            InitializeComponent();

            this.gridRoomList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            roomBLT = new RoomBLT();

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            Room searchRoom = new Room();

            searchRoom.Name = this.tbName.Text;
            searchRoom.Id = this.tbID.Text;
            searchRoom.StatusID = this.cbStatus.SelectedValue.ToString();
            searchRoom.RoomType = this.cbtype.SelectedValue.ToString();

            this.gridRoomList.DataSource = roomBLT.searchRoom(searchRoom);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Room newRoom = new Room();

            this.Hide();

            RoomEdit editform = new RoomEdit(newRoom, 2);
            editform.Show();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (gridRoomList.Rows.Count > 0)
            {

                if ((rowIndex < gridRoomList.RowCount) && (rowIndex >= 0))
                {

                    Room editRoom = new Room();

                    editRoom.Id = gridRoomList.Rows[rowIndex].Cells[0].Value.ToString();
                    editRoom.Name = gridRoomList.Rows[rowIndex].Cells[1].Value.ToString();
           
                    editRoom.StatusID = gridRoomList.Rows[rowIndex].Cells[2].Value.ToString();
                    editRoom.RoomType = gridRoomList.Rows[rowIndex].Cells[3].Value.ToString();

                    if (roomBLT.getRoomStatusById(editRoom.Id).Equals("RMS0000002"))
                    {
                        MessageBox.Show("Room is used. Don't update!");
                    }
                    else
                    {
                        this.Hide();

                        RoomEdit editform = new RoomEdit(editRoom, 1);
                        editform.Show();
                    }
                }
                else
                {
                    MessageBox.Show("No row Selected!");
                }
             }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (gridRoomList.Rows.Count > 0)
            {
                if ((rowIndex < gridRoomList.RowCount ) && (rowIndex >= 0))
                {
                    string idSelect = gridRoomList.Rows[rowIndex].Cells[0].Value.ToString();

                    if (roomBLT.getRoomStatusById(idSelect).Equals("RMS0000002"))
                    {
                        MessageBox.Show("Room is used. Don't delete!");
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (rowIndex >= 0)
                            {

                                if (roomBLT.deleteRoom(idSelect))
                                {
                                    MessageBox.Show("Delete Success!");
                                    this.gridRoomList.DataSource = roomBLT.getListData();
                                }
                                else
                                {
                                    MessageBox.Show("Error Delete!");
                                }
                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do nothing
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("No row selected!");
                }
            }
          
        }

        private void RoomList_Load(object sender, EventArgs e)
        {
            this.gridRoomList.DataSource = roomBLT.getListData();

            DataTable dt = new DataTable();
            dt = roomBLT.getListRoomStatus();

            this.cbStatus.DataSource = dt;
            this.cbStatus.DisplayMember = "name";
            this.cbStatus.ValueMember = "id";
            
            DataRow dr = dt.NewRow();
            dr["name"] = "";
            dr["id"] = "";

            dt.Rows.InsertAt(dr, 0);
            this.cbStatus.SelectedIndex = 0;

            //------------------
            DataTable dt2 = new DataTable();
            dt2 = roomBLT.getListRoomType();
            this.cbtype.DataSource = dt2;
            this.cbtype.DisplayMember = "name";
            this.cbtype.ValueMember = "id";

            DataRow dr2 = dt2.NewRow();
            dr2["name"] = "";
            dr2["id"] = "";

            dt2.Rows.InsertAt(dr2, 0);
            this.cbtype.SelectedIndex = 0;

        }

        private void gridRoomList_SelectionChanged(object sender, EventArgs e)
        {
          
           
        }

        private void gridRoomList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            
            if (rowIndex > -1)
             {
                 string id = gridRoomList.Rows[rowIndex].Cells[0].Value.ToString();
                 string name = gridRoomList.Rows[rowIndex].Cells[1].Value.ToString();

                 string status = gridRoomList.Rows[rowIndex].Cells[2].Value.ToString();
                 string type = gridRoomList.Rows[rowIndex].Cells[3].Value.ToString();

                 this.tbID.Text = id;
                 this.tbName.Text = name;

                 this.cbStatus.SelectedIndex = this.cbStatus.FindStringExact(status);

                 this.cbtype.SelectedIndex = this.cbtype.FindStringExact(type);

             }
        }
    }
}
