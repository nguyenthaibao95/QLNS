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
    public partial class tkXemccTheoTen : UserControl
    {
        public tkXemccTheoTen()
        {
            InitializeComponent();
        }
        tkCauLenh tkcl = new tkCauLenh();
        DataTable dt = new DataTable();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            
        }
        private void load()
        {
            
        }
        private void tkXemccTheoTen_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
