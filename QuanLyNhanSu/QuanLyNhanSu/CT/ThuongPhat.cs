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
    public partial class ThuongPhat : UserControl
    {
        public ThuongPhat()
        {
            InitializeComponent();
        }
        
        private void load()
        {
            
        }
        private void ThuongPhat_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private string layMaNhanVien(string tennv)
        {
            dr = cl.layMaNVTuTenNV(tennv);
            while (dr.Read())
                manv = dr.GetString(0);
            return manv;
        }
        private string layTenPhongBan(string ma)
        {
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
           
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            
        }

       

        
  
    }
}
