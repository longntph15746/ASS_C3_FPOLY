using ASS_NAM_FPOLY.frmQLĐSV;
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

namespace ASS_NAM_FPOLY.frmLogin
{
    public partial class Frm_Action : Form
    {
        public Frm_Action()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_QLĐSV frmQLĐSV = new Frm_QLĐSV();
            frmQLĐSV.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_QLSV frmQLSV = new Frm_QLSV();
            frmQLSV.Show();
            this.Hide();
        }
    }
}
