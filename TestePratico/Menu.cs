using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePratico
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
        }

       
        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja sair realmente do programa?", "Confirmação de Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            Listar listar = new Listar();
            listar.ShowDialog();
        }

       
    }
}
