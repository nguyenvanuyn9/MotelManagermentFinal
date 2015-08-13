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
    public partial class ReportExpenseList : Form
    {

        ReportExpenseBLT reportExpenseBLT;
        int rowIndex = -1;

        public ReportExpenseList()
        {
            InitializeComponent();

            this.gridviewReportExpense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            reportExpenseBLT = new ReportExpenseBLT();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            ReportExpenses reportExpense = new ReportExpenses();

            reportExpense.Id = this.tbReportID.Text;
            reportExpense.Date = this.dateSet.Value.Date.ToString("MM/dd/yyyy");

            if (!this.tbTotalMoney.Text.Equals(""))
                reportExpense.Total = Convert.ToDecimal(this.tbTotalMoney.Text);

            this.gridviewReportExpense.DataSource = reportExpenseBLT.SearchReportExpense(reportExpense);
        }

        private void btDetail_Click(object sender, EventArgs e)
        {
            if (gridviewReportExpense.Rows.Count > 0)
            {
               // rowIndex = this.gridviewReportExpense.CurrentCell.RowIndex;

                if ((rowIndex < gridviewReportExpense.RowCount) && (rowIndex >= 0))
                {
                    ReportExpenses reportExpense = new ReportExpenses();

                    reportExpense.Id = gridviewReportExpense.Rows[rowIndex].Cells[0].Value.ToString();
                    reportExpense.Date = gridviewReportExpense.Rows[rowIndex].Cells[1].Value.ToString();
                    reportExpense.Total = Convert.ToDecimal(gridviewReportExpense.Rows[rowIndex].Cells[2].Value);

                    this.Hide();

                    ReportExpenseDetail form = new ReportExpenseDetail(reportExpense);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Not Select");
                }
            }
            
        }

        private void ReportExpenseList_Load(object sender, EventArgs e)
        {
            //Load list data
            this.gridviewReportExpense.DataSource = reportExpenseBLT.getListData();
        }

        private void gridviewReportExpense_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void tbTotalMoney_KeyPress(object sender, KeyPressEventArgs e)
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

        private void gridviewReportExpense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;

            if (rowIndex > -1)
            {
                this.tbReportID.Text = gridviewReportExpense.Rows[rowIndex].Cells[0].Value.ToString();
                
                this.dateSet.Value = Convert.ToDateTime(gridviewReportExpense.Rows[rowIndex].Cells[1].Value);
                this.tbTotalMoney.Text = gridviewReportExpense.Rows[rowIndex].Cells[2].Value.ToString();

            }
        }
    }
}
