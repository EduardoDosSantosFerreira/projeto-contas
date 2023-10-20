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
    public partial class frmfornecedor : Form
    {
        private void Habilita()
        {
            txtcod.Enabled = false;
            txtnm.Enabled = true;

            txtend.Enabled = true;
            txtN.Enabled = true;
            txtbairro.Enabled = true;
            txtcid.Enabled = true;
            txtsg.Enabled = true;
            txtcep.Enabled = true;
            txtcnpj.Enabled = true;
            txtie.Enabled = true;
            txttell.Enabled = true;
            txtemail.Enabled = true;

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
            txtcod.Enabled = false;
            txtnm.Enabled = false;

            txtend.Enabled = false;
            txtN.Enabled = false;
            txtbairro.Enabled = false;
            txtcid.Enabled = false;
            txtsg.Enabled = false;
            txtcep.Enabled = false;
            txtcnpj.Enabled = false;
            txtie.Enabled = false;
            txttell.Enabled = false;
            txtemail.Enabled = false;

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
        public frmfornecedor()
        {
            InitializeComponent();
        }

        private void tb_fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void frmfornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedorTableAdapter.Fill(this.cadastroDataSet.tb_fornecedor);

        }

        private void cd_fornecedorLabel_Click(object sender, EventArgs e)
        {

        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.MovePrevious();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.MoveNext();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.AddNew();
            Habilita();
        }

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.RemoveCurrent();
            tb_fornecedorTableAdapter.Update(cadastroDataSet.tb_fornecedor);
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            double dig1 = 0, dig2 = 0;
            dig1 += double.Parse(txtcnpj.Text.Substring(14, 1)) * 2;
            dig1 += double.Parse(txtcnpj.Text.Substring(13, 1)) * 3;
            dig1 += double.Parse(txtcnpj.Text.Substring(12, 1)) * 4;
            dig1 += double.Parse(txtcnpj.Text.Substring(11, 1)) * 5;
            dig1 += double.Parse(txtcnpj.Text.Substring(9, 1)) * 6;
            dig1 += double.Parse(txtcnpj.Text.Substring(8, 1)) * 7;
            dig1 += double.Parse(txtcnpj.Text.Substring(7, 1)) * 8;
            dig1 += double.Parse(txtcnpj.Text.Substring(5, 1)) * 9;
            dig1 += double.Parse(txtcnpj.Text.Substring(4, 1)) * 2;
            dig1 += double.Parse(txtcnpj.Text.Substring(3, 1)) * 3;
            dig1 += double.Parse(txtcnpj.Text.Substring(1, 1)) * 4;
            dig1 += double.Parse(txtcnpj.Text.Substring(0, 1)) * 5;
            dig1 = dig1 % 11;
            dig1 = 11 - dig1;

            dig2 += double.Parse(txtcnpj.Text.Substring(16, 1)) * 2;
            dig2 += double.Parse(txtcnpj.Text.Substring(14, 1)) * 3;
            dig2 += double.Parse(txtcnpj.Text.Substring(13, 1)) * 4;
            dig2 += double.Parse(txtcnpj.Text.Substring(12, 1)) * 5;
            dig2 += double.Parse(txtcnpj.Text.Substring(11, 1)) * 6;
            dig2 += double.Parse(txtcnpj.Text.Substring(9, 1)) * 7;
            dig2 += double.Parse(txtcnpj.Text.Substring(8, 1)) * 8;
            dig2 += double.Parse(txtcnpj.Text.Substring(7, 1)) * 9;
            dig2 += double.Parse(txtcnpj.Text.Substring(5, 1)) * 2;
            dig2 += double.Parse(txtcnpj.Text.Substring(4, 1)) * 3;
            dig2 += double.Parse(txtcnpj.Text.Substring(3, 1)) * 4;
            dig2 += double.Parse(txtcnpj.Text.Substring(1, 1)) * 5;
            dig2 += double.Parse(txtcnpj.Text.Substring(0, 1)) * 6;
            dig2 = dig2 % 11;
            dig2 = 11 - dig2;



            if (txtcnpj.Text.Substring(16, 1) != dig1.ToString() ||
               txtcnpj.Text.Substring(17, 1) != dig2.ToString())
            {
                MessageBox.Show("CNPJ Inválido!");
                txtcnpj.Focus();
            }
            else
            {
                Validate();
                tb_fornecedorBindingSource.EndEdit();
                tb_fornecedorTableAdapter.Update(cadastroDataSet.tb_fornecedor);
                Rehabilita();
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.CancelEdit();
            Rehabilita();
        }

        private void bt_pesquisa_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaFornecedor fpu = new frmPesquisaFornecedor();
            fpu.ShowDialog();
            cod = fpu.getCodigo();
            if (cod > 0)
            {
                reg = tb_fornecedorBindingSource.Find("cd_usuario", cod);
                tb_fornecedorBindingSource.Position = reg;
            }
        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE FORNECEDOR" + (char)10 + (char)10;
            strDados += "Código: " + txtcod.Text + (char)10 + (char)10;
            strDados += "Nome: " + txtnm.Text + (char)10 + (char)10;
            strDados += "CNPJ: " + txtcnpj.Text + (char)10 + (char)10;
            strDados += "Inscrição Estadual: " + txtie.Text + (char)10 + (char)10;
            strDados += "Endereço: " + txtend.Text + (char)10 + (char)10;
            strDados += "Número: " + txtN.Text + (char)10 + (char)10;
            strDados += "Bairro: " + txtbairro.Text + (char)10 + (char)10;
            strDados += "Cidade: " + txtcid.Text + (char)10 + (char)10;
            strDados += "Estado: " + txtsg.Text + (char)10 + (char)10;
            strDados += "CEP: " + txtcep.Text + (char)10 + (char)10;
            strDados += "Telefone: " + txttell.Text + (char)10 + (char)10;
            strDados += "Email: " + txtemail.Text;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new Pen(Brushes.Black), 50, 80, 800, 80);
        }
    }
}
