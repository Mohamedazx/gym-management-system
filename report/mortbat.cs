using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace elly_gym.report
{
    public partial class mortbat : DevExpress.XtraReports.UI.XtraReport
    {
        public mortbat()
        {
            InitializeComponent();
        }

        private void table1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
