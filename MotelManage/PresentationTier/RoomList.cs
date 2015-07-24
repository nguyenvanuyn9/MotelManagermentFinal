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
             if (gridRoomList.Rows.Count > 1)
            {
                rowIndex = this.gridRoomList.CurrentCell.RowIndex;

                if ((rowIndex < gridRoomList.RowCount - 1) && (rowIndex >= 0))
                {

                    Room editRoom = new Room();

                    editRoom.Id = gridRoomList.Rows[rowIndex].Cells[0].Value.ToString();
                    editRoom.Name = gridRoomList.Rows[rowIndex].Cells[1].Value.ToString();
           
                    editRoom.StatusID = gridRoomList.Rows[rowIndex].Cells[2].Value.ToString();
                    editRoom.RoomType = gridRoomList.Rows[rowIndex].Cells[3].Value.ToString();
          

                    this.Hide();

                    RoomEdit editform = new RoomEdit(editRoom, 1);
                    editform.Show();
                }
            }else
             {
                 MessageBox.Show("No row selected!");
             }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (gridRoomList.Rows.Count > 1)
            {

                rowIndex = this.gridRoomList.CurrentCell.RowIndex;

                if ((rowIndex < gridRoomList.RowCount - 1) && (rowIndex >= 0))
                {

                    string idSelect = gridRoomList.Rows[rowIndex].Cells[0].Value.ToString();

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
                        //do something else
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

            this.cbStatus.DataSource = roomBLT.getListRoomStatus();
            this.cbStatus.DisplayMember = "name";
            this.cbStatus.ValueMember = "id";

            this.cbtype.DataSource = roomBLT.getListRoomType();
            this.cbtype.DisplayMember = "name";
            this.cbtype.ValueMember = "id";

        }

        private void gridRoomList_SelectionChanged(object sender, EventArgs e)
        {
             rowIndex = this.gridRoomList.CurrentCell.RowIndex;

             if (rowIndex < gridRoomList.RowCount - 1)
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
