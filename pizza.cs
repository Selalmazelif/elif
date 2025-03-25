using System;
using System.Text;
using System.Windows.Forms;

namespace pizza
{
    public partial class PİZZA : Form
    {
        public PİZZA()
        {
            InitializeComponent();
        }

        private void textBoxToplam_TextChanged(object sender, EventArgs e)
        {

        }

 private void comboBoxEbat_SelectedIndexChanged_1(object sender, EventArgs e) { }






        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PİZZA_Load(object sender, EventArgs e)
        {
           
            comboBoxEbat.Items.Add("Küçük");
            comboBoxEbat.Items.Add("Orta");
            comboBoxEbat.Items.Add("Büyük");
            comboBoxEbat.SelectedIndex = 0;

           
            listBoxPizza.Items.Add("American Hot");
            listBoxPizza.Items.Add("Calypso");
            listBoxPizza.Items.Add("Turkish");
            listBoxPizza.Items.Add("Pizza Italiano");
            listBoxPizza.Items.Add("Etravaganizza");
            listBoxPizza.SelectedIndex = 0;

            HesaplaToplam();
        }

        private void HesaplaToplam()
        {
            int fiyat = 120; 
            if (comboBoxEbat.SelectedItem.ToString() == "Orta") fiyat += 30;
            if (comboBoxEbat.SelectedItem.ToString() == "Büyük") fiyat += 90;

            if (listBoxPizza.SelectedItem.ToString() == "American Hot") fiyat += 50;
            if (listBoxPizza.SelectedItem.ToString() == "Calypso") fiyat += 50;
            if (listBoxPizza.SelectedItem.ToString() == "Turkish") fiyat += 50;
            if (listBoxPizza.SelectedItem.ToString() == "Pizza Italiano") fiyat += 50;
            if (listBoxPizza.SelectedItem.ToString() == "Etravaganizza") fiyat += 50;

            
            
            if (radioKalinKenar.Checked) fiyat +=15;
            if (radioInceKenar.Checked) fiyat += 15;

          
            foreach (Control ctrl in groupBoxMalzemeler.Controls)
            {
                if (ctrl is CheckBox checkBox && checkBox.Checked)
                {
                    fiyat += 5;
                }
            }

            int adet = 1;
            if(!int.TryParse(textBoxadet.Text,out adet) || adet < 1)
            {
                adet = 1;
                textBoxadet.Text = " ";
            }
            int toplamtutar = fiyat * adet;
            textBoxToplam.Text = toplamtutar.ToString() + " TL";
        }



        private void siparisver(object sender, EventArgs e)
        {
            int adet = 1;
            if (!int.TryParse(textBoxadet.Text, out adet) || adet < 1)
            {
                adet = 1;
                textBoxadet.Text = " ";
            }

            StringBuilder siparisDetay = new StringBuilder();
            siparisDetay.AppendLine("📌 **Sipariş Detayları**");
            siparisDetay.AppendLine($"🍕 Pizza: {comboBoxEbat.SelectedItem}");
            siparisDetay.AppendLine($"📏 Ebat: {listBoxPizza.SelectedItem}");
            siparisDetay.AppendLine($"🟢 Kenar: {(radioKalinKenar.Checked ? "Kalın Kenar" : "İnce Kenar")}");
            siparisDetay.AppendLine($"📦 Adet: {adet}");
            siparisDetay.Append("🛑 Malzemeler: ");
            
            bool malzemeVar = false;
            foreach (Control ctrl in groupBoxMalzemeler.Controls)
            {
                if (ctrl is CheckBox checkBox && checkBox.Checked)
                {
                    siparisDetay.Append(checkBox.Text + ", ");
                    malzemeVar = true;
                }
            }
            if (!malzemeVar) siparisDetay.Append("Yok");

            siparisDetay.AppendLine($"\n💰 Toplam Tutar: {textBoxToplam.Text}");
            siparisDetay.AppendLine("\n✅ Siparişinizi onaylıyor musunuz?");

            DialogResult result = MessageBox.Show(siparisDetay.ToString(), "Sipariş Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Siparişiniz onaylandı! 🚀 Yaklaşık 30 dakika içinde elinizde olacak.", "Sipariş Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sipariş iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


      
         
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) => HesaplaToplam();
        private void checkBoxMalzeme(object sender, EventArgs e) => HesaplaToplam(); // checkedChanged
        private void radioKenar(object sender, EventArgs e) => HesaplaToplam();   // checkedChanged
        private void textBoxAdet(object sender, EventArgs e) => HesaplaToplam();  // textChanged

    }
}
