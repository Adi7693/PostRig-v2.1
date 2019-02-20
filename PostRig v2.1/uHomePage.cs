using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostRig_v2._1
{
    public partial class uHomePage : DevExpress.XtraEditors.XtraUserControl
    {
        public uHomePage()
        {
            InitializeComponent();
            VersionLabel.Text = ProductVersion.ToString();
        }

        private static uHomePage _instance;

        public static uHomePage Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new uHomePage();
                }

                return _instance;

            }
        }
    }
}