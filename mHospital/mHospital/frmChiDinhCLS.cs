using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace mHospital
{
    public partial class frmChiDinhCLS : DevComponents.DotNetBar.Office2007Form
    {
        string maBN;
        public frmChiDinhCLS(string maBN)
        {
            InitializeComponent();
            this.maBN = maBN;
        }

        private void frmChiDinhCLS_Load(object sender, EventArgs e)
        {

        }
    }
}