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
    public partial class ReportEvenueList : Form
    {

        ReportEvenueBLT reportEvenueBLT;
        int rowIndex = -1;


        public ReportEvenueList()
        {
            InitializeComponent();

            this.gridviewReportEvenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            reportEvenueBLT = new ReportEvenueBLT();
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

        private void ReportEvenueList_Load(object sender, EventArgs e)
        {
            //Load list data
            this.gridviewReportEvenue.DataSource = reportEvenueBLT.getListData();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            ReportEvenues reportEvenue = new ReportEvenues();

            reportEvenue.Id = this.tbReportID.Text;
            reportEvenue.Date = this.dateSet.Value.Date.ToString("MM/dd/yyyy");

            if (!this.tbTotalMoney.Text.Equals(""))
                reportEvenue.Total = Convert.ToDecimal(this.tbTotalMoney.Text);
            
            this.gridviewReportEvenue.DataSource = reportEvenueBLT.SearchReportEvenue(reportEvenue);
        }

        private void btDetail_Click(object sender, EventArgs e)
        {
            if (gridviewReportEvenue.Rows.Count > 0)
            {
                //rowIndex = this.gridviewReportEvenue.CurrentCell.RowIndex;

                if ((rowIndex < gridviewReportEvenue.RowCount) && (rowIndex >= 0))
                {
                    ReportEvenues reportEvenue = new ReportEvenues();

                    reportEvenue.Id = gridviewReportEvenue.Rows[rowIndex].Cells[0].Value.ToString();
                    reportEvenue.Date = gridviewReportEvenue.Rows[rowIndex].Cells[1].Value.ToString();
                    reportEvenue.Total = Convert.ToDecimal(gridviewReportEvenue.Rows[rowIndex].Cells[2].Value);

                    this.Hide();

                    ReportEvenueDetail form = new ReportEvenueDetail(reportEvenue);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Not Select");
                }
            }
           


            /* if (gridviewReportExpense.Rows.Count > 1)
             {
                 rowIndex = this.gridviewReportExpense.CurrentCell.RowIndex;

                 if ((rowIndex < gridviewReportExpense.RowCount - 1) && (rowIndex >= 0))
                 {
                     ReportExpenses reportExpense = new ReportExpenses();

                     reportExpense.Id = gridviewReportExpense.Rows[rowIndex].Cells[0].Value.ToString();
                     reportExpense.Date = gridviewReportExpense.Rows[rowIndex].Cells[1].Value.ToString();
                     reportExpense.Total = Convert.ToDecimal(gridviewReportExpense.Rows[rowIndex].Cells[2].Value);

                     this.Hide();

                     ReportExpenseDetail form = new ReportExpenseDetail(reportExpense);
                     form.Show();
                 }
             }*/

        }
        private void gridviewReportEvenue_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void gridviewReportEvenue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;

            if (rowIndex > -1)
            {
                this.tbReportID.Text = gridviewReportEvenue.Rows[rowIndex].Cells[0].Value.ToString();
                this.dateSet.Value = Convert.ToDateTime(gridviewReportEvenue.Rows[rowIndex].Cells[1].Value);
                this.tbTotalMoney.Text = gridviewReportEvenue.Rows[rowIndex].Cells[2].Value.ToString();

            }
        }
    }
}
