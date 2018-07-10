using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;

namespace ProjFitterShop2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.officeNavigationBar1 = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGpEntry = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem19 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGpSetup = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiCars = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiCarManufacturer = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem1 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem10 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem2 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarItem11 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem12 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem13 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem3 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarItem14 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem15 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem16 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGpAdmin = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem17 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem18 = new DevExpress.XtraNavBar.NavBarItem();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcCars = new DevExpress.XtraLayout.LayoutControl();
            this.leCarManufacturer = new DevExpress.XtraEditors.LookUpEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.teUIUsername = new DevExpress.XtraEditors.TextEdit();
            this.teUIPassword = new DevExpress.XtraEditors.TextEdit();
            this.teUINewPassword = new DevExpress.XtraEditors.TextEdit();
            this.teUIComfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.peUIImage = new DevExpress.XtraEditors.PictureEdit();
            this.sbChangePassword = new DevExpress.XtraEditors.SimpleButton();
            this.sbLogin = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup22 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem98 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem99 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNewPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciComfirmPass = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem104 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciChangePassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciImage = new DevExpress.XtraLayout.LayoutControlItem();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.bvbLogout = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.backstageViewItemSeparator1 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
            this.bsvBtnExit = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.bciEdit = new DevExpress.XtraBars.BarCheckItem();
            this.bbiShowPrintDialog = new DevExpress.XtraBars.BarButtonItem();
            this.bbiGenerateReport = new DevExpress.XtraBars.BarButtonItem();
            this.bciDetailView = new DevExpress.XtraBars.BarCheckItem();
            this.bciSelectAll = new DevExpress.XtraBars.BarCheckItem();
            this.bhiUserName = new DevExpress.XtraBars.BarHeaderItem();
            this.bhiCurrentPage = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gcCars = new DevExpress.XtraGrid.GridControl();
            this.gvCars = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teCarFName = new DevExpress.XtraEditors.TextEdit();
            this.teCarSName = new DevExpress.XtraEditors.TextEdit();
            this.peCarImage = new DevExpress.XtraEditors.PictureEdit();
            this.meCarRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.deCarDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.ckeCarStatus = new DevExpress.XtraEditors.CheckEdit();
            this.deCarYear = new DevExpress.XtraEditors.DateEdit();
            this.lcgCars = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgCarDetail = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcCarManufacturer = new DevExpress.XtraLayout.LayoutControl();
            this.gcCarManufacturer = new DevExpress.XtraGrid.GridControl();
            this.gvCarManufacturer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teCMFname = new DevExpress.XtraEditors.TextEdit();
            this.teCMSName = new DevExpress.XtraEditors.TextEdit();
            this.meCMRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.deCMDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.ckeCMStatus = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgCarMan = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcProduct = new DevExpress.XtraLayout.LayoutControl();
            this.gcProducts = new DevExpress.XtraGrid.GridControl();
            this.gvProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn54 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn53 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tePdFName = new DevExpress.XtraEditors.TextEdit();
            this.tePdUnitPrice = new DevExpress.XtraEditors.TextEdit();
            this.tePdSName = new DevExpress.XtraEditors.TextEdit();
            this.mePdRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.dePdDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.ckePdStatus = new DevExpress.XtraEditors.CheckEdit();
            this.sePdVatRate = new DevExpress.XtraEditors.SpinEdit();
            this.sePdTaxRate = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgPNS = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem53 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem52 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem3 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPage4 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcTitle = new DevExpress.XtraLayout.LayoutControl();
            this.gcTittles = new DevExpress.XtraGrid.GridControl();
            this.gvTitles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teTFName = new DevExpress.XtraEditors.TextEdit();
            this.teTSName = new DevExpress.XtraEditors.TextEdit();
            this.meTRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.deTDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.ckeTStatus = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgTitle = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem24 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem27 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem28 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem29 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem4 = new DevExpress.XtraLayout.SplitterItem();
            this.navigationPage5 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcCustomers = new DevExpress.XtraLayout.LayoutControl();
            this.gcCustomers = new DevExpress.XtraGrid.GridControl();
            this.gvCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn38 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn36 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn37 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn39 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn40 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn41 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn42 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn43 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn74 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.leCDTitle = new DevExpress.XtraEditors.LookUpEdit();
            this.teCDFName = new DevExpress.XtraEditors.TextEdit();
            this.teCDPhone = new DevExpress.XtraEditors.TextEdit();
            this.teCDSName = new DevExpress.XtraEditors.TextEdit();
            this.teCDID = new DevExpress.XtraEditors.TextEdit();
            this.teCDAddress = new DevExpress.XtraEditors.TextEdit();
            this.meCDRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.ckeCDStatus = new DevExpress.XtraEditors.CheckEdit();
            this.deCDDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup9 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgCustomer = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem30 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem33 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem35 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem36 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem38 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem37 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem34 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem39 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem31 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem5 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem40 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPage6 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcServiceType = new DevExpress.XtraLayout.LayoutControl();
            this.gcServiceType = new DevExpress.XtraGrid.GridControl();
            this.gvServiceType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn45 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn46 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn47 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn48 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn49 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn50 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn51 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teSTFName = new DevExpress.XtraEditors.TextEdit();
            this.teSTSName = new DevExpress.XtraEditors.TextEdit();
            this.meSTRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.deSTDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.ckeSTStatus = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup12 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgServiceType = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem42 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem43 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem44 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem45 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem46 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem6 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem47 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPage7 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcCarServicing = new DevExpress.XtraLayout.LayoutControl();
            this.leDCSServiceType = new DevExpress.XtraEditors.LookUpEdit();
            this.leDCSCar = new DevExpress.XtraEditors.LookUpEdit();
            this.leDCSCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.gcCarServicing = new DevExpress.XtraGrid.GridControl();
            this.gvCarServicing = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn55 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn56 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn57 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn58 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn194 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn59 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn190 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn189 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn191 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn61 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn60 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn62 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCustomerPurchase = new DevExpress.XtraGrid.GridControl();
            this.gvCustomerPurchase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn63 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn71 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCEAddItem = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn65 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSEQuantity = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn64 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn66 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn67 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn68 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn69 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSEDiscount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn70 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSEVat = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSETax = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.deDCSDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.meDCSRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.teDCSAmount = new DevExpress.XtraEditors.TextEdit();
            this.teDCSChange = new DevExpress.XtraEditors.TextEdit();
            this.teDCSBalance = new DevExpress.XtraEditors.TextEdit();
            this.teDCSTotalAmount = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup11 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgProdAndServ = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem48 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem8 = new DevExpress.XtraLayout.SplitterItem();
            this.splitterItem7 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem41 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgCarServDetail = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem63 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem64 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem66 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem57 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem159 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem160 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTotalAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem50 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPage8 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcProductPrice = new DevExpress.XtraLayout.LayoutControl();
            this.lePPProduct = new DevExpress.XtraEditors.LookUpEdit();
            this.gcProductPrices = new DevExpress.XtraGrid.GridControl();
            this.gvProductPrices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn52 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn75 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn76 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn77 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn72 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn79 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn78 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn73 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn81 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tePPUnitPrice = new DevExpress.XtraEditors.TextEdit();
            this.dePPDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.ckePPStatus = new DevExpress.XtraEditors.CheckEdit();
            this.sePPTaxRate = new DevExpress.XtraEditors.SpinEdit();
            this.sePPVatRate = new DevExpress.XtraEditors.SpinEdit();
            this.mePPRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup16 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem51 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgProdPrice = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem61 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem62 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem60 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem58 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem56 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem65 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem49 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem9 = new DevExpress.XtraLayout.SplitterItem();
            this.navigationPage9 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcCompanyInfo = new DevExpress.XtraLayout.LayoutControl();
            this.gcCompanyInfo = new DevExpress.XtraGrid.GridControl();
            this.gvCompanyInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn80 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn82 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn83 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn96 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn95 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn94 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn84 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn93 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn87 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn88 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn89 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teCISlogan = new DevExpress.XtraEditors.TextEdit();
            this.deCIDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.ckeCIStatus = new DevExpress.XtraEditors.CheckEdit();
            this.meCIRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.teCIFName = new DevExpress.XtraEditors.TextEdit();
            this.teCISName = new DevExpress.XtraEditors.TextEdit();
            this.teCIPhone = new DevExpress.XtraEditors.TextEdit();
            this.teCIAddress = new DevExpress.XtraEditors.TextEdit();
            this.peCILogo = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem54 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgCompanyInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem55 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem59 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem69 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem72 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem73 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem74 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem68 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem75 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem67 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem10 = new DevExpress.XtraLayout.SplitterItem();
            this.navigationPage10 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcEmployee = new DevExpress.XtraLayout.LayoutControl();
            this.leSfQualification = new DevExpress.XtraEditors.LookUpEdit();
            this.leSfJobType = new DevExpress.XtraEditors.LookUpEdit();
            this.leSfEmployeeType = new DevExpress.XtraEditors.LookUpEdit();
            this.leSfMStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.leSfTitle = new DevExpress.XtraEditors.LookUpEdit();
            this.leSfGender = new DevExpress.XtraEditors.LookUpEdit();
            this.leSfRegion = new DevExpress.XtraEditors.LookUpEdit();
            this.leSfCountry = new DevExpress.XtraEditors.LookUpEdit();
            this.leSfTown = new DevExpress.XtraEditors.LookUpEdit();
            this.gcEmployee = new DevExpress.XtraGrid.GridControl();
            this.gvEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn85 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn86 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn90 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn91 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn173 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn172 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn171 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn170 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn169 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn168 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn167 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn166 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn165 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn164 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn163 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn162 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn92 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn97 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn98 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn175 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn174 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn99 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn100 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn101 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn102 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teSFOName = new DevExpress.XtraEditors.TextEdit();
            this.deSfDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.ckeSfStatus = new DevExpress.XtraEditors.CheckEdit();
            this.meSfRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.teSfFName = new DevExpress.XtraEditors.TextEdit();
            this.teSfPhone = new DevExpress.XtraEditors.TextEdit();
            this.teSfAddress = new DevExpress.XtraEditors.TextEdit();
            this.peSfImage = new DevExpress.XtraEditors.PictureEdit();
            this.teSfLName = new DevExpress.XtraEditors.TextEdit();
            this.deSfDOB = new DevExpress.XtraEditors.DateEdit();
            this.teSfEmail = new DevExpress.XtraEditors.TextEdit();
            this.teSfStaffID = new DevExpress.XtraEditors.TextEdit();
            this.deSfStartDate = new DevExpress.XtraEditors.DateEdit();
            this.deSfEndDate = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup19 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tcgEmployee = new DevExpress.XtraLayout.TabbedControlGroup();
            this.lcgSfPersonalInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem76 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem77 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem79 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem81 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem84 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem86 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem87 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem88 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem90 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem80 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem82 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem91 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem78 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem83 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem85 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem89 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem71 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgSfJobSpec = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem93 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem94 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem95 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem92 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem97 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem96 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem70 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPage11 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcGender = new DevExpress.XtraLayout.LayoutControl();
            this.gcGender = new DevExpress.XtraGrid.GridControl();
            this.gvGender = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn103 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn104 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn105 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn106 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn107 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn108 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn109 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teGFName = new DevExpress.XtraEditors.TextEdit();
            this.teGSName = new DevExpress.XtraEditors.TextEdit();
            this.meGRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.deGDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.ckeGStatus = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup23 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgGender = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem100 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem101 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem102 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem103 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem105 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem11 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem106 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPage12 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcMaritalStatus = new DevExpress.XtraLayout.LayoutControl();
            this.gcMaritalStatus = new DevExpress.XtraGrid.GridControl();
            this.gvMaritalStatus = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn110 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn111 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn112 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn113 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn114 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn115 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn116 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teMSFName = new DevExpress.XtraEditors.TextEdit();
            this.teMSSName = new DevExpress.XtraEditors.TextEdit();
            this.meMSRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.deMSDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.ckeMSStatus = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup25 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgMStatus = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem107 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem108 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem109 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem110 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem111 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem12 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem112 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPage13 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcCountry = new DevExpress.XtraLayout.LayoutControl();
            this.gcCountry = new DevExpress.XtraGrid.GridControl();
            this.gvCountry = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn117 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn118 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn119 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn120 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn121 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn122 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn123 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teConFName = new DevExpress.XtraEditors.TextEdit();
            this.teConSName = new DevExpress.XtraEditors.TextEdit();
            this.meConRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.deConDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.ckeConStatus = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup27 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgCountryDetail = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem113 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem114 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem115 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem116 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem117 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem13 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem118 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPage14 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcRegion = new DevExpress.XtraLayout.LayoutControl();
            this.gcRegion = new DevExpress.XtraGrid.GridControl();
            this.gvRegion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn124 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn125 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn126 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn131 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn127 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn128 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn129 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn130 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teRegFName = new DevExpress.XtraEditors.TextEdit();
            this.teRegSName = new DevExpress.XtraEditors.TextEdit();
            this.meRegRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.deRegDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.ckeRegStatus = new DevExpress.XtraEditors.CheckEdit();
            this.leRegCountry = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup29 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgRegion = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem119 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem120 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem121 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem122 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem123 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem125 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem14 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem124 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPage15 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcTown = new DevExpress.XtraLayout.LayoutControl();
            this.leTwnCountry = new DevExpress.XtraEditors.LookUpEdit();
            this.gcTown = new DevExpress.XtraGrid.GridControl();
            this.gvTown = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn132 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn133 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn134 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn135 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn140 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn136 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn137 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn138 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn139 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teTwnFName = new DevExpress.XtraEditors.TextEdit();
            this.teTwnSName = new DevExpress.XtraEditors.TextEdit();
            this.meTwnRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.deTwnDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.ckeTwnStatus = new DevExpress.XtraEditors.CheckEdit();
            this.leTwnRegion = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup31 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgTown = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem126 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem127 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem128 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem129 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem130 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem134 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem133 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem15 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem132 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPage16 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcQualification = new DevExpress.XtraLayout.LayoutControl();
            this.gcQualification = new DevExpress.XtraGrid.GridControl();
            this.gvQualification = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn141 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn142 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn143 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn144 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn145 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn146 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn147 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teQFName = new DevExpress.XtraEditors.TextEdit();
            this.teQSName = new DevExpress.XtraEditors.TextEdit();
            this.meQRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.deQDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.ckeQStatus = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup33 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgQualification = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem135 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem136 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem137 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem138 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem139 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem16 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem140 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPage17 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcEmployeeType = new DevExpress.XtraLayout.LayoutControl();
            this.gcEmployeeType = new DevExpress.XtraGrid.GridControl();
            this.gvEmployeeType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn148 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn149 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn150 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn151 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn152 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn153 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn154 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teETFName = new DevExpress.XtraEditors.TextEdit();
            this.teETSName = new DevExpress.XtraEditors.TextEdit();
            this.meETRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.deETDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.ckeETStatus = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup35 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgEmpTypeDetail = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem141 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem142 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem143 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem144 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem145 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem17 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem146 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPage18 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcJobType = new DevExpress.XtraLayout.LayoutControl();
            this.gcJobType = new DevExpress.XtraGrid.GridControl();
            this.gvJobType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn155 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn156 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn157 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn158 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn159 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn160 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn161 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teJTFName = new DevExpress.XtraEditors.TextEdit();
            this.teJTSName = new DevExpress.XtraEditors.TextEdit();
            this.meJTRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.deJTDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.ckeJTStatus = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup37 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgJTDetail = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem147 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem148 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem149 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem150 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem151 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem18 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem152 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPage19 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcFormAccess = new DevExpress.XtraLayout.LayoutControl();
            this.gcUsers = new DevExpress.XtraGrid.GridControl();
            this.gvUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn182 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn186 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riUsersAdd = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn183 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn185 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn187 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn188 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn184 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcForms = new DevExpress.XtraGrid.GridControl();
            this.gvForms = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn176 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn177 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn178 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn179 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn180 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn181 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckeFAReadAll = new DevExpress.XtraEditors.CheckEdit();
            this.ckeFAEditAll = new DevExpress.XtraEditors.CheckEdit();
            this.ckeFAWriteAll = new DevExpress.XtraEditors.CheckEdit();
            this.ckeFAAddAll = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup20 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.splitterItem19 = new DevExpress.XtraLayout.SplitterItem();
            this.lcgForms = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem154 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem158 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem155 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem156 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup39 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem153 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem157 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPage20 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.dashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(this.components);
            this.navigationPage21 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lcCustomerCar = new DevExpress.XtraLayout.LayoutControl();
            this.leCCCar = new DevExpress.XtraEditors.LookUpEdit();
            this.leCCCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.gcCustomerCar = new DevExpress.XtraGrid.GridControl();
            this.gvCustomerCar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn192 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn193 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn195 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn199 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn196 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn197 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn198 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn200 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.meCCRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.deCCDateCreated = new DevExpress.XtraEditors.DateEdit();
            this.ckeCCStatus = new DevExpress.XtraEditors.CheckEdit();
            this.teCCRegNum = new DevExpress.XtraEditors.TextEdit();
            this.teCCVIN = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem163 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem164 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem165 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem168 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem162 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem161 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem166 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem20 = new DevExpress.XtraLayout.SplitterItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.layoutControlItem32 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColumn44 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcCars)).BeginInit();
            this.lcCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leCarManufacturer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            this.backstageViewClientControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teUIUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUIPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUINewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUIComfirmPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peUIImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem98)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem99)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciComfirmPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem104)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChangePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCarFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCarSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCarImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meCarRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCarDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCarDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeCarStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCarYear.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCarYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCarDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcCarManufacturer)).BeginInit();
            this.lcCarManufacturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCarManufacturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCarManufacturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCMFname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCMSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meCMRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCMDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCMDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeCMStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCarMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            this.navigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcProduct)).BeginInit();
            this.lcProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePdFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePdUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePdSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mePdRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePdDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePdDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckePdStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePdVatRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePdTaxRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            this.navigationPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcTitle)).BeginInit();
            this.lcTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTittles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTitles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meTRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeTStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem4)).BeginInit();
            this.navigationPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcCustomers)).BeginInit();
            this.lcCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leCDTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCDFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCDPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCDSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCDID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCDAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meCDRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeCDStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCDDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCDDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem40)).BeginInit();
            this.navigationPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcServiceType)).BeginInit();
            this.lcServiceType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcServiceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServiceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSTFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSTSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meSTRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSTDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSTDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeSTStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgServiceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem47)).BeginInit();
            this.navigationPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcCarServicing)).BeginInit();
            this.lcCarServicing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leDCSServiceType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leDCSCar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leDCSCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCarServicing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCarServicing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCEAddItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSEQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSEDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSEVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSETax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDCSDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDCSDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDCSRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDCSAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDCSChange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDCSBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDCSTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgProdAndServ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCarServDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem159)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem160)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTotalAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem50)).BeginInit();
            this.navigationPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcProductPrice)).BeginInit();
            this.lcProductPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lePPProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductPrices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePPUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePPDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePPDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckePPStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePPTaxRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePPVatRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mePPRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgProdPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem9)).BeginInit();
            this.navigationPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcCompanyInfo)).BeginInit();
            this.lcCompanyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCompanyInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompanyInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCISlogan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCIDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCIDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeCIStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meCIRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCIFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCISName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCIPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCIAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCILogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCompanyInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem74)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem10)).BeginInit();
            this.navigationPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcEmployee)).BeginInit();
            this.lcEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leSfQualification.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSfJobType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSfEmployeeType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSfMStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSfTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSfGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSfRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSfCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSfTown.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSFOName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSfDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSfDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeSfStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meSfRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSfFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSfPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSfAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSfImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSfLName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSfDOB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSfDOB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSfEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSfStaffID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSfStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSfStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSfEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSfEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcgEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSfPersonalInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem76)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem77)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem79)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem84)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem86)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem88)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem82)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem91)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem78)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem83)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem85)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem89)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSfJobSpec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem93)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem94)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem95)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem92)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem97)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem96)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem70)).BeginInit();
            this.navigationPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcGender)).BeginInit();
            this.lcGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teGFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teGSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meGRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deGDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deGDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeGStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem102)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem103)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem105)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem106)).BeginInit();
            this.navigationPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcMaritalStatus)).BeginInit();
            this.lcMaritalStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMaritalStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaritalStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMSFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMSSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meMSRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deMSDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deMSDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeMSStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem107)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem108)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem109)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem110)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem112)).BeginInit();
            this.navigationPage13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcCountry)).BeginInit();
            this.lcCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teConFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teConSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meConRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deConDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deConDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeConStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCountryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem113)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem114)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem115)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem116)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem117)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem118)).BeginInit();
            this.navigationPage14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcRegion)).BeginInit();
            this.lcRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRegFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRegSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meRegRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRegDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRegDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeRegStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leRegCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem119)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem120)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem121)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem122)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem123)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem125)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem124)).BeginInit();
            this.navigationPage15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcTown)).BeginInit();
            this.lcTown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leTwnCountry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTwnFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTwnSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meTwnRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTwnDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTwnDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeTwnStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leTwnRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem126)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem127)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem128)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem129)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem130)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem134)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem133)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem132)).BeginInit();
            this.navigationPage16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcQualification)).BeginInit();
            this.lcQualification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcQualification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQualification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meQRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deQDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deQDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeQStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgQualification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem135)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem136)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem137)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem138)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem139)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem140)).BeginInit();
            this.navigationPage17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcEmployeeType)).BeginInit();
            this.lcEmployeeType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teETFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teETSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meETRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deETDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deETDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeETStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgEmpTypeDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem141)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem142)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem143)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem144)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem145)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem146)).BeginInit();
            this.navigationPage18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcJobType)).BeginInit();
            this.lcJobType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcJobType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJTFName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJTSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meJTRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deJTDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deJTDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeJTStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgJTDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem147)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem148)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem149)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem150)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem151)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem152)).BeginInit();
            this.navigationPage19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcFormAccess)).BeginInit();
            this.lcFormAccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riUsersAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeFAReadAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeFAEditAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeFAWriteAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeFAAddAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem154)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem158)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem155)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem156)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem153)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem157)).BeginInit();
            this.navigationPage20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).BeginInit();
            this.navigationPage21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcCustomerCar)).BeginInit();
            this.lcCustomerCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leCCCar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leCCCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meCCRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCCDateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCCDateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeCCStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCCRegNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCCVIN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem163)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem164)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem165)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem168)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem162)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem161)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem166)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).BeginInit();
            this.SuspendLayout();
            // 
            // officeNavigationBar1
            // 
            this.officeNavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar1.Location = new System.Drawing.Point(0, 478);
            this.officeNavigationBar1.Name = "officeNavigationBar1";
            this.officeNavigationBar1.NavigationClient = this.navBarControl1;
            this.officeNavigationBar1.Size = new System.Drawing.Size(866, 45);
            this.officeNavigationBar1.TabIndex = 0;
            this.officeNavigationBar1.Text = "officeNavigationBar1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGpEntry;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGpSetup,
            this.navBarGpEntry,
            this.navBarGpAdmin});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiCars,
            this.nbiCarManufacturer,
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItem7,
            this.navBarItem8,
            this.navBarSeparatorItem1,
            this.navBarItem9,
            this.navBarItem10,
            this.navBarSeparatorItem2,
            this.navBarItem11,
            this.navBarItem12,
            this.navBarItem13,
            this.navBarSeparatorItem3,
            this.navBarItem14,
            this.navBarItem15,
            this.navBarItem16,
            this.navBarItem17,
            this.navBarItem18,
            this.navBarItem19});
            this.navBarControl1.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl;
            this.navBarControl1.Location = new System.Drawing.Point(0, 143);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 140;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(140, 335);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.SelectedLinkChanged += new DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventHandler(this.navBarControl1_SelectedLinkChanged);
            // 
            // navBarGpEntry
            // 
            this.navBarGpEntry.Caption = "Entries";
            this.navBarGpEntry.Expanded = true;
            this.navBarGpEntry.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem19),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem8)});
            this.navBarGpEntry.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGpEntry.LargeImage")));
            this.navBarGpEntry.Name = "navBarGpEntry";
            this.navBarGpEntry.SelectedLinkIndex = 1;
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Customers";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem2.SmallImage")));
            // 
            // navBarItem19
            // 
            this.navBarItem19.Caption = "Customer Cars";
            this.navBarItem19.Name = "navBarItem19";
            this.navBarItem19.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem19.SmallImage")));
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Daily Car Servicing";
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem5.SmallImage")));
            // 
            // navBarItem8
            // 
            this.navBarItem8.Caption = "Employee";
            this.navBarItem8.Name = "navBarItem8";
            this.navBarItem8.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem8.SmallImage")));
            // 
            // navBarGpSetup
            // 
            this.navBarGpSetup.Caption = "Setups";
            this.navBarGpSetup.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiCars),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiCarManufacturer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem9),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem10),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem11),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem12),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem13),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem14),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem15),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem16)});
            this.navBarGpSetup.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGpSetup.LargeImage")));
            this.navBarGpSetup.Name = "navBarGpSetup";
            // 
            // nbiCars
            // 
            this.nbiCars.Caption = "Cars";
            this.nbiCars.Name = "nbiCars";
            this.nbiCars.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiCars.SmallImage")));
            // 
            // nbiCarManufacturer
            // 
            this.nbiCarManufacturer.Caption = "Car Manufacturers";
            this.nbiCarManufacturer.Name = "nbiCarManufacturer";
            this.nbiCarManufacturer.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiCarManufacturer.SmallImage")));
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Products N Services";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.SmallImage")));
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Service Type";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.SmallImage")));
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Product Prices";
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem6.SmallImage")));
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "Company Info";
            this.navBarItem7.Name = "navBarItem7";
            this.navBarItem7.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem7.SmallImage")));
            // 
            // navBarSeparatorItem1
            // 
            this.navBarSeparatorItem1.CanDrag = false;
            this.navBarSeparatorItem1.Enabled = false;
            this.navBarSeparatorItem1.Hint = null;
            this.navBarSeparatorItem1.LargeImageIndex = 0;
            this.navBarSeparatorItem1.LargeImageSize = new System.Drawing.Size(0, 0);
            this.navBarSeparatorItem1.Name = "navBarSeparatorItem1";
            this.navBarSeparatorItem1.SmallImageIndex = 0;
            this.navBarSeparatorItem1.SmallImageSize = new System.Drawing.Size(0, 0);
            // 
            // navBarItem9
            // 
            this.navBarItem9.Caption = "Gender";
            this.navBarItem9.Name = "navBarItem9";
            this.navBarItem9.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem9.SmallImage")));
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Titles";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.SmallImage")));
            // 
            // navBarItem10
            // 
            this.navBarItem10.Caption = "Marital Status";
            this.navBarItem10.Name = "navBarItem10";
            this.navBarItem10.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem10.SmallImage")));
            // 
            // navBarSeparatorItem2
            // 
            this.navBarSeparatorItem2.CanDrag = false;
            this.navBarSeparatorItem2.Enabled = false;
            this.navBarSeparatorItem2.Hint = null;
            this.navBarSeparatorItem2.LargeImageIndex = 0;
            this.navBarSeparatorItem2.LargeImageSize = new System.Drawing.Size(0, 0);
            this.navBarSeparatorItem2.Name = "navBarSeparatorItem2";
            this.navBarSeparatorItem2.SmallImageIndex = 0;
            this.navBarSeparatorItem2.SmallImageSize = new System.Drawing.Size(0, 0);
            // 
            // navBarItem11
            // 
            this.navBarItem11.Caption = "Country";
            this.navBarItem11.Name = "navBarItem11";
            this.navBarItem11.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem11.SmallImage")));
            // 
            // navBarItem12
            // 
            this.navBarItem12.Caption = "Region";
            this.navBarItem12.Name = "navBarItem12";
            this.navBarItem12.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem12.SmallImage")));
            // 
            // navBarItem13
            // 
            this.navBarItem13.Caption = "Town";
            this.navBarItem13.Name = "navBarItem13";
            this.navBarItem13.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem13.SmallImage")));
            // 
            // navBarSeparatorItem3
            // 
            this.navBarSeparatorItem3.CanDrag = false;
            this.navBarSeparatorItem3.Enabled = false;
            this.navBarSeparatorItem3.Hint = null;
            this.navBarSeparatorItem3.LargeImageIndex = 0;
            this.navBarSeparatorItem3.LargeImageSize = new System.Drawing.Size(0, 0);
            this.navBarSeparatorItem3.Name = "navBarSeparatorItem3";
            this.navBarSeparatorItem3.SmallImageIndex = 0;
            this.navBarSeparatorItem3.SmallImageSize = new System.Drawing.Size(0, 0);
            // 
            // navBarItem14
            // 
            this.navBarItem14.Caption = "Qualification";
            this.navBarItem14.Name = "navBarItem14";
            this.navBarItem14.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem14.SmallImage")));
            // 
            // navBarItem15
            // 
            this.navBarItem15.Caption = "Employee Type";
            this.navBarItem15.Name = "navBarItem15";
            this.navBarItem15.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem15.SmallImage")));
            // 
            // navBarItem16
            // 
            this.navBarItem16.Caption = "Job Type";
            this.navBarItem16.Name = "navBarItem16";
            this.navBarItem16.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem16.SmallImage")));
            // 
            // navBarGpAdmin
            // 
            this.navBarGpAdmin.Caption = "Administrator";
            this.navBarGpAdmin.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem17),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem18)});
            this.navBarGpAdmin.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGpAdmin.LargeImage")));
            this.navBarGpAdmin.Name = "navBarGpAdmin";
            // 
            // navBarItem17
            // 
            this.navBarItem17.Caption = "Form Access";
            this.navBarItem17.Name = "navBarItem17";
            this.navBarItem17.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem17.SmallImage")));
            // 
            // navBarItem18
            // 
            this.navBarItem18.Caption = "DashBoard";
            this.navBarItem18.Name = "navBarItem18";
            this.navBarItem18.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem18.SmallImage")));
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Controls.Add(this.navigationPage3);
            this.navigationFrame1.Controls.Add(this.navigationPage4);
            this.navigationFrame1.Controls.Add(this.navigationPage5);
            this.navigationFrame1.Controls.Add(this.navigationPage6);
            this.navigationFrame1.Controls.Add(this.navigationPage7);
            this.navigationFrame1.Controls.Add(this.navigationPage8);
            this.navigationFrame1.Controls.Add(this.navigationPage9);
            this.navigationFrame1.Controls.Add(this.navigationPage10);
            this.navigationFrame1.Controls.Add(this.navigationPage11);
            this.navigationFrame1.Controls.Add(this.navigationPage12);
            this.navigationFrame1.Controls.Add(this.navigationPage13);
            this.navigationFrame1.Controls.Add(this.navigationPage14);
            this.navigationFrame1.Controls.Add(this.navigationPage15);
            this.navigationFrame1.Controls.Add(this.navigationPage16);
            this.navigationFrame1.Controls.Add(this.navigationPage17);
            this.navigationFrame1.Controls.Add(this.navigationPage18);
            this.navigationFrame1.Controls.Add(this.navigationPage19);
            this.navigationFrame1.Controls.Add(this.navigationPage20);
            this.navigationFrame1.Controls.Add(this.navigationPage21);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(140, 143);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2,
            this.navigationPage3,
            this.navigationPage4,
            this.navigationPage5,
            this.navigationPage6,
            this.navigationPage7,
            this.navigationPage8,
            this.navigationPage9,
            this.navigationPage10,
            this.navigationPage11,
            this.navigationPage12,
            this.navigationPage13,
            this.navigationPage14,
            this.navigationPage15,
            this.navigationPage16,
            this.navigationPage17,
            this.navigationPage18,
            this.navigationPage19,
            this.navigationPage20,
            this.navigationPage21});
            this.navigationFrame1.SelectedPage = this.navigationPage2;
            this.navigationFrame1.Size = new System.Drawing.Size(726, 335);
            this.navigationFrame1.TabIndex = 2;
            this.navigationFrame1.Tag = "";
            this.navigationFrame1.Text = "navigationFrame1";
            this.navigationFrame1.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.navigationFrame1_SelectedPageChanged);
            this.navigationFrame1.SelectedPageChanging += new DevExpress.XtraBars.Navigation.SelectedPageChangingEventHandler(this.navigationFrame1_SelectedPageChanging);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Controls.Add(this.lcCars);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(726, 335);
            this.navigationPage1.Tag = "Cars";
            // 
            // lcCars
            // 
            this.lcCars.Controls.Add(this.leCarManufacturer);
            this.lcCars.Controls.Add(this.gcCars);
            this.lcCars.Controls.Add(this.teCarFName);
            this.lcCars.Controls.Add(this.teCarSName);
            this.lcCars.Controls.Add(this.peCarImage);
            this.lcCars.Controls.Add(this.meCarRemarks);
            this.lcCars.Controls.Add(this.deCarDateCreated);
            this.lcCars.Controls.Add(this.ckeCarStatus);
            this.lcCars.Controls.Add(this.deCarYear);
            this.lcCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcCars.Location = new System.Drawing.Point(0, 0);
            this.lcCars.Name = "lcCars";
            this.lcCars.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(347, 228, 450, 400);
            this.lcCars.Root = this.lcgCars;
            this.lcCars.Size = new System.Drawing.Size(726, 335);
            this.lcCars.TabIndex = 0;
            this.lcCars.Text = "layoutControl1";
            // 
            // leCarManufacturer
            // 
            this.leCarManufacturer.Location = new System.Drawing.Point(99, 112);
            this.leCarManufacturer.MenuManager = this.ribbonControl1;
            this.leCarManufacturer.Name = "leCarManufacturer";
            this.leCarManufacturer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leCarManufacturer.Properties.NullText = "Select Manufacturer";
            this.leCarManufacturer.Size = new System.Drawing.Size(409, 20);
            this.leCarManufacturer.StyleController = this.lcCars;
            this.leCarManufacturer.TabIndex = 4;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiNew,
            this.bbiSave,
            this.bbiDelete,
            this.skinRibbonGalleryBarItem1,
            this.bciEdit,
            this.bbiShowPrintDialog,
            this.bbiGenerateReport,
            this.bciDetailView,
            this.bciSelectAll,
            this.bhiUserName,
            this.bhiCurrentPage,
            this.barHeaderItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 36;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.bhiUserName);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.bbiNew);
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.bciEdit);
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.bbiSave);
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(866, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ApplicationButtonClick += new System.EventHandler(this.ribbonControl1_ApplicationButtonClick);
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl1);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem1);
            this.backstageViewControl1.Items.Add(this.bvbLogout);
            this.backstageViewControl1.Items.Add(this.backstageViewItemSeparator1);
            this.backstageViewControl1.Items.Add(this.bsvBtnExit);
            this.backstageViewControl1.Location = new System.Drawing.Point(0, 32);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.OwnerControl = this.ribbonControl1;
            this.backstageViewControl1.SelectedTab = this.backstageViewTabItem1;
            this.backstageViewControl1.SelectedTabIndex = 0;
            this.backstageViewControl1.Size = new System.Drawing.Size(141, 105);
            this.backstageViewControl1.TabIndex = 5;
            this.backstageViewControl1.Text = "backstageViewControl1";
            this.backstageViewControl1.BackButtonClick += new System.EventHandler(this.backstageViewControl1_BackButtonClick);
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Controls.Add(this.layoutControl1);
            this.backstageViewClientControl1.Location = new System.Drawing.Point(133, 63);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(0, 41);
            this.backstageViewClientControl1.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.teUIUsername);
            this.layoutControl1.Controls.Add(this.teUIPassword);
            this.layoutControl1.Controls.Add(this.teUINewPassword);
            this.layoutControl1.Controls.Add(this.teUIComfirmPassword);
            this.layoutControl1.Controls.Add(this.peUIImage);
            this.layoutControl1.Controls.Add(this.sbChangePassword);
            this.layoutControl1.Controls.Add(this.sbLogin);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(700, 413, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup22;
            this.layoutControl1.Size = new System.Drawing.Size(0, 41);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // teUIUsername
            // 
            this.teUIUsername.Location = new System.Drawing.Point(108, 12);
            this.teUIUsername.MenuManager = this.ribbonControl1;
            this.teUIUsername.Name = "teUIUsername";
            this.teUIUsername.Size = new System.Drawing.Size(50, 20);
            this.teUIUsername.StyleController = this.layoutControl1;
            this.teUIUsername.TabIndex = 4;
            this.teUIUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            // 
            // teUIPassword
            // 
            this.teUIPassword.Location = new System.Drawing.Point(108, 36);
            this.teUIPassword.MenuManager = this.ribbonControl1;
            this.teUIPassword.Name = "teUIPassword";
            this.teUIPassword.Properties.PasswordChar = '0';
            this.teUIPassword.Size = new System.Drawing.Size(50, 20);
            this.teUIPassword.StyleController = this.layoutControl1;
            this.teUIPassword.TabIndex = 5;
            this.teUIPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            // 
            // teUINewPassword
            // 
            this.teUINewPassword.Location = new System.Drawing.Point(108, 60);
            this.teUINewPassword.MenuManager = this.ribbonControl1;
            this.teUINewPassword.Name = "teUINewPassword";
            this.teUINewPassword.Properties.PasswordChar = '0';
            this.teUINewPassword.Size = new System.Drawing.Size(50, 20);
            this.teUINewPassword.StyleController = this.layoutControl1;
            this.teUINewPassword.TabIndex = 6;
            // 
            // teUIComfirmPassword
            // 
            this.teUIComfirmPassword.Location = new System.Drawing.Point(108, 84);
            this.teUIComfirmPassword.MenuManager = this.ribbonControl1;
            this.teUIComfirmPassword.Name = "teUIComfirmPassword";
            this.teUIComfirmPassword.Properties.PasswordChar = '0';
            this.teUIComfirmPassword.Size = new System.Drawing.Size(50, 20);
            this.teUIComfirmPassword.StyleController = this.layoutControl1;
            this.teUIComfirmPassword.TabIndex = 7;
            // 
            // peUIImage
            // 
            this.peUIImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.peUIImage.Location = new System.Drawing.Point(162, 12);
            this.peUIImage.MenuManager = this.ribbonControl1;
            this.peUIImage.Name = "peUIImage";
            this.peUIImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peUIImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peUIImage.Properties.ZoomAccelerationFactor = 1D;
            this.peUIImage.Size = new System.Drawing.Size(95, 92);
            this.peUIImage.StyleController = this.layoutControl1;
            this.peUIImage.TabIndex = 8;
            // 
            // sbChangePassword
            // 
            this.sbChangePassword.Location = new System.Drawing.Point(162, 108);
            this.sbChangePassword.Name = "sbChangePassword";
            this.sbChangePassword.Size = new System.Drawing.Size(95, 22);
            this.sbChangePassword.StyleController = this.layoutControl1;
            this.sbChangePassword.TabIndex = 9;
            this.sbChangePassword.Text = "Change Password";
            this.sbChangePassword.Click += new System.EventHandler(this.sbChangePassword_Click);
            // 
            // sbLogin
            // 
            this.sbLogin.Location = new System.Drawing.Point(12, 108);
            this.sbLogin.Name = "sbLogin";
            this.sbLogin.Size = new System.Drawing.Size(146, 22);
            this.sbLogin.StyleController = this.layoutControl1;
            this.sbLogin.TabIndex = 10;
            this.sbLogin.Text = "Login";
            this.sbLogin.Click += new System.EventHandler(this.sbLogin_Click);
            // 
            // layoutControlGroup22
            // 
            this.layoutControlGroup22.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup22.GroupBordersVisible = false;
            this.layoutControlGroup22.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem98,
            this.layoutControlItem99,
            this.lciNewPassword,
            this.lciComfirmPass,
            this.layoutControlItem104,
            this.lciChangePassword,
            this.lciImage});
            this.layoutControlGroup22.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup22.Name = "Root";
            this.layoutControlGroup22.Size = new System.Drawing.Size(269, 142);
            this.layoutControlGroup22.TextVisible = false;
            // 
            // layoutControlItem98
            // 
            this.layoutControlItem98.Control = this.teUIUsername;
            this.layoutControlItem98.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem98.Name = "layoutControlItem98";
            this.layoutControlItem98.Size = new System.Drawing.Size(150, 24);
            this.layoutControlItem98.Text = "User Name :";
            this.layoutControlItem98.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem99
            // 
            this.layoutControlItem99.Control = this.teUIPassword;
            this.layoutControlItem99.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem99.Name = "layoutControlItem99";
            this.layoutControlItem99.Size = new System.Drawing.Size(150, 24);
            this.layoutControlItem99.Text = "Password :";
            this.layoutControlItem99.TextSize = new System.Drawing.Size(93, 13);
            // 
            // lciNewPassword
            // 
            this.lciNewPassword.Control = this.teUINewPassword;
            this.lciNewPassword.Location = new System.Drawing.Point(0, 48);
            this.lciNewPassword.Name = "lciNewPassword";
            this.lciNewPassword.Size = new System.Drawing.Size(150, 24);
            this.lciNewPassword.Text = "New Password :";
            this.lciNewPassword.TextSize = new System.Drawing.Size(93, 13);
            this.lciNewPassword.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciComfirmPass
            // 
            this.lciComfirmPass.Control = this.teUIComfirmPassword;
            this.lciComfirmPass.Location = new System.Drawing.Point(0, 72);
            this.lciComfirmPass.Name = "lciComfirmPass";
            this.lciComfirmPass.Size = new System.Drawing.Size(150, 24);
            this.lciComfirmPass.Text = "Confirm Password :";
            this.lciComfirmPass.TextSize = new System.Drawing.Size(93, 13);
            this.lciComfirmPass.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem104
            // 
            this.layoutControlItem104.Control = this.sbLogin;
            this.layoutControlItem104.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem104.Name = "layoutControlItem104";
            this.layoutControlItem104.Size = new System.Drawing.Size(150, 26);
            this.layoutControlItem104.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem104.TextVisible = false;
            // 
            // lciChangePassword
            // 
            this.lciChangePassword.Control = this.sbChangePassword;
            this.lciChangePassword.Location = new System.Drawing.Point(150, 96);
            this.lciChangePassword.Name = "lciChangePassword";
            this.lciChangePassword.Size = new System.Drawing.Size(99, 26);
            this.lciChangePassword.TextSize = new System.Drawing.Size(0, 0);
            this.lciChangePassword.TextVisible = false;
            this.lciChangePassword.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciImage
            // 
            this.lciImage.Control = this.peUIImage;
            this.lciImage.Location = new System.Drawing.Point(150, 0);
            this.lciImage.Name = "lciImage";
            this.lciImage.Size = new System.Drawing.Size(99, 96);
            this.lciImage.TextSize = new System.Drawing.Size(0, 0);
            this.lciImage.TextVisible = false;
            this.lciImage.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "User Info";
            this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
            this.backstageViewTabItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("backstageViewTabItem1.Glyph")));
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            this.backstageViewTabItem1.Selected = true;
            // 
            // bvbLogout
            // 
            this.bvbLogout.Caption = "Logout";
            this.bvbLogout.Glyph = ((System.Drawing.Image)(resources.GetObject("bvbLogout.Glyph")));
            this.bvbLogout.Name = "bvbLogout";
            this.bvbLogout.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvbLogout_ItemClick);
            // 
            // backstageViewItemSeparator1
            // 
            this.backstageViewItemSeparator1.Name = "backstageViewItemSeparator1";
            // 
            // bsvBtnExit
            // 
            this.bsvBtnExit.Caption = "Exit";
            this.bsvBtnExit.Glyph = ((System.Drawing.Image)(resources.GetObject("bsvBtnExit.Glyph")));
            this.bsvBtnExit.Name = "bsvBtnExit";
            this.bsvBtnExit.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bsvBtnExit_ItemClick);
            // 
            // bbiNew
            // 
            this.bbiNew.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 1;
            this.bbiNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiNew.ImageOptions.Image")));
            this.bbiNew.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiNew.ImageOptions.LargeImage")));
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiSave
            // 
            this.bbiSave.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 17;
            this.bbiSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiSave.ImageOptions.Image")));
            this.bbiSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiSave.ImageOptions.LargeImage")));
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDelete.ImageOptions.Image")));
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HomePageButtonClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 19;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // bciEdit
            // 
            this.bciEdit.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bciEdit.Caption = "Edit";
            this.bciEdit.Id = 22;
            this.bciEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bciEdit.ImageOptions.Image")));
            this.bciEdit.Name = "bciEdit";
            this.bciEdit.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bciEdit_CheckedChanged);
            // 
            // bbiShowPrintDialog
            // 
            this.bbiShowPrintDialog.Caption = "Show Print Dialog";
            this.bbiShowPrintDialog.Id = 24;
            this.bbiShowPrintDialog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiShowPrintDialog.ImageOptions.Image")));
            this.bbiShowPrintDialog.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiShowPrintDialog.ImageOptions.LargeImage")));
            this.bbiShowPrintDialog.Name = "bbiShowPrintDialog";
            this.bbiShowPrintDialog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiShowPrintDialog_ItemClick);
            // 
            // bbiGenerateReport
            // 
            this.bbiGenerateReport.Caption = "Generate Reports";
            this.bbiGenerateReport.Id = 26;
            this.bbiGenerateReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiGenerateReport.ImageOptions.Image")));
            this.bbiGenerateReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiGenerateReport.ImageOptions.LargeImage")));
            this.bbiGenerateReport.Name = "bbiGenerateReport";
            this.bbiGenerateReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGenerateReport_ItemClick);
            // 
            // bciDetailView
            // 
            this.bciDetailView.Caption = "Detail View";
            this.bciDetailView.Id = 27;
            this.bciDetailView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bciDetailView.ImageOptions.Image")));
            this.bciDetailView.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bciDetailView.ImageOptions.LargeImage")));
            this.bciDetailView.Name = "bciDetailView";
            this.bciDetailView.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bciDetailView_CheckedChanged);
            // 
            // bciSelectAll
            // 
            this.bciSelectAll.Caption = "Select All";
            this.bciSelectAll.Id = 28;
            this.bciSelectAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bciSelectAll.ImageOptions.Image")));
            this.bciSelectAll.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bciSelectAll.ImageOptions.LargeImage")));
            this.bciSelectAll.Name = "bciSelectAll";
            this.bciSelectAll.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bciSelectAll_CheckedChanged);
            // 
            // bhiUserName
            // 
            this.bhiUserName.Caption = "Anonymous";
            this.bhiUserName.Id = 33;
            this.bhiUserName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bhiUserName.ImageOptions.Image")));
            this.bhiUserName.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bhiUserName.ImageOptions.LargeImage")));
            this.bhiUserName.Name = "bhiUserName";
            this.bhiUserName.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bhiUserName_ItemClick);
            // 
            // bhiCurrentPage
            // 
            this.bhiCurrentPage.Caption = "Current Page";
            this.bhiCurrentPage.Id = 34;
            this.bhiCurrentPage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bhiCurrentPage.ImageOptions.Image")));
            this.bhiCurrentPage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bhiCurrentPage.ImageOptions.LargeImage")));
            this.bhiCurrentPage.Name = "bhiCurrentPage";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Quick ToolBar";
            this.barHeaderItem1.Id = 35;
            this.barHeaderItem1.MultiColumn = DevExpress.Utils.DefaultBoolean.True;
            this.barHeaderItem1.Name = "barHeaderItem1";
            this.barHeaderItem1.OptionsMultiColumn.ColumnCount = 4;
            this.barHeaderItem1.OptionsMultiColumn.LargeImages = DevExpress.Utils.DefaultBoolean.True;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bciEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSave);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "File";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Appearance";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiShowPrintDialog);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiGenerateReport);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Print ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bciDetailView);
            this.ribbonPageGroup4.ItemLinks.Add(this.bciSelectAll);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Utilities";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.bbiNew);
            this.ribbonStatusBar1.ItemLinks.Add(this.bciEdit);
            this.ribbonStatusBar1.ItemLinks.Add(this.bbiSave);
            this.ribbonStatusBar1.ItemLinks.Add(this.bhiCurrentPage);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 523);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(866, 31);
            // 
            // gcCars
            // 
            this.gcCars.Location = new System.Drawing.Point(12, 221);
            this.gcCars.MainView = this.gvCars;
            this.gcCars.Name = "gcCars";
            this.gcCars.Size = new System.Drawing.Size(702, 102);
            this.gcCars.TabIndex = 9;
            this.gcCars.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCars});
            // 
            // gvCars
            // 
            this.gvCars.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn16});
            this.gvCars.GridControl = this.gcCars;
            this.gvCars.Name = "gvCars";
            this.gvCars.OptionsBehavior.Editable = false;
            this.gvCars.OptionsBehavior.ReadOnly = true;
            this.gvCars.OptionsCustomization.AllowRowSizing = true;
            this.gvCars.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCars.OptionsView.EnableAppearanceOddRow = true;
            this.gvCars.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewCars_SelectionChanged);
            this.gvCars.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "carID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Full Name";
            this.gridColumn2.FieldName = "carFName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Short Name";
            this.gridColumn3.FieldName = "carSName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Manufacturer";
            this.gridColumn5.FieldName = "cmfname";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Year";
            this.gridColumn6.FieldName = "carYear";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Remarks";
            this.gridColumn7.FieldName = "carRemarks";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Date Created";
            this.gridColumn8.FieldName = "carDateCreated";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Status";
            this.gridColumn9.FieldName = "carStatus";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 6;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Image";
            this.gridColumn10.FieldName = "carImage";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 7;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Created By";
            this.gridColumn16.FieldName = "FullName";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 8;
            // 
            // teCarFName
            // 
            this.teCarFName.EditValue = "";
            this.teCarFName.Location = new System.Drawing.Point(99, 64);
            this.teCarFName.Name = "teCarFName";
            this.teCarFName.Size = new System.Drawing.Size(409, 20);
            this.teCarFName.StyleController = this.lcCars;
            this.teCarFName.TabIndex = 0;
            // 
            // teCarSName
            // 
            this.teCarSName.Location = new System.Drawing.Point(99, 88);
            this.teCarSName.MenuManager = this.ribbonControl1;
            this.teCarSName.Name = "teCarSName";
            this.teCarSName.Size = new System.Drawing.Size(409, 20);
            this.teCarSName.StyleController = this.lcCars;
            this.teCarSName.TabIndex = 2;
            // 
            // peCarImage
            // 
            this.peCarImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.peCarImage.Location = new System.Drawing.Point(512, 64);
            this.peCarImage.MenuManager = this.ribbonControl1;
            this.peCarImage.Name = "peCarImage";
            this.peCarImage.Properties.InitialImage = ((System.Drawing.Image)(resources.GetObject("peCarImage.Properties.InitialImage")));
            this.peCarImage.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.RoundedRect;
            this.peCarImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peCarImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peCarImage.Properties.ZoomAccelerationFactor = 1D;
            this.peCarImage.Size = new System.Drawing.Size(190, 92);
            this.peCarImage.StyleController = this.lcCars;
            this.peCarImage.TabIndex = 1;
            // 
            // meCarRemarks
            // 
            this.meCarRemarks.Location = new System.Drawing.Point(99, 160);
            this.meCarRemarks.MenuManager = this.ribbonControl1;
            this.meCarRemarks.Name = "meCarRemarks";
            this.meCarRemarks.Size = new System.Drawing.Size(603, 16);
            this.meCarRemarks.StyleController = this.lcCars;
            this.meCarRemarks.TabIndex = 6;
            // 
            // deCarDateCreated
            // 
            this.deCarDateCreated.EditValue = new System.DateTime(2017, 7, 27, 13, 34, 35, 0);
            this.deCarDateCreated.Location = new System.Drawing.Point(99, 180);
            this.deCarDateCreated.MenuManager = this.ribbonControl1;
            this.deCarDateCreated.Name = "deCarDateCreated";
            this.deCarDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCarDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCarDateCreated.Size = new System.Drawing.Size(538, 20);
            this.deCarDateCreated.StyleController = this.lcCars;
            this.deCarDateCreated.TabIndex = 7;
            // 
            // ckeCarStatus
            // 
            this.ckeCarStatus.EditValue = true;
            this.ckeCarStatus.Location = new System.Drawing.Point(641, 180);
            this.ckeCarStatus.MenuManager = this.ribbonControl1;
            this.ckeCarStatus.Name = "ckeCarStatus";
            this.ckeCarStatus.Properties.Caption = "Active ?";
            this.ckeCarStatus.Size = new System.Drawing.Size(61, 19);
            this.ckeCarStatus.StyleController = this.lcCars;
            this.ckeCarStatus.TabIndex = 8;
            // 
            // deCarYear
            // 
            this.deCarYear.EditValue = new System.DateTime(2017, 7, 27, 14, 47, 17, 0);
            this.deCarYear.Location = new System.Drawing.Point(99, 136);
            this.deCarYear.MenuManager = this.ribbonControl1;
            this.deCarYear.Name = "deCarYear";
            this.deCarYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCarYear.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCarYear.Properties.DisplayFormat.FormatString = "yyy";
            this.deCarYear.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deCarYear.Properties.EditFormat.FormatString = "yyy";
            this.deCarYear.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.deCarYear.Properties.Mask.EditMask = "yyy";
            this.deCarYear.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.deCarYear.Size = new System.Drawing.Size(409, 20);
            this.deCarYear.StyleController = this.lcCars;
            this.deCarYear.TabIndex = 5;
            // 
            // lcgCars
            // 
            this.lcgCars.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgCars.GroupBordersVisible = false;
            this.lcgCars.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.lcgCarDetail,
            this.splitterItem1});
            this.lcgCars.Location = new System.Drawing.Point(0, 0);
            this.lcgCars.Name = "lcgCars";
            this.lcgCars.Size = new System.Drawing.Size(726, 335);
            this.lcgCars.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcCars;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 209);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(706, 106);
            this.layoutControlItem2.Text = "Detail View";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // lcgCarDetail
            // 
            this.lcgCarDetail.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgCarDetail.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgCarDetail.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgCarDetail.CaptionImage")));
            this.lcgCarDetail.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem8,
            this.layoutControlItem6});
            this.lcgCarDetail.Location = new System.Drawing.Point(0, 0);
            this.lcgCarDetail.Name = "lcgCarDetail";
            this.lcgCarDetail.Size = new System.Drawing.Size(706, 204);
            this.lcgCarDetail.Text = "Car Details";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.teCarFName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(488, 24);
            this.layoutControlItem1.Text = "Full Name :";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.teCarSName;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(488, 24);
            this.layoutControlItem5.Text = "Short Name :";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.meCarRemarks;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(682, 20);
            this.layoutControlItem9.Text = "Remarks :";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.deCarDateCreated;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 116);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem10.Text = "Date Created :";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.ckeCarStatus;
            this.layoutControlItem11.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem11.Location = new System.Drawing.Point(617, 116);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(65, 24);
            this.layoutControlItem11.Text = "Status";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.deCarYear;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(488, 24);
            this.layoutControlItem12.Text = "Year :";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.peCarImage;
            this.layoutControlItem8.Location = new System.Drawing.Point(488, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(194, 96);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.leCarManufacturer;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(488, 24);
            this.layoutControlItem6.Text = "Manufacturer :";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(72, 13);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(0, 204);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(706, 5);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Controls.Add(this.lcCarManufacturer);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(726, 335);
            this.navigationPage2.Tag = "Car Manufacturers";
            // 
            // lcCarManufacturer
            // 
            this.lcCarManufacturer.Controls.Add(this.gcCarManufacturer);
            this.lcCarManufacturer.Controls.Add(this.teCMFname);
            this.lcCarManufacturer.Controls.Add(this.teCMSName);
            this.lcCarManufacturer.Controls.Add(this.meCMRemarks);
            this.lcCarManufacturer.Controls.Add(this.deCMDateCreated);
            this.lcCarManufacturer.Controls.Add(this.ckeCMStatus);
            this.lcCarManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcCarManufacturer.Location = new System.Drawing.Point(0, 0);
            this.lcCarManufacturer.Name = "lcCarManufacturer";
            this.lcCarManufacturer.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(640, 283, 450, 400);
            this.lcCarManufacturer.Root = this.layoutControlGroup3;
            this.lcCarManufacturer.Size = new System.Drawing.Size(726, 335);
            this.lcCarManufacturer.TabIndex = 0;
            this.lcCarManufacturer.Text = "layoutControl2";
            // 
            // gcCarManufacturer
            // 
            this.gcCarManufacturer.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gcCarManufacturer.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gcCarManufacturer_EmbeddedNavigator_ButtonClick);
            this.gcCarManufacturer.Location = new System.Drawing.Point(12, 173);
            this.gcCarManufacturer.MainView = this.gvCarManufacturer;
            this.gcCarManufacturer.Name = "gcCarManufacturer";
            this.gcCarManufacturer.Size = new System.Drawing.Size(702, 150);
            this.gcCarManufacturer.TabIndex = 6;
            this.gcCarManufacturer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCarManufacturer});
            // 
            // gvCarManufacturer
            // 
            this.gvCarManufacturer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn18,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn17});
            this.gvCarManufacturer.GridControl = this.gcCarManufacturer;
            this.gvCarManufacturer.Name = "gvCarManufacturer";
            this.gvCarManufacturer.OptionsBehavior.Editable = false;
            this.gvCarManufacturer.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "ID";
            this.gridColumn18.FieldName = "cmID";
            this.gridColumn18.Name = "gridColumn18";
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Full Name";
            this.gridColumn11.FieldName = "cmFName";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Short Name";
            this.gridColumn12.FieldName = "cmSName";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Remarks";
            this.gridColumn13.FieldName = "cmRemarks";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Date Created";
            this.gridColumn14.FieldName = "cmDateCreated";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 3;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Status";
            this.gridColumn15.FieldName = "cmStatus";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 4;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Created By";
            this.gridColumn17.FieldName = "FullName";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 5;
            // 
            // teCMFname
            // 
            this.teCMFname.Location = new System.Drawing.Point(99, 64);
            this.teCMFname.Name = "teCMFname";
            this.teCMFname.Size = new System.Drawing.Size(603, 20);
            this.teCMFname.StyleController = this.lcCarManufacturer;
            this.teCMFname.TabIndex = 0;
            // 
            // teCMSName
            // 
            this.teCMSName.Location = new System.Drawing.Point(99, 88);
            this.teCMSName.MenuManager = this.ribbonControl1;
            this.teCMSName.Name = "teCMSName";
            this.teCMSName.Size = new System.Drawing.Size(603, 20);
            this.teCMSName.StyleController = this.lcCarManufacturer;
            this.teCMSName.TabIndex = 2;
            // 
            // meCMRemarks
            // 
            this.meCMRemarks.Location = new System.Drawing.Point(99, 112);
            this.meCMRemarks.MenuManager = this.ribbonControl1;
            this.meCMRemarks.Name = "meCMRemarks";
            this.meCMRemarks.Size = new System.Drawing.Size(603, 16);
            this.meCMRemarks.StyleController = this.lcCarManufacturer;
            this.meCMRemarks.TabIndex = 3;
            this.meCMRemarks.EditValueChanged += new System.EventHandler(this.memoEdit1_EditValueChanged);
            // 
            // deCMDateCreated
            // 
            this.deCMDateCreated.EditValue = new System.DateTime(2017, 7, 28, 10, 48, 22, 0);
            this.deCMDateCreated.Location = new System.Drawing.Point(99, 132);
            this.deCMDateCreated.MenuManager = this.ribbonControl1;
            this.deCMDateCreated.Name = "deCMDateCreated";
            this.deCMDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCMDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCMDateCreated.Size = new System.Drawing.Size(538, 20);
            this.deCMDateCreated.StyleController = this.lcCarManufacturer;
            this.deCMDateCreated.TabIndex = 4;
            this.deCMDateCreated.EditValueChanged += new System.EventHandler(this.deCMDateCreated_EditValueChanged);
            // 
            // ckeCMStatus
            // 
            this.ckeCMStatus.EditValue = true;
            this.ckeCMStatus.Location = new System.Drawing.Point(641, 132);
            this.ckeCMStatus.MenuManager = this.ribbonControl1;
            this.ckeCMStatus.Name = "ckeCMStatus";
            this.ckeCMStatus.Properties.Caption = "Active ?";
            this.ckeCMStatus.Size = new System.Drawing.Size(61, 19);
            this.ckeCMStatus.StyleController = this.lcCarManufacturer;
            this.ckeCMStatus.TabIndex = 5;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.lcgCarMan,
            this.splitterItem2});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "Root";
            this.layoutControlGroup3.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gcCarManufacturer;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 161);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(706, 154);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // lcgCarMan
            // 
            this.lcgCarMan.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgCarMan.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgCarMan.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgCarMan.CaptionImage")));
            this.lcgCarMan.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem13,
            this.layoutControlItem14,
            this.layoutControlItem15,
            this.layoutControlItem16});
            this.lcgCarMan.Location = new System.Drawing.Point(0, 0);
            this.lcgCarMan.Name = "lcgCarMan";
            this.lcgCarMan.Size = new System.Drawing.Size(706, 156);
            this.lcgCarMan.Text = "Car Manufacturer Details";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.teCMFname;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem3.Text = "Full Name :";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.teCMSName;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem13.Text = "Short Name :";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.meCMRemarks;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(682, 20);
            this.layoutControlItem14.Text = "Remarks :";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.deCMDateCreated;
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem15.Text = "Date Created :";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.ckeCMStatus;
            this.layoutControlItem16.Location = new System.Drawing.Point(617, 68);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(65, 24);
            this.layoutControlItem16.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem16.TextVisible = false;
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.Location = new System.Drawing.Point(0, 156);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(706, 5);
            // 
            // navigationPage3
            // 
            this.navigationPage3.Controls.Add(this.lcProduct);
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(726, 335);
            this.navigationPage3.Tag = "Products N Services";
            // 
            // lcProduct
            // 
            this.lcProduct.Controls.Add(this.gcProducts);
            this.lcProduct.Controls.Add(this.tePdFName);
            this.lcProduct.Controls.Add(this.tePdUnitPrice);
            this.lcProduct.Controls.Add(this.tePdSName);
            this.lcProduct.Controls.Add(this.mePdRemarks);
            this.lcProduct.Controls.Add(this.dePdDateCreated);
            this.lcProduct.Controls.Add(this.ckePdStatus);
            this.lcProduct.Controls.Add(this.sePdVatRate);
            this.lcProduct.Controls.Add(this.sePdTaxRate);
            this.lcProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcProduct.Location = new System.Drawing.Point(0, 0);
            this.lcProduct.Name = "lcProduct";
            this.lcProduct.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(868, 291, 450, 400);
            this.lcProduct.Root = this.layoutControlGroup5;
            this.lcProduct.Size = new System.Drawing.Size(726, 335);
            this.lcProduct.TabIndex = 0;
            this.lcProduct.Text = "layoutControl1";
            // 
            // gcProducts
            // 
            this.gcProducts.Location = new System.Drawing.Point(12, 197);
            this.gcProducts.MainView = this.gvProducts;
            this.gcProducts.MenuManager = this.ribbonControl1;
            this.gcProducts.Name = "gcProducts";
            this.gcProducts.Size = new System.Drawing.Size(702, 126);
            this.gcProducts.TabIndex = 9;
            this.gcProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProducts});
            // 
            // gvProducts
            // 
            this.gvProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn54,
            this.gridColumn53,
            this.gridColumn23,
            this.gridColumn24,
            this.gridColumn25,
            this.gridColumn26});
            this.gvProducts.GridControl = this.gcProducts;
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.OptionsBehavior.Editable = false;
            this.gvProducts.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "ID";
            this.gridColumn19.FieldName = "pdID";
            this.gridColumn19.Name = "gridColumn19";
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Full Name";
            this.gridColumn20.FieldName = "pdFName";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 0;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Short Name";
            this.gridColumn21.FieldName = "pdSName";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 1;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Unit Price";
            this.gridColumn22.DisplayFormat.FormatString = "GHC {0}";
            this.gridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn22.FieldName = "ppUnitPrice";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 2;
            // 
            // gridColumn54
            // 
            this.gridColumn54.Caption = "Tax Rate";
            this.gridColumn54.DisplayFormat.FormatString = "{0}%";
            this.gridColumn54.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn54.FieldName = "ppTaxRate";
            this.gridColumn54.Name = "gridColumn54";
            this.gridColumn54.Visible = true;
            this.gridColumn54.VisibleIndex = 3;
            // 
            // gridColumn53
            // 
            this.gridColumn53.Caption = "VAT Rate";
            this.gridColumn53.DisplayFormat.FormatString = "{0}%";
            this.gridColumn53.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn53.FieldName = "ppVatRate";
            this.gridColumn53.Name = "gridColumn53";
            this.gridColumn53.Visible = true;
            this.gridColumn53.VisibleIndex = 4;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "Remarks";
            this.gridColumn23.FieldName = "pdRemarks";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 5;
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "Date Created";
            this.gridColumn24.FieldName = "pdDateCreated";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 6;
            // 
            // gridColumn25
            // 
            this.gridColumn25.Caption = "Status";
            this.gridColumn25.FieldName = "pdStatus";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 7;
            // 
            // gridColumn26
            // 
            this.gridColumn26.Caption = "Created By";
            this.gridColumn26.FieldName = "FullName";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 8;
            // 
            // tePdFName
            // 
            this.tePdFName.Location = new System.Drawing.Point(99, 64);
            this.tePdFName.MenuManager = this.ribbonControl1;
            this.tePdFName.Name = "tePdFName";
            this.tePdFName.Size = new System.Drawing.Size(603, 20);
            this.tePdFName.StyleController = this.lcProduct;
            this.tePdFName.TabIndex = 0;
            // 
            // tePdUnitPrice
            // 
            this.tePdUnitPrice.Location = new System.Drawing.Point(441, 88);
            this.tePdUnitPrice.MenuManager = this.ribbonControl1;
            this.tePdUnitPrice.Name = "tePdUnitPrice";
            this.tePdUnitPrice.Size = new System.Drawing.Size(261, 20);
            this.tePdUnitPrice.StyleController = this.lcProduct;
            this.tePdUnitPrice.TabIndex = 3;
            // 
            // tePdSName
            // 
            this.tePdSName.Location = new System.Drawing.Point(99, 88);
            this.tePdSName.MenuManager = this.ribbonControl1;
            this.tePdSName.Name = "tePdSName";
            this.tePdSName.Size = new System.Drawing.Size(263, 20);
            this.tePdSName.StyleController = this.lcProduct;
            this.tePdSName.TabIndex = 2;
            // 
            // mePdRemarks
            // 
            this.mePdRemarks.Location = new System.Drawing.Point(99, 136);
            this.mePdRemarks.MenuManager = this.ribbonControl1;
            this.mePdRemarks.Name = "mePdRemarks";
            this.mePdRemarks.Size = new System.Drawing.Size(603, 16);
            this.mePdRemarks.StyleController = this.lcProduct;
            this.mePdRemarks.TabIndex = 6;
            // 
            // dePdDateCreated
            // 
            this.dePdDateCreated.EditValue = new System.DateTime(2017, 7, 28, 20, 56, 37, 0);
            this.dePdDateCreated.Location = new System.Drawing.Point(99, 156);
            this.dePdDateCreated.MenuManager = this.ribbonControl1;
            this.dePdDateCreated.Name = "dePdDateCreated";
            this.dePdDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePdDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePdDateCreated.Size = new System.Drawing.Size(538, 20);
            this.dePdDateCreated.StyleController = this.lcProduct;
            this.dePdDateCreated.TabIndex = 7;
            // 
            // ckePdStatus
            // 
            this.ckePdStatus.EditValue = true;
            this.ckePdStatus.Location = new System.Drawing.Point(641, 156);
            this.ckePdStatus.MenuManager = this.ribbonControl1;
            this.ckePdStatus.Name = "ckePdStatus";
            this.ckePdStatus.Properties.Caption = "Active ?";
            this.ckePdStatus.Size = new System.Drawing.Size(61, 19);
            this.ckePdStatus.StyleController = this.lcProduct;
            this.ckePdStatus.TabIndex = 8;
            // 
            // sePdVatRate
            // 
            this.sePdVatRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePdVatRate.Location = new System.Drawing.Point(441, 112);
            this.sePdVatRate.MenuManager = this.ribbonControl1;
            this.sePdVatRate.Name = "sePdVatRate";
            this.sePdVatRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePdVatRate.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.sePdVatRate.Size = new System.Drawing.Size(261, 20);
            this.sePdVatRate.StyleController = this.lcProduct;
            this.sePdVatRate.TabIndex = 5;
            // 
            // sePdTaxRate
            // 
            this.sePdTaxRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePdTaxRate.Location = new System.Drawing.Point(99, 112);
            this.sePdTaxRate.MenuManager = this.ribbonControl1;
            this.sePdTaxRate.Name = "sePdTaxRate";
            this.sePdTaxRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePdTaxRate.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.sePdTaxRate.Size = new System.Drawing.Size(263, 20);
            this.sePdTaxRate.StyleController = this.lcProduct;
            this.sePdTaxRate.TabIndex = 4;
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup5.GroupBordersVisible = false;
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgPNS,
            this.splitterItem3,
            this.layoutControlItem23});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "Root";
            this.layoutControlGroup5.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup5.TextVisible = false;
            // 
            // lcgPNS
            // 
            this.lcgPNS.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgPNS.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgPNS.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgPNS.CaptionImage")));
            this.lcgPNS.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem17,
            this.layoutControlItem21,
            this.layoutControlItem22,
            this.layoutControlItem53,
            this.layoutControlItem52,
            this.layoutControlItem20,
            this.layoutControlItem19,
            this.layoutControlItem18});
            this.lcgPNS.Location = new System.Drawing.Point(0, 0);
            this.lcgPNS.Name = "lcgPNS";
            this.lcgPNS.Size = new System.Drawing.Size(706, 180);
            this.lcgPNS.Text = "Product N Services Detail";
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.tePdFName;
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem17.Name = "layoutControlItem17";
            this.layoutControlItem17.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem17.Text = "Full Name :";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.dePdDateCreated;
            this.layoutControlItem21.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem21.Text = "Date Created :";
            this.layoutControlItem21.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.Control = this.ckePdStatus;
            this.layoutControlItem22.Location = new System.Drawing.Point(617, 92);
            this.layoutControlItem22.Name = "layoutControlItem22";
            this.layoutControlItem22.Size = new System.Drawing.Size(65, 24);
            this.layoutControlItem22.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem22.TextVisible = false;
            // 
            // layoutControlItem53
            // 
            this.layoutControlItem53.Control = this.sePdTaxRate;
            this.layoutControlItem53.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem53.Name = "layoutControlItem53";
            this.layoutControlItem53.Size = new System.Drawing.Size(342, 24);
            this.layoutControlItem53.Text = "Tax Rate :";
            this.layoutControlItem53.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem52
            // 
            this.layoutControlItem52.Control = this.sePdVatRate;
            this.layoutControlItem52.Location = new System.Drawing.Point(342, 48);
            this.layoutControlItem52.Name = "layoutControlItem52";
            this.layoutControlItem52.Size = new System.Drawing.Size(340, 24);
            this.layoutControlItem52.Text = "VAT Rate :";
            this.layoutControlItem52.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.mePdRemarks;
            this.layoutControlItem20.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem20.Name = "layoutControlItem20";
            this.layoutControlItem20.Size = new System.Drawing.Size(682, 20);
            this.layoutControlItem20.Text = "Remarks :";
            this.layoutControlItem20.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.tePdSName;
            this.layoutControlItem19.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem19.Name = "layoutControlItem19";
            this.layoutControlItem19.Size = new System.Drawing.Size(342, 24);
            this.layoutControlItem19.Text = "Short Name :";
            this.layoutControlItem19.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.tePdUnitPrice;
            this.layoutControlItem18.Location = new System.Drawing.Point(342, 24);
            this.layoutControlItem18.Name = "layoutControlItem18";
            this.layoutControlItem18.Size = new System.Drawing.Size(340, 24);
            this.layoutControlItem18.Text = "Unit Price :";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(72, 13);
            // 
            // splitterItem3
            // 
            this.splitterItem3.AllowHotTrack = true;
            this.splitterItem3.Location = new System.Drawing.Point(0, 180);
            this.splitterItem3.Name = "splitterItem3";
            this.splitterItem3.Size = new System.Drawing.Size(706, 5);
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.Control = this.gcProducts;
            this.layoutControlItem23.Location = new System.Drawing.Point(0, 185);
            this.layoutControlItem23.Name = "layoutControlItem23";
            this.layoutControlItem23.Size = new System.Drawing.Size(706, 130);
            this.layoutControlItem23.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem23.TextVisible = false;
            // 
            // navigationPage4
            // 
            this.navigationPage4.Controls.Add(this.lcTitle);
            this.navigationPage4.Name = "navigationPage4";
            this.navigationPage4.Size = new System.Drawing.Size(726, 335);
            this.navigationPage4.Tag = "Titles";
            // 
            // lcTitle
            // 
            this.lcTitle.Controls.Add(this.gcTittles);
            this.lcTitle.Controls.Add(this.teTFName);
            this.lcTitle.Controls.Add(this.teTSName);
            this.lcTitle.Controls.Add(this.meTRemarks);
            this.lcTitle.Controls.Add(this.deTDateCreated);
            this.lcTitle.Controls.Add(this.ckeTStatus);
            this.lcTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcTitle.Location = new System.Drawing.Point(0, 0);
            this.lcTitle.Name = "lcTitle";
            this.lcTitle.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(640, 351, 450, 400);
            this.lcTitle.Root = this.layoutControlGroup7;
            this.lcTitle.Size = new System.Drawing.Size(726, 335);
            this.lcTitle.TabIndex = 0;
            this.lcTitle.Text = "layoutControl3";
            // 
            // gcTittles
            // 
            this.gcTittles.Location = new System.Drawing.Point(12, 178);
            this.gcTittles.MainView = this.gvTitles;
            this.gcTittles.MenuManager = this.ribbonControl1;
            this.gcTittles.Name = "gcTittles";
            this.gcTittles.Size = new System.Drawing.Size(702, 145);
            this.gcTittles.TabIndex = 6;
            this.gcTittles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTitles});
            // 
            // gvTitles
            // 
            this.gvTitles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn27,
            this.gridColumn28,
            this.gridColumn29,
            this.gridColumn30,
            this.gridColumn31,
            this.gridColumn32,
            this.gridColumn33});
            this.gvTitles.GridControl = this.gcTittles;
            this.gvTitles.Name = "gvTitles";
            this.gvTitles.OptionsBehavior.Editable = false;
            this.gvTitles.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn27
            // 
            this.gridColumn27.Caption = "ID";
            this.gridColumn27.FieldName = "tID";
            this.gridColumn27.Name = "gridColumn27";
            // 
            // gridColumn28
            // 
            this.gridColumn28.Caption = "Full Name";
            this.gridColumn28.FieldName = "tFName";
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.Visible = true;
            this.gridColumn28.VisibleIndex = 0;
            // 
            // gridColumn29
            // 
            this.gridColumn29.Caption = "Short Name";
            this.gridColumn29.FieldName = "tSName";
            this.gridColumn29.Name = "gridColumn29";
            this.gridColumn29.Visible = true;
            this.gridColumn29.VisibleIndex = 1;
            // 
            // gridColumn30
            // 
            this.gridColumn30.Caption = "Remarks";
            this.gridColumn30.FieldName = "tRemarks";
            this.gridColumn30.Name = "gridColumn30";
            this.gridColumn30.Visible = true;
            this.gridColumn30.VisibleIndex = 2;
            // 
            // gridColumn31
            // 
            this.gridColumn31.Caption = "Date Created";
            this.gridColumn31.FieldName = "tDateCreated";
            this.gridColumn31.Name = "gridColumn31";
            this.gridColumn31.Visible = true;
            this.gridColumn31.VisibleIndex = 3;
            // 
            // gridColumn32
            // 
            this.gridColumn32.Caption = "Status";
            this.gridColumn32.FieldName = "tStatus";
            this.gridColumn32.Name = "gridColumn32";
            this.gridColumn32.Visible = true;
            this.gridColumn32.VisibleIndex = 4;
            // 
            // gridColumn33
            // 
            this.gridColumn33.Caption = "Created By";
            this.gridColumn33.FieldName = "FullName";
            this.gridColumn33.Name = "gridColumn33";
            this.gridColumn33.Visible = true;
            this.gridColumn33.VisibleIndex = 5;
            // 
            // teTFName
            // 
            this.teTFName.Location = new System.Drawing.Point(99, 64);
            this.teTFName.MenuManager = this.ribbonControl1;
            this.teTFName.Name = "teTFName";
            this.teTFName.Size = new System.Drawing.Size(603, 20);
            this.teTFName.StyleController = this.lcTitle;
            this.teTFName.TabIndex = 0;
            // 
            // teTSName
            // 
            this.teTSName.Location = new System.Drawing.Point(99, 88);
            this.teTSName.MenuManager = this.ribbonControl1;
            this.teTSName.Name = "teTSName";
            this.teTSName.Size = new System.Drawing.Size(603, 20);
            this.teTSName.StyleController = this.lcTitle;
            this.teTSName.TabIndex = 2;
            // 
            // meTRemarks
            // 
            this.meTRemarks.Location = new System.Drawing.Point(99, 112);
            this.meTRemarks.MenuManager = this.ribbonControl1;
            this.meTRemarks.Name = "meTRemarks";
            this.meTRemarks.Size = new System.Drawing.Size(603, 21);
            this.meTRemarks.StyleController = this.lcTitle;
            this.meTRemarks.TabIndex = 3;
            // 
            // deTDateCreated
            // 
            this.deTDateCreated.EditValue = new System.DateTime(2017, 7, 31, 16, 25, 1, 0);
            this.deTDateCreated.Location = new System.Drawing.Point(99, 137);
            this.deTDateCreated.MenuManager = this.ribbonControl1;
            this.deTDateCreated.Name = "deTDateCreated";
            this.deTDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTDateCreated.Size = new System.Drawing.Size(538, 20);
            this.deTDateCreated.StyleController = this.lcTitle;
            this.deTDateCreated.TabIndex = 4;
            // 
            // ckeTStatus
            // 
            this.ckeTStatus.EditValue = true;
            this.ckeTStatus.Location = new System.Drawing.Point(641, 137);
            this.ckeTStatus.MenuManager = this.ribbonControl1;
            this.ckeTStatus.Name = "ckeTStatus";
            this.ckeTStatus.Properties.Caption = "Active ?";
            this.ckeTStatus.Size = new System.Drawing.Size(61, 19);
            this.ckeTStatus.StyleController = this.lcTitle;
            this.ckeTStatus.TabIndex = 5;
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup7.GroupBordersVisible = false;
            this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgTitle,
            this.layoutControlItem29,
            this.splitterItem4});
            this.layoutControlGroup7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup7.Name = "Root";
            this.layoutControlGroup7.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup7.TextVisible = false;
            // 
            // lcgTitle
            // 
            this.lcgTitle.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgTitle.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgTitle.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgTitle.CaptionImage")));
            this.lcgTitle.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem24,
            this.layoutControlItem25,
            this.layoutControlItem26,
            this.layoutControlItem27,
            this.layoutControlItem28});
            this.lcgTitle.Location = new System.Drawing.Point(0, 0);
            this.lcgTitle.Name = "lcgTitle";
            this.lcgTitle.Size = new System.Drawing.Size(706, 161);
            this.lcgTitle.Text = "Title Details";
            // 
            // layoutControlItem24
            // 
            this.layoutControlItem24.Control = this.teTFName;
            this.layoutControlItem24.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem24.Name = "layoutControlItem24";
            this.layoutControlItem24.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem24.Text = "Full Name :";
            this.layoutControlItem24.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.Control = this.teTSName;
            this.layoutControlItem25.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem25.Name = "layoutControlItem25";
            this.layoutControlItem25.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem25.Text = "Short Name :";
            this.layoutControlItem25.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.Control = this.meTRemarks;
            this.layoutControlItem26.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem26.Name = "layoutControlItem26";
            this.layoutControlItem26.Size = new System.Drawing.Size(682, 25);
            this.layoutControlItem26.Text = "Remarks :";
            this.layoutControlItem26.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem27
            // 
            this.layoutControlItem27.Control = this.deTDateCreated;
            this.layoutControlItem27.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem27.Name = "layoutControlItem27";
            this.layoutControlItem27.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem27.Text = "Date Created :";
            this.layoutControlItem27.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem28
            // 
            this.layoutControlItem28.Control = this.ckeTStatus;
            this.layoutControlItem28.Location = new System.Drawing.Point(617, 73);
            this.layoutControlItem28.Name = "layoutControlItem28";
            this.layoutControlItem28.Size = new System.Drawing.Size(65, 24);
            this.layoutControlItem28.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem28.TextVisible = false;
            // 
            // layoutControlItem29
            // 
            this.layoutControlItem29.Control = this.gcTittles;
            this.layoutControlItem29.Location = new System.Drawing.Point(0, 166);
            this.layoutControlItem29.Name = "layoutControlItem29";
            this.layoutControlItem29.Size = new System.Drawing.Size(706, 149);
            this.layoutControlItem29.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem29.TextVisible = false;
            // 
            // splitterItem4
            // 
            this.splitterItem4.AllowHotTrack = true;
            this.splitterItem4.Location = new System.Drawing.Point(0, 161);
            this.splitterItem4.Name = "splitterItem4";
            this.splitterItem4.Size = new System.Drawing.Size(706, 5);
            // 
            // navigationPage5
            // 
            this.navigationPage5.Controls.Add(this.lcCustomers);
            this.navigationPage5.Name = "navigationPage5";
            this.navigationPage5.Size = new System.Drawing.Size(726, 335);
            this.navigationPage5.Tag = "Customers";
            // 
            // lcCustomers
            // 
            this.lcCustomers.Controls.Add(this.gcCustomers);
            this.lcCustomers.Controls.Add(this.leCDTitle);
            this.lcCustomers.Controls.Add(this.teCDFName);
            this.lcCustomers.Controls.Add(this.teCDPhone);
            this.lcCustomers.Controls.Add(this.teCDSName);
            this.lcCustomers.Controls.Add(this.teCDID);
            this.lcCustomers.Controls.Add(this.teCDAddress);
            this.lcCustomers.Controls.Add(this.meCDRemarks);
            this.lcCustomers.Controls.Add(this.ckeCDStatus);
            this.lcCustomers.Controls.Add(this.deCDDateCreated);
            this.lcCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcCustomers.Location = new System.Drawing.Point(0, 0);
            this.lcCustomers.Name = "lcCustomers";
            this.lcCustomers.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(647, 199, 450, 400);
            this.lcCustomers.Root = this.layoutControlGroup9;
            this.lcCustomers.Size = new System.Drawing.Size(726, 335);
            this.lcCustomers.TabIndex = 0;
            this.lcCustomers.Text = "layoutControl4";
            // 
            // gcCustomers
            // 
            this.gcCustomers.Location = new System.Drawing.Point(12, 221);
            this.gcCustomers.MainView = this.gvCustomers;
            this.gcCustomers.MenuManager = this.ribbonControl1;
            this.gcCustomers.Name = "gcCustomers";
            this.gcCustomers.Size = new System.Drawing.Size(702, 102);
            this.gcCustomers.TabIndex = 10;
            this.gcCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCustomers});
            // 
            // gvCustomers
            // 
            this.gvCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn34,
            this.gridColumn38,
            this.gridColumn35,
            this.gridColumn36,
            this.gridColumn37,
            this.gridColumn39,
            this.gridColumn40,
            this.gridColumn41,
            this.gridColumn42,
            this.gridColumn43,
            this.gridColumn74});
            this.gvCustomers.GridControl = this.gcCustomers;
            this.gvCustomers.Name = "gvCustomers";
            this.gvCustomers.OptionsBehavior.Editable = false;
            this.gvCustomers.OptionsBehavior.ReadOnly = true;
            this.gvCustomers.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn34
            // 
            this.gridColumn34.Caption = "ID";
            this.gridColumn34.FieldName = "cusID";
            this.gridColumn34.Name = "gridColumn34";
            // 
            // gridColumn38
            // 
            this.gridColumn38.Caption = "Title";
            this.gridColumn38.FieldName = "tFName";
            this.gridColumn38.Name = "gridColumn38";
            this.gridColumn38.Visible = true;
            this.gridColumn38.VisibleIndex = 0;
            // 
            // gridColumn35
            // 
            this.gridColumn35.Caption = "Full Name";
            this.gridColumn35.FieldName = "cusFName";
            this.gridColumn35.Name = "gridColumn35";
            this.gridColumn35.Visible = true;
            this.gridColumn35.VisibleIndex = 2;
            // 
            // gridColumn36
            // 
            this.gridColumn36.Caption = "Short Name";
            this.gridColumn36.FieldName = "cusSName";
            this.gridColumn36.Name = "gridColumn36";
            this.gridColumn36.Visible = true;
            this.gridColumn36.VisibleIndex = 3;
            // 
            // gridColumn37
            // 
            this.gridColumn37.Caption = "Customer ID";
            this.gridColumn37.FieldName = "cusCustomerID";
            this.gridColumn37.Name = "gridColumn37";
            this.gridColumn37.Visible = true;
            this.gridColumn37.VisibleIndex = 1;
            // 
            // gridColumn39
            // 
            this.gridColumn39.Caption = "Address";
            this.gridColumn39.FieldName = "cusAddress";
            this.gridColumn39.Name = "gridColumn39";
            this.gridColumn39.Visible = true;
            this.gridColumn39.VisibleIndex = 4;
            // 
            // gridColumn40
            // 
            this.gridColumn40.Caption = "Phone";
            this.gridColumn40.FieldName = "cusPhone";
            this.gridColumn40.Name = "gridColumn40";
            this.gridColumn40.Visible = true;
            this.gridColumn40.VisibleIndex = 5;
            // 
            // gridColumn41
            // 
            this.gridColumn41.Caption = "Remarks";
            this.gridColumn41.FieldName = "cusRemarks";
            this.gridColumn41.Name = "gridColumn41";
            this.gridColumn41.Visible = true;
            this.gridColumn41.VisibleIndex = 6;
            // 
            // gridColumn42
            // 
            this.gridColumn42.Caption = "Date Created";
            this.gridColumn42.FieldName = "cusDateCreated";
            this.gridColumn42.Name = "gridColumn42";
            this.gridColumn42.Visible = true;
            this.gridColumn42.VisibleIndex = 7;
            // 
            // gridColumn43
            // 
            this.gridColumn43.Caption = "Status";
            this.gridColumn43.FieldName = "cusStatus";
            this.gridColumn43.Name = "gridColumn43";
            this.gridColumn43.Visible = true;
            this.gridColumn43.VisibleIndex = 8;
            // 
            // gridColumn74
            // 
            this.gridColumn74.Caption = "Created By";
            this.gridColumn74.FieldName = "FullName";
            this.gridColumn74.Name = "gridColumn74";
            this.gridColumn74.Visible = true;
            this.gridColumn74.VisibleIndex = 9;
            // 
            // leCDTitle
            // 
            this.leCDTitle.Location = new System.Drawing.Point(572, 88);
            this.leCDTitle.MenuManager = this.ribbonControl1;
            this.leCDTitle.Name = "leCDTitle";
            this.leCDTitle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leCDTitle.Properties.NullText = "Select Title";
            this.leCDTitle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leCDTitle.Size = new System.Drawing.Size(130, 20);
            this.leCDTitle.StyleController = this.lcCustomers;
            this.leCDTitle.TabIndex = 4;
            // 
            // teCDFName
            // 
            this.teCDFName.Location = new System.Drawing.Point(99, 64);
            this.teCDFName.MenuManager = this.ribbonControl1;
            this.teCDFName.Name = "teCDFName";
            this.teCDFName.Size = new System.Drawing.Size(394, 20);
            this.teCDFName.StyleController = this.lcCustomers;
            this.teCDFName.TabIndex = 0;
            // 
            // teCDPhone
            // 
            this.teCDPhone.Location = new System.Drawing.Point(99, 136);
            this.teCDPhone.MenuManager = this.ribbonControl1;
            this.teCDPhone.Name = "teCDPhone";
            this.teCDPhone.Size = new System.Drawing.Size(603, 20);
            this.teCDPhone.StyleController = this.lcCustomers;
            this.teCDPhone.TabIndex = 6;
            // 
            // teCDSName
            // 
            this.teCDSName.Location = new System.Drawing.Point(99, 88);
            this.teCDSName.MenuManager = this.ribbonControl1;
            this.teCDSName.Name = "teCDSName";
            this.teCDSName.Size = new System.Drawing.Size(394, 20);
            this.teCDSName.StyleController = this.lcCustomers;
            this.teCDSName.TabIndex = 3;
            // 
            // teCDID
            // 
            this.teCDID.Location = new System.Drawing.Point(572, 64);
            this.teCDID.MenuManager = this.ribbonControl1;
            this.teCDID.Name = "teCDID";
            this.teCDID.Properties.ReadOnly = true;
            this.teCDID.Size = new System.Drawing.Size(130, 20);
            this.teCDID.StyleController = this.lcCustomers;
            this.teCDID.TabIndex = 2;
            // 
            // teCDAddress
            // 
            this.teCDAddress.Location = new System.Drawing.Point(99, 112);
            this.teCDAddress.MenuManager = this.ribbonControl1;
            this.teCDAddress.Name = "teCDAddress";
            this.teCDAddress.Size = new System.Drawing.Size(603, 20);
            this.teCDAddress.StyleController = this.lcCustomers;
            this.teCDAddress.TabIndex = 5;
            // 
            // meCDRemarks
            // 
            this.meCDRemarks.Location = new System.Drawing.Point(99, 160);
            this.meCDRemarks.MenuManager = this.ribbonControl1;
            this.meCDRemarks.Name = "meCDRemarks";
            this.meCDRemarks.Size = new System.Drawing.Size(603, 16);
            this.meCDRemarks.StyleController = this.lcCustomers;
            this.meCDRemarks.TabIndex = 7;
            // 
            // ckeCDStatus
            // 
            this.ckeCDStatus.EditValue = true;
            this.ckeCDStatus.Location = new System.Drawing.Point(641, 180);
            this.ckeCDStatus.MenuManager = this.ribbonControl1;
            this.ckeCDStatus.Name = "ckeCDStatus";
            this.ckeCDStatus.Properties.Caption = "Active ?";
            this.ckeCDStatus.Size = new System.Drawing.Size(61, 19);
            this.ckeCDStatus.StyleController = this.lcCustomers;
            this.ckeCDStatus.TabIndex = 9;
            // 
            // deCDDateCreated
            // 
            this.deCDDateCreated.EditValue = new System.DateTime(2017, 7, 31, 16, 24, 40, 0);
            this.deCDDateCreated.Location = new System.Drawing.Point(99, 180);
            this.deCDDateCreated.MenuManager = this.ribbonControl1;
            this.deCDDateCreated.Name = "deCDDateCreated";
            this.deCDDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCDDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCDDateCreated.Size = new System.Drawing.Size(538, 20);
            this.deCDDateCreated.StyleController = this.lcCustomers;
            this.deCDDateCreated.TabIndex = 8;
            // 
            // layoutControlGroup9
            // 
            this.layoutControlGroup9.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup9.GroupBordersVisible = false;
            this.layoutControlGroup9.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgCustomer,
            this.splitterItem5,
            this.layoutControlItem40});
            this.layoutControlGroup9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup9.Name = "Root";
            this.layoutControlGroup9.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup9.TextVisible = false;
            // 
            // lcgCustomer
            // 
            this.lcgCustomer.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgCustomer.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgCustomer.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgCustomer.CaptionImage")));
            this.lcgCustomer.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem30,
            this.layoutControlItem33,
            this.layoutControlItem35,
            this.layoutControlItem36,
            this.layoutControlItem38,
            this.layoutControlItem37,
            this.layoutControlItem34,
            this.layoutControlItem39,
            this.layoutControlItem31});
            this.lcgCustomer.Location = new System.Drawing.Point(0, 0);
            this.lcgCustomer.Name = "lcgCustomer";
            this.lcgCustomer.Size = new System.Drawing.Size(706, 204);
            this.lcgCustomer.Text = "Customer Details";
            // 
            // layoutControlItem30
            // 
            this.layoutControlItem30.Control = this.teCDFName;
            this.layoutControlItem30.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem30.Name = "layoutControlItem30";
            this.layoutControlItem30.Size = new System.Drawing.Size(473, 24);
            this.layoutControlItem30.Text = "Full Name :";
            this.layoutControlItem30.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem33
            // 
            this.layoutControlItem33.Control = this.teCDSName;
            this.layoutControlItem33.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem33.Name = "layoutControlItem33";
            this.layoutControlItem33.Size = new System.Drawing.Size(473, 24);
            this.layoutControlItem33.Text = "Short Name :";
            this.layoutControlItem33.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem35
            // 
            this.layoutControlItem35.Control = this.teCDAddress;
            this.layoutControlItem35.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem35.Name = "layoutControlItem35";
            this.layoutControlItem35.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem35.Text = "Address :";
            this.layoutControlItem35.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem36
            // 
            this.layoutControlItem36.Control = this.meCDRemarks;
            this.layoutControlItem36.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem36.Name = "layoutControlItem36";
            this.layoutControlItem36.Size = new System.Drawing.Size(682, 20);
            this.layoutControlItem36.Text = "Remarks :";
            this.layoutControlItem36.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem38
            // 
            this.layoutControlItem38.Control = this.deCDDateCreated;
            this.layoutControlItem38.Location = new System.Drawing.Point(0, 116);
            this.layoutControlItem38.Name = "layoutControlItem38";
            this.layoutControlItem38.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem38.Text = "Date Created :";
            this.layoutControlItem38.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem37
            // 
            this.layoutControlItem37.Control = this.ckeCDStatus;
            this.layoutControlItem37.Location = new System.Drawing.Point(617, 116);
            this.layoutControlItem37.Name = "layoutControlItem37";
            this.layoutControlItem37.Size = new System.Drawing.Size(65, 24);
            this.layoutControlItem37.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem37.TextVisible = false;
            // 
            // layoutControlItem34
            // 
            this.layoutControlItem34.Control = this.teCDID;
            this.layoutControlItem34.Location = new System.Drawing.Point(473, 0);
            this.layoutControlItem34.Name = "layoutControlItem34";
            this.layoutControlItem34.Size = new System.Drawing.Size(209, 24);
            this.layoutControlItem34.Text = "ID :";
            this.layoutControlItem34.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem39
            // 
            this.layoutControlItem39.Control = this.leCDTitle;
            this.layoutControlItem39.Location = new System.Drawing.Point(473, 24);
            this.layoutControlItem39.Name = "layoutControlItem39";
            this.layoutControlItem39.Size = new System.Drawing.Size(209, 24);
            this.layoutControlItem39.Text = "Title :";
            this.layoutControlItem39.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem31
            // 
            this.layoutControlItem31.Control = this.teCDPhone;
            this.layoutControlItem31.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem31.Name = "layoutControlItem31";
            this.layoutControlItem31.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem31.Text = "Phone :";
            this.layoutControlItem31.TextSize = new System.Drawing.Size(72, 13);
            // 
            // splitterItem5
            // 
            this.splitterItem5.AllowHotTrack = true;
            this.splitterItem5.Location = new System.Drawing.Point(0, 204);
            this.splitterItem5.Name = "splitterItem5";
            this.splitterItem5.Size = new System.Drawing.Size(706, 5);
            // 
            // layoutControlItem40
            // 
            this.layoutControlItem40.Control = this.gcCustomers;
            this.layoutControlItem40.Location = new System.Drawing.Point(0, 209);
            this.layoutControlItem40.Name = "layoutControlItem40";
            this.layoutControlItem40.Size = new System.Drawing.Size(706, 106);
            this.layoutControlItem40.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem40.TextVisible = false;
            // 
            // navigationPage6
            // 
            this.navigationPage6.Controls.Add(this.lcServiceType);
            this.navigationPage6.Name = "navigationPage6";
            this.navigationPage6.Size = new System.Drawing.Size(726, 335);
            this.navigationPage6.Tag = "Service Type";
            // 
            // lcServiceType
            // 
            this.lcServiceType.Controls.Add(this.gcServiceType);
            this.lcServiceType.Controls.Add(this.teSTFName);
            this.lcServiceType.Controls.Add(this.teSTSName);
            this.lcServiceType.Controls.Add(this.meSTRemarks);
            this.lcServiceType.Controls.Add(this.deSTDateCreated);
            this.lcServiceType.Controls.Add(this.ckeSTStatus);
            this.lcServiceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcServiceType.Location = new System.Drawing.Point(0, 0);
            this.lcServiceType.Name = "lcServiceType";
            this.lcServiceType.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(622, 85, 450, 400);
            this.lcServiceType.Root = this.layoutControlGroup12;
            this.lcServiceType.Size = new System.Drawing.Size(726, 335);
            this.lcServiceType.TabIndex = 6;
            this.lcServiceType.Text = "layoutControl6";
            // 
            // gcServiceType
            // 
            this.gcServiceType.Location = new System.Drawing.Point(12, 201);
            this.gcServiceType.MainView = this.gvServiceType;
            this.gcServiceType.MenuManager = this.ribbonControl1;
            this.gcServiceType.Name = "gcServiceType";
            this.gcServiceType.Size = new System.Drawing.Size(702, 122);
            this.gcServiceType.TabIndex = 6;
            this.gcServiceType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvServiceType});
            // 
            // gvServiceType
            // 
            this.gvServiceType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn45,
            this.gridColumn46,
            this.gridColumn47,
            this.gridColumn48,
            this.gridColumn49,
            this.gridColumn50,
            this.gridColumn51});
            this.gvServiceType.GridControl = this.gcServiceType;
            this.gvServiceType.Name = "gvServiceType";
            this.gvServiceType.OptionsBehavior.Editable = false;
            this.gvServiceType.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn45
            // 
            this.gridColumn45.Caption = "ID";
            this.gridColumn45.FieldName = "stID";
            this.gridColumn45.Name = "gridColumn45";
            // 
            // gridColumn46
            // 
            this.gridColumn46.Caption = "Full Name";
            this.gridColumn46.FieldName = "stFName";
            this.gridColumn46.Name = "gridColumn46";
            this.gridColumn46.Visible = true;
            this.gridColumn46.VisibleIndex = 0;
            // 
            // gridColumn47
            // 
            this.gridColumn47.Caption = "Short Name";
            this.gridColumn47.FieldName = "stSName";
            this.gridColumn47.Name = "gridColumn47";
            this.gridColumn47.Visible = true;
            this.gridColumn47.VisibleIndex = 1;
            // 
            // gridColumn48
            // 
            this.gridColumn48.Caption = "Remarks";
            this.gridColumn48.FieldName = "stRemarks";
            this.gridColumn48.Name = "gridColumn48";
            this.gridColumn48.Visible = true;
            this.gridColumn48.VisibleIndex = 2;
            // 
            // gridColumn49
            // 
            this.gridColumn49.Caption = "Date Created";
            this.gridColumn49.FieldName = "stDateCreated";
            this.gridColumn49.Name = "gridColumn49";
            this.gridColumn49.Visible = true;
            this.gridColumn49.VisibleIndex = 3;
            // 
            // gridColumn50
            // 
            this.gridColumn50.Caption = "Status";
            this.gridColumn50.FieldName = "stStatus";
            this.gridColumn50.Name = "gridColumn50";
            this.gridColumn50.Visible = true;
            this.gridColumn50.VisibleIndex = 4;
            // 
            // gridColumn51
            // 
            this.gridColumn51.Caption = "Created By";
            this.gridColumn51.FieldName = "FullName";
            this.gridColumn51.Name = "gridColumn51";
            this.gridColumn51.Visible = true;
            this.gridColumn51.VisibleIndex = 5;
            // 
            // teSTFName
            // 
            this.teSTFName.Location = new System.Drawing.Point(99, 64);
            this.teSTFName.MenuManager = this.ribbonControl1;
            this.teSTFName.Name = "teSTFName";
            this.teSTFName.Size = new System.Drawing.Size(603, 20);
            this.teSTFName.StyleController = this.lcServiceType;
            this.teSTFName.TabIndex = 0;
            // 
            // teSTSName
            // 
            this.teSTSName.Location = new System.Drawing.Point(99, 88);
            this.teSTSName.MenuManager = this.ribbonControl1;
            this.teSTSName.Name = "teSTSName";
            this.teSTSName.Size = new System.Drawing.Size(603, 20);
            this.teSTSName.StyleController = this.lcServiceType;
            this.teSTSName.TabIndex = 2;
            // 
            // meSTRemarks
            // 
            this.meSTRemarks.Location = new System.Drawing.Point(99, 112);
            this.meSTRemarks.MenuManager = this.ribbonControl1;
            this.meSTRemarks.Name = "meSTRemarks";
            this.meSTRemarks.Size = new System.Drawing.Size(603, 44);
            this.meSTRemarks.StyleController = this.lcServiceType;
            this.meSTRemarks.TabIndex = 3;
            // 
            // deSTDateCreated
            // 
            this.deSTDateCreated.EditValue = new System.DateTime(2017, 7, 31, 16, 24, 26, 0);
            this.deSTDateCreated.Location = new System.Drawing.Point(99, 160);
            this.deSTDateCreated.MenuManager = this.ribbonControl1;
            this.deSTDateCreated.Name = "deSTDateCreated";
            this.deSTDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deSTDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deSTDateCreated.Size = new System.Drawing.Size(538, 20);
            this.deSTDateCreated.StyleController = this.lcServiceType;
            this.deSTDateCreated.TabIndex = 4;
            // 
            // ckeSTStatus
            // 
            this.ckeSTStatus.EditValue = true;
            this.ckeSTStatus.Location = new System.Drawing.Point(641, 160);
            this.ckeSTStatus.MenuManager = this.ribbonControl1;
            this.ckeSTStatus.Name = "ckeSTStatus";
            this.ckeSTStatus.Properties.Caption = "Active ?";
            this.ckeSTStatus.Size = new System.Drawing.Size(61, 19);
            this.ckeSTStatus.StyleController = this.lcServiceType;
            this.ckeSTStatus.TabIndex = 5;
            // 
            // layoutControlGroup12
            // 
            this.layoutControlGroup12.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup12.GroupBordersVisible = false;
            this.layoutControlGroup12.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgServiceType,
            this.splitterItem6,
            this.layoutControlItem47});
            this.layoutControlGroup12.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup12.Name = "Root";
            this.layoutControlGroup12.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup12.TextVisible = false;
            // 
            // lcgServiceType
            // 
            this.lcgServiceType.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgServiceType.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgServiceType.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgServiceType.CaptionImage")));
            this.lcgServiceType.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem42,
            this.layoutControlItem43,
            this.layoutControlItem44,
            this.layoutControlItem45,
            this.layoutControlItem46});
            this.lcgServiceType.Location = new System.Drawing.Point(0, 0);
            this.lcgServiceType.Name = "lcgServiceType";
            this.lcgServiceType.Size = new System.Drawing.Size(706, 184);
            this.lcgServiceType.Text = "Service Type";
            // 
            // layoutControlItem42
            // 
            this.layoutControlItem42.Control = this.teSTFName;
            this.layoutControlItem42.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem42.Name = "layoutControlItem24";
            this.layoutControlItem42.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem42.Text = "Full Name :";
            this.layoutControlItem42.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem43
            // 
            this.layoutControlItem43.Control = this.teSTSName;
            this.layoutControlItem43.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem43.Name = "layoutControlItem25";
            this.layoutControlItem43.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem43.Text = "Short Name :";
            this.layoutControlItem43.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem44
            // 
            this.layoutControlItem44.Control = this.meSTRemarks;
            this.layoutControlItem44.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem44.Name = "layoutControlItem26";
            this.layoutControlItem44.Size = new System.Drawing.Size(682, 48);
            this.layoutControlItem44.Text = "Remarks :";
            this.layoutControlItem44.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem45
            // 
            this.layoutControlItem45.Control = this.deSTDateCreated;
            this.layoutControlItem45.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem45.Name = "layoutControlItem27";
            this.layoutControlItem45.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem45.Text = "Date Created :";
            this.layoutControlItem45.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem46
            // 
            this.layoutControlItem46.Control = this.ckeSTStatus;
            this.layoutControlItem46.Location = new System.Drawing.Point(617, 96);
            this.layoutControlItem46.Name = "layoutControlItem28";
            this.layoutControlItem46.Size = new System.Drawing.Size(65, 24);
            this.layoutControlItem46.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem46.TextVisible = false;
            // 
            // splitterItem6
            // 
            this.splitterItem6.AllowHotTrack = true;
            this.splitterItem6.Location = new System.Drawing.Point(0, 184);
            this.splitterItem6.Name = "splitterItem4";
            this.splitterItem6.Size = new System.Drawing.Size(706, 5);
            // 
            // layoutControlItem47
            // 
            this.layoutControlItem47.Control = this.gcServiceType;
            this.layoutControlItem47.Location = new System.Drawing.Point(0, 189);
            this.layoutControlItem47.Name = "layoutControlItem29";
            this.layoutControlItem47.Size = new System.Drawing.Size(706, 126);
            this.layoutControlItem47.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem47.TextVisible = false;
            // 
            // navigationPage7
            // 
            this.navigationPage7.Controls.Add(this.lcCarServicing);
            this.navigationPage7.Name = "navigationPage7";
            this.navigationPage7.Size = new System.Drawing.Size(726, 335);
            this.navigationPage7.Tag = "Daily Car Servicing";
            // 
            // lcCarServicing
            // 
            this.lcCarServicing.Controls.Add(this.leDCSServiceType);
            this.lcCarServicing.Controls.Add(this.leDCSCar);
            this.lcCarServicing.Controls.Add(this.leDCSCustomer);
            this.lcCarServicing.Controls.Add(this.gcCarServicing);
            this.lcCarServicing.Controls.Add(this.gcCustomerPurchase);
            this.lcCarServicing.Controls.Add(this.deDCSDateCreated);
            this.lcCarServicing.Controls.Add(this.meDCSRemarks);
            this.lcCarServicing.Controls.Add(this.teDCSAmount);
            this.lcCarServicing.Controls.Add(this.teDCSChange);
            this.lcCarServicing.Controls.Add(this.teDCSBalance);
            this.lcCarServicing.Controls.Add(this.teDCSTotalAmount);
            this.lcCarServicing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcCarServicing.Location = new System.Drawing.Point(0, 0);
            this.lcCarServicing.Name = "lcCarServicing";
            this.lcCarServicing.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(640, 265, 450, 400);
            this.lcCarServicing.Root = this.layoutControlGroup11;
            this.lcCarServicing.Size = new System.Drawing.Size(726, 335);
            this.lcCarServicing.TabIndex = 0;
            this.lcCarServicing.Text = "layoutControl5";
            // 
            // leDCSServiceType
            // 
            this.leDCSServiceType.Location = new System.Drawing.Point(99, 88);
            this.leDCSServiceType.MenuManager = this.ribbonControl1;
            this.leDCSServiceType.Name = "leDCSServiceType";
            this.leDCSServiceType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leDCSServiceType.Properties.NullText = "[Select Service Typel]";
            this.leDCSServiceType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leDCSServiceType.Size = new System.Drawing.Size(141, 20);
            this.leDCSServiceType.StyleController = this.lcCarServicing;
            this.leDCSServiceType.TabIndex = 3;
            // 
            // leDCSCar
            // 
            this.leDCSCar.Location = new System.Drawing.Point(319, 64);
            this.leDCSCar.MenuManager = this.ribbonControl1;
            this.leDCSCar.Name = "leDCSCar";
            this.leDCSCar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leDCSCar.Properties.NullText = "[Select Car]";
            this.leDCSCar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leDCSCar.Size = new System.Drawing.Size(143, 20);
            this.leDCSCar.StyleController = this.lcCarServicing;
            this.leDCSCar.TabIndex = 2;
            this.leDCSCar.EditValueChanged += new System.EventHandler(this.leDCSCar_EditValueChanged);
            // 
            // leDCSCustomer
            // 
            this.leDCSCustomer.Location = new System.Drawing.Point(99, 64);
            this.leDCSCustomer.MenuManager = this.ribbonControl1;
            this.leDCSCustomer.Name = "leDCSCustomer";
            this.leDCSCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leDCSCustomer.Properties.NullText = "[Select Customer]";
            this.leDCSCustomer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leDCSCustomer.Size = new System.Drawing.Size(141, 20);
            this.leDCSCustomer.StyleController = this.lcCarServicing;
            this.leDCSCustomer.TabIndex = 0;
            this.leDCSCustomer.EditValueChanged += new System.EventHandler(this.leDCSCustomer_EditValueChanged);
            // 
            // gcCarServicing
            // 
            this.gcCarServicing.Location = new System.Drawing.Point(12, 257);
            this.gcCarServicing.MainView = this.gvCarServicing;
            this.gcCarServicing.MenuManager = this.ribbonControl1;
            this.gcCarServicing.Name = "gcCarServicing";
            this.gcCarServicing.Size = new System.Drawing.Size(462, 66);
            this.gcCarServicing.TabIndex = 6;
            this.gcCarServicing.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCarServicing});
            // 
            // gvCarServicing
            // 
            this.gvCarServicing.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn55,
            this.gridColumn56,
            this.gridColumn57,
            this.gridColumn58,
            this.gridColumn194,
            this.gridColumn59,
            this.gridColumn190,
            this.gridColumn189,
            this.gridColumn191,
            this.gridColumn61,
            this.gridColumn60,
            this.gridColumn62});
            this.gvCarServicing.GridControl = this.gcCarServicing;
            this.gvCarServicing.GroupCount = 1;
            this.gvCarServicing.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "(Count={0})")});
            this.gvCarServicing.Name = "gvCarServicing";
            this.gvCarServicing.OptionsBehavior.Editable = false;
            this.gvCarServicing.OptionsBehavior.ReadOnly = true;
            this.gvCarServicing.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn57, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvCarServicing.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn55
            // 
            this.gridColumn55.Caption = "ID";
            this.gridColumn55.FieldName = "csID";
            this.gridColumn55.Name = "gridColumn55";
            // 
            // gridColumn56
            // 
            this.gridColumn56.Caption = "Customer Name";
            this.gridColumn56.FieldName = "cusFName";
            this.gridColumn56.Name = "gridColumn56";
            this.gridColumn56.Visible = true;
            this.gridColumn56.VisibleIndex = 0;
            // 
            // gridColumn57
            // 
            this.gridColumn57.Caption = "Customer ID";
            this.gridColumn57.FieldName = "cusCustomerID";
            this.gridColumn57.Name = "gridColumn57";
            this.gridColumn57.Visible = true;
            this.gridColumn57.VisibleIndex = 1;
            // 
            // gridColumn58
            // 
            this.gridColumn58.Caption = "Car";
            this.gridColumn58.FieldName = "carfname";
            this.gridColumn58.Name = "gridColumn58";
            this.gridColumn58.Visible = true;
            this.gridColumn58.VisibleIndex = 1;
            // 
            // gridColumn194
            // 
            this.gridColumn194.Caption = "Registration Number";
            this.gridColumn194.FieldName = "ccRegistrationNum";
            this.gridColumn194.Name = "gridColumn194";
            this.gridColumn194.Visible = true;
            this.gridColumn194.VisibleIndex = 2;
            // 
            // gridColumn59
            // 
            this.gridColumn59.Caption = "Service Type";
            this.gridColumn59.FieldName = "stFName";
            this.gridColumn59.Name = "gridColumn59";
            this.gridColumn59.Visible = true;
            this.gridColumn59.VisibleIndex = 3;
            // 
            // gridColumn190
            // 
            this.gridColumn190.Caption = "Amount Due";
            this.gridColumn190.FieldName = "AmountDue";
            this.gridColumn190.Name = "gridColumn190";
            this.gridColumn190.Visible = true;
            this.gridColumn190.VisibleIndex = 6;
            // 
            // gridColumn189
            // 
            this.gridColumn189.Caption = "Amount Paid";
            this.gridColumn189.FieldName = "TotalPaid";
            this.gridColumn189.Name = "gridColumn189";
            this.gridColumn189.Visible = true;
            this.gridColumn189.VisibleIndex = 7;
            // 
            // gridColumn191
            // 
            this.gridColumn191.Caption = "Amount Left";
            this.gridColumn191.FieldName = "AmountLeft";
            this.gridColumn191.Name = "gridColumn191";
            this.gridColumn191.Visible = true;
            this.gridColumn191.VisibleIndex = 8;
            // 
            // gridColumn61
            // 
            this.gridColumn61.Caption = "Remarks";
            this.gridColumn61.FieldName = "csRemarks";
            this.gridColumn61.Name = "gridColumn61";
            this.gridColumn61.Visible = true;
            this.gridColumn61.VisibleIndex = 5;
            // 
            // gridColumn60
            // 
            this.gridColumn60.Caption = "Date Created";
            this.gridColumn60.FieldName = "csDateCreated";
            this.gridColumn60.Name = "gridColumn60";
            this.gridColumn60.Visible = true;
            this.gridColumn60.VisibleIndex = 4;
            // 
            // gridColumn62
            // 
            this.gridColumn62.Caption = "Created By";
            this.gridColumn62.FieldName = "FullName";
            this.gridColumn62.Name = "gridColumn62";
            this.gridColumn62.Visible = true;
            this.gridColumn62.VisibleIndex = 9;
            // 
            // gcCustomerPurchase
            // 
            this.gcCustomerPurchase.Location = new System.Drawing.Point(495, 64);
            this.gcCustomerPurchase.MainView = this.gvCustomerPurchase;
            this.gcCustomerPurchase.MenuManager = this.ribbonControl1;
            this.gcCustomerPurchase.Name = "gcCustomerPurchase";
            this.gcCustomerPurchase.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSEVat,
            this.repositoryItemSEQuantity,
            this.repositoryItemSpinEdit3,
            this.repositoryItemSETax,
            this.repositoryItemSEDiscount,
            this.repositoryItemCEAddItem});
            this.gcCustomerPurchase.Size = new System.Drawing.Size(207, 247);
            this.gcCustomerPurchase.TabIndex = 7;
            this.gcCustomerPurchase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCustomerPurchase});
            // 
            // gvCustomerPurchase
            // 
            this.gvCustomerPurchase.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn63,
            this.gridColumn71,
            this.gridColumn65,
            this.gridColumn64,
            this.gridColumn66,
            this.gridColumn67,
            this.gridColumn68,
            this.gridColumn69,
            this.gridColumn70});
            this.gvCustomerPurchase.GridControl = this.gcCustomerPurchase;
            this.gvCustomerPurchase.Name = "gvCustomerPurchase";
            this.gvCustomerPurchase.OptionsView.ColumnAutoWidth = false;
            this.gvCustomerPurchase.OptionsView.ShowFooter = true;
            this.gvCustomerPurchase.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gvCustomerPurchase_CustomSummaryCalculate);
            this.gvCustomerPurchase.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvCustomerPurchase_CustomUnboundColumnData);
            // 
            // gridColumn63
            // 
            this.gridColumn63.Caption = "ID";
            this.gridColumn63.FieldName = "ppID";
            this.gridColumn63.Name = "gridColumn63";
            // 
            // gridColumn71
            // 
            this.gridColumn71.Caption = "Add Item";
            this.gridColumn71.ColumnEdit = this.repositoryItemCEAddItem;
            this.gridColumn71.FieldName = "gridColumn71";
            this.gridColumn71.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn71.Name = "gridColumn71";
            this.gridColumn71.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn71.Visible = true;
            this.gridColumn71.VisibleIndex = 0;
            // 
            // repositoryItemCEAddItem
            // 
            this.repositoryItemCEAddItem.AutoHeight = false;
            this.repositoryItemCEAddItem.Name = "repositoryItemCEAddItem";
            this.repositoryItemCEAddItem.ValueGrayed = false;
            // 
            // gridColumn65
            // 
            this.gridColumn65.Caption = "Quantity";
            this.gridColumn65.ColumnEdit = this.repositoryItemSEQuantity;
            this.gridColumn65.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn65.FieldName = "gridColumn65";
            this.gridColumn65.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn65.Name = "gridColumn65";
            this.gridColumn65.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn65.Visible = true;
            this.gridColumn65.VisibleIndex = 1;
            // 
            // repositoryItemSEQuantity
            // 
            this.repositoryItemSEQuantity.AutoHeight = false;
            this.repositoryItemSEQuantity.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSEQuantity.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repositoryItemSEQuantity.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemSEQuantity.Name = "repositoryItemSEQuantity";
            // 
            // gridColumn64
            // 
            this.gridColumn64.Caption = "Product Or Service";
            this.gridColumn64.FieldName = "pdFName";
            this.gridColumn64.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn64.Name = "gridColumn64";
            this.gridColumn64.OptionsColumn.ReadOnly = true;
            this.gridColumn64.Visible = true;
            this.gridColumn64.VisibleIndex = 2;
            // 
            // gridColumn66
            // 
            this.gridColumn66.Caption = "Unit Price GHC";
            this.gridColumn66.DisplayFormat.FormatString = "{0}";
            this.gridColumn66.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn66.FieldName = "ppUnitPrice";
            this.gridColumn66.Name = "gridColumn66";
            this.gridColumn66.Visible = true;
            this.gridColumn66.VisibleIndex = 3;
            // 
            // gridColumn67
            // 
            this.gridColumn67.Caption = "Tax";
            this.gridColumn67.FieldName = "ppTaxRate";
            this.gridColumn67.Name = "gridColumn67";
            this.gridColumn67.OptionsColumn.ReadOnly = true;
            this.gridColumn67.Visible = true;
            this.gridColumn67.VisibleIndex = 4;
            // 
            // gridColumn68
            // 
            this.gridColumn68.Caption = "VAT";
            this.gridColumn68.FieldName = "ppVatRate";
            this.gridColumn68.Name = "gridColumn68";
            this.gridColumn68.OptionsColumn.ReadOnly = true;
            this.gridColumn68.Visible = true;
            this.gridColumn68.VisibleIndex = 5;
            // 
            // gridColumn69
            // 
            this.gridColumn69.Caption = "Discount";
            this.gridColumn69.ColumnEdit = this.repositoryItemSEDiscount;
            this.gridColumn69.FieldName = "gridColumn69";
            this.gridColumn69.Name = "gridColumn69";
            this.gridColumn69.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn69.Visible = true;
            this.gridColumn69.VisibleIndex = 6;
            // 
            // repositoryItemSEDiscount
            // 
            this.repositoryItemSEDiscount.AutoHeight = false;
            this.repositoryItemSEDiscount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSEDiscount.EditFormat.FormatString = "{0}%";
            this.repositoryItemSEDiscount.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSEDiscount.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repositoryItemSEDiscount.Name = "repositoryItemSEDiscount";
            // 
            // gridColumn70
            // 
            this.gridColumn70.Caption = "Total ";
            this.gridColumn70.FieldName = "gridColumn70";
            this.gridColumn70.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.gridColumn70.Name = "gridColumn70";
            this.gridColumn70.OptionsColumn.ReadOnly = true;
            this.gridColumn70.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "gridColumn70", "Total Cost=GHC{0}", 1)});
            this.gridColumn70.UnboundExpression = resources.GetString("gridColumn70.UnboundExpression");
            this.gridColumn70.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn70.Visible = true;
            this.gridColumn70.VisibleIndex = 7;
            // 
            // repositoryItemSEVat
            // 
            this.repositoryItemSEVat.AutoHeight = false;
            this.repositoryItemSEVat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSEVat.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repositoryItemSEVat.Name = "repositoryItemSEVat";
            // 
            // repositoryItemSpinEdit3
            // 
            this.repositoryItemSpinEdit3.AutoHeight = false;
            this.repositoryItemSpinEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3";
            // 
            // repositoryItemSETax
            // 
            this.repositoryItemSETax.AutoHeight = false;
            this.repositoryItemSETax.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSETax.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repositoryItemSETax.Name = "repositoryItemSETax";
            // 
            // deDCSDateCreated
            // 
            this.deDCSDateCreated.EditValue = new System.DateTime(2017, 8, 15, 16, 16, 0, 0);
            this.deDCSDateCreated.Location = new System.Drawing.Point(319, 88);
            this.deDCSDateCreated.MenuManager = this.ribbonControl1;
            this.deDCSDateCreated.Name = "deDCSDateCreated";
            this.deDCSDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDCSDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDCSDateCreated.Size = new System.Drawing.Size(143, 20);
            this.deDCSDateCreated.StyleController = this.lcCarServicing;
            this.deDCSDateCreated.TabIndex = 4;
            // 
            // meDCSRemarks
            // 
            this.meDCSRemarks.Location = new System.Drawing.Point(99, 220);
            this.meDCSRemarks.MenuManager = this.ribbonControl1;
            this.meDCSRemarks.Name = "meDCSRemarks";
            this.meDCSRemarks.Size = new System.Drawing.Size(363, 16);
            this.meDCSRemarks.StyleController = this.lcCarServicing;
            this.meDCSRemarks.TabIndex = 5;
            // 
            // teDCSAmount
            // 
            this.teDCSAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.teDCSAmount.Location = new System.Drawing.Point(99, 112);
            this.teDCSAmount.MenuManager = this.ribbonControl1;
            this.teDCSAmount.Name = "teDCSAmount";
            this.teDCSAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teDCSAmount.Properties.Appearance.Options.UseFont = true;
            this.teDCSAmount.Properties.Mask.BeepOnError = true;
            this.teDCSAmount.Properties.Mask.EditMask = "#,###,###,###.00";
            this.teDCSAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teDCSAmount.Size = new System.Drawing.Size(363, 32);
            this.teDCSAmount.StyleController = this.lcCarServicing;
            this.teDCSAmount.TabIndex = 9;
            this.teDCSAmount.EditValueChanged += new System.EventHandler(this.teDCSAmount_EditValueChanged);
            // 
            // teDCSChange
            // 
            this.teDCSChange.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.teDCSChange.Location = new System.Drawing.Point(99, 148);
            this.teDCSChange.MenuManager = this.ribbonControl1;
            this.teDCSChange.Name = "teDCSChange";
            this.teDCSChange.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teDCSChange.Properties.Appearance.Options.UseFont = true;
            this.teDCSChange.Properties.Mask.EditMask = "c2";
            this.teDCSChange.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teDCSChange.Properties.ReadOnly = true;
            this.teDCSChange.Size = new System.Drawing.Size(141, 32);
            this.teDCSChange.StyleController = this.lcCarServicing;
            this.teDCSChange.TabIndex = 10;
            // 
            // teDCSBalance
            // 
            this.teDCSBalance.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.teDCSBalance.Location = new System.Drawing.Point(319, 148);
            this.teDCSBalance.MenuManager = this.ribbonControl1;
            this.teDCSBalance.Name = "teDCSBalance";
            this.teDCSBalance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teDCSBalance.Properties.Appearance.Options.UseFont = true;
            this.teDCSBalance.Properties.Mask.EditMask = "c2";
            this.teDCSBalance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teDCSBalance.Properties.ReadOnly = true;
            this.teDCSBalance.Size = new System.Drawing.Size(143, 32);
            this.teDCSBalance.StyleController = this.lcCarServicing;
            this.teDCSBalance.TabIndex = 11;
            // 
            // teDCSTotalAmount
            // 
            this.teDCSTotalAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.teDCSTotalAmount.Location = new System.Drawing.Point(99, 184);
            this.teDCSTotalAmount.Name = "teDCSTotalAmount";
            this.teDCSTotalAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teDCSTotalAmount.Properties.Appearance.Options.UseFont = true;
            this.teDCSTotalAmount.Properties.Mask.EditMask = "c2";
            this.teDCSTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teDCSTotalAmount.Properties.ReadOnly = true;
            this.teDCSTotalAmount.Size = new System.Drawing.Size(363, 32);
            this.teDCSTotalAmount.StyleController = this.lcCarServicing;
            this.teDCSTotalAmount.TabIndex = 12;
            this.teDCSTotalAmount.EditValueChanged += new System.EventHandler(this.teDCSTotalAmount_EditValueChanged);
            // 
            // layoutControlGroup11
            // 
            this.layoutControlGroup11.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup11.GroupBordersVisible = false;
            this.layoutControlGroup11.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgProdAndServ,
            this.splitterItem8,
            this.splitterItem7,
            this.layoutControlItem41,
            this.lcgCarServDetail});
            this.layoutControlGroup11.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup11.Name = "Root";
            this.layoutControlGroup11.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup11.TextVisible = false;
            // 
            // lcgProdAndServ
            // 
            this.lcgProdAndServ.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgProdAndServ.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgProdAndServ.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgProdAndServ.CaptionImage")));
            this.lcgProdAndServ.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem48});
            this.lcgProdAndServ.Location = new System.Drawing.Point(471, 0);
            this.lcgProdAndServ.Name = "lcgProdAndServ";
            this.lcgProdAndServ.Size = new System.Drawing.Size(235, 315);
            this.lcgProdAndServ.Text = "Product And Services";
            // 
            // layoutControlItem48
            // 
            this.layoutControlItem48.Control = this.gcCustomerPurchase;
            this.layoutControlItem48.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem48.Name = "layoutControlItem48";
            this.layoutControlItem48.Size = new System.Drawing.Size(211, 251);
            this.layoutControlItem48.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem48.TextVisible = false;
            // 
            // splitterItem8
            // 
            this.splitterItem8.AllowHotTrack = true;
            this.splitterItem8.Location = new System.Drawing.Point(466, 0);
            this.splitterItem8.Name = "splitterItem8";
            this.splitterItem8.Size = new System.Drawing.Size(5, 315);
            // 
            // splitterItem7
            // 
            this.splitterItem7.AllowHotTrack = true;
            this.splitterItem7.Location = new System.Drawing.Point(0, 240);
            this.splitterItem7.Name = "splitterItem7";
            this.splitterItem7.OptionsTableLayoutItem.ColumnIndex = 1;
            this.splitterItem7.OptionsTableLayoutItem.RowIndex = 2;
            this.splitterItem7.Size = new System.Drawing.Size(466, 5);
            // 
            // layoutControlItem41
            // 
            this.layoutControlItem41.Control = this.gcCarServicing;
            this.layoutControlItem41.Location = new System.Drawing.Point(0, 245);
            this.layoutControlItem41.Name = "layoutControlItem41";
            this.layoutControlItem41.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem41.Size = new System.Drawing.Size(466, 70);
            this.layoutControlItem41.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem41.TextVisible = false;
            // 
            // lcgCarServDetail
            // 
            this.lcgCarServDetail.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgCarServDetail.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgCarServDetail.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgCarServDetail.CaptionImage")));
            this.lcgCarServDetail.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem63,
            this.layoutControlItem64,
            this.layoutControlItem66,
            this.layoutControlItem57,
            this.lciAmount,
            this.layoutControlItem159,
            this.layoutControlItem160,
            this.lciTotalAmount,
            this.layoutControlItem50});
            this.lcgCarServDetail.Location = new System.Drawing.Point(0, 0);
            this.lcgCarServDetail.Name = "lcgCarServDetail";
            this.lcgCarServDetail.Size = new System.Drawing.Size(466, 240);
            this.lcgCarServDetail.Text = "Car Servicing Details";
            // 
            // layoutControlItem63
            // 
            this.layoutControlItem63.Control = this.leDCSCustomer;
            this.layoutControlItem63.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem63.Name = "layoutControlItem63";
            this.layoutControlItem63.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem63.Text = "Customer :";
            this.layoutControlItem63.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem64
            // 
            this.layoutControlItem64.Control = this.leDCSCar;
            this.layoutControlItem64.Location = new System.Drawing.Point(220, 0);
            this.layoutControlItem64.Name = "layoutControlItem64";
            this.layoutControlItem64.Size = new System.Drawing.Size(222, 24);
            this.layoutControlItem64.Text = "Car :";
            this.layoutControlItem64.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem66
            // 
            this.layoutControlItem66.Control = this.leDCSServiceType;
            this.layoutControlItem66.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem66.Name = "layoutControlItem66";
            this.layoutControlItem66.Size = new System.Drawing.Size(220, 24);
            this.layoutControlItem66.Text = "Service Type :";
            this.layoutControlItem66.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem57
            // 
            this.layoutControlItem57.Control = this.deDCSDateCreated;
            this.layoutControlItem57.Location = new System.Drawing.Point(220, 24);
            this.layoutControlItem57.Name = "layoutControlItem57";
            this.layoutControlItem57.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem57.Size = new System.Drawing.Size(222, 24);
            this.layoutControlItem57.Text = "Date Created :";
            this.layoutControlItem57.TextSize = new System.Drawing.Size(72, 13);
            // 
            // lciAmount
            // 
            this.lciAmount.Control = this.teDCSAmount;
            this.lciAmount.Location = new System.Drawing.Point(0, 48);
            this.lciAmount.Name = "lciAmount";
            this.lciAmount.Size = new System.Drawing.Size(442, 36);
            this.lciAmount.Text = "Amount Paid:";
            this.lciAmount.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem159
            // 
            this.layoutControlItem159.Control = this.teDCSChange;
            this.layoutControlItem159.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem159.Name = "layoutControlItem159";
            this.layoutControlItem159.Size = new System.Drawing.Size(220, 36);
            this.layoutControlItem159.Text = "Change :";
            this.layoutControlItem159.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem160
            // 
            this.layoutControlItem160.Control = this.teDCSBalance;
            this.layoutControlItem160.Location = new System.Drawing.Point(220, 84);
            this.layoutControlItem160.Name = "layoutControlItem160";
            this.layoutControlItem160.Size = new System.Drawing.Size(222, 36);
            this.layoutControlItem160.Text = "Balance :";
            this.layoutControlItem160.TextSize = new System.Drawing.Size(72, 13);
            // 
            // lciTotalAmount
            // 
            this.lciTotalAmount.Control = this.teDCSTotalAmount;
            this.lciTotalAmount.CustomizationFormText = "Previous Amount :";
            this.lciTotalAmount.Location = new System.Drawing.Point(0, 120);
            this.lciTotalAmount.Name = "lciTotalAmount";
            this.lciTotalAmount.Size = new System.Drawing.Size(442, 36);
            this.lciTotalAmount.Text = "Total Paid :";
            this.lciTotalAmount.TextSize = new System.Drawing.Size(72, 13);
            this.lciTotalAmount.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem50
            // 
            this.layoutControlItem50.Control = this.meDCSRemarks;
            this.layoutControlItem50.Location = new System.Drawing.Point(0, 156);
            this.layoutControlItem50.Name = "layoutControlItem50";
            this.layoutControlItem50.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem50.Size = new System.Drawing.Size(442, 20);
            this.layoutControlItem50.Text = "Remarks :";
            this.layoutControlItem50.TextSize = new System.Drawing.Size(72, 13);
            // 
            // navigationPage8
            // 
            this.navigationPage8.Controls.Add(this.lcProductPrice);
            this.navigationPage8.Name = "navigationPage8";
            this.navigationPage8.Size = new System.Drawing.Size(726, 335);
            this.navigationPage8.Tag = "Product Prices";
            // 
            // lcProductPrice
            // 
            this.lcProductPrice.Controls.Add(this.lePPProduct);
            this.lcProductPrice.Controls.Add(this.gcProductPrices);
            this.lcProductPrice.Controls.Add(this.tePPUnitPrice);
            this.lcProductPrice.Controls.Add(this.dePPDateCreated);
            this.lcProductPrice.Controls.Add(this.ckePPStatus);
            this.lcProductPrice.Controls.Add(this.sePPTaxRate);
            this.lcProductPrice.Controls.Add(this.sePPVatRate);
            this.lcProductPrice.Controls.Add(this.mePPRemarks);
            this.lcProductPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcProductPrice.Location = new System.Drawing.Point(0, 0);
            this.lcProductPrice.Name = "lcProductPrice";
            this.lcProductPrice.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(66, 135, 450, 400);
            this.lcProductPrice.Root = this.layoutControlGroup16;
            this.lcProductPrice.Size = new System.Drawing.Size(726, 335);
            this.lcProductPrice.TabIndex = 1;
            this.lcProductPrice.Text = "layoutControl1";
            // 
            // lePPProduct
            // 
            this.lePPProduct.Location = new System.Drawing.Point(99, 64);
            this.lePPProduct.MenuManager = this.ribbonControl1;
            this.lePPProduct.Name = "lePPProduct";
            this.lePPProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lePPProduct.Properties.NullText = "[Select Product]";
            this.lePPProduct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lePPProduct.Size = new System.Drawing.Size(261, 20);
            this.lePPProduct.StyleController = this.lcProductPrice;
            this.lePPProduct.TabIndex = 0;
            // 
            // gcProductPrices
            // 
            this.gcProductPrices.Location = new System.Drawing.Point(12, 173);
            this.gcProductPrices.MainView = this.gvProductPrices;
            this.gcProductPrices.Name = "gcProductPrices";
            this.gcProductPrices.Size = new System.Drawing.Size(702, 150);
            this.gcProductPrices.TabIndex = 8;
            this.gcProductPrices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductPrices});
            // 
            // gvProductPrices
            // 
            this.gvProductPrices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn52,
            this.gridColumn75,
            this.gridColumn76,
            this.gridColumn77,
            this.gridColumn72,
            this.gridColumn79,
            this.gridColumn78,
            this.gridColumn73,
            this.gridColumn81});
            this.gvProductPrices.GridControl = this.gcProductPrices;
            this.gvProductPrices.Name = "gvProductPrices";
            this.gvProductPrices.OptionsBehavior.Editable = false;
            this.gvProductPrices.OptionsBehavior.ReadOnly = true;
            this.gvProductPrices.OptionsCustomization.AllowRowSizing = true;
            this.gvProductPrices.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProductPrices.OptionsView.EnableAppearanceOddRow = true;
            this.gvProductPrices.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn52
            // 
            this.gridColumn52.Caption = "ID";
            this.gridColumn52.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn52.FieldName = "ppID";
            this.gridColumn52.Name = "gridColumn52";
            // 
            // gridColumn75
            // 
            this.gridColumn75.Caption = "Product";
            this.gridColumn75.FieldName = "pdFName";
            this.gridColumn75.Name = "gridColumn75";
            this.gridColumn75.Visible = true;
            this.gridColumn75.VisibleIndex = 0;
            // 
            // gridColumn76
            // 
            this.gridColumn76.Caption = "Unit Price";
            this.gridColumn76.FieldName = "ppUnitPrice";
            this.gridColumn76.Name = "gridColumn76";
            this.gridColumn76.Visible = true;
            this.gridColumn76.VisibleIndex = 1;
            // 
            // gridColumn77
            // 
            this.gridColumn77.Caption = "Tax Rate";
            this.gridColumn77.FieldName = "ppTaxRate";
            this.gridColumn77.Name = "gridColumn77";
            this.gridColumn77.Visible = true;
            this.gridColumn77.VisibleIndex = 2;
            // 
            // gridColumn72
            // 
            this.gridColumn72.Caption = "Vat Rate";
            this.gridColumn72.FieldName = "ppVatRate";
            this.gridColumn72.Name = "gridColumn72";
            this.gridColumn72.Visible = true;
            this.gridColumn72.VisibleIndex = 3;
            // 
            // gridColumn79
            // 
            this.gridColumn79.Caption = "Remarks";
            this.gridColumn79.FieldName = "ppRemarks";
            this.gridColumn79.Name = "gridColumn79";
            this.gridColumn79.Visible = true;
            this.gridColumn79.VisibleIndex = 5;
            // 
            // gridColumn78
            // 
            this.gridColumn78.Caption = "Date Created";
            this.gridColumn78.FieldName = "ppDateCreated";
            this.gridColumn78.Name = "gridColumn78";
            this.gridColumn78.Visible = true;
            this.gridColumn78.VisibleIndex = 4;
            // 
            // gridColumn73
            // 
            this.gridColumn73.Caption = "Status";
            this.gridColumn73.FieldName = "ppStatus";
            this.gridColumn73.Name = "gridColumn73";
            this.gridColumn73.Visible = true;
            this.gridColumn73.VisibleIndex = 7;
            // 
            // gridColumn81
            // 
            this.gridColumn81.Caption = "Created By";
            this.gridColumn81.FieldName = "FullName";
            this.gridColumn81.Name = "gridColumn81";
            this.gridColumn81.Visible = true;
            this.gridColumn81.VisibleIndex = 6;
            // 
            // tePPUnitPrice
            // 
            this.tePPUnitPrice.Location = new System.Drawing.Point(439, 64);
            this.tePPUnitPrice.MenuManager = this.ribbonControl1;
            this.tePPUnitPrice.Name = "tePPUnitPrice";
            this.tePPUnitPrice.Size = new System.Drawing.Size(263, 20);
            this.tePPUnitPrice.StyleController = this.lcProductPrice;
            this.tePPUnitPrice.TabIndex = 2;
            // 
            // dePPDateCreated
            // 
            this.dePPDateCreated.EditValue = new System.DateTime(2017, 7, 27, 13, 34, 35, 0);
            this.dePPDateCreated.Location = new System.Drawing.Point(99, 132);
            this.dePPDateCreated.MenuManager = this.ribbonControl1;
            this.dePPDateCreated.Name = "dePPDateCreated";
            this.dePPDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePPDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dePPDateCreated.Size = new System.Drawing.Size(538, 20);
            this.dePPDateCreated.StyleController = this.lcProductPrice;
            this.dePPDateCreated.TabIndex = 6;
            // 
            // ckePPStatus
            // 
            this.ckePPStatus.EditValue = true;
            this.ckePPStatus.Location = new System.Drawing.Point(641, 132);
            this.ckePPStatus.MenuManager = this.ribbonControl1;
            this.ckePPStatus.Name = "ckePPStatus";
            this.ckePPStatus.Properties.Caption = "Active ?";
            this.ckePPStatus.Size = new System.Drawing.Size(61, 19);
            this.ckePPStatus.StyleController = this.lcProductPrice;
            this.ckePPStatus.TabIndex = 7;
            // 
            // sePPTaxRate
            // 
            this.sePPTaxRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePPTaxRate.Location = new System.Drawing.Point(99, 88);
            this.sePPTaxRate.MenuManager = this.ribbonControl1;
            this.sePPTaxRate.Name = "sePPTaxRate";
            this.sePPTaxRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePPTaxRate.Size = new System.Drawing.Size(261, 20);
            this.sePPTaxRate.StyleController = this.lcProductPrice;
            this.sePPTaxRate.TabIndex = 3;
            // 
            // sePPVatRate
            // 
            this.sePPVatRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sePPVatRate.Location = new System.Drawing.Point(439, 88);
            this.sePPVatRate.MenuManager = this.ribbonControl1;
            this.sePPVatRate.Name = "sePPVatRate";
            this.sePPVatRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sePPVatRate.Size = new System.Drawing.Size(263, 20);
            this.sePPVatRate.StyleController = this.lcProductPrice;
            this.sePPVatRate.TabIndex = 4;
            // 
            // mePPRemarks
            // 
            this.mePPRemarks.Location = new System.Drawing.Point(99, 112);
            this.mePPRemarks.MenuManager = this.ribbonControl1;
            this.mePPRemarks.Name = "mePPRemarks";
            this.mePPRemarks.Size = new System.Drawing.Size(603, 16);
            this.mePPRemarks.StyleController = this.lcProductPrice;
            this.mePPRemarks.TabIndex = 5;
            // 
            // layoutControlGroup16
            // 
            this.layoutControlGroup16.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup16.GroupBordersVisible = false;
            this.layoutControlGroup16.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem51,
            this.lcgProdPrice,
            this.splitterItem9});
            this.layoutControlGroup16.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup16.Name = "Root";
            this.layoutControlGroup16.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup16.TextVisible = false;
            // 
            // layoutControlItem51
            // 
            this.layoutControlItem51.Control = this.gcProductPrices;
            this.layoutControlItem51.Location = new System.Drawing.Point(0, 161);
            this.layoutControlItem51.Name = "layoutControlItem2";
            this.layoutControlItem51.Size = new System.Drawing.Size(706, 154);
            this.layoutControlItem51.Text = "Detail View";
            this.layoutControlItem51.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem51.TextVisible = false;
            // 
            // lcgProdPrice
            // 
            this.lcgProdPrice.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgProdPrice.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgProdPrice.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgProdPrice.CaptionImage")));
            this.lcgProdPrice.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem61,
            this.layoutControlItem62,
            this.layoutControlItem60,
            this.layoutControlItem58,
            this.layoutControlItem56,
            this.layoutControlItem65,
            this.layoutControlItem49});
            this.lcgProdPrice.Location = new System.Drawing.Point(0, 0);
            this.lcgProdPrice.Name = "lcgProdPrice";
            this.lcgProdPrice.Size = new System.Drawing.Size(706, 156);
            this.lcgProdPrice.Text = "Product Prices Details";
            // 
            // layoutControlItem61
            // 
            this.layoutControlItem61.Control = this.dePPDateCreated;
            this.layoutControlItem61.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem61.Name = "layoutControlItem10";
            this.layoutControlItem61.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem61.Text = "Date Created :";
            this.layoutControlItem61.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem62
            // 
            this.layoutControlItem62.Control = this.ckePPStatus;
            this.layoutControlItem62.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem62.Location = new System.Drawing.Point(617, 68);
            this.layoutControlItem62.Name = "layoutControlItem11";
            this.layoutControlItem62.Size = new System.Drawing.Size(65, 24);
            this.layoutControlItem62.Text = "Status";
            this.layoutControlItem62.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem62.TextVisible = false;
            // 
            // layoutControlItem60
            // 
            this.layoutControlItem60.Control = this.sePPTaxRate;
            this.layoutControlItem60.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem60.Name = "layoutControlItem60";
            this.layoutControlItem60.Size = new System.Drawing.Size(340, 24);
            this.layoutControlItem60.Text = "Tax Rate :";
            this.layoutControlItem60.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem58
            // 
            this.layoutControlItem58.Control = this.tePPUnitPrice;
            this.layoutControlItem58.Location = new System.Drawing.Point(340, 0);
            this.layoutControlItem58.Name = "layoutControlItem5";
            this.layoutControlItem58.Size = new System.Drawing.Size(342, 24);
            this.layoutControlItem58.Text = "Unit Price :";
            this.layoutControlItem58.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem56
            // 
            this.layoutControlItem56.Control = this.mePPRemarks;
            this.layoutControlItem56.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem56.Name = "layoutControlItem56";
            this.layoutControlItem56.Size = new System.Drawing.Size(682, 20);
            this.layoutControlItem56.Text = "Remarks :";
            this.layoutControlItem56.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem65
            // 
            this.layoutControlItem65.Control = this.sePPVatRate;
            this.layoutControlItem65.Location = new System.Drawing.Point(340, 24);
            this.layoutControlItem65.Name = "layoutControlItem65";
            this.layoutControlItem65.Size = new System.Drawing.Size(342, 24);
            this.layoutControlItem65.Text = "Vat Rate :";
            this.layoutControlItem65.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem49
            // 
            this.layoutControlItem49.Control = this.lePPProduct;
            this.layoutControlItem49.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem49.Name = "layoutControlItem49";
            this.layoutControlItem49.Size = new System.Drawing.Size(340, 24);
            this.layoutControlItem49.Text = "Product :";
            this.layoutControlItem49.TextSize = new System.Drawing.Size(72, 13);
            // 
            // splitterItem9
            // 
            this.splitterItem9.AllowHotTrack = true;
            this.splitterItem9.Location = new System.Drawing.Point(0, 156);
            this.splitterItem9.Name = "splitterItem1";
            this.splitterItem9.Size = new System.Drawing.Size(706, 5);
            // 
            // navigationPage9
            // 
            this.navigationPage9.Controls.Add(this.lcCompanyInfo);
            this.navigationPage9.Name = "navigationPage9";
            this.navigationPage9.Size = new System.Drawing.Size(726, 335);
            this.navigationPage9.Tag = "Company Info";
            // 
            // lcCompanyInfo
            // 
            this.lcCompanyInfo.Controls.Add(this.gcCompanyInfo);
            this.lcCompanyInfo.Controls.Add(this.teCISlogan);
            this.lcCompanyInfo.Controls.Add(this.deCIDateCreated);
            this.lcCompanyInfo.Controls.Add(this.ckeCIStatus);
            this.lcCompanyInfo.Controls.Add(this.meCIRemarks);
            this.lcCompanyInfo.Controls.Add(this.teCIFName);
            this.lcCompanyInfo.Controls.Add(this.teCISName);
            this.lcCompanyInfo.Controls.Add(this.teCIPhone);
            this.lcCompanyInfo.Controls.Add(this.teCIAddress);
            this.lcCompanyInfo.Controls.Add(this.peCILogo);
            this.lcCompanyInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcCompanyInfo.Location = new System.Drawing.Point(0, 0);
            this.lcCompanyInfo.Name = "lcCompanyInfo";
            this.lcCompanyInfo.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(21, 122, 450, 400);
            this.lcCompanyInfo.Root = this.layoutControlGroup1;
            this.lcCompanyInfo.Size = new System.Drawing.Size(726, 335);
            this.lcCompanyInfo.TabIndex = 2;
            this.lcCompanyInfo.Text = "layoutControl1";
            // 
            // gcCompanyInfo
            // 
            this.gcCompanyInfo.Location = new System.Drawing.Point(12, 245);
            this.gcCompanyInfo.MainView = this.gvCompanyInfo;
            this.gcCompanyInfo.Name = "gcCompanyInfo";
            this.gcCompanyInfo.Size = new System.Drawing.Size(702, 78);
            this.gcCompanyInfo.TabIndex = 9;
            this.gcCompanyInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCompanyInfo});
            // 
            // gvCompanyInfo
            // 
            this.gvCompanyInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn80,
            this.gridColumn82,
            this.gridColumn83,
            this.gridColumn96,
            this.gridColumn95,
            this.gridColumn94,
            this.gridColumn84,
            this.gridColumn93,
            this.gridColumn87,
            this.gridColumn88,
            this.gridColumn89});
            this.gvCompanyInfo.GridControl = this.gcCompanyInfo;
            this.gvCompanyInfo.Name = "gvCompanyInfo";
            this.gvCompanyInfo.OptionsBehavior.Editable = false;
            this.gvCompanyInfo.OptionsBehavior.ReadOnly = true;
            this.gvCompanyInfo.OptionsCustomization.AllowRowSizing = true;
            this.gvCompanyInfo.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCompanyInfo.OptionsView.EnableAppearanceOddRow = true;
            this.gvCompanyInfo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn80
            // 
            this.gridColumn80.Caption = "ID";
            this.gridColumn80.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn80.FieldName = "ciID";
            this.gridColumn80.Name = "gridColumn80";
            // 
            // gridColumn82
            // 
            this.gridColumn82.Caption = "Full Name";
            this.gridColumn82.FieldName = "ciFName";
            this.gridColumn82.Name = "gridColumn82";
            this.gridColumn82.Visible = true;
            this.gridColumn82.VisibleIndex = 0;
            // 
            // gridColumn83
            // 
            this.gridColumn83.Caption = "Short Name";
            this.gridColumn83.FieldName = "ciSName";
            this.gridColumn83.Name = "gridColumn83";
            this.gridColumn83.Visible = true;
            this.gridColumn83.VisibleIndex = 1;
            // 
            // gridColumn96
            // 
            this.gridColumn96.Caption = "Slogan";
            this.gridColumn96.FieldName = "ciSlogan";
            this.gridColumn96.Name = "gridColumn96";
            this.gridColumn96.Visible = true;
            this.gridColumn96.VisibleIndex = 2;
            // 
            // gridColumn95
            // 
            this.gridColumn95.Caption = "Address";
            this.gridColumn95.FieldName = "ciAddress";
            this.gridColumn95.Name = "gridColumn95";
            this.gridColumn95.Visible = true;
            this.gridColumn95.VisibleIndex = 3;
            // 
            // gridColumn94
            // 
            this.gridColumn94.Caption = "Phone";
            this.gridColumn94.FieldName = "ciPhone";
            this.gridColumn94.Name = "gridColumn94";
            this.gridColumn94.Visible = true;
            this.gridColumn94.VisibleIndex = 4;
            // 
            // gridColumn84
            // 
            this.gridColumn84.Caption = "Logo";
            this.gridColumn84.FieldName = "ciLogo";
            this.gridColumn84.Name = "gridColumn84";
            this.gridColumn84.Visible = true;
            this.gridColumn84.VisibleIndex = 8;
            // 
            // gridColumn93
            // 
            this.gridColumn93.Caption = "Remarks";
            this.gridColumn93.FieldName = "ciRemarks";
            this.gridColumn93.Name = "gridColumn93";
            this.gridColumn93.Visible = true;
            this.gridColumn93.VisibleIndex = 5;
            // 
            // gridColumn87
            // 
            this.gridColumn87.Caption = "Date Created";
            this.gridColumn87.FieldName = "ciDateCreated";
            this.gridColumn87.Name = "gridColumn87";
            this.gridColumn87.Visible = true;
            this.gridColumn87.VisibleIndex = 6;
            // 
            // gridColumn88
            // 
            this.gridColumn88.Caption = "Status";
            this.gridColumn88.FieldName = "ciStatus";
            this.gridColumn88.Name = "gridColumn88";
            this.gridColumn88.Visible = true;
            this.gridColumn88.VisibleIndex = 7;
            // 
            // gridColumn89
            // 
            this.gridColumn89.Caption = "Created By";
            this.gridColumn89.FieldName = "FullName";
            this.gridColumn89.Name = "gridColumn89";
            this.gridColumn89.Visible = true;
            this.gridColumn89.VisibleIndex = 9;
            // 
            // teCISlogan
            // 
            this.teCISlogan.Location = new System.Drawing.Point(99, 112);
            this.teCISlogan.MenuManager = this.ribbonControl1;
            this.teCISlogan.Name = "teCISlogan";
            this.teCISlogan.Size = new System.Drawing.Size(381, 20);
            this.teCISlogan.StyleController = this.lcCompanyInfo;
            this.teCISlogan.TabIndex = 3;
            // 
            // deCIDateCreated
            // 
            this.deCIDateCreated.EditValue = new System.DateTime(2017, 7, 27, 13, 34, 35, 0);
            this.deCIDateCreated.Location = new System.Drawing.Point(99, 204);
            this.deCIDateCreated.MenuManager = this.ribbonControl1;
            this.deCIDateCreated.Name = "deCIDateCreated";
            this.deCIDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCIDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCIDateCreated.Size = new System.Drawing.Size(538, 20);
            this.deCIDateCreated.StyleController = this.lcCompanyInfo;
            this.deCIDateCreated.TabIndex = 7;
            // 
            // ckeCIStatus
            // 
            this.ckeCIStatus.EditValue = true;
            this.ckeCIStatus.Location = new System.Drawing.Point(641, 204);
            this.ckeCIStatus.MenuManager = this.ribbonControl1;
            this.ckeCIStatus.Name = "ckeCIStatus";
            this.ckeCIStatus.Properties.Caption = "Active ?";
            this.ckeCIStatus.Size = new System.Drawing.Size(61, 19);
            this.ckeCIStatus.StyleController = this.lcCompanyInfo;
            this.ckeCIStatus.TabIndex = 8;
            // 
            // meCIRemarks
            // 
            this.meCIRemarks.Location = new System.Drawing.Point(99, 184);
            this.meCIRemarks.MenuManager = this.ribbonControl1;
            this.meCIRemarks.Name = "meCIRemarks";
            this.meCIRemarks.Size = new System.Drawing.Size(603, 16);
            this.meCIRemarks.StyleController = this.lcCompanyInfo;
            this.meCIRemarks.TabIndex = 6;
            // 
            // teCIFName
            // 
            this.teCIFName.Location = new System.Drawing.Point(99, 64);
            this.teCIFName.MenuManager = this.ribbonControl1;
            this.teCIFName.Name = "teCIFName";
            this.teCIFName.Size = new System.Drawing.Size(381, 20);
            this.teCIFName.StyleController = this.lcCompanyInfo;
            this.teCIFName.TabIndex = 0;
            // 
            // teCISName
            // 
            this.teCISName.Location = new System.Drawing.Point(99, 88);
            this.teCISName.MenuManager = this.ribbonControl1;
            this.teCISName.Name = "teCISName";
            this.teCISName.Size = new System.Drawing.Size(381, 20);
            this.teCISName.StyleController = this.lcCompanyInfo;
            this.teCISName.TabIndex = 2;
            // 
            // teCIPhone
            // 
            this.teCIPhone.Location = new System.Drawing.Point(99, 136);
            this.teCIPhone.MenuManager = this.ribbonControl1;
            this.teCIPhone.Name = "teCIPhone";
            this.teCIPhone.Size = new System.Drawing.Size(381, 20);
            this.teCIPhone.StyleController = this.lcCompanyInfo;
            this.teCIPhone.TabIndex = 4;
            // 
            // teCIAddress
            // 
            this.teCIAddress.Location = new System.Drawing.Point(99, 160);
            this.teCIAddress.MenuManager = this.ribbonControl1;
            this.teCIAddress.Name = "teCIAddress";
            this.teCIAddress.Size = new System.Drawing.Size(603, 20);
            this.teCIAddress.StyleController = this.lcCompanyInfo;
            this.teCIAddress.TabIndex = 5;
            // 
            // peCILogo
            // 
            this.peCILogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.peCILogo.Location = new System.Drawing.Point(484, 64);
            this.peCILogo.MenuManager = this.ribbonControl1;
            this.peCILogo.Name = "peCILogo";
            this.peCILogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peCILogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peCILogo.Properties.ZoomAccelerationFactor = 1D;
            this.peCILogo.Size = new System.Drawing.Size(218, 92);
            this.peCILogo.StyleController = this.lcCompanyInfo;
            this.peCILogo.TabIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem54,
            this.lcgCompanyInfo,
            this.splitterItem10});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem54
            // 
            this.layoutControlItem54.Control = this.gcCompanyInfo;
            this.layoutControlItem54.Location = new System.Drawing.Point(0, 233);
            this.layoutControlItem54.Name = "layoutControlItem2";
            this.layoutControlItem54.Size = new System.Drawing.Size(706, 82);
            this.layoutControlItem54.Text = "Detail View";
            this.layoutControlItem54.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem54.TextVisible = false;
            // 
            // lcgCompanyInfo
            // 
            this.lcgCompanyInfo.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgCompanyInfo.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgCompanyInfo.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgCompanyInfo.CaptionImage")));
            this.lcgCompanyInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem55,
            this.layoutControlItem59,
            this.layoutControlItem69,
            this.layoutControlItem72,
            this.layoutControlItem73,
            this.layoutControlItem74,
            this.layoutControlItem68,
            this.layoutControlItem75,
            this.layoutControlItem67});
            this.lcgCompanyInfo.Location = new System.Drawing.Point(0, 0);
            this.lcgCompanyInfo.Name = "lcgCompanyInfo";
            this.lcgCompanyInfo.Size = new System.Drawing.Size(706, 228);
            this.lcgCompanyInfo.Text = "Company Info Details";
            // 
            // layoutControlItem55
            // 
            this.layoutControlItem55.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem55.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem55.Control = this.deCIDateCreated;
            this.layoutControlItem55.Location = new System.Drawing.Point(0, 140);
            this.layoutControlItem55.Name = "layoutControlItem10";
            this.layoutControlItem55.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem55.Text = "Date Created :";
            this.layoutControlItem55.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem59
            // 
            this.layoutControlItem59.Control = this.ckeCIStatus;
            this.layoutControlItem59.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem59.Location = new System.Drawing.Point(617, 140);
            this.layoutControlItem59.Name = "layoutControlItem11";
            this.layoutControlItem59.Size = new System.Drawing.Size(65, 24);
            this.layoutControlItem59.Text = "Status";
            this.layoutControlItem59.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem59.TextVisible = false;
            // 
            // layoutControlItem69
            // 
            this.layoutControlItem69.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem69.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem69.Control = this.meCIRemarks;
            this.layoutControlItem69.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem69.Name = "layoutControlItem56";
            this.layoutControlItem69.Size = new System.Drawing.Size(682, 20);
            this.layoutControlItem69.Text = "Remarks :";
            this.layoutControlItem69.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem72
            // 
            this.layoutControlItem72.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem72.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem72.Control = this.teCIFName;
            this.layoutControlItem72.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem72.Name = "layoutControlItem72";
            this.layoutControlItem72.Size = new System.Drawing.Size(460, 24);
            this.layoutControlItem72.Text = "Full Name :";
            this.layoutControlItem72.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem73
            // 
            this.layoutControlItem73.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem73.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem73.Control = this.teCISName;
            this.layoutControlItem73.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem73.Name = "layoutControlItem73";
            this.layoutControlItem73.Size = new System.Drawing.Size(460, 24);
            this.layoutControlItem73.Text = "Short Name :";
            this.layoutControlItem73.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem74
            // 
            this.layoutControlItem74.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem74.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem74.Control = this.teCIPhone;
            this.layoutControlItem74.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem74.Name = "layoutControlItem74";
            this.layoutControlItem74.Size = new System.Drawing.Size(460, 24);
            this.layoutControlItem74.Text = "Phone :";
            this.layoutControlItem74.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem68
            // 
            this.layoutControlItem68.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem68.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem68.Control = this.teCISlogan;
            this.layoutControlItem68.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem68.Name = "layoutControlItem5";
            this.layoutControlItem68.Size = new System.Drawing.Size(460, 24);
            this.layoutControlItem68.Text = "Slogan :";
            this.layoutControlItem68.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem75
            // 
            this.layoutControlItem75.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem75.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem75.Control = this.teCIAddress;
            this.layoutControlItem75.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem75.Name = "layoutControlItem75";
            this.layoutControlItem75.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem75.Text = "Address :";
            this.layoutControlItem75.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem67
            // 
            this.layoutControlItem67.Control = this.peCILogo;
            this.layoutControlItem67.Location = new System.Drawing.Point(460, 0);
            this.layoutControlItem67.Name = "layoutControlItem67";
            this.layoutControlItem67.Size = new System.Drawing.Size(222, 96);
            this.layoutControlItem67.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem67.TextVisible = false;
            // 
            // splitterItem10
            // 
            this.splitterItem10.AllowHotTrack = true;
            this.splitterItem10.Location = new System.Drawing.Point(0, 228);
            this.splitterItem10.Name = "splitterItem1";
            this.splitterItem10.Size = new System.Drawing.Size(706, 5);
            // 
            // navigationPage10
            // 
            this.navigationPage10.Controls.Add(this.lcEmployee);
            this.navigationPage10.Name = "navigationPage10";
            this.navigationPage10.Size = new System.Drawing.Size(726, 335);
            this.navigationPage10.Tag = "Employee";
            // 
            // lcEmployee
            // 
            this.lcEmployee.Controls.Add(this.leSfQualification);
            this.lcEmployee.Controls.Add(this.leSfJobType);
            this.lcEmployee.Controls.Add(this.leSfEmployeeType);
            this.lcEmployee.Controls.Add(this.leSfMStatus);
            this.lcEmployee.Controls.Add(this.leSfTitle);
            this.lcEmployee.Controls.Add(this.leSfGender);
            this.lcEmployee.Controls.Add(this.leSfRegion);
            this.lcEmployee.Controls.Add(this.leSfCountry);
            this.lcEmployee.Controls.Add(this.leSfTown);
            this.lcEmployee.Controls.Add(this.gcEmployee);
            this.lcEmployee.Controls.Add(this.teSFOName);
            this.lcEmployee.Controls.Add(this.deSfDateCreated);
            this.lcEmployee.Controls.Add(this.ckeSfStatus);
            this.lcEmployee.Controls.Add(this.meSfRemarks);
            this.lcEmployee.Controls.Add(this.teSfFName);
            this.lcEmployee.Controls.Add(this.teSfPhone);
            this.lcEmployee.Controls.Add(this.teSfAddress);
            this.lcEmployee.Controls.Add(this.peSfImage);
            this.lcEmployee.Controls.Add(this.teSfLName);
            this.lcEmployee.Controls.Add(this.deSfDOB);
            this.lcEmployee.Controls.Add(this.teSfEmail);
            this.lcEmployee.Controls.Add(this.teSfStaffID);
            this.lcEmployee.Controls.Add(this.deSfStartDate);
            this.lcEmployee.Controls.Add(this.deSfEndDate);
            this.lcEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcEmployee.Location = new System.Drawing.Point(0, 0);
            this.lcEmployee.Name = "lcEmployee";
            this.lcEmployee.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(66, 135, 450, 400);
            this.lcEmployee.Root = this.layoutControlGroup19;
            this.lcEmployee.Size = new System.Drawing.Size(726, 335);
            this.lcEmployee.TabIndex = 3;
            this.lcEmployee.Text = "layoutControl1";
            // 
            // leSfQualification
            // 
            this.leSfQualification.Location = new System.Drawing.Point(107, 89);
            this.leSfQualification.MenuManager = this.ribbonControl1;
            this.leSfQualification.Name = "leSfQualification";
            this.leSfQualification.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leSfQualification.Properties.NullText = "[Select Qualification]";
            this.leSfQualification.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leSfQualification.Size = new System.Drawing.Size(595, 20);
            this.leSfQualification.StyleController = this.lcEmployee;
            this.leSfQualification.TabIndex = 39;
            // 
            // leSfJobType
            // 
            this.leSfJobType.Location = new System.Drawing.Point(107, 137);
            this.leSfJobType.MenuManager = this.ribbonControl1;
            this.leSfJobType.Name = "leSfJobType";
            this.leSfJobType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leSfJobType.Properties.NullText = "[Select Job Type]";
            this.leSfJobType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leSfJobType.Size = new System.Drawing.Size(595, 20);
            this.leSfJobType.StyleController = this.lcEmployee;
            this.leSfJobType.TabIndex = 36;
            // 
            // leSfEmployeeType
            // 
            this.leSfEmployeeType.Location = new System.Drawing.Point(107, 113);
            this.leSfEmployeeType.MenuManager = this.ribbonControl1;
            this.leSfEmployeeType.Name = "leSfEmployeeType";
            this.leSfEmployeeType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leSfEmployeeType.Properties.NullText = "[Select Employee Type]";
            this.leSfEmployeeType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leSfEmployeeType.Size = new System.Drawing.Size(595, 20);
            this.leSfEmployeeType.StyleController = this.lcEmployee;
            this.leSfEmployeeType.TabIndex = 35;
            this.leSfEmployeeType.EditValueChanged += new System.EventHandler(this.leSfEmployeeType_EditValueChanged);
            // 
            // leSfMStatus
            // 
            this.leSfMStatus.Location = new System.Drawing.Point(572, 161);
            this.leSfMStatus.MenuManager = this.ribbonControl1;
            this.leSfMStatus.Name = "leSfMStatus";
            this.leSfMStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leSfMStatus.Properties.NullText = "[Select Marital status]";
            this.leSfMStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leSfMStatus.Size = new System.Drawing.Size(130, 20);
            this.leSfMStatus.StyleController = this.lcEmployee;
            this.leSfMStatus.TabIndex = 31;
            // 
            // leSfTitle
            // 
            this.leSfTitle.Location = new System.Drawing.Point(371, 161);
            this.leSfTitle.MenuManager = this.ribbonControl1;
            this.leSfTitle.Name = "leSfTitle";
            this.leSfTitle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leSfTitle.Properties.NullText = "[Select Title]";
            this.leSfTitle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leSfTitle.Size = new System.Drawing.Size(114, 20);
            this.leSfTitle.StyleController = this.lcEmployee;
            this.leSfTitle.TabIndex = 29;
            // 
            // leSfGender
            // 
            this.leSfGender.Location = new System.Drawing.Point(107, 161);
            this.leSfGender.MenuManager = this.ribbonControl1;
            this.leSfGender.Name = "leSfGender";
            this.leSfGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leSfGender.Properties.NullText = "[Select Gender]";
            this.leSfGender.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leSfGender.Size = new System.Drawing.Size(177, 20);
            this.leSfGender.StyleController = this.lcEmployee;
            this.leSfGender.TabIndex = 28;
            // 
            // leSfRegion
            // 
            this.leSfRegion.Location = new System.Drawing.Point(371, 185);
            this.leSfRegion.MenuManager = this.ribbonControl1;
            this.leSfRegion.Name = "leSfRegion";
            this.leSfRegion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leSfRegion.Properties.NullText = "[Select Region]";
            this.leSfRegion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leSfRegion.Size = new System.Drawing.Size(114, 20);
            this.leSfRegion.StyleController = this.lcEmployee;
            this.leSfRegion.TabIndex = 27;
            this.leSfRegion.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.leSfRegion_ButtonClick);
            this.leSfRegion.EditValueChanged += new System.EventHandler(this.leSfRegion_EditValueChanged);
            // 
            // leSfCountry
            // 
            this.leSfCountry.Location = new System.Drawing.Point(107, 185);
            this.leSfCountry.MenuManager = this.ribbonControl1;
            this.leSfCountry.Name = "leSfCountry";
            this.leSfCountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leSfCountry.Properties.NullText = "[Select Country]";
            this.leSfCountry.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leSfCountry.Size = new System.Drawing.Size(177, 20);
            this.leSfCountry.StyleController = this.lcEmployee;
            this.leSfCountry.TabIndex = 26;
            this.leSfCountry.EditValueChanged += new System.EventHandler(this.leSfCountry_EditValueChanged);
            // 
            // leSfTown
            // 
            this.leSfTown.Location = new System.Drawing.Point(572, 185);
            this.leSfTown.MenuManager = this.ribbonControl1;
            this.leSfTown.Name = "leSfTown";
            this.leSfTown.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leSfTown.Properties.NullText = "[Select Town]";
            this.leSfTown.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leSfTown.Size = new System.Drawing.Size(130, 20);
            this.leSfTown.StyleController = this.lcEmployee;
            this.leSfTown.TabIndex = 25;
            this.leSfTown.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.leSfTown_ButtonClick);
            // 
            // gcEmployee
            // 
            this.gcEmployee.Location = new System.Drawing.Point(12, 337);
            this.gcEmployee.MainView = this.gvEmployee;
            this.gcEmployee.Name = "gcEmployee";
            this.gcEmployee.Size = new System.Drawing.Size(702, 20);
            this.gcEmployee.TabIndex = 5;
            this.gcEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployee});
            // 
            // gvEmployee
            // 
            this.gvEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn85,
            this.gridColumn86,
            this.gridColumn90,
            this.gridColumn91,
            this.gridColumn173,
            this.gridColumn172,
            this.gridColumn171,
            this.gridColumn170,
            this.gridColumn169,
            this.gridColumn168,
            this.gridColumn167,
            this.gridColumn166,
            this.gridColumn165,
            this.gridColumn164,
            this.gridColumn163,
            this.gridColumn162,
            this.gridColumn92,
            this.gridColumn97,
            this.gridColumn98,
            this.gridColumn175,
            this.gridColumn174,
            this.gridColumn99,
            this.gridColumn100,
            this.gridColumn101,
            this.gridColumn102});
            this.gvEmployee.GridControl = this.gcEmployee;
            this.gvEmployee.Name = "gvEmployee";
            this.gvEmployee.OptionsBehavior.Editable = false;
            this.gvEmployee.OptionsBehavior.ReadOnly = true;
            this.gvEmployee.OptionsCustomization.AllowRowSizing = true;
            this.gvEmployee.OptionsView.ColumnAutoWidth = false;
            this.gvEmployee.OptionsView.EnableAppearanceEvenRow = true;
            this.gvEmployee.OptionsView.EnableAppearanceOddRow = true;
            this.gvEmployee.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn85
            // 
            this.gridColumn85.Caption = "ID";
            this.gridColumn85.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn85.FieldName = "sfID";
            this.gridColumn85.Name = "gridColumn85";
            // 
            // gridColumn86
            // 
            this.gridColumn86.Caption = "First Name";
            this.gridColumn86.FieldName = "sfFName";
            this.gridColumn86.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn86.Name = "gridColumn86";
            this.gridColumn86.Visible = true;
            this.gridColumn86.VisibleIndex = 0;
            // 
            // gridColumn90
            // 
            this.gridColumn90.Caption = "Last Name";
            this.gridColumn90.FieldName = "sfLName";
            this.gridColumn90.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn90.Name = "gridColumn90";
            this.gridColumn90.Visible = true;
            this.gridColumn90.VisibleIndex = 1;
            // 
            // gridColumn91
            // 
            this.gridColumn91.Caption = "Other Names";
            this.gridColumn91.FieldName = "sfOName";
            this.gridColumn91.Name = "gridColumn91";
            this.gridColumn91.Visible = true;
            this.gridColumn91.VisibleIndex = 2;
            // 
            // gridColumn173
            // 
            this.gridColumn173.Caption = "D.O.B";
            this.gridColumn173.FieldName = "sfDOB";
            this.gridColumn173.Name = "gridColumn173";
            this.gridColumn173.Visible = true;
            this.gridColumn173.VisibleIndex = 3;
            // 
            // gridColumn172
            // 
            this.gridColumn172.Caption = "Image";
            this.gridColumn172.FieldName = "sfImage";
            this.gridColumn172.Name = "gridColumn172";
            this.gridColumn172.Visible = true;
            this.gridColumn172.VisibleIndex = 10;
            // 
            // gridColumn171
            // 
            this.gridColumn171.Caption = "Gender";
            this.gridColumn171.FieldName = "gFName";
            this.gridColumn171.Name = "gridColumn171";
            this.gridColumn171.Visible = true;
            this.gridColumn171.VisibleIndex = 4;
            // 
            // gridColumn170
            // 
            this.gridColumn170.Caption = "Title";
            this.gridColumn170.FieldName = "tFName";
            this.gridColumn170.Name = "gridColumn170";
            this.gridColumn170.Visible = true;
            this.gridColumn170.VisibleIndex = 5;
            // 
            // gridColumn169
            // 
            this.gridColumn169.Caption = "Marital Status";
            this.gridColumn169.FieldName = "msFName";
            this.gridColumn169.Name = "gridColumn169";
            this.gridColumn169.Visible = true;
            this.gridColumn169.VisibleIndex = 6;
            // 
            // gridColumn168
            // 
            this.gridColumn168.Caption = "Country";
            this.gridColumn168.FieldName = "conFName";
            this.gridColumn168.Name = "gridColumn168";
            this.gridColumn168.Visible = true;
            this.gridColumn168.VisibleIndex = 7;
            // 
            // gridColumn167
            // 
            this.gridColumn167.Caption = "Region";
            this.gridColumn167.FieldName = "regFName";
            this.gridColumn167.Name = "gridColumn167";
            this.gridColumn167.Visible = true;
            this.gridColumn167.VisibleIndex = 8;
            // 
            // gridColumn166
            // 
            this.gridColumn166.Caption = "Town";
            this.gridColumn166.FieldName = "twnFName";
            this.gridColumn166.Name = "gridColumn166";
            this.gridColumn166.Visible = true;
            this.gridColumn166.VisibleIndex = 9;
            // 
            // gridColumn165
            // 
            this.gridColumn165.Caption = "Phone";
            this.gridColumn165.FieldName = "sfPhone";
            this.gridColumn165.Name = "gridColumn165";
            this.gridColumn165.Visible = true;
            this.gridColumn165.VisibleIndex = 11;
            // 
            // gridColumn164
            // 
            this.gridColumn164.Caption = "Address";
            this.gridColumn164.FieldName = "sfAddress";
            this.gridColumn164.Name = "gridColumn164";
            this.gridColumn164.Visible = true;
            this.gridColumn164.VisibleIndex = 12;
            // 
            // gridColumn163
            // 
            this.gridColumn163.Caption = "Email";
            this.gridColumn163.FieldName = "sfEmail";
            this.gridColumn163.Name = "gridColumn163";
            this.gridColumn163.Visible = true;
            this.gridColumn163.VisibleIndex = 13;
            // 
            // gridColumn162
            // 
            this.gridColumn162.Caption = "Sfaff ID";
            this.gridColumn162.FieldName = "sfStaffID";
            this.gridColumn162.Name = "gridColumn162";
            this.gridColumn162.Visible = true;
            this.gridColumn162.VisibleIndex = 14;
            // 
            // gridColumn92
            // 
            this.gridColumn92.Caption = "Qualification";
            this.gridColumn92.FieldName = "qFName";
            this.gridColumn92.Name = "gridColumn92";
            this.gridColumn92.Visible = true;
            this.gridColumn92.VisibleIndex = 15;
            // 
            // gridColumn97
            // 
            this.gridColumn97.Caption = "Employee Type";
            this.gridColumn97.FieldName = "etFName";
            this.gridColumn97.Name = "gridColumn97";
            this.gridColumn97.Visible = true;
            this.gridColumn97.VisibleIndex = 16;
            // 
            // gridColumn98
            // 
            this.gridColumn98.Caption = "Job Type";
            this.gridColumn98.FieldName = "jtFName";
            this.gridColumn98.Name = "gridColumn98";
            this.gridColumn98.Visible = true;
            this.gridColumn98.VisibleIndex = 17;
            // 
            // gridColumn175
            // 
            this.gridColumn175.Caption = "Start Date";
            this.gridColumn175.FieldName = "sfStartDate";
            this.gridColumn175.Name = "gridColumn175";
            this.gridColumn175.Visible = true;
            this.gridColumn175.VisibleIndex = 18;
            // 
            // gridColumn174
            // 
            this.gridColumn174.Caption = "End Date";
            this.gridColumn174.FieldName = "sfEndDate";
            this.gridColumn174.Name = "gridColumn174";
            this.gridColumn174.Visible = true;
            this.gridColumn174.VisibleIndex = 19;
            // 
            // gridColumn99
            // 
            this.gridColumn99.Caption = "Remarks";
            this.gridColumn99.FieldName = "sfRemarks";
            this.gridColumn99.Name = "gridColumn99";
            this.gridColumn99.Visible = true;
            this.gridColumn99.VisibleIndex = 20;
            // 
            // gridColumn100
            // 
            this.gridColumn100.Caption = "Date Created";
            this.gridColumn100.FieldName = "sfDateCreated";
            this.gridColumn100.Name = "gridColumn100";
            this.gridColumn100.Visible = true;
            this.gridColumn100.VisibleIndex = 21;
            // 
            // gridColumn101
            // 
            this.gridColumn101.Caption = "Status";
            this.gridColumn101.FieldName = "sfStatus";
            this.gridColumn101.Name = "gridColumn101";
            this.gridColumn101.Visible = true;
            this.gridColumn101.VisibleIndex = 22;
            // 
            // gridColumn102
            // 
            this.gridColumn102.Caption = "Created By";
            this.gridColumn102.FieldName = "FullName";
            this.gridColumn102.Name = "gridColumn102";
            this.gridColumn102.Visible = true;
            this.gridColumn102.VisibleIndex = 23;
            // 
            // teSFOName
            // 
            this.teSFOName.Location = new System.Drawing.Point(107, 113);
            this.teSFOName.MenuManager = this.ribbonControl1;
            this.teSFOName.Name = "teSFOName";
            this.teSFOName.Size = new System.Drawing.Size(378, 20);
            this.teSFOName.StyleController = this.lcEmployee;
            this.teSFOName.TabIndex = 6;
            // 
            // deSfDateCreated
            // 
            this.deSfDateCreated.EditValue = new System.DateTime(2017, 8, 11, 13, 34, 35, 0);
            this.deSfDateCreated.Location = new System.Drawing.Point(107, 301);
            this.deSfDateCreated.MenuManager = this.ribbonControl1;
            this.deSfDateCreated.Name = "deSfDateCreated";
            this.deSfDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deSfDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deSfDateCreated.Size = new System.Drawing.Size(529, 20);
            this.deSfDateCreated.StyleController = this.lcEmployee;
            this.deSfDateCreated.TabIndex = 11;
            // 
            // ckeSfStatus
            // 
            this.ckeSfStatus.EditValue = true;
            this.ckeSfStatus.Location = new System.Drawing.Point(640, 301);
            this.ckeSfStatus.MenuManager = this.ribbonControl1;
            this.ckeSfStatus.Name = "ckeSfStatus";
            this.ckeSfStatus.Properties.Caption = "Active ?";
            this.ckeSfStatus.Size = new System.Drawing.Size(62, 19);
            this.ckeSfStatus.StyleController = this.lcEmployee;
            this.ckeSfStatus.TabIndex = 12;
            // 
            // meSfRemarks
            // 
            this.meSfRemarks.Location = new System.Drawing.Point(107, 281);
            this.meSfRemarks.MenuManager = this.ribbonControl1;
            this.meSfRemarks.Name = "meSfRemarks";
            this.meSfRemarks.Size = new System.Drawing.Size(595, 16);
            this.meSfRemarks.StyleController = this.lcEmployee;
            this.meSfRemarks.TabIndex = 17;
            // 
            // teSfFName
            // 
            this.teSfFName.Location = new System.Drawing.Point(107, 65);
            this.teSfFName.MenuManager = this.ribbonControl1;
            this.teSfFName.Name = "teSfFName";
            this.teSfFName.Size = new System.Drawing.Size(378, 20);
            this.teSfFName.StyleController = this.lcEmployee;
            this.teSfFName.TabIndex = 20;
            // 
            // teSfPhone
            // 
            this.teSfPhone.Location = new System.Drawing.Point(107, 209);
            this.teSfPhone.MenuManager = this.ribbonControl1;
            this.teSfPhone.Name = "teSfPhone";
            this.teSfPhone.Size = new System.Drawing.Size(595, 20);
            this.teSfPhone.StyleController = this.lcEmployee;
            this.teSfPhone.TabIndex = 21;
            // 
            // teSfAddress
            // 
            this.teSfAddress.Location = new System.Drawing.Point(107, 233);
            this.teSfAddress.MenuManager = this.ribbonControl1;
            this.teSfAddress.Name = "teSfAddress";
            this.teSfAddress.Size = new System.Drawing.Size(595, 20);
            this.teSfAddress.StyleController = this.lcEmployee;
            this.teSfAddress.TabIndex = 22;
            // 
            // peSfImage
            // 
            this.peSfImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.peSfImage.Location = new System.Drawing.Point(489, 65);
            this.peSfImage.MenuManager = this.ribbonControl1;
            this.peSfImage.Name = "peSfImage";
            this.peSfImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peSfImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peSfImage.Properties.ZoomAccelerationFactor = 1D;
            this.peSfImage.Size = new System.Drawing.Size(213, 92);
            this.peSfImage.StyleController = this.lcEmployee;
            this.peSfImage.TabIndex = 23;
            // 
            // teSfLName
            // 
            this.teSfLName.Location = new System.Drawing.Point(107, 89);
            this.teSfLName.MenuManager = this.ribbonControl1;
            this.teSfLName.Name = "teSfLName";
            this.teSfLName.Size = new System.Drawing.Size(378, 20);
            this.teSfLName.StyleController = this.lcEmployee;
            this.teSfLName.TabIndex = 24;
            // 
            // deSfDOB
            // 
            this.deSfDOB.EditValue = new System.DateTime(2017, 8, 11, 22, 28, 27, 121);
            this.deSfDOB.Location = new System.Drawing.Point(107, 137);
            this.deSfDOB.MenuManager = this.ribbonControl1;
            this.deSfDOB.Name = "deSfDOB";
            this.deSfDOB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deSfDOB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deSfDOB.Size = new System.Drawing.Size(378, 20);
            this.deSfDOB.StyleController = this.lcEmployee;
            this.deSfDOB.TabIndex = 32;
            // 
            // teSfEmail
            // 
            this.teSfEmail.Location = new System.Drawing.Point(107, 257);
            this.teSfEmail.MenuManager = this.ribbonControl1;
            this.teSfEmail.Name = "teSfEmail";
            this.teSfEmail.Size = new System.Drawing.Size(595, 20);
            this.teSfEmail.StyleController = this.lcEmployee;
            this.teSfEmail.TabIndex = 33;
            // 
            // teSfStaffID
            // 
            this.teSfStaffID.Enabled = false;
            this.teSfStaffID.Location = new System.Drawing.Point(107, 65);
            this.teSfStaffID.MenuManager = this.ribbonControl1;
            this.teSfStaffID.Name = "teSfStaffID";
            this.teSfStaffID.Size = new System.Drawing.Size(595, 20);
            this.teSfStaffID.StyleController = this.lcEmployee;
            this.teSfStaffID.TabIndex = 34;
            // 
            // deSfStartDate
            // 
            this.deSfStartDate.EditValue = new System.DateTime(2017, 8, 11, 22, 43, 17, 703);
            this.deSfStartDate.Location = new System.Drawing.Point(107, 161);
            this.deSfStartDate.MenuManager = this.ribbonControl1;
            this.deSfStartDate.Name = "deSfStartDate";
            this.deSfStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deSfStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deSfStartDate.Size = new System.Drawing.Size(595, 20);
            this.deSfStartDate.StyleController = this.lcEmployee;
            this.deSfStartDate.TabIndex = 37;
            // 
            // deSfEndDate
            // 
            this.deSfEndDate.EditValue = new System.DateTime(2017, 8, 11, 22, 43, 27, 412);
            this.deSfEndDate.Location = new System.Drawing.Point(107, 185);
            this.deSfEndDate.MenuManager = this.ribbonControl1;
            this.deSfEndDate.Name = "deSfEndDate";
            this.deSfEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deSfEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deSfEndDate.Size = new System.Drawing.Size(595, 20);
            this.deSfEndDate.StyleController = this.lcEmployee;
            this.deSfEndDate.TabIndex = 38;
            // 
            // layoutControlGroup19
            // 
            this.layoutControlGroup19.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup19.GroupBordersVisible = false;
            this.layoutControlGroup19.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tcgEmployee,
            this.layoutControlItem70});
            this.layoutControlGroup19.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup19.Name = "Root";
            this.layoutControlGroup19.Size = new System.Drawing.Size(726, 369);
            this.layoutControlGroup19.TextVisible = false;
            // 
            // tcgEmployee
            // 
            this.tcgEmployee.Location = new System.Drawing.Point(0, 0);
            this.tcgEmployee.Name = "tcgEmployee";
            this.tcgEmployee.SelectedTabPage = this.lcgSfPersonalInfo;
            this.tcgEmployee.SelectedTabPageIndex = 0;
            this.tcgEmployee.Size = new System.Drawing.Size(706, 325);
            this.tcgEmployee.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgSfPersonalInfo,
            this.lcgSfJobSpec});
            // 
            // lcgSfPersonalInfo
            // 
            this.lcgSfPersonalInfo.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgSfPersonalInfo.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgSfPersonalInfo.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgSfPersonalInfo.CaptionImage")));
            this.lcgSfPersonalInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem76,
            this.layoutControlItem77,
            this.layoutControlItem79,
            this.layoutControlItem81,
            this.layoutControlItem84,
            this.layoutControlItem86,
            this.layoutControlItem87,
            this.layoutControlItem88,
            this.layoutControlItem90,
            this.layoutControlItem80,
            this.layoutControlItem82,
            this.layoutControlItem91,
            this.layoutControlItem78,
            this.layoutControlItem83,
            this.layoutControlItem85,
            this.layoutControlItem89,
            this.layoutControlItem71});
            this.lcgSfPersonalInfo.Location = new System.Drawing.Point(0, 0);
            this.lcgSfPersonalInfo.Name = "lcgSfPersonalInfo";
            this.lcgSfPersonalInfo.Size = new System.Drawing.Size(682, 260);
            this.lcgSfPersonalInfo.Text = "Persnal Info";
            // 
            // layoutControlItem76
            // 
            this.layoutControlItem76.Control = this.ckeSfStatus;
            this.layoutControlItem76.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem76.Location = new System.Drawing.Point(616, 236);
            this.layoutControlItem76.Name = "layoutControlItem76";
            this.layoutControlItem76.Size = new System.Drawing.Size(66, 24);
            this.layoutControlItem76.Text = "Status";
            this.layoutControlItem76.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem76.TextVisible = false;
            // 
            // layoutControlItem77
            // 
            this.layoutControlItem77.Control = this.meSfRemarks;
            this.layoutControlItem77.Location = new System.Drawing.Point(0, 216);
            this.layoutControlItem77.Name = "layoutControlItem77";
            this.layoutControlItem77.Size = new System.Drawing.Size(682, 20);
            this.layoutControlItem77.Text = "Remarks :";
            this.layoutControlItem77.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem79
            // 
            this.layoutControlItem79.Control = this.teSfFName;
            this.layoutControlItem79.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem79.Name = "layoutControlItem79";
            this.layoutControlItem79.Size = new System.Drawing.Size(465, 24);
            this.layoutControlItem79.Text = "First Name :";
            this.layoutControlItem79.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem81
            // 
            this.layoutControlItem81.Control = this.teSFOName;
            this.layoutControlItem81.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem81.Name = "layoutControlItem81";
            this.layoutControlItem81.Size = new System.Drawing.Size(465, 24);
            this.layoutControlItem81.Text = "Other Names :";
            this.layoutControlItem81.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem84
            // 
            this.layoutControlItem84.Control = this.teSfLName;
            this.layoutControlItem84.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem84.Name = "layoutControlItem84";
            this.layoutControlItem84.Size = new System.Drawing.Size(465, 24);
            this.layoutControlItem84.Text = "Last Name :";
            this.layoutControlItem84.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem86
            // 
            this.layoutControlItem86.Control = this.leSfCountry;
            this.layoutControlItem86.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem86.Name = "layoutControlItem86";
            this.layoutControlItem86.Size = new System.Drawing.Size(264, 24);
            this.layoutControlItem86.Text = "Country :";
            this.layoutControlItem86.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem87
            // 
            this.layoutControlItem87.Control = this.leSfRegion;
            this.layoutControlItem87.Location = new System.Drawing.Point(264, 120);
            this.layoutControlItem87.Name = "layoutControlItem87";
            this.layoutControlItem87.Size = new System.Drawing.Size(201, 24);
            this.layoutControlItem87.Text = "Region :";
            this.layoutControlItem87.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem88
            // 
            this.layoutControlItem88.Control = this.leSfTitle;
            this.layoutControlItem88.Location = new System.Drawing.Point(264, 96);
            this.layoutControlItem88.Name = "layoutControlItem88";
            this.layoutControlItem88.Size = new System.Drawing.Size(201, 24);
            this.layoutControlItem88.Text = "Title :";
            this.layoutControlItem88.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem90
            // 
            this.layoutControlItem90.Control = this.leSfMStatus;
            this.layoutControlItem90.Location = new System.Drawing.Point(465, 96);
            this.layoutControlItem90.Name = "layoutControlItem90";
            this.layoutControlItem90.Size = new System.Drawing.Size(217, 24);
            this.layoutControlItem90.Text = "Marital Status :";
            this.layoutControlItem90.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem80
            // 
            this.layoutControlItem80.Control = this.teSfPhone;
            this.layoutControlItem80.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem80.Name = "layoutControlItem80";
            this.layoutControlItem80.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem80.Text = "Phone :";
            this.layoutControlItem80.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem82
            // 
            this.layoutControlItem82.Control = this.teSfAddress;
            this.layoutControlItem82.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem82.Name = "layoutControlItem82";
            this.layoutControlItem82.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem82.Text = "Address :";
            this.layoutControlItem82.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem91
            // 
            this.layoutControlItem91.Control = this.deSfDOB;
            this.layoutControlItem91.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem91.Name = "layoutControlItem91";
            this.layoutControlItem91.Size = new System.Drawing.Size(465, 24);
            this.layoutControlItem91.Text = "Date Of Birth";
            this.layoutControlItem91.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem78
            // 
            this.layoutControlItem78.Control = this.leSfGender;
            this.layoutControlItem78.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem78.Name = "layoutControlItem78";
            this.layoutControlItem78.Size = new System.Drawing.Size(264, 24);
            this.layoutControlItem78.Text = "Gender :";
            this.layoutControlItem78.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem83
            // 
            this.layoutControlItem83.Control = this.peSfImage;
            this.layoutControlItem83.Location = new System.Drawing.Point(465, 0);
            this.layoutControlItem83.Name = "layoutControlItem83";
            this.layoutControlItem83.Size = new System.Drawing.Size(217, 96);
            this.layoutControlItem83.Text = "Image :";
            this.layoutControlItem83.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem83.TextVisible = false;
            // 
            // layoutControlItem85
            // 
            this.layoutControlItem85.Control = this.leSfTown;
            this.layoutControlItem85.Location = new System.Drawing.Point(465, 120);
            this.layoutControlItem85.Name = "layoutControlItem85";
            this.layoutControlItem85.Size = new System.Drawing.Size(217, 24);
            this.layoutControlItem85.Text = "Town :";
            this.layoutControlItem85.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem89
            // 
            this.layoutControlItem89.Control = this.teSfEmail;
            this.layoutControlItem89.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem89.Name = "layoutControlItem89";
            this.layoutControlItem89.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem89.Text = "Email :";
            this.layoutControlItem89.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem71
            // 
            this.layoutControlItem71.Control = this.deSfDateCreated;
            this.layoutControlItem71.Location = new System.Drawing.Point(0, 236);
            this.layoutControlItem71.Name = "layoutControlItem71";
            this.layoutControlItem71.Size = new System.Drawing.Size(616, 24);
            this.layoutControlItem71.Text = "Date Created :";
            this.layoutControlItem71.TextSize = new System.Drawing.Size(80, 13);
            // 
            // lcgSfJobSpec
            // 
            this.lcgSfJobSpec.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgSfJobSpec.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgSfJobSpec.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgSfJobSpec.CaptionImage")));
            this.lcgSfJobSpec.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem93,
            this.layoutControlItem94,
            this.layoutControlItem95,
            this.layoutControlItem92,
            this.layoutControlItem97,
            this.layoutControlItem96});
            this.lcgSfJobSpec.Location = new System.Drawing.Point(0, 0);
            this.lcgSfJobSpec.Name = "lcgSfJobSpec";
            this.lcgSfJobSpec.Size = new System.Drawing.Size(682, 260);
            this.lcgSfJobSpec.Text = "Job Specification";
            // 
            // layoutControlItem93
            // 
            this.layoutControlItem93.Control = this.leSfEmployeeType;
            this.layoutControlItem93.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem93.Name = "layoutControlItem93";
            this.layoutControlItem93.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem93.Text = "Employee Type :";
            this.layoutControlItem93.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem94
            // 
            this.layoutControlItem94.Control = this.leSfJobType;
            this.layoutControlItem94.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem94.Name = "layoutControlItem94";
            this.layoutControlItem94.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem94.Text = "Job Type :";
            this.layoutControlItem94.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem95
            // 
            this.layoutControlItem95.Control = this.deSfStartDate;
            this.layoutControlItem95.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem95.Name = "layoutControlItem95";
            this.layoutControlItem95.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem95.Text = "Start Date :";
            this.layoutControlItem95.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem92
            // 
            this.layoutControlItem92.Control = this.teSfStaffID;
            this.layoutControlItem92.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem92.Name = "layoutControlItem92";
            this.layoutControlItem92.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem92.Text = "Employee ID :";
            this.layoutControlItem92.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem97
            // 
            this.layoutControlItem97.Control = this.leSfQualification;
            this.layoutControlItem97.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem97.Name = "layoutControlItem97";
            this.layoutControlItem97.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem97.Text = "Qualification :";
            this.layoutControlItem97.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem96
            // 
            this.layoutControlItem96.Control = this.deSfEndDate;
            this.layoutControlItem96.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem96.Name = "layoutControlItem96";
            this.layoutControlItem96.Size = new System.Drawing.Size(682, 140);
            this.layoutControlItem96.Text = "End Date :";
            this.layoutControlItem96.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem70
            // 
            this.layoutControlItem70.Control = this.gcEmployee;
            this.layoutControlItem70.Location = new System.Drawing.Point(0, 325);
            this.layoutControlItem70.Name = "layoutControlItem2";
            this.layoutControlItem70.Size = new System.Drawing.Size(706, 24);
            this.layoutControlItem70.Text = "Detail View";
            this.layoutControlItem70.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem70.TextVisible = false;
            // 
            // navigationPage11
            // 
            this.navigationPage11.Controls.Add(this.lcGender);
            this.navigationPage11.Name = "navigationPage11";
            this.navigationPage11.Size = new System.Drawing.Size(726, 335);
            this.navigationPage11.Tag = "Gender";
            // 
            // lcGender
            // 
            this.lcGender.Controls.Add(this.gcGender);
            this.lcGender.Controls.Add(this.teGFName);
            this.lcGender.Controls.Add(this.teGSName);
            this.lcGender.Controls.Add(this.meGRemarks);
            this.lcGender.Controls.Add(this.deGDateCreated);
            this.lcGender.Controls.Add(this.ckeGStatus);
            this.lcGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcGender.Location = new System.Drawing.Point(0, 0);
            this.lcGender.Name = "lcGender";
            this.lcGender.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(622, 85, 450, 400);
            this.lcGender.Root = this.layoutControlGroup23;
            this.lcGender.Size = new System.Drawing.Size(726, 335);
            this.lcGender.TabIndex = 7;
            this.lcGender.Text = "layoutControl6";
            // 
            // gcGender
            // 
            this.gcGender.Location = new System.Drawing.Point(12, 201);
            this.gcGender.MainView = this.gvGender;
            this.gcGender.MenuManager = this.ribbonControl1;
            this.gcGender.Name = "gcGender";
            this.gcGender.Size = new System.Drawing.Size(702, 122);
            this.gcGender.TabIndex = 6;
            this.gcGender.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvGender});
            // 
            // gvGender
            // 
            this.gvGender.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn103,
            this.gridColumn104,
            this.gridColumn105,
            this.gridColumn106,
            this.gridColumn107,
            this.gridColumn108,
            this.gridColumn109});
            this.gvGender.GridControl = this.gcGender;
            this.gvGender.Name = "gvGender";
            this.gvGender.OptionsBehavior.Editable = false;
            this.gvGender.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn103
            // 
            this.gridColumn103.Caption = "ID";
            this.gridColumn103.FieldName = "gID";
            this.gridColumn103.Name = "gridColumn103";
            // 
            // gridColumn104
            // 
            this.gridColumn104.Caption = "Full Name";
            this.gridColumn104.FieldName = "gFName";
            this.gridColumn104.Name = "gridColumn104";
            this.gridColumn104.Visible = true;
            this.gridColumn104.VisibleIndex = 0;
            // 
            // gridColumn105
            // 
            this.gridColumn105.Caption = "Short Name";
            this.gridColumn105.FieldName = "gSName";
            this.gridColumn105.Name = "gridColumn105";
            this.gridColumn105.Visible = true;
            this.gridColumn105.VisibleIndex = 1;
            // 
            // gridColumn106
            // 
            this.gridColumn106.Caption = "Remarks";
            this.gridColumn106.FieldName = "gRemarks";
            this.gridColumn106.Name = "gridColumn106";
            this.gridColumn106.Visible = true;
            this.gridColumn106.VisibleIndex = 2;
            // 
            // gridColumn107
            // 
            this.gridColumn107.Caption = "Date Created";
            this.gridColumn107.FieldName = "gDateCreated";
            this.gridColumn107.Name = "gridColumn107";
            this.gridColumn107.Visible = true;
            this.gridColumn107.VisibleIndex = 3;
            // 
            // gridColumn108
            // 
            this.gridColumn108.Caption = "Status";
            this.gridColumn108.FieldName = "gStatus";
            this.gridColumn108.Name = "gridColumn108";
            this.gridColumn108.Visible = true;
            this.gridColumn108.VisibleIndex = 4;
            // 
            // gridColumn109
            // 
            this.gridColumn109.Caption = "Created By";
            this.gridColumn109.FieldName = "FullName";
            this.gridColumn109.Name = "gridColumn109";
            this.gridColumn109.Visible = true;
            this.gridColumn109.VisibleIndex = 5;
            // 
            // teGFName
            // 
            this.teGFName.Location = new System.Drawing.Point(99, 64);
            this.teGFName.MenuManager = this.ribbonControl1;
            this.teGFName.Name = "teGFName";
            this.teGFName.Size = new System.Drawing.Size(603, 20);
            this.teGFName.StyleController = this.lcGender;
            this.teGFName.TabIndex = 0;
            // 
            // teGSName
            // 
            this.teGSName.Location = new System.Drawing.Point(99, 88);
            this.teGSName.MenuManager = this.ribbonControl1;
            this.teGSName.Name = "teGSName";
            this.teGSName.Size = new System.Drawing.Size(603, 20);
            this.teGSName.StyleController = this.lcGender;
            this.teGSName.TabIndex = 2;
            // 
            // meGRemarks
            // 
            this.meGRemarks.Location = new System.Drawing.Point(99, 112);
            this.meGRemarks.MenuManager = this.ribbonControl1;
            this.meGRemarks.Name = "meGRemarks";
            this.meGRemarks.Size = new System.Drawing.Size(603, 44);
            this.meGRemarks.StyleController = this.lcGender;
            this.meGRemarks.TabIndex = 3;
            // 
            // deGDateCreated
            // 
            this.deGDateCreated.EditValue = new System.DateTime(2017, 7, 31, 16, 24, 26, 0);
            this.deGDateCreated.Location = new System.Drawing.Point(99, 160);
            this.deGDateCreated.MenuManager = this.ribbonControl1;
            this.deGDateCreated.Name = "deGDateCreated";
            this.deGDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deGDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deGDateCreated.Size = new System.Drawing.Size(538, 20);
            this.deGDateCreated.StyleController = this.lcGender;
            this.deGDateCreated.TabIndex = 4;
            // 
            // ckeGStatus
            // 
            this.ckeGStatus.EditValue = true;
            this.ckeGStatus.Location = new System.Drawing.Point(641, 160);
            this.ckeGStatus.MenuManager = this.ribbonControl1;
            this.ckeGStatus.Name = "ckeGStatus";
            this.ckeGStatus.Properties.Caption = "Active ?";
            this.ckeGStatus.Size = new System.Drawing.Size(61, 19);
            this.ckeGStatus.StyleController = this.lcGender;
            this.ckeGStatus.TabIndex = 5;
            // 
            // layoutControlGroup23
            // 
            this.layoutControlGroup23.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup23.GroupBordersVisible = false;
            this.layoutControlGroup23.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgGender,
            this.splitterItem11,
            this.layoutControlItem106});
            this.layoutControlGroup23.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup23.Name = "Root";
            this.layoutControlGroup23.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup23.TextVisible = false;
            // 
            // lcgGender
            // 
            this.lcgGender.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgGender.CaptionImage")));
            this.lcgGender.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem100,
            this.layoutControlItem101,
            this.layoutControlItem102,
            this.layoutControlItem103,
            this.layoutControlItem105});
            this.lcgGender.Location = new System.Drawing.Point(0, 0);
            this.lcgGender.Name = "lcgGender";
            this.lcgGender.Size = new System.Drawing.Size(706, 184);
            this.lcgGender.Text = "Gender Detail";
            // 
            // layoutControlItem100
            // 
            this.layoutControlItem100.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem100.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem100.Control = this.teGFName;
            this.layoutControlItem100.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem100.Name = "layoutControlItem24";
            this.layoutControlItem100.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem100.Text = "Full Name :";
            this.layoutControlItem100.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem101
            // 
            this.layoutControlItem101.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem101.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem101.Control = this.teGSName;
            this.layoutControlItem101.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem101.Name = "layoutControlItem25";
            this.layoutControlItem101.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem101.Text = "Short Name :";
            this.layoutControlItem101.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem102
            // 
            this.layoutControlItem102.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem102.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem102.Control = this.meGRemarks;
            this.layoutControlItem102.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem102.Name = "layoutControlItem26";
            this.layoutControlItem102.Size = new System.Drawing.Size(682, 48);
            this.layoutControlItem102.Text = "Remarks :";
            this.layoutControlItem102.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem103
            // 
            this.layoutControlItem103.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem103.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem103.Control = this.deGDateCreated;
            this.layoutControlItem103.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem103.Name = "layoutControlItem27";
            this.layoutControlItem103.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem103.Text = "Date Created :";
            this.layoutControlItem103.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem105
            // 
            this.layoutControlItem105.Control = this.ckeGStatus;
            this.layoutControlItem105.Location = new System.Drawing.Point(617, 96);
            this.layoutControlItem105.Name = "layoutControlItem28";
            this.layoutControlItem105.Size = new System.Drawing.Size(65, 24);
            this.layoutControlItem105.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem105.TextVisible = false;
            // 
            // splitterItem11
            // 
            this.splitterItem11.AllowHotTrack = true;
            this.splitterItem11.Location = new System.Drawing.Point(0, 184);
            this.splitterItem11.Name = "splitterItem4";
            this.splitterItem11.Size = new System.Drawing.Size(706, 5);
            // 
            // layoutControlItem106
            // 
            this.layoutControlItem106.Control = this.gcGender;
            this.layoutControlItem106.Location = new System.Drawing.Point(0, 189);
            this.layoutControlItem106.Name = "layoutControlItem29";
            this.layoutControlItem106.Size = new System.Drawing.Size(706, 126);
            this.layoutControlItem106.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem106.TextVisible = false;
            // 
            // navigationPage12
            // 
            this.navigationPage12.Controls.Add(this.lcMaritalStatus);
            this.navigationPage12.Name = "navigationPage12";
            this.navigationPage12.Size = new System.Drawing.Size(726, 335);
            this.navigationPage12.Tag = "Marital Status";
            // 
            // lcMaritalStatus
            // 
            this.lcMaritalStatus.Controls.Add(this.gcMaritalStatus);
            this.lcMaritalStatus.Controls.Add(this.teMSFName);
            this.lcMaritalStatus.Controls.Add(this.teMSSName);
            this.lcMaritalStatus.Controls.Add(this.meMSRemarks);
            this.lcMaritalStatus.Controls.Add(this.deMSDateCreated);
            this.lcMaritalStatus.Controls.Add(this.ckeMSStatus);
            this.lcMaritalStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMaritalStatus.Location = new System.Drawing.Point(0, 0);
            this.lcMaritalStatus.Name = "lcMaritalStatus";
            this.lcMaritalStatus.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(622, 85, 450, 400);
            this.lcMaritalStatus.Root = this.layoutControlGroup25;
            this.lcMaritalStatus.Size = new System.Drawing.Size(726, 335);
            this.lcMaritalStatus.TabIndex = 8;
            this.lcMaritalStatus.Text = "layoutControl6";
            // 
            // gcMaritalStatus
            // 
            this.gcMaritalStatus.Location = new System.Drawing.Point(12, 201);
            this.gcMaritalStatus.MainView = this.gvMaritalStatus;
            this.gcMaritalStatus.MenuManager = this.ribbonControl1;
            this.gcMaritalStatus.Name = "gcMaritalStatus";
            this.gcMaritalStatus.Size = new System.Drawing.Size(702, 122);
            this.gcMaritalStatus.TabIndex = 6;
            this.gcMaritalStatus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMaritalStatus});
            // 
            // gvMaritalStatus
            // 
            this.gvMaritalStatus.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn110,
            this.gridColumn111,
            this.gridColumn112,
            this.gridColumn113,
            this.gridColumn114,
            this.gridColumn115,
            this.gridColumn116});
            this.gvMaritalStatus.GridControl = this.gcMaritalStatus;
            this.gvMaritalStatus.Name = "gvMaritalStatus";
            this.gvMaritalStatus.OptionsBehavior.Editable = false;
            this.gvMaritalStatus.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn110
            // 
            this.gridColumn110.Caption = "ID";
            this.gridColumn110.FieldName = "msID";
            this.gridColumn110.Name = "gridColumn110";
            // 
            // gridColumn111
            // 
            this.gridColumn111.Caption = "Full Name";
            this.gridColumn111.FieldName = "msFName";
            this.gridColumn111.Name = "gridColumn111";
            this.gridColumn111.Visible = true;
            this.gridColumn111.VisibleIndex = 0;
            // 
            // gridColumn112
            // 
            this.gridColumn112.Caption = "Short Name";
            this.gridColumn112.FieldName = "msSName";
            this.gridColumn112.Name = "gridColumn112";
            this.gridColumn112.Visible = true;
            this.gridColumn112.VisibleIndex = 1;
            // 
            // gridColumn113
            // 
            this.gridColumn113.Caption = "Remarks";
            this.gridColumn113.FieldName = "msRemarks";
            this.gridColumn113.Name = "gridColumn113";
            this.gridColumn113.Visible = true;
            this.gridColumn113.VisibleIndex = 2;
            // 
            // gridColumn114
            // 
            this.gridColumn114.Caption = "Date Created";
            this.gridColumn114.FieldName = "msDateCreated";
            this.gridColumn114.Name = "gridColumn114";
            this.gridColumn114.Visible = true;
            this.gridColumn114.VisibleIndex = 3;
            // 
            // gridColumn115
            // 
            this.gridColumn115.Caption = "Status";
            this.gridColumn115.FieldName = "msStatus";
            this.gridColumn115.Name = "gridColumn115";
            this.gridColumn115.Visible = true;
            this.gridColumn115.VisibleIndex = 4;
            // 
            // gridColumn116
            // 
            this.gridColumn116.Caption = "Created By";
            this.gridColumn116.FieldName = "FullName";
            this.gridColumn116.Name = "gridColumn116";
            this.gridColumn116.Visible = true;
            this.gridColumn116.VisibleIndex = 5;
            // 
            // teMSFName
            // 
            this.teMSFName.Location = new System.Drawing.Point(99, 64);
            this.teMSFName.MenuManager = this.ribbonControl1;
            this.teMSFName.Name = "teMSFName";
            this.teMSFName.Size = new System.Drawing.Size(603, 20);
            this.teMSFName.StyleController = this.lcMaritalStatus;
            this.teMSFName.TabIndex = 0;
            // 
            // teMSSName
            // 
            this.teMSSName.Location = new System.Drawing.Point(99, 88);
            this.teMSSName.MenuManager = this.ribbonControl1;
            this.teMSSName.Name = "teMSSName";
            this.teMSSName.Size = new System.Drawing.Size(603, 20);
            this.teMSSName.StyleController = this.lcMaritalStatus;
            this.teMSSName.TabIndex = 2;
            // 
            // meMSRemarks
            // 
            this.meMSRemarks.Location = new System.Drawing.Point(99, 112);
            this.meMSRemarks.MenuManager = this.ribbonControl1;
            this.meMSRemarks.Name = "meMSRemarks";
            this.meMSRemarks.Size = new System.Drawing.Size(603, 44);
            this.meMSRemarks.StyleController = this.lcMaritalStatus;
            this.meMSRemarks.TabIndex = 3;
            // 
            // deMSDateCreated
            // 
            this.deMSDateCreated.EditValue = new System.DateTime(2017, 7, 31, 16, 24, 26, 0);
            this.deMSDateCreated.Location = new System.Drawing.Point(99, 160);
            this.deMSDateCreated.MenuManager = this.ribbonControl1;
            this.deMSDateCreated.Name = "deMSDateCreated";
            this.deMSDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deMSDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deMSDateCreated.Size = new System.Drawing.Size(538, 20);
            this.deMSDateCreated.StyleController = this.lcMaritalStatus;
            this.deMSDateCreated.TabIndex = 4;
            // 
            // ckeMSStatus
            // 
            this.ckeMSStatus.EditValue = true;
            this.ckeMSStatus.Location = new System.Drawing.Point(641, 160);
            this.ckeMSStatus.MenuManager = this.ribbonControl1;
            this.ckeMSStatus.Name = "ckeMSStatus";
            this.ckeMSStatus.Properties.Caption = "Active ?";
            this.ckeMSStatus.Size = new System.Drawing.Size(61, 19);
            this.ckeMSStatus.StyleController = this.lcMaritalStatus;
            this.ckeMSStatus.TabIndex = 5;
            // 
            // layoutControlGroup25
            // 
            this.layoutControlGroup25.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup25.GroupBordersVisible = false;
            this.layoutControlGroup25.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgMStatus,
            this.splitterItem12,
            this.layoutControlItem112});
            this.layoutControlGroup25.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup25.Name = "Root";
            this.layoutControlGroup25.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup25.TextVisible = false;
            // 
            // lcgMStatus
            // 
            this.lcgMStatus.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgMStatus.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgMStatus.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgMStatus.CaptionImage")));
            this.lcgMStatus.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem107,
            this.layoutControlItem108,
            this.layoutControlItem109,
            this.layoutControlItem110,
            this.layoutControlItem111});
            this.lcgMStatus.Location = new System.Drawing.Point(0, 0);
            this.lcgMStatus.Name = "lcgMStatus";
            this.lcgMStatus.Size = new System.Drawing.Size(706, 184);
            this.lcgMStatus.Text = "Marital Status Detail";
            // 
            // layoutControlItem107
            // 
            this.layoutControlItem107.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem107.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem107.Control = this.teMSFName;
            this.layoutControlItem107.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem107.Name = "layoutControlItem24";
            this.layoutControlItem107.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem107.Text = "Full Name :";
            this.layoutControlItem107.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem108
            // 
            this.layoutControlItem108.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem108.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem108.Control = this.teMSSName;
            this.layoutControlItem108.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem108.Name = "layoutControlItem25";
            this.layoutControlItem108.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem108.Text = "Short Name :";
            this.layoutControlItem108.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem109
            // 
            this.layoutControlItem109.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem109.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem109.Control = this.meMSRemarks;
            this.layoutControlItem109.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem109.Name = "layoutControlItem26";
            this.layoutControlItem109.Size = new System.Drawing.Size(682, 48);
            this.layoutControlItem109.Text = "Remarks :";
            this.layoutControlItem109.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem110
            // 
            this.layoutControlItem110.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem110.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem110.Control = this.deMSDateCreated;
            this.layoutControlItem110.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem110.Name = "layoutControlItem27";
            this.layoutControlItem110.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem110.Text = "Date Created :";
            this.layoutControlItem110.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem111
            // 
            this.layoutControlItem111.Control = this.ckeMSStatus;
            this.layoutControlItem111.Location = new System.Drawing.Point(617, 96);
            this.layoutControlItem111.Name = "layoutControlItem28";
            this.layoutControlItem111.Size = new System.Drawing.Size(65, 24);
            this.layoutControlItem111.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem111.TextVisible = false;
            // 
            // splitterItem12
            // 
            this.splitterItem12.AllowHotTrack = true;
            this.splitterItem12.Location = new System.Drawing.Point(0, 184);
            this.splitterItem12.Name = "splitterItem4";
            this.splitterItem12.Size = new System.Drawing.Size(706, 5);
            // 
            // layoutControlItem112
            // 
            this.layoutControlItem112.Control = this.gcMaritalStatus;
            this.layoutControlItem112.Location = new System.Drawing.Point(0, 189);
            this.layoutControlItem112.Name = "layoutControlItem29";
            this.layoutControlItem112.Size = new System.Drawing.Size(706, 126);
            this.layoutControlItem112.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem112.TextVisible = false;
            // 
            // navigationPage13
            // 
            this.navigationPage13.Controls.Add(this.lcCountry);
            this.navigationPage13.Name = "navigationPage13";
            this.navigationPage13.Size = new System.Drawing.Size(726, 335);
            this.navigationPage13.Tag = "Country";
            // 
            // lcCountry
            // 
            this.lcCountry.Controls.Add(this.gcCountry);
            this.lcCountry.Controls.Add(this.teConFName);
            this.lcCountry.Controls.Add(this.teConSName);
            this.lcCountry.Controls.Add(this.meConRemarks);
            this.lcCountry.Controls.Add(this.deConDateCreated);
            this.lcCountry.Controls.Add(this.ckeConStatus);
            this.lcCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcCountry.Location = new System.Drawing.Point(0, 0);
            this.lcCountry.Name = "lcCountry";
            this.lcCountry.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(622, 85, 450, 400);
            this.lcCountry.Root = this.layoutControlGroup27;
            this.lcCountry.Size = new System.Drawing.Size(726, 335);
            this.lcCountry.TabIndex = 9;
            this.lcCountry.Text = "layoutControl6";
            // 
            // gcCountry
            // 
            this.gcCountry.Location = new System.Drawing.Point(12, 201);
            this.gcCountry.MainView = this.gvCountry;
            this.gcCountry.MenuManager = this.ribbonControl1;
            this.gcCountry.Name = "gcCountry";
            this.gcCountry.Size = new System.Drawing.Size(702, 122);
            this.gcCountry.TabIndex = 6;
            this.gcCountry.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCountry});
            // 
            // gvCountry
            // 
            this.gvCountry.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn117,
            this.gridColumn118,
            this.gridColumn119,
            this.gridColumn120,
            this.gridColumn121,
            this.gridColumn122,
            this.gridColumn123});
            this.gvCountry.GridControl = this.gcCountry;
            this.gvCountry.Name = "gvCountry";
            this.gvCountry.OptionsBehavior.Editable = false;
            this.gvCountry.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn117
            // 
            this.gridColumn117.Caption = "ID";
            this.gridColumn117.FieldName = "conID";
            this.gridColumn117.Name = "gridColumn117";
            // 
            // gridColumn118
            // 
            this.gridColumn118.Caption = "Full Name";
            this.gridColumn118.FieldName = "conFName";
            this.gridColumn118.Name = "gridColumn118";
            this.gridColumn118.Visible = true;
            this.gridColumn118.VisibleIndex = 0;
            // 
            // gridColumn119
            // 
            this.gridColumn119.Caption = "Short Name";
            this.gridColumn119.FieldName = "conSName";
            this.gridColumn119.Name = "gridColumn119";
            this.gridColumn119.Visible = true;
            this.gridColumn119.VisibleIndex = 1;
            // 
            // gridColumn120
            // 
            this.gridColumn120.Caption = "Remarks";
            this.gridColumn120.FieldName = "conRemarks";
            this.gridColumn120.Name = "gridColumn120";
            this.gridColumn120.Visible = true;
            this.gridColumn120.VisibleIndex = 2;
            // 
            // gridColumn121
            // 
            this.gridColumn121.Caption = "Date Created";
            this.gridColumn121.FieldName = "conDateCreated";
            this.gridColumn121.Name = "gridColumn121";
            this.gridColumn121.Visible = true;
            this.gridColumn121.VisibleIndex = 3;
            // 
            // gridColumn122
            // 
            this.gridColumn122.Caption = "Status";
            this.gridColumn122.FieldName = "conStatus";
            this.gridColumn122.Name = "gridColumn122";
            this.gridColumn122.Visible = true;
            this.gridColumn122.VisibleIndex = 4;
            // 
            // gridColumn123
            // 
            this.gridColumn123.Caption = "Created By";
            this.gridColumn123.FieldName = "FullName";
            this.gridColumn123.Name = "gridColumn123";
            this.gridColumn123.Visible = true;
            this.gridColumn123.VisibleIndex = 5;
            // 
            // teConFName
            // 
            this.teConFName.Location = new System.Drawing.Point(99, 64);
            this.teConFName.MenuManager = this.ribbonControl1;
            this.teConFName.Name = "teConFName";
            this.teConFName.Size = new System.Drawing.Size(603, 20);
            this.teConFName.StyleController = this.lcCountry;
            this.teConFName.TabIndex = 0;
            // 
            // teConSName
            // 
            this.teConSName.Location = new System.Drawing.Point(99, 88);
            this.teConSName.MenuManager = this.ribbonControl1;
            this.teConSName.Name = "teConSName";
            this.teConSName.Size = new System.Drawing.Size(603, 20);
            this.teConSName.StyleController = this.lcCountry;
            this.teConSName.TabIndex = 2;
            // 
            // meConRemarks
            // 
            this.meConRemarks.Location = new System.Drawing.Point(99, 112);
            this.meConRemarks.MenuManager = this.ribbonControl1;
            this.meConRemarks.Name = "meConRemarks";
            this.meConRemarks.Size = new System.Drawing.Size(603, 44);
            this.meConRemarks.StyleController = this.lcCountry;
            this.meConRemarks.TabIndex = 3;
            // 
            // deConDateCreated
            // 
            this.deConDateCreated.EditValue = new System.DateTime(2017, 7, 31, 16, 24, 26, 0);
            this.deConDateCreated.Location = new System.Drawing.Point(99, 160);
            this.deConDateCreated.MenuManager = this.ribbonControl1;
            this.deConDateCreated.Name = "deConDateCreated";
            this.deConDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deConDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deConDateCreated.Size = new System.Drawing.Size(538, 20);
            this.deConDateCreated.StyleController = this.lcCountry;
            this.deConDateCreated.TabIndex = 4;
            // 
            // ckeConStatus
            // 
            this.ckeConStatus.EditValue = true;
            this.ckeConStatus.Location = new System.Drawing.Point(641, 160);
            this.ckeConStatus.MenuManager = this.ribbonControl1;
            this.ckeConStatus.Name = "ckeConStatus";
            this.ckeConStatus.Properties.Caption = "Active ?";
            this.ckeConStatus.Size = new System.Drawing.Size(61, 19);
            this.ckeConStatus.StyleController = this.lcCountry;
            this.ckeConStatus.TabIndex = 5;
            // 
            // layoutControlGroup27
            // 
            this.layoutControlGroup27.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup27.GroupBordersVisible = false;
            this.layoutControlGroup27.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgCountryDetail,
            this.splitterItem13,
            this.layoutControlItem118});
            this.layoutControlGroup27.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup27.Name = "Root";
            this.layoutControlGroup27.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup27.TextVisible = false;
            // 
            // lcgCountryDetail
            // 
            this.lcgCountryDetail.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgCountryDetail.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgCountryDetail.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgCountryDetail.CaptionImage")));
            this.lcgCountryDetail.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem113,
            this.layoutControlItem114,
            this.layoutControlItem115,
            this.layoutControlItem116,
            this.layoutControlItem117});
            this.lcgCountryDetail.Location = new System.Drawing.Point(0, 0);
            this.lcgCountryDetail.Name = "lcgCountryDetail";
            this.lcgCountryDetail.Size = new System.Drawing.Size(706, 184);
            this.lcgCountryDetail.Text = "Country Detail";
            // 
            // layoutControlItem113
            // 
            this.layoutControlItem113.Control = this.teConFName;
            this.layoutControlItem113.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem113.Name = "layoutControlItem24";
            this.layoutControlItem113.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem113.Text = "Full Name :";
            this.layoutControlItem113.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem114
            // 
            this.layoutControlItem114.Control = this.teConSName;
            this.layoutControlItem114.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem114.Name = "layoutControlItem25";
            this.layoutControlItem114.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem114.Text = "Short Name :";
            this.layoutControlItem114.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem115
            // 
            this.layoutControlItem115.Control = this.meConRemarks;
            this.layoutControlItem115.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem115.Name = "layoutControlItem26";
            this.layoutControlItem115.Size = new System.Drawing.Size(682, 48);
            this.layoutControlItem115.Text = "Remarks :";
            this.layoutControlItem115.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem116
            // 
            this.layoutControlItem116.Control = this.deConDateCreated;
            this.layoutControlItem116.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem116.Name = "layoutControlItem27";
            this.layoutControlItem116.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem116.Text = "Date Created :";
            this.layoutControlItem116.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem117
            // 
            this.layoutControlItem117.Control = this.ckeConStatus;
            this.layoutControlItem117.Location = new System.Drawing.Point(617, 96);
            this.layoutControlItem117.Name = "layoutControlItem28";
            this.layoutControlItem117.Size = new System.Drawing.Size(65, 24);
            this.layoutControlItem117.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem117.TextVisible = false;
            // 
            // splitterItem13
            // 
            this.splitterItem13.AllowHotTrack = true;
            this.splitterItem13.Location = new System.Drawing.Point(0, 184);
            this.splitterItem13.Name = "splitterItem4";
            this.splitterItem13.Size = new System.Drawing.Size(706, 5);
            // 
            // layoutControlItem118
            // 
            this.layoutControlItem118.Control = this.gcCountry;
            this.layoutControlItem118.Location = new System.Drawing.Point(0, 189);
            this.layoutControlItem118.Name = "layoutControlItem29";
            this.layoutControlItem118.Size = new System.Drawing.Size(706, 126);
            this.layoutControlItem118.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem118.TextVisible = false;
            // 
            // navigationPage14
            // 
            this.navigationPage14.Controls.Add(this.lcRegion);
            this.navigationPage14.Name = "navigationPage14";
            this.navigationPage14.Size = new System.Drawing.Size(726, 335);
            this.navigationPage14.Tag = "Region";
            // 
            // lcRegion
            // 
            this.lcRegion.Controls.Add(this.gcRegion);
            this.lcRegion.Controls.Add(this.teRegFName);
            this.lcRegion.Controls.Add(this.teRegSName);
            this.lcRegion.Controls.Add(this.meRegRemarks);
            this.lcRegion.Controls.Add(this.deRegDateCreated);
            this.lcRegion.Controls.Add(this.ckeRegStatus);
            this.lcRegion.Controls.Add(this.leRegCountry);
            this.lcRegion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcRegion.Location = new System.Drawing.Point(0, 0);
            this.lcRegion.Name = "lcRegion";
            this.lcRegion.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(622, 85, 450, 400);
            this.lcRegion.Root = this.layoutControlGroup29;
            this.lcRegion.Size = new System.Drawing.Size(726, 335);
            this.lcRegion.TabIndex = 10;
            this.lcRegion.Text = "layoutControl6";
            // 
            // gcRegion
            // 
            this.gcRegion.Location = new System.Drawing.Point(12, 197);
            this.gcRegion.MainView = this.gvRegion;
            this.gcRegion.MenuManager = this.ribbonControl1;
            this.gcRegion.Name = "gcRegion";
            this.gcRegion.Size = new System.Drawing.Size(702, 126);
            this.gcRegion.TabIndex = 7;
            this.gcRegion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRegion});
            // 
            // gvRegion
            // 
            this.gvRegion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn124,
            this.gridColumn125,
            this.gridColumn126,
            this.gridColumn131,
            this.gridColumn127,
            this.gridColumn128,
            this.gridColumn129,
            this.gridColumn130});
            this.gvRegion.GridControl = this.gcRegion;
            this.gvRegion.Name = "gvRegion";
            this.gvRegion.OptionsBehavior.Editable = false;
            this.gvRegion.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn124
            // 
            this.gridColumn124.Caption = "ID";
            this.gridColumn124.FieldName = "regID";
            this.gridColumn124.Name = "gridColumn124";
            // 
            // gridColumn125
            // 
            this.gridColumn125.Caption = "Full Name";
            this.gridColumn125.FieldName = "regFName";
            this.gridColumn125.Name = "gridColumn125";
            this.gridColumn125.Visible = true;
            this.gridColumn125.VisibleIndex = 0;
            // 
            // gridColumn126
            // 
            this.gridColumn126.Caption = "Short Name";
            this.gridColumn126.FieldName = "regSName";
            this.gridColumn126.Name = "gridColumn126";
            this.gridColumn126.Visible = true;
            this.gridColumn126.VisibleIndex = 1;
            // 
            // gridColumn131
            // 
            this.gridColumn131.Caption = "Country";
            this.gridColumn131.FieldName = "conFName";
            this.gridColumn131.Name = "gridColumn131";
            this.gridColumn131.Visible = true;
            this.gridColumn131.VisibleIndex = 3;
            // 
            // gridColumn127
            // 
            this.gridColumn127.Caption = "Remarks";
            this.gridColumn127.FieldName = "regRemarks";
            this.gridColumn127.Name = "gridColumn127";
            this.gridColumn127.Visible = true;
            this.gridColumn127.VisibleIndex = 2;
            // 
            // gridColumn128
            // 
            this.gridColumn128.Caption = "Date Created";
            this.gridColumn128.FieldName = "regDateCreated";
            this.gridColumn128.Name = "gridColumn128";
            this.gridColumn128.Visible = true;
            this.gridColumn128.VisibleIndex = 4;
            // 
            // gridColumn129
            // 
            this.gridColumn129.Caption = "Status";
            this.gridColumn129.FieldName = "regStatus";
            this.gridColumn129.Name = "gridColumn129";
            this.gridColumn129.Visible = true;
            this.gridColumn129.VisibleIndex = 5;
            // 
            // gridColumn130
            // 
            this.gridColumn130.Caption = "Created By";
            this.gridColumn130.FieldName = "FullName";
            this.gridColumn130.Name = "gridColumn130";
            this.gridColumn130.Visible = true;
            this.gridColumn130.VisibleIndex = 6;
            // 
            // teRegFName
            // 
            this.teRegFName.Location = new System.Drawing.Point(99, 88);
            this.teRegFName.MenuManager = this.ribbonControl1;
            this.teRegFName.Name = "teRegFName";
            this.teRegFName.Size = new System.Drawing.Size(603, 20);
            this.teRegFName.StyleController = this.lcRegion;
            this.teRegFName.TabIndex = 2;
            // 
            // teRegSName
            // 
            this.teRegSName.Location = new System.Drawing.Point(99, 112);
            this.teRegSName.MenuManager = this.ribbonControl1;
            this.teRegSName.Name = "teRegSName";
            this.teRegSName.Size = new System.Drawing.Size(603, 20);
            this.teRegSName.StyleController = this.lcRegion;
            this.teRegSName.TabIndex = 3;
            // 
            // meRegRemarks
            // 
            this.meRegRemarks.Location = new System.Drawing.Point(99, 136);
            this.meRegRemarks.MenuManager = this.ribbonControl1;
            this.meRegRemarks.Name = "meRegRemarks";
            this.meRegRemarks.Size = new System.Drawing.Size(603, 16);
            this.meRegRemarks.StyleController = this.lcRegion;
            this.meRegRemarks.TabIndex = 4;
            // 
            // deRegDateCreated
            // 
            this.deRegDateCreated.EditValue = new System.DateTime(2017, 7, 31, 16, 24, 26, 0);
            this.deRegDateCreated.Location = new System.Drawing.Point(99, 156);
            this.deRegDateCreated.MenuManager = this.ribbonControl1;
            this.deRegDateCreated.Name = "deRegDateCreated";
            this.deRegDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deRegDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deRegDateCreated.Size = new System.Drawing.Size(538, 20);
            this.deRegDateCreated.StyleController = this.lcRegion;
            this.deRegDateCreated.TabIndex = 5;
            // 
            // ckeRegStatus
            // 
            this.ckeRegStatus.EditValue = true;
            this.ckeRegStatus.Location = new System.Drawing.Point(641, 156);
            this.ckeRegStatus.MenuManager = this.ribbonControl1;
            this.ckeRegStatus.Name = "ckeRegStatus";
            this.ckeRegStatus.Properties.Caption = "Active ?";
            this.ckeRegStatus.Size = new System.Drawing.Size(61, 19);
            this.ckeRegStatus.StyleController = this.lcRegion;
            this.ckeRegStatus.TabIndex = 6;
            // 
            // leRegCountry
            // 
            this.leRegCountry.Location = new System.Drawing.Point(99, 64);
            this.leRegCountry.MenuManager = this.ribbonControl1;
            this.leRegCountry.Name = "leRegCountry";
            this.leRegCountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leRegCountry.Properties.NullText = "[Select Country]";
            this.leRegCountry.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leRegCountry.Size = new System.Drawing.Size(603, 20);
            this.leRegCountry.StyleController = this.lcRegion;
            this.leRegCountry.TabIndex = 0;
            // 
            // layoutControlGroup29
            // 
            this.layoutControlGroup29.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup29.GroupBordersVisible = false;
            this.layoutControlGroup29.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgRegion,
            this.splitterItem14,
            this.layoutControlItem124});
            this.layoutControlGroup29.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup29.Name = "Root";
            this.layoutControlGroup29.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup29.TextVisible = false;
            // 
            // lcgRegion
            // 
            this.lcgRegion.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgRegion.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgRegion.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgRegion.CaptionImage")));
            this.lcgRegion.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem119,
            this.layoutControlItem120,
            this.layoutControlItem121,
            this.layoutControlItem122,
            this.layoutControlItem123,
            this.layoutControlItem125});
            this.lcgRegion.Location = new System.Drawing.Point(0, 0);
            this.lcgRegion.Name = "lcgRegion";
            this.lcgRegion.Size = new System.Drawing.Size(706, 180);
            this.lcgRegion.Text = "Region Detail";
            // 
            // layoutControlItem119
            // 
            this.layoutControlItem119.Control = this.teRegFName;
            this.layoutControlItem119.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem119.Name = "layoutControlItem24";
            this.layoutControlItem119.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem119.Text = "Full Name :";
            this.layoutControlItem119.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem120
            // 
            this.layoutControlItem120.Control = this.teRegSName;
            this.layoutControlItem120.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem120.Name = "layoutControlItem25";
            this.layoutControlItem120.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem120.Text = "Short Name :";
            this.layoutControlItem120.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem121
            // 
            this.layoutControlItem121.Control = this.meRegRemarks;
            this.layoutControlItem121.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem121.Name = "layoutControlItem26";
            this.layoutControlItem121.Size = new System.Drawing.Size(682, 20);
            this.layoutControlItem121.Text = "Remarks :";
            this.layoutControlItem121.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem122
            // 
            this.layoutControlItem122.Control = this.deRegDateCreated;
            this.layoutControlItem122.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem122.Name = "layoutControlItem27";
            this.layoutControlItem122.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem122.Text = "Date Created :";
            this.layoutControlItem122.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem123
            // 
            this.layoutControlItem123.Control = this.ckeRegStatus;
            this.layoutControlItem123.Location = new System.Drawing.Point(617, 92);
            this.layoutControlItem123.Name = "layoutControlItem28";
            this.layoutControlItem123.Size = new System.Drawing.Size(65, 24);
            this.layoutControlItem123.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem123.TextVisible = false;
            // 
            // layoutControlItem125
            // 
            this.layoutControlItem125.Control = this.leRegCountry;
            this.layoutControlItem125.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem125.Name = "layoutControlItem125";
            this.layoutControlItem125.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem125.Text = "Country :";
            this.layoutControlItem125.TextSize = new System.Drawing.Size(72, 13);
            // 
            // splitterItem14
            // 
            this.splitterItem14.AllowHotTrack = true;
            this.splitterItem14.Location = new System.Drawing.Point(0, 180);
            this.splitterItem14.Name = "splitterItem4";
            this.splitterItem14.Size = new System.Drawing.Size(706, 5);
            // 
            // layoutControlItem124
            // 
            this.layoutControlItem124.Control = this.gcRegion;
            this.layoutControlItem124.Location = new System.Drawing.Point(0, 185);
            this.layoutControlItem124.Name = "layoutControlItem29";
            this.layoutControlItem124.Size = new System.Drawing.Size(706, 130);
            this.layoutControlItem124.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem124.TextVisible = false;
            // 
            // navigationPage15
            // 
            this.navigationPage15.Controls.Add(this.lcTown);
            this.navigationPage15.Name = "navigationPage15";
            this.navigationPage15.Size = new System.Drawing.Size(726, 335);
            this.navigationPage15.Tag = "Town";
            // 
            // lcTown
            // 
            this.lcTown.Controls.Add(this.leTwnCountry);
            this.lcTown.Controls.Add(this.gcTown);
            this.lcTown.Controls.Add(this.teTwnFName);
            this.lcTown.Controls.Add(this.teTwnSName);
            this.lcTown.Controls.Add(this.meTwnRemarks);
            this.lcTown.Controls.Add(this.deTwnDateCreated);
            this.lcTown.Controls.Add(this.ckeTwnStatus);
            this.lcTown.Controls.Add(this.leTwnRegion);
            this.lcTown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcTown.Location = new System.Drawing.Point(0, 0);
            this.lcTown.Name = "lcTown";
            this.lcTown.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(555, 393, 450, 400);
            this.lcTown.Root = this.layoutControlGroup31;
            this.lcTown.Size = new System.Drawing.Size(726, 335);
            this.lcTown.TabIndex = 11;
            this.lcTown.Text = "layoutControl6";
            // 
            // leTwnCountry
            // 
            this.leTwnCountry.Location = new System.Drawing.Point(99, 64);
            this.leTwnCountry.MenuManager = this.ribbonControl1;
            this.leTwnCountry.Name = "leTwnCountry";
            this.leTwnCountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leTwnCountry.Properties.NullText = "[Select Country]";
            this.leTwnCountry.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leTwnCountry.Size = new System.Drawing.Size(261, 20);
            this.leTwnCountry.StyleController = this.lcTown;
            this.leTwnCountry.TabIndex = 0;
            this.leTwnCountry.EditValueChanged += new System.EventHandler(this.leTwnCountry_EditValueChanged);
            // 
            // gcTown
            // 
            this.gcTown.Location = new System.Drawing.Point(12, 197);
            this.gcTown.MainView = this.gvTown;
            this.gcTown.MenuManager = this.ribbonControl1;
            this.gcTown.Name = "gcTown";
            this.gcTown.Size = new System.Drawing.Size(702, 126);
            this.gcTown.TabIndex = 8;
            this.gcTown.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTown});
            // 
            // gvTown
            // 
            this.gvTown.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn132,
            this.gridColumn133,
            this.gridColumn134,
            this.gridColumn135,
            this.gridColumn140,
            this.gridColumn136,
            this.gridColumn137,
            this.gridColumn138,
            this.gridColumn139});
            this.gvTown.GridControl = this.gcTown;
            this.gvTown.Name = "gvTown";
            this.gvTown.OptionsBehavior.Editable = false;
            this.gvTown.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn132
            // 
            this.gridColumn132.Caption = "ID";
            this.gridColumn132.FieldName = "twnID";
            this.gridColumn132.Name = "gridColumn132";
            // 
            // gridColumn133
            // 
            this.gridColumn133.Caption = "Full Name";
            this.gridColumn133.FieldName = "twnFName";
            this.gridColumn133.Name = "gridColumn133";
            this.gridColumn133.Visible = true;
            this.gridColumn133.VisibleIndex = 0;
            // 
            // gridColumn134
            // 
            this.gridColumn134.Caption = "Short Name";
            this.gridColumn134.FieldName = "twnSName";
            this.gridColumn134.Name = "gridColumn134";
            this.gridColumn134.Visible = true;
            this.gridColumn134.VisibleIndex = 1;
            // 
            // gridColumn135
            // 
            this.gridColumn135.Caption = "Country";
            this.gridColumn135.FieldName = "conFName";
            this.gridColumn135.Name = "gridColumn135";
            this.gridColumn135.Visible = true;
            this.gridColumn135.VisibleIndex = 2;
            // 
            // gridColumn140
            // 
            this.gridColumn140.Caption = "Region";
            this.gridColumn140.FieldName = "regFName";
            this.gridColumn140.Name = "gridColumn140";
            this.gridColumn140.Visible = true;
            this.gridColumn140.VisibleIndex = 3;
            // 
            // gridColumn136
            // 
            this.gridColumn136.Caption = "Remarks";
            this.gridColumn136.FieldName = "twnRemarks";
            this.gridColumn136.Name = "gridColumn136";
            this.gridColumn136.Visible = true;
            this.gridColumn136.VisibleIndex = 4;
            // 
            // gridColumn137
            // 
            this.gridColumn137.Caption = "Date Created";
            this.gridColumn137.FieldName = "twnDateCreated";
            this.gridColumn137.Name = "gridColumn137";
            this.gridColumn137.Visible = true;
            this.gridColumn137.VisibleIndex = 5;
            // 
            // gridColumn138
            // 
            this.gridColumn138.Caption = "Status";
            this.gridColumn138.FieldName = "twnStatus";
            this.gridColumn138.Name = "gridColumn138";
            this.gridColumn138.Visible = true;
            this.gridColumn138.VisibleIndex = 6;
            // 
            // gridColumn139
            // 
            this.gridColumn139.Caption = "Created By";
            this.gridColumn139.FieldName = "FullName";
            this.gridColumn139.Name = "gridColumn139";
            this.gridColumn139.Visible = true;
            this.gridColumn139.VisibleIndex = 7;
            // 
            // teTwnFName
            // 
            this.teTwnFName.Location = new System.Drawing.Point(99, 88);
            this.teTwnFName.MenuManager = this.ribbonControl1;
            this.teTwnFName.Name = "teTwnFName";
            this.teTwnFName.Size = new System.Drawing.Size(603, 20);
            this.teTwnFName.StyleController = this.lcTown;
            this.teTwnFName.TabIndex = 3;
            // 
            // teTwnSName
            // 
            this.teTwnSName.Location = new System.Drawing.Point(99, 112);
            this.teTwnSName.MenuManager = this.ribbonControl1;
            this.teTwnSName.Name = "teTwnSName";
            this.teTwnSName.Size = new System.Drawing.Size(603, 20);
            this.teTwnSName.StyleController = this.lcTown;
            this.teTwnSName.TabIndex = 4;
            // 
            // meTwnRemarks
            // 
            this.meTwnRemarks.Location = new System.Drawing.Point(99, 136);
            this.meTwnRemarks.MenuManager = this.ribbonControl1;
            this.meTwnRemarks.Name = "meTwnRemarks";
            this.meTwnRemarks.Size = new System.Drawing.Size(603, 16);
            this.meTwnRemarks.StyleController = this.lcTown;
            this.meTwnRemarks.TabIndex = 5;
            // 
            // deTwnDateCreated
            // 
            this.deTwnDateCreated.EditValue = new System.DateTime(2017, 7, 31, 16, 24, 26, 0);
            this.deTwnDateCreated.Location = new System.Drawing.Point(99, 156);
            this.deTwnDateCreated.MenuManager = this.ribbonControl1;
            this.deTwnDateCreated.Name = "deTwnDateCreated";
            this.deTwnDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTwnDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deTwnDateCreated.Size = new System.Drawing.Size(538, 20);
            this.deTwnDateCreated.StyleController = this.lcTown;
            this.deTwnDateCreated.TabIndex = 6;
            this.deTwnDateCreated.EditValueChanged += new System.EventHandler(this.deTwnDateCreated_EditValueChanged);
            // 
            // ckeTwnStatus
            // 
            this.ckeTwnStatus.EditValue = true;
            this.ckeTwnStatus.Location = new System.Drawing.Point(641, 156);
            this.ckeTwnStatus.MenuManager = this.ribbonControl1;
            this.ckeTwnStatus.Name = "ckeTwnStatus";
            this.ckeTwnStatus.Properties.Caption = "Active ?";
            this.ckeTwnStatus.Size = new System.Drawing.Size(61, 19);
            this.ckeTwnStatus.StyleController = this.lcTown;
            this.ckeTwnStatus.TabIndex = 7;
            // 
            // leTwnRegion
            // 
            this.leTwnRegion.Location = new System.Drawing.Point(439, 64);
            this.leTwnRegion.Name = "leTwnRegion";
            this.leTwnRegion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leTwnRegion.Properties.NullText = "[Select Region]";
            this.leTwnRegion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leTwnRegion.Size = new System.Drawing.Size(263, 20);
            this.leTwnRegion.StyleController = this.lcTown;
            this.leTwnRegion.TabIndex = 2;
            this.leTwnRegion.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.leTwnRegion_ButtonClick_1);
            // 
            // layoutControlGroup31
            // 
            this.layoutControlGroup31.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup31.GroupBordersVisible = false;
            this.layoutControlGroup31.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgTown,
            this.splitterItem15,
            this.layoutControlItem132});
            this.layoutControlGroup31.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup31.Name = "Root";
            this.layoutControlGroup31.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup31.TextVisible = false;
            // 
            // lcgTown
            // 
            this.lcgTown.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgTown.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgTown.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgTown.CaptionImage")));
            this.lcgTown.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem126,
            this.layoutControlItem127,
            this.layoutControlItem128,
            this.layoutControlItem129,
            this.layoutControlItem130,
            this.layoutControlItem134,
            this.layoutControlItem133});
            this.lcgTown.Location = new System.Drawing.Point(0, 0);
            this.lcgTown.Name = "lcgTown";
            this.lcgTown.Size = new System.Drawing.Size(706, 180);
            this.lcgTown.Text = "Town Detail";
            // 
            // layoutControlItem126
            // 
            this.layoutControlItem126.Control = this.teTwnFName;
            this.layoutControlItem126.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem126.Name = "layoutControlItem24";
            this.layoutControlItem126.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem126.Text = "Full Name :";
            this.layoutControlItem126.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem127
            // 
            this.layoutControlItem127.Control = this.teTwnSName;
            this.layoutControlItem127.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem127.Name = "layoutControlItem25";
            this.layoutControlItem127.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem127.Text = "Short Name :";
            this.layoutControlItem127.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem128
            // 
            this.layoutControlItem128.Control = this.meTwnRemarks;
            this.layoutControlItem128.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem128.Name = "layoutControlItem26";
            this.layoutControlItem128.Size = new System.Drawing.Size(682, 20);
            this.layoutControlItem128.Text = "Remarks :";
            this.layoutControlItem128.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem129
            // 
            this.layoutControlItem129.Control = this.deTwnDateCreated;
            this.layoutControlItem129.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem129.Name = "layoutControlItem27";
            this.layoutControlItem129.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem129.Text = "Date Created :";
            this.layoutControlItem129.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem130
            // 
            this.layoutControlItem130.Control = this.ckeTwnStatus;
            this.layoutControlItem130.Location = new System.Drawing.Point(617, 92);
            this.layoutControlItem130.Name = "layoutControlItem28";
            this.layoutControlItem130.Size = new System.Drawing.Size(65, 24);
            this.layoutControlItem130.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem130.TextVisible = false;
            // 
            // layoutControlItem134
            // 
            this.layoutControlItem134.Control = this.leTwnCountry;
            this.layoutControlItem134.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem134.Name = "layoutControlItem134";
            this.layoutControlItem134.Size = new System.Drawing.Size(340, 24);
            this.layoutControlItem134.Text = "Country :";
            this.layoutControlItem134.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem133
            // 
            this.layoutControlItem133.Control = this.leTwnRegion;
            this.layoutControlItem133.CustomizationFormText = "Country :";
            this.layoutControlItem133.Location = new System.Drawing.Point(340, 0);
            this.layoutControlItem133.Name = "layoutControlItem133";
            this.layoutControlItem133.Size = new System.Drawing.Size(342, 24);
            this.layoutControlItem133.Text = "Region :";
            this.layoutControlItem133.TextSize = new System.Drawing.Size(72, 13);
            // 
            // splitterItem15
            // 
            this.splitterItem15.AllowHotTrack = true;
            this.splitterItem15.Location = new System.Drawing.Point(0, 180);
            this.splitterItem15.Name = "splitterItem4";
            this.splitterItem15.Size = new System.Drawing.Size(706, 5);
            // 
            // layoutControlItem132
            // 
            this.layoutControlItem132.Control = this.gcTown;
            this.layoutControlItem132.Location = new System.Drawing.Point(0, 185);
            this.layoutControlItem132.Name = "layoutControlItem29";
            this.layoutControlItem132.Size = new System.Drawing.Size(706, 130);
            this.layoutControlItem132.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem132.TextVisible = false;
            // 
            // navigationPage16
            // 
            this.navigationPage16.Controls.Add(this.lcQualification);
            this.navigationPage16.Name = "navigationPage16";
            this.navigationPage16.Size = new System.Drawing.Size(726, 335);
            this.navigationPage16.Tag = "Qualification";
            // 
            // lcQualification
            // 
            this.lcQualification.Controls.Add(this.gcQualification);
            this.lcQualification.Controls.Add(this.teQFName);
            this.lcQualification.Controls.Add(this.teQSName);
            this.lcQualification.Controls.Add(this.meQRemarks);
            this.lcQualification.Controls.Add(this.deQDateCreated);
            this.lcQualification.Controls.Add(this.ckeQStatus);
            this.lcQualification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcQualification.Location = new System.Drawing.Point(0, 0);
            this.lcQualification.Name = "lcQualification";
            this.lcQualification.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(622, 85, 450, 400);
            this.lcQualification.Root = this.layoutControlGroup33;
            this.lcQualification.Size = new System.Drawing.Size(726, 335);
            this.lcQualification.TabIndex = 9;
            this.lcQualification.Text = "layoutControl6";
            // 
            // gcQualification
            // 
            this.gcQualification.Location = new System.Drawing.Point(12, 201);
            this.gcQualification.MainView = this.gvQualification;
            this.gcQualification.MenuManager = this.ribbonControl1;
            this.gcQualification.Name = "gcQualification";
            this.gcQualification.Size = new System.Drawing.Size(702, 122);
            this.gcQualification.TabIndex = 6;
            this.gcQualification.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvQualification});
            // 
            // gvQualification
            // 
            this.gvQualification.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn141,
            this.gridColumn142,
            this.gridColumn143,
            this.gridColumn144,
            this.gridColumn145,
            this.gridColumn146,
            this.gridColumn147});
            this.gvQualification.GridControl = this.gcQualification;
            this.gvQualification.Name = "gvQualification";
            this.gvQualification.OptionsBehavior.Editable = false;
            this.gvQualification.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn141
            // 
            this.gridColumn141.Caption = "ID";
            this.gridColumn141.FieldName = "qID";
            this.gridColumn141.Name = "gridColumn141";
            // 
            // gridColumn142
            // 
            this.gridColumn142.Caption = "Full Name";
            this.gridColumn142.FieldName = "qFName";
            this.gridColumn142.Name = "gridColumn142";
            this.gridColumn142.Visible = true;
            this.gridColumn142.VisibleIndex = 0;
            // 
            // gridColumn143
            // 
            this.gridColumn143.Caption = "Short Name";
            this.gridColumn143.FieldName = "qSName";
            this.gridColumn143.Name = "gridColumn143";
            this.gridColumn143.Visible = true;
            this.gridColumn143.VisibleIndex = 1;
            // 
            // gridColumn144
            // 
            this.gridColumn144.Caption = "Remarks";
            this.gridColumn144.FieldName = "qRemarks";
            this.gridColumn144.Name = "gridColumn144";
            this.gridColumn144.Visible = true;
            this.gridColumn144.VisibleIndex = 2;
            // 
            // gridColumn145
            // 
            this.gridColumn145.Caption = "Date Created";
            this.gridColumn145.FieldName = "qDateCreated";
            this.gridColumn145.Name = "gridColumn145";
            this.gridColumn145.Visible = true;
            this.gridColumn145.VisibleIndex = 3;
            // 
            // gridColumn146
            // 
            this.gridColumn146.Caption = "Status";
            this.gridColumn146.FieldName = "qStatus";
            this.gridColumn146.Name = "gridColumn146";
            this.gridColumn146.Visible = true;
            this.gridColumn146.VisibleIndex = 4;
            // 
            // gridColumn147
            // 
            this.gridColumn147.Caption = "Created By";
            this.gridColumn147.FieldName = "FullName";
            this.gridColumn147.Name = "gridColumn147";
            this.gridColumn147.Visible = true;
            this.gridColumn147.VisibleIndex = 5;
            // 
            // teQFName
            // 
            this.teQFName.Location = new System.Drawing.Point(99, 64);
            this.teQFName.MenuManager = this.ribbonControl1;
            this.teQFName.Name = "teQFName";
            this.teQFName.Size = new System.Drawing.Size(603, 20);
            this.teQFName.StyleController = this.lcQualification;
            this.teQFName.TabIndex = 0;
            // 
            // teQSName
            // 
            this.teQSName.Location = new System.Drawing.Point(99, 88);
            this.teQSName.MenuManager = this.ribbonControl1;
            this.teQSName.Name = "teQSName";
            this.teQSName.Size = new System.Drawing.Size(603, 20);
            this.teQSName.StyleController = this.lcQualification;
            this.teQSName.TabIndex = 2;
            // 
            // meQRemarks
            // 
            this.meQRemarks.Location = new System.Drawing.Point(99, 112);
            this.meQRemarks.MenuManager = this.ribbonControl1;
            this.meQRemarks.Name = "meQRemarks";
            this.meQRemarks.Size = new System.Drawing.Size(603, 44);
            this.meQRemarks.StyleController = this.lcQualification;
            this.meQRemarks.TabIndex = 3;
            // 
            // deQDateCreated
            // 
            this.deQDateCreated.EditValue = new System.DateTime(2017, 7, 31, 16, 24, 26, 0);
            this.deQDateCreated.Location = new System.Drawing.Point(99, 160);
            this.deQDateCreated.MenuManager = this.ribbonControl1;
            this.deQDateCreated.Name = "deQDateCreated";
            this.deQDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deQDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deQDateCreated.Size = new System.Drawing.Size(538, 20);
            this.deQDateCreated.StyleController = this.lcQualification;
            this.deQDateCreated.TabIndex = 4;
            // 
            // ckeQStatus
            // 
            this.ckeQStatus.EditValue = true;
            this.ckeQStatus.Location = new System.Drawing.Point(641, 160);
            this.ckeQStatus.MenuManager = this.ribbonControl1;
            this.ckeQStatus.Name = "ckeQStatus";
            this.ckeQStatus.Properties.Caption = "Active ?";
            this.ckeQStatus.Size = new System.Drawing.Size(61, 19);
            this.ckeQStatus.StyleController = this.lcQualification;
            this.ckeQStatus.TabIndex = 5;
            // 
            // layoutControlGroup33
            // 
            this.layoutControlGroup33.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup33.GroupBordersVisible = false;
            this.layoutControlGroup33.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgQualification,
            this.splitterItem16,
            this.layoutControlItem140});
            this.layoutControlGroup33.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup33.Name = "Root";
            this.layoutControlGroup33.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup33.TextVisible = false;
            // 
            // lcgQualification
            // 
            this.lcgQualification.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgQualification.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgQualification.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgQualification.CaptionImage")));
            this.lcgQualification.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem135,
            this.layoutControlItem136,
            this.layoutControlItem137,
            this.layoutControlItem138,
            this.layoutControlItem139});
            this.lcgQualification.Location = new System.Drawing.Point(0, 0);
            this.lcgQualification.Name = "lcgQualification";
            this.lcgQualification.Size = new System.Drawing.Size(706, 184);
            this.lcgQualification.Text = "Qualification Detail";
            // 
            // layoutControlItem135
            // 
            this.layoutControlItem135.Control = this.teQFName;
            this.layoutControlItem135.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem135.Name = "layoutControlItem24";
            this.layoutControlItem135.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem135.Text = "Full Name :";
            this.layoutControlItem135.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem136
            // 
            this.layoutControlItem136.Control = this.teQSName;
            this.layoutControlItem136.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem136.Name = "layoutControlItem25";
            this.layoutControlItem136.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem136.Text = "Short Name :";
            this.layoutControlItem136.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem137
            // 
            this.layoutControlItem137.Control = this.meQRemarks;
            this.layoutControlItem137.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem137.Name = "layoutControlItem26";
            this.layoutControlItem137.Size = new System.Drawing.Size(682, 48);
            this.layoutControlItem137.Text = "Remarks :";
            this.layoutControlItem137.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem138
            // 
            this.layoutControlItem138.Control = this.deQDateCreated;
            this.layoutControlItem138.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem138.Name = "layoutControlItem27";
            this.layoutControlItem138.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem138.Text = "Date Created :";
            this.layoutControlItem138.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem139
            // 
            this.layoutControlItem139.Control = this.ckeQStatus;
            this.layoutControlItem139.Location = new System.Drawing.Point(617, 96);
            this.layoutControlItem139.Name = "layoutControlItem28";
            this.layoutControlItem139.Size = new System.Drawing.Size(65, 24);
            this.layoutControlItem139.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem139.TextVisible = false;
            // 
            // splitterItem16
            // 
            this.splitterItem16.AllowHotTrack = true;
            this.splitterItem16.Location = new System.Drawing.Point(0, 184);
            this.splitterItem16.Name = "splitterItem4";
            this.splitterItem16.Size = new System.Drawing.Size(706, 5);
            // 
            // layoutControlItem140
            // 
            this.layoutControlItem140.Control = this.gcQualification;
            this.layoutControlItem140.Location = new System.Drawing.Point(0, 189);
            this.layoutControlItem140.Name = "layoutControlItem29";
            this.layoutControlItem140.Size = new System.Drawing.Size(706, 126);
            this.layoutControlItem140.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem140.TextVisible = false;
            // 
            // navigationPage17
            // 
            this.navigationPage17.Controls.Add(this.lcEmployeeType);
            this.navigationPage17.Name = "navigationPage17";
            this.navigationPage17.Size = new System.Drawing.Size(726, 335);
            this.navigationPage17.Tag = "Employee Type";
            // 
            // lcEmployeeType
            // 
            this.lcEmployeeType.Controls.Add(this.gcEmployeeType);
            this.lcEmployeeType.Controls.Add(this.teETFName);
            this.lcEmployeeType.Controls.Add(this.teETSName);
            this.lcEmployeeType.Controls.Add(this.meETRemarks);
            this.lcEmployeeType.Controls.Add(this.deETDateCreated);
            this.lcEmployeeType.Controls.Add(this.ckeETStatus);
            this.lcEmployeeType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcEmployeeType.Location = new System.Drawing.Point(0, 0);
            this.lcEmployeeType.Name = "lcEmployeeType";
            this.lcEmployeeType.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(622, 85, 450, 400);
            this.lcEmployeeType.Root = this.layoutControlGroup35;
            this.lcEmployeeType.Size = new System.Drawing.Size(726, 335);
            this.lcEmployeeType.TabIndex = 9;
            this.lcEmployeeType.Text = "layoutControl6";
            // 
            // gcEmployeeType
            // 
            this.gcEmployeeType.Location = new System.Drawing.Point(12, 201);
            this.gcEmployeeType.MainView = this.gvEmployeeType;
            this.gcEmployeeType.MenuManager = this.ribbonControl1;
            this.gcEmployeeType.Name = "gcEmployeeType";
            this.gcEmployeeType.Size = new System.Drawing.Size(702, 122);
            this.gcEmployeeType.TabIndex = 6;
            this.gcEmployeeType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployeeType});
            // 
            // gvEmployeeType
            // 
            this.gvEmployeeType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn148,
            this.gridColumn149,
            this.gridColumn150,
            this.gridColumn151,
            this.gridColumn152,
            this.gridColumn153,
            this.gridColumn154});
            this.gvEmployeeType.GridControl = this.gcEmployeeType;
            this.gvEmployeeType.Name = "gvEmployeeType";
            this.gvEmployeeType.OptionsBehavior.Editable = false;
            this.gvEmployeeType.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn148
            // 
            this.gridColumn148.Caption = "ID";
            this.gridColumn148.FieldName = "etID";
            this.gridColumn148.Name = "gridColumn148";
            // 
            // gridColumn149
            // 
            this.gridColumn149.Caption = "Full Name";
            this.gridColumn149.FieldName = "etFName";
            this.gridColumn149.Name = "gridColumn149";
            this.gridColumn149.Visible = true;
            this.gridColumn149.VisibleIndex = 0;
            // 
            // gridColumn150
            // 
            this.gridColumn150.Caption = "Short Name";
            this.gridColumn150.FieldName = "etSName";
            this.gridColumn150.Name = "gridColumn150";
            this.gridColumn150.Visible = true;
            this.gridColumn150.VisibleIndex = 1;
            // 
            // gridColumn151
            // 
            this.gridColumn151.Caption = "Remarks";
            this.gridColumn151.FieldName = "etRemarks";
            this.gridColumn151.Name = "gridColumn151";
            this.gridColumn151.Visible = true;
            this.gridColumn151.VisibleIndex = 2;
            // 
            // gridColumn152
            // 
            this.gridColumn152.Caption = "Date Created";
            this.gridColumn152.FieldName = "etDateCreated";
            this.gridColumn152.Name = "gridColumn152";
            this.gridColumn152.Visible = true;
            this.gridColumn152.VisibleIndex = 3;
            // 
            // gridColumn153
            // 
            this.gridColumn153.Caption = "Status";
            this.gridColumn153.FieldName = "etStatus";
            this.gridColumn153.Name = "gridColumn153";
            this.gridColumn153.Visible = true;
            this.gridColumn153.VisibleIndex = 4;
            // 
            // gridColumn154
            // 
            this.gridColumn154.Caption = "Created By";
            this.gridColumn154.FieldName = "FullName";
            this.gridColumn154.Name = "gridColumn154";
            this.gridColumn154.Visible = true;
            this.gridColumn154.VisibleIndex = 5;
            // 
            // teETFName
            // 
            this.teETFName.Location = new System.Drawing.Point(99, 64);
            this.teETFName.MenuManager = this.ribbonControl1;
            this.teETFName.Name = "teETFName";
            this.teETFName.Size = new System.Drawing.Size(603, 20);
            this.teETFName.StyleController = this.lcEmployeeType;
            this.teETFName.TabIndex = 0;
            // 
            // teETSName
            // 
            this.teETSName.Location = new System.Drawing.Point(99, 88);
            this.teETSName.MenuManager = this.ribbonControl1;
            this.teETSName.Name = "teETSName";
            this.teETSName.Size = new System.Drawing.Size(603, 20);
            this.teETSName.StyleController = this.lcEmployeeType;
            this.teETSName.TabIndex = 2;
            // 
            // meETRemarks
            // 
            this.meETRemarks.Location = new System.Drawing.Point(99, 112);
            this.meETRemarks.MenuManager = this.ribbonControl1;
            this.meETRemarks.Name = "meETRemarks";
            this.meETRemarks.Size = new System.Drawing.Size(603, 44);
            this.meETRemarks.StyleController = this.lcEmployeeType;
            this.meETRemarks.TabIndex = 3;
            // 
            // deETDateCreated
            // 
            this.deETDateCreated.EditValue = new System.DateTime(2017, 7, 31, 16, 24, 26, 0);
            this.deETDateCreated.Location = new System.Drawing.Point(99, 160);
            this.deETDateCreated.MenuManager = this.ribbonControl1;
            this.deETDateCreated.Name = "deETDateCreated";
            this.deETDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deETDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deETDateCreated.Size = new System.Drawing.Size(538, 20);
            this.deETDateCreated.StyleController = this.lcEmployeeType;
            this.deETDateCreated.TabIndex = 4;
            // 
            // ckeETStatus
            // 
            this.ckeETStatus.EditValue = true;
            this.ckeETStatus.Location = new System.Drawing.Point(641, 160);
            this.ckeETStatus.MenuManager = this.ribbonControl1;
            this.ckeETStatus.Name = "ckeETStatus";
            this.ckeETStatus.Properties.Caption = "Active ?";
            this.ckeETStatus.Size = new System.Drawing.Size(61, 19);
            this.ckeETStatus.StyleController = this.lcEmployeeType;
            this.ckeETStatus.TabIndex = 5;
            // 
            // layoutControlGroup35
            // 
            this.layoutControlGroup35.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup35.GroupBordersVisible = false;
            this.layoutControlGroup35.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgEmpTypeDetail,
            this.splitterItem17,
            this.layoutControlItem146});
            this.layoutControlGroup35.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup35.Name = "Root";
            this.layoutControlGroup35.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup35.TextVisible = false;
            // 
            // lcgEmpTypeDetail
            // 
            this.lcgEmpTypeDetail.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgEmpTypeDetail.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgEmpTypeDetail.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgEmpTypeDetail.CaptionImage")));
            this.lcgEmpTypeDetail.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem141,
            this.layoutControlItem142,
            this.layoutControlItem143,
            this.layoutControlItem144,
            this.layoutControlItem145});
            this.lcgEmpTypeDetail.Location = new System.Drawing.Point(0, 0);
            this.lcgEmpTypeDetail.Name = "lcgEmpTypeDetail";
            this.lcgEmpTypeDetail.Size = new System.Drawing.Size(706, 184);
            this.lcgEmpTypeDetail.Text = "Employee Type Detail";
            // 
            // layoutControlItem141
            // 
            this.layoutControlItem141.Control = this.teETFName;
            this.layoutControlItem141.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem141.Name = "layoutControlItem24";
            this.layoutControlItem141.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem141.Text = "Full Name :";
            this.layoutControlItem141.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem142
            // 
            this.layoutControlItem142.Control = this.teETSName;
            this.layoutControlItem142.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem142.Name = "layoutControlItem25";
            this.layoutControlItem142.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem142.Text = "Short Name :";
            this.layoutControlItem142.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem143
            // 
            this.layoutControlItem143.Control = this.meETRemarks;
            this.layoutControlItem143.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem143.Name = "layoutControlItem26";
            this.layoutControlItem143.Size = new System.Drawing.Size(682, 48);
            this.layoutControlItem143.Text = "Remarks :";
            this.layoutControlItem143.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem144
            // 
            this.layoutControlItem144.Control = this.deETDateCreated;
            this.layoutControlItem144.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem144.Name = "layoutControlItem27";
            this.layoutControlItem144.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem144.Text = "Date Created :";
            this.layoutControlItem144.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem145
            // 
            this.layoutControlItem145.Control = this.ckeETStatus;
            this.layoutControlItem145.Location = new System.Drawing.Point(617, 96);
            this.layoutControlItem145.Name = "layoutControlItem28";
            this.layoutControlItem145.Size = new System.Drawing.Size(65, 24);
            this.layoutControlItem145.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem145.TextVisible = false;
            // 
            // splitterItem17
            // 
            this.splitterItem17.AllowHotTrack = true;
            this.splitterItem17.Location = new System.Drawing.Point(0, 184);
            this.splitterItem17.Name = "splitterItem4";
            this.splitterItem17.Size = new System.Drawing.Size(706, 5);
            // 
            // layoutControlItem146
            // 
            this.layoutControlItem146.Control = this.gcEmployeeType;
            this.layoutControlItem146.Location = new System.Drawing.Point(0, 189);
            this.layoutControlItem146.Name = "layoutControlItem29";
            this.layoutControlItem146.Size = new System.Drawing.Size(706, 126);
            this.layoutControlItem146.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem146.TextVisible = false;
            // 
            // navigationPage18
            // 
            this.navigationPage18.Controls.Add(this.lcJobType);
            this.navigationPage18.Name = "navigationPage18";
            this.navigationPage18.Size = new System.Drawing.Size(726, 335);
            this.navigationPage18.Tag = "Job Type";
            // 
            // lcJobType
            // 
            this.lcJobType.Controls.Add(this.gcJobType);
            this.lcJobType.Controls.Add(this.teJTFName);
            this.lcJobType.Controls.Add(this.teJTSName);
            this.lcJobType.Controls.Add(this.meJTRemarks);
            this.lcJobType.Controls.Add(this.deJTDateCreated);
            this.lcJobType.Controls.Add(this.ckeJTStatus);
            this.lcJobType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcJobType.Location = new System.Drawing.Point(0, 0);
            this.lcJobType.Name = "lcJobType";
            this.lcJobType.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(823, 95, 450, 400);
            this.lcJobType.Root = this.layoutControlGroup37;
            this.lcJobType.Size = new System.Drawing.Size(726, 335);
            this.lcJobType.TabIndex = 9;
            this.lcJobType.Text = "layoutControl6";
            // 
            // gcJobType
            // 
            this.gcJobType.Location = new System.Drawing.Point(12, 201);
            this.gcJobType.MainView = this.gvJobType;
            this.gcJobType.MenuManager = this.ribbonControl1;
            this.gcJobType.Name = "gcJobType";
            this.gcJobType.Size = new System.Drawing.Size(702, 122);
            this.gcJobType.TabIndex = 6;
            this.gcJobType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvJobType});
            // 
            // gvJobType
            // 
            this.gvJobType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn155,
            this.gridColumn156,
            this.gridColumn157,
            this.gridColumn158,
            this.gridColumn159,
            this.gridColumn160,
            this.gridColumn161});
            this.gvJobType.GridControl = this.gcJobType;
            this.gvJobType.Name = "gvJobType";
            this.gvJobType.OptionsBehavior.Editable = false;
            this.gvJobType.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn155
            // 
            this.gridColumn155.Caption = "ID";
            this.gridColumn155.FieldName = "jtID";
            this.gridColumn155.Name = "gridColumn155";
            // 
            // gridColumn156
            // 
            this.gridColumn156.Caption = "Full Name";
            this.gridColumn156.FieldName = "jtFName";
            this.gridColumn156.Name = "gridColumn156";
            this.gridColumn156.Visible = true;
            this.gridColumn156.VisibleIndex = 0;
            // 
            // gridColumn157
            // 
            this.gridColumn157.Caption = "Short Name";
            this.gridColumn157.FieldName = "jtSName";
            this.gridColumn157.Name = "gridColumn157";
            this.gridColumn157.Visible = true;
            this.gridColumn157.VisibleIndex = 1;
            // 
            // gridColumn158
            // 
            this.gridColumn158.Caption = "Remarks";
            this.gridColumn158.FieldName = "jtRemarks";
            this.gridColumn158.Name = "gridColumn158";
            this.gridColumn158.Visible = true;
            this.gridColumn158.VisibleIndex = 2;
            // 
            // gridColumn159
            // 
            this.gridColumn159.Caption = "Date Created";
            this.gridColumn159.FieldName = "jtDateCreated";
            this.gridColumn159.Name = "gridColumn159";
            this.gridColumn159.Visible = true;
            this.gridColumn159.VisibleIndex = 3;
            // 
            // gridColumn160
            // 
            this.gridColumn160.Caption = "Status";
            this.gridColumn160.FieldName = "jtStatus";
            this.gridColumn160.Name = "gridColumn160";
            this.gridColumn160.Visible = true;
            this.gridColumn160.VisibleIndex = 4;
            // 
            // gridColumn161
            // 
            this.gridColumn161.Caption = "Created By";
            this.gridColumn161.FieldName = "FullName";
            this.gridColumn161.Name = "gridColumn161";
            this.gridColumn161.Visible = true;
            this.gridColumn161.VisibleIndex = 5;
            // 
            // teJTFName
            // 
            this.teJTFName.Location = new System.Drawing.Point(99, 64);
            this.teJTFName.MenuManager = this.ribbonControl1;
            this.teJTFName.Name = "teJTFName";
            this.teJTFName.Size = new System.Drawing.Size(603, 20);
            this.teJTFName.StyleController = this.lcJobType;
            this.teJTFName.TabIndex = 0;
            // 
            // teJTSName
            // 
            this.teJTSName.Location = new System.Drawing.Point(99, 88);
            this.teJTSName.MenuManager = this.ribbonControl1;
            this.teJTSName.Name = "teJTSName";
            this.teJTSName.Size = new System.Drawing.Size(603, 20);
            this.teJTSName.StyleController = this.lcJobType;
            this.teJTSName.TabIndex = 2;
            // 
            // meJTRemarks
            // 
            this.meJTRemarks.Location = new System.Drawing.Point(99, 112);
            this.meJTRemarks.MenuManager = this.ribbonControl1;
            this.meJTRemarks.Name = "meJTRemarks";
            this.meJTRemarks.Size = new System.Drawing.Size(603, 44);
            this.meJTRemarks.StyleController = this.lcJobType;
            this.meJTRemarks.TabIndex = 3;
            // 
            // deJTDateCreated
            // 
            this.deJTDateCreated.EditValue = new System.DateTime(2017, 7, 31, 16, 24, 26, 0);
            this.deJTDateCreated.Location = new System.Drawing.Point(99, 160);
            this.deJTDateCreated.MenuManager = this.ribbonControl1;
            this.deJTDateCreated.Name = "deJTDateCreated";
            this.deJTDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deJTDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deJTDateCreated.Size = new System.Drawing.Size(538, 20);
            this.deJTDateCreated.StyleController = this.lcJobType;
            this.deJTDateCreated.TabIndex = 4;
            // 
            // ckeJTStatus
            // 
            this.ckeJTStatus.EditValue = true;
            this.ckeJTStatus.Location = new System.Drawing.Point(641, 160);
            this.ckeJTStatus.MenuManager = this.ribbonControl1;
            this.ckeJTStatus.Name = "ckeJTStatus";
            this.ckeJTStatus.Properties.Caption = "Active ?";
            this.ckeJTStatus.Size = new System.Drawing.Size(61, 19);
            this.ckeJTStatus.StyleController = this.lcJobType;
            this.ckeJTStatus.TabIndex = 5;
            // 
            // layoutControlGroup37
            // 
            this.layoutControlGroup37.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup37.GroupBordersVisible = false;
            this.layoutControlGroup37.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgJTDetail,
            this.splitterItem18,
            this.layoutControlItem152});
            this.layoutControlGroup37.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup37.Name = "Root";
            this.layoutControlGroup37.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup37.TextVisible = false;
            // 
            // lcgJTDetail
            // 
            this.lcgJTDetail.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgJTDetail.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgJTDetail.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgJTDetail.CaptionImage")));
            this.lcgJTDetail.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem147,
            this.layoutControlItem148,
            this.layoutControlItem149,
            this.layoutControlItem150,
            this.layoutControlItem151});
            this.lcgJTDetail.Location = new System.Drawing.Point(0, 0);
            this.lcgJTDetail.Name = "lcgJTDetail";
            this.lcgJTDetail.Size = new System.Drawing.Size(706, 184);
            this.lcgJTDetail.Text = "Job Type Detail";
            // 
            // layoutControlItem147
            // 
            this.layoutControlItem147.Control = this.teJTFName;
            this.layoutControlItem147.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem147.Name = "layoutControlItem24";
            this.layoutControlItem147.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem147.Text = "Full Name :";
            this.layoutControlItem147.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem148
            // 
            this.layoutControlItem148.Control = this.teJTSName;
            this.layoutControlItem148.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem148.Name = "layoutControlItem25";
            this.layoutControlItem148.Size = new System.Drawing.Size(682, 24);
            this.layoutControlItem148.Text = "Short Name :";
            this.layoutControlItem148.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem149
            // 
            this.layoutControlItem149.Control = this.meJTRemarks;
            this.layoutControlItem149.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem149.Name = "layoutControlItem26";
            this.layoutControlItem149.Size = new System.Drawing.Size(682, 48);
            this.layoutControlItem149.Text = "Remarks :";
            this.layoutControlItem149.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem150
            // 
            this.layoutControlItem150.Control = this.deJTDateCreated;
            this.layoutControlItem150.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem150.Name = "layoutControlItem27";
            this.layoutControlItem150.Size = new System.Drawing.Size(617, 24);
            this.layoutControlItem150.Text = "Date Created :";
            this.layoutControlItem150.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem151
            // 
            this.layoutControlItem151.Control = this.ckeJTStatus;
            this.layoutControlItem151.Location = new System.Drawing.Point(617, 96);
            this.layoutControlItem151.Name = "layoutControlItem28";
            this.layoutControlItem151.Size = new System.Drawing.Size(65, 24);
            this.layoutControlItem151.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem151.TextVisible = false;
            // 
            // splitterItem18
            // 
            this.splitterItem18.AllowHotTrack = true;
            this.splitterItem18.Location = new System.Drawing.Point(0, 184);
            this.splitterItem18.Name = "splitterItem4";
            this.splitterItem18.Size = new System.Drawing.Size(706, 5);
            // 
            // layoutControlItem152
            // 
            this.layoutControlItem152.Control = this.gcJobType;
            this.layoutControlItem152.Location = new System.Drawing.Point(0, 189);
            this.layoutControlItem152.Name = "layoutControlItem29";
            this.layoutControlItem152.Size = new System.Drawing.Size(706, 126);
            this.layoutControlItem152.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem152.TextVisible = false;
            // 
            // navigationPage19
            // 
            this.navigationPage19.Controls.Add(this.lcFormAccess);
            this.navigationPage19.Name = "navigationPage19";
            this.navigationPage19.Size = new System.Drawing.Size(726, 335);
            this.navigationPage19.Tag = "Form Access";
            // 
            // lcFormAccess
            // 
            this.lcFormAccess.Controls.Add(this.gcUsers);
            this.lcFormAccess.Controls.Add(this.gcForms);
            this.lcFormAccess.Controls.Add(this.ckeFAReadAll);
            this.lcFormAccess.Controls.Add(this.ckeFAEditAll);
            this.lcFormAccess.Controls.Add(this.ckeFAWriteAll);
            this.lcFormAccess.Controls.Add(this.ckeFAAddAll);
            this.lcFormAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcFormAccess.Location = new System.Drawing.Point(0, 0);
            this.lcFormAccess.Name = "lcFormAccess";
            this.lcFormAccess.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(832, 314, 450, 400);
            this.lcFormAccess.Root = this.layoutControlGroup20;
            this.lcFormAccess.Size = new System.Drawing.Size(726, 335);
            this.lcFormAccess.TabIndex = 9;
            this.lcFormAccess.Text = "layoutControl6";
            // 
            // gcUsers
            // 
            this.gcUsers.Location = new System.Drawing.Point(24, 280);
            this.gcUsers.MainView = this.gvUsers;
            this.gcUsers.MenuManager = this.ribbonControl1;
            this.gcUsers.Name = "gcUsers";
            this.gcUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riUsersAdd});
            this.gcUsers.Size = new System.Drawing.Size(678, 31);
            this.gcUsers.TabIndex = 7;
            this.gcUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUsers});
            // 
            // gvUsers
            // 
            this.gvUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn182,
            this.gridColumn186,
            this.gridColumn183,
            this.gridColumn185,
            this.gridColumn187,
            this.gridColumn188,
            this.gridColumn184});
            this.gvUsers.GridControl = this.gcUsers;
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            this.gvUsers.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvUsers_CustomUnboundColumnData);
            // 
            // gridColumn182
            // 
            this.gridColumn182.Caption = "ID";
            this.gridColumn182.FieldName = "sfID";
            this.gridColumn182.Name = "gridColumn182";
            // 
            // gridColumn186
            // 
            this.gridColumn186.Caption = "Add";
            this.gridColumn186.ColumnEdit = this.riUsersAdd;
            this.gridColumn186.FieldName = "gridColumn186";
            this.gridColumn186.Name = "gridColumn186";
            this.gridColumn186.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn186.Visible = true;
            this.gridColumn186.VisibleIndex = 0;
            // 
            // riUsersAdd
            // 
            this.riUsersAdd.AutoHeight = false;
            this.riUsersAdd.Name = "riUsersAdd";
            // 
            // gridColumn183
            // 
            this.gridColumn183.Caption = "Full Name";
            this.gridColumn183.FieldName = "sfFullName";
            this.gridColumn183.Name = "gridColumn183";
            this.gridColumn183.OptionsColumn.AllowEdit = false;
            this.gridColumn183.Visible = true;
            this.gridColumn183.VisibleIndex = 1;
            // 
            // gridColumn185
            // 
            this.gridColumn185.Caption = "Staff ID";
            this.gridColumn185.FieldName = "sfStaffID";
            this.gridColumn185.Name = "gridColumn185";
            this.gridColumn185.OptionsColumn.AllowEdit = false;
            this.gridColumn185.Visible = true;
            this.gridColumn185.VisibleIndex = 2;
            // 
            // gridColumn187
            // 
            this.gridColumn187.Caption = "Job Type";
            this.gridColumn187.FieldName = "jtFName";
            this.gridColumn187.Name = "gridColumn187";
            this.gridColumn187.OptionsColumn.AllowEdit = false;
            this.gridColumn187.Visible = true;
            this.gridColumn187.VisibleIndex = 3;
            // 
            // gridColumn188
            // 
            this.gridColumn188.Caption = "Employee Type";
            this.gridColumn188.FieldName = "etFName";
            this.gridColumn188.Name = "gridColumn188";
            this.gridColumn188.OptionsColumn.AllowEdit = false;
            this.gridColumn188.Visible = true;
            this.gridColumn188.VisibleIndex = 4;
            // 
            // gridColumn184
            // 
            this.gridColumn184.Caption = "Image";
            this.gridColumn184.FieldName = "sfImage";
            this.gridColumn184.Name = "gridColumn184";
            this.gridColumn184.OptionsColumn.AllowEdit = false;
            this.gridColumn184.Visible = true;
            this.gridColumn184.VisibleIndex = 5;
            // 
            // gcForms
            // 
            this.gcForms.Location = new System.Drawing.Point(24, 87);
            this.gcForms.MainView = this.gvForms;
            this.gcForms.MenuManager = this.ribbonControl1;
            this.gcForms.Name = "gcForms";
            this.gcForms.Size = new System.Drawing.Size(678, 97);
            this.gcForms.TabIndex = 6;
            this.gcForms.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvForms});
            // 
            // gvForms
            // 
            this.gvForms.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn176,
            this.gridColumn177,
            this.gridColumn178,
            this.gridColumn179,
            this.gridColumn180,
            this.gridColumn181});
            this.gvForms.GridControl = this.gcForms;
            this.gvForms.Name = "gvForms";
            // 
            // gridColumn176
            // 
            this.gridColumn176.Caption = "ID";
            this.gridColumn176.FieldName = "frmID";
            this.gridColumn176.Name = "gridColumn176";
            // 
            // gridColumn177
            // 
            this.gridColumn177.Caption = "Form Name";
            this.gridColumn177.FieldName = "frmFName";
            this.gridColumn177.Name = "gridColumn177";
            this.gridColumn177.OptionsColumn.AllowEdit = false;
            this.gridColumn177.Visible = true;
            this.gridColumn177.VisibleIndex = 0;
            // 
            // gridColumn178
            // 
            this.gridColumn178.Caption = "Description";
            this.gridColumn178.FieldName = "frmDescription";
            this.gridColumn178.Name = "gridColumn178";
            this.gridColumn178.OptionsColumn.AllowEdit = false;
            this.gridColumn178.Visible = true;
            this.gridColumn178.VisibleIndex = 4;
            // 
            // gridColumn179
            // 
            this.gridColumn179.Caption = "Read";
            this.gridColumn179.FieldName = "frmRead";
            this.gridColumn179.Name = "gridColumn179";
            this.gridColumn179.OptionsColumn.FixedWidth = true;
            this.gridColumn179.Visible = true;
            this.gridColumn179.VisibleIndex = 1;
            // 
            // gridColumn180
            // 
            this.gridColumn180.Caption = "Write";
            this.gridColumn180.FieldName = "frmWrite";
            this.gridColumn180.Name = "gridColumn180";
            this.gridColumn180.OptionsColumn.FixedWidth = true;
            this.gridColumn180.Visible = true;
            this.gridColumn180.VisibleIndex = 2;
            // 
            // gridColumn181
            // 
            this.gridColumn181.Caption = "Edit";
            this.gridColumn181.FieldName = "frmEdit";
            this.gridColumn181.Name = "gridColumn181";
            this.gridColumn181.OptionsColumn.FixedWidth = true;
            this.gridColumn181.Visible = true;
            this.gridColumn181.VisibleIndex = 3;
            // 
            // ckeFAReadAll
            // 
            this.ckeFAReadAll.Location = new System.Drawing.Point(24, 64);
            this.ckeFAReadAll.MenuManager = this.ribbonControl1;
            this.ckeFAReadAll.Name = "ckeFAReadAll";
            this.ckeFAReadAll.Properties.Caption = "Read All ?";
            this.ckeFAReadAll.Size = new System.Drawing.Size(69, 19);
            this.ckeFAReadAll.StyleController = this.lcFormAccess;
            this.ckeFAReadAll.TabIndex = 8;
            this.ckeFAReadAll.CheckedChanged += new System.EventHandler(this.ckeFAReadAll_CheckedChanged);
            // 
            // ckeFAEditAll
            // 
            this.ckeFAEditAll.Location = new System.Drawing.Point(171, 64);
            this.ckeFAEditAll.MenuManager = this.ribbonControl1;
            this.ckeFAEditAll.Name = "ckeFAEditAll";
            this.ckeFAEditAll.Properties.Caption = "Edit All  ?";
            this.ckeFAEditAll.Size = new System.Drawing.Size(531, 19);
            this.ckeFAEditAll.StyleController = this.lcFormAccess;
            this.ckeFAEditAll.TabIndex = 9;
            this.ckeFAEditAll.CheckedChanged += new System.EventHandler(this.ckeFAEditAll_CheckedChanged);
            // 
            // ckeFAWriteAll
            // 
            this.ckeFAWriteAll.Location = new System.Drawing.Point(97, 64);
            this.ckeFAWriteAll.MenuManager = this.ribbonControl1;
            this.ckeFAWriteAll.Name = "ckeFAWriteAll";
            this.ckeFAWriteAll.Properties.Caption = "Write All ?";
            this.ckeFAWriteAll.Size = new System.Drawing.Size(70, 19);
            this.ckeFAWriteAll.StyleController = this.lcFormAccess;
            this.ckeFAWriteAll.TabIndex = 10;
            this.ckeFAWriteAll.CheckedChanged += new System.EventHandler(this.ckeFAWriteAll_CheckedChanged);
            // 
            // ckeFAAddAll
            // 
            this.ckeFAAddAll.Location = new System.Drawing.Point(24, 257);
            this.ckeFAAddAll.MenuManager = this.ribbonControl1;
            this.ckeFAAddAll.Name = "ckeFAAddAll";
            this.ckeFAAddAll.Properties.Caption = "Add All ?";
            this.ckeFAAddAll.Size = new System.Drawing.Size(678, 19);
            this.ckeFAAddAll.StyleController = this.lcFormAccess;
            this.ckeFAAddAll.TabIndex = 11;
            this.ckeFAAddAll.CheckedChanged += new System.EventHandler(this.ckeFAAddAll_CheckedChanged);
            // 
            // layoutControlGroup20
            // 
            this.layoutControlGroup20.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup20.GroupBordersVisible = false;
            this.layoutControlGroup20.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.splitterItem19,
            this.lcgForms,
            this.layoutControlGroup39});
            this.layoutControlGroup20.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup20.Name = "Root";
            this.layoutControlGroup20.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup20.TextVisible = false;
            // 
            // splitterItem19
            // 
            this.splitterItem19.AllowHotTrack = true;
            this.splitterItem19.Location = new System.Drawing.Point(0, 188);
            this.splitterItem19.Name = "splitterItem4";
            this.splitterItem19.Size = new System.Drawing.Size(706, 5);
            // 
            // lcgForms
            // 
            this.lcgForms.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lcgForms.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lcgForms.CaptionImage = ((System.Drawing.Image)(resources.GetObject("lcgForms.CaptionImage")));
            this.lcgForms.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem154,
            this.layoutControlItem158,
            this.layoutControlItem155,
            this.layoutControlItem156});
            this.lcgForms.Location = new System.Drawing.Point(0, 0);
            this.lcgForms.Name = "lcgForms";
            this.lcgForms.Size = new System.Drawing.Size(706, 188);
            this.lcgForms.Text = "Forms";
            // 
            // layoutControlItem154
            // 
            this.layoutControlItem154.Control = this.ckeFAReadAll;
            this.layoutControlItem154.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem154.Name = "layoutControlItem154";
            this.layoutControlItem154.Size = new System.Drawing.Size(73, 23);
            this.layoutControlItem154.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem154.TextVisible = false;
            // 
            // layoutControlItem158
            // 
            this.layoutControlItem158.Control = this.gcForms;
            this.layoutControlItem158.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem158.Name = "layoutControlItem29";
            this.layoutControlItem158.Size = new System.Drawing.Size(682, 101);
            this.layoutControlItem158.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem158.TextVisible = false;
            // 
            // layoutControlItem155
            // 
            this.layoutControlItem155.Control = this.ckeFAEditAll;
            this.layoutControlItem155.Location = new System.Drawing.Point(147, 0);
            this.layoutControlItem155.Name = "layoutControlItem155";
            this.layoutControlItem155.Size = new System.Drawing.Size(535, 23);
            this.layoutControlItem155.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem155.TextVisible = false;
            // 
            // layoutControlItem156
            // 
            this.layoutControlItem156.Control = this.ckeFAWriteAll;
            this.layoutControlItem156.Location = new System.Drawing.Point(73, 0);
            this.layoutControlItem156.Name = "layoutControlItem156";
            this.layoutControlItem156.Size = new System.Drawing.Size(74, 23);
            this.layoutControlItem156.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem156.TextVisible = false;
            // 
            // layoutControlGroup39
            // 
            this.layoutControlGroup39.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlGroup39.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlGroup39.CaptionImage = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup39.CaptionImage")));
            this.layoutControlGroup39.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem153,
            this.layoutControlItem157});
            this.layoutControlGroup39.Location = new System.Drawing.Point(0, 193);
            this.layoutControlGroup39.Name = "layoutControlGroup39";
            this.layoutControlGroup39.Size = new System.Drawing.Size(706, 122);
            this.layoutControlGroup39.Text = "Users";
            // 
            // layoutControlItem153
            // 
            this.layoutControlItem153.Control = this.gcUsers;
            this.layoutControlItem153.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem153.Name = "layoutControlItem153";
            this.layoutControlItem153.Size = new System.Drawing.Size(682, 35);
            this.layoutControlItem153.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem153.TextVisible = false;
            // 
            // layoutControlItem157
            // 
            this.layoutControlItem157.Control = this.ckeFAAddAll;
            this.layoutControlItem157.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem157.Name = "layoutControlItem157";
            this.layoutControlItem157.Size = new System.Drawing.Size(682, 23);
            this.layoutControlItem157.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem157.TextVisible = false;
            // 
            // navigationPage20
            // 
            this.navigationPage20.Controls.Add(this.dashboardViewer1);
            this.navigationPage20.Name = "navigationPage20";
            this.navigationPage20.Size = new System.Drawing.Size(726, 335);
            this.navigationPage20.Tag = "DashBoard";
            // 
            // dashboardViewer1
            // 
            this.dashboardViewer1.CustomDBSchemaProviderEx = null;
            this.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardViewer1.Location = new System.Drawing.Point(0, 0);
            this.dashboardViewer1.Name = "dashboardViewer1";
            this.dashboardViewer1.Size = new System.Drawing.Size(726, 335);
            this.dashboardViewer1.TabIndex = 6;
            this.dashboardViewer1.DashboardLoaded += new DevExpress.DashboardWin.DashboardLoadedEventHandler(this.dashboardViewer1_DashboardLoaded);
            this.dashboardViewer1.ConfigureDataConnection += new DevExpress.DashboardCommon.DashboardConfigureDataConnectionEventHandler(this.dashboardViewer1_ConfigureDataConnection);
            this.dashboardViewer1.DataLoading += new DevExpress.DashboardCommon.DataLoadingEventHandler(this.dashboardViewer1_DataLoading);
            // 
            // navigationPage21
            // 
            this.navigationPage21.Controls.Add(this.lcCustomerCar);
            this.navigationPage21.Name = "navigationPage21";
            this.navigationPage21.Size = new System.Drawing.Size(726, 335);
            this.navigationPage21.Tag = "Customer Cars";
            // 
            // lcCustomerCar
            // 
            this.lcCustomerCar.Controls.Add(this.leCCCar);
            this.lcCustomerCar.Controls.Add(this.leCCCustomer);
            this.lcCustomerCar.Controls.Add(this.gcCustomerCar);
            this.lcCustomerCar.Controls.Add(this.meCCRemarks);
            this.lcCustomerCar.Controls.Add(this.deCCDateCreated);
            this.lcCustomerCar.Controls.Add(this.ckeCCStatus);
            this.lcCustomerCar.Controls.Add(this.teCCRegNum);
            this.lcCustomerCar.Controls.Add(this.teCCVIN);
            this.lcCustomerCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcCustomerCar.Location = new System.Drawing.Point(0, 0);
            this.lcCustomerCar.Name = "lcCustomerCar";
            this.lcCustomerCar.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(859, 201, 450, 400);
            this.lcCustomerCar.Root = this.layoutControlGroup2;
            this.lcCustomerCar.Size = new System.Drawing.Size(726, 335);
            this.lcCustomerCar.TabIndex = 1;
            this.lcCustomerCar.Text = "layoutControl1";
            // 
            // leCCCar
            // 
            this.leCCCar.Location = new System.Drawing.Point(453, 64);
            this.leCCCar.MenuManager = this.ribbonControl1;
            this.leCCCar.Name = "leCCCar";
            this.leCCCar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.leCCCar.Properties.NullText = "Select a Car";
            this.leCCCar.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leCCCar.Size = new System.Drawing.Size(249, 20);
            this.leCCCar.StyleController = this.lcCustomerCar;
            this.leCCCar.TabIndex = 10;
            // 
            // leCCCustomer
            // 
            this.leCCCustomer.Location = new System.Drawing.Point(112, 64);
            this.leCCCustomer.MenuManager = this.ribbonControl1;
            this.leCCCustomer.Name = "leCCCustomer";
            this.leCCCustomer.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            this.leCCCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leCCCustomer.Properties.NullText = "Select a Customer";
            this.leCCCustomer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leCCCustomer.Size = new System.Drawing.Size(249, 20);
            this.leCCCustomer.StyleController = this.lcCustomerCar;
            this.leCCCustomer.TabIndex = 4;
            this.leCCCustomer.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.leCCCustomer_ProcessNewValue);
            // 
            // gcCustomerCar
            // 
            this.gcCustomerCar.Location = new System.Drawing.Point(12, 196);
            this.gcCustomerCar.MainView = this.gvCustomerCar;
            this.gcCustomerCar.Name = "gcCustomerCar";
            this.gcCustomerCar.Size = new System.Drawing.Size(702, 127);
            this.gcCustomerCar.TabIndex = 9;
            this.gcCustomerCar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCustomerCar});
            // 
            // gvCustomerCar
            // 
            this.gvCustomerCar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn192,
            this.gridColumn193,
            this.gridColumn195,
            this.gridColumn199,
            this.gridColumn196,
            this.gridColumn197,
            this.gridColumn198,
            this.gridColumn200});
            this.gvCustomerCar.GridControl = this.gcCustomerCar;
            this.gvCustomerCar.Name = "gvCustomerCar";
            this.gvCustomerCar.OptionsBehavior.Editable = false;
            this.gvCustomerCar.OptionsBehavior.ReadOnly = true;
            this.gvCustomerCar.OptionsCustomization.AllowRowSizing = true;
            this.gvCustomerCar.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCustomerCar.OptionsView.EnableAppearanceOddRow = true;
            this.gvCustomerCar.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "ccID";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn192
            // 
            this.gridColumn192.Caption = "Customer";
            this.gridColumn192.FieldName = "cusfname";
            this.gridColumn192.Name = "gridColumn192";
            this.gridColumn192.Visible = true;
            this.gridColumn192.VisibleIndex = 0;
            // 
            // gridColumn193
            // 
            this.gridColumn193.Caption = "Car";
            this.gridColumn193.FieldName = "carfname";
            this.gridColumn193.Name = "gridColumn193";
            this.gridColumn193.Visible = true;
            this.gridColumn193.VisibleIndex = 1;
            // 
            // gridColumn195
            // 
            this.gridColumn195.Caption = "VIN";
            this.gridColumn195.FieldName = "ccVIN";
            this.gridColumn195.Name = "gridColumn195";
            this.gridColumn195.Visible = true;
            this.gridColumn195.VisibleIndex = 2;
            // 
            // gridColumn199
            // 
            this.gridColumn199.Caption = "Registration No.";
            this.gridColumn199.FieldName = "ccRegistrationNum";
            this.gridColumn199.Name = "gridColumn199";
            this.gridColumn199.Visible = true;
            this.gridColumn199.VisibleIndex = 3;
            // 
            // gridColumn196
            // 
            this.gridColumn196.Caption = "Remarks";
            this.gridColumn196.FieldName = "ccRemarks";
            this.gridColumn196.Name = "gridColumn196";
            this.gridColumn196.Visible = true;
            this.gridColumn196.VisibleIndex = 4;
            // 
            // gridColumn197
            // 
            this.gridColumn197.Caption = "Date Created";
            this.gridColumn197.FieldName = "ccDateCreated";
            this.gridColumn197.Name = "gridColumn197";
            this.gridColumn197.Visible = true;
            this.gridColumn197.VisibleIndex = 5;
            // 
            // gridColumn198
            // 
            this.gridColumn198.Caption = "Status";
            this.gridColumn198.FieldName = "ccStatus";
            this.gridColumn198.Name = "gridColumn198";
            this.gridColumn198.Visible = true;
            this.gridColumn198.VisibleIndex = 6;
            // 
            // gridColumn200
            // 
            this.gridColumn200.Caption = "Created By";
            this.gridColumn200.FieldName = "FullName";
            this.gridColumn200.Name = "gridColumn200";
            this.gridColumn200.Visible = true;
            this.gridColumn200.VisibleIndex = 7;
            // 
            // meCCRemarks
            // 
            this.meCCRemarks.Location = new System.Drawing.Point(112, 112);
            this.meCCRemarks.MenuManager = this.ribbonControl1;
            this.meCCRemarks.Name = "meCCRemarks";
            this.meCCRemarks.Size = new System.Drawing.Size(590, 39);
            this.meCCRemarks.StyleController = this.lcCustomerCar;
            this.meCCRemarks.TabIndex = 6;
            // 
            // deCCDateCreated
            // 
            this.deCCDateCreated.EditValue = new System.DateTime(2017, 7, 27, 13, 34, 35, 0);
            this.deCCDateCreated.Location = new System.Drawing.Point(112, 155);
            this.deCCDateCreated.MenuManager = this.ribbonControl1;
            this.deCCDateCreated.Name = "deCCDateCreated";
            this.deCCDateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCCDateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCCDateCreated.Size = new System.Drawing.Size(526, 20);
            this.deCCDateCreated.StyleController = this.lcCustomerCar;
            this.deCCDateCreated.TabIndex = 7;
            // 
            // ckeCCStatus
            // 
            this.ckeCCStatus.EditValue = true;
            this.ckeCCStatus.Location = new System.Drawing.Point(642, 155);
            this.ckeCCStatus.MenuManager = this.ribbonControl1;
            this.ckeCCStatus.Name = "ckeCCStatus";
            this.ckeCCStatus.Properties.Caption = "Active ?";
            this.ckeCCStatus.Size = new System.Drawing.Size(60, 19);
            this.ckeCCStatus.StyleController = this.lcCustomerCar;
            this.ckeCCStatus.TabIndex = 8;
            // 
            // teCCRegNum
            // 
            this.teCCRegNum.Location = new System.Drawing.Point(453, 88);
            this.teCCRegNum.MenuManager = this.ribbonControl1;
            this.teCCRegNum.Name = "teCCRegNum";
            this.teCCRegNum.Size = new System.Drawing.Size(249, 20);
            this.teCCRegNum.StyleController = this.lcCustomerCar;
            this.teCCRegNum.TabIndex = 11;
            // 
            // teCCVIN
            // 
            this.teCCVIN.Location = new System.Drawing.Point(112, 88);
            this.teCCVIN.MenuManager = this.ribbonControl1;
            this.teCCVIN.Name = "teCCVIN";
            this.teCCVIN.Size = new System.Drawing.Size(249, 20);
            this.teCCVIN.StyleController = this.lcCustomerCar;
            this.teCCVIN.TabIndex = 12;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlGroup4,
            this.splitterItem20});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(726, 335);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.gcCustomerCar;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 184);
            this.layoutControlItem7.Name = "layoutControlItem2";
            this.layoutControlItem7.Size = new System.Drawing.Size(706, 131);
            this.layoutControlItem7.Text = "Detail View";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlGroup4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlGroup4.CaptionImage = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup4.CaptionImage")));
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem163,
            this.layoutControlItem164,
            this.layoutControlItem165,
            this.layoutControlItem168,
            this.layoutControlItem162,
            this.layoutControlItem161,
            this.layoutControlItem166});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "lcgCarDetail";
            this.layoutControlGroup4.Size = new System.Drawing.Size(706, 179);
            this.layoutControlGroup4.Text = "Customer Car Details";
            // 
            // layoutControlItem163
            // 
            this.layoutControlItem163.Control = this.meCCRemarks;
            this.layoutControlItem163.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem163.Name = "layoutControlItem9";
            this.layoutControlItem163.Size = new System.Drawing.Size(682, 43);
            this.layoutControlItem163.Text = "Remarks :";
            this.layoutControlItem163.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem164
            // 
            this.layoutControlItem164.Control = this.deCCDateCreated;
            this.layoutControlItem164.Location = new System.Drawing.Point(0, 91);
            this.layoutControlItem164.Name = "layoutControlItem10";
            this.layoutControlItem164.Size = new System.Drawing.Size(618, 24);
            this.layoutControlItem164.Text = "Date Created :";
            this.layoutControlItem164.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem165
            // 
            this.layoutControlItem165.Control = this.ckeCCStatus;
            this.layoutControlItem165.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem165.Location = new System.Drawing.Point(618, 91);
            this.layoutControlItem165.Name = "layoutControlItem11";
            this.layoutControlItem165.Size = new System.Drawing.Size(64, 24);
            this.layoutControlItem165.Text = "Status";
            this.layoutControlItem165.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem165.TextVisible = false;
            // 
            // layoutControlItem168
            // 
            this.layoutControlItem168.Control = this.leCCCustomer;
            this.layoutControlItem168.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem168.Name = "layoutControlItem6";
            this.layoutControlItem168.Size = new System.Drawing.Size(341, 24);
            this.layoutControlItem168.Text = "Customer :";
            this.layoutControlItem168.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem162
            // 
            this.layoutControlItem162.Control = this.teCCRegNum;
            this.layoutControlItem162.Location = new System.Drawing.Point(341, 24);
            this.layoutControlItem162.Name = "layoutControlItem162";
            this.layoutControlItem162.Size = new System.Drawing.Size(341, 24);
            this.layoutControlItem162.Text = "Registration No. :";
            this.layoutControlItem162.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem161
            // 
            this.layoutControlItem161.Control = this.leCCCar;
            this.layoutControlItem161.Location = new System.Drawing.Point(341, 0);
            this.layoutControlItem161.Name = "layoutControlItem161";
            this.layoutControlItem161.Size = new System.Drawing.Size(341, 24);
            this.layoutControlItem161.Text = "Car :";
            this.layoutControlItem161.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem166
            // 
            this.layoutControlItem166.Control = this.teCCVIN;
            this.layoutControlItem166.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem166.Name = "layoutControlItem166";
            this.layoutControlItem166.Size = new System.Drawing.Size(341, 24);
            this.layoutControlItem166.Text = "VIN :";
            this.layoutControlItem166.TextSize = new System.Drawing.Size(85, 13);
            // 
            // splitterItem20
            // 
            this.splitterItem20.AllowHotTrack = true;
            this.splitterItem20.Location = new System.Drawing.Point(0, 179);
            this.splitterItem20.Name = "splitterItem1";
            this.splitterItem20.Size = new System.Drawing.Size(706, 5);
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.barHeaderItem1);
            this.popupMenu1.ItemLinks.Add(this.bbiSave);
            this.popupMenu1.ItemLinks.Add(this.bbiNew);
            this.popupMenu1.ItemLinks.Add(this.bciEdit);
            this.popupMenu1.ItemLinks.Add(this.bbiDelete);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // layoutControlItem32
            // 
            this.layoutControlItem32.Location = new System.Drawing.Point(0, 315);
            this.layoutControlItem32.Name = "layoutControlItem32";
            this.layoutControlItem32.Size = new System.Drawing.Size(699, 25);
            this.layoutControlItem32.TextSize = new System.Drawing.Size(50, 20);
            // 
            // gridColumn44
            // 
            this.gridColumn44.Caption = "Created By";
            this.gridColumn44.FieldName = "sfFName";
            this.gridColumn44.Name = "gridColumn44";
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "Edit";
            this.barToggleSwitchItem1.Id = 20;
            this.barToggleSwitchItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barToggleSwitchItem1.ImageOptions.Image")));
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            this.barToggleSwitchItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Id = -1;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 554);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.officeNavigationBar1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "UNIMECH AUTO SERVICE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcCars)).EndInit();
            this.lcCars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leCarManufacturer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            this.backstageViewClientControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teUIUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUIPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUINewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUIComfirmPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peUIImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem98)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem99)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciComfirmPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem104)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChangePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCarFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCarSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCarImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meCarRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCarDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCarDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeCarStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCarYear.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCarYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCarDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcCarManufacturer)).EndInit();
            this.lcCarManufacturer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCarManufacturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCarManufacturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCMFname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCMSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meCMRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCMDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCMDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeCMStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCarMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            this.navigationPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcProduct)).EndInit();
            this.lcProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePdFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePdUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePdSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mePdRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePdDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePdDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckePdStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePdVatRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePdTaxRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPNS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            this.navigationPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcTitle)).EndInit();
            this.lcTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTittles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTitles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meTRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeTStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem4)).EndInit();
            this.navigationPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcCustomers)).EndInit();
            this.lcCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leCDTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCDFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCDPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCDSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCDID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCDAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meCDRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeCDStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCDDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCDDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem40)).EndInit();
            this.navigationPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcServiceType)).EndInit();
            this.lcServiceType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcServiceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvServiceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSTFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSTSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meSTRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSTDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSTDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeSTStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgServiceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem47)).EndInit();
            this.navigationPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcCarServicing)).EndInit();
            this.lcCarServicing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leDCSServiceType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leDCSCar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leDCSCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCarServicing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCarServicing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCEAddItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSEQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSEDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSEVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSETax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDCSDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDCSDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDCSRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDCSAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDCSChange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDCSBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDCSTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgProdAndServ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCarServDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem159)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem160)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTotalAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem50)).EndInit();
            this.navigationPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcProductPrice)).EndInit();
            this.lcProductPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lePPProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductPrices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePPUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePPDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dePPDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckePPStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePPTaxRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sePPVatRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mePPRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgProdPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem9)).EndInit();
            this.navigationPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcCompanyInfo)).EndInit();
            this.lcCompanyInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCompanyInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompanyInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCISlogan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCIDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCIDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeCIStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meCIRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCIFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCISName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCIPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCIAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCILogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCompanyInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem74)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem10)).EndInit();
            this.navigationPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcEmployee)).EndInit();
            this.lcEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leSfQualification.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSfJobType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSfEmployeeType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSfMStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSfTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSfGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSfRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSfCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSfTown.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSFOName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSfDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSfDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeSfStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meSfRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSfFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSfPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSfAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSfImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSfLName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSfDOB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSfDOB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSfEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSfStaffID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSfStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSfStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSfEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSfEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcgEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSfPersonalInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem76)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem77)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem79)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem84)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem86)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem88)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem82)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem91)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem78)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem83)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem85)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem89)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSfJobSpec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem93)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem94)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem95)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem92)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem97)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem96)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem70)).EndInit();
            this.navigationPage11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcGender)).EndInit();
            this.lcGender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teGFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teGSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meGRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deGDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deGDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeGStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem102)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem103)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem105)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem106)).EndInit();
            this.navigationPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcMaritalStatus)).EndInit();
            this.lcMaritalStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMaritalStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaritalStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMSFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMSSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meMSRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deMSDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deMSDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeMSStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem107)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem108)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem109)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem110)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem112)).EndInit();
            this.navigationPage13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcCountry)).EndInit();
            this.lcCountry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teConFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teConSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meConRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deConDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deConDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeConStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCountryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem113)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem114)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem115)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem116)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem117)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem118)).EndInit();
            this.navigationPage14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcRegion)).EndInit();
            this.lcRegion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRegFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRegSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meRegRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRegDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRegDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeRegStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leRegCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem119)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem120)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem121)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem122)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem123)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem125)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem124)).EndInit();
            this.navigationPage15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcTown)).EndInit();
            this.lcTown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leTwnCountry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTwnFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTwnSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meTwnRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTwnDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deTwnDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeTwnStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leTwnRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem126)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem127)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem128)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem129)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem130)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem134)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem133)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem132)).EndInit();
            this.navigationPage16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcQualification)).EndInit();
            this.lcQualification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcQualification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvQualification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meQRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deQDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deQDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeQStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgQualification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem135)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem136)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem137)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem138)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem139)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem140)).EndInit();
            this.navigationPage17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcEmployeeType)).EndInit();
            this.lcEmployeeType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teETFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teETSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meETRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deETDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deETDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeETStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgEmpTypeDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem141)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem142)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem143)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem144)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem145)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem146)).EndInit();
            this.navigationPage18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcJobType)).EndInit();
            this.lcJobType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcJobType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvJobType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJTFName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teJTSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meJTRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deJTDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deJTDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeJTStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgJTDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem147)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem148)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem149)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem150)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem151)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem152)).EndInit();
            this.navigationPage19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcFormAccess)).EndInit();
            this.lcFormAccess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riUsersAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeFAReadAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeFAEditAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeFAWriteAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeFAAddAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem154)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem158)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem155)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem156)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem153)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem157)).EndInit();
            this.navigationPage20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).EndInit();
            this.navigationPage21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcCustomerCar)).EndInit();
            this.lcCustomerCar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leCCCar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leCCCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meCCRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCCDateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCCDateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeCCStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCCRegNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCCVIN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem163)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem164)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem165)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem168)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem162)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem161)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem166)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGpSetup;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraNavBar.NavBarItem nbiCars;
        private DevExpress.XtraNavBar.NavBarItem nbiCarManufacturer;
        private DevExpress.XtraNavBar.NavBarGroup navBarGpEntry;
        private DevExpress.XtraNavBar.NavBarGroup navBarGpAdmin;
        private DevExpress.XtraLayout.LayoutControl lcCars;
        private DevExpress.XtraGrid.GridControl gcCars;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCars;
        private DevExpress.XtraEditors.TextEdit teCarFName;
        private DevExpress.XtraLayout.LayoutControlGroup lcgCars;
        private DevExpress.XtraLayout.LayoutControlGroup lcgCarDetail;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.LayoutControl lcCarManufacturer;
        private DevExpress.XtraGrid.GridControl gcCarManufacturer;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCarManufacturer;
        private DevExpress.XtraEditors.TextEdit teCMFname;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraEditors.TextEdit teCarSName;
        private DevExpress.XtraEditors.PictureEdit peCarImage;
        private DevExpress.XtraEditors.MemoEdit meCarRemarks;
        private DevExpress.XtraEditors.DateEdit deCarDateCreated;
        private DevExpress.XtraEditors.CheckEdit ckeCarStatus;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraEditors.DateEdit deCarYear;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.LookUpEdit leCarManufacturer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.TextEdit teCMSName;
        private DevExpress.XtraEditors.MemoEdit meCMRemarks;
        private DevExpress.XtraEditors.DateEdit deCMDateCreated;
        private DevExpress.XtraEditors.CheckEdit ckeCMStatus;
        private DevExpress.XtraLayout.LayoutControlGroup lcgCarMan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private LayoutControl lcProduct;
        private GridControl gcProducts;
        private GridView gvProducts;
        private TextEdit tePdFName;
        private TextEdit tePdUnitPrice;
        private TextEdit tePdSName;
        private MemoEdit mePdRemarks;
        private DateEdit dePdDateCreated;
        private CheckEdit ckePdStatus;
        private LayoutControlGroup layoutControlGroup5;
        private LayoutControlGroup lcgPNS;
        private LayoutControlItem layoutControlItem17;
        private LayoutControlItem layoutControlItem19;
        private LayoutControlItem layoutControlItem21;
        private LayoutControlItem layoutControlItem20;
        private LayoutControlItem layoutControlItem22;
        private LayoutControlItem layoutControlItem18;
        private SplitterItem splitterItem3;
        private LayoutControlItem layoutControlItem23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage4;
        private LayoutControl lcTitle;
        private TextEdit teTFName;
        private TextEdit teTSName;
        private MemoEdit meTRemarks;
        private DateEdit deTDateCreated;
        private CheckEdit ckeTStatus;
        private LayoutControlGroup layoutControlGroup7;
        private LayoutControlItem layoutControlItem24;
        private LayoutControlItem layoutControlItem25;
        private LayoutControlItem layoutControlItem26;
        private LayoutControlItem layoutControlItem27;
        private LayoutControlItem layoutControlItem28;
        private GridControl gcTittles;
        private GridView gvTitles;
        private LayoutControlGroup lcgTitle;
        private SplitterItem splitterItem4;
        private LayoutControlItem layoutControlItem29;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage5;
        private LayoutControl lcCustomers;
        private GridControl gcCustomers;
        private GridView gvCustomers;
        private LookUpEdit leCDTitle;
        private TextEdit teCDFName;
        private TextEdit teCDPhone;
        private TextEdit teCDSName;
        private TextEdit teCDID;
        private TextEdit teCDAddress;
        private MemoEdit meCDRemarks;
        private CheckEdit ckeCDStatus;
        private DateEdit deCDDateCreated;
        private LayoutControlGroup layoutControlGroup9;
        private LayoutControlGroup lcgCustomer;
        private LayoutControlItem layoutControlItem30;
        private LayoutControlItem layoutControlItem33;
        private LayoutControlItem layoutControlItem35;
        private LayoutControlItem layoutControlItem36;
        private LayoutControlItem layoutControlItem31;
        private LayoutControlItem layoutControlItem38;
        private LayoutControlItem layoutControlItem37;
        private LayoutControlItem layoutControlItem34;
        private LayoutControlItem layoutControlItem39;
        private SplitterItem splitterItem5;
        private LayoutControlItem layoutControlItem40;
        private LayoutControlItem layoutControlItem32;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn38;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn35;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn36;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn37;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn39;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn40;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn41;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn42;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn43;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn44;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarCheckItem bciEdit;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage6;
        private LayoutControl lcServiceType;
        private GridControl gcServiceType;
        private GridView gvServiceType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn45;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn46;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn47;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn48;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn49;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn50;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn51;
        private TextEdit teSTFName;
        private TextEdit teSTSName;
        private MemoEdit meSTRemarks;
        private DateEdit deSTDateCreated;
        private CheckEdit ckeSTStatus;
        private LayoutControlGroup layoutControlGroup12;
        private LayoutControlGroup lcgServiceType;
        private LayoutControlItem layoutControlItem42;
        private LayoutControlItem layoutControlItem43;
        private LayoutControlItem layoutControlItem44;
        private LayoutControlItem layoutControlItem45;
        private LayoutControlItem layoutControlItem46;
        private SplitterItem splitterItem6;
        private LayoutControlItem layoutControlItem47;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage7;
        private LayoutControl lcCarServicing;
        private GridControl gcCustomerPurchase;
        private GridView gvCustomerPurchase;
        private LayoutControlGroup layoutControlGroup11;
        private LayoutControlGroup lcgProdAndServ;
        private LayoutControlItem layoutControlItem48;
        private GridControl gcCarServicing;
        private GridView gvCarServicing;
        private SplitterItem splitterItem8;
        private SpinEdit sePdVatRate;
        private SpinEdit sePdTaxRate;
        private LayoutControlItem layoutControlItem53;
        private LayoutControlItem layoutControlItem52;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn54;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn53;
        private DateEdit deDCSDateCreated;
        private MemoEdit meDCSRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn55;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn56;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn57;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn58;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn59;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn61;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn60;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn62;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn63;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn65;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSEQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn64;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn66;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn67;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSETax;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn68;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSEVat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn69;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSEDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn70;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn71;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCEAddItem;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage8;
        private LayoutControl lcProductPrice;
        private GridControl gcProductPrices;
        private GridView gvProductPrices;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn52;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn75;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn76;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn77;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn72;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn78;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn73;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn81;
        private TextEdit tePPUnitPrice;
        private DateEdit dePPDateCreated;
        private CheckEdit ckePPStatus;
        private SpinEdit sePPTaxRate;
        private SpinEdit sePPVatRate;
        private LayoutControlGroup layoutControlGroup16;
        private LayoutControlItem layoutControlItem51;
        private LayoutControlGroup lcgProdPrice;
        private LayoutControlItem layoutControlItem61;
        private LayoutControlItem layoutControlItem62;
        private LayoutControlItem layoutControlItem60;
        private LayoutControlItem layoutControlItem58;
        private LayoutControlItem layoutControlItem65;
        private SplitterItem splitterItem9;
        private MemoEdit mePPRemarks;
        private LayoutControlItem layoutControlItem56;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn74;
        private LookUpEdit leDCSServiceType;
        private LookUpEdit leDCSCar;
        private LookUpEdit leDCSCustomer;
        private LookUpEdit lePPProduct;
        private LayoutControlItem layoutControlItem49;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn79;
        private DevExpress.XtraBars.BarButtonItem bbiShowPrintDialog;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bbiGenerateReport;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage9;
        private LayoutControl lcCompanyInfo;
        private GridControl gcCompanyInfo;
        private GridView gvCompanyInfo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn80;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn82;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn83;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn96;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn95;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn94;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn84;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn93;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn87;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn88;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn89;
        private TextEdit teCISlogan;
        private DateEdit deCIDateCreated;
        private CheckEdit ckeCIStatus;
        private MemoEdit meCIRemarks;
        private TextEdit teCIFName;
        private TextEdit teCISName;
        private TextEdit teCIPhone;
        private TextEdit teCIAddress;
        private PictureEdit peCILogo;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem layoutControlItem54;
        private LayoutControlGroup lcgCompanyInfo;
        private LayoutControlItem layoutControlItem55;
        private LayoutControlItem layoutControlItem59;
        private LayoutControlItem layoutControlItem69;
        private LayoutControlItem layoutControlItem72;
        private LayoutControlItem layoutControlItem73;
        private LayoutControlItem layoutControlItem74;
        private LayoutControlItem layoutControlItem68;
        private LayoutControlItem layoutControlItem75;
        private LayoutControlItem layoutControlItem67;
        private SplitterItem splitterItem10;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage10;
        private LayoutControl lcEmployee;
        private LookUpEdit leSfQualification;
        private LookUpEdit leSfJobType;
        private LookUpEdit leSfEmployeeType;
        private LookUpEdit leSfMStatus;
        private LookUpEdit leSfTitle;
        private LookUpEdit leSfGender;
        private LookUpEdit leSfRegion;
        private LookUpEdit leSfCountry;
        private LookUpEdit leSfTown;
        private GridControl gcEmployee;
        private GridView gvEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn85;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn86;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn90;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn91;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn92;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn97;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn98;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn99;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn100;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn101;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn102;
        private TextEdit teSFOName;
        private DateEdit deSfDateCreated;
        private CheckEdit ckeSfStatus;
        private MemoEdit meSfRemarks;
        private TextEdit teSfFName;
        private TextEdit teSfPhone;
        private TextEdit teSfAddress;
        private PictureEdit peSfImage;
        private TextEdit teSfLName;
        private DateEdit deSfDOB;
        private TextEdit teSfEmail;
        private TextEdit teSfStaffID;
        private DateEdit deSfStartDate;
        private DateEdit deSfEndDate;
        private LayoutControlGroup layoutControlGroup19;
        private LayoutControlItem layoutControlItem70;
        private TabbedControlGroup tcgEmployee;
        private LayoutControlGroup lcgSfPersonalInfo;
        private LayoutControlItem layoutControlItem71;
        private LayoutControlItem layoutControlItem76;
        private LayoutControlItem layoutControlItem77;
        private LayoutControlItem layoutControlItem79;
        private LayoutControlItem layoutControlItem81;
        private LayoutControlItem layoutControlItem84;
        private LayoutControlItem layoutControlItem86;
        private LayoutControlItem layoutControlItem87;
        private LayoutControlItem layoutControlItem88;
        private LayoutControlItem layoutControlItem90;
        private LayoutControlItem layoutControlItem80;
        private LayoutControlItem layoutControlItem82;
        private LayoutControlItem layoutControlItem91;
        private LayoutControlItem layoutControlItem78;
        private LayoutControlItem layoutControlItem83;
        private LayoutControlItem layoutControlItem85;
        private LayoutControlItem layoutControlItem89;
        private LayoutControlGroup lcgSfJobSpec;
        private LayoutControlItem layoutControlItem93;
        private LayoutControlItem layoutControlItem94;
        private LayoutControlItem layoutControlItem95;
        private LayoutControlItem layoutControlItem92;
        private LayoutControlItem layoutControlItem97;
        private LayoutControlItem layoutControlItem96;
        private DevExpress.XtraBars.BarCheckItem bciDetailView;
        private DevExpress.XtraBars.BarCheckItem bciSelectAll;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private LayoutControl layoutControl1;
        private TextEdit teUIUsername;
        private TextEdit teUIPassword;
        private TextEdit teUINewPassword;
        private TextEdit teUIComfirmPassword;
        private LayoutControlGroup layoutControlGroup22;
        private LayoutControlItem layoutControlItem98;
        private LayoutControlItem layoutControlItem99;
        private LayoutControlItem lciNewPassword;
        private LayoutControlItem lciComfirmPass;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bsvBtnExit;
        private PictureEdit peUIImage;
        private SimpleButton sbChangePassword;
        private SimpleButton sbLogin;
        private LayoutControlItem lciChangePassword;
        private LayoutControlItem layoutControlItem104;
        private LayoutControlItem lciImage;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
        private DevExpress.XtraNavBar.NavBarItem navBarItem10;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem11;
        private DevExpress.XtraNavBar.NavBarItem navBarItem12;
        private DevExpress.XtraNavBar.NavBarItem navBarItem13;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage11;
        private LayoutControl lcGender;
        private GridControl gcGender;
        private GridView gvGender;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn103;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn104;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn105;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn106;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn107;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn108;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn109;
        private TextEdit teGFName;
        private TextEdit teGSName;
        private MemoEdit meGRemarks;
        private DateEdit deGDateCreated;
        private CheckEdit ckeGStatus;
        private LayoutControlGroup layoutControlGroup23;
        private LayoutControlGroup lcgGender;
        private LayoutControlItem layoutControlItem100;
        private LayoutControlItem layoutControlItem101;
        private LayoutControlItem layoutControlItem102;
        private LayoutControlItem layoutControlItem103;
        private LayoutControlItem layoutControlItem105;
        private SplitterItem splitterItem11;
        private LayoutControlItem layoutControlItem106;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage12;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage13;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage14;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage15;
        private LayoutControl lcMaritalStatus;
        private GridControl gcMaritalStatus;
        private GridView gvMaritalStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn110;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn111;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn112;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn113;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn114;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn115;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn116;
        private TextEdit teMSFName;
        private TextEdit teMSSName;
        private MemoEdit meMSRemarks;
        private DateEdit deMSDateCreated;
        private CheckEdit ckeMSStatus;
        private LayoutControlGroup layoutControlGroup25;
        private LayoutControlGroup lcgMStatus;
        private LayoutControlItem layoutControlItem107;
        private LayoutControlItem layoutControlItem108;
        private LayoutControlItem layoutControlItem109;
        private LayoutControlItem layoutControlItem110;
        private LayoutControlItem layoutControlItem111;
        private SplitterItem splitterItem12;
        private LayoutControlItem layoutControlItem112;
        private LayoutControl lcCountry;
        private GridControl gcCountry;
        private GridView gvCountry;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn117;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn118;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn119;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn120;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn121;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn122;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn123;
        private TextEdit teConFName;
        private TextEdit teConSName;
        private MemoEdit meConRemarks;
        private DateEdit deConDateCreated;
        private CheckEdit ckeConStatus;
        private LayoutControlGroup layoutControlGroup27;
        private LayoutControlGroup lcgCountryDetail;
        private LayoutControlItem layoutControlItem113;
        private LayoutControlItem layoutControlItem114;
        private LayoutControlItem layoutControlItem115;
        private LayoutControlItem layoutControlItem116;
        private LayoutControlItem layoutControlItem117;
        private SplitterItem splitterItem13;
        private LayoutControlItem layoutControlItem118;
        private LayoutControl lcRegion;
        private LookUpEdit leRegCountry;
        private GridControl gcRegion;
        private GridView gvRegion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn124;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn125;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn126;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn127;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn128;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn129;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn130;
        private TextEdit teRegFName;
        private TextEdit teRegSName;
        private MemoEdit meRegRemarks;
        private DateEdit deRegDateCreated;
        private CheckEdit ckeRegStatus;
        private LayoutControlGroup layoutControlGroup29;
        private LayoutControlGroup lcgRegion;
        private LayoutControlItem layoutControlItem119;
        private LayoutControlItem layoutControlItem120;
        private LayoutControlItem layoutControlItem121;
        private LayoutControlItem layoutControlItem122;
        private LayoutControlItem layoutControlItem123;
        private LayoutControlItem layoutControlItem125;
        private SplitterItem splitterItem14;
        private LayoutControlItem layoutControlItem124;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn131;
        private LayoutControl lcTown;
        private GridControl gcTown;
        private GridView gvTown;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn132;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn133;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn134;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn135;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn136;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn137;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn138;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn139;
        private TextEdit teTwnFName;
        private TextEdit teTwnSName;
        private MemoEdit meTwnRemarks;
        private DateEdit deTwnDateCreated;
        private CheckEdit ckeTwnStatus;
        private LayoutControlGroup layoutControlGroup31;
        private LayoutControlGroup lcgTown;
        private LayoutControlItem layoutControlItem126;
        private LayoutControlItem layoutControlItem127;
        private LayoutControlItem layoutControlItem128;
        private LayoutControlItem layoutControlItem129;
        private LayoutControlItem layoutControlItem130;
        private LayoutControlItem layoutControlItem131;
        private SplitterItem splitterItem15;
        private LayoutControlItem layoutControlItem132;
        private LookUpEdit leTwnRegion;
        private LayoutControlItem layoutControlItem133;
        private LookUpEdit leTwnCountry;
        private LayoutControlItem layoutControlItem134;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn140;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem14;
        private DevExpress.XtraNavBar.NavBarItem navBarItem15;
        private DevExpress.XtraNavBar.NavBarItem navBarItem16;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage16;
        private LayoutControl lcQualification;
        private GridControl gcQualification;
        private GridView gvQualification;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn141;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn142;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn143;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn144;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn145;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn146;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn147;
        private TextEdit teQFName;
        private TextEdit teQSName;
        private MemoEdit meQRemarks;
        private DateEdit deQDateCreated;
        private CheckEdit ckeQStatus;
        private LayoutControlGroup layoutControlGroup33;
        private LayoutControlGroup lcgQualification;
        private LayoutControlItem layoutControlItem135;
        private LayoutControlItem layoutControlItem136;
        private LayoutControlItem layoutControlItem137;
        private LayoutControlItem layoutControlItem138;
        private LayoutControlItem layoutControlItem139;
        private SplitterItem splitterItem16;
        private LayoutControlItem layoutControlItem140;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage17;
        private LayoutControl lcEmployeeType;
        private GridControl gcEmployeeType;
        private GridView gvEmployeeType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn148;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn149;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn150;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn151;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn152;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn153;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn154;
        private TextEdit teETFName;
        private TextEdit teETSName;
        private MemoEdit meETRemarks;
        private DateEdit deETDateCreated;
        private CheckEdit ckeETStatus;
        private LayoutControlGroup layoutControlGroup35;
        private LayoutControlGroup lcgEmpTypeDetail;
        private LayoutControlItem layoutControlItem141;
        private LayoutControlItem layoutControlItem142;
        private LayoutControlItem layoutControlItem143;
        private LayoutControlItem layoutControlItem144;
        private LayoutControlItem layoutControlItem145;
        private SplitterItem splitterItem17;
        private LayoutControlItem layoutControlItem146;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage18;
        private LayoutControl lcJobType;
        private GridControl gcJobType;
        private GridView gvJobType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn155;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn156;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn157;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn158;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn159;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn160;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn161;
        private TextEdit teJTFName;
        private TextEdit teJTSName;
        private MemoEdit meJTRemarks;
        private DateEdit deJTDateCreated;
        private CheckEdit ckeJTStatus;
        private LayoutControlGroup layoutControlGroup37;
        private LayoutControlGroup lcgJTDetail;
        private LayoutControlItem layoutControlItem147;
        private LayoutControlItem layoutControlItem148;
        private LayoutControlItem layoutControlItem149;
        private LayoutControlItem layoutControlItem150;
        private LayoutControlItem layoutControlItem151;
        private SplitterItem splitterItem18;
        private LayoutControlItem layoutControlItem152;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn173;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn172;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn171;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn170;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn169;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn168;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn167;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn166;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn165;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn164;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn163;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn162;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn175;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn174;
        private DevExpress.XtraBars.BarHeaderItem bhiUserName;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bvbLogout;
        private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem17;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage19;
        private LayoutControl lcFormAccess;
        private GridControl gcForms;
        private GridView gvForms;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn176;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn177;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn178;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn179;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn180;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn181;
        private LayoutControlGroup layoutControlGroup20;
        private SplitterItem splitterItem19;
        private LayoutControlItem layoutControlItem158;
        private GridControl gcUsers;
        private GridView gvUsers;
        private LayoutControlItem layoutControlItem153;
        private LayoutControlGroup lcgForms;
        private LayoutControlGroup layoutControlGroup39;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn182;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn183;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn185;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn187;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn188;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn184;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn186;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riUsersAdd;
        private CheckEdit ckeFAReadAll;
        private CheckEdit ckeFAEditAll;
        private CheckEdit ckeFAWriteAll;
        private CheckEdit ckeFAAddAll;
        private LayoutControlItem layoutControlItem154;
        private LayoutControlItem layoutControlItem155;
        private LayoutControlItem layoutControlItem156;
        private LayoutControlItem layoutControlItem157;
        private TextEdit teDCSAmount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn189;
        private TextEdit teDCSChange;
        private TextEdit teDCSBalance;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn190;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn191;
        private TextEdit teDCSTotalAmount;
        private DevExpress.XtraNavBar.NavBarItem navBarItem18;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage20;
        private DevExpress.DashboardWin.DashboardViewer dashboardViewer1;
        private DevExpress.XtraBars.BarHeaderItem bhiCurrentPage;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private SplitterItem splitterItem7;
        private LayoutControlItem layoutControlItem41;
        private LayoutControlGroup lcgCarServDetail;
        private LayoutControlItem layoutControlItem63;
        private LayoutControlItem layoutControlItem64;
        private LayoutControlItem layoutControlItem66;
        private LayoutControlItem layoutControlItem57;
        private LayoutControlItem lciAmount;
        private LayoutControlItem layoutControlItem159;
        private LayoutControlItem layoutControlItem160;
        private LayoutControlItem lciTotalAmount;
        private LayoutControlItem layoutControlItem50;
        private DevExpress.XtraNavBar.NavBarItem navBarItem19;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage21;
        private LayoutControl lcCustomerCar;
        private LookUpEdit leCCCustomer;
        private GridControl gcCustomerCar;
        private GridView gvCustomerCar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn192;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn193;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn195;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn196;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn197;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn198;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn200;
        private MemoEdit meCCRemarks;
        private DateEdit deCCDateCreated;
        private CheckEdit ckeCCStatus;
        private LayoutControlGroup layoutControlGroup2;
        private LayoutControlItem layoutControlItem7;
        private LayoutControlGroup layoutControlGroup4;
        private LayoutControlItem layoutControlItem163;
        private LayoutControlItem layoutControlItem164;
        private LayoutControlItem layoutControlItem165;
        private LayoutControlItem layoutControlItem168;
        private SplitterItem splitterItem20;
        private LookUpEdit leCCCar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn199;
        private TextEdit teCCRegNum;
        private TextEdit teCCVIN;
        private LayoutControlItem layoutControlItem162;
        private LayoutControlItem layoutControlItem161;
        private LayoutControlItem layoutControlItem166;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn194;
    }
}

