using Microsoft.Reporting.WinForms;
using MotelManage.BusinessLogicTier;
using MotelManage.DataTransferObject;
using MotelManage.Reports;
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
    public partial class ContractEdit : Form
    {
        private ServiceBLT serviceBLT;
        private ContractBLT contractBLT;
        private RoomBLT roomBLT;
        private CustomerBLT customerBLT;
        private string serviceId = "";
        decimal restMoney = 0;

        public delegate void EditCompleteDelegate(String contractId);

        public EditCompleteDelegate EditCompletedHandler;

        public ContractEdit(Contract contract, string customerName, string roomName, bool canEdit/*, ContractStatus contractStatus*/)
        {
            Init();
            cmbRoom.DataSource = roomBLT.getListRoom();
            Text = "Edit contract";
            if (canEdit)
            {
                cmbContractStatus.Visible = false;
            }
            else
            {
                ckbIsBooked.Enabled = false;
                dateTimePickerBeginDate.Enabled = false;
                dateTimePickerEndDate.Enabled = false;
                cmbCustomer.Enabled = false;
                btnAddCustomer.Enabled = false;
                txtDuration.ReadOnly = true;
                txtPriceRoom.ReadOnly = true;
                txtDeposit.ReadOnly = true;
                cmbRoom.Enabled = false;
                lblBail.Text = "Contract status";
                cmbContractStatus.Visible = true;
                cmbContractStatus.DisplayMember = "Display";
                cmbContractStatus.ValueMember = "Value";
                cmbContractStatus.DataSource = new List<ContractStatus>()
                {
                    new ContractStatus() { Value = false, Display = "InValid" },
                    new ContractStatus() { Value = true, Display = "Valid" }
                };
                cmbContractStatus.SelectedValue = contract.IsValid;

                txtContractId.Size = new Size(txtDeposit.Size.Width, txtContractId.Size.Height);
                cmbCustomer.Size = new Size(cmbRoom.Size.Width, cmbCustomer.Size.Height);
                cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
                txtBail.Visible = false;
                txtRest.Visible = false;
                btnAddCustomer.Visible = false;
                ckbIsBooked.Visible = false;

                tabControl1.Location = new Point(tabControl1.Location.X, tabControl1.Location.Y - 38);
                btnPrint.Location = new Point(btnPrint.Location.X, btnPrint.Location.Y - 38);
                btnPayment.Location = new Point(btnPayment.Location.X, btnPayment.Location.Y - 38);
                btnSave.Location = new Point(btnSave.Location.X, btnSave.Location.Y - 38);
                btnClose.Location = new Point(btnClose.Location.X, btnClose.Location.Y - 38);
                this.Size = new Size(this.Size.Width, this.Size.Height - 38);

                btnPayment.Enabled = false;
            }

            txtContractId.Text = contract.Id;
            dateTimePickerDateEstablish.Text = contract.Setdate;
            dateTimePickerBeginDate.Text = contract.Begindate;
            dateTimePickerEndDate.Text = contract.Enddate;
            cmbCustomer.SelectedIndex = cmbCustomer.FindStringExact(customerName);

            cmbRoom.SelectedIndex = cmbRoom.FindStringExact(roomName);
            txtPriceRoom.Text = contract.PriceRoom.ToString();
            txtDeposit.Text = contract.Deposit.ToString();
            restMoney = contract.PriceRoom + contract.Deposit;
            txtRest.Text = restMoney.ToString();

            dgvService.DataSource = serviceBLT.getListServiceWithContractDetail(txtContractId.Text);
        }

        public ContractEdit()
        {
            Init();
            Text = "Add contract";
            cmbRoom.DataSource = roomBLT.searchRoom(new Room() { StatusID = "RMS0000001" });//Lấy danh sách phòng có trạng thái là Available
            cmbRoom.SelectedIndex = -1;
            cmbCustomer.SelectedIndex = -1;
            cmbContractStatus.Visible = false;
            dgvService.DataSource = serviceBLT.getListServiceWithContractDetail("");
        }

        public void Init()
        {
            InitializeComponent();
            Load += ContractEdit_Load;
            contractBLT = new ContractBLT();
            serviceBLT = new ServiceBLT();
            roomBLT = new RoomBLT();
            customerBLT = new CustomerBLT();
            dateTimePickerBeginDate.MaxDate = DateTime.Now;
            dateTimePickerBeginDate.Value = dateTimePickerBeginDate.MaxDate;
            dateTimePickerEndDate.Value = dateTimePickerBeginDate.MaxDate;
            dgvService.AutoGenerateColumns = false;
            dgvService.AllowUserToDeleteRows = false;
            dgvService.AllowUserToAddRows = false;

            cmbRoom.DisplayMember = "NAME";
            cmbRoom.ValueMember = "ID";

            cmbCustomer.DisplayMember = "NAME";
            cmbCustomer.ValueMember = "ID";
            cmbCustomer.DataSource = customerBLT.getListCustomer();

            txtDuration.KeyPress += TxtMoney_KeyPress;
            txtPriceRoom.KeyPress += TxtMoney_KeyPress;
            txtDeposit.KeyPress += TxtMoney_KeyPress;
            txtBail.KeyPress += TxtMoney_KeyPress;
            txtRest.KeyPress += TxtMoney_KeyPress;

            txtPriceRoom.TextChanged += TxtMoney_TextChanged;
            txtDeposit.TextChanged += TxtMoney_TextChanged;
        }

        private void ContractEdit_Load(object sender, EventArgs e)
        {
            DataTable serviceList = dgvService.DataSource as DataTable;
            foreach (DataGridViewRow item in dgvService.Rows)
            {
                if (item.Index == 0 || item.Index == 1)
                {
                    item.Cells[3].Value = true;
                    EnableCell(item.Cells[3], false);
                }
                else
                    break;
            }
        }

        private XElement ConvertToXmlData()
        {
            XElement XmlData = null;
            try
            {
                if (dgvService.Rows.Count > 0)
                {
                    DataTable table = dgvService.DataSource as DataTable;

                    XmlData = new XElement(new XElement("Root"));

                    foreach (DataGridViewRow item in dgvService.Rows)
                    {
                        XElement xml = new XElement("XmlData");
                        if (Text == "Edit contract")
                        {
                            //Chỗ này tìm ContractDetailId trước đó để bỏ vào đây
                            xml.Add(new XElement("ID", (table.Rows[item.Index] as DataRow).Field<string>("CONTRACTDETAILID")));
                            xml.Add(new XElement("ISVALID", (item.Cells["clSelect"].Value)));
                            //xml.Add(new XElement("SERVICEID", (table.Rows[item.Index] as DataRow).Field<string>("SERVICEID")));
                        }
                        //else//Chỗ này kiểm tra xem clSelect đó có được check không? Nếu dc check thì mới add vào.
                        if ((bool)item.Cells["clSelect"].Value)
                            xml.Add(new XElement("SERVICEID", (table.Rows[item.Index] as DataRow).Field<string>("SERVICEID")));
                        XmlData.Add(xml);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return XmlData;
        }

        private void TxtMoney_TextChanged(object sender, EventArgs e)
        {
            txtRest.Text = (decimal.Parse((txtPriceRoom.Text.Trim() == "" ? "0" : txtPriceRoom.Text))
                + decimal.Parse((txtDeposit.Text.Trim() == "" ? "0" : txtDeposit.Text))
                - decimal.Parse((txtBail.Text.Trim() == "" ? "0" : txtBail.Text))).ToString();
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
            if (cmbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("You must choose Customer!");
                return false;
            }
            if (cmbRoom.SelectedIndex == -1)
            {
                MessageBox.Show("You must choose room!");
                return false;
            }

            decimal priceRoom;
            if (!decimal.TryParse(txtPriceRoom.Text, out priceRoom) || priceRoom <= 0)
            {
                MessageBox.Show("The price room is invalid!");
                return false;
            }
            decimal deposit;
            if (!decimal.TryParse(txtDeposit.Text, out deposit) || deposit <= 0)
            {
                MessageBox.Show("The deposit is invalid!");
                return false;
            }
            return true;
        }

        private void EnableCell(DataGridViewCell dc, bool enabled)
        {
            //toggle read-only state
            dc.ReadOnly = !enabled;
            if (enabled)
            {
                //restore cell style to the default value
                dc.Style.BackColor = dc.OwningColumn.DefaultCellStyle.BackColor;
                dc.Style.ForeColor = dc.OwningColumn.DefaultCellStyle.ForeColor;
                dc.Style.SelectionBackColor = dc.OwningColumn.DefaultCellStyle.SelectionBackColor;
                dc.Style.SelectionForeColor = dc.OwningColumn.DefaultCellStyle.SelectionForeColor;
            }
            else
            {
                //gray out the cell
                dc.Style.BackColor = Color.Gainsboro;
                dc.Style.ForeColor = Color.Black;
                dc.Style.SelectionBackColor = Color.Gainsboro;
                dc.Style.SelectionForeColor = Color.Black;
            }
        }

        private void dateTimePickerBeginDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEndDate.MinDate = dateTimePickerBeginDate.Value;
            dateTimePickerEndDate_ValueChanged(sender, e);
        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerBeginDate.Value.Year == dateTimePickerEndDate.Value.Year
                && dateTimePickerBeginDate.Value.Month == dateTimePickerEndDate.Value.Month
                && dateTimePickerBeginDate.Value.Day == dateTimePickerEndDate.Value.Day)
            {
                txtDuration.Text = "-";
            }
            else
            {
                int month = dateTimePickerEndDate.Value.Month - dateTimePickerBeginDate.Value.Month;
                int year = dateTimePickerEndDate.Value.Year - dateTimePickerBeginDate.Value.Year;
                int day = dateTimePickerEndDate.Value.Day - dateTimePickerBeginDate.Value.Day;

                month += year * 12 + (day > 0 ? 1 : 0);
                txtDuration.Text = month.ToString();
            }
        }

        private void FormCustomerEdit_Completed(string cusId, string cusName)
        {
            DataTable cusList = customerBLT.getListCustomer();
            cmbCustomer.DataSource = cusList;
            cmbCustomer.SelectedIndex = cmbCustomer.FindStringExact(cusName);

            txtCustomerId.Text = cusId;
            txtCustomerName.Text = cusName;
            txtCMND.Text = cusList.Rows[cmbCustomer.SelectedIndex].Field<string>("Identity Card");
            txtPhone.Text = cusList.Rows[cmbCustomer.SelectedIndex].Field<string>("Phone");
            txtAddress.Text = cusList.Rows[cmbCustomer.SelectedIndex].Field<string>("Address");
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex > -1)
            {
                DataTable cusList = cmbCustomer.DataSource as DataTable;
                txtCustomerId.Text = cusList.Rows[cmbCustomer.SelectedIndex].Field<string>("ID");
                txtCustomerName.Text = cusList.Rows[cmbCustomer.SelectedIndex].Field<string>("Name");
                txtCMND.Text = cusList.Rows[cmbCustomer.SelectedIndex].Field<string>("Identity Card");
                txtPhone.Text = cusList.Rows[cmbCustomer.SelectedIndex].Field<string>("Phone");
                txtAddress.Text = cusList.Rows[cmbCustomer.SelectedIndex].Field<string>("Address");
                btnEditCustomer.Enabled = true;
            }
            else
            {
                txtCustomerId.Text = "";
                txtCustomerName.Text = "";
                txtCMND.Text = "";
                txtPhone.Text = "";
                txtAddress.Text = "";
                btnEditCustomer.Enabled = false;
            }
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoom.SelectedIndex > -1)
            {
                DataTable roomSelect = cmbRoom.DataSource as DataTable;
                txtPriceRoom.Text = roomSelect.Rows[cmbRoom.SelectedIndex].Field<decimal>("PRICE").ToString();
                txtDeposit.Text = roomSelect.Rows[cmbRoom.SelectedIndex].Field<decimal>("DEPOSIT").ToString();
            }
            else
            {
                txtPriceRoom.Text = "0";
                txtDeposit.Text = "0";
            }
        }

        private void ckbIsBooked_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckbIsBooked.Checked)
            {
                cmbRoom.Enabled = true;
                cmbCustomer.Size = new Size(142, cmbCustomer.Size.Height);
                cmbCustomer.DropDownStyle = ComboBoxStyle.DropDown;
                cmbCustomer.Enabled = true;
                btnAddCustomer.Visible = true;
                cmbRoom.DataSource = roomBLT.searchRoom(new Room() { StatusID = "RMS0000001" });
            }
            else
            {
                //Call SearchRoomBook here
                var bookedSearch = new RoomBookSearch();
                bookedSearch.SearchCompletedHandler += FormSearchBooked_Completed;
                bookedSearch.ShowDialog();
            }
        }

        private void FormSearchBooked_Completed(RoomBook roomBook, string roomName, string customerName)
        {
            cmbRoom.Enabled = false;
            cmbCustomer.Size = new Size(cmbRoom.Size.Width, cmbCustomer.Size.Height);
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.Enabled = false;
            btnAddCustomer.Visible = false;
            cmbRoom.DataSource = roomBLT.getListRoom();

            cmbRoom.SelectedIndex = cmbRoom.FindStringExact(roomName);
            cmbCustomer.SelectedIndex = cmbCustomer.FindStringExact(customerName);
            txtBail.Text = roomBook.Deposit.ToString();
        }

        #region Button Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkContraints())
            {
                try
                {
                    XElement xmlData = ConvertToXmlData();

                    Contract contract = new Contract()
                    {
                        Id = txtContractId.Text,
                        Setdate = dateTimePickerDateEstablish.Text,
                        Begindate = dateTimePickerBeginDate.Text,
                        Enddate = dateTimePickerEndDate.Text,
                        Customerid = txtCustomerId.Text,
                        Roomid = cmbRoom.SelectedValue.ToString(),
                        PriceRoom = decimal.Parse(txtPriceRoom.Text.Trim() == "" ? "0" : txtPriceRoom.Text.Trim()),
                        Deposit = decimal.Parse(txtDeposit.Text.Trim() == "" ? "0" : txtDeposit.Text.Trim()),
                        IsValid = bool.Parse(cmbContractStatus.SelectedValue.ToString()),
                        Note = rtxtNote.Text
                    };


                    if (this.Text == "Edit contract")
                    {
                        //Edit
                        if (contractBLT.updateContract(contract, xmlData))
                        {
                            MessageBox.Show("Update " + txtContractId.Text.Trim().ToUpper() + " successfully!");
                            EditCompletedHandler(txtContractId.Text.Trim());
                            this.Close();
                        }
                        else
                            MessageBox.Show("Update " + txtContractId.Text.ToUpper() + " fail!");
                    }
                    else
                    {
                        //Insert
                        string id;
                        if (contractBLT.addContract(contract, xmlData, out id))
                        {
                            MessageBox.Show("Insert new contract successfully!\nThe new contract Id = " + id + ".");
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var motel = HouseHolderInfo.ReadXML();

            string reportEmbeddedResource = "MotelManage.Reports.PrintContract.rdlc";
            ReportParameter city = new ReportParameter("city", "TP.HCM", true);
            ReportParameter dayPrint = new ReportParameter("dayPrint");
            ReportParameter monthPrint = new ReportParameter("monthPrint");
            ReportParameter yearPrint = new ReportParameter("yearPrint");
            ReportParameter addressHouse = new ReportParameter("addressHouse", string.IsNullOrEmpty(motel.Address)?null: motel.Address, true);
            ReportParameter nameHolder = new ReportParameter("nameHolder", string.IsNullOrEmpty(motel.Address)?null:motel.HouseHolder.Name, true);
            ReportParameter cmndHolder = new ReportParameter("cmndHolder", string.IsNullOrEmpty(motel.Address) ? null : motel.HouseHolder.Cmnd, true);
            ReportParameter addressHolder = new ReportParameter("addressHolder", string.IsNullOrEmpty(motel.Address) ? null : motel.HouseHolder.Address, true);
            ReportParameter phoneHolder = new ReportParameter("phoneHolder", string.IsNullOrEmpty(motel.Address) ? null : motel.HouseHolder.Phone, true);
            ReportParameter nameCustomer = new ReportParameter("nameCustomer", txtCustomerName.Text, true);
            ReportParameter cmndCustomer = new ReportParameter("cmndCustomer", txtCMND.Text, true);
            ReportParameter addressCustomer = new ReportParameter("addressCustomer", txtAddress.Text, true);
            ReportParameter phoneCustomer = new ReportParameter("phoneCustomer", txtPhone.Text, true);

            DataTable roomSelect = cmbRoom.DataSource as DataTable;
            ReportParameter roomNote = new ReportParameter("roomNote", roomSelect.Rows[cmbRoom.SelectedIndex].Field<string>("NOTE").ToString(), true);
            ReportParameter roomName = new ReportParameter("roomName", roomSelect.Rows[cmbRoom.SelectedIndex].Field<string>("NAME").ToString(), true);
            ReportParameter roomPrince = new ReportParameter("roomPrice", ConvertDecimalToInt(roomSelect.Rows[cmbRoom.SelectedIndex].Field<decimal>("PRICE").ToString()), true);
            ReportParameter roomDeposit = new ReportParameter("roomDeposit", ConvertDecimalToInt(roomSelect.Rows[cmbRoom.SelectedIndex].Field<decimal>("DEPOSIT").ToString()), true);

            string electric = string.Empty;
            string water = string.Empty;
            string anotherService = string.Empty;
            foreach (DataGridViewRow item in dgvService.Rows)
            {
                if (item.Index == 0)
                {
                    electric = ConvertDecimalToInt(item.Cells[1].Value.ToString());
                }
                else if (item.Index == 1)
                {
                    water = ConvertDecimalToInt(item.Cells[1].Value.ToString());
                }
                else
                {
                    if(bool.Parse(item.Cells[3].Value.ToString()))
                    {
                        anotherService += item.Cells[0].Value.ToString();
                        anotherService += " (";
                        anotherService += ConvertDecimalToInt(item.Cells[1].Value.ToString(), true);
                        anotherService += " VND/";
                        anotherService += item.Cells[2].Value.ToString();
                        anotherService += "), ";
                    }
                }
            }
            anotherService = anotherService.Remove(anotherService.LastIndexOf(',')).Trim();


            ReportParameter roomElectricService = new ReportParameter("roomElectricService", electric, true);
            ReportParameter roomWaterService = new ReportParameter("roomWaterService", water, true);
            ReportParameter roomAnotherServiceRegister = new ReportParameter("roomAnotherServiceRegister", anotherService, true);

            string timeRentValue=string.Empty;
            if(string.Equals(txtDuration.Text, "-"))
            {
                timeRentValue = "Từ ngày " + dateTimePickerBeginDate.Value.ToShortDateString();
            }
            else
            {
                timeRentValue = txtDuration.Text + " tháng, từ ngày "
                    + dateTimePickerBeginDate.Value.ToShortDateString() + " đến ngày "
                     + dateTimePickerEndDate.Value.ToShortDateString();
            }

            ReportParameter timeRent = new ReportParameter("timeRent", timeRentValue, true);
            ReportParameter dayBill = new ReportParameter("dayBill", dateTimePickerBeginDate.Value.Day.ToString(), true);
            
            ReportParameter[] parameter = new ReportParameter[] { city,
                                                                  dayPrint,
                                                                  monthPrint,
                                                                  yearPrint,
                                                                  addressHouse,
                                                                  nameHolder,
                                                                  cmndHolder,
                                                                  addressHolder,
                                                                  phoneHolder,
                                                                  nameCustomer,
                                                                  cmndCustomer,
                                                                  addressCustomer,
                                                                  phoneCustomer,
                                                                  roomNote,
                                                                  roomName,
                                                                  roomPrince,
                                                                  roomElectricService,
                                                                  roomWaterService,
                                                                  roomAnotherServiceRegister,
                                                                  roomDeposit,
                                                                  timeRent,
                                                                  dayBill};

            ReportBaseForm form = new ReportBaseForm("Print contract", reportEmbeddedResource, parameter, null);
            form.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            ReceiptAdd receipt = new ReceiptAdd(txtContractId.Text, txtCustomerName.Text, "", txtRest.Text, "Kí hợp đồng thuê nhà");
            receipt.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer()
            {
                Id = txtCustomerId.Text,
                Name = txtCustomerName.Text,
                Address = txtAddress.Text,
                Cmnd = txtCMND.Text,
                Phonenumber = txtPhone.Text
            };

            CustomerEdit cusEdit = new CustomerEdit(cus);
            cusEdit.EditCompletedHandler += FormCustomerEdit_Completed;
            cusEdit.ShowDialog();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerAdd cusEdit = new CustomerAdd();
            cusEdit.EditCompletedHandler += FormCustomerEdit_Completed;
            cusEdit.ShowDialog();
        }
        #endregion

        public static string ConvertDecimalToInt(string moneyValue, bool isAddSeparate=false)
        {
            moneyValue = moneyValue.Remove(moneyValue.LastIndexOf(','));

            if(isAddSeparate)
            {
                var temp = moneyValue;

                while (temp.Length > 3)
                {
                    temp = moneyValue.Substring(0, temp.Length - 3);
                    moneyValue = moneyValue.Insert(moneyValue.IndexOf(temp) + temp.Length, ".");
                }
            }

            return moneyValue;
        }
    }
}

