using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estágio_teste
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string numero, string data, string nome, string total)
        {
            InitializeComponent();
            label3.Text = "#" + numero;
            label5.Text = data;
            label7.Text = nome;
            label13.Text = total;
        }

        public ListView.ListViewItemCollection Items
        {
            set
            {
                foreach (ListViewItem item in value)
                {
                    listView1.Items.Add((ListViewItem)item.Clone());
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label11.Text = DateTime.Now.ToString("dd/MM/yyyy");
            label12.Text = DateTime.Now.ToShortTimeString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
