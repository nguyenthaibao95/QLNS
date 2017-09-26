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

namespace QuanLyNhanSu.CT
{
    public partial class PhuCap : UserControl
    {
        public PhuCap()
        {
            InitializeComponent();
        }
        
        private void PhanQuyen(string quyen)
        {
           
        }
        private void PhuCap_Load(object sender, EventArgs e)
        {
            
        }
        private void load()
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdTat_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdTen_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            dr = cl.SuaPhuCap(ma, loai, txtTen.Text, Convert.ToInt32(txtTien.Text), dtpTu.Value, dtpDen.Value);
            load();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
           
        }
    }
}
