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
        public Form2(string numero, string data, string nome, string total) // Recebendo os parâmetros
        {
            InitializeComponent();
            label3.Text = "#" + numero;
            label5.Text = data;
            label7.Text = nome;
            label13.Text = total;
        }

        public ListView.ListViewItemCollection Items
        {
            set // Set envia e Get pega informacao
            {

                foreach (ListViewItem item in value) // foreach: for - para, each - cada, foreach - para cada. Para cada item em value faça
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
            // label11.Text = DateTime.Now.ToLongDateString();  data em que foi gerado por extenso
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria um novo formulário 
            Form frmAzul = new Form();

            // Atribui um titulo ao formulário
            frmAzul.Text = "Formulário Azul";

            // Altera a cor de fundo do formulário
            frmAzul.BackColor = System.Drawing.Color.Black;

            // Maximiza o formulário filho
            frmAzul.WindowState = System.Windows.Forms.FormWindowState.Minimized;


            // Define quem o pai desta janela
            frmAzul.IsMdiContainer = true;

            // exibe o formulário
            frmAzul.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();

            this.Hide(); // muito engracado eu tinha usado form2.Hide() e não escondia, já com esse this esconde
            form.Show();

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            
            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo)) // ou no lugar de this, colocar Text e assim tirar o Closing, o Closing é o título da mensagem
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            } 
            Application.Exit();
        }
        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}