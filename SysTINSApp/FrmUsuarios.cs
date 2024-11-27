//
﻿using SysTINSClass;
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
//
//
            Usuario usuario = new(
                txtNome.Text,
                txtEmail.Text,
                txtSenha.Text,
                Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue))
                );
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                CarregaGridUsuarios();
                MessageBox.Show($"Usuário {usuario.Id} inserido com sucesso");
                btnInserir.Enabled = false;
            }
//

// 7afd2f3889b316a0337ea6dbfa375599e1695451
//

// 7afd2f3889b316a0337ea6dbfa375599e1695451

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
//
//
            Usuario usuario = new();
            usuario.Id = int.Parse(txtId.Text);
            usuario.Nome = txtNome.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Nivel = Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue));
            if(usuario.Atualizar())
            {
                CarregaGridUsuarios();
                MessageBox.Show("Usuário atualizado com sucesso!");
            }
//

// 7afd2f3889b316a0337ea6dbfa375599e1695451
//

// 7afd2f3889b316a0337ea6dbfa375599e1695451
        }

        private void cmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
//
//
            //carregandoi o combobox
//
// 7afd2f3889b316a0337ea6dbfa375599e1695451
//
// 7afd2f3889b316a0337ea6dbfa375599e1695451
            cmbNivel.DataSource = Nivel.ObterLista();//uma lista ou um objeto do tipo lista de niveis contendo todos os objetos do tipo lista
            cmbNivel.DisplayMember = "Nome";
            cmbNivel.ValueMember = "Id";

//
//
            //carregando o datagrid de usuarios

            //metodo estatico e da classe metodo nao etatico e o objeto
//
// 7afd2f3889b316a0337ea6dbfa375599e1695451
//
// 7afd2f3889b316a0337ea6dbfa375599e1695451
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
//
//
            int linhaAtual = dgvUsuarios.CurrentRow.Index;
            int idUser = Convert.ToInt32(dgvUsuarios.Rows[linhaAtual].Cells[0].Value);
            var usuario = Usuario.ObterPorId(idUser);
            txtId.Text = usuario.Id.ToString();
            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            chkAtivo.Checked = usuario.Ativo;
            cmbNivel.SelectedIndex = usuario.Nivel.Id;
            btnAtualizar.Enabled = true;
            //MessageBox.Show(linhaAtual.ToString();
        }
        private void CarregaGridUsuarios()
        {
            dgvUsuarios.Rows.Clear();
            var listaDeUsuarios = Usuario.ObterLista();
            int linha = 0;

            foreach (var usuario in listaDeUsuarios)
            {

                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[linha].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[linha].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[linha].Cells[2].Value = usuario.Email;
                dgvUsuarios.Rows[linha].Cells[3].Value = usuario.Nivel.Nome;
                dgvUsuarios.Rows[linha].Cells[4].Value = usuario.Ativo;
                linha++;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
//
// 7afd2f3889b316a0337ea6dbfa375599e1695451
//
// 7afd2f3889b316a0337ea6dbfa375599e1695451

        }
    }
}
