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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fechamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new();// cria uma instância (objeto) do FrmUsuarios 
            frmUsuarios.MdiParent = this; // associa esta instância ao container (MDI) FrmPrincipal
            frmUsuarios.Show(); // exibe o form Usuários na janela do sistema 
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Hide();
            FrmLogin frmLogin = new();
            //frmLogin.Show();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                tsslUsuario.Text = Program.UsuarioLogado.Nome + " - " + Program.UsuarioLogado.Nivel.Nome;
                Show();
            }
            else
                Application.Exit();

        }

        private void manterToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void novoInserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new();// cria uma instância (objeto) do FrmUsuarios 
            frmProdutos.MdiParent = this; // associa esta instância ao container (MDI) FrmPrincipal
            frmProdutos.Show(); // exibe o form Usuários na janela do sistema 
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmPedidoNovo frmPedidoNovo= new();// cria uma instância (objeto) do FrmUsuarios 
            frmPedidoNovo.MdiParent = this; // associa esta instância ao container (MDI) FrmPrincipal
            frmPedidoNovo.Show(); // exibe o form Usuários na janela do sistema 
        }
    }
}
