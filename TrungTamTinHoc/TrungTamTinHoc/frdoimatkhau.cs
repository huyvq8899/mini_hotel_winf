using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrungTamTinHoc
{
    public partial class frdoimatkhau : Form
    {
        public frdoimatkhau()
        {
            InitializeComponent();
        }
        Classqlttth obj = new Classqlttth();
        public bool ktuser_pass()
        {
            string _ten, _matk;
            _ten = txtmanv.Text;
            _matk = txtmk.Text;
            if (txtmk.Text == "" || txtmanv.Text == "")
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
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (ktuser_pass() == true)
            {
                //if (txtpasmoi.Text == txtpas1.Text)
                if(txtmkmoi.Text==txtmkmoi1.Text)
                {
                    string vma, vpas;
                    vma =txtmanv.Text;
                    vpas = txtmkmoi.Text;
                    
                    obj.DOIMATKHAU(vma,vpas);
                    MessageBox.Show("Mật khẩu đã được thay đổi");
                }
               
               
            }
            else
                MessageBox.Show("Thông tin chưa đúng, xin vui lòng xem lại");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frdoimatkhau_Load(object sender, EventArgs e)
        {

        }
        
    }
}