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
    public partial class RoomStatusList : Form
    {
        RoomStatusBLT roomStatusBLT;
        int rowIndex = -1;

        public RoomStatusList()
        {
            InitializeComponent();
            this.gridRoomStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            roomStatusBLT = new RoomStatusBLT();
        }

        private void RoomStatusList_Load(object sender, EventArgs e)
        {
            this.gridRoomStatus.DataSource = roomStatusBLT.getListData();
        }

        private void gridRoomStatus_SelectionChanged(object sender, EventArgs e)
        {
           rowIndex = this.gridRoomStatus.CurrentCell.RowIndex;

           if (rowIndex < gridRoomStatus.RowCount - 1)
           {

               string value1 = gridRoomStatus.Rows[rowIndex].Cells[0].Value.ToString();
               string value2 = gridRoomStatus.Rows[rowIndex].Cells[1].Value.ToString();

               this.tbID.Text = value1;
               this.tbName.Text = value2;
           }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (gridRoomStatus.Rows.Count > 1)
            {
                rowIndex = this.gridRoomStatus.CurrentCell.RowIndex;

                if ((rowIndex < gridRoomStatus.RowCount - 1) && (rowIndex >= 0))
                {
                    RoomStatus editRoom = new RoomStatus();

                    editRoom.Id = gridRoomStatus.Rows[rowIndex].Cells[0].Value.ToString();
                    editRoom.Name = this.tbName.Text;

                    RoomStatusEdit editform = new RoomStatusEdit(editRoom, 1);
                    editform.Show();

                    this.Hide();
                }
            }else
             {
                 MessageBox.Show("No row Selected!");
             }
            
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
             if (gridRoomStatus.Rows.Count > 1)
            {

                rowIndex = this.gridRoomStatus.CurrentCell.RowIndex;

                if ((rowIndex < gridRoomStatus.RowCount - 1) && (rowIndex >= 0))
                {

                    string id = gridRoomStatus.Rows[rowIndex].Cells[0].Value.ToString();

                    DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (rowIndex >= 0)
                        {

                            if (roomStatusBLT.deleteRoomStatus(id))
                            {
                                MessageBox.Show("Delete Success!");
                                this.gridRoomStatus.DataSource = roomStatusBLT.getListData();
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
                    MessageBox.Show("No row Selected!");
                }
            }

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            RoomStatus editRoom = new RoomStatus();

            this.Hide();

            RoomStatusEdit editform = new RoomStatusEdit(editRoom, 2);
            editform.Show();

          
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            RoomStatus searchRoom = new RoomStatus();

            searchRoom.Name = this.tbName.Text;
            searchRoom.Id = this.tbID.Text;

            this.gridRoomStatus.DataSource = roomStatusBLT.searchRoomStatus(searchRoom);
        }

       
     
    }
}
