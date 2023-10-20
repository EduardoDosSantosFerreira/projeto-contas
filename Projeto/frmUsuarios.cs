using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class frmUsuarios : Form
    {

        private void Habilita()
        {
            txtcod.Enabled = false;
            txtnome.Enabled = true;
            txtnl.Enabled = true;
            txtlg.Enabled = true;
            txtsn.Enabled = true;
            bt_anterior.Enabled = false;
            bt_proximo.Enabled = false;
            bt_novo.Enabled = false;
            bt_alterar.Enabled = false;
            bt_excluir.Enabled = false;
            bt_salvar.Enabled = true;
            bt_cancelar.Enabled = true;
            bt_pesquisa.Enabled = false;
            bt_imprimir.Enabled = false;
            bt_sair.Enabled = false;
        }
        private void ReHabilita()
        {
            txtcod.Enabled = false;
            txtnome.Enabled = false;
            txtnl.Enabled = false;
            txtlg.Enabled = false;
            txtsn.Enabled = false;
            bt_anterior.Enabled = true;
            bt_proximo.Enabled = true;
            bt_novo.Enabled = true;
            bt_alterar.Enabled = true;
            bt_excluir.Enabled = true;
            bt_salvar.Enabled = false;
            bt_cancelar.Enabled = false;
            bt_pesquisa.Enabled = true;
            bt_imprimir.Enabled = true;
            bt_sair.Enabled = true;
        }
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            this.tb_usuarioTableAdapter.Fill(this.cadastroDataSet1.tb_usuario);
            ReHabilita();
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
            Habilita();
        }

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void bt_pesquisa_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaUsuario fpu = new frmPesquisaUsuario();
            fpu.ShowDialog();
            cod = fpu.getCodigo();
            if (cod > 0)
            {
               reg = bindingSource1.Find("cd_usuario", cod);
                bindingSource1.Position = reg;
            }

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            tb_usuarioTableAdapter.Update(cadastroDataSet1.tb_usuario);
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Validate();
            bindingSource1.EndEdit();
            tb_usuarioTableAdapter.Update(cadastroDataSet1.tb_usuario);
            ReHabilita();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            bindingSource1.CancelEdit();
            ReHabilita();
        }

        private void txtsn_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE USUÁRIO" + (char)10 + (char)10;
            strDados += "Código: " + txtcod.Text + (char)10 + (char)10;
            strDados += "Nome: " + txtnome.Text + (char)10 + (char)10;
            strDados += "Nível: " + txtlg.Text + (char)10 + (char)10;
            strDados += "Login: " + txtsn.Text;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new Pen(Brushes.Black), 50, 80, 800, 80);
        }
    }
}
