using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace QuanLyNhanSu.CT
{
    public partial class tkNhanVien : UserControl
    {
        public tkNhanVien()
        {
            InitializeComponent();
        }
        CauLenh cl = new CauLenh();
        tkCauLenh tkcl = new tkCauLenh();
        DataTable dt = new DataTable();
        private void lbH_Click(object sender, EventArgs e)
        {
            
        }

        private void txtH_Click(object sender, EventArgs e)
        {
            txtH.Text = "";
        }
        private void load()
        {
            
        }
        private void tkNhanVien_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
