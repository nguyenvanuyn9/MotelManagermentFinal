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
    public partial class ServiceEdit : Form
    {
        public delegate void EditCompleteDelegate(String serviceId);

        public EditCompleteDelegate EditCompletedHandler;

        private ServiceBLT serviceBLT;
        public ServiceEdit(Service service)
        {
            InitializeComponent();
            this.serviceBLT = new ServiceBLT();
            this.Text = "Edit service";
            txtId.Text = service.Id;
            txtName.Text = service.Name;
            txtPrice.Text = service.Price.ToString();
            txtUnit.Text = service.Unit.ToString();
        }

        public ServiceEdit()
        {
            InitializeComponent();
            this.serviceBLT = new ServiceBLT();
            this.Text = "Add service";
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
                Service rt = new Service()
                {
                    Id = txtId.Text,
                    Name = txtName.Text.Trim(),
                    Price = decimal.Parse(txtPrice.Text.Trim() == "" ? "0" : txtPrice.Text.Trim()),
                    Unit = txtUnit.Text.Trim(),
                };

                if (this.Text == "Edit service")
                {
                    //Edit
                    if(serviceBLT.updateService(rt))
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
                    if (serviceBLT.addService(rt, out id))
                    {
                        MessageBox.Show("Insert " + txtName.Text.Trim().ToUpper() + " successfully!\nThe new service Id = " + id + ".");
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
            if (txtUnit.Text.Trim() == "" || txtName.Text.Trim() == "" || txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("Don't be empty the fields: Service name, Price, Unit!");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
