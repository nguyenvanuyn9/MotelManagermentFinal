using MotelManage.PresentationTier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotelManage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void roomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RoomTypeList().Show();
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ServiceList().Show();
        }

        private void serviceNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ServiceNoteList().Show();
        }

        private void tollBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TollBillList().Show();
        }

        private void roomBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RoomBookList().Show();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RoomList().Show();
        }

        private void roomStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RoomStatusList().Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerList().Show();
        }

        private void debtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DebtList().Show();
        }

        private void contractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ContactList().Show();
        }

        private void spendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SpendBillList().Show();
        }

        private void receiptBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReceiptList().Show();
        }

        private void evenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportEvenue().Show();
        }

        private void roomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ReportRoom().Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa hỗ trợ chức năng này!");
        }
    }
}
