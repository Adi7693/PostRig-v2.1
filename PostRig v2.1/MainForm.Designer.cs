namespace PostRig_v2._1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.NewBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.OpenNew = new DevExpress.XtraBars.BarButtonItem();
            this.SaveBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.SaveAsBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.HelpbarButton = new DevExpress.XtraBars.BarButtonItem();
            this.CaseStudyBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.AboutBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.CloseBarButton = new DevExpress.XtraBars.BarButtonItem();
            this.BodyBarList = new DevExpress.XtraBars.BarListItem();
            this.HomeRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.HomePage = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.HomePageOpenSaveGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.HomePageReadMeGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.HomePageAboutGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.HomePageCloseGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DesignRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.DesignPageBodyGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.WorkingAreaPanel = new DevExpress.XtraEditors.PanelControl();
            this.noDocumentsView1 = new DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.PropertyTreeListDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.DesignTreeListView = new DevExpress.XtraTreeList.TreeList();
            this.DesignTreeListColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.DesignPageSuspGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.SpringBarList = new DevExpress.XtraBars.BarListItem();
            this.DamperBarList = new DevExpress.XtraBars.BarListItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingAreaPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.PropertyTreeListDockPanel.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DesignTreeListView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.NewBarButton,
            this.OpenNew,
            this.SaveBarButton,
            this.SaveAsBarButton,
            this.HelpbarButton,
            this.CaseStudyBarButton,
            this.AboutBarButton,
            this.CloseBarButton,
            this.BodyBarList,
            this.SpringBarList,
            this.DamperBarList});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HomeRibbonPage,
            this.DesignRibbonPage});
            this.ribbonControl1.Size = new System.Drawing.Size(856, 162);
            // 
            // NewBarButton
            // 
            this.NewBarButton.Caption = "New";
            this.NewBarButton.Id = 1;
            this.NewBarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("NewBarButton.ImageOptions.Image")));
            this.NewBarButton.Name = "NewBarButton";
            this.NewBarButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.NewBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NewBarButton_ItemClick);
            // 
            // OpenNew
            // 
            this.OpenNew.Caption = "Open";
            this.OpenNew.Id = 2;
            this.OpenNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("OpenNew.ImageOptions.Image")));
            this.OpenNew.Name = "OpenNew";
            this.OpenNew.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // SaveBarButton
            // 
            this.SaveBarButton.Caption = "Save";
            this.SaveBarButton.Id = 3;
            this.SaveBarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SaveBarButton.ImageOptions.Image")));
            this.SaveBarButton.Name = "SaveBarButton";
            this.SaveBarButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // SaveAsBarButton
            // 
            this.SaveAsBarButton.Caption = "Save As";
            this.SaveAsBarButton.Id = 4;
            this.SaveAsBarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsBarButton.ImageOptions.Image")));
            this.SaveAsBarButton.Name = "SaveAsBarButton";
            this.SaveAsBarButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // HelpbarButton
            // 
            this.HelpbarButton.Caption = "Help";
            this.HelpbarButton.Id = 5;
            this.HelpbarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HelpbarButton.ImageOptions.Image")));
            this.HelpbarButton.Name = "HelpbarButton";
            this.HelpbarButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // CaseStudyBarButton
            // 
            this.CaseStudyBarButton.Caption = "Case Study";
            this.CaseStudyBarButton.Id = 6;
            this.CaseStudyBarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CaseStudyBarButton.ImageOptions.Image")));
            this.CaseStudyBarButton.Name = "CaseStudyBarButton";
            this.CaseStudyBarButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // AboutBarButton
            // 
            this.AboutBarButton.Caption = "About";
            this.AboutBarButton.Id = 7;
            this.AboutBarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AboutBarButton.ImageOptions.Image")));
            this.AboutBarButton.Name = "AboutBarButton";
            this.AboutBarButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.AboutBarButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AboutBarButton_ItemClick);
            // 
            // CloseBarButton
            // 
            this.CloseBarButton.Caption = "Close";
            this.CloseBarButton.Id = 8;
            this.CloseBarButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CloseBarButton.ImageOptions.Image")));
            this.CloseBarButton.Name = "CloseBarButton";
            this.CloseBarButton.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // BodyBarList
            // 
            this.BodyBarList.Caption = "Body";
            this.BodyBarList.Id = 9;
            this.BodyBarList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barListItem1.ImageOptions.Image")));
            this.BodyBarList.Name = "BodyBarList";
            this.BodyBarList.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BodyBarList.Strings.AddRange(new object[] {
            "New",
            "Export",
            "Import"});
            this.BodyBarList.ListItemClick += new DevExpress.XtraBars.ListItemClickEventHandler(this.BodyBarList_ListItemClick);
            // 
            // HomeRibbonPage
            // 
            this.HomeRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.HomePage,
            this.HomePageOpenSaveGroup,
            this.HomePageReadMeGroup,
            this.HomePageAboutGroup,
            this.HomePageCloseGroup});
            this.HomeRibbonPage.Name = "HomeRibbonPage";
            this.HomeRibbonPage.Text = "Home";
            // 
            // HomePage
            // 
            this.HomePage.ItemLinks.Add(this.NewBarButton);
            this.HomePage.Name = "HomePage";
            this.HomePage.Text = "New";
            // 
            // HomePageOpenSaveGroup
            // 
            this.HomePageOpenSaveGroup.ItemLinks.Add(this.OpenNew);
            this.HomePageOpenSaveGroup.ItemLinks.Add(this.SaveBarButton);
            this.HomePageOpenSaveGroup.ItemLinks.Add(this.SaveAsBarButton);
            this.HomePageOpenSaveGroup.Name = "HomePageOpenSaveGroup";
            this.HomePageOpenSaveGroup.Text = "Open/Save";
            // 
            // HomePageReadMeGroup
            // 
            this.HomePageReadMeGroup.ItemLinks.Add(this.HelpbarButton);
            this.HomePageReadMeGroup.ItemLinks.Add(this.CaseStudyBarButton);
            this.HomePageReadMeGroup.Name = "HomePageReadMeGroup";
            this.HomePageReadMeGroup.Text = "Read Me";
            // 
            // HomePageAboutGroup
            // 
            this.HomePageAboutGroup.ItemLinks.Add(this.AboutBarButton);
            this.HomePageAboutGroup.Name = "HomePageAboutGroup";
            this.HomePageAboutGroup.Text = "About";
            // 
            // HomePageCloseGroup
            // 
            this.HomePageCloseGroup.ItemLinks.Add(this.CloseBarButton);
            this.HomePageCloseGroup.Name = "HomePageCloseGroup";
            this.HomePageCloseGroup.Text = "Close";
            // 
            // DesignRibbonPage
            // 
            this.DesignRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.DesignPageBodyGroup,
            this.DesignPageSuspGroup});
            this.DesignRibbonPage.Name = "DesignRibbonPage";
            this.DesignRibbonPage.Text = "Design";
            // 
            // DesignPageBodyGroup
            // 
            this.DesignPageBodyGroup.ItemLinks.Add(this.BodyBarList);
            this.DesignPageBodyGroup.Name = "DesignPageBodyGroup";
            this.DesignPageBodyGroup.Text = "Body";
            // 
            // documentManager1
            // 
            this.documentManager1.ClientControl = this.WorkingAreaPanel;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.noDocumentsView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.noDocumentsView1,
            this.tabbedView1});
            // 
            // WorkingAreaPanel
            // 
            this.WorkingAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkingAreaPanel.Location = new System.Drawing.Point(200, 162);
            this.WorkingAreaPanel.Name = "WorkingAreaPanel";
            this.WorkingAreaPanel.Size = new System.Drawing.Size(656, 487);
            this.WorkingAreaPanel.TabIndex = 2;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.PropertyTreeListDockPanel});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"});
            // 
            // PropertyTreeListDockPanel
            // 
            this.PropertyTreeListDockPanel.Controls.Add(this.dockPanel2_Container);
            this.PropertyTreeListDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.PropertyTreeListDockPanel.ID = new System.Guid("9391bffd-84ed-4d78-83ee-6d9961d84e87");
            this.PropertyTreeListDockPanel.Location = new System.Drawing.Point(0, 162);
            this.PropertyTreeListDockPanel.Name = "PropertyTreeListDockPanel";
            this.PropertyTreeListDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.PropertyTreeListDockPanel.SavedSizeFactor = 0D;
            this.PropertyTreeListDockPanel.Size = new System.Drawing.Size(200, 487);
            this.PropertyTreeListDockPanel.Text = "Property Tree";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.DesignTreeListView);
            this.dockPanel2_Container.Location = new System.Drawing.Point(3, 30);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(193, 454);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // DesignTreeListView
            // 
            this.DesignTreeListView.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.DesignTreeListColumn});
            this.DesignTreeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesignTreeListView.Location = new System.Drawing.Point(0, 0);
            this.DesignTreeListView.Name = "DesignTreeListView";
            this.DesignTreeListView.BeginUnboundLoad();
            this.DesignTreeListView.AppendNode(new object[] {
            "Post Rig Project"}, -1);
            this.DesignTreeListView.AppendNode(new object[] {
            "Component Library"}, 0);
            this.DesignTreeListView.AppendNode(new object[] {
            "Body"}, 1);
            this.DesignTreeListView.AppendNode(new object[] {
            "Spring"}, 1);
            this.DesignTreeListView.AppendNode(new object[] {
            "Damper"}, 1);
            this.DesignTreeListView.EndUnboundLoad();
            this.DesignTreeListView.OptionsView.ShowButtons = false;
            this.DesignTreeListView.OptionsView.ShowFirstLines = false;
            this.DesignTreeListView.OptionsView.ShowHorzLines = false;
            this.DesignTreeListView.OptionsView.ShowIndicator = false;
            this.DesignTreeListView.OptionsView.ShowRoot = false;
            this.DesignTreeListView.OptionsView.ShowVertLines = false;
            this.DesignTreeListView.Size = new System.Drawing.Size(193, 454);
            this.DesignTreeListView.TabIndex = 0;
            // 
            // DesignTreeListColumn
            // 
            this.DesignTreeListColumn.Caption = "DesignTreeColumn";
            this.DesignTreeListColumn.FieldName = "DesignTreeColumn";
            this.DesignTreeListColumn.Name = "DesignTreeListColumn";
            this.DesignTreeListColumn.OptionsColumn.AllowEdit = false;
            this.DesignTreeListColumn.OptionsColumn.AllowFocus = false;
            this.DesignTreeListColumn.OptionsColumn.AllowMove = false;
            this.DesignTreeListColumn.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.DesignTreeListColumn.OptionsColumn.AllowSize = false;
            this.DesignTreeListColumn.OptionsColumn.AllowSort = false;
            this.DesignTreeListColumn.OptionsColumn.ReadOnly = true;
            this.DesignTreeListColumn.OptionsColumn.ShowInCustomizationForm = false;
            this.DesignTreeListColumn.OptionsColumn.ShowInExpressionEditor = false;
            this.DesignTreeListColumn.OptionsFilter.AllowAutoFilter = false;
            this.DesignTreeListColumn.OptionsFilter.AllowFilter = false;
            this.DesignTreeListColumn.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.DesignTreeListColumn.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.DesignTreeListColumn.OptionsFilter.ImmediateUpdatePopupDateFilter = DevExpress.Utils.DefaultBoolean.False;
            this.DesignTreeListColumn.OptionsFilter.ImmediateUpdatePopupExcelFilter = DevExpress.Utils.DefaultBoolean.False;
            this.DesignTreeListColumn.OptionsFilter.ShowBlanksFilterItems = DevExpress.Utils.DefaultBoolean.False;
            this.DesignTreeListColumn.OptionsFilter.ShowEmptyDateFilter = false;
            this.DesignTreeListColumn.Visible = true;
            this.DesignTreeListColumn.VisibleIndex = 0;
            // 
            // DesignPageSuspGroup
            // 
            this.DesignPageSuspGroup.ItemLinks.Add(this.SpringBarList);
            this.DesignPageSuspGroup.ItemLinks.Add(this.DamperBarList);
            this.DesignPageSuspGroup.Name = "DesignPageSuspGroup";
            this.DesignPageSuspGroup.Text = "Suspension";
            // 
            // SpringBarList
            // 
            this.SpringBarList.Caption = "Spring";
            this.SpringBarList.Id = 10;
            this.SpringBarList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SpringBarList.ImageOptions.Image")));
            this.SpringBarList.Name = "SpringBarList";
            this.SpringBarList.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.SpringBarList.Strings.AddRange(new object[] {
            "New",
            "Export",
            "Import"});
            this.SpringBarList.ListItemClick += new DevExpress.XtraBars.ListItemClickEventHandler(this.SpringBarList_ListItemClick);
            // 
            // DamperBarList
            // 
            this.DamperBarList.Caption = "Damper";
            this.DamperBarList.Id = 11;
            this.DamperBarList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DamperBarList.ImageOptions.Image")));
            this.DamperBarList.Name = "DamperBarList";
            this.DamperBarList.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.DamperBarList.Strings.AddRange(new object[] {
            "New",
            "Export",
            "Import"});
            this.DamperBarList.ListItemClick += new DevExpress.XtraBars.ListItemClickEventHandler(this.DamperBarList_ListItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 649);
            this.Controls.Add(this.WorkingAreaPanel);
            this.Controls.Add(this.PropertyTreeListDockPanel);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "PostRig v2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingAreaPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.PropertyTreeListDockPanel.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DesignTreeListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage HomeRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup HomePage;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraEditors.PanelControl WorkingAreaPanel;
        private DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView noDocumentsView1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel PropertyTreeListDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.BarButtonItem NewBarButton;
        private DevExpress.XtraBars.BarButtonItem OpenNew;
        private DevExpress.XtraBars.BarButtonItem SaveBarButton;
        private DevExpress.XtraBars.BarButtonItem SaveAsBarButton;
        private DevExpress.XtraBars.BarButtonItem HelpbarButton;
        private DevExpress.XtraBars.BarButtonItem CaseStudyBarButton;
        private DevExpress.XtraBars.BarButtonItem AboutBarButton;
        private DevExpress.XtraBars.BarButtonItem CloseBarButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup HomePageOpenSaveGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup HomePageReadMeGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup HomePageAboutGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup HomePageCloseGroup;
        private DevExpress.XtraBars.BarListItem BodyBarList;
        private DevExpress.XtraBars.Ribbon.RibbonPage DesignRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup DesignPageBodyGroup;
        private DevExpress.XtraTreeList.TreeList DesignTreeListView;
        private DevExpress.XtraTreeList.Columns.TreeListColumn DesignTreeListColumn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup DesignPageSuspGroup;
        private DevExpress.XtraBars.BarListItem SpringBarList;
        private DevExpress.XtraBars.BarListItem DamperBarList;
    }
}

