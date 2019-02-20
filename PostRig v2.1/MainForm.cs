using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace PostRig_v2._1
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private bool BodyNeedsToAdd = false;
        private bool SpringNeedsToAdd = false;
        private bool DamperNeedsToAdd = false;

        private Project CurrentProject { get; set; } = new Project();

        public MainForm()
        {
            InitializeComponent();
            ShowHomePage();
            DesignTreeListView.ExpandAll();
        }

        public void ShowHomePage()
        {
            if(!WorkingAreaPanel.Controls.Contains(uHomePage.Instance))
            {
                WorkingAreaPanel.Controls.Add(uHomePage.Instance);

                uHomePage.Instance.Dock = DockStyle.Fill;
            }

            PropertyTreeListDockPanel.Close();
        }

        private void NewBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PropertyTreeListDockPanel.Show();

            uHomePage.Instance.Hide();
        }

        private void AboutBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uHomePage.Instance.Show();
        }

        private void AddToTreeList(IVehicleComponent vehicleComponent)
        {
            DesignTreeListView.BeginUnboundLoad();

            TreeListNode ParentNodeForRoot = null;

            if (BodyNeedsToAdd)
            {
                ParentNodeForRoot = DesignTreeListView.Nodes[0].Nodes[0].Nodes[0];
            }
            else if (SpringNeedsToAdd)
            {
                ParentNodeForRoot = DesignTreeListView.Nodes[0].Nodes[0].Nodes[1];
            }
            else if (DamperNeedsToAdd)
            {
                ParentNodeForRoot = DesignTreeListView.Nodes[0].Nodes[0].Nodes[2];
            }

            TreeListNode NewBody = DesignTreeListView.AppendNode(new object[] { null }, ParentNodeForRoot, vehicleComponent);

            ParentNodeForRoot.LastNode.SetValue(DesignTreeListColumn, vehicleComponent.Name);

            DesignTreeListView.EndUnboundLoad();

            DesignTreeListView.ExpandAll();

            BodyNeedsToAdd = false;
            SpringNeedsToAdd = false;
            DamperNeedsToAdd = false;
        }   


        private void NewBody()
        {
            IVehicleComponent Body = new VehicleBody(CurrentProject.GetValidName(VehicleComponentTypes.Body));

            BodyNeedsToAdd = true;
            CurrentProject.BodyNeedsToAdd = true;

            AddToTreeList(Body);
            CurrentProject.AddBody(Body);
        }

        private void ExportBody()
        {

        }

        private void ImportBody()
        {

        }

        private void BodyBarList_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    NewBody();
                    break;

                case 1:
                    ExportBody();
                    break;

                case 2:
                    ImportBody();
                    break;

            }
        }

        private void NewSpring()
        {
            IVehicleComponent Spring = new Spring(CurrentProject.GetValidName(VehicleComponentTypes.Spring));

            SpringNeedsToAdd = true;
            CurrentProject.SpringNeedsToAdd = true;

            AddToTreeList(Spring);
            CurrentProject.AddSpring(Spring);
        }

        private void ExportSpring()
        {

        }

        private void ImportSpring()
        {

        }



        private void SpringBarList_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    NewSpring();
                    break;

                case 1:
                    ExportSpring();
                    break;

                case 2:
                    ImportSpring();
                    break;
            }
        }

        private void NewDamper()
        {
            IVehicleComponent Damper = new Damper(CurrentProject.GetValidName(VehicleComponentTypes.Damper));

            DamperNeedsToAdd = true;
            CurrentProject.DamperNeedsToAdd = true;

            AddToTreeList(Damper);
            CurrentProject.AddDamper(Damper);
        }

        private void ExportDamper()
        {

        }

        private void ImportDamper()
        {

        }

        private void DamperBarList_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    NewDamper();
                    break;

                case 1:
                    ExportDamper();
                    break;

                case 2:
                    ImportDamper();
                    break;
            }
        }
    }
}
