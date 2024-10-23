using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysTINSClass;

namespace SysTINSApp
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new(txtNome.Text, txtEmail.Text, txtSenha.Text, Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue))
                ) ;
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                MessageBox.Show($"Usuário {usuario.Id} inserido com sucesso");
                btnInserir.Enabled = false;
            } 

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            cmbNivel.DataSource = Nivel.ObterLista();//uma lista ou um objeto do tipo lista de niveis contendo todos os objetos do tipo lista
            cmbNivel.DisplayMember = "Nome";
            cmbNivel.ValueMember = "Id";

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
