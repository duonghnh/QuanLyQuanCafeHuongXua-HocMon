using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCaFe.DAO;

namespace QuanLyQuanCaFe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccounList();
        }
        void LoadAccounList()
        {
            string query = "SELECT USERNAME AS [TEN TAI KHOAN] FROM ACCOUNT ";
            DataProvider provider = new DataProvider();
            dtgvAcount.DataSource = provider.ExecuteQuery(query);
        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void tpFood_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
