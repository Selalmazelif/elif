using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var eklenecekDeger = txtgiris.Text;
            listBox1.Items.Add(eklenecekDeger);
            txtgiris.Clear();
            txtgiris.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtgiris.Focus();
            listBox1.Items.Add("Samsun");
            listBox1.Items.Add("Ankara");
            listBox1.Items.Add("istanbul");
            listBox1.Items.Add("Şanlıurfa");
            listBox1.Items.Add("Sivas");
            listBox1.Items.Add("Sinop");

        }

        private void txtgiris_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void btngöster_Click(object sender, EventArgs e)
        {
            var secilenIcerik = listBox1.SelectedItems;
            if(secilenIcerik.Count <= 0)
            {
                MessageBox.Show(
                    "il seçimi yapılmamıştır.","Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            var mesaj = string.Empty;
            foreach(var item in secilenIcerik)
            {
                mesaj = mesaj + $"{item}\n";
            }

            MessageBox.Show(
                mesaj,
                "Bilgi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information );
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            var secilenIndeksler = listBox1.SelectedIndices;
            if(secilenIndeksler.Count <= 0)
            {
                MessageBox.Show(
                    "lütfen silmek istediğiniz il seçimi yapınız",
                    "hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                  
            }

            for (int i = secilenIndeksler.Count-1; i >= 0; i--)
            {
                listBox1.Items.Remove(secilenIndeksler[i]);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<string> liste = new List<string>();
            foreach(var item in listBox1.SelectedItems)
            {
                liste.Add(item.ToString());
            }
            foreach(var item in liste)
            {
                listBox2.Items.Add(item.ToString());
                listBox1.Items.Remove(item);
            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> liste = new List<string>();
            foreach (var item in listBox2.SelectedItems)
            {
                liste.Add(item.ToString());
            }
            foreach (var item in liste)
            {
                listBox1.Items.Add(item.ToString());
                listBox2.Items.Remove(item);
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(listBox1.SelectedItems.Count > 0)
            {
                listBox1.DoDragDrop(listBox1, DragDropEffects.Move);
            }

            
            
            
            
        }

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            var tasinanData = e.Data.GetData(typeof(ListBox).FullName) as ListBox;

            if(tasinanData != null)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            var tasinanData = e.Data.GetData(typeof(ListBox).FullName) as ListBox;
            var secilenIndeksler = tasinanData.SelectedIndices;

            foreach(int item in secilenIndeksler)
            {
                listBox2.Items.Add(listBox1.Items[item]);
            }
            for(int i = secilenIndeksler.Count -1; i>=0; i--)
            {
                listBox1.Items.RemoveAt(secilenIndeksler[i]);
            }
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            var tasınandata1 = e.Data.GetData(typeof(ListBox).FullName) as ListBox;
            var secilenindexler1 = tasınandata1.SelectedIndices;
            foreach (int item in secilenindexler1)
            {
                listBox1.Items.Add(listBox2.Items[item]);
            }
            for (int i = secilenindexler1.Count - 1; i >= 0; i--)
            {
                listBox2.Items.RemoveAt(secilenindexler1[i]);
            }
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            var tasinanData1 = e.Data.GetData(typeof(ListBox).FullName) as ListBox;

            if (tasinanData1 != null)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                listBox2.DoDragDrop(listBox2, DragDropEffects.Move);
            }
        }
    }
}
