using ASS_NAM_FPOLY.frmQLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASS_NAM_FPOLY.frmQLĐSV
{
    public partial class Frm_QLĐSV : Form
    {
        public Frm_QLĐSV()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_QLSV frmQLSV = new Frm_QLSV();
            frmQLSV.Show();
            this.Hide();
        }
    }
}
