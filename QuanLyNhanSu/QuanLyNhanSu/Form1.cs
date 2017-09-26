using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        SqlDataReader dr;
        CauLenh cl = new CauLenh();
        public static string chuoi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = null;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private string layQHNhanVien(string tk, string mk)
        {
            
        }
        private string layTenNhanVien(string manv)
        {
           
        }
        private string layMaNhanVien(string tk)
        {
            
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
        }


    }
}
