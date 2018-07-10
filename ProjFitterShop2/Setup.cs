using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using System.IO;
using DevExpress.XtraLayout;
using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars;

namespace ProjFitterShop2
{
    class Setup
    {
        public static SqlConnection connx;
        public static SqlDataAdapter adapter;
        public static SqlCommand comm;
        public static SqlDataReader reader;
        public static int primaryKey;
        public static DataRow row;
        public static int userID;
        public static string dailyToast;
        public static int logAccess;
        public static ImageConverter imgConverter;
        public static Image staffImage;
        public static string UserName = "Anonymous";
        //vincentDB "Data Source =VINCENTE\\SQLEXPRESS01;Initial Catalog = dbAutoService; Integrated Security=True;";
        public static string connString = "Data Source =.;Initial Catalog = dbAutoService; Integrated Security=True;";
        public static string defaultConnxString = "Data Source = DESKTOP-LNIL79P;Initial Catalog = dbAutoService; Integrated Security=True;";
        public static DataTable table;
        public static DataSet dataSet = new DataSet("All Tables");
        public static string cbQuery, cbValueMem, cbDisplayMem, query;
        public static bool Error = false;
        //Index should get to 20 now
        public static bool[] mode = new bool[20];
        public static bool[] detailView = new bool[20];
        public static bool[] selectAll = new bool[20];
        public static bool[,] accessStatus = new bool[20, 3];
        public static Dictionary<int, bool> Users;
        public static decimal sumOfSelectedItems = 0;
        public Setup()
        {
            imgConverter = new ImageConverter();
            //mode = new bool[19];
            //accessStatus = new bool[19, 3];
            Users = new Dictionary<int, bool>();
        }

        public static void PopulateDGV(GridControl gc, Label statusText, string readQuery)
        {
            
            Cursor.Current = Cursors.AppStarting;
            using (connx = new SqlConnection(connString))
            {
               
                try
                {
                    connx.Open();
                    table = new DataTable(gc.Name);
                    if (dataSet.Tables.Contains(table.TableName))
                        dataSet.Tables.Remove(table.TableName);
                    adapter = new SqlDataAdapter(readQuery, connx);

                    dataSet.Tables.Add(table);

                    adapter.Fill(table);
                    Error = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //Application.Exit();
                    Error = true;
                }

                gc.DataSource = table ;
              
            }

            Cursor.Current = Cursors.Default;
        }
        public static bool IsCBTextRite(ComboBoxEdit cb)
        {
            bool isRite = false;
            //for (int i = 0; i < cb.Items.Count; i++)
            //{

            //    if (cb.GetItemText(cb.Items[i]).Equals(cb.Text, StringComparison.InvariantCultureIgnoreCase))
            //    {
            //        isRite = true;
            //        cb.SelectedItem = cb.Items[i];
            //        break;
            //    }
            ////}
            return isRite;
        }
        static void PopulateSearchLookUps(string query,SearchLookUpEdit sle,string display,string value)
        {
            try
            {
                using (connx = new SqlConnection(connString))
                {

                    connx.Open();
                    adapter = new SqlDataAdapter(query, connx);
                    table = new DataTable(sle.Name);
                    //dataSet.Tables.Add(table);
                    adapter.Fill(table);


                    sle.Properties.DisplayMember = display;
                    sle.Properties.ValueMember = value;
                    sle.Properties.DataSource = table;
                   // sle.Properties.View.Columns[0].Visible = false;
                    // sle.ShowPopup();
                    //le.Properties.ShowHeader = true;
                    // le.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Full Name"));
                    //sle.Properties.PopulateColumns();
                    // sle.Properties.Columns["ID"].Visible = false;
                    //cb.SelectedIndex = -1;



                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("OOps An error Occured In the Normal Flow of the Program, Contact your IT Personnel\r\n" + ex.Message, "Error Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        static void PopulateLookUps(string query, LookUpEdit le, string display, string value)
        {
            Cursor.Current = Cursors.AppStarting;
            try
            {
                using (connx = new SqlConnection(connString))
                {

                    connx.Open();
                    adapter = new SqlDataAdapter(query, connx);
                    table = new DataTable(le.Name);
                    //dataSet.Tables.Add(table);
                    adapter.Fill(table);

                    le.Properties.DataSource = table;
                    le.Properties. DisplayMember = display;
                    le.Properties.ValueMember = value;

                    //le.Properties.ShowHeader = true;
                    // le.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Full Name"));
                    //le.Properties.PopulateColumns();
                    // le.Properties.Columns["ID"].Visible = false;
                    le.Properties.Columns.Clear();
                    le.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Full Name"));
                    //cb.SelectedIndex = -1;
                    Error = false;


                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("OOps An error Occured In the Normal Flow of the Program, Contact your IT Personnel\r\n" + ex.Message, "Error Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Error = true;
            }
            Cursor.Current = Cursors.AppStarting;
        }
        public static void PopulateIndependantLookUPs(LookUpEdit le)
        {
            if (userID == 0)
                return;
            if (le.Properties.DataSource == null)
            {
                switch (le.Name)
                {
                    case "leCarManufacturer":
                        cbQuery = "Select cmID as [ID],cmFName as [Full Name],cmsname as [Short Name] from stblCarManufacturer where cmStatus=1";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "leCDTitle":
                        cbQuery = "Select tID as [ID],tFName as [Full Name],tSName as [Short Name] from stblTitle where tStatus=1";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "leDCSCustomer":
                        cbQuery = "Select cusID as [ID],cusFName as [Full Name],cusCustomerID as [Customer ID] from etblCustomer where cusStatus=1";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "leDCSCar":
                        cbQuery = "Select carID as [ID],carFName as [Full Name],carSName as [Short Name] from stblCar where carStatus=1";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "leDCSServiceType":
                        cbQuery = "Select stID as [ID],stFName as [Full Name] from stblServiceType where stStatus=1";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "lePPProduct":
                        cbQuery = "Select pdID as [ID],pdFName as [Full Name] from stblProduct where pdStatus=1";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "leRegCountry":
                        cbQuery = "Select conID as [ID],conFName as [Full Name] from stblCountry where conStatus=1";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "leTwnCountry":
                        cbQuery = "Select conID as [ID],conFName as [Full Name] from stblCountry where conStatus=1";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "leSfGender":
                        cbQuery = "Select gID as [ID],gFName as [Full Name] from stblGender where gStatus=1";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "leSfTitle":
                        cbQuery = "Select tID as [ID],tFName as [Full Name] from stblTitle where tStatus=1";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "leSfMStatus":
                        cbQuery = "Select msID as [ID],msFName as [Full Name] from stblMaritalStatus where msStatus=1";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "leSfCountry":
                        cbQuery = "Select conID as [ID],conFName as [Full Name] from stblCountry where conStatus=1";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "leSfQualification":
                        cbQuery = "Select qID as [ID],qFName as [Full Name] from stblQualification where qStatus=1";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "leSfEmployeeType":
                        cbQuery = "Select etID as [ID],etFName as [Full Name] from stblEmployeeType where etStatus=1";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "leSfJobType":
                        cbQuery = "Select jtID as [ID],jtFName as [Full Name] from stblJobType where jtStatus=1";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "cbLogStatus":
                        cbQuery = "Select lsID,lsFName from tblLogStatus";
                        cbDisplayMem = "lsFName";
                        cbValueMem = "lsID";
                        break;
                }

                PopulateLookUps(cbQuery, le, cbDisplayMem, cbValueMem);
                //le.Properties.Columns["ID"].Visible = false;
            }
        }
        static void AllColumnLookUps(string query, LookUpEdit le, string display, string value)
        {
            Cursor.Current = Cursors.AppStarting;
            try
            {
                using (connx = new SqlConnection(connString))
                {

                    connx.Open();
                    adapter = new SqlDataAdapter(query, connx);
                    table = new DataTable(le.Name);
                    if (dataSet.Tables.Contains(table.TableName))
                        dataSet.Tables.Remove(table.TableName);
                    dataSet.Tables.Add(table);
                    adapter.Fill(table);

                    le.Properties.DataSource = table;
                    le.Properties.DisplayMember = display;
                    le.Properties.ValueMember = value;

                    //le.Properties.ShowHeader = true;
                    // le.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Full Name"));
                    le.Properties.PopulateColumns();
                    le.Properties.Columns["ID"].Visible = false;
                  
                  
                    Error = false;


                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("OOps An error Occured In the Normal Flow of the Program, Contact your IT Personnel\r\n" + ex.Message, "Error Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Error = true;
            }
            Cursor.Current = Cursors.AppStarting;
        }
        public static void PopulateCustomerCarLookUps(LookUpEdit le)
        {
            if (userID == 0)
                return;
            if (le.Properties.DataSource == null)
            {
                switch (le.Name)
                {
                    case "leCCCustomer":
                        cbQuery = "Select cusID as [ID],cusFName as [Full Name] from etblCustomer where cusStatus=1";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "leCCCar":
                        cbQuery = "Select carID as [ID],carFName as [Full Name],cmfname as [Car Manufacturer] from vwCar where carStatus=1";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;

                }

                AllColumnLookUps(cbQuery, le, cbDisplayMem, cbValueMem);
            }
        }
        public static void PopulateDependantLookUPs(LookUpEdit parent,LookUpEdit child)
        {
            if(child.Properties.DataSource==null)
            {
                switch(child.Name)
                {
                    case "leTwnRegion":
                        cbQuery = "Select regID as [ID],regFname as [Full Name] from stblRegion where regConID='" + parent.EditValue + "'";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "leSfRegion":
                        cbQuery = "Select regID as [ID],regFname as [Full Name] from stblRegion where regConID='" + parent.EditValue + "'";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                    case "leSfTown":
                        cbQuery = "Select twnID as [ID],twnFname as [Full Name] from stblTown where twnRegID='" + parent.EditValue + "'";
                        cbDisplayMem = "Full Name";
                        cbValueMem = "ID";
                        break;
                }
                PopulateLookUps(cbQuery, child, cbDisplayMem, cbValueMem);
                //child.Properties.Columns["ID"].Visible = false;
            }
        }
        public static void PopulateDependantAllColumnLookUPs(LookUpEdit parent, LookUpEdit child)
        {
            if (child.Properties.DataSource == null)
            {
                switch (child.Name)
                {
                    case "leDCSCar":
                        cbQuery = "Select ccID as [ID],carfname as [Full Name],ccRegistrationNum as [Registration Number] from vwCustomerCar where ccCusID='" + parent.EditValue + "'";
                        cbDisplayMem = "Registration Number";
                        cbValueMem = "ID";
                        break;
                   
                }
                AllColumnLookUps(cbQuery, child, cbDisplayMem, cbValueMem);
                //child.Properties.Columns["ID"].Visible = false;
            }
        }
        public static void PopulateIndependantSearchLookUPs(SearchLookUpEdit sle)
        {
            if (sle.Properties.DataSource == null)
            {
                switch (sle.Name)
                {
                   
                   

                }

                PopulateSearchLookUps(cbQuery, sle, cbDisplayMem, cbValueMem);
            }
        }
        public void LoadDGVRecords(string frmName,GridControl gc, Label status, bool canRead, bool canEdit)
        {
            if (!canRead && !canEdit)
                return;
            if (gc.DataSource != null)
                return;
         
            switch (frmName)
            {
                case "navigationPage1":
                    query = "select * from vwCar";

                    break;

                case "navigationPage2":
                    query = "select * from vwCarManufacturer";

                    break;
                case "navigationPage3":
                    query = "Select * from vwProduct";

                    break;
                case "navigationPage4":
                    query = "select * from vwTitle";

                    break;

                case "navigationPage6":
                    query = "select * from vwServiceType";

                    break;
                case "navigationPage8":
                    query = "Select * from vwProductPrice";
                    break;
                case "navigationPage9":
                    query = "Select * from vwCompanyInfos";
                    break;
                case "navigationPage10":
                    query = "Select * from vwEmployee";
                    break;
                case "navigationPage11":
                    query = "Select * from vwGender";
                    break;
                case "navigationPage12":
                    query = "Select * from vwMaritalStatus";
                    break;
                case "navigationPage13":
                    query = "Select * from vwCountry";
                    break;
                case "navigationPage14":
                    query = "Select * from vwRegion";
                    break;
                case "navigationPage15":
                    query = "Select * from vwTown";
                    break;
                case "navigationPage16":
                    query = "Select * from vwQualification";
                    break;
                case "navigationPage17":
                    query = "Select * from vwEmployeeType";
                    break;
                case "navigationPage18":
                    query = "Select * from vwJobType";
                    break;
                case "navigationPage19":
                    query = "Select * from stblForms";
                    break;
                case "navigationPage21":
                    query = "Select * from vwCustomerCar";
                    break;
            }
            PopulateDGV(gc, status, query);
           
        }
        public void SaveCarRecords(TextEdit fname,TextEdit sname,LookUpEdit manufacturer,DateEdit year,PictureEdit image,MemoEdit remarks,DateEdit dateCreated,CheckEdit status,string tableName,bool canWrite,BarCheckItem editing,int currentRow)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                XtraMessageBox.Show("Full Name Required", "Specify Car Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fname.Focus();
                return;
              
            }
            if(manufacturer.EditValue==null)
            {
                XtraMessageBox.Show("Select a Car Manufacturer", "Specify Car Manufacturer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                manufacturer.Focus();
                return;
            }
            if(image.Image==null)
            {
                XtraMessageBox.Show("Right Click the image Box to load an image", "Specify Car image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                image.Focus();
                return;
            }
           
            byte[] imgByte = (byte[])imgConverter.ConvertTo(image.Image, typeof(byte[]));
            
            comm = new SqlCommand();
            comm.Parameters.Add(new SqlParameter("@FName", fname.Text));
            comm.Parameters.Add(new SqlParameter("@SName", sname.Text));
            comm.Parameters.Add(new SqlParameter("@Manufacturer", manufacturer.EditValue));
           
            comm.Parameters.Add(new SqlParameter("@Year",year.DateTime.Year));
            comm.Parameters.Add(new SqlParameter("@Image", imgByte));
            comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            comm.Parameters.Add(new SqlParameter("@Status", status.Checked));
            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    if (!mode[0])
                    {
                        comm.CommandText = "select carID from stblCar where carFName=@Fname and carMfrID=@Manufacturer and carYear=@Year";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Car Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        comm.CommandText = "Insert into stblCar (carfname,carsname,carMfrID,caryear,carimage,carremarks,carDateCreated,carstatus,carCreatorID,carCreatedDate) values(@fname,@sname,@manufacturer,@year,@image,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                        dataSet.Tables[tableName].Rows.Add(primaryKey, fname.Text, sname.Text, manufacturer.Text,year.DateTime.Year, imgByte, remarks.Text, dateCreated.DateTime, status.Checked, UserName);
                        XtraMessageBox.Show(fname.Text + " Saved Sussusfully", "Car Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        comm.Parameters.Add(new SqlParameter("@EditorID", 1));
                        comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        comm.Parameters.Add(new SqlParameter("@ID", dataSet.Tables[tableName].Rows[currentRow].ItemArray[0]));
                        comm.Parameters.Add(new SqlParameter("@UserName", dataSet.Tables[tableName].Rows[currentRow].ItemArray[9]));
                        comm.CommandText = "select carID from stblCar where carFName=@Fname and carMfrID=@Manufacturer and carYear=@Year and carID !=@ID";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Car Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.CommandText = "Update stblCar set carfname=@fname, carsname=@sname,carmfrid=@manufacturer,caryear=@year,carimage=@image,carremarks=@remarks,carStatus=@status,carEditorID=@EditorID,carEditedDate=@EditedDate where carID=@ID";
                        comm.ExecuteNonQuery();
                        dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { comm.Parameters["@ID"].Value, fname.Text, sname.Text, manufacturer.Text,year.DateTime.Year, imgByte, remarks.Text, dateCreated.DateTime, status.Checked, comm.Parameters["@Username"].Value };

                        XtraMessageBox.Show(fname.Text + " Updated Sussusfully", "Car Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void SaveCarManufacturerRecords(TextEdit fname, TextEdit sname, MemoEdit remarks, DateEdit dateCreated, CheckEdit status, string tableName, bool canWrite,BarCheckItem editing,int currentRow)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                XtraMessageBox.Show("Full Name Required", "Specify Car Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fname.Focus();
                return;
            }

            comm = new SqlCommand();
            comm.Parameters.Add(new SqlParameter("@FName", fname.Text));
            comm.Parameters.Add(new SqlParameter("@SName", sname.Text));
            comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            comm.Parameters.Add(new SqlParameter("@Status", status.Checked));

            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    if (!mode[1])
                    {
                        comm.CommandText = "select cmID from stblCarManufacturer where cmFName=@Fname";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Car Manufacturer Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        comm.CommandText = "Insert into stblCarManufacturer (cmfname,cmsname,cmremarks,cmDateCreated,cmstatus,cmCreatorID,cmCreatedDate) values(@fname,@sname,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                        dataSet.Tables[tableName].Rows.Add(primaryKey, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, UserName);
                        XtraMessageBox.Show(fname.Text + " Saved Sussusfully", "Car Manufacturer Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        comm.Parameters.Add(new SqlParameter("@EditorID", 1));
                        comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        comm.Parameters.Add(new SqlParameter("@ID", dataSet.Tables[tableName].Rows[currentRow].ItemArray[0]));
                        comm.Parameters.Add(new SqlParameter("@UserName", dataSet.Tables[tableName].Rows[currentRow].ItemArray[6]));
                        comm.CommandText = "select cmID from stblCarManufacturer where cmFName=@Fname and cmID !=@ID";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Car Manufacturer Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.CommandText = "Update stblCarManufacturer set cmfname=@fname, cmsname=@sname,cmremarks=@remarks,cmStatus=@status,cmEditorID=@EditorID,cmEditedDate=@EditedDate where cmID=@ID";
                        comm.ExecuteNonQuery();
                        dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { comm.Parameters["@ID"].Value, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, comm.Parameters["@Username"].Value };

                        XtraMessageBox.Show(fname.Text + " Updated Sussusfully", "Car Manufacturer Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void SaveProductRecords(TextEdit fname, TextEdit sname,TextEdit unitPrice,SpinEdit taxRate,SpinEdit vatRate, MemoEdit remarks, DateEdit dateCreated, CheckEdit status, string tableName, bool canWrite, BarCheckItem editing, int currentRow)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                XtraMessageBox.Show("Full Name Required", "Specify Product Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fname.Focus();
                return;
            }
            float price = 0;
            if (!float.TryParse(unitPrice.Text,out price))
            {
                XtraMessageBox.Show("Unit Price Required", "Specify Unit Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
                unitPrice.Focus();
                return;
            }
          
            comm = new SqlCommand();
            comm.Parameters.Add(new SqlParameter("@FName", fname.Text));
            comm.Parameters.Add(new SqlParameter("@SName", sname.Text));
            comm.Parameters.Add(new SqlParameter("@UnitPrice", unitPrice.Text));
            comm.Parameters.Add(new SqlParameter("@TaxRate", taxRate.Value));
            comm.Parameters.Add(new SqlParameter("@VatRate", vatRate.Value));
           
            comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            comm.Parameters.Add(new SqlParameter("@Status", status.Checked));
            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    if (!mode[2])
                    {
                        comm.CommandText = "select pdID from stblProduct where pdFName=@Fname";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Product Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        comm.CommandText = "Insert into stblProduct (pdfname,pdsname,pdremarks,pdDateCreated,pdstatus,pdCreatorID,pdCreatedDate) values(@fname,@sname,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                        dataSet.Tables[tableName].Rows.Add(primaryKey, fname.Text, sname.Text, unitPrice.Text, taxRate.Text, vatRate.Text, remarks.Text, dateCreated.DateTime, status.Checked, UserName);

                        comm.Parameters.Add(new SqlParameter("@ProductID", primaryKey));
                        //Save to Product Prices
                        comm.CommandText = "Insert into stblProductPrice (ppProductID,ppUnitPrice,ppTaxRate,ppVatRate,ppRemarks,ppDateCreated,ppStatus,ppCreatorID,ppCreatedDate) values(@ProductID,@UnitPrice,@TaxRate,@VatRate,@Remarks,@DateCreated,1,@creatorID,@createdDate)";
                        comm.ExecuteNonQuery();
                        XtraMessageBox.Show(fname.Text + " Saved Sussusfully", "Product Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        comm.Parameters.Add(new SqlParameter("@EditorID", 1));
                        comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        comm.Parameters.Add(new SqlParameter("@ID", dataSet.Tables[tableName].Rows[currentRow].ItemArray[0]));

                        comm.Parameters.Add(new SqlParameter("@UserName", dataSet.Tables[tableName].Rows[currentRow].ItemArray[9]));
                        comm.CommandText = "select pdID from stblProduct where pdFName=@Fname and pdID !=@ID";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Product Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.CommandText = "Update stblProduct set pdfname=@fname, pdsname=@sname,pdremarks=@remarks,pdStatus=@status,pdEditorID=@EditorID,pdEditedDate=@EditedDate where pdID=@ID";
                        comm.ExecuteNonQuery();

                        comm.CommandText = "Update stblProductPrice set ppProductID=@ID,ppUnitPrice=@UnitPrice,ppTaxRate=@TaxRate,ppVatRate=@VatRate,ppRemarks=@Remarks,ppEditorID=@EditorID,ppEditedDate=@EditedDate where ppProductID=@ID and ppStatus=1";
                        comm.ExecuteNonQuery();
                        dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { comm.Parameters["@ID"].Value, fname.Text, sname.Text, unitPrice.Text, taxRate.Text, vatRate.Text, remarks.Text, dateCreated.DateTime, status.Checked, comm.Parameters["@UserName"].Value };

                        XtraMessageBox.Show(fname.Text + " Updated Sussusfully", "Product Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void SaveProductPricesRecords(LookUpEdit product, TextEdit unitPrice, SpinEdit taxRate, SpinEdit vatRate,MemoEdit remarks, DateEdit dateCreated, CheckEdit status, string tableName, bool canWrite, BarCheckItem editing, int currentRow)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (product.EditValue==null)
            {
                XtraMessageBox.Show("Select a Product from the product drop down ", "Select a Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                product.Focus();
                return;
            }
            float price = 0;
            if (!float.TryParse(unitPrice.Text, out price))
            {
                XtraMessageBox.Show("Unit Price Required", "Specify Unit Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
                unitPrice.Focus();
                return;
            }

            comm = new SqlCommand();
          
            comm.Parameters.Add(new SqlParameter("@ProductID", product.EditValue));
            comm.Parameters.Add(new SqlParameter("@UnitPrice", unitPrice.Text));
            comm.Parameters.Add(new SqlParameter("@TaxRate", taxRate.Value));
            comm.Parameters.Add(new SqlParameter("@VatRate", vatRate.Value));

            comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            comm.Parameters.Add(new SqlParameter("@Status", status.Checked));
            comm.Parameters.Add(new SqlParameter("@ID", primaryKey));

            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    if (!mode[7])
                    {
                        comm.CommandText = "select ppID from stblProductPrice where ppProductID=@ProductID and ppUnitPrice=@UnitPrice and ppTaxRate=@TaxRate and ppVatRate=@VatRate";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(product.Text + " With Similar options exist!", "This Product Price Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        comm.CommandText = "Insert into stblProductPrice (ppProductID,ppunitprice,ppTaxRate,ppVatRate,ppremarks,ppDateCreated,ppstatus,ppCreatorID,ppCreatedDate) values(@ProductID,@UnitPrice,@TaxRate,@VatRate,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                        comm.Parameters["@ID"].Value = primaryKey;

                        dataSet.Tables[tableName].Rows.Add(primaryKey, product.Text, unitPrice.Text, taxRate.Text, vatRate.Text, remarks.Text, dateCreated.DateTime, status.Checked, UserName);
                        XtraMessageBox.Show(product.Text + "Price Saved Sussusfully", "Product Price Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        comm.Parameters.Add(new SqlParameter("@EditorID", 1));
                        comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));

                        comm.Parameters["@ID"].Value = dataSet.Tables[tableName].Rows[currentRow].ItemArray[0];
                        comm.Parameters.Add(new SqlParameter("@UserName", dataSet.Tables[tableName].Rows[currentRow].ItemArray[8]));
                        comm.CommandText = "select ppID from stblProductPrice where ppProductID=@ProductID and ppUnitPrice=@UnitPrice and ppTaxRate=@TaxRate and ppVatRate=@VatRate and ppID !=@ID";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(product.Text + " with similar options exist!", "This Product Price Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();


                        comm.CommandText = "Update stblProductPrice set ppProductID=@ProductID, ppUnitPrice=@UnitPrice,ppTaxRate=@TaxRate,ppVatRate=@VatRate,ppRemarks=@Remarks,ppStatus=@status,ppEditorID=@EditorID,ppEditedDate=@EditedDate where ppID=@ID";
                        comm.ExecuteNonQuery();
                        dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { comm.Parameters["@ID"].Value, product.Text, unitPrice.Text, taxRate.Text, vatRate.Text, remarks.Text, dateCreated.DateTime, status.Checked, comm.Parameters["@Username"].Value };


                        XtraMessageBox.Show(product.Text + " Updated Sucusfully", "Product Price Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if ((bool)comm.Parameters["@Status"].Value)
                    {
                        comm.CommandText = "Update stblProductPrice set ppStatus=0 where ppId !=@ID and ppProductID=@ProductID";
                        comm.ExecuteNonQuery();
                        for (int i = 0; i < dataSet.Tables[tableName].Rows.Count; i++)
                        {
                            DataRow row = dataSet.Tables[tableName].Rows[i];
                            if ((row.ItemArray[1].ToString() == product.Text) && (row.ItemArray[0].ToString() != comm.Parameters["@ID"].Value.ToString()))
                            {
                                row.ItemArray = new object[] { row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3], row.ItemArray[4], row.ItemArray[5], row.ItemArray[6], false, row.ItemArray[8] };


                            }

                        }

                    }
                    else
                    {
                        comm.CommandText = "Select count(ppID) from stblProductPrice where ppProductID=@ProductID and ppstatus=1";
                        reader = comm.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            comm.CommandText = "Update stblProductPrice set ppstatus=1 where ppID=@ID";
                            comm.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void SaveTitleRecords(TextEdit fname, TextEdit sname,  MemoEdit remarks, DateEdit dateCreated, CheckEdit status, string tableName, bool canWrite, BarCheckItem editing, int currentRow)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                XtraMessageBox.Show("Full Name Required", "Specify Title Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fname.Focus();
                return;
            }
           
          
            comm = new SqlCommand();
            comm.Parameters.Add(new SqlParameter("@FName", fname.Text));
            comm.Parameters.Add(new SqlParameter("@SName", sname.Text));
            comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            comm.Parameters.Add(new SqlParameter("@Status", status.Checked));

            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    if (!mode[3])
                    {
                        comm.CommandText = "select tID from stblTitle where tFName=@Fname";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Title Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        comm.CommandText = "Insert into stblTitle (tfname,tsname,tremarks,tDateCreated,tstatus,tCreatorID,tCreatedDate) values(@fname,@sname,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                        dataSet.Tables[tableName].Rows.Add(primaryKey, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, UserName);
                        XtraMessageBox.Show(fname.Text + " Saved Sussusfully", "Title Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        comm.Parameters.Add(new SqlParameter("@EditorID", 1));
                        comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        comm.Parameters.Add(new SqlParameter("@ID", dataSet.Tables[tableName].Rows[currentRow].ItemArray[0]));

                        comm.Parameters.Add(new SqlParameter("@UserName", dataSet.Tables[tableName].Rows[currentRow].ItemArray[6]));
                        comm.CommandText = "select tID from stblTitle where tFName=@Fname and tID !=@ID";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Title Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.CommandText = "Update stblTitle set tfname=@fname, tsname=@sname,tremarks=@remarks,tStatus=@status,tEditorID=@EditorID,tEditedDate=@EditedDate where tID=@ID";
                        comm.ExecuteNonQuery();
                        dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { comm.Parameters["@ID"].Value, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, comm.Parameters["@username"].Value };

                        XtraMessageBox.Show(fname.Text + " Updated Sussusfully", "Title Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void SaveServiceTypeRecords(TextEdit fname, TextEdit sname, MemoEdit remarks, DateEdit dateCreated, CheckEdit status, string tableName, bool canWrite, BarCheckItem editing, int currentRow)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                XtraMessageBox.Show("Full Name Required", "Specify Service Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fname.Focus();
                return;
            }


            comm = new SqlCommand();
            comm.Parameters.Add(new SqlParameter("@FName", fname.Text));
            comm.Parameters.Add(new SqlParameter("@SName", sname.Text));
            comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            comm.Parameters.Add(new SqlParameter("@Status", status.Checked));

            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    if (!mode[5])
                    {
                        comm.CommandText = "select stID from stblServiceType where stFName=@Fname";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Service Type Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        comm.CommandText = "Insert into stblServiceType (stfname,stsname,stremarks,stDateCreated,ststatus,stCreatorID,stCreatedDate) values(@fname,@sname,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                        dataSet.Tables[tableName].Rows.Add(primaryKey, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, UserName);
                        XtraMessageBox.Show(fname.Text + " Saved Sussusfully", "Service Type Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        comm.Parameters.Add(new SqlParameter("@EditorID", 1));
                        comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        comm.Parameters.Add(new SqlParameter("@ID", dataSet.Tables[tableName].Rows[currentRow].ItemArray[0]));

                        comm.Parameters.Add(new SqlParameter("@UserName", dataSet.Tables[tableName].Rows[currentRow].ItemArray[6]));
                        comm.CommandText = "select stID from stblServiceType where stFName=@Fname and stID !=@ID";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Service Type Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.CommandText = "Update stblServiceType set stfname=@fname, stsname=@sname,stremarks=@remarks,stStatus=@status,stEditorID=@EditorID,stEditedDate=@EditedDate where stID=@ID";
                        comm.ExecuteNonQuery();
                        dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { comm.Parameters["@ID"].Value, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, comm.Parameters["@Username"].Value };

                        XtraMessageBox.Show(fname.Text + " Updated Sussusfully", "ServiceType Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void EditValue(LayoutControl le,GridControl gc, GridView gv,BarCheckItem bciEdit,bool canEdit)
        {
            if (!canEdit)
            {
                XtraMessageBox.Show("You dont Have Edit Access, Contact Admin", "You cant edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bciEdit.Checked = false;
                return;
            }
            if (gv.RowCount == 0)
            {
                XtraMessageBox.Show("There are no records To Edit", "No records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bciEdit.Checked = false;
                return;
            }
            string tableName = gc.Name;
            int currentRow = gv.GetFocusedDataSourceRowIndex();
            gc.UseEmbeddedNavigator = true;
            switch (le.Name)
            {
                case "lcCars":
                    le.Controls["teCarFName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1];
                    le.Controls["teCarSName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2];
                    //le.Controls["teVin"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[4];
                    (le.Controls["leCarManufacturer"] as LookUpEdit).EditValue = (le.Controls["leCarManufacturer"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[3]);
                    (le.Controls["deCarYear"] as DateEdit).DateTime = new DateTime((int)dataSet.Tables[tableName].Rows[currentRow].ItemArray[4], 01, 01);
                    le.Controls["meCarRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[6];
                    (le.Controls["deCarDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[7];
                    (le.Controls["ckeCarStatus"] as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[8];
                    (le.Controls["peCarImage"] as PictureEdit).Image = (Image)imgConverter.ConvertFrom(dataSet.Tables[tableName].Rows[currentRow].ItemArray[5]);
                    break;
                case "lcCarManufacturer":
                    le.Controls["teCMFName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1];
                    le.Controls["teCMSName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2];
                    le.Controls["meCMRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[3];
                    (le.Controls["deCMDateCreated"] as DateEdit).DateTime= (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[4];
                    (le.Controls["ckeCMStatus"]as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[5];
                    break;
                case "lcProduct":
                    le.Controls["tePdFName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1];
                    le.Controls["tePdSName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2];
                    le.Controls["tePdUnitPrice"].Text = dataSet.Tables[tableName].Rows[currentRow].ItemArray[3].ToString();
                    (le.Controls["sePdTaxRate"] as SpinEdit).Value = Convert.ToDecimal(dataSet.Tables[tableName].Rows[currentRow].ItemArray[4]);
                    (le.Controls["sePdVatRate"] as SpinEdit).EditValue = Convert.ToDecimal(dataSet.Tables[tableName].Rows[currentRow].ItemArray[5]);
                    le.Controls["mePdRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[6];
                    (le.Controls["dePdDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[7];
                    (le.Controls["ckePdStatus"] as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[8];

                    break;
                case "lcTitle":
                    le.Controls["teTFName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1];
                    le.Controls["teTSName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2];
                    le.Controls["meTRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[3];
                    (le.Controls["deTDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[4];
                    (le.Controls["ckeTStatus"] as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[5];
                    break;
                case "lcCustomers":
                    le.Controls["teCDFName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2];
                    le.Controls["teCDSName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[3];
                    (le.Controls["leCDTitle"] as LookUpEdit).EditValue = (le.Controls["leCDTitle"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1]);
                    le.Controls["teCDID"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[4];
                    le.Controls["teCDAddress"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[5];
                    le.Controls["meCDRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[7];
                    (le.Controls["deCDDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[8];
                    (le.Controls["ckeCDStatus"] as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[9];
                    le.Controls["teCDPhone"].Text =(string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[6];
                    break;
                case "lcServiceType":
                    le.Controls["teSTFName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1];
                    le.Controls["teSTSName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2];
                    le.Controls["meSTRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[3];
                    (le.Controls["deSTDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[4];
                    (le.Controls["ckeSTStatus"] as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[5];
                    break;
                case "lcCarServicing":

                    (le.Controls["leDCSCustomer"] as LookUpEdit).EditValue = (le.Controls["leDCSCustomer"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2]);
                 
                    (le.Controls["leDCSServiceType"] as LookUpEdit).EditValue = (le.Controls["leDCSServiceType"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[6]);
                    (le.Controls["teDCSAmount"] as TextEdit).EditValue = default(decimal);
                    le.Controls["meDCSRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[7];
                    (le.Controls["deDCSDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[8];


                    (le.Controls["teDCSTotalAmount"] as TextEdit).EditValue = dataSet.Tables[tableName].Rows[currentRow].ItemArray[10];
                    //le.Controls["teDCSBalance"].Text= dataSet.Tables[tableName].Rows[currentRow].ItemArray[10].ToString();
                    //le.Controls["teDCSTotalAmount"].Text=
                    (le.Controls["leDCSCar"] as LookUpEdit).EditValue = (le.Controls["leDCSCar"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[5]);
                    break;
                case "lcProductPrice":
                    (le.Controls["lePPProduct"] as LookUpEdit).EditValue = (le.Controls["lePPProduct"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1]);
                    le.Controls["tePPUnitPrice"].Text = dataSet.Tables[tableName].Rows[currentRow].ItemArray[2].ToString();
                    (le.Controls["sePPTaxRate"] as SpinEdit).Value = Convert.ToDecimal(dataSet.Tables[tableName].Rows[currentRow].ItemArray[3]);
                    (le.Controls["sePPVatRate"] as SpinEdit).Value = Convert.ToDecimal(dataSet.Tables[tableName].Rows[currentRow].ItemArray[4]);
                    le.Controls["mePPRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[5];
                    (le.Controls["dePPDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[6];
                    (le.Controls["ckePPStatus"] as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[7];
                    break;
                case "lcCompanyInfo":
                    le.Controls["teCIFName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1];
                    le.Controls["teCISName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2];
                    le.Controls["teCISlogan"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[3];
                    le.Controls["teCIAddress"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[4];
                    le.Controls["teCIPhone"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[5];
                    (le.Controls["peCILogo"] as PictureEdit).Image = (Image)imgConverter.ConvertFrom(dataSet.Tables[tableName].Rows[currentRow].ItemArray[6]);
                    le.Controls["meCIRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[7];
                    (le.Controls["deCIDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[8];
                    (le.Controls["ckeCIStatus"] as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[9];
                    break;
                case "lcEmployee":
                    le.Controls["teSfFName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1];
                    le.Controls["teSfLName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2];
                    le.Controls["teSfOName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[3];
                    (le.Controls["deSfDOB"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[4];
                    (le.Controls["peSfImage"] as PictureEdit).Image = (Image)imgConverter.ConvertFrom(dataSet.Tables[tableName].Rows[currentRow].ItemArray[5]);
                    (le.Controls["leSfGender"] as LookUpEdit).EditValue = (le.Controls["leSfGender"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[6]);
                    (le.Controls["leSfTitle"] as LookUpEdit).EditValue = (le.Controls["leSfTitle"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[7]);
                    (le.Controls["leSfMStatus"] as LookUpEdit).EditValue = (le.Controls["leSfMStatus"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[8]);
                    (le.Controls["leSfCountry"] as LookUpEdit).EditValue = (le.Controls["leSfCountry"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[9]);
                    (le.Controls["leSfRegion"] as LookUpEdit).EditValue = (le.Controls["leSfRegion"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[10]);
                    (le.Controls["leSfTown"] as LookUpEdit).EditValue = (le.Controls["leSfTown"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[11]);
                    le.Controls["teSfPhone"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[12];
                    le.Controls["teSfAddress"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[13];
                    le.Controls["teSfEmail"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[14];
                    le.Controls["teSfStaffID"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[15];
                    (le.Controls["leSfQualification"] as LookUpEdit).EditValue = (le.Controls["leSfQualification"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[17]);
                    (le.Controls["leSfEmployeeType"] as LookUpEdit).EditValue = (le.Controls["leSfEmployeeType"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[18]);
                    (le.Controls["leSfJobType"] as LookUpEdit).EditValue = (le.Controls["leSfJobType"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[19]);
                    (le.Controls["deSfStartDate"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[20];
                    (le.Controls["deSfEndDate"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[21];
                    le.Controls["meSfRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[22];
                    (le.Controls["deSfDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[23];
                    (le.Controls["ckeSfStatus"] as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[24];
                  
                    break;
                case "lcGender":
                    le.Controls["teGFName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1];
                    le.Controls["teGSName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2];
                    le.Controls["meGRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[3];
                    (le.Controls["deGDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[4];
                    (le.Controls["ckeGStatus"] as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[5];
                    break;
                case "lcMaritalStatus":
                    le.Controls["teMSFName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1];
                    le.Controls["teMSSName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2];
                    le.Controls["meMSRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[3];
                    (le.Controls["deMSDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[4];
                    (le.Controls["ckeMSStatus"] as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[5];
                    break;
                case "lcCountry":
                    le.Controls["teConFName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1];
                    le.Controls["teConSName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2];
                    le.Controls["meConRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[3];
                    (le.Controls["deConDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[4];
                    (le.Controls["ckeConStatus"] as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[5];
                    break;
                case "lcRegion":
                    le.Controls["teRegFName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1];
                    le.Controls["teRegSName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2];
                    (le.Controls["leRegCountry"] as LookUpEdit).EditValue = (le.Controls["leRegCountry"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[3]);
                    le.Controls["meRegRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[4];
                    (le.Controls["deRegDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[5];
                    (le.Controls["ckeRegStatus"] as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[6];
                    break;
                case "lcTown":
                    le.Controls["teTwnFName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1];
                    le.Controls["teTwnSName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2];
                    (le.Controls["leTwnCountry"] as LookUpEdit).EditValue = (le.Controls["leTwnCountry"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[3]);
                    (le.Controls["leTwnRegion"] as LookUpEdit).EditValue = (le.Controls["leTwnRegion"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[4]);
                    le.Controls["meTwnRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[5];
                    (le.Controls["deTwnDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[6];
                    (le.Controls["ckeTwnStatus"] as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[7];
                    break;
                case "lcQualification":
                    le.Controls["teQFName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1];
                    le.Controls["teQSName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2];
                    le.Controls["meQRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[3];
                    (le.Controls["deQDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[4];
                    (le.Controls["ckeQStatus"] as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[5];
                    break;
                case "lcEmployeeType":
                    le.Controls["teETFName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1];
                    le.Controls["teETSName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2];
                    le.Controls["meETRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[3];
                    (le.Controls["deETDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[4];
                    (le.Controls["ckeETStatus"] as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[5];
                    break;
                case "lcJobType":
                    le.Controls["teJTFName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1];
                    le.Controls["teJTSName"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2];
                    le.Controls["meJTRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[3];
                    (le.Controls["deJTDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[4];
                    (le.Controls["ckeJTStatus"] as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[5];
                    break;
                case "lcCustomerCar":
                    (le.Controls["leCCCustomer"] as LookUpEdit).EditValue = (le.Controls["leCCCustomer"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[1]);
                    (le.Controls["leCCCar"] as LookUpEdit).EditValue = (le.Controls["leCCCar"] as LookUpEdit).Properties.GetKeyValueByDisplayText((string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[2]);
                    le.Controls["teCCVIN"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[3];
                    le.Controls["teCCRegNum"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[4];
                    le.Controls["meCCRemarks"].Text = (string)dataSet.Tables[tableName].Rows[currentRow].ItemArray[5];
                    (le.Controls["deCCDateCreated"] as DateEdit).DateTime = (DateTime)dataSet.Tables[tableName].Rows[currentRow].ItemArray[6];
                    (le.Controls["ckeCCStatus"] as CheckEdit).Checked = (bool)dataSet.Tables[tableName].Rows[currentRow].ItemArray[7];
                    break;
            }
        }
        public void ClearValue(LayoutControl le,string  tableName)
        {
            switch(tableName)
            {
                case "lcCars":
                    le.Controls["teCarFName"].Text = string.Empty;
                    le.Controls["teCarSName"].Text = string.Empty;
                   
                    (le.Controls["leCarManufacturer"] as LookUpEdit).EditValue = null;
                    (le.Controls["deCarYear"] as DateEdit).DateTime = new DateTime(DateTime.Now.Year, 01, 01);
                    le.Controls["meCarRemarks"].Text = string.Empty;
                    (le.Controls["deCarDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckeCarStatus"] as CheckEdit).Checked = false;
                    (le.Controls["peCarImage"] as PictureEdit).Image = null;
                    break;
                case "lcCarManufacturer":
                    le.Controls["teCMFName"].Text = string.Empty;
                    le.Controls["teCMSName"].Text = string.Empty;
                    le.Controls["meCMRemarks"].Text = string.Empty;
                    (le.Controls["deCMDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckeCMStatus"] as CheckEdit).Checked = false;
                    break;
                case "lcProduct":
                    le.Controls["tePdFName"].Text = string.Empty;
                    le.Controls["tePdSName"].Text = string.Empty;
                    le.Controls["tePdUnitPrice"].Text = string.Empty;
                    (le.Controls["sePdTaxRate"] as SpinEdit).Value = 0;
                    (le.Controls["sePdVatRate"] as SpinEdit).Value = 0;
                    le.Controls["mePdRemarks"].Text = string.Empty;
                    (le.Controls["dePdDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckePdStatus"] as CheckEdit).Checked = false;
                    break;
                case "lcTitle":
                    le.Controls["teTFName"].Text = string.Empty;
                    le.Controls["teTSName"].Text = string.Empty;
                    le.Controls["meTRemarks"].Text = string.Empty;
                    (le.Controls["deTDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckeTStatus"] as CheckEdit).Checked = false;
                    break;
                case "lcCustomers":
                    le.Controls["teCDFName"].Text = string.Empty;
                    le.Controls["teCDSName"].Text = string.Empty;
                    (le.Controls["leCDTitle"] as LookUpEdit).EditValue = null;
                    le.Controls["teCDID"].Text = string.Empty;
                    le.Controls["teCDAddress"].Text = string.Empty;
                    le.Controls["meCDRemarks"].Text = string.Empty;
                    (le.Controls["deCDDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckeCDStatus"] as CheckEdit).Checked = false;
                    le.Controls["teCDPhone"].Text = string.Empty;
                    break;
                case "lcServiceType":
                    le.Controls["teSTFName"].Text = string.Empty;
                    le.Controls["teSTSName"].Text = string.Empty;
                    le.Controls["meSTRemarks"].Text = string.Empty;
                    (le.Controls["deSTDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckeSTStatus"] as CheckEdit).Checked = false;
                    break;
                case "lcCarServicing":

                    (le.Controls["leDCSCustomer"] as LookUpEdit).EditValue = null;


                    (le.Controls["leDCSCar"] as LookUpEdit).EditValue = null;


                    (le.Controls["leDCSServiceType"] as LookUpEdit).EditValue = null;

                  
                    le.Controls["meDCSRemarks"].Text = string.Empty;
                    // le.Controls["teDCSPrevAmount"].Text = string.Empty;
                  
                    (le.Controls["teDCSTotalAmount"] as TextEdit).EditValue = default(decimal);
                    (le.Controls["deDCSDateCreated"] as DateEdit).DateTime = DateTime.Now;
                 
                    break;
                case "lcProductPrice":
                    (le.Controls["lePPProduct"] as LookUpEdit).EditValue = null;
                    le.Controls["tePPUnitPrice"].Text = null;
                    (le.Controls["sePPTaxRate"] as SpinEdit).Value = 0;
                    (le.Controls["sePPVatRate"] as SpinEdit).Value = 0;
                    le.Controls["mePPRemarks"].Text = string.Empty;
                    (le.Controls["dePPDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckePPStatus"] as CheckEdit).Checked = false;
                    break;
                case "lcCompanyInfo":
                    le.Controls["teCIFName"].Text = string.Empty;
                    le.Controls["teCISName"].Text = string.Empty;
                    le.Controls["teCISlogan"].Text = string.Empty;
                    le.Controls["teCIAddress"].Text = string.Empty;
                    le.Controls["teCIPhone"].Text = string.Empty;
                    (le.Controls["peCILogo"] as PictureEdit).Image = null;
                    le.Controls["meCIRemarks"].Text = string.Empty;
                    (le.Controls["deCIDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckeCIStatus"] as CheckEdit).Checked = false;
                    break;
                case "lcEmployee":
                    le.Controls["teSfFName"].Text = string.Empty;
                    le.Controls["teSfLName"].Text = string.Empty;
                    le.Controls["teSfOName"].Text = string.Empty;
                    (le.Controls["deSfDOB"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["peSfImage"] as PictureEdit).Image = null;
                    (le.Controls["leSfGender"] as LookUpEdit).EditValue = null;
                    (le.Controls["leSfTitle"] as LookUpEdit).EditValue = null;
                    (le.Controls["leSfMStatus"] as LookUpEdit).EditValue = null;
                    (le.Controls["leSfCountry"] as LookUpEdit).EditValue = null;
                    (le.Controls["leSfRegion"] as LookUpEdit).EditValue = null;
                    (le.Controls["leSfTown"] as LookUpEdit).EditValue = null;
                    le.Controls["teSfPhone"].Text = string.Empty;
                    le.Controls["teSfAddress"].Text = string.Empty;
                    le.Controls["teSfEmail"].Text = string.Empty;
                    le.Controls["teSfStaffID"].Text = string.Empty;
                    (le.Controls["leSfQualification"] as LookUpEdit).EditValue = null;
                    (le.Controls["leSfEmployeeType"] as LookUpEdit).EditValue = null;
                    (le.Controls["leSfJobType"] as LookUpEdit).EditValue = null;
                    (le.Controls["deSfStartDate"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["deSfEndDate"] as DateEdit).DateTime = DateTime.Now;
                    le.Controls["meSfRemarks"].Text = string.Empty;
                    (le.Controls["deSfDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckeSfStatus"] as CheckEdit).Checked = false;

                    break;
                case "lcGender":
                    le.Controls["teGFName"].Text = string.Empty;
                    le.Controls["teGSName"].Text = string.Empty;
                    le.Controls["meGRemarks"].Text = string.Empty;
                    (le.Controls["deGDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckeGStatus"] as CheckEdit).Checked = false;
                    break;
                case "lcMaritalStatus":
                    le.Controls["teMSFName"].Text = string.Empty;
                    le.Controls["teMSSName"].Text = string.Empty;
                    le.Controls["meMSRemarks"].Text = string.Empty;
                    (le.Controls["deMSDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckeMSStatus"] as CheckEdit).Checked = false;
                    break;
                case "lcCountry":
                    le.Controls["teConFName"].Text = string.Empty;
                    le.Controls["teConSName"].Text = string.Empty;
                    le.Controls["meConRemarks"].Text = string.Empty;
                    (le.Controls["deConDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckeConStatus"] as CheckEdit).Checked = false;
                    break;
                case "lcRegion":
                    le.Controls["teRegFName"].Text = string.Empty;
                    le.Controls["teRegSName"].Text = string.Empty;
                    (le.Controls["leRegCountry"] as LookUpEdit).EditValue = null;
                    le.Controls["meRegRemarks"].Text = string.Empty;
                    (le.Controls["deRegDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckeRegStatus"] as CheckEdit).Checked = false;
                    break;
                case "lcTown":
                    le.Controls["teTwnFName"].Text = string.Empty;
                    le.Controls["teTwnSName"].Text = string.Empty;
                    (le.Controls["leTwnCountry"] as LookUpEdit).EditValue = null;
                    (le.Controls["leTwnRegion"] as LookUpEdit).EditValue = null;
                    le.Controls["meTwnRemarks"].Text = string.Empty;
                    (le.Controls["deTwnDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckeTwnStatus"] as CheckEdit).Checked = false;
                    break;
                case "lcQualification":
                    le.Controls["teQFName"].Text = string.Empty;
                    le.Controls["teQSName"].Text = string.Empty;
                    le.Controls["meQRemarks"].Text = string.Empty;
                    (le.Controls["deQDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckeQStatus"] as CheckEdit).Checked = false;
                    break;
                case "lcEmployeeType":
                    le.Controls["teETFName"].Text = string.Empty;
                    le.Controls["teETSName"].Text = string.Empty;
                    le.Controls["meETRemarks"].Text = string.Empty;
                    (le.Controls["deETDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckeETStatus"] as CheckEdit).Checked = false;
                    break;
                case "lcJobType":
                    le.Controls["teJTFName"].Text = string.Empty;
                    le.Controls["teJTSName"].Text = string.Empty;
                    le.Controls["meJTRemarks"].Text = string.Empty;
                    (le.Controls["deJTDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckeJTStatus"] as CheckEdit).Checked = false;
                    break;
                case "lcCustomerCar":
                    (le.Controls["leCCCustomer"] as LookUpEdit).EditValue = null;
                    (le.Controls["leCCCar"] as LookUpEdit).EditValue = null;
                    le.Controls["teCCVIN"].Text = string.Empty;
                    le.Controls["teCCRegNum"].Text = string.Empty;
                    le.Controls["meCCRemarks"].Text = string.Empty;
                    (le.Controls["deCCDateCreated"] as DateEdit).DateTime = DateTime.Now;
                    (le.Controls["ckeCCStatus"] as CheckEdit).Checked = false;
                    break;
            }

        }

        //this method needs futher testing
        public void SaveCompanyInfoRecords(TextEdit fname, TextEdit sname,TextEdit slogan,TextEdit address,TextEdit phone, PictureEdit image, MemoEdit remarks, DateEdit dateCreated, CheckEdit status, string tableName, bool canWrite, BarCheckItem editing, int currentRow,GridView gv,Form parentForm)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                XtraMessageBox.Show("Full Name Required", "Specify Company Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fname.Focus();
                return;

            }
            if (string.IsNullOrWhiteSpace(slogan.Text))
            {
                XtraMessageBox.Show("Select a Company Slogan", "Specify Company Slogan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                slogan.Focus();
                return;
            }
            if (image.Image == null)
            {
                XtraMessageBox.Show("Right Click the image Box to load an image", "Specify Company Logo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                image.Focus();
                return;
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
            if (string.IsNullOrWhiteSpace(address.Text))
            {
                XtraMessageBox.Show("Speify the address the Company", "Specify Company Address", MessageBoxButtons.OK, MessageBoxIcon.Information);
                slogan.Focus();
                return;
            }
            byte[] imgByte = (byte[])imgConverter.ConvertTo(image.Image, typeof(byte[]));

            comm = new SqlCommand();
            comm.Parameters.Add(new SqlParameter("@FName", fname.Text));
            comm.Parameters.Add(new SqlParameter("@SName", sname.Text));
           
            comm.Parameters.Add(new SqlParameter("@Slogan", slogan.Text));
            comm.Parameters.Add(new SqlParameter("@Address", address.Text));
            comm.Parameters.Add(new SqlParameter("@Phone", phone.Text));
            comm.Parameters.Add(new SqlParameter("@Image", imgByte));
            comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            comm.Parameters.Add(new SqlParameter("@Status", status.Checked));
            comm.Parameters.Add(new SqlParameter("@ID",1));
            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    if (!mode[8])
                    {
                        comm.CommandText = "select ciID from stblCompanyInfo where ciFName=@Fname";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Company Name Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        comm.CommandText = "Insert into stblCompanyInfo (cifname,cisname,ciSlogan,ciAddress,ciPhone,ciLogo,ciremarks,ciDateCreated,cistatus,ciCreatorID,ciCreatedDate) values(@fname,@sname,@slogan,@address,@phone,@image,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                        comm.Parameters["@ID"].Value = primaryKey;
                        dataSet.Tables[tableName].Rows.Add(primaryKey, fname.Text, sname.Text, slogan.Text, address.Text, phone.Text, imgByte, remarks.Text, dateCreated.DateTime, status.Checked, UserName);
                        XtraMessageBox.Show(fname.Text + " Saved Succusfully", "Company Info Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        comm.Parameters.Add(new SqlParameter("@EditorID", 1));
                        comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        comm.Parameters["@ID"].Value= dataSet.Tables[tableName].Rows[currentRow].ItemArray[0];
                        comm.Parameters.Add(new SqlParameter("@UserName", dataSet.Tables[tableName].Rows[currentRow].ItemArray[10]));
                        comm.CommandText = "select ciID from stblCompanyInfo where ciFName=@Fname and ciID !=@ID";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Company Info Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.CommandText = "Update stblCompanyInfo set cifname=@fname, cisname=@sname,ciSlogan=@Slogan,ciAddress=@address,ciPhone=@phone,ciLogo=@image,ciremarks=@remarks,ciStatus=@status,ciEditorID=@EditorID,ciEditedDate=@EditedDate where ciID=@ID";
                        comm.ExecuteNonQuery();
                        dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { comm.Parameters["@ID"].Value, fname.Text, sname.Text, slogan.Text, address.Text, phone.Text, imgByte, remarks.Text, dateCreated.DateTime, status.Checked, comm.Parameters["@UserName"].Value };

                        XtraMessageBox.Show(fname.Text + " Updated Sussusfully", "Company Info Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if((bool)comm.Parameters["@Status"].Value)
                    {
                        comm.CommandText = "Update stblCompanyInfo set ciStatus=0 where ciID !=@ID";
                        comm.ExecuteNonQuery();
                        for(int i=0;i< dataSet.Tables[tableName].Rows.Count;i++)
                        {
                            DataRow row = dataSet.Tables[tableName].Rows[i];
                            if ((int)row.ItemArray[0]!= (int)comm.Parameters["@ID"].Value)
                                gv.SetRowCellValue(i, "ciStatus", false);
                        }
                        Properties.Settings.Default.nameSetting = fname.Text;
                        parentForm.Text = fname.Text;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        comm.CommandText = "Select ciID from stblCompanyInfo where ciStatus=1";
                        reader = comm.ExecuteReader();
                        if(!reader.HasRows)
                        {
                            reader.Close();
                            comm.CommandText = "Update stblCompanyInfo set ciStatus=1 where ciID=@ID";
                            comm.ExecuteNonQuery();
                            gv.SetRowCellValue(currentRow, "ciStatus", true);
                            Properties.Settings.Default.nameSetting = fname.Text;
                            parentForm.Text = fname.Text;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Contact Admin To Fix this", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public bool SignIn(TextEdit username,TextEdit password)
        {
            bool signedIn = false;
            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    comm = new SqlCommand();
                    comm.Connection = connx;
                    comm.Parameters.Add(new SqlParameter("@Username", username.Text));
                    comm.Parameters.Add(new SqlParameter("@Password", password.Text));
                    comm.CommandText = "Select sfID,sfStatus,tSname,sfFName,sfLName,sfImage from vwEmployee where sfStaffID=@username and sfPassword=@password";
                    reader = comm.ExecuteReader();
                    if(reader.HasRows)
                    {
                        bool status = false;
                        while(reader.Read())
                        {
                            
                            if(!(status = Convert.ToBoolean(reader[1])))
                            {
                                XtraMessageBox.Show("Your account has been blocked, Contact Admin!", "Your account Is Blocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                signedIn = true;
                                userID = Convert.ToInt32(reader[0]);
                                UserName = Convert.ToString(reader[2]) + "" + Convert.ToString(reader[4]) + " " + Convert.ToString(reader[3]);
                                staffImage = (Image)imgConverter.ConvertFrom(reader[5]);
                                accessStatus = new bool[20, 3];
                                //Load UserPriviledge
                                reader.Close();
                                comm.Parameters.Add(new SqlParameter("@UserID", userID));
                                comm.CommandText = "Select upFmID,upRead,upWrite,upEdit from stblUserPriviledge where upSfID=@UserID";
                                reader = comm.ExecuteReader();
                               
                                while(reader.Read())
                                {
                                    accessStatus[Convert.ToInt32(reader[0])-1, 0] = Convert.ToBoolean(reader[1]);
                                    accessStatus[Convert.ToInt32(reader[0])-1, 1] = Convert.ToBoolean(reader[2]);
                                    accessStatus[Convert.ToInt32(reader[0])-1, 2] = Convert.ToBoolean(reader[3]);
                                }
                            }
                            
                        }
                    }
                    else
                    {
                        username.Focus();
                        XtraMessageBox.Show("Your Credentials are Invalid, Check And try again!", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Contact Admin To Fix this", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return signedIn;
        }
        public void ChangePassword(TextEdit username,TextEdit oldPassword, TextEdit newPassword)
        {
            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    comm = new SqlCommand();
                    comm.Connection = connx;
                    comm.Parameters.Add(new SqlParameter("@Username", username.Text));
                    comm.Parameters.Add(new SqlParameter("@Password", oldPassword.Text));
                    comm.Parameters.Add(new SqlParameter("@NewPassword", newPassword.Text));
                    comm.CommandText = "Update etblEmployee set sfPassword=@NewPassword where sfStaffID=@username and sfPassword=@Password;select scope_identity()";
                    object row = comm.ExecuteScalar();
                    if (row!=null)
                    {
                        XtraMessageBox.Show("You have succusfully changed your passoword", "Password Changed Succusfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        username.Focus();
                        XtraMessageBox.Show("Your Credentials are Invalid, Check And try again!", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Contact Admin To Fix this", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }
        public void SaveGenderRecords(TextEdit fname, TextEdit sname, MemoEdit remarks, DateEdit dateCreated, CheckEdit status, string tableName, bool canWrite, BarCheckItem editing, int currentRow)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                XtraMessageBox.Show("Full Name Required", "Specify Gender Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fname.Focus();
                return;
            }


            comm = new SqlCommand();
            comm.Parameters.Add(new SqlParameter("@FName", fname.Text));
            comm.Parameters.Add(new SqlParameter("@SName", sname.Text));
            comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            comm.Parameters.Add(new SqlParameter("@Status", status.Checked));

            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    if (!mode[10])
                    {
                        comm.CommandText = "select gID from stblGender where gFName=@Fname";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Gender Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        comm.CommandText = "Insert into stblGender (gfname,gsname,gremarks,gDateCreated,gstatus,gCreatorID,gCreatedDate) values(@fname,@sname,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                        dataSet.Tables[tableName].Rows.Add(primaryKey, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, UserName);
                        XtraMessageBox.Show(fname.Text + " Saved Sussusfully", "Gender Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        comm.Parameters.Add(new SqlParameter("@EditorID", 1));
                        comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        comm.Parameters.Add(new SqlParameter("@ID", dataSet.Tables[tableName].Rows[currentRow].ItemArray[0]));

                        comm.Parameters.Add(new SqlParameter("@UserName", dataSet.Tables[tableName].Rows[currentRow].ItemArray[6]));
                        comm.CommandText = "select gID from stblGender where gFName=@Fname and gID !=@ID";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Gender Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.CommandText = "Update stblGender set gfname=@fname, gsname=@sname,gremarks=@remarks,gStatus=@status,gEditorID=@EditorID,gEditedDate=@EditedDate where gID=@ID";
                        comm.ExecuteNonQuery();
                        dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { comm.Parameters["@ID"].Value, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, comm.Parameters["@username"].Value };

                        XtraMessageBox.Show(fname.Text + " Updated Sussusfully", "Gender Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void SaveMaritalStatusRecords(TextEdit fname, TextEdit sname, MemoEdit remarks, DateEdit dateCreated, CheckEdit status, string tableName, bool canWrite, BarCheckItem editing, int currentRow)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                XtraMessageBox.Show("Full Name Required", "Specify Marital Status Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fname.Focus();
                return;
            }


            comm = new SqlCommand();
            comm.Parameters.Add(new SqlParameter("@FName", fname.Text));
            comm.Parameters.Add(new SqlParameter("@SName", sname.Text));
            comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            comm.Parameters.Add(new SqlParameter("@Status", status.Checked));

            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    if (!mode[11])
                    {
                        comm.CommandText = "select msID from stblMaritalStatus where msFName=@Fname";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Marital Status Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        comm.CommandText = "Insert into stblMaritalStatus (msfname,mssname,msremarks,msDateCreated,msstatus,msCreatorID,msCreatedDate) values(@fname,@sname,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                        dataSet.Tables[tableName].Rows.Add(primaryKey, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, UserName);
                        XtraMessageBox.Show(fname.Text + " Saved Sussusfully", "Marital Status Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        comm.Parameters.Add(new SqlParameter("@EditorID", 1));
                        comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        comm.Parameters.Add(new SqlParameter("@ID", dataSet.Tables[tableName].Rows[currentRow].ItemArray[0]));

                        comm.Parameters.Add(new SqlParameter("@UserName", dataSet.Tables[tableName].Rows[currentRow].ItemArray[6]));
                        comm.CommandText = "select msID from stblMaritalStatus where msFName=@Fname and msID !=@ID";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Marital Status Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.CommandText = "Update stblMaritalStatus set msfname=@fname, mssname=@sname,msremarks=@remarks,msStatus=@status,msEditorID=@EditorID,msEditedDate=@EditedDate where msID=@ID";
                        comm.ExecuteNonQuery();
                        dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { comm.Parameters["@ID"].Value, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, comm.Parameters["@username"].Value };

                        XtraMessageBox.Show(fname.Text + " Updated Sussusfully", "Marital Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void SaveCountryRecords(TextEdit fname, TextEdit sname, MemoEdit remarks, DateEdit dateCreated, CheckEdit status, string tableName, bool canWrite, BarCheckItem editing, int currentRow)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                XtraMessageBox.Show("Full Name Required", "Specify Country Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fname.Focus();
                return;
            }


            comm = new SqlCommand();
            comm.Parameters.Add(new SqlParameter("@FName", fname.Text));
            comm.Parameters.Add(new SqlParameter("@SName", sname.Text));
            comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            comm.Parameters.Add(new SqlParameter("@Status", status.Checked));

            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    if (!mode[12])
                    {
                        comm.CommandText = "select conID from stblCountry where conFName=@Fname";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Country Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        comm.CommandText = "Insert into stblCountry (confname,consname,conremarks,conDateCreated,constatus,conCreatorID,conCreatedDate) values(@fname,@sname,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                        dataSet.Tables[tableName].Rows.Add(primaryKey, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, UserName);
                        XtraMessageBox.Show(fname.Text + " Saved Sussusfully", "Country Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        comm.Parameters.Add(new SqlParameter("@EditorID", 1));
                        comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        comm.Parameters.Add(new SqlParameter("@ID", dataSet.Tables[tableName].Rows[currentRow].ItemArray[0]));

                        comm.Parameters.Add(new SqlParameter("@UserName", dataSet.Tables[tableName].Rows[currentRow].ItemArray[6]));
                        comm.CommandText = "select conID from stblCountry where conFName=@Fname and conID !=@ID";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Country Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.CommandText = "Update stblCountry set confname=@fname, consname=@sname,conremarks=@remarks,conStatus=@status,conEditorID=@EditorID,conEditedDate=@EditedDate where conID=@ID";
                        comm.ExecuteNonQuery();
                        dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { comm.Parameters["@ID"].Value, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, comm.Parameters["@username"].Value };

                        XtraMessageBox.Show(fname.Text + " Updated Sussusfully", "Country Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void SaveRegionRecords(TextEdit fname, TextEdit sname,LookUpEdit country, MemoEdit remarks, DateEdit dateCreated, CheckEdit status, string tableName, bool canWrite, BarCheckItem editing, int currentRow)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (country.EditValue==null)
            {
                XtraMessageBox.Show("Select a country from the country drop down list", "Select a Country", MessageBoxButtons.OK, MessageBoxIcon.Information);
                country.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                XtraMessageBox.Show("Full Name Required", "Specify Region Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fname.Focus();
                return;
            }


            comm = new SqlCommand();
            comm.Parameters.Add(new SqlParameter("@FName", fname.Text));
            comm.Parameters.Add(new SqlParameter("@SName", sname.Text));
            comm.Parameters.Add(new SqlParameter("@Country", country.EditValue));
            comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            comm.Parameters.Add(new SqlParameter("@Status", status.Checked));

            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    if (!mode[13])
                    {
                        comm.CommandText = "select regID from stblRegion where regFName=@Fname and regConID=@country";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Region Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        comm.CommandText = "Insert into stblRegion (regfname,regsname,regConID,regremarks,regDateCreated,regstatus,regCreatorID,regCreatedDate) values(@fname,@sname,@country,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                        dataSet.Tables[tableName].Rows.Add(primaryKey, fname.Text, sname.Text, country.Text, remarks.Text, dateCreated.DateTime, status.Checked, UserName);
                        XtraMessageBox.Show(fname.Text + " Saved Sussusfully", "Region Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        comm.Parameters.Add(new SqlParameter("@EditorID", 1));
                        comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        comm.Parameters.Add(new SqlParameter("@ID", dataSet.Tables[tableName].Rows[currentRow].ItemArray[0]));

                        comm.Parameters.Add(new SqlParameter("@UserName", dataSet.Tables[tableName].Rows[currentRow].ItemArray[7]));
                        comm.CommandText = "select regID from stblRegion where regFName=@Fname and regconID=@country and regID !=@ID";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Region Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.CommandText = "Update stblRegion set regfname=@fname, regsname=@sname,regConID=@country,regremarks=@remarks,regStatus=@status,regEditorID=@EditorID,regEditedDate=@EditedDate where regID=@ID";
                        comm.ExecuteNonQuery();
                        dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { comm.Parameters["@ID"].Value, fname.Text, sname.Text, country.Text, remarks.Text, dateCreated.DateTime, status.Checked, comm.Parameters["@username"].Value };

                        XtraMessageBox.Show(fname.Text + " Updated Sussusfully", "Region Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void SaveTownRecords(TextEdit fname, TextEdit sname,LookUpEdit country, LookUpEdit region, MemoEdit remarks, DateEdit dateCreated, CheckEdit status, string tableName, bool canWrite, BarCheckItem editing, int currentRow)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (region.EditValue == null)
            {
                XtraMessageBox.Show("Select a region from the region drop down list", "Select a Region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                region.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                XtraMessageBox.Show("Full Name Required", "Specify Town Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fname.Focus();
                return;
            }


            comm = new SqlCommand();
            comm.Parameters.Add(new SqlParameter("@FName", fname.Text));
            comm.Parameters.Add(new SqlParameter("@SName", sname.Text));
            comm.Parameters.Add(new SqlParameter("@Region", region.EditValue));
            comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            comm.Parameters.Add(new SqlParameter("@Status", status.Checked));

            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    if (!mode[14])
                    {
                        comm.CommandText = "select twnID from stblTown where twnFName=@Fname and twnRegID=@region";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Town Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        comm.CommandText = "Insert into stblTown (twnfname,twnsname,twnRegID,twnremarks,twnDateCreated,twnstatus,twnCreatorID,twnCreatedDate) values(@fname,@sname,@region,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                        dataSet.Tables[tableName].Rows.Add(primaryKey, fname.Text, sname.Text, country.Text, region.Text, remarks.Text, dateCreated.DateTime, status.Checked, UserName);
                        XtraMessageBox.Show(fname.Text + " Saved Sussusfully", "Town Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        comm.Parameters.Add(new SqlParameter("@EditorID", 1));
                        comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        comm.Parameters.Add(new SqlParameter("@ID", dataSet.Tables[tableName].Rows[currentRow].ItemArray[0]));

                        comm.Parameters.Add(new SqlParameter("@UserName", dataSet.Tables[tableName].Rows[currentRow].ItemArray[8]));
                        comm.CommandText = "select twnID from stblTown where twnFName=@Fname and twnRegID=@region and twnID !=@ID";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Town Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.CommandText = "Update stblTown set twnfname=@fname, twnsname=@sname,twnRegID=@region,twnremarks=@remarks,twnStatus=@status,twnEditorID=@EditorID,twnEditedDate=@EditedDate where twnID=@ID";
                        comm.ExecuteNonQuery();
                        dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { comm.Parameters["@ID"].Value, fname.Text, sname.Text, country.Text, region.Text, remarks.Text, dateCreated.DateTime, status.Checked, comm.Parameters["@username"].Value };

                        XtraMessageBox.Show(fname.Text + " Updated Sussusfully", "Region Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void SaveQualificationRecords(TextEdit fname, TextEdit sname, MemoEdit remarks, DateEdit dateCreated, CheckEdit status, string tableName, bool canWrite, BarCheckItem editing, int currentRow)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                XtraMessageBox.Show("Full Name Required", "Specify Qualification Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fname.Focus();
                return;
            }


            comm = new SqlCommand();
            comm.Parameters.Add(new SqlParameter("@FName", fname.Text));
            comm.Parameters.Add(new SqlParameter("@SName", sname.Text));
            comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            comm.Parameters.Add(new SqlParameter("@Status", status.Checked));

            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    if (!mode[15])
                    {
                        comm.CommandText = "select qID from stblQualification where qFName=@Fname";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Qualification Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        comm.CommandText = "Insert into stblQualification (qfname,qsname,qremarks,qDateCreated,qstatus,qCreatorID,qCreatedDate) values(@fname,@sname,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                        dataSet.Tables[tableName].Rows.Add(primaryKey, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, UserName);
                        XtraMessageBox.Show(fname.Text + " Saved Sussusfully", "Qualification Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        comm.Parameters.Add(new SqlParameter("@EditorID", 1));
                        comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        comm.Parameters.Add(new SqlParameter("@ID", dataSet.Tables[tableName].Rows[currentRow].ItemArray[0]));

                        comm.Parameters.Add(new SqlParameter("@UserName", dataSet.Tables[tableName].Rows[currentRow].ItemArray[6]));
                        comm.CommandText = "select qID from stblQualification where qFName=@Fname and qID !=@ID";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Qualification Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.CommandText = "Update stblQualification set qfname=@fname, qsname=@sname,qremarks=@remarks,qStatus=@status,qEditorID=@EditorID,qEditedDate=@EditedDate where qID=@ID";
                        comm.ExecuteNonQuery();
                        dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { comm.Parameters["@ID"].Value, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, comm.Parameters["@username"].Value };

                        XtraMessageBox.Show(fname.Text + " Updated Sussusfully", "Qualification Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void SaveEmployeeTypeRecords(TextEdit fname, TextEdit sname, MemoEdit remarks, DateEdit dateCreated, CheckEdit status, string tableName, bool canWrite, BarCheckItem editing, int currentRow)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                XtraMessageBox.Show("Full Name Required", "Specify Employee Type Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fname.Focus();
                return;
            }


            comm = new SqlCommand();
            comm.Parameters.Add(new SqlParameter("@FName", fname.Text));
            comm.Parameters.Add(new SqlParameter("@SName", sname.Text));
            comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            comm.Parameters.Add(new SqlParameter("@Status", status.Checked));

            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    if (!mode[16])
                    {
                        comm.CommandText = "select etID from stblEmployeeType where etFName=@Fname";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Employee Type Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        comm.CommandText = "Insert into stblEmployeeType (etfname,etsname,etremarks,etDateCreated,etstatus,etCreatorID,etCreatedDate) values(@fname,@sname,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                        dataSet.Tables[tableName].Rows.Add(primaryKey, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, UserName);
                        XtraMessageBox.Show(fname.Text + " Saved Sussusfully", "Employee Type Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        comm.Parameters.Add(new SqlParameter("@EditorID", 1));
                        comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        comm.Parameters.Add(new SqlParameter("@ID", dataSet.Tables[tableName].Rows[currentRow].ItemArray[0]));

                        comm.Parameters.Add(new SqlParameter("@UserName", dataSet.Tables[tableName].Rows[currentRow].ItemArray[6]));
                        comm.CommandText = "select etID from stblEmployeeType where etFName=@Fname and etID !=@ID";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Employee Type Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.CommandText = "Update stblEmployeeType set etfname=@fname, etsname=@sname,etremarks=@remarks,etStatus=@status,etEditorID=@EditorID,etEditedDate=@EditedDate where etID=@ID";
                        comm.ExecuteNonQuery();
                        dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { comm.Parameters["@ID"].Value, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, comm.Parameters["@username"].Value };

                        XtraMessageBox.Show(fname.Text + " Updated Sussusfully", "Employee Type Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void SaveJobTypeRecords(TextEdit fname, TextEdit sname, MemoEdit remarks, DateEdit dateCreated, CheckEdit status, string tableName, bool canWrite, BarCheckItem editing, int currentRow)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(fname.Text))
            {
                XtraMessageBox.Show("Full Name Required", "Specify Job Type Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fname.Focus();
                return;
            }


            comm = new SqlCommand();
            comm.Parameters.Add(new SqlParameter("@FName", fname.Text));
            comm.Parameters.Add(new SqlParameter("@SName", sname.Text));
            comm.Parameters.Add(new SqlParameter("@Remarks", remarks.Text));
            comm.Parameters.Add(new SqlParameter("@DateCreated", dateCreated.DateTime));
            comm.Parameters.Add(new SqlParameter("@Status", status.Checked));

            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    if (!mode[17])
                    {
                        comm.CommandText = "select jtID from stblJobType where jtFName=@Fname";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Job Type Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
                        comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
                        comm.CommandText = "Insert into stblJobType (jtfname,jtsname,jtremarks,jtDateCreated,jtstatus,jtCreatorID,jtCreatedDate) values(@fname,@sname,@remarks,@DateCreated,@status,@creatorID,@createdDate);select scope_identity()";
                        primaryKey = Convert.ToInt32(comm.ExecuteScalar());
                        dataSet.Tables[tableName].Rows.Add(primaryKey, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, UserName);
                        XtraMessageBox.Show(fname.Text + " Saved Sussusfully", "Job Type Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        comm.Parameters.Add(new SqlParameter("@EditorID", 1));
                        comm.Parameters.Add(new SqlParameter("@EditedDate", DateTime.Now));
                        comm.Parameters.Add(new SqlParameter("@ID", dataSet.Tables[tableName].Rows[currentRow].ItemArray[0]));

                        comm.Parameters.Add(new SqlParameter("@UserName", dataSet.Tables[tableName].Rows[currentRow].ItemArray[6]));
                        comm.CommandText = "select jtID from stblJobType where jtFName=@Fname and jtID !=@ID";
                        comm.Connection = connx;
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            XtraMessageBox.Show(fname.Text + " exist!", "This Job Type Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        reader.Close();
                        comm.CommandText = "Update stblJobType set jtfname=@fname, jtsname=@sname,jtremarks=@remarks,jtStatus=@status,jtEditorID=@EditorID,jtEditedDate=@EditedDate where jtID=@ID";
                        comm.ExecuteNonQuery();
                        dataSet.Tables[tableName].Rows[currentRow].ItemArray = new object[] { comm.Parameters["@ID"].Value, fname.Text, sname.Text, remarks.Text, dateCreated.DateTime, status.Checked, comm.Parameters["@username"].Value };

                        XtraMessageBox.Show(fname.Text + " Updated Sussusfully", "Job Type Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void ChangeSelection(CheckEdit cke,GridView gv,string field)
        {
          
            if (cke.Checked)
            {
                for(int i=0;i<gv.RowCount;i++)
                {
                    gv.SetRowCellValue(i, field, true);
                }
               
              
            }
            else
            {
                for (int i = 0; i < gv.RowCount; i++)
                {
                    gv.SetRowCellValue(i, field, false);
                }
              
            }
        }
        public void SaveFormAccess(string formTable,string userTable,bool canWrite,BarCheckItem editing,int currentRow)
        {
            if (!editing.Checked && !canWrite)
            {

                XtraMessageBox.Show("You dont Have Write Access, Contact Admin", "You cant write", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
          

            comm = new SqlCommand();
            comm.Parameters.Add(new SqlParameter("@frmID",1));
            comm.Parameters.Add(new SqlParameter("@StaffID", 1));
            comm.Parameters.Add(new SqlParameter("@Read", 1));
            comm.Parameters.Add(new SqlParameter("@Write", 1));
            comm.Parameters.Add(new SqlParameter("@Edit", 1));
            comm.Parameters.Add(new SqlParameter("@CreatorID", 1));
            comm.Parameters.Add(new SqlParameter("@CreatedDate", DateTime.Now));
         

            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    comm.Connection = connx;

                    if (!mode[18])
                    {

                        int staffCount = 0;
                        //Check whether staff selected
                        foreach (bool value in Users.Values)
                        {
                            if (value)
                                staffCount++;
                        }
                        if (staffCount == 0)
                        {
                            XtraMessageBox.Show("Select a Staff to apply this form access to", "Select a Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        //Delete selected staff Log access Records
                        for (int i = 0; i < Users.Count; i++)
                        {
                            if (Users[i])
                            {
                                comm.Parameters["@StaffID"].Value = dataSet.Tables[userTable].Rows[i].ItemArray[0];
                                comm.CommandText = "Delete from stblUserPriviledge where upSfID=@StaffID";
                                comm.ExecuteNonQuery();
                            }

                        }


                        //Save staff User Priviledges;
                        for (int i = 0; i < Users.Count; i++)
                        {
                            if (Users[i])
                            {
                                for (int j = 0; j < dataSet.Tables[formTable].Rows.Count; j++)
                                {
                                    row = dataSet.Tables[formTable].Rows[j];
                                    if ((bool)row.ItemArray[3] || (bool)row.ItemArray[4] || (bool)row.ItemArray[5])
                                    {
                                        comm.CommandText = "Insert into stblUserPriviledge(upSfId,upFmID,upRead,upWrite,upEdit,upCreatorId,upCreatedDate) Values(@StaffID,@frmID,@Read,@Write,@Edit,@CreatorID,@CreatedDate)";
                                        comm.Parameters["@frmID"].Value = dataSet.Tables[formTable].Rows[j].ItemArray[0];
                                        comm.Parameters["@StaffID"].Value = dataSet.Tables[userTable].Rows[i].ItemArray[0];
                                        comm.Parameters["@Read"].Value = dataSet.Tables[formTable].Rows[j].ItemArray[3];
                                        comm.Parameters["@Write"].Value = dataSet.Tables[formTable].Rows[j].ItemArray[4];
                                        comm.Parameters["@Edit"].Value = dataSet.Tables[formTable].Rows[j].ItemArray[5];
                                        comm.ExecuteNonQuery();
                                    }
                                }

                            }

                        }

                        XtraMessageBox.Show(staffCount + " Records saved Succusfully", "Staff User Priviledges Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    else
                    {
                        //Delete selected staff Log access Records
                       
                                comm.Parameters["@StaffID"].Value = dataSet.Tables[userTable].Rows[currentRow].ItemArray[0];
                                comm.CommandText = "Delete from stblUserPriviledge where upSfID=@StaffID";
                                comm.ExecuteNonQuery();
                      
                        //Save staff User Priviledges;
                     
                                for (int j = 0; j < dataSet.Tables[formTable].Rows.Count; j++)
                                {
                                    row = dataSet.Tables[formTable].Rows[j];
                                    if ((bool)row.ItemArray[3] || (bool)row.ItemArray[4] || (bool)row.ItemArray[5])
                                    {
                                        comm.CommandText = "Insert into stblUserPriviledge(upSfId,upFmID,upRead,upWrite,upEdit,upCreatorId,upCreatedDate) Values(@StaffID,@frmID,@Read,@Write,@Edit,@CreatorID,@CreatedDate)";
                                        comm.Parameters["@frmID"].Value = dataSet.Tables[formTable].Rows[j].ItemArray[0];
                                        comm.Parameters["@StaffID"].Value = dataSet.Tables[userTable].Rows[currentRow].ItemArray[0];
                                        comm.Parameters["@Read"].Value = dataSet.Tables[formTable].Rows[j].ItemArray[3];
                                        comm.Parameters["@Write"].Value = dataSet.Tables[formTable].Rows[j].ItemArray[4];
                                        comm.Parameters["@Edit"].Value = dataSet.Tables[formTable].Rows[j].ItemArray[5];
                                        comm.ExecuteNonQuery();
                                    }
                                }

                     

                        XtraMessageBox.Show(dataSet.Tables[userTable].Rows[currentRow].ItemArray[1] + " Records updated Succusfully", "Staff User Priviledges Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                    }
                    RefreshUserPriviledge();
                }
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show("Something went wrong! See Administrator " + Environment.NewLine + ex.Message, "Contact Admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void LoadUserPriviledges(string formTable,string userTable,GridView userGV,BarCheckItem bciEdit, bool canEdit)
        {
            if (!canEdit)
            {
                XtraMessageBox.Show("You dont Have Edit Access, Contact Admin", "You cant edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bciEdit.Checked = false;
                return;
            }
            if (userGV.RowCount == 0)
            {
                XtraMessageBox.Show("There are no records To Edit", "No records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bciEdit.Checked = false;
                return;
            }
            int currentRow = userGV.GetFocusedDataSourceRowIndex();
         
           
            try
            {
                
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    comm = new SqlCommand();
                    comm.Connection = connx;
                    comm.Parameters.Add(new SqlParameter("@StaffID", dataSet.Tables[userTable].Rows[currentRow].ItemArray[0]));
                  
                    comm.CommandText = "Select upFmID,upRead,upWrite,upEdit from stblUserPriviledge where upSfID=@staffID";
                    reader = comm.ExecuteReader();
                    object[] row = null;
                    foreach (DataRow value in dataSet.Tables[formTable].Rows)
                    {
                        row = value.ItemArray;
                        row[3] = false;
                        row[4] = false;
                        row[5] = false;
                        value.ItemArray = row;
                    }

                    int rowID = 0;
                    while (reader.Read())
                    {
                      
                        rowID = Convert.ToInt32(reader[0]);
                        foreach(DataRow value  in dataSet.Tables[formTable].Rows)
                        {
                          
                            if ((int)value.ItemArray[0]==rowID)
                            {
                                row = value.ItemArray;
                                row[3] = Convert.ToBoolean(reader[1]);
                                row[4] = Convert.ToBoolean(reader[2]);
                                row[5] = Convert.ToBoolean(reader[3]);
                                value.ItemArray = row;
                                break;
                            }
                        }
                      
                    }
                   
                 }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("OOPs! cud not connect to server now Contact HR\r\n" + ex.Message, "Contact Admin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void RefreshUserPriviledge()
        {
            try
            {
                using (connx = new SqlConnection(connString))
                {
                    connx.Open();
                    comm = new SqlCommand();
                    comm.Connection = connx;
                  
                                //Load UserPriviledge
                 
                    comm.Parameters.Add(new SqlParameter("@UserID", userID));
                    comm.CommandText = "Select upFmID,upRead,upWrite,upEdit from stblUserPriviledge where upSfID=@UserID";
                    reader = comm.ExecuteReader();

                    while (reader.Read())
                    {
                       accessStatus[Convert.ToInt32(reader[0]) - 1, 0] = Convert.ToBoolean(reader[1]);
                       accessStatus[Convert.ToInt32(reader[0]) - 1, 1] = Convert.ToBoolean(reader[2]);
                       accessStatus[Convert.ToInt32(reader[0]) - 1, 2] = Convert.ToBoolean(reader[3]);
                    }
                }

             }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Contact Admin To Fix this", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }
    }
}
