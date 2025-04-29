using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaLista
{
    public partial class Form1 : Form
    {
        Lista l = new Lista();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonIMPRIMIR_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxLISTA.Text = l.imprime();
        }

        private void buttonInsereFIM_MouseClick(object sender, MouseEventArgs e)
        {
            l.insere(Convert.ToInt32(textBoxNRO.Text));
            textBoxNRO.Text = string.Empty;
        }

        // MouseClick para o botão "Remove"
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxLISTA.Text = l.imprime();
            MessageBox.Show("Escolha um número a ser removido");

       }

        private void buttonLIMPAR_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxLISTA.Text = string.Empty;
        }

        private void buttonOK_Remove_MouseClick(object sender, MouseEventArgs e)
        {
            int temp = Convert.ToInt32(textBoxNRO.Text);

            // achar a referência de temp na lista
            l.remove(temp);

            MessageBox.Show(textBoxNRO.Text + "  removido");
        }
    }
}
