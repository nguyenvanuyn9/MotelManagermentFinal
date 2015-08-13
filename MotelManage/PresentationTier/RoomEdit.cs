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
    public partial class RoomEdit : Form
    {
        RoomBLT roomBLT;
        private Room room;

          //=1: Edit
        //=2: Add
        private int typeHandle;

        public RoomEdit(Room rooms, int type)
        {
            InitializeComponent();
            this.room = rooms;
            this.typeHandle = type;

            this.tbID.Enabled = false;

            roomBLT = new RoomBLT();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (check_type())
            {
                room.Id = this.tbID.Text;
                room.Name = this.tbName.Text;
                room.RoomType = this.cbTypeRoom.SelectedValue.ToString();
                room.StatusID = this.cbStatus.SelectedValue.ToString();

                if (roomBLT.checkDuplidateName(room.Name) > 0)
                {
                    MessageBox.Show("Duplicate name!");
                }
                else
                {
                    if (typeHandle == 1)//Edit
                    {

                        if (roomBLT.updateRoom(room))
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
                        if (roomBLT.addRoom(room))
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
        }

        private void RoomEdit_Load(object sender, EventArgs e)
        {
            this.cbStatus.DataSource = roomBLT.getListRoomStatus();
            this.cbStatus.DisplayMember = "name";
            this.cbStatus.ValueMember = "id";

            this.cbTypeRoom.DataSource = roomBLT.getListRoomType();
            this.cbTypeRoom.DisplayMember = "name";
            this.cbTypeRoom.ValueMember = "id";

            //-----------------
            this.tbID.Text = room.Id;
            this.tbName.Text = room.Name;
            this.cbStatus.SelectedIndex = this.cbStatus.FindStringExact(room.StatusID);
            this.cbTypeRoom.SelectedIndex = this.cbTypeRoom.FindStringExact(room.RoomType);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Dispose();

          

            RoomList newform = new RoomList();
            newform.Show();
        }

        private Boolean check_type()
        {
            Boolean result = false;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;

                    if (textBox.Name == "tbName")
                    {
                        if (!string.IsNullOrWhiteSpace(textBox.Text))
                        {

                            result = true;
                        }
                        else
                        {
                            result = false;
                            MessageBox.Show("Name must not enmpty!");
                            return result;
                        }
                    }

                }


                //Combobox..
                if (c is ComboBox)
                {
                    ComboBox comboBox = c as ComboBox;

                    if (comboBox.Name == "cbStatus")
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

                    if (comboBox.Name == "cbTypeRoom")
                    {
                        if (comboBox.SelectedIndex > -1)   
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                            MessageBox.Show("TypeRoom must not enmpty!");
                            return result;
                        }
                    }
                }
            }

            return result;
        }
    
    }
}
