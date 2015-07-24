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
    public partial class ContactList : Form
    {
        protected ContractBLT contractBLT = new ContractBLT();
        protected DataTable dt = new DataTable();
        protected Contract c = new Contract();
        protected String mConTract = string.Empty;
        public ContactList()
        {
            InitializeComponent();
        }

        private void contract_Load(object sender, EventArgs e)
        {
           
            dt = contractBLT.getListContract();
            //dt.Columns.Add(new DataColumn("Selected", typeof(bool)));
            this.dataContract.DataSource = dt;
        }

        private void cell_contractList(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
