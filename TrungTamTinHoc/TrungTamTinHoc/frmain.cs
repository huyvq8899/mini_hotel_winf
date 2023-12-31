using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using TrungTamTinHoc.DanhMuc.Phong;
using TrungTamTinHoc.DanhMuc.HoaDon;
using TrungTamTinHoc.DanhMuc.BaoCao;
using TrungTamTinHoc.DanhMuc.DatPhong;

namespace TrungTamTinHoc
{
    public partial class frmain : Form
    {
        public frmain()
        {
            InitializeComponent();
            FormDatPhong frm = new FormDatPhong();
            frm.MdiParent = this;
            frm.Show();
        }
        Classqlttth obj = new Classqlttth();
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmain_Load(object sender, EventArgs e)
        {

            
            
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            new frlogin().Show();
            this.Hide();

            đăngXuấtToolStripMenuItem.Enabled = true;
            thayĐổiMậtKhẩuToolStripMenuItem.Enabled = true;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            đăngNhậpToolStripMenuItem.Enabled = true;
            cậpNhậtToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = false;
            thayĐổiMậtKhẩuToolStripMenuItem.Enabled = false;
            
           
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frdoimatkhau frm = new frdoimatkhau();            
            frm.MdiParent = this;
            frm.Show();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void danhMucVatTuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVatTu frm = new FormVatTu();           
            frm.MdiParent = this;
            frm.Show();
        }


        private void thờiKhoáBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frlichkhaigiang frm = new frlichkhaigiang();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm");
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhong frm = new FormPhong();
            FormDatPhong frm2 = new FormDatPhong(); 
            frm2.Hide();
            frm.MdiParent = this;
            frm.Show();
        }

        private void HoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDon frm = new FormHoaDon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BaoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKeDatPhong frm = new FormThongKeDatPhong();
            frm.MdiParent = this;
            frm.Show();
        }


    } 
}