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
    public partial class tkSoNgayNghiKhongPhep : UserControl
    {
        public tkSoNgayNghiKhongPhep()
        {
            InitializeComponent();
        }
        tkCauLenh tkcl = new tkCauLenh();
        DataTable dt = new DataTable();
        int thang = DateTime.Now.Month, nam = DateTime.Now.Year, ngay = DateTime.Now.Day;
        private void tkSoNgayNghiKhongPhep_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            btXem.Enabled = false;
        }
        private void btXem_Click(object sender, EventArgs e)
        {
            
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
