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

namespace Rent_a_car_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7EM7F9I\\SQLEXPRESS;Initial Catalog=RentaCar;Integrated Security=True");
        private void Temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            mtbtc.Text = "";
            txtkm.Text = "";
            txtalınankm.Text = "";
            txtplaka.Text = "";
            txtcalısanad.Text = "";
            txtcalisansoyad.Text = "";
            txtucret.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'rentaCarDataSet.Tbl_Kiralama' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_KiralamaTableAdapter.Fill(this.rentaCarDataSet.Tbl_Kiralama);

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_KiralamaTableAdapter.Fill(this.rentaCarDataSet.Tbl_Kiralama);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_kiralama(AD,SOYAD,TC,Verkm,Plaka,Alkm,CalAd,Calsoyad,Ucret,ID)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3",mtbtc.Text);
            komut.Parameters.AddWithValue("@p4",txtkm.Text);
            komut.Parameters.AddWithValue("@p5",txtplaka.Text);
            komut.Parameters.AddWithValue("@p6",txtalınankm.Text);
            komut.Parameters.AddWithValue("@p7",txtcalısanad.Text);
            komut.Parameters.AddWithValue("@p8",txtcalisansoyad.Text);
            komut.Parameters.AddWithValue("@p9",txtucret.Text);
            komut.Parameters.AddWithValue("@p10", txtid.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla eklendi");

            baglanti.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_kiralama where ID=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla silindi");
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text=dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mtbtc.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtkm.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtplaka.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtalınankm.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtcalısanad.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtcalisansoyad.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtucret.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_kiralama Set AD=@a1,Soyad=@a2,TC=@a3,VERKM=@a4,plaka=@a5,alkm=@a6,calad=@a7,calsoyad=@a8,ucret=@a9", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", mtbtc.Text);
            komutguncelle.Parameters.AddWithValue("@a4",txtkm.Text);
            komutguncelle.Parameters.AddWithValue("@a5",txtplaka.Text);
            komutguncelle.Parameters.AddWithValue("@a6",txtalınankm.Text);
            komutguncelle.Parameters.AddWithValue("@a7",txtcalısanad.Text);
            komutguncelle.Parameters.AddWithValue("@a8",txtcalisansoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a9",txtucret.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla güncellendi");
        }
    }
}
