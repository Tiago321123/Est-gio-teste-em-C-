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
    public partial class Form1 : Form
    {
        public static 
        int a=0;
        string valorTotal;
        string[] valorTotal1 = new string[200];

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void textBox4_TextChanged(object sender, EventArgs e)
        {
         
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                a += 1;
                ListViewItem item1 = new ListViewItem(textBox4.Text, 0);
                
                valorTotal = Convert.ToString(Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox6.Text));
                if (a == 1)
                {
                    valorTotal1[a] = valorTotal;
                }
                else
                {
                    valorTotal1[a] = Convert.ToString(Convert.ToDouble(valorTotal) + Convert.ToDouble(valorTotal1[a - 1]));
                }
                item1.Checked = true;

                item1.SubItems.Add(textBox5.Text + "x");
                item1.SubItems.Add("R$ " + textBox6.Text);
                item1.SubItems.Add("R$ " + valorTotal); /* Os subItems tem que ser em string */
                listView1.Items.AddRange(new ListViewItem[] { item1 });
                label9.Text = valorTotal1[a]; /* Para label receber string, colocar .Text */
                
            }
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new Form2(textBox1.Text, textBox2.Text, textBox3.Text, label9.Text);
            form2.Items = listView1.Items;
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            label9.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
