using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        int a = 0;
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            a += 1;
            ListViewItem item1 = new ListViewItem(textBox4.Text); // declaro o item1 coloco como item o textBox4, os outros ficam como SubItems 

            // Mensagens de erro
            if (textBox4.Text == "")
            {
                MessageBox.Show(this, "Digite o nome do produto", "Erro", MessageBoxButtons.OKCancel);
                textBox4.Focus();
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show(this, "Digite a quantidade do produto", "Erro", MessageBoxButtons.OKCancel);
                textBox5.Focus();
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show(this, "Digite o valor unitário do produto", "Erro", MessageBoxButtons.OKCancel);
                textBox6.Focus();
            }

            else
            {

                valorTotal = Convert.ToString(Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox6.Text));
                if (a == 1)
                {
                    valorTotal1[1] = valorTotal;
                }
                else
                {
                    valorTotal1[a] = Convert.ToString(Convert.ToDouble(valorTotal) + Convert.ToDouble(valorTotal1[a - 1])); /// Converto para double, somo e depois passo para string
                }

                item1.Checked = true;
                item1.SubItems.Add(textBox5.Text + "x");
                item1.SubItems.Add("R$ " + textBox6.Text);
                item1.SubItems.Add("R$ " + valorTotal); /* Os subItems tem que ser em string */
                listView1.Items.AddRange(new ListViewItem[] { item1 }); // Range: Faixa. Adicionar uma faixa de items no listView1
                label9.Text = valorTotal1[a]; /* Para label receber string, colocar .Text */
            }
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show(this, "Digite o número da venda", "Erro", MessageBoxButtons.OKCancel);
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show(this, "Digite a data", "Erro", MessageBoxButtons.OKCancel);
                textBox2.Focus();
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show(this, "Digite o nome do cliente", "Erro", MessageBoxButtons.OKCancel);
                textBox3.Focus();
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show(this, "Digite o nome do produto", "Erro", MessageBoxButtons.OKCancel);
                textBox4.Focus();
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show(this, "Digite a quantidade do produto", "Erro", MessageBoxButtons.OKCancel);
                textBox5.Focus();
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show(this, "Digite o valor unitário do produto", "Erro", MessageBoxButtons.OKCancel);
                textBox6.Focus();
            }

            else
            {
                Form2 form2 = new Form2(textBox1.Text, textBox2.Text, textBox3.Text, label9.Text);


                /* A palavra-chave var instrui o compilador para deduzir o tipo da variável 
                da expressão no lado direito da instrução de inicialização.
                O tipo inferido pode ser um tipo interno, um tipo anônimo, um tipo definido pelo usuário 
                ou um tipo definido na biblioteca de classes do NET Framework. (int, string, double...) */
                form2.Items = listView1.Items;

                this.Hide(); //this.Hide();  vai "esconder" o form atual e daí vai aparecer o outro logo em seguida 
                form2.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            label9.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
           
            
            Application.Exit();
        }
        
       

    }
}
