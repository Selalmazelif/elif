using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gecis
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textbox.Text);
            textbox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var secilen = listBox1.SelectedItems;
            if (secilen.Count > 0)
            {
                foreach (var at in secilen) { 
                listBox2.Items.Add(at);
                }
                listBox1.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var secilen = listBox2.SelectedItems;
            if (secilen.Count > 0)
            {
                foreach (var at in secilen)
                {
                    listBox1.Items.Add(at);
                }
                listBox2.Items.Clear();
            }
        }
    }
}
