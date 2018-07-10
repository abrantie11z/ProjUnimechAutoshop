using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using DevExpress.DashboardWin;
using System.IO;

namespace ProjFitterShop2
{
    class Entry
    {
        public static Dictionary<int, Tuple<bool, int, double,double>> CustomerPurchaseData;
        UmitechXtraReport report;
        ReportPrintTool printTool;
        public static bool PrintSingle;
       

        public void LoadEntryRecords(string frmName, GridControl gc, Label status, bool canRead, bool canEdit)
        {
            if (!canRead && !canEdit)
                return;
            if (gc.DataSource != null)
                return;
            switch (frmName)
            {
                case "navigationPage5":
                    Setup.query = "select * from vwCustomer";
                    break;
                case "navigationPage7":
                    Setup.query = "select * from vwCarService";
                    break;
                case "navigationPage10":
                    Setup.query = "select * from vwEmployee";
                    break;
            }
            Setup.PopulateDGV(gc, status, Setup.query);
        }
        public void SaveCustomerRecord(TextEdit fname, TextEdit sname, TextEdit cusID, LookUpEdit title, TextEdit address, TextEdit phone, MemoEdit remarks, DateEdit dateCreated, CheckEdit status, string tableName, bool canWrite, BarCheckItem editing, int currentRow)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                XtraMessageBox.Show("Full Name Required", "Specify Customer Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fname.Focus();
                return;
            }
            if (title.EditValue == null)
            {
                XtraMessageBox.Show("Select a Title ", "Specify Customer Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                title.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(phone.Text))
            {
                XtraMessageBox.Show("Enter custmer's Phone number ", "Phone Number Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                phone.Focus();
            }
            string[] numbers = phone.Text.Split(',');
            int phoneNum = 0;

            foreach (string num in numbers)
            {
                if (!int.TryParse(num, out phoneNum))
                {
                    XtraMessageBox.Show("Separate each phone number with a comma if more than 1", "Phone number not in right format", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    phone.Focus();
                    return;
                }
            }
            string[] names = fname.Text.Split(' ');
            string ID = "";
            foreach (string name in names)
            {
                ID += name[0];

            }
            cusID.Text = ID.ToUpper() + numbers[0];
            Setup.comm = new SqlCommand();
            Setup.comm.Parameters.Add(new SqlParameter("@FName", fname.Text));
            Setup.comm.Parameters.Add(new SqlParameter("@SName", sname.Text));
            Setup.comm.Parameters.Add(new SqlParameter("@CusID", cusID.Text));
            Setup.comm.Parameters.Add(new SqlParameter("@Title", title.EditValue));
            Setup.comm.Parameters.Add(new SqlParameter("@Address", address.Text));

            Setup.comm.Parameters.Add(new SqlParameter("@Phone", phone.Text));
            Setup.comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            Setup.comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            Setup.comm.Parameters.Add(new SqlParameter("@Status", status.Checked));

            try
            {
                using (Setup.connx = new SqlConnection(Setup.connString))
                {
                    Setup.connx.Open();
                    if (!Setup.mode[4])
                    {
                        Setup.comm.CommandText = "select cusID from etblCustomer where cusCustomerID=@CusID";
                        Setup.comm.Connection = Setup.connx;
                        Setup.reader = Setup.comm.ExecuteReader();
                        while (Setup.reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Customer Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        Setup.reader.Close();
                        Setup.comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        Setup.comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        Setup.comm.CommandText = "Insert into etblCustomer (cusTID,cusfname,cussname,cusCustomerID,cusAddress,cusPhone,cusremarks,cusDateCreated,cusstatus,cusCreatorID,cusCreatedDate) values(@Title,@fname,@sname,@CusID,@Address,@Phone,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        Setup.primaryKey = Convert.ToInt32(Setup.comm.ExecuteScalar());
                        Setup.dataSet.Tables[tableName].Rows.Add(Setup.primaryKey, title.Text, fname.Text, sname.Text, cusID.Text, address.Text, phone.Text, remarks.Text, dateCreated.DateTime, status.Checked, Setup.UserName);
                        XtraMessageBox.Show(fname.Text + " Saved Sussusfully", "Title Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        Setup.comm.Parameters.Add(new SqlParameter("@EditorID", 1));
                        Setup.comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        Setup.comm.Parameters.Add(new SqlParameter("@ID", Setup.dataSet.Tables[tableName].Rows[currentRow].ItemArray[0]));

                        Setup.comm.Parameters.Add(new SqlParameter("@UserName", Setup.dataSet.Tables[tableName].Rows[currentRow].ItemArray[10]));
                        Setup.comm.CommandText = "select cusID from etblCustomer where cusFName=@Fname and cusID !=@ID";
                        Setup.comm.Connection = Setup.connx;
                        Setup.reader = Setup.comm.ExecuteReader();
                        while (Setup.reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Customer Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        Setup.reader.Close();
                        Setup.comm.CommandText = "Update etblcustomer set cusfname=@fname, cussname=@sname,custID=@Title,cusCustomerID=@CusID,cusAddress=@Address,cusPhone=@Phone,cusremarks=@remarks,cusStatus=@status,cusEditorID=@EditorID,cusEditedDate=@EditedDate where cusID=@ID";
                        Setup.comm.ExecuteNonQuery();
                        Setup.dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { Setup.comm.Parameters["@ID"].Value, title.Text, fname.Text, sname.Text, cusID.Text, address.Text, phone.Text, remarks.Text, dateCreated.DateTime, status.Checked, Setup.comm.Parameters["@UserName"].Value };

                        XtraMessageBox.Show(fname.Text + " Updated Sussusfully", "Customer Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void SaveCustomerCarRecord(LookUpEdit customer,LookUpEdit car, TextEdit VIN, TextEdit registrationNum,MemoEdit remarks, DateEdit dateCreated, CheckEdit status, string tableName, bool canWrite, BarCheckItem editing, int currentRow)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
            if (customer.EditValue == null)
            {
                XtraMessageBox.Show("Select a Customer ", "Specify Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                customer.Focus();
                return;
            }
            if (car.EditValue == null)
            {
                XtraMessageBox.Show("Select a car ", "Specify Customer Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                car.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(VIN.Text))
            {
                XtraMessageBox.Show("Enter car unique VIN ", "Car VIN Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VIN.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(registrationNum.Text))
            {
                XtraMessageBox.Show("Enter car registration number ", "Car registration Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                registrationNum.Focus();
                return;
            }
           
            Setup.comm = new SqlCommand();
            Setup.comm.Parameters.Add(new SqlParameter("@Customer", customer.EditValue));
            Setup.comm.Parameters.Add(new SqlParameter("@Car",car.EditValue));
            Setup.comm.Parameters.Add(new SqlParameter("@VIN", VIN.Text));
            Setup.comm.Parameters.Add(new SqlParameter("@RegNum", registrationNum.Text));
           
            Setup.comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            Setup.comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            Setup.comm.Parameters.Add(new SqlParameter("@Status", status.Checked));

            try
            {
                using (Setup.connx = new SqlConnection(Setup.connString))
                {
                    Setup.connx.Open();
                    if (!Setup.mode[19])
                    {
                        Setup.comm.CommandText = "Select ccID from etblCustomerCar where ccVIN=@VIN or ccRegistrationNum=@RegNum";
                        Setup.comm.Connection = Setup.connx;
                        Setup.reader = Setup.comm.ExecuteReader();
                        while (Setup.reader.Read())
                        {
                            XtraMessageBox.Show("A customer with a similar car VIN or car number already exist!", "Car VIN or Registration Number Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        Setup.reader.Close();
                        Setup.comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        Setup.comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        Setup.comm.CommandText = "Insert into etblCustomerCar (ccCusID,ccCarID,ccVIN,ccRegistrationNum,ccremarks,ccDateCreated,ccstatus,ccCreatorID,ccCreatedDate) values(@Customer,@Car,@VIN,@RegNum,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        Setup.primaryKey = Convert.ToInt32(Setup.comm.ExecuteScalar());
                        Setup.dataSet.Tables[tableName].Rows.Add(Setup.primaryKey,customer.Text,car.Text,VIN.Text,registrationNum.Text, remarks.Text, dateCreated.DateTime, status.Checked, Setup.UserName);
                        XtraMessageBox.Show(customer.Text + " Car  Saved Sussusfully", "Customer Car Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        Setup.comm.Parameters.Add(new SqlParameter("@EditorID", Setup.userID));
                        Setup.comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        Setup.comm.Parameters.Add(new SqlParameter("@ID", Setup.dataSet.Tables[tableName].Rows[currentRow].ItemArray[0]));

                        Setup.comm.Parameters.Add(new SqlParameter("@UserName", Setup.dataSet.Tables[tableName].Rows[currentRow].ItemArray[8]));
                        Setup.comm.CommandText = "Select ccID from etblCustomerCar where ccID !=@ID and (ccVIN=@VIN or ccRegistrationNum=@RegNum)";
                        Setup.comm.Connection = Setup.connx;
                        Setup.reader = Setup.comm.ExecuteReader();
                        while (Setup.reader.Read())
                        {
                            XtraMessageBox.Show("A customer with a similar car VIN or car number already exist!", "Car VIN or Registration Number Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        Setup.reader.Close();
                        Setup.comm.CommandText = "Update etblCustomerCar set ccCusID=@Customer,ccCarID=@Car,ccVIN=@VIN,ccRegistrationNum=@RegNum,ccremarks=@remarks,ccDateCreated=@DateCreated,ccStatus=@status,ccEditorID=@EditorID,ccEditedDate=@EditedDate where ccID=@ID";
                        Setup.comm.ExecuteNonQuery();
                        Setup.dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { Setup.comm.Parameters["@ID"].Value, customer.Text, car.Text, VIN.Text, registrationNum.Text, remarks.Text, dateCreated.DateTime, status.Checked, Setup.comm.Parameters["@UserName"].Value };

                        XtraMessageBox.Show(customer.Text + " Car Updated Sussusfully", "Customer Car Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void LoadProductAndServices(GridControl gc, Label status,bool canRead,bool canWrite,bool canEdit)
        {
            if (!canRead && !canWrite && !canEdit)
                return;
            if (gc.DataSource == null)
            {
                Setup.query = "Select * from vwProductAndServices ";
                Setup.PopulateDGV(gc, status, Setup.query);
                gc.RefreshDataSource();
            }
        }
        public void LoadUsers(GridControl gc,Label status, bool canRead, bool canWrite, bool canEdit)
        {
            if (!canRead || !canWrite || !canEdit)
                return;
            if (gc.DataSource == null)
            {
                Setup.query = "Select sfID,sfFullName,sfStaffID,jtFName,etFName,sfImage from vwEmployee where sfStatus=1";
                Setup.PopulateDGV(gc, status, Setup.query);
              
            }
        }

        //Improve, cant accept negative in new sales and shouldnt pay more than already payed when editing
        public void SaveDailySalesRecord(LookUpEdit customer, string customerID,string car, LookUpEdit regNum, LookUpEdit servType,TextEdit amount,TextEdit allPayments, DateEdit dateCreated, MemoEdit remarks, string carServTable, string cusPurchaseTable, bool canWrite, BarCheckItem editing, int currentRow,GridView gv,DashboardViewer dbv)
        {
           // gv.CloseEditor();
           // gv.UpdateCurrentRow();
          //  gv.UpdateTotalSummary();
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (customer.EditValue == null)
            {
                XtraMessageBox.Show("Select a Customer from the Customer Drop down list ", "Specify a Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                customer.Focus();
                return;
            }
            if (regNum.EditValue == null)
            {
                XtraMessageBox.Show("Select a Car from the Car Drop down list ", "Specify a Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                regNum.Focus();
                return;
            }
            if (servType.EditValue == null)
            {
                XtraMessageBox.Show("Select a Service Type from the Service Type Drop down list ", "Specify a Service Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                servType.Focus();
                return;
            }

           
            //if (decimal.Parse(prevAmount.EditValue.ToString()) < 0)
            //{
            //    XtraMessageBox.Show("You cant make negative payments ", "No negative payments allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    prevAmount.Focus();
            //    return;
            //}
            int count = 0;
            foreach (Tuple<bool,int,double,double> values in CustomerPurchaseData.Values)
            {
                if (values.Item1)
                    count++;
            }
            if(count==0)
            {
                XtraMessageBox.Show("No Product Or service Was selected for this customer,You Want ot go ahead and still Save ?", "No Product selected For Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }
            Setup.comm = new SqlCommand();
            Setup.comm.Parameters.Add(new SqlParameter("@CusID", customer.EditValue));
            Setup.comm.Parameters.Add(new SqlParameter("@CarID", regNum.EditValue));
            Setup.comm.Parameters.Add(new SqlParameter("@ServTypeID", servType.EditValue));
            Setup.comm.Parameters.Add(new SqlParameter("@Amount", amount.EditValue));
            Setup.comm.Parameters.Add(new SqlParameter("@Quantity", 1));
            Setup.comm.Parameters.Add(new SqlParameter("@ProductID", 1));
          
            Setup.comm.Parameters.Add(new SqlParameter("@Discount", 1));
            Setup.comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            Setup.comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));

            try
            {
                using (Setup.connx = new SqlConnection(Setup.connString))
                {
                    Setup.connx.Open();
                    if (!Setup.mode[6])
                    {
                        decimal amnt = (decimal)amount.EditValue;
                        if (amnt < 0)
                        {
                            XtraMessageBox.Show("You cant make negative payments ", "No negative payments allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            amount.Focus();
                            return;
                        }
                        if (amnt > Setup.sumOfSelectedItems)
                        {
                            amnt = Setup.sumOfSelectedItems;
                            Setup.comm.Parameters["@Amount"].Value = amnt;
                            //XtraMessageBox.Show("Amount entered is greater than amount due for payment ", "Customer Payment greater than Amount Due", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //amount.Focus();
                            //return;
                        }


                        Setup.comm.CommandText = "select csCusID from etblCarService where csCusID=@CusID and CAST(csDateCreated as DATE)=CAST(@DateCreated as Date)";
                        Setup.comm.Connection = Setup.connx;
                        Setup.reader = Setup.comm.ExecuteReader();
                        while (Setup.reader.Read())
                        {
                            if (XtraMessageBox.Show(customer.Text + " Car has already been serviced today, you sure u wanna add another transaction!", "This Customer has been already been today", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                                return;

                        }
                        Setup.reader.Close();
                        Setup.comm.Parameters.Add(new SqlParameter("@CreatorID", Setup.userID));
                        Setup.comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));

                        //Save customer Details
                        Setup.comm.CommandText = "Insert into etblCarService (csCusID,csStID,csCcID,csremarks,csDateCreated,csCreatorID,csCreatedDate) values(@CusID,@CarID,@ServTypeID,@remarks,@DateCreated,@creatorID,@createdDate);select scope_identity()";
                        Setup.primaryKey = Convert.ToInt32(Setup.comm.ExecuteScalar());
                        Setup.dataSet.Tables[carServTable].Rows.Add(Setup.primaryKey, customer.EditValue, customer.Text, customerID,car, regNum.Text, servType.Text, remarks.Text, dateCreated.DateTime, Setup.sumOfSelectedItems,amnt, Setup.sumOfSelectedItems - amnt, Setup.UserName);
                        bool added = false;

                        Setup.comm.Parameters.Add(new SqlParameter("@csID", Setup.primaryKey));
                        //Save Customer Purchases
                        Setup.reader.Close();
                        Setup.comm.CommandText = "Insert into etblCustomerPurchase(cpCsID,cpPpID,cpQuantity,cpDiscount) values(@CsID,@ProductID,@Quantity,@Discount)";
                        foreach (int row in CustomerPurchaseData.Keys)
                        {
                            added = CustomerPurchaseData[row].Item1;
                            if (added)
                            {
                                Setup.comm.Parameters["@ProductID"].Value = Setup.dataSet.Tables[cusPurchaseTable].Rows[row].ItemArray[0];
                                Setup.comm.Parameters["@Quantity"].Value = CustomerPurchaseData[row].Item2;

                                Setup.comm.Parameters["@Discount"].Value = CustomerPurchaseData[row].Item3;
                                Setup.comm.ExecuteNonQuery();
                            }
                        }

                        //Save customer Payments
                        Setup.comm.CommandText = "Insert into etblCustomerPayments(cuspaycsID,cuspayAmount,cusPayDateCreated,cusPayCreatorID,cusPayCreatedDate) values(@csID,@Amount,@DateCreated,@CreatorID,@CreatedDate)";
                        Setup.comm.ExecuteNonQuery();

                        XtraMessageBox.Show(customer.Text + " Saved Sussusfully", "Transaction Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                       
                        
                        decimal totalPaid = Convert.ToDecimal(Setup.dataSet.Tables[carServTable].Rows[currentRow].ItemArray[10]);
                        decimal prevAmntDue= Convert.ToDecimal(Setup.dataSet.Tables[carServTable].Rows[currentRow].ItemArray[9]);
                        decimal amnt = (decimal)amount.EditValue;
                        decimal payments = totalPaid + amnt;
                        decimal change = payments - Setup.sumOfSelectedItems;
                      
                     
                        if ((amnt <0) && Setup.sumOfSelectedItems <payments)
                        {
                            XtraMessageBox.Show("Negative amount only means refund of money to customers and as such, it is expected that Change after refund be zero", "Change after a refund Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            amount.Focus();
                            return;
                        }

                       if(payments<0)
                        {
                            XtraMessageBox.Show("You cant refund below amount customer has already paid", "Refund is Ambigious", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            amount.Focus();
                            return;
                        }
                       
                        if (payments> Setup.sumOfSelectedItems)
                        {

                            if ((amnt- change) >= 0)
                            {
                                amnt -= change;
                                Setup.comm.Parameters["@Amount"].Value = amnt;
                            }
                            else
                            {
                                XtraMessageBox.Show("Change to give Customer is greater than amount customer paid, Enter negative values in case of a refund", "Customer Change is Ambigious", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                amount.Focus();
                                return;
                            }

                        }
                        Setup.comm.Parameters.Add(new SqlParameter("@EditorID", Setup.userID));
                        Setup.comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        Setup.comm.Parameters.Add(new SqlParameter("@ID", Setup.dataSet.Tables[carServTable].Rows[currentRow].ItemArray[0]));

                        Setup.comm.Parameters.Add(new SqlParameter("@UserName", Setup.dataSet.Tables[carServTable].Rows[currentRow].ItemArray[12]));
                        Setup.comm.CommandText = "select csCusID from etblCarService where csCusID=@CusID and CAST(csDateCreated as DATE)=CAST(@DateCreated as Date) and csID!=@ID";
                        Setup.comm.Connection = Setup.connx;
                        Setup.reader = Setup.comm.ExecuteReader();
                        while (Setup.reader.Read())
                        {
                            if (XtraMessageBox.Show(customer.Text + " Car has already been serviced today, you sure u wanna add another transaction!", "This Customer has been already been today", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                                return;

                        }
                        Setup.reader.Close();
                        Setup.comm.CommandText = "Update etblCarService set csCusID=@CusID,csStID=@ServTypeID,csCcID=@CarID,csremarks=@remarks,csEditorID=@EditorID,csEditedDate=@EditedDate where csID=@ID";
                        Setup.comm.ExecuteNonQuery();
                        allPayments.EditValue = totalPaid + amnt;
                        Setup.dataSet.Tables[carServTable].Rows[currentRow].ItemArray = new object[] { Setup.comm.Parameters["@ID"].Value, customer.EditValue, customer.Text, customerID, car,regNum.Text, servType.Text, remarks.Text, dateCreated.DateTime, Setup.sumOfSelectedItems, totalPaid + amnt, (Setup.sumOfSelectedItems - (totalPaid + amnt)),Setup.comm.Parameters["@Username"].Value };

                        //Delete previous purchases
                        Setup.comm.CommandText = "Delete from etblCustomerPurchase where cpCsID=@ID";
                        Setup.comm.ExecuteNonQuery();
                        bool added = false;

                        //Save Customer Purchases

                        Setup.comm.CommandText = "Insert into etblCustomerPurchase(cpCsID,cpPpID,cpQuantity,cpDiscount) values(@ID,@ProductID,@Quantity,@Discount)";
                        foreach (int row in CustomerPurchaseData.Keys)
                        {
                            added = CustomerPurchaseData[row].Item1;
                            if (added)
                            {
                                Setup.comm.Parameters["@ProductID"].Value = Setup.dataSet.Tables[cusPurchaseTable].Rows[row].ItemArray[0];
                                Setup.comm.Parameters["@Quantity"].Value = CustomerPurchaseData[row].Item2;

                                Setup.comm.Parameters["@Discount"].Value = CustomerPurchaseData[row].Item3;
                                Setup.comm.ExecuteNonQuery();
                            }
                        }

                        //Add new Customer Payments if any
                        if (amnt != 0)
                        {
                            Setup.comm.CommandText = "Insert into etblCustomerPayments(cuspaycsID,cuspayAmount,cusPayDateCreated,cusPayCreatorID,cusPayCreatedDate) values(@ID,@Amount,@DateCreated,@EditorID,@EditedDate);select scope_identity()";
                            Setup.comm.ExecuteNonQuery();
                           
                        }
                        amount.EditValue = default(decimal);
                        XtraMessageBox.Show(customer.Text + " Updated Sussusfully", "Car Servicing Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Report a refund
                        if (amnt < 0 || Setup.sumOfSelectedItems <prevAmntDue)
                        {
                            Setup.comm.Parameters.Add(new SqlParameter("@Type", amnt < 0 ? "MONEY" : "PRODUCT OR SERVICE"));
                            Setup.comm.Parameters.Add(new SqlParameter("@rfdAmount", amnt < 0 ? Math.Abs(amnt) :prevAmntDue-Setup.sumOfSelectedItems ));
                            Setup.comm.CommandText = "Insert into etblRefunds(rfdAmount,rfdCusID,rfdType,rfdDateCreated,rfdCreatorID) values(@rfdAmount,@CusID,@Type,@EditedDate,@EditorID)";
                            Setup.comm.ExecuteNonQuery();
                        }
                    }
                    //amountRecieved.EditValue = default(decimal);


                    //Load Invoice

                    Cursor.Current = Cursors.AppStarting;
                    if (dbv.Dashboard != null)
                        dbv.ReloadData();
                    PrintSingle = true;
                    report = new UmitechXtraReport();
                    report.Parameters[0].Visible = false;
                    report.Parameters[0].Value = customer.EditValue;
                    printTool = new ReportPrintTool(report);
                    printTool.ShowRibbonPreviewDialog();
                    PrintSingle = false;
                    Cursor.Current = Cursors.Default;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //can be made better
        public void LoadCustomerPurchase(string table, GridView gvCarServ, GridControl gcCusPurchase,GridView gvCusPurchase,bool canEdit)
        {
            if (!canEdit || gvCarServ.RowCount==0)
                return;
            int csID = (int)Setup.dataSet.Tables[table].Rows[gvCarServ.GetFocusedDataSourceRowIndex()].ItemArray[0];
            for (int i = 0; i < Setup.dataSet.Tables[gcCusPurchase.Name].Rows.Count; i++)
            {
                gvCusPurchase.SetRowCellValue(i, "gridColumn71", false);
            }
            //CustomerPurchaseData.Clear();
            // int csID =(int)gvCarServ.GetRowCellValue(gvCarServ.GetFocusedDataSourceRowIndex(), "csID");
            using (Setup.connx = new SqlConnection(Setup.connString))
            {
                Setup.connx.Open();
                int quantity,taxRate,vatRate = 0;
                double discount,unitPrice = 0;
                bool found = false;
                Setup.comm = new SqlCommand();
                Setup.comm.Connection = Setup.connx;
                Setup.comm.Parameters.Add(new SqlParameter("@csID", csID));

             
                //Select cutomer purchase per this transaction
                Setup.comm.CommandText = "Select * from vwCustomerPurchase where cpCsID=@csID";
                
                StringBuilder builder = new StringBuilder();
                string itemName=string.Empty,productName = string.Empty;
                Setup.reader= Setup.comm.ExecuteReader();
                while(Setup.reader.Read())
                {
                    productName =Convert.ToString(Setup.reader[1]);
                    quantity = Convert.ToInt32(Setup.reader[2]);
                    unitPrice = Convert.ToInt32(Setup.reader[3]);
                    taxRate = Convert.ToInt32(Setup.reader[4]);
                    vatRate = Convert.ToInt32(Setup.reader[5]);
                    discount = Convert.ToInt32(Setup.reader[6]);

                    for(int i=0;i<Setup.dataSet.Tables[gcCusPurchase.Name].Rows.Count;i++)
                    {
                      
                        DataRow row = Setup.dataSet.Tables[gcCusPurchase.Name].Rows[i];
                        itemName = row[1].ToString();
                        if ((string)row.ItemArray[1] == productName)
                        {
                           
                            // CustomerPurchaseData[i]= Tuple.Create(true, quantity, discount, CustomerPurchaseData[i].Item4);
                            //Setup.row = gv.GetDataRow(i);
                            gvCusPurchase.SetRowCellValue(i, "gridColumn71", true);
                            gvCusPurchase.SetRowCellValue(i, "gridColumn65", quantity);
                            gvCusPurchase.SetRowCellValue(i, "ppUnitPrice", unitPrice);
                            gvCusPurchase.SetRowCellValue(i, "ppTaxRate", taxRate);
                            gvCusPurchase.SetRowCellValue(i, "ppVatRate", vatRate);
                            gvCusPurchase.SetRowCellValue(i, "gridColumn69", discount);
                            //Setup.row[2] = unitPrice;
                            //Setup.row[3] = taxRate;
                            //Setup.row[4] = vatRate;

                            found = true;
                            break;
                        }
                    }
                    if (!found)
                        builder.AppendLine(itemName);
                    found = false;
                   
                  
                }
                Setup.reader.Close();
                //Select last customer pay ID
                //Setup.comm.CommandText = "Select top 1 cusPayID,cusPayAmount from etblCustomerPayments where cusPayCsID=@csID order by cusPayID desc";
                //Setup.reader = Setup.comm.ExecuteReader();
                //while (Setup.reader.Read())
                //{
                //    customerLastPaymentID = Convert.ToInt32(Setup.reader[0]);
                //    prevAmount.EditValue = Convert.ToDecimal(Setup.reader[1]);
                //    customerLastPayment = (decimal)prevAmount.EditValue;
                //}
               
                gcCusPurchase.RefreshDataSource();
                if (!string.IsNullOrEmpty(builder.ToString()))
                    XtraMessageBox.Show("The following Product where not found :" + builder.ToString() + Environment.NewLine + " These may due to these prducts being either deleted or having a status of false", "Some Products where not found!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        
        public void SaveEmployeeRecord(TextEdit fname,TextEdit lname,TextEdit oname,DateEdit DOB,PictureEdit image,LookUpEdit gender,LookUpEdit title,LookUpEdit mStatus,LookUpEdit country,LookUpEdit region,LookUpEdit town,
         TextEdit phone,TextEdit address,TextEdit email,TextEdit staffID,LookUpEdit qualification,LookUpEdit empType,LookUpEdit jobType,DateEdit startDate,DateEdit endDate,MemoEdit remarks,DateEdit dateCreated,CheckEdit status,string tableName, bool canWrite, BarCheckItem editing, int currentRow,GridControl users)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                XtraMessageBox.Show("First Name Required", "Specify Staff First Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fname.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(lname.Text))
            {
                XtraMessageBox.Show("Last Name Required", "Specify Staff Last Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lname.Focus();
                return;
            }
            if (image.Image == null)
            {
                XtraMessageBox.Show("Right Click the image Box to load an image", "Specify Staff image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                image.Focus();
                return;
            }

            byte[] imgByte = (byte[])Setup.imgConverter.ConvertTo(image.Image, typeof(byte[]));
            if (gender.EditValue == null)
            {
                XtraMessageBox.Show("Select a Gender ", "Specify Staff Gender", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gender.Focus();
                return;
            }
            if (title.EditValue == null)
            {
                XtraMessageBox.Show("Select a Title ", "Specify Staff Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                title.Focus();
                return;
            }
            if (mStatus.EditValue == null)
            {
                XtraMessageBox.Show("Select a Marital Status ", "Specify Staff Marital Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mStatus.Focus();
                return;
            }
            if (town.EditValue == null)
            {
                XtraMessageBox.Show("Select a Town from the Town drop down list ", "Specify Staff Town", MessageBoxButtons.OK, MessageBoxIcon.Information);
                town.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(phone.Text))
            {
                XtraMessageBox.Show("Enter Staff's Phone number ", "Phone Number Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string[] numbers = phone.Text.Split(',');
            int phoneNum = 0;

            foreach (string num in numbers)
            {
                if (!int.TryParse(num, out phoneNum))
                {
                    XtraMessageBox.Show("Separate each phone number with a comma if more than 1", "Phone number not in right format", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    phone.Focus();
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(email.Text))
            {
                XtraMessageBox.Show("Email Required", "Specify Staff Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                email.Focus();
                return;
            }
            if (qualification.EditValue == null)
            {
                XtraMessageBox.Show("Select a qualification from the qualification Drop down ", "Specify Staff Qualification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                qualification.Focus();
                return;
            }
            if (empType.EditValue == null)
            {
                XtraMessageBox.Show("Select an Employee Type from the employee type drop down ", "Specify Staff Employee Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                empType.Focus();
                return;
            }
            if (jobType.EditValue == null)
            {
                XtraMessageBox.Show("Select a Job Type from the job type drop down ", "Specify Staff Job Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jobType.Focus();
                return;
            }
         
           
            Setup.comm = new SqlCommand();
            Setup.comm.Parameters.Add(new SqlParameter("@FName", fname.Text));
            Setup.comm.Parameters.Add(new SqlParameter("@LName", lname.Text));
            Setup.comm.Parameters.Add(new SqlParameter("@OName", oname.Text));
            Setup.comm.Parameters.Add(new SqlParameter("@DOB", DOB.DateTime));
            Setup.comm.Parameters.Add(new SqlParameter("@Image", imgByte));
            Setup.comm.Parameters.Add(new SqlParameter("@Gender", gender.EditValue));
            Setup.comm.Parameters.Add(new SqlParameter("@Title", title.EditValue));
            Setup.comm.Parameters.Add(new SqlParameter("@MStatus", mStatus.EditValue));
            Setup.comm.Parameters.Add(new SqlParameter("@Town", town.EditValue));
            Setup.comm.Parameters.Add(new SqlParameter("@Phone", phone.Text));
            Setup.comm.Parameters.Add(new SqlParameter("@Address", address.Text));
            Setup.comm.Parameters.Add(new SqlParameter("@Email", email.Text));
            Setup.comm.Parameters.Add(new SqlParameter("@StaffID", staffID.Text));
            Setup.comm.Parameters.Add(new SqlParameter("@QID", qualification.EditValue));
            Setup.comm.Parameters.Add(new SqlParameter("@EmpType", empType.EditValue));
            Setup.comm.Parameters.Add(new SqlParameter("@JobType", jobType.EditValue));
            Setup.comm.Parameters.Add(new SqlParameter("@StartDate", startDate.DateTime));
            Setup.comm.Parameters.Add(new SqlParameter("@EndDate", endDate.DateTime));
            Setup.comm.Parameters.Add(new SqlParameter("@Password",staffID.Text));
            Setup.comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            Setup.comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            Setup.comm.Parameters.Add(new SqlParameter("@Status", status.Checked));

            try
            {
                using (Setup.connx = new SqlConnection(Setup.connString))
                {
                    Setup.connx.Open();
                    if (!Setup.mode[9])
                    {
                        staffID.Text = char.ToUpperInvariant(lname.Text[0]).ToString() + char.ToUpperInvariant(fname.Text[0]).ToString() + numbers[0];
                        Setup.comm.Parameters["@StaffID"].Value = staffID.Text;
                        Setup.comm.CommandText = "select sfID from etblEmployee where sfStaffID=@StaffID";
                        Setup.comm.Connection = Setup.connx;
                        Setup.reader = Setup.comm.ExecuteReader();
                        while (Setup.reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Staff Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        Setup.reader.Close();
                        Setup.comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        Setup.comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        Setup.comm.CommandText = "Insert into etblEmployee (sffname,sflname,sfoname,sfDOB,sfImage,sfGID,sfTID,sfMSID,sfTwnID,sfPhone,sfAddress,sfEmail,sfStaffID,sfPassword,sfQID,sfETID,sfJTID,sfStartDate,sfEndDate,sfremarks,sfDateCreated,sfstatus,sfCreatorID,sfCreatedDate) values(@fname,@lname,@oname,@DOB,@image,@Gender,@Title,@MStatus,@Town,@Phone,@Address,@Email,@StaffID,@Password,@QID,@EmpType,@JobType,@startDate,@EndDate,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        Setup.primaryKey = Convert.ToInt32(Setup.comm.ExecuteScalar());
                        Setup.dataSet.Tables[tableName].Rows.Add(Setup.primaryKey, fname.Text, lname.Text, oname.Text, DOB.DateTime, imgByte, gender.Text, title.Text, mStatus.Text, country.Text, region.Text, town.Text, phone.Text, address.Text, email.Text, staffID.Text, staffID.Text, qualification.Text, empType.Text, jobType.Text, startDate.DateTime, endDate.DateTime, remarks.Text, dateCreated.DateTime, status.Checked, Setup.UserName, Setup.UserName);
                        XtraMessageBox.Show(fname.Text + " Saved Sussusfully", "Staff Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        Setup.comm.Parameters.Add(new SqlParameter("@EditorID", 1));
                        Setup.comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        Setup.comm.Parameters.Add(new SqlParameter("@ID", Setup.dataSet.Tables[tableName].Rows[currentRow].ItemArray[0]));

                        Setup.comm.Parameters.Add(new SqlParameter("@UserName", Setup.dataSet.Tables[tableName].Rows[currentRow].ItemArray[26]));
                        Setup.comm.CommandText = "select sfID from etblEmployee where sfStaffID=@StaffID and sfID !=@ID";
                        Setup.comm.Connection = Setup.connx;
                        Setup.reader = Setup.comm.ExecuteReader();
                        while (Setup.reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Staff Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        Setup.reader.Close();
                        Setup.comm.CommandText = "Update etblEmployee set sffname=@fname, sflname=@lname,sfoname=@oname,sfDOB=@DOB,sfImage=@Image,sfGID=@Gender,sfTID=@Title,sfMSID=@MStatus,sfTwnID=@Town,sfPhone=@Phone,sfAddress=@Address,sfEmail=@Email,sfQID=@QID,sfETID=@EmpType,sfJTID=@JobType,sfStartDate=@StartDate,sfEndDate=@EndDate,sfremarks=@remarks,sfStatus=@status,sfEditorID=@EditorID,sfEditedDate=@EditedDate where sfID=@ID";
                        Setup.comm.ExecuteNonQuery();
                        Setup.dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { Setup.comm.Parameters["@ID"].Value, fname.Text, lname.Text, oname.Text, DOB.DateTime, imgByte, gender.Text, title.Text, mStatus.Text, country.Text, region.Text, town.Text, phone.Text, address.Text, email.Text, staffID.Text, Setup.comm.Parameters[16].Value, qualification.Text, empType.Text, jobType.Text, startDate.DateTime, endDate.DateTime, remarks.Text, dateCreated.DateTime, status.Checked, Setup.comm.Parameters["@Username"].Value, Setup.comm.Parameters["@Username"].Value };

                        XtraMessageBox.Show(fname.Text + " Updated Sussusfully", "Staff Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    users.DataSource = null;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void ShowReport(bool canWrite,bool canEdit)
        {
            if(!canWrite && !canEdit)
            {
                XtraMessageBox.Show("You dont Have access to view Reports, Contact Admin", "You cant View Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Cursor.Current = Cursors.AppStarting;
            report = new UmitechXtraReport();
            printTool = new ReportPrintTool(report);
            printTool.ShowRibbonPreview();
            Cursor.Current = Cursors.Default;
        }
        public void ShowDashBoard(DashboardViewer dbv,bool canRead)
        {
           
            if (canRead)
            {
                if (dbv.Dashboard == null)
                {
                   dbv.LoadDashboard(@"UmitechDashBoard.xml");
                    dbv.Show();
                }
                    
                else
                    dbv.Show();

            }
               
            else
            {
                dbv.Hide();
                XtraMessageBox.Show("You need to have administrative rights to have a look the dashboard of the comapany", "You Cant View Dashbord", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
