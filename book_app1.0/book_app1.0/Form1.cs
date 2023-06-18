using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_app1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void kitaplarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kitaplarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kitaplar_databaseDataSet);
            MessageBox.Show("Kitap bilgileri kaydedildi ve güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

       

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kitaplar_databaseDataSet.kitaplar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitaplarTableAdapter.Fill(this.kitaplar_databaseDataSet.kitaplar);

            //combobox durumlar
            string[] durumlar = new string[] { "Okundu", "Okunmadı", "Yarım kaldı" };
            durumComboBox.DataSource = durumlar;
            durumComboBox.SelectedIndex = 0;

            //combobox kategoriler
            string[] kategoriler = { "Bilim", "Biyografi", "Eğitim", "Ticaret-Ekonomi", "Kişisel Gelişim", "Masal", "Tarih", "Şiir", "Roman", "Hikaye", "Gezi", "Felsefe" };
            kategoriComboBox.DataSource = kategoriler;
            kategoriComboBox.SelectedIndex = 4;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeni bir satır eklendi! Lütfen kitap bilgilerini giriniz ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Programı kapatmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            //else ile yazabilirdim 
            if (secim == DialogResult.No)
            {
                e.Cancel = true;

            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kitap silindi! ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
