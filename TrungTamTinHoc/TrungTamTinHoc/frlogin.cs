using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TrungTamTinHoc
{
    public partial class frlogin : Form
    {
        public frlogin()
        {
            InitializeComponent();
        }

      
        Classqlttth obj = new Classqlttth();
        //====//
        public bool ktuser_pass()
        {
            string _ten, _matk;
            _ten = txtten.Text;
            _matk = txtmk.Text;
            if (txtmk.Text == "" || txtten.Text == "")
            {
                MessageBox.Show("Thông tin nhập không đầy đủ");
                return false;
            }
            if (obj.kiemtrauser(_ten, _matk))
            {
                //MessageBox.Show(" Mã sách này đã tồn tại !");
                return true;
            }
            return false;
        }
        private void frlogin_Load(object sender, EventArgs e)
        {
            //Khai bao de nap frmSplash
            //frmSreen frm = new frmSreen();
           
            //Dung 3000 mili giay
            System.Threading.Thread.Sleep(3000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (ktuser_pass() == true)
                {
                    //frmMain frm = new frmMain();
                    frmain frm = new frmain();
                    frm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Tên truy cập này không tồn tại");
        }

        private void rdnguoiql_CheckedChanged(object sender, EventArgs e)
        {
            txtmk.Enabled = true;
          txtten.Enabled = true;
           txtten.Focus();
        }

        private void rdhocvien_CheckedChanged(object sender, EventArgs e)
        {

            txtten.Enabled =true;
           txtmk.Enabled = true;
           txtten.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}