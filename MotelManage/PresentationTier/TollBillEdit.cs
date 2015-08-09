using Microsoft.Reporting.WinForms;
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
using System.Xml.Linq;

namespace MotelManage.PresentationTier
{
    public partial class TollBillEdit : Form
    {
        private ServiceNoteBLT serviceNoteBLT;
        private TollBillsBLT tollBillsBLT;
        private ContractBLT contractBLT;
        private DebtBLT debtBLT;
        private string serviceNoteId = "";
        decimal totalMustPayOrg = 0;

        public delegate void EditCompleteDelegate(String serviceNoteId);

        public EditCompleteDelegate EditCompletedHandler;

        public TollBillEdit(TollBills tollbill, string contractId, string roomName, string dateNoteService, string priceRoom, string totalMoneyService, string debt, string total, bool canEdit)
        {
            Init(tollbill.Servicenoteid, contractId, decimal.Parse(totalMoneyService), dateNoteService);
            Load += TollBillsEdit_Load;
            if (canEdit)
            {
                Text = "Edit tollbills";
            }
            else
            {
                Text = "Detail tollbills";
                btnSave.Enabled = false;
                btnPayment.Enabled = false;
                txtDiscountMoney.ReadOnly = true;
                txtNote.ReadOnly = true;
            }

            txtId.Text = tollbill.Id;
            dateTimePickerDate.Text = tollbill.Datetoll;
            txtContractId.Text = contractId;
            txtRoom.Text = roomName;
            txtNote.Text = tollbill.Note;
            txtPriceRoom.Text = priceRoom;
            txtDebt.Text = debt;
            txtDiscountMoney.Text = tollbill.DiscountMoney.ToString();
            totalMustPayOrg = tollbill.Total + tollbill.DiscountMoney;
            txtTotal.Text = tollbill.Total.ToString();
        }

        public TollBillEdit(string serviceNoteId, string contractId, decimal serviceTotalMoney, string dateNoteService)
        {
            Init(serviceNoteId, contractId, serviceTotalMoney, dateNoteService);
            Text = "Add tollbills";

            dateTimePickerDate.Value = dateTimePickerDate.MaxDate;
            txtDiscountMoney.Text = "0";
            //Load NameRoom, RoomPrice của contractId, Debt, Total must pay here
            DataTable contractTable = contractBLT.searchContract(new Contract()
            {
                Id = contractId,
                IsValid = true
            });

            txtRoom.Text = (contractTable.Rows[0] as DataRow).Field<string>("ROOMNAME");
            txtPriceRoom.Text = (contractTable.Rows[0] as DataRow).Field<decimal>("PRICEROOM").ToString();
            DataTable debtTable = debtBLT.searchDebt(new Debt()
            {
                Contractid = contractId,
                DateSet = "", 
            });

            if(debtTable!=null && debtTable.Rows.Count>0)
            {
                txtDebt.Text = (debtTable.Rows[0] as DataRow).Field<decimal>("DEBTUNTILDATE").ToString();
            }
            totalMustPayOrg = (decimal.Parse(txtPriceRoom.Text) + decimal.Parse(txtTotalMoneyService.Text) + decimal.Parse(txtDebt.Text) - decimal.Parse(txtDiscountMoney.Text));
            txtTotal.Text = totalMustPayOrg.ToString();
        }

        public void Init(string serviceNoteId, string contractId, decimal serviceTotalMoney, string dateNoteService)
        {
            InitializeComponent();
            this.serviceNoteId = serviceNoteId;
            txtContractId.Text = contractId;
            lblServiceNoteId.Text += string.Format(serviceNoteId + ")");
            txtTotalMoneyService.Text = serviceTotalMoney.ToString();
            dateTimePickerDateNoteService.Text = dateNoteService;
            dateTimePickerDate.MaxDate = DateTime.Now;
            dgvServiceNoteDetail.AutoGenerateColumns = false;
            dgvServiceNoteDetail.AllowUserToDeleteRows = false;
            dgvServiceNoteDetail.AllowUserToAddRows = false;

            serviceNoteBLT = new ServiceNoteBLT();
            tollBillsBLT = new TollBillsBLT();
            contractBLT = new ContractBLT();
            debtBLT = new DebtBLT();

            //Load service note detail here
            var searchInfo = new ServiceNoteDetail()
            {
                Servicenoteid = serviceNoteId
            };

            dgvServiceNoteDetail.DataSource = serviceNoteBLT.searchServiceNoteDetail(searchInfo);

            txtDiscountMoney.KeyPress += TxtMoney_KeyPress;
            txtDiscountMoney.TextChanged += TxtDiscountMoney_TextChanged;
        }

        private void TollBillsEdit_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkContraints())
            {
                try
                {
                    TollBills tollBills = new TollBills()
                    {
                        Id = txtId.Text,
                        Datetoll = dateTimePickerDate.Text,
                        DiscountMoney = decimal.Parse(txtDiscountMoney.Text.Trim() == "" ? "0" : txtDiscountMoney.Text.Trim()),
                        DebtUntilDate = decimal.Parse(txtDebt.Text.Trim() == "" ? "0" : txtDebt.Text.Trim()),
                        Servicenoteid = serviceNoteId,
                        Note = txtNote.Text,
                        Total = decimal.Parse(txtTotal.Text.Trim() == "" ? "0" : txtTotal.Text.Trim())
                    };


                    if (this.Text == "Edit tollbills")
                    {
                        //Edit
                        if (tollBillsBLT.updateTollBill(tollBills))
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
                        if (tollBillsBLT.addTollBill(tollBills, out id))
                        {
                            MessageBox.Show("Insert tollbills of " + serviceNoteId.ToUpper() + " successfully!\nThe new tollbills Id = " + id + ".");
                            EditCompletedHandler(id);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Insert fail! Try again later.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TxtDiscountMoney_TextChanged(object sender, EventArgs e)
        { 
            txtTotal.Text = (totalMustPayOrg - decimal.Parse((txtDiscountMoney.Text==""?"0": txtDiscountMoney.Text))).ToString();
        }

        private void TxtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)))
            {
                e.Handled = true;
            }
        }
        
        private bool checkContraints()
        {
            if (decimal.Parse(txtDiscountMoney.Text) > 0 && txtNote.Text.Trim()=="")
            {
                MessageBox.Show("You must write reason why you discount money!");
                return false;
            }
            return true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable contractTable = contractBLT.searchContract(new Contract()
            {
                Id = txtContractId.Text,
                IsValid = true
            });

            var customerName = (contractTable.Rows[0] as DataRow).Field<string>("CUSTOMERNAME"); 

            DataTable serviceNotePrev = serviceNoteBLT.getServiceNotePrev(serviceNoteId);
            DateTime dateServiceNotePrev;
            if (serviceNotePrev.Rows==null || serviceNotePrev.Rows.Count==0)
            {
                dateServiceNotePrev = (contractTable.Rows[0] as DataRow).Field<DateTime>("BEGINDATE");
            }
            else
                dateServiceNotePrev = (serviceNotePrev.Rows[0] as DataRow).Field<DateTime>("DATE");
            string billRoomToValue = (contractTable.Rows[0] as DataRow).Field<DateTime>("BEGINDATE").Day.ToString() + "/"
                + dateTimePickerDateNoteService.Value.AddDays(30).Month.ToString() + "/"
                + dateTimePickerDateNoteService.Value.AddDays(30).Year.ToString();

            string reportEmbeddedResource = "MotelManage.Reports.PrintTollBills.rdlc";
            ReportParameter city = new ReportParameter("city", "TP.HCM", true);
            ReportParameter dayPrint = new ReportParameter("dayPrint");
            ReportParameter monthPrint = new ReportParameter("monthPrint");
            ReportParameter yearPrint = new ReportParameter("yearPrint");
            ReportParameter roomName = new ReportParameter("roomName", txtRoom.Text, true);
            
            ReportParameter billServiceFrom = new ReportParameter("billServiceFrom", dateServiceNotePrev.ToShortDateString(), true);
            ReportParameter billRoomTo = new ReportParameter("billRoomTo", billRoomToValue, true);

            ReportParameter contractId = new ReportParameter("contractId", txtContractId.Text, true);
            ReportParameter nameCustomer = new ReportParameter("nameCustomer", customerName, true);
            ReportParameter dateNoteService = new ReportParameter("dateNoteService", dateTimePickerDateNoteService.Value.ToShortDateString(), true);
            ReportParameter roomPrice = new ReportParameter("roomPrice", ContractEdit.ConvertDecimalToInt(txtPriceRoom.Text), true);
            ReportParameter debt = new ReportParameter("debt", ContractEdit.ConvertDecimalToInt(txtDebt.Text), true);
            ReportParameter totalMoneyService = new ReportParameter("totalMoneyService", ContractEdit.ConvertDecimalToInt(txtTotalMoneyService.Text), true);
            ReportParameter discountMoney = new ReportParameter("discountMoney", ContractEdit.ConvertDecimalToInt(txtDiscountMoney.Text), true);
            ReportParameter totalMoneyPay = new ReportParameter("totalMoneyPay", ContractEdit.ConvertDecimalToInt(txtTotal.Text), true);
            ReportParameter dayPay = new ReportParameter("dayPay", DateTime.Now.AddDays(5).ToShortDateString(), true);
            
            ReportParameter[] parameter = new ReportParameter[] { city,
                                                                  dayPrint,
                                                                  monthPrint,
                                                                  yearPrint,
                                                                  roomName,
                                                                  billServiceFrom,
                                                                  billRoomTo,
                                                                  contractId,
                                                                  nameCustomer,
                                                                  dateNoteService,
                                                                  roomPrice,
                                                                  debt,
                                                                  totalMoneyService,
                                                                  discountMoney,
                                                                  totalMoneyPay,
                                                                  dayPay};



            ReportBaseForm form = new ReportBaseForm("Print tollbills", reportEmbeddedResource, parameter, (dgvServiceNoteDetail.DataSource as DataTable));
            form.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            DataTable contractTable = contractBLT.searchContract(new Contract()
            {
                Id = txtContractId.Text,
                IsValid = true
            });

            var customerName = (contractTable.Rows[0] as DataRow).Field<string>("CUSTOMERNAME");

            ReceiptAdd receipt = new ReceiptAdd(txtContractId.Text, customerName, txtId.Text, txtTotal.Text, "");
            receipt.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
