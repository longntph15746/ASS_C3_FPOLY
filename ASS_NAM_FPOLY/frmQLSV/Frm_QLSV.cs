using ASS_NAM_FPOLY.DTO;
using ASS_NAM_FPOLY.frmQLĐSV;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASS_NAM_FPOLY.frmQLSV
{
    public partial class Frm_QLSV : Form
    {
        public Frm_QLSV()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_QLĐSV frmQLĐSV = new Frm_QLĐSV();
            frmQLĐSV.Show();
            this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
        }
    }
}
