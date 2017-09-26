using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuanLyNhanSu.ThongKe
{
    public partial class tkNVNghiCoPhep : UserControl
    {
        public tkNVNghiCoPhep()
        {
            InitializeComponent();
        }
        tkCauLenh tkcl = new tkCauLenh();
        DataTable dt = new DataTable();
        int thang = DateTime.Now.Month, nam = DateTime.Now.Year, ngay = DateTime.Now.Day;
        DateTime n;
        private void btXem_Click(object sender, EventArgs e)
        {
            
        }
        private void load()
        {
            
        }
        private void tkNVNghiCoPhep_Load(object sender, EventArgs e)
        {
            
        }

        private void rdNTN_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rdT_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
