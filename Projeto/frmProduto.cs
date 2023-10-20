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
    public partial class frmProduto : Form
    {
        private void Habilita()
        {
            txtcd.Enabled = false;
            txtnm.Enabled = true;

            txtVV.Enabled = true;
            txtN.Enabled = true;
            txtQ.Enabled = true;
            txtmarca.Enabled = true;
            txtct.Enabled = true;

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

        private void Rehabilita()
        {
            txtcd.Enabled = false;
            txtnm.Enabled = false;

            txtVV.Enabled = false;
            txtN.Enabled = false;
            txtQ.Enabled = false;
            txtmarca.Enabled = false;
            txtct.Enabled = false;

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
        public frmProduto()
        {
            InitializeComponent();
        }

        private void tb_produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tb_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_produtoTableAdapter.Fill(this.cadastroDataSet.tb_produto);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            tb_produtoBindingSource.MovePrevious();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            tb_produtoBindingSource.MoveNext();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            tb_produtoBindingSource.AddNew();
            Habilita();
        }

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            tb_produtoBindingSource.RemoveCurrent();
            tb_produtoTableAdapter.Update(cadastroDataSet.tb_produto);
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Validate();
            tb_produtoBindingSource.EndEdit();
            tb_produtoTableAdapter.Update(cadastroDataSet.tb_produto);
            Rehabilita();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            tb_produtoBindingSource.CancelEdit();
            Rehabilita();
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_pesquisa_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaProduto fpu = new frmPesquisaProduto();
            fpu.ShowDialog();
            cod = fpu.getCodigo();
            if (cod > 0)
            {
                reg = tb_produtoBindingSource.Find("cd_usuario", cod);
                tb_produtoBindingSource.Position = reg;
            }

        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE PRODUTO" + (char)10 + (char)10;
            strDados += "Código: " + txtcd.Text + (char)10 + (char)10;
            strDados += "Nome: " + txtnm.Text + (char)10 + (char)10;
            strDados += "Unidade: " + txtN.Text + (char)10 + (char)10;
            strDados += "Marca: " + txtmarca.Text + (char)10 + (char)10;
            strDados += "Preço de Custo: " + txtct.Text + (char)10 + (char)10;
            strDados += "Preço de Venda: " + txtVV.Text + (char)10 + (char)10;
            strDados += "Estoque: " + txtQ.Text;


            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new Pen(Brushes.Black), 50, 80, 800, 80);
        }
    }
}
