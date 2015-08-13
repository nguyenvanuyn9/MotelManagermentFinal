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
    public partial class RoomStatusEdit : Form
    {
        RoomStatusBLT roomStatusBLT;
        private RoomStatus roomstatus;

        //=1: Edit
        //=2: Add
        private int typeHandle;

        public RoomStatusEdit(RoomStatus roomstt, int type)
        {
            InitializeComponent();
            this.roomstatus = roomstt;
            this.typeHandle = type;

            this.txtID.Enabled = false;

            roomStatusBLT = new RoomStatusBLT();
        }

        private void RoomStatusEdit_Load(object sender, EventArgs e)
        {
            this.txtID.Text = roomstatus.Id;
            this.txtName.Text = roomstatus.Name;
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            if (check_type())
            {
                roomstatus.Name = this.txtName.Text;
                roomstatus.Id = this.txtID.Text;

                if (roomStatusBLT.checkDuplidateName(roomstatus.Name) > 0)
                {
                    MessageBox.Show("Duplicate name!");
                }
                else
                {
                    if (typeHandle == 1)//Edit
                    {

                        if (roomStatusBLT.updateRoomStatus(roomstatus))
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
                        if (roomStatusBLT.addRoomStatus(roomstatus))
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

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Dispose();

            RoomStatusList newform = new RoomStatusList();
            newform.Show();
        }


        private Boolean check_type()
        {
            Boolean result = true;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;

                    if (textBox.Name == "txtName")
                    {
                        if(!string.IsNullOrWhiteSpace(textBox.Text))
                        {

                            result = true;
                        }
                        else
                        {
                            result = false;
                            MessageBox.Show("Name must not enmpty!");
                        }
                    }

                }
            }

            return result;
        }


      
    }
}
