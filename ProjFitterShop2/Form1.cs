using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using System.Threading;
using DevExpress.DashboardWin;


namespace ProjFitterShop2
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Setup setupForm = new Setup();
        Entry entryForm = new Entry();
        string customerID = string.Empty;
        string customerCar = string.Empty;



        public Form1()
        {
            InitializeComponent();
            WindowsFormsSettings.DefaultFont = new Font("Tahoma", 10);
            this.Text = Properties.Settings.Default.nameSetting;
            // SetGridFont(layoutControl1, new Font("Tohoma", 10));
           
            //gvCarManufacturer.ShowFindPanel();
            //gridViewCars.ShowFindPanel();
            Entry.CustomerPurchaseData = new Dictionary<int, Tuple<bool, int, double, double>>();
            // gvCustomerPurchase.ShowFindPanel();
            tcgEmployee.SelectedTabPageIndex = 1;
            navBarControl1.SelectedLink = navBarGpEntry.ItemLinks[2];


            // dashboardViewer1.Hide();
            ribbonControl1.ShowApplicationButtonContentControl();
            repositoryItemCEAddItem.EditValueChanged += RepositoryItemCEAddItem_EditValueChanged;
            repositoryItemSEQuantity.EditValueChanged += RepositoryItemSEQuantity_EditValueChanged;
        }

        private void RepositoryItemSEQuantity_EditValueChanged(object sender, EventArgs e)
        {
            SpinEdit spin = sender as SpinEdit;
            gvCustomerPurchase.SetRowCellValue(gvCustomerPurchase.GetFocusedDataSourceRowIndex(), gvCustomerPurchase.FocusedColumn, spin.EditValue);
            gvCustomerPurchase.UpdateTotalSummary(); 
        }

        private void RepositoryItemCEAddItem_EditValueChanged(object sender, EventArgs e)
        {
            CheckEdit cke = sender as CheckEdit;
            gvCustomerPurchase.SetRowCellValue(gvCustomerPurchase.GetFocusedDataSourceRowIndex(), gvCustomerPurchase.FocusedColumn, cke.EditValue);
            gvCustomerPurchase.UpdateTotalSummary();
        }

        private void navBarControl1_SelectedLinkChanged(object sender, DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventArgs e)
        {

            navigationFrame1.SelectedPage = (NavigationPage)navigationFrame1.Pages.FirstOrDefault(x => x.Tag as string == e.Link.Caption);
            bhiCurrentPage.Caption = e.Link.Caption + " Page";
        }
        void SetDateTime(DateEdit dateEdit) => dateEdit.EditValue = DateTime.Now;
        

        private void navigationFrame1_SelectedPageChanging(object sender, SelectedPageChangingEventArgs e)
        {
           switch(e.Page.Caption)
            {
                case "navigationPage1":
                    setupForm.LoadDGVRecords(e.Page.Caption, gcCars, new Label(), Setup.accessStatus[0,0], Setup.accessStatus[0, 2]);
                  
                    break;
                case "navigationPage2":
                    setupForm.LoadDGVRecords(e.Page.Caption, gcCarManufacturer, new Label(), Setup.accessStatus[1, 0], Setup.accessStatus[1, 2]);
                   
                    break;
                case "navigationPage3":
                    setupForm.LoadDGVRecords(e.Page.Caption, gcProducts, new Label(), Setup.accessStatus[2, 0], Setup.accessStatus[2, 2]);
                   
                    break;
                case "navigationPage4":
                    setupForm.LoadDGVRecords(e.Page.Caption, gcTittles, new Label(), Setup.accessStatus[3, 0], Setup.accessStatus[3, 2]);
                   
                    break;
                case "navigationPage5":
                    entryForm.LoadEntryRecords(e.Page.Caption, gcCustomers, new Label(), Setup.accessStatus[4, 0], Setup.accessStatus[4, 2]);
                  
                    break;
                case "navigationPage6":
                    setupForm.LoadDGVRecords(e.Page.Caption, gcServiceType, new Label(), Setup.accessStatus[5, 0], Setup.accessStatus[5, 2]);
                   
                    break;
                case "navigationPage7":
                    entryForm.LoadEntryRecords(e.Page.Caption, gcCarServicing, new Label(), Setup.accessStatus[6, 0], Setup.accessStatus[6, 2]);
                    entryForm.LoadProductAndServices(gcCustomerPurchase, new Label(), Setup.accessStatus[6, 0], Setup.accessStatus[6, 1], Setup.accessStatus[6, 2]);
                 
                    break;
                case "navigationPage8":
                    setupForm.LoadDGVRecords(e.Page.Caption, gcProductPrices, new Label(), Setup.accessStatus[7, 0], Setup.accessStatus[7, 2]);
                 
                    break;
                case "navigationPage9":
                    setupForm.LoadDGVRecords(e.Page.Caption, gcCompanyInfo, new Label(), Setup.accessStatus[8, 0], Setup.accessStatus[8, 2]);
                    break;
                case "navigationPage10":
                    entryForm.LoadEntryRecords(e.Page.Caption, gcEmployee, new Label(), Setup.accessStatus[9, 0], Setup.accessStatus[9, 2]);
                    break;
                case "navigationPage11":
                    setupForm.LoadDGVRecords(e.Page.Caption, gcGender, new Label(), Setup.accessStatus[10, 0], Setup.accessStatus[10, 2]);
                    break;
                case "navigationPage12":
                    setupForm.LoadDGVRecords(e.Page.Caption, gcMaritalStatus, new Label(), Setup.accessStatus[11, 0], Setup.accessStatus[11, 2]);
                    break;
                case "navigationPage13":
                    setupForm.LoadDGVRecords(e.Page.Caption, gcCountry, new Label(), Setup.accessStatus[12, 0], Setup.accessStatus[12, 2]);
                    break;
                case "navigationPage14":
                    setupForm.LoadDGVRecords(e.Page.Caption, gcRegion, new Label(), Setup.accessStatus[13, 0], Setup.accessStatus[13, 2]);
                    break;
                case "navigationPage15":
                    setupForm.LoadDGVRecords(e.Page.Caption, gcTown, new Label(), Setup.accessStatus[14, 0], Setup.accessStatus[14, 2]);
                    break;
                case "navigationPage16":
                    setupForm.LoadDGVRecords(e.Page.Caption, gcQualification, new Label(), Setup.accessStatus[15, 0], Setup.accessStatus[15, 2]);
                    break;
                case "navigationPage17":
                    setupForm.LoadDGVRecords(e.Page.Caption, gcEmployeeType, new Label(), Setup.accessStatus[16, 0], Setup.accessStatus[16, 2]);
                    break;
                case "navigationPage18":
                    setupForm.LoadDGVRecords(e.Page.Caption, gcJobType, new Label(), Setup.accessStatus[17, 0], Setup.accessStatus[17, 2]);
                    break;
                case "navigationPage19":
                    setupForm.LoadDGVRecords(e.Page.Caption, gcForms, new Label(), Setup.accessStatus[18, 0], Setup.accessStatus[18, 2]);
                    entryForm.LoadUsers(gcUsers, new Label(), Setup.accessStatus[18, 0], Setup.accessStatus[18,1],Setup.accessStatus[18,2]);
                    break;
                case "navigationPage20":
                    Cursor.Current = Cursors.AppStarting;
                    entryForm.ShowDashBoard(dashboardViewer1, Setup.accessStatus[18, 0]);
                    Cursor.Current = Cursors.Default;
                    break;
                case "navigationPage21":
                    setupForm.LoadDGVRecords(e.Page.Caption, gcCustomerCar, new Label(), Setup.accessStatus[19, 0], Setup.accessStatus[19, 2]);
                    break;
            }
        }
        void SetGridFont(LayoutControl view, Font font)
        {
            //foreach (LayoutControlItem ap in view.Controls)
            //    ap.Font = font;
        }

        private void HomePageButtonClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         
            if (lcgCarDetail.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
                        lcgCarDetail.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    else
                        lcgCarDetail.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                 
          
        }

        private void gridViewCars_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            MessageBox.Show(e.ControllerRow.ToString());
        }

        private void memoEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            bciEdit.Checked = false;
            bciEdit_CheckedChanged(sender, e);
           
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (navigationFrame1.SelectedPage.Caption)
            {
                case "navigationPage1":
                    setupForm.SaveCarRecords(teCarFName, teCarSName, leCarManufacturer,deCarYear, peCarImage, meCarRemarks, deCarDateCreated, ckeCarStatus, gcCars.Name,Setup.accessStatus[0,1] ,bciEdit,gvCars.GetFocusedDataSourceRowIndex());
                    leDCSCar.Properties.DataSource = null;
                    break;
                case "navigationPage2":
                    setupForm.SaveCarManufacturerRecords(teCMFname, teCMSName, meCMRemarks, deCMDateCreated, ckeCMStatus, gcCarManufacturer.Name, Setup.accessStatus[1, 1], bciEdit, gvCarManufacturer.GetFocusedDataSourceRowIndex());
                    leCarManufacturer.Properties.DataSource = null;
                    break;
                case "navigationPage3":
                    setupForm.SaveProductRecords(tePdFName, tePdSName, tePdUnitPrice,sePdTaxRate,sePdVatRate,mePdRemarks, dePdDateCreated, ckePdStatus, gcProducts.Name, Setup.accessStatus[2, 1], bciEdit, gvProducts.GetFocusedDataSourceRowIndex());
                    lePPProduct.Properties.DataSource = null;
                    gcProducts.DataSource = null;
                    break;
                case "navigationPage4":
                    setupForm.SaveTitleRecords(teTFName, teTSName, meTRemarks, deTDateCreated, ckeTStatus, gcTittles.Name, Setup.accessStatus[3, 1], bciEdit, gvTitles.GetFocusedDataSourceRowIndex());
                    leCDTitle.Properties.DataSource = null;
                    break;
                case "navigationPage5":
                    entryForm.SaveCustomerRecord(teCDFName, teCDSName, teCDID, leCDTitle, teCDAddress, teCDPhone, meCDRemarks, deCDDateCreated, ckeCDStatus, gcCustomers.Name, Setup.accessStatus[4, 1], bciEdit, gvCustomers.GetFocusedDataSourceRowIndex());
                    leDCSCustomer.Properties.DataSource = null;
                    break;
                case "navigationPage6":
                    setupForm.SaveServiceTypeRecords(teSTFName, teSTSName, meSTRemarks, deSTDateCreated, ckeSTStatus, gcServiceType.Name, Setup.accessStatus[5, 1], bciEdit, gvServiceType.GetFocusedDataSourceRowIndex());
                    leDCSServiceType.Properties.DataSource = null;
                    break;
                case "navigationPage7":
                      
                   // gvCustomerPurchase.CloseEditor();
                    //gvCustomerPurchase.SelectCell(gvCustomerPurchase.GetFocusedDataSourceRowIndex(), gridColumn64);
                    entryForm.SaveDailySalesRecord(leDCSCustomer, customerID,customerCar, leDCSCar, leDCSServiceType,teDCSAmount,teDCSTotalAmount,deDCSDateCreated, meDCSRemarks, gcCarServicing.Name, gcCustomerPurchase.Name,Setup.accessStatus[6, 1], bciEdit, gvCarServicing.GetFocusedDataSourceRowIndex(),gvCustomerPurchase,dashboardViewer1);
                    break;
                case "navigationPage8":
                    setupForm.SaveProductPricesRecords(lePPProduct, tePPUnitPrice, sePPTaxRate, sePPVatRate, mePPRemarks, dePPDateCreated, ckePPStatus, gcProductPrices.Name, Setup.accessStatus[7, 1], bciEdit, gvProductPrices.GetFocusedDataSourceRowIndex());
                  
                    break;
                case "navigationPage9":
                    setupForm.SaveCompanyInfoRecords(teCIFName, teCISName, teCISlogan, teCIAddress, teCIPhone, peCILogo, meCIRemarks, deCIDateCreated, ckeCIStatus, gcCompanyInfo.Name, Setup.accessStatus[8, 1], bciEdit, gvCompanyInfo.GetFocusedDataSourceRowIndex(),gvCompanyInfo,this);
                    break;
                case "navigationPage10":
                    entryForm.SaveEmployeeRecord(teSfFName, teSfLName, teSFOName, deSfDOB, peSfImage, leSfGender, leSfTitle, leSfMStatus, leSfCountry, leSfRegion, leSfTown, teSfPhone, teSfAddress, teSfEmail, teSfStaffID,
                        leSfQualification, leSfEmployeeType, leSfJobType, deSfStartDate, deSfEndDate, meSfRemarks, deSfDateCreated, ckeSfStatus, gcEmployee.Name, Setup.accessStatus[9, 1], bciEdit, gvEmployee.GetFocusedDataSourceRowIndex(),gcUsers);

                    break;
                case "navigationPage11":
                    setupForm.SaveGenderRecords(teGFName, teGSName, meGRemarks, deGDateCreated, ckeGStatus, gcGender.Name, Setup.accessStatus[10, 1], bciEdit, gvGender.GetFocusedDataSourceRowIndex());
                    break;
                case "navigationPage12":
                    setupForm.SaveMaritalStatusRecords(teMSFName, teMSSName, meMSRemarks, deMSDateCreated, ckeMSStatus, gcMaritalStatus.Name, Setup.accessStatus[11, 1], bciEdit, gvMaritalStatus.GetFocusedDataSourceRowIndex());
                    break;
                case "navigationPage13":
                    setupForm.SaveCountryRecords(teConFName, teConSName, meConRemarks, deConDateCreated, ckeConStatus, gcCountry.Name, Setup.accessStatus[12, 1], bciEdit, gvCountry.GetFocusedDataSourceRowIndex());
                    leTwnCountry.Properties.DataSource = null;
                    leRegCountry.Properties.DataSource = null;
                    break;
                case "navigationPage14":
                    setupForm.SaveRegionRecords(teRegFName, teRegSName, leRegCountry, meRegRemarks, deRegDateCreated, ckeRegStatus, gcRegion.Name, Setup.accessStatus[13, 1], bciEdit, gvRegion.GetFocusedDataSourceRowIndex());
                    break;
                case "navigationPage15":
                    setupForm.SaveTownRecords(teTwnFName, teTwnSName,leTwnCountry,leTwnRegion, meTwnRemarks, deTwnDateCreated, ckeTwnStatus, gcTown.Name, Setup.accessStatus[14, 1], bciEdit, gvTown.GetFocusedDataSourceRowIndex());
                    break;
                case "navigationPage16":
                    setupForm.SaveQualificationRecords(teQFName, teQSName, meQRemarks, deQDateCreated, ckeQStatus, gcQualification.Name, Setup.accessStatus[15, 1], bciEdit, gvQualification.GetFocusedDataSourceRowIndex());
                    break;
                case "navigationPage17":
                    setupForm.SaveEmployeeTypeRecords(teETFName, teETSName, meETRemarks, deETDateCreated, ckeETStatus, gcEmployeeType.Name, Setup.accessStatus[16, 1], bciEdit, gvEmployeeType.GetFocusedDataSourceRowIndex());
                    break;
                case "navigationPage18":
                    setupForm.SaveJobTypeRecords(teJTFName, teJTSName, meJTRemarks, deJTDateCreated, ckeJTStatus, gcJobType.Name, Setup.accessStatus[17, 1], bciEdit, gvJobType.GetFocusedDataSourceRowIndex());
                    break;
                case "navigationPage19":
                    gcForms.Focus();
                    setupForm.SaveFormAccess(gcForms.Name, gcUsers.Name, Setup.accessStatus[18, 1], bciEdit,gvUsers.GetFocusedDataSourceRowIndex());
              
                    break;
                case "navigationPage21":
                    entryForm.SaveCustomerCarRecord(leCCCustomer, leCCCar, teCCVIN, teCCRegNum, meCCRemarks, deCCDateCreated, ckeCCStatus, gcCustomerCar.Name, Setup.accessStatus[19, 1], bciEdit, gvCustomerCar.GetFocusedDataSourceRowIndex());
                    break;
            }

        }

        private void bciEdit_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (navigationFrame1.SelectedPage.Caption)
            {
                case "navigationPage1":
                   
                    if (bciEdit.Checked)
                    {
                        Setup.mode[0] = true;
                        setupForm.EditValue(lcCars, gcCars,gvCars,bciEdit, Setup.accessStatus[0, 2]);
                       
                       // gcCars.UseEmbeddedNavigator = true;

                    }
                    else
                    {
                        setupForm.ClearValue(lcCars, lcCars.Name);
                        Setup.mode[0] = false;
                        gcCars.UseEmbeddedNavigator = false;
                    }
                    break;
                case "navigationPage2":
                   
                    if (bciEdit.Checked)
                    {
                        Setup.mode[1] = true;
                        setupForm.EditValue(lcCarManufacturer, gcCarManufacturer, gvCarManufacturer,bciEdit, Setup.accessStatus[1, 2]);
                        
                       // gcCarManufacturer.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                        setupForm.ClearValue(lcCarManufacturer, lcCarManufacturer.Name);
                        Setup.mode[1] = false;
                        gcCarManufacturer.UseEmbeddedNavigator = false;
                    }
                    break;
                case "navigationPage3":
                    if (bciEdit.Checked)
                    {
                        Setup.mode[2] = true;
                        setupForm.EditValue(lcProduct,gcProducts,gvProducts, bciEdit, Setup.accessStatus[2, 2]);
                       
                       // gcProducts.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                        setupForm.ClearValue(lcProduct,lcProduct.Name);
                        Setup.mode[2] = false;
                        gcProducts.UseEmbeddedNavigator = false;
                    }
                    break;
                case "navigationPage4":
                    if (bciEdit.Checked)
                    {
                        Setup.mode[3] = true;
                        setupForm.EditValue(lcTitle, gcTittles, gvTitles, bciEdit, Setup.accessStatus[3, 2]);
                       
                       // gcTittles.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                        setupForm.ClearValue(lcTitle, lcTitle.Name);
                        Setup.mode[3] = false;
                        gcTittles.UseEmbeddedNavigator = false;
                    }
                    break;
                case "navigationPage5":
                    if (bciEdit.Checked)
                    {
                        Setup.mode[4] = true;
                        setupForm.EditValue(lcCustomers, gcCustomers, gvCustomers, bciEdit, Setup.accessStatus[4, 2]);
                        
                       // gcCustomers.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                        setupForm.ClearValue(lcCustomers, lcCustomers.Name);
                        Setup.mode[4] = false;
                        gcCustomers.UseEmbeddedNavigator = false;
                    }
                    break;
                case "navigationPage6":
                    if (bciEdit.Checked)
                    {
                        Setup.mode[5] = true;
                        setupForm.EditValue(lcServiceType, gcServiceType, gvServiceType, bciEdit, Setup.accessStatus[5, 2]);
                       
                       // gcServiceType.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                        setupForm.ClearValue(lcServiceType, lcServiceType.Name);
                        Setup.mode[5] = false;
                        gcServiceType.UseEmbeddedNavigator = false;
                    }
                    break;
                case "navigationPage7":
                    if (bciEdit.Checked)
                    {
                       
                        lciTotalAmount.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        Setup.mode[6] = true;
        
                        setupForm.EditValue(lcCarServicing, gcCarServicing, gvCarServicing, bciEdit, Setup.accessStatus[6, 2]);
                        entryForm.LoadCustomerPurchase(gcCarServicing.Name, gvCarServicing, gcCustomerPurchase, gvCustomerPurchase,Setup.accessStatus[6, 2]);
                        

                        //gcCarServicing.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                       
                        lciTotalAmount.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        setupForm.ClearValue(lcCarServicing, lcCarServicing.Name);
                        gcCustomerPurchase.DataSource = null;
                        Entry.CustomerPurchaseData.Clear();
                        entryForm.LoadProductAndServices(gcCustomerPurchase, new Label(), Setup.accessStatus[6, 0], Setup.accessStatus[6, 1], Setup.accessStatus[6, 2]);
                        Setup.mode[6] = false;
                        gcCarServicing.UseEmbeddedNavigator = false;
                      
                    }
                    break;
                case "navigationPage8":
                    if (bciEdit.Checked)
                    {
                        Setup.mode[7] = true;
                        setupForm.EditValue(lcProductPrice, gcProductPrices, gvProductPrices, bciEdit, Setup.accessStatus[7, 2]);
                       
                        //gcProductPrices.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                        setupForm.ClearValue(lcProductPrice, lcProductPrice.Name);
                        Setup.mode[7] = false;
                        gcProductPrices.UseEmbeddedNavigator = false;
                    }
                    break;
                case "navigationPage9":
                    if (bciEdit.Checked)
                    {
                        Setup.mode[8] = true;
                        setupForm.EditValue(lcCompanyInfo, gcCompanyInfo, gvCompanyInfo, bciEdit, Setup.accessStatus[8, 2]);
                       
                        //gcCompanyInfo.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                        setupForm.ClearValue(lcCompanyInfo, lcCompanyInfo.Name);
                        Setup.mode[8] = false;
                        gcCompanyInfo.UseEmbeddedNavigator = false;
                    }
                    break;
                case "navigationPage10":
                    if (bciEdit.Checked)
                    {
                        Setup.mode[9] = true;
                        setupForm.EditValue(lcEmployee, gcEmployee,gvEmployee, bciEdit, Setup.accessStatus[9, 2]);
                       
                        //gcCompanyInfo.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                        setupForm.ClearValue(lcEmployee, lcEmployee.Name);
                        Setup.mode[9] = false;
                        gcEmployee.UseEmbeddedNavigator = false;
                    }
                    break;
                case "navigationPage11":
                    if (bciEdit.Checked)
                    {
                        Setup.mode[10] = true;
                        setupForm.EditValue(lcGender, gcGender, gvGender, bciEdit, Setup.accessStatus[10, 2]);
                       
                        //gcGender.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                        setupForm.ClearValue(lcGender, lcGender.Name);
                        Setup.mode[10] = false;
                        gcGender.UseEmbeddedNavigator = false;
                    }
                    break;
                case "navigationPage12":
                    if (bciEdit.Checked)
                    {
                        Setup.mode[11] = true;
                        setupForm.EditValue(lcMaritalStatus, gcMaritalStatus, gvMaritalStatus, bciEdit, Setup.accessStatus[11, 2]);
                      
                       // gcMaritalStatus.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                        setupForm.ClearValue(lcMaritalStatus, lcMaritalStatus.Name);
                        Setup.mode[11] = false;
                        gcMaritalStatus.UseEmbeddedNavigator = false;
                    }
                    break;
                case "navigationPage13":
                    if (bciEdit.Checked)
                    {
                        Setup.mode[12] = true;
                        setupForm.EditValue(lcCountry,gcCountry, gvCountry, bciEdit, Setup.accessStatus[12, 2]);
                       
                       // gcCountry.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                        setupForm.ClearValue(lcCountry, lcCountry.Name);
                        Setup.mode[12] = false;
                        gcCountry.UseEmbeddedNavigator = false;
                    }
                    break;
                case "navigationPage14":
                    if (bciEdit.Checked)
                    {
                        Setup.mode[13] = true;
                        setupForm.EditValue(lcRegion, gcRegion, gvRegion, bciEdit, Setup.accessStatus[13, 2]);
                        
                       // gcRegion.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                        setupForm.ClearValue(lcRegion, lcRegion.Name);
                        Setup.mode[13] = false;
                        gcRegion.UseEmbeddedNavigator = false;
                    }
                    break;
                case "navigationPage15":
                    if (bciEdit.Checked)
                    {
                        Setup.mode[14] = true;
                        setupForm.EditValue(lcTown, gcTown, gvTown, bciEdit, Setup.accessStatus[14, 2]);
                       
                        //gcTown.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                        setupForm.ClearValue(lcTown, lcTown.Name);
                        Setup.mode[14] = false;
                        gcTown.UseEmbeddedNavigator = false;
                    }
                    break;
                case "navigationPage16":
                    if (bciEdit.Checked)
                    {
                        Setup.mode[15] = true;
                        setupForm.EditValue(lcQualification, gcQualification, gvQualification, bciEdit, Setup.accessStatus[15, 2]);
                       
                        //gcTown.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                        setupForm.ClearValue(lcQualification, lcQualification.Name);
                        Setup.mode[15] = false;
                        gcQualification.UseEmbeddedNavigator = false;
                    }
                    break;
                case "navigationPage17":
                    if (bciEdit.Checked)
                    {
                        Setup.mode[16] = true;
                        setupForm.EditValue(lcEmployeeType, gcEmployeeType, gvEmployeeType, bciEdit, Setup.accessStatus[16, 2]);
                       
                        //gcTown.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                        setupForm.ClearValue(lcEmployeeType, lcEmployeeType.Name);
                        Setup.mode[16] = false;
                        gcEmployeeType.UseEmbeddedNavigator = false;
                    }
                    break;
                case "navigationPage18":
                    if (bciEdit.Checked)
                    {
                        Setup.mode[17] = true;
                        setupForm.EditValue(lcJobType, gcJobType, gvJobType, bciEdit, Setup.accessStatus[17, 2]);
                       
                        //gcTown.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                        setupForm.ClearValue(lcJobType, lcJobType.Name);
                        Setup.mode[17] = false;
                        gcJobType.UseEmbeddedNavigator = false;
                    }
                    break;
                case "navigationPage19":
                    if (bciEdit.Checked)
                    {
                        Setup.mode[18] = true;
                       
                        setupForm.LoadUserPriviledges(gcForms.Name, gcUsers.Name, gvUsers, bciEdit, Setup.accessStatus[18, 2]);
                        
                        
                    }
                    else
                    {
                        ckeFAReadAll.Checked = false;
                        ckeFAWriteAll.Checked = false;
                        ckeFAEditAll.Checked = false;
                        ckeFAAddAll.Checked = false;
                        ckeFAReadAll_CheckedChanged(sender, e);
                        ckeFAWriteAll_CheckedChanged(sender, e);
                        ckeFAEditAll_CheckedChanged(sender, e);
                        ckeFAAddAll_CheckedChanged(sender, e);
                        //setupForm.ClearFormSelection(ckeFAReadAll,ckeFAWriteAll,ckeFAEditAll);
                        Setup.mode[18] = false;
                     
                    }
                    break;
                case "navigationPage21":
                    if (bciEdit.Checked)
                    {
                        Setup.mode[19] = true;
                        setupForm.EditValue(lcCustomerCar, gcCustomerCar, gvCustomerCar, bciEdit, Setup.accessStatus[19, 2]);

                        //gcTown.UseEmbeddedNavigator = true;
                    }
                    else
                    {
                        setupForm.ClearValue(lcCustomerCar, lcCustomerCar.Name);
                        Setup.mode[19] = false;
                        gcCustomerCar.UseEmbeddedNavigator = false;
                    }
                    break;
            }
        }

       

        private void gvCustomerPurchase_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;
            
            int quantity=0;
            double total = 0D;
            double discount = 0D;
            bool add = false;
            if(e.IsGetData)
            {
                if (!Entry.CustomerPurchaseData.ContainsKey(rowIndex))
                   Entry. CustomerPurchaseData.Add(rowIndex, Tuple.Create(false,1, 0D,0D));
                if(e.Column.AbsoluteIndex==1)
                {
                    e.Value =Entry.CustomerPurchaseData[rowIndex].Item1;
                   
                    
                }
                else if(e.Column.AbsoluteIndex==2)
                {
                    e.Value =Entry. CustomerPurchaseData[rowIndex].Item2;
                }
                else if(e.Column.AbsoluteIndex==7)
                {
                    e.Value = Entry.CustomerPurchaseData[rowIndex].Item3;
                   
                }

                
            }
            else
            {
                if (e.Column.AbsoluteIndex == 1)
                {
                    quantity =Entry. CustomerPurchaseData[rowIndex].Item2;
                    discount= Entry.CustomerPurchaseData[rowIndex].Item3;
                    total =Entry. CustomerPurchaseData[rowIndex].Item4;
                    Entry.CustomerPurchaseData[rowIndex] = Tuple.Create(Convert.ToBoolean(e.Value),quantity,discount,total);
                  
                }
                else if (e.Column.AbsoluteIndex == 2)
                {
                    add =Entry.CustomerPurchaseData[rowIndex].Item1;
                    discount = Entry.CustomerPurchaseData[rowIndex].Item3;
                    total =Entry.CustomerPurchaseData[rowIndex].Item4;
                   Entry.CustomerPurchaseData[rowIndex] = Tuple.Create(add,Convert.ToInt32(e.Value),discount,total);
                }
                else if(e.Column.AbsoluteIndex==7)
                {
                    add = Entry.CustomerPurchaseData[rowIndex].Item1;
                    quantity = Entry.CustomerPurchaseData[rowIndex].Item2;
                    total = Entry.CustomerPurchaseData[rowIndex].Item4;
                    Entry.CustomerPurchaseData[rowIndex] = Tuple.Create(add,quantity, Convert.ToDouble(e.Value),total);
                }
                else
                {
                    add =Entry.CustomerPurchaseData[rowIndex].Item1;
                    quantity =Entry.CustomerPurchaseData[rowIndex].Item2;
                    discount = Entry.CustomerPurchaseData[rowIndex].Item3;
                    Entry.CustomerPurchaseData[rowIndex] = Tuple.Create(add,quantity,discount, Convert.ToDouble(e.Value));
                }
            }
        }

        
        private void navigationFrame1_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            switch(e.Page.Caption)
            {
                case "navigationPage1":
                    Setup.PopulateIndependantLookUPs(leCarManufacturer);
                  
                    bciEdit.Checked = Setup.mode[0];
                    bciDetailView.Checked = Setup.detailView[0];
                    bciSelectAll.Checked = Setup.selectAll[0];
                    SetDateTime(deCarDateCreated);
                    break;
                case "navigationPage2":
                    bciEdit.Checked = Setup.mode[1];
                    bciDetailView.Checked = Setup.detailView[1];
                    bciSelectAll.Checked = Setup.selectAll[1];
                    SetDateTime(deCMDateCreated);
                    break;
                case "navigationPage3":
                    bciEdit.Checked = Setup.mode[2];
                    bciDetailView.Checked = Setup.detailView[2];
                    bciSelectAll.Checked = Setup.selectAll[2];
                    SetDateTime(dePdDateCreated);
                    break;
                case "navigationPage4":
                    bciEdit.Checked = Setup.mode[3];
                    bciDetailView.Checked = Setup.detailView[3];
                    bciSelectAll.Checked = Setup.selectAll[3];
                    SetDateTime(deTDateCreated);
                    break;
                case "navigationPage5":
                    Setup.PopulateIndependantLookUPs(leCDTitle);
                  
                    bciEdit.Checked = Setup.mode[4];
                    bciDetailView.Checked = Setup.detailView[4];
                    bciSelectAll.Checked = Setup.selectAll[4];
                    SetDateTime(deCDDateCreated);
                    break;
                case "navigationPage6":
                    bciEdit.Checked = Setup.mode[5];
                    bciDetailView.Checked = Setup.detailView[5];
                    bciSelectAll.Checked = Setup.selectAll[5];
                    SetDateTime(deSTDateCreated);
                    break;
                case "navigationPage7":
                    Setup.PopulateIndependantLookUPs(leDCSCustomer);
                   // Setup.PopulateIndependantLookUPs(leDCSCar);
                    Setup.PopulateIndependantLookUPs(leDCSServiceType);
                  
                    bciEdit.Checked = Setup.mode[6];
                    bciDetailView.Checked = Setup.detailView[6];
                    bciSelectAll.Checked = Setup.selectAll[6];
                    SetDateTime(deDCSDateCreated);
                    break;
                case "navigationPage8":
                    Setup.PopulateIndependantLookUPs(lePPProduct);
                 
                    bciEdit.Checked = Setup.mode[7];
                    bciDetailView.Checked = Setup.detailView[7];
                    bciSelectAll.Checked = Setup.selectAll[7];
                    SetDateTime(dePPDateCreated);
                    break;
                case "navigationPage9":
                    bciEdit.Checked = Setup.mode[8];
                    bciDetailView.Checked = Setup.detailView[8];
                    bciSelectAll.Checked = Setup.selectAll[8];
                    SetDateTime(deCIDateCreated);
                    break;
                case "navigationPage10":
                    Setup.PopulateIndependantLookUPs(leSfGender);
                    Setup.PopulateIndependantLookUPs(leSfTitle);
                    Setup.PopulateIndependantLookUPs(leSfMStatus);
                    Setup.PopulateIndependantLookUPs(leSfCountry);
                    Setup.PopulateIndependantLookUPs(leSfQualification);
                    Setup.PopulateIndependantLookUPs(leSfEmployeeType);
                    Setup.PopulateIndependantLookUPs(leSfJobType);
                   
                  
                    bciEdit.Checked = Setup.mode[9];
                    bciDetailView.Checked = Setup.detailView[9];
                    bciSelectAll.Checked = Setup.selectAll[9];
                    SetDateTime(deSfDateCreated);
                    break;
                case "navigationPage11":
                    bciEdit.Checked = Setup.mode[10];
                    bciDetailView.Checked = Setup.detailView[10];
                    bciSelectAll.Checked = Setup.selectAll[10];
                    SetDateTime(deGDateCreated);
                    break;
                case "navigationPage12":
                    bciEdit.Checked = Setup.mode[11];
                    bciDetailView.Checked = Setup.detailView[11];
                    bciSelectAll.Checked = Setup.selectAll[11];
                    SetDateTime(deMSDateCreated);
                    break;
                case "navigationPage13":
                    bciEdit.Checked = Setup.mode[12];
                    bciDetailView.Checked = Setup.detailView[12];
                    bciSelectAll.Checked = Setup.selectAll[12];
                    SetDateTime(deConDateCreated);
                    break;
                case "navigationPage14":
                    Setup.PopulateIndependantLookUPs(leRegCountry);
               
                    bciEdit.Checked = Setup.mode[13];
                    bciDetailView.Checked = Setup.detailView[13];
                    bciSelectAll.Checked = Setup.selectAll[13];
                    SetDateTime(deRegDateCreated);
                    break;
                case "navigationPage15":
                    Setup.PopulateIndependantLookUPs(leTwnCountry);
                
                    bciEdit.Checked = Setup.mode[14];
                    bciDetailView.Checked = Setup.detailView[14];
                    bciSelectAll.Checked = Setup.selectAll[14];
                    SetDateTime(deTwnDateCreated);
                    break;
                case "navigationPage16":
                    bciEdit.Checked = Setup.mode[15];
                    bciDetailView.Checked = Setup.detailView[15];
                    bciSelectAll.Checked = Setup.selectAll[15];
                    SetDateTime(deQDateCreated);
                    break;
                case "navigationPage17":
                    bciEdit.Checked = Setup.mode[16];
                    bciDetailView.Checked = Setup.detailView[16];
                    bciSelectAll.Checked = Setup.selectAll[16];
                    SetDateTime(deETDateCreated);
                    break;
                case "navigationPage18":
                    bciEdit.Checked = Setup.mode[17];
                    bciDetailView.Checked = Setup.detailView[17];
                    bciSelectAll.Checked = Setup.selectAll[17];
                    SetDateTime(deJTDateCreated);
                    break;
                case "navigationPage19":
                    bciEdit.Checked = Setup.mode[18];
                    bciDetailView.Checked = Setup.detailView[18];
                    bciSelectAll.Checked = Setup.selectAll[18];
                    break;
                case "navigationPage20":
                    bciSelectAll.Checked = false;
                    break;
                case "navigationPage21":
                    Setup.PopulateCustomerCarLookUps(leCCCar);
                    Setup.PopulateCustomerCarLookUps(leCCCustomer);
                    bciEdit.Checked = Setup.mode[19];
                    bciDetailView.Checked = Setup.detailView[19];
                    bciSelectAll.Checked = Setup.selectAll[19];
                    break;

            }
        }

        private void gcCarManufacturer_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            switch(navigationFrame1.SelectedPage.Caption)
            {
                case "navigationPage1":
                    if(Setup.mode[0])
                        setupForm.EditValue(lcCars, gcCars,gvCars,bciEdit, Setup.accessStatus[0, 2]);
                    break;
                case "navigationPage2":
                    if (Setup.mode[1])
                        setupForm.EditValue(lcCarManufacturer,gcCarManufacturer, gvCarManufacturer,bciEdit, Setup.accessStatus[1, 2]);
                    break;
                case "navigationPage3":
                    if (Setup.mode[2])
                        setupForm.EditValue(lcProduct,gcProducts,gvProducts, bciEdit, Setup.accessStatus[2, 2]);
                    break;
                case "navigationPage4":
                    if (Setup.mode[3])
                        setupForm.EditValue(lcTitle, gcTittles, gvTitles, bciEdit, Setup.accessStatus[3, 2]);
                    break;
                case "navigationPage5":
                    if (Setup.mode[4])
                        setupForm.EditValue(lcCustomers, gcCustomers, gvCustomers, bciEdit, Setup.accessStatus[4, 2]);
                    break;
                case "navigationPage6":
                    if (Setup.mode[5])
                        setupForm.EditValue(lcServiceType, gcServiceType, gvServiceType, bciEdit, Setup.accessStatus[5, 2]);
                    break;
                case "navigationPage7":
                    if (Setup.mode[6])
                    {
                        setupForm.EditValue(lcCarServicing, gcCarServicing, gvCarServicing, bciEdit, Setup.accessStatus[6, 2]);
                        entryForm.LoadCustomerPurchase(gcCarServicing.Name, gvCarServicing, gcCustomerPurchase, gvCustomerPurchase,Setup.accessStatus[6, 2]);
                        
                    }
                    break;
                case "navigationPage8":
                    if (Setup.mode[7])
                        setupForm.EditValue(lcProductPrice, gcProductPrices, gvProductPrices, bciEdit, Setup.accessStatus[7, 2]);
                    break;
                case "navigationPage9":
                    if (Setup.mode[8])
                        setupForm.EditValue(lcCompanyInfo, gcCompanyInfo, gvCompanyInfo, bciEdit, Setup.accessStatus[8, 2]);
                    break;
                case "navigationPage10":
                    if (Setup.mode[9])
                        setupForm.EditValue(lcEmployee, gcEmployee, gvEmployee, bciEdit, Setup.accessStatus[9, 2]);
                    break;
                case "navigationPage11":
                    if (Setup.mode[10])
                        setupForm.EditValue(lcGender, gcGender, gvGender, bciEdit, Setup.accessStatus[10, 2]);
                    break;
                case "navigationPage12":
                    if (Setup.mode[11])
                        setupForm.EditValue(lcMaritalStatus, gcMaritalStatus, gvMaritalStatus, bciEdit, Setup.accessStatus[11, 2]);
                    break;
                case "navigationPage13":
                    if (Setup.mode[12])
                        setupForm.EditValue(lcCountry,gcCountry, gvCountry, bciEdit, Setup.accessStatus[12, 2]);
                    break;
                case "navigationPage14":
                    if (Setup.mode[13])
                        setupForm.EditValue(lcRegion, gcRegion,gvRegion, bciEdit, Setup.accessStatus[13, 2]);
                    break;
                case "navigationPage15":
                    if (Setup.mode[14])
                        setupForm.EditValue(lcTown, gcTown, gvTown, bciEdit, Setup.accessStatus[14, 2]);
                    break;
                case "navigationPage16":
                    if (Setup.mode[15])
                        setupForm.EditValue(lcQualification, gcQualification, gvQualification, bciEdit, Setup.accessStatus[15, 2]);
                    break;
                case "navigationPage17":
                    if (Setup.mode[16])
                        setupForm.EditValue(lcEmployeeType, gcEmployeeType, gvEmployeeType, bciEdit, Setup.accessStatus[16, 2]);
                    break;
                   
                case "navigationPage18":
                    if (Setup.mode[17])
                        setupForm.EditValue(lcJobType, gcJobType, gvJobType, bciEdit, Setup.accessStatus[17, 2]);
                    break;
                case "navigationPage19":
                    if (Setup.mode[18])
                    {
                    
                        setupForm.LoadUserPriviledges(gcForms.Name, gcUsers.Name, gvUsers, bciEdit, Setup.accessStatus[18, 2]);
                    }
                    break;
                case "navigationPage21":
                    if (Setup.mode[19])
                        setupForm.EditValue(lcCustomerCar, gcCustomerCar, gvCustomerCar, bciEdit, Setup.accessStatus[19, 2]);
                    break;
            }
        }

      

        private void leDCSCustomer_EditValueChanged(object sender, EventArgs e)
        {
            leDCSCar.Properties.DataSource = null;
            if(leDCSCustomer.EditValue!=null)
            {
                Setup.PopulateDependantAllColumnLookUPs(leDCSCustomer, leDCSCar);
                DataRowView row = leDCSCustomer.Properties.GetDataSourceRowByKeyValue(leDCSCustomer.EditValue) as DataRowView;
                customerID = (string)row[2];
            }
          
        }


        private void deCMDateCreated_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bbiPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (navigationFrame1.SelectedPage.Caption)
            {
                case "navigationPage1":
                  
                    break;
                case "navigationPage2":
                   
                    break;
                case "navigationPage3":
                 
                    break;
                case "navigationPage4":
                 
                    break;
                case "navigationPage5":
                  
                    break;
                case "navigationPage6":
                 
                    break;
                case "navigationPage7":
                  
                    break;
                case "navigationPage8":
                 
                    break;
                case "navigationPage9":

                    break;
            }
            }

        void ShowPrintDialog(GridControl gridControl)
        {
            Cursor.Current = Cursors.AppStarting;
            if (gridControl.IsPrintingAvailable)
                gridControl.ShowPrintPreview();
            Cursor.Current = Cursors.Default;
        }
        private void bbiShowPrintDialog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (navigationFrame1.SelectedPage.Caption)
            {
                case "navigationPage1":
                    ShowPrintDialog(gcCars);
                    break;
                case "navigationPage2":
                    ShowPrintDialog(gcCarManufacturer);
                    break;
                case "navigationPage3":
                    ShowPrintDialog(gcProducts);
                    break;
                case "navigationPage4":
                    ShowPrintDialog(gcTittles);
                    break;
                case "navigationPage5":
                    ShowPrintDialog(gcCustomers);
                    break;
                case "navigationPage6":
                    ShowPrintDialog(gcServiceType);
                    break;
                case "navigationPage7":
                    ShowPrintDialog(gcCarServicing);
                    break;
                case "navigationPage8":
                    ShowPrintDialog(gcProductPrices);
                    break;
                case "navigationPage9":
                    ShowPrintDialog(gcCompanyInfo);
                    break;
                case "navigationPage10":
                    ShowPrintDialog(gcEmployee);
                    break;
                case "navigationPage11":
                    ShowPrintDialog(gcGender);
                    break;
                case "navigationPage12":
                    ShowPrintDialog(gcMaritalStatus);
                    break;
                case "navigationPage13":
                    ShowPrintDialog(gcCountry);
                    break;
                case "navigationPage14":
                    ShowPrintDialog(gcRegion);
                    break;
                case "navigationPage15":
                    ShowPrintDialog(gcTown);
                    break;
                case "navigationPage16":
                    ShowPrintDialog(gcQualification);
                    break;
                case "navigationPage17":
                    ShowPrintDialog(gcEmployeeType);
                    break;
                case "navigationPage18":
                    ShowPrintDialog(gcJobType);
                    break;
                case "navigationPage19":
                    ShowPrintDialog(gcUsers);
                    break;
            }
        }
        void SetDetailView(LayoutControlGroup layoutControlGroup,SplitterItem splitterItem, ref bool detail)
        {
            if(bciDetailView.Checked)
            {
                detail= true;
                layoutControlGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                splitterItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {
                detail = false;
                layoutControlGroup.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                splitterItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }
        private void bciDetailView_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch(navigationFrame1.SelectedPage.Caption)
            {
               
              case "navigationPage1":
                    SetDetailView(lcgCarDetail, splitterItem1,ref Setup.detailView[0]);
                    break;
                case "navigationPage2":
                    SetDetailView(lcgCarMan, splitterItem2,ref Setup.detailView[1]);
                    break;
                case "navigationPage3":
                    SetDetailView(lcgPNS, splitterItem3, ref Setup.detailView[2]);
                    break;
                case "navigationPage4":
                    SetDetailView(lcgTitle, splitterItem4, ref Setup.detailView[3]);
                    break;
                case "navigationPage5":
                    SetDetailView(lcgCustomer, splitterItem5, ref Setup.detailView[4]);
                    break;
                case "navigationPage6":
                    SetDetailView(lcgServiceType, splitterItem6, ref Setup.detailView[5]);
                    break;
                case "navigationPage7":
                    if(bciDetailView.Checked)
                    {
                        Setup.detailView[6] = true;
                        lcgCarServDetail.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        splitterItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        splitterItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        lcgProdAndServ.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    }
                    else
                    {
                        Setup.detailView[6] = false;
                        lcgCarServDetail.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        splitterItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        splitterItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                        lcgProdAndServ.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    }
                   
                    break;
                case "navigationPage8":
                    SetDetailView(lcgProdPrice, splitterItem9, ref Setup.detailView[7]);
                    break;
                case "navigationPage9":
                    SetDetailView(lcgCompanyInfo, splitterItem10, ref Setup.detailView[8]);
                    break;
                case "navigationPage10":
                    if (bciDetailView.Checked)
                    {
                        Setup.detailView[9] = true;
                        tcgEmployee.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    }
                    else
                    {
                        Setup.detailView[10] = false;
                        tcgEmployee.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    }
                    break;
                case "navigationPage11":
                    SetDetailView(lcgGender, splitterItem11, ref Setup.detailView[10]);
                    break;
                case "navigationPage12":
                    SetDetailView(lcgMStatus, splitterItem12, ref Setup.detailView[11]);
                    break;
                case "navigationPage13":
                    SetDetailView(lcgCountryDetail, splitterItem13, ref Setup.detailView[12]);
                    break;
                case "navigationPage14":
                    SetDetailView(lcgRegion, splitterItem14, ref Setup.detailView[13]);
                    break;
                case "navigationPage15":
                    SetDetailView(lcgTown, splitterItem15, ref Setup.detailView[14]);
                    break;
                case "navigationPage16":
                    SetDetailView(lcgQualification, splitterItem16, ref Setup.detailView[15]);
                    break;
                case "navigationPage17":
                    SetDetailView(lcgEmpTypeDetail, splitterItem17, ref Setup.detailView[16]);
                    break;
                case "navigationPage18":
                    SetDetailView(lcgJTDetail, splitterItem18, ref Setup.detailView[17]);
                    break;
                case "navigationPage19":
                    SetDetailView(lcgForms, splitterItem19,ref Setup.detailView[18]);
                    break;

            }
        }

        private void backstageViewControl1_BackButtonClick(object sender, EventArgs e)
        {
      
        }

        private void bsvBtnExit_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            if (XtraMessageBox.Show("Are you Sure you Wanna Exit the application ?", "Exit App", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        

        }

        private void ribbonControl1_ApplicationButtonClick(object sender, EventArgs e)
        {
            teUIUsername.Focus();
        }

        private void sbLogin_Click(object sender, EventArgs e)
        {
            if(sbLogin.Text=="Login" && setupForm.SignIn(teUIUsername, teUIPassword))
            {
                Cursor.Current = Cursors.AppStarting;
               
                //var link = navBarControl1.SelectedLink;
                //navigationFrame1.SelectNextPage();
                //navigationFrame1.SelectPrevPage();
               // 
                bhiUserName.Caption = Setup.UserName;
                lciChangePassword.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                peUIImage.Image = Setup.staffImage;
                lciImage.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                RefreshUser();
                navigationFrame1_SelectedPageChanging(sender, new SelectedPageChangingEventArgs(null, navigationFrame1.SelectedPage));
                navigationFrame1_SelectedPageChanged(sender, new SelectedPageChangedEventArgs(null, navigationFrame1.SelectedPage));
                ribbonControl1.HideApplicationButtonContentControl();
                // navBarControl1.UpdateSelectedLink();
                //navBarControl1.SelectedLink = navBarGpEntry.ItemLinks[1];
                Cursor.Current = Cursors.Default;
                //
                //

            }
            else if(sbLogin.Text=="Save")
            {
                if (teUINewPassword.Text == teUIComfirmPassword.Text)
                    setupForm.ChangePassword(teUIUsername, teUIPassword, teUINewPassword);
                else
                {
                    teUIComfirmPassword.Focus();
                    XtraMessageBox.Show("Password do not match, recheck and try again");
                }
            }
        }

        private void sbChangePassword_Click(object sender, EventArgs e)
        {
            if (sbChangePassword.Text == "Change Password")
            {
                lciNewPassword.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciComfirmPass.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                sbChangePassword.Text = "Back";
                sbLogin.Text = "Save";
            }
            else
            {
                lciNewPassword.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciComfirmPass.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                sbChangePassword.Text = "Change Password";
                sbLogin.Text = "Login";
            }
        }

      
        private void leTwnCountry_EditValueChanged(object sender, EventArgs e)
        {
            leTwnRegion.Properties.DataSource = null;
            if (leTwnCountry.EditValue!=null)
            {
                Setup.PopulateDependantLookUPs(leTwnCountry, leTwnRegion);
            }
        }

      
        private void leSfEmployeeType_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void leSfCountry_EditValueChanged(object sender, EventArgs e)
        {
            leSfRegion.Properties.DataSource = null;
            if (leSfCountry.EditValue != null)
            {
                Setup.PopulateDependantLookUPs(leSfCountry, leSfRegion);
            }
        }

        private void leSfRegion_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (leSfCountry.EditValue == null)
            {
                XtraMessageBox.Show("Select a Country in order to access regions", "Select a country", MessageBoxButtons.OK, MessageBoxIcon.Information);
                leSfCountry.Focus();
            }
        }

        private void leSfRegion_EditValueChanged(object sender, EventArgs e)
        {
            leSfTown.Properties.DataSource = null;
            if (leSfRegion.Properties.DataSource != null)
            {
                Setup.PopulateDependantLookUPs(leSfRegion,leSfTown);

            }
        }

        private void leSfTown_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (leSfRegion.Properties.DataSource == null || leSfRegion.EditValue==null)
            {
                XtraMessageBox.Show("Select a Region in order to access related Towns", "Select a Region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                leSfRegion.Focus();
            }
        }

        private void leTwnRegion_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(leTwnCountry.EditValue==null)
            {
                XtraMessageBox.Show("Select a Country in order to access regions", "Select a country", MessageBoxButtons.OK, MessageBoxIcon.Information);
                leTwnCountry.Focus();
            }
        }

        private void bhiUserName_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
        void RefreshUser()
        {
           
            Setup.dataSet.Clear();
            //dashboardViewer1.Dashboard = null;
            dashboardViewer1.Hide();
            gcCarManufacturer.DataSource = null;
            gcCarManufacturer.DataSource = null;
            gcProducts.DataSource = null;
            gcTittles.DataSource = null;
            gcCustomers.DataSource = null;
            gcServiceType.DataSource = null;
            gcCarServicing.DataSource = null;
            gcCustomerPurchase.DataSource = null;
            gcProductPrices.DataSource = null;
            gcCompanyInfo.DataSource = null;
            gcEmployee.DataSource = null;
            gcGender.DataSource = null;
            gcMaritalStatus.DataSource = null;
            gcCountry.DataSource = null;
            gcRegion.DataSource = null;
            gcTown.DataSource = null;
            gcQualification.DataSource = null;
            gcEmployeeType.DataSource = null;
            gcJobType.DataSource = null;
            gcUsers.DataSource = null;
            gcForms.DataSource = null;
            gcCustomerCar.DataSource = null;
        }

        private void bvbLogout_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            RefreshUser();
            
            Setup.userID = 0;
            Setup.accessStatus = new bool[20, 3];
            bhiUserName.Caption = "Anonymous";
            teUIUsername.Text = string.Empty;
            teUIPassword.Text = string.Empty;
            lciChangePassword.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciNewPassword.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lciComfirmPass.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            sbChangePassword.Text = "Change Password";
            sbLogin.Text = "Login";
            lciImage.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            navigationFrame1_SelectedPageChanging(sender, new SelectedPageChangingEventArgs(null, navigationFrame1.SelectedPage));
        }

        private void gvUsers_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if(e.IsGetData)
            {
                if (!Setup.Users.ContainsKey(e.ListSourceRowIndex))
                    Setup.Users.Add(e.ListSourceRowIndex, false);
                e.Value = Setup.Users[e.ListSourceRowIndex];
            }
            else
            {
                Setup.Users[e.ListSourceRowIndex] = (bool)e.Value;
            }
        }

        private void ckeFAReadAll_CheckedChanged(object sender, EventArgs e)
        {
            setupForm.ChangeSelection(ckeFAReadAll,gvForms,"frmRead");
        }

        private void ckeFAWriteAll_CheckedChanged(object sender, EventArgs e)
        {
            setupForm.ChangeSelection(ckeFAWriteAll, gvForms, "frmWrite");
        }

        private void ckeFAEditAll_CheckedChanged(object sender, EventArgs e)
        {
            setupForm.ChangeSelection(ckeFAEditAll, gvForms, "frmEdit");
        }

        private void ckeFAAddAll_CheckedChanged(object sender, EventArgs e)
        {
            setupForm.ChangeSelection(ckeFAAddAll, gvUsers, "gridColumn186");
           
        }

        private void bbiGenerateReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            entryForm.ShowReport(Setup.accessStatus[18,1],Setup.accessStatus[18,2]);
        }

        private void gvCustomerPurchase_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            int summaryID =(int)(e.Item as GridSummaryItem).Tag;
            bool ItemSelected = false;

            //Initialization stage
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
               Setup.sumOfSelectedItems = 0;

            //Calcualtion Stage
            if(e.SummaryProcess== DevExpress.Data.CustomSummaryProcess.Calculate)
            {
                if (ItemSelected = (bool)gvCustomerPurchase.GetRowCellValue(e.RowHandle, "gridColumn71"))
                    Setup.sumOfSelectedItems += Convert.ToDecimal(e.FieldValue);

            }

            //Final Stage
            if(e.SummaryProcess== DevExpress.Data.CustomSummaryProcess.Finalize)
            {
                e.TotalValue = Setup.sumOfSelectedItems;
                gridColumn70.BestFit();
                //decimal amount = 0;
                //decimal prevAmount = 0;
                //if (decimal.TryParse(teDCSAmount.Text, out amount))
                //{

                //    teDCSBalance.Text = decimal.TryParse(teDCSPrevAmount.Text, out prevAmount) ? (Setup.sumOfSelectedItems - amount - prevAmount).ToString() : (Setup.sumOfSelectedItems - amount).ToString();
                //}
                //else
                //{
                //    teDCSBalance.Text = decimal.TryParse(teDCSPrevAmount.Text, out prevAmount) ? (Setup.sumOfSelectedItems - prevAmount).ToString() : Setup.sumOfSelectedItems.ToString();
                //}
                decimal total= Setup.sumOfSelectedItems - (decimal)teDCSAmount.EditValue - (Convert.ToDecimal(teDCSTotalAmount.EditValue));
                teDCSBalance.EditValue = total < 0 ? 0 : total;
                teDCSChange.EditValue = total < 0 ? Math.Abs(total) : 0;
            }
        }

       

        private void teDCSAmount_EditValueChanged(object sender, EventArgs e)
        {
            decimal total = Setup.sumOfSelectedItems - (decimal)teDCSAmount.EditValue - (Convert.ToDecimal(teDCSTotalAmount.EditValue));
            teDCSBalance.EditValue = total < 0 ? 0 : total;
            
            teDCSChange.EditValue = total < 0 ? Math.Abs(total) : 0;
            //decimal change= (decimal)teDCSAmountRecieved.EditValue - (decimal)teDCSAmount.EditValue;
            //teDCSChange.EditValue = change > 0 ? change : 0;
            // teDCSChange.EditValue =(decimal)teDCSAmountRecieved.EditValue - (decimal)teDCSAmount.EditValue;
        }

        
        private void dashboardViewer1_DashboardLoaded(object sender, DevExpress.DashboardWin.DashboardLoadedEventArgs e)
        {
          
        }

        private void dashboardViewer1_DataLoading(object sender, DevExpress.DashboardCommon.DataLoadingEventArgs e)
        {
            
        }

        private void dashboardViewer1_ConfigureDataConnection(object sender, DevExpress.DashboardCommon.DashboardConfigureDataConnectionEventArgs e)
        {
          
        }


        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys)e.KeyChar== Keys.Enter)
            {
                sbLogin_Click(sbLogin, e);
            }
        }
      
        private void deTwnDateCreated_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bciSelectAll_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch(navigationFrame1.SelectedPage.Caption)
            {
                case "navigationPage19":
                    if(bciSelectAll.Checked)
                    {
                        ckeFAReadAll.Checked = true;
                        ckeFAEditAll.Checked = true;
                        ckeFAWriteAll.Checked = true;
                        ckeFAAddAll.Checked = true;
                        Setup.selectAll[18] = true;
                    }
                    else
                    {
                        ckeFAReadAll.Checked = false;
                        ckeFAEditAll.Checked = false;
                        ckeFAWriteAll.Checked = false;
                        ckeFAAddAll.Checked = false;
                        Setup.selectAll[18] = false;
                    }
                    break;
                default:
                    bciSelectAll.Checked = false;
                    break;
            }
        }

        private void leDCSCar_EditValueChanged(object sender, EventArgs e)
        {
            if (leDCSCar.EditValue != null)
            {
                
                DataRowView row = leDCSCar.Properties.GetDataSourceRowByKeyValue(leDCSCar.EditValue) as DataRowView;
                customerCar = (string)row[1];
            }
        }

        private void teDCSTotalAmount_EditValueChanged(object sender, EventArgs e)
        {
            decimal total = Setup.sumOfSelectedItems - (decimal)teDCSAmount.EditValue - (Convert.ToDecimal(teDCSTotalAmount.EditValue));
            teDCSBalance.EditValue = total < 0 ? 0 : total;

            teDCSChange.EditValue = total < 0 ? Math.Abs(total) : 0;
        }

        private void leCCCustomer_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if (string.IsNullOrEmpty(e.DisplayValue.ToString())) return;
            if(XtraMessageBox.Show("Adding New Customer","Adding "+e.DisplayValue+" as new Customer",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                //check if -2 exixt then replace

                //after saving , we edit the row and replace -2 with  the new primary key.
            }

        }
    }
    
}