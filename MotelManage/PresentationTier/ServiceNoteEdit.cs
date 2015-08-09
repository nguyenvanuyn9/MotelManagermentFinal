using MotelManage.BusinessLogicTier;
using MotelManage.DataTransferObject;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MotelManage.PresentationTier
{
    public partial class ServiceNoteEdit : Form
    {
        private ServiceNoteBLT serviceNoteBLT;
        private ContractBLT contractBLT;
        private TollBillsBLT tollBillsBLT;
        private DebtBLT debtBLT;

        public delegate void EditCompleteDelegate(String serviceNoteId);

        public EditCompleteDelegate EditCompletedHandler;

        public ServiceNoteEdit(ServiceNote serviceNote, string roomName, bool canEdit)
        {
            Init();
            Load += ServiceNoteEdit_Load;
            if (canEdit)
            {
                Text = "Edit service note";
            }
            else
            {
                Text = "Detail service note";
                btnSave.Text = "Close";
                btnSaveAndExport.Enabled = false;
            }

            txtId.Text = serviceNote.Id;
            dateTimePickerDate.Text = serviceNote.Date;
            cmbRoom.SelectedIndex = cmbRoom.FindStringExact(roomName);
            cmbRoom.Enabled = false;
            txtContractID.Text = serviceNote.Conntractid;
            txtTotalMoney.Text = serviceNote.Total.ToString();

            //Load service note detail here
            var searchInfo = new ServiceNoteDetail()
            {
                Servicenoteid = serviceNote.Id
            };

            dgvServiceNoteDetail.DataSource = serviceNoteBLT.searchServiceNoteDetail(searchInfo);
        }

        public ServiceNoteEdit()
        {
            Init();
            Text = "Add service note";
            cmbRoom.SelectedIndex = -1;
        }

        public void Init()
        {
            InitializeComponent();
            dateTimePickerDate.MaxDate = DateTime.Now;
            dgvServiceNoteDetail.AutoGenerateColumns = false;
            dgvServiceNoteDetail.AllowUserToDeleteRows = false;
            dgvServiceNoteDetail.AllowUserToAddRows = false;

            serviceNoteBLT = new ServiceNoteBLT();
            contractBLT = new ContractBLT();
            tollBillsBLT = new TollBillsBLT();
            debtBLT = new DebtBLT();

            var temp = new Contract()
            {
                IsValid = true
            };

            cmbRoom.DisplayMember = "ROOMNAME";
            cmbRoom.ValueMember = "ROOMID";
            cmbRoom.DataSource = contractBLT.searchContract(temp);
        }

        private void ServiceNoteEdit_Load(object sender, EventArgs e)
        {
            //Kiểm tra xem cột NumberOld nào có giá trị là -1 thì không cho sửa
            foreach (DataGridViewRow item in dgvServiceNoteDetail.Rows)
            {
                DataGridViewTextBoxCell celNumberOld = (DataGridViewTextBoxCell)item.Cells[1];
                //DataGridViewTextBoxCell celNumberNew = (DataGridViewTextBoxCell)item.Cells[2];
                //DataGridViewTextBoxCell celNumberUsed = (DataGridViewTextBoxCell)item.Cells[3];
                if(btnSave.Text=="Save")
                {
                    int numberOldValue = 0;
                    int.TryParse(celNumberOld.Value.ToString(), out numberOldValue);
                    if (numberOldValue == -1)
                    {
                        EnableCell(item.Cells[1], false);
                        EnableCell(item.Cells[2], false);
                    }
                    else
                    {
                        EnableCell(item.Cells[1], true);
                        EnableCell(item.Cells[2], true);
                    }
                }
                else
                {
                    EnableCell(item.Cells[1], false);
                    EnableCell(item.Cells[2], false);
                    EnableCell(item.Cells[3], false);
                    dateTimePickerDate.Enabled = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Close")
                this.Close();
            else
                SaveServiceNote();

        }

        private void btnSaveAndExport_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("If you export to Tollbills, you will not be able to edit or delete it again?\n\nDo you want to continues?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var serviceNoteId = SaveServiceNote();
                if (!string.IsNullOrEmpty(serviceNoteId))
                {
                    DataTable debtTable = debtBLT.searchDebt(new Debt()
                    {
                        Contractid = txtContractID.Text,
                        DateSet = "",
                    });

                    decimal debt = 0, priceRoom = 0, totalTollsBill = 0;
                    if (debtTable != null && debtTable.Rows.Count > 0)
                    {
                        debt = (debtTable.Rows[0] as DataRow).Field<decimal>("DEBTUNTILDATE");
                    }

                    DataTable contractTable = contractBLT.searchContract(new Contract()
                    {
                        Id = txtContractID.Text,
                        IsValid = true
                    });
                    if (contractTable != null && contractTable.Rows.Count > 0)
                    {
                        priceRoom = (contractTable.Rows[0] as DataRow).Field<decimal>("PRICEROOM");
                    }
                    totalTollsBill = priceRoom + decimal.Parse(txtTotalMoney.Text) + debt;

                    TollBills tollBills = new TollBills()
                    {
                        Datetoll = dateTimePickerDate.Text,
                        DiscountMoney = 0,
                        DebtUntilDate = debt,
                        Servicenoteid = serviceNoteId,
                        Note = "",
                        Total = totalTollsBill
                    };
                    
                    //Insert
                    string id;
                    if (tollBillsBLT.addTollBill(tollBills, out id))
                    {
                        MessageBox.Show("Export to Tollbills of " + serviceNoteId.ToUpper() + " successfully!\nThe new tollbills Id = " + id + ".");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Export fail! Try again later.");
                }
            }
        }

        private string SaveServiceNote()
        {
            string serviceNoteId = null;
            if (checkContraints())
            {
                try
                {
                    XElement xmlData = ConvertToXmlData();

                    ServiceNote svcn = new ServiceNote()
                    {
                        Id = txtId.Text,
                        Date = dateTimePickerDate.Text,
                        Total = decimal.Parse(txtTotalMoney.Text.Trim() == "" ? "0" : txtTotalMoney.Text.Trim()),
                        Conntractid = txtContractID.Text.Trim()
                    };


                    if (this.Text == "Edit service note")
                    {
                        //Edit
                        if (serviceNoteBLT.updateServiceNote(svcn, xmlData))
                        {
                            MessageBox.Show("Update " + txtId.Text.Trim().ToUpper() + " successfully!");
                            EditCompletedHandler(txtId.Text.Trim());
                            serviceNoteId = txtId.Text.Trim();
                            //this.Close();
                        }
                        else
                            MessageBox.Show("Update " + txtId.Text.ToUpper() + " fail!");
                    }
                    else
                    {
                        //Insert
                        string id;
                        if (serviceNoteBLT.addServiceNote(svcn, xmlData, out id))
                        {
                            MessageBox.Show("Insert service note of " + txtContractID.Text.Trim().ToUpper() + " successfully!\nThe new service note Id = " + id + ".");
                            EditCompletedHandler(id);
                            serviceNoteId = id;
                            //this.Close();
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
            return serviceNoteId;
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoom.SelectedIndex != -1)
            {
                txtContractID.Text = (cmbRoom.SelectedItem as DataRowView).Row["id"].ToString();
                txtTotalMoney.Text = "0";
                DataTable serviceList = contractBLT.getListContractDetail(txtContractID.Text);
                dgvServiceNoteDetail.DataSource = serviceList;

                foreach (DataGridViewRow item in dgvServiceNoteDetail.Rows)
                {
                    DataGridViewTextBoxCell celNumberOld = (DataGridViewTextBoxCell)item.Cells[1];
                    DataGridViewTextBoxCell celNumberNew = (DataGridViewTextBoxCell)item.Cells[2];
                    int numberOldValue = 0;
                    int.TryParse(celNumberOld.Value.ToString(), out numberOldValue);
                    if (numberOldValue == -1)
                    {
                        EnableCell(item.Cells[1], false);
                        EnableCell(item.Cells[2], false);
                    }
                    else
                    {
                        EnableCell(item.Cells[1], true);
                        EnableCell(item.Cells[2], true);
                    }
                }
            }
            else
            {
                dgvServiceNoteDetail.DataSource = null;
                txtContractID.Text = "";
            }
        }

        private void dgvServiceNoteDetail_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var currentCellAddr = dgvServiceNoteDetail.CurrentCellAddress;
            if ((currentCellAddr.X == 1 || currentCellAddr.X == 2 || currentCellAddr.X == 3)
                && e.Control is TextBox)
            {
                TextBox textBox = e.Control as TextBox;
                textBox.KeyPress += TxtMoney_KeyPress;
                textBox.TextChanged += TextBox_TextChanged;
            }
        }

        private void dgvServiceNoteDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int currentColIndex = dgvServiceNoteDetail.CurrentCell.ColumnIndex;
            if ((currentColIndex == 1 || currentColIndex == 2 || currentColIndex == 3)
                && dgvServiceNoteDetail.CurrentCell.EditedFormattedValue.ToString() == "")
            {
                dgvServiceNoteDetail.CurrentCell.Value = "0";
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            #region Vùng xử lí việc tự động tính toán total money từng hàng
            int numOld = 0, numNew = 0;
            var currentRow = dgvServiceNoteDetail.CurrentRow;

            currentRow.Cells[2].Style.ForeColor = currentRow.Cells[6].OwningColumn.DefaultCellStyle.ForeColor;
            currentRow.Cells[3].Style.ForeColor = currentRow.Cells[6].OwningColumn.DefaultCellStyle.ForeColor;

            int.TryParse(currentRow.Cells[1].EditedFormattedValue.ToString(), out numOld);
            int.TryParse(currentRow.Cells[2].EditedFormattedValue.ToString(), out numNew);

            if (dgvServiceNoteDetail.CurrentCell.ColumnIndex != 3)//Nếu chỉnh sửa khác ô Num used
            {
                currentRow.Cells[3].Value = numNew - numOld;
            }
            else// Nếu chỉnh sửa trong ô num used thì đặt giá trị âm cho hai ô Num New, Num Old
            {
                currentRow.Cells[1].Value = -1;
                currentRow.Cells[2].Value = -1;
            }


            int tempNumUsed = 0;
            int.TryParse(currentRow.Cells[3].EditedFormattedValue.ToString(), out tempNumUsed);

            if (tempNumUsed < 0)
            {
                currentRow.Cells[6].Value = "#INVALID";
                currentRow.Cells[6].Style.ForeColor = Color.Red;
            }
            else
            {
                //Sum total money here
                decimal money = tempNumUsed * decimal.Parse(currentRow.Cells[5].EditedFormattedValue.ToString() == "" ? "0" : currentRow.Cells[5].EditedFormattedValue.ToString());

                currentRow.Cells[6].Value = money;
                currentRow.Cells[6].Style.ForeColor = currentRow.Cells[6].OwningColumn.DefaultCellStyle.ForeColor;
            }
            #endregion

            #region Vùng xử lý việc tự động tính toán total money tổng các hàng (ở TextBoxTotal)
            decimal total = 0;
            foreach (var item in dgvServiceNoteDetail.Rows)
            {
                decimal cellTotalValue;
                if (decimal.TryParse((item as DataGridViewRow).Cells[6].EditedFormattedValue.ToString(), out cellTotalValue))
                    total += cellTotalValue;
            }

            txtTotalMoney.Text = total.ToString();
            #endregion
        }

        private void TxtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                || ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1)))
            {
                e.Handled = true;
            }
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

        private void dgvServiceNoteDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentColIndex = dgvServiceNoteDetail.CurrentCell.ColumnIndex;
            if ((currentColIndex == 1 || currentColIndex == 2 || currentColIndex == 3)
                && dgvServiceNoteDetail.CurrentCell.EditedFormattedValue.ToString() == "0")
            {
                dgvServiceNoteDetail.CurrentCell.Value = "";
            }
        }

        private XElement ConvertToXmlData()
        {
            XElement XmlData = null;
            try
            {
                if (dgvServiceNoteDetail.Rows.Count > 0)
                {
                    DataTable table = dgvServiceNoteDetail.DataSource as DataTable;

                    XmlData = new XElement(new XElement("Root"));

                    foreach (DataGridViewRow item in dgvServiceNoteDetail.Rows)
                    {
                        XElement xml = new XElement("XmlData");
                        if (Text == "Edit service note")
                        {
                            xml.Add(new XElement("ID", (table.Rows[item.Index] as DataRow).Field<string>("ID")));
                            xml.Add(new XElement("SERVICENOTEID", (table.Rows[item.Index] as DataRow).Field<string>("SERVICENOTEID")));
                        }
                        xml.Add(new XElement("SERVICEID", (table.Rows[item.Index] as DataRow).Field<string>("SERVICEID")));
                        xml.Add(new XElement("NUMBEROLD", item.Cells["clNumberOld"].Value));
                        xml.Add(new XElement("NUMBERNEW", item.Cells["clNumberNew"].Value));
                        xml.Add(new XElement("NUMBERUSED", item.Cells["clNumberUsed"].Value));
                        xml.Add(new XElement("TOTAL", item.Cells["clTotalMoney"].Value.ToString().Replace(',', '.')));
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

        private bool checkContraints()
        {
            foreach (DataGridViewRow item in dgvServiceNoteDetail.Rows)
            {
                if (int.Parse(item.Cells["clNumberOld"].Value.ToString()) > int.Parse(item.Cells["clNumberNew"].Value.ToString()))
                {
                    item.Cells["clNumberNew"].Style.ForeColor = Color.Red;
                    MessageBox.Show("Number old must less than Number new!");
                    return false;
                }
                if (int.Parse(item.Cells["clNumberUsed"].Value.ToString()) < 0)
                {
                    item.Cells["clNumberUsed"].Style.ForeColor = Color.Red;
                    MessageBox.Show("Number used is invalid!");
                    return false;
                }
            }
            return true;
        }

    }
}
