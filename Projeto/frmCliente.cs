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
    public partial class frmCliente : Form
    {
        private void Habilita()
        {
            txtcod.Enabled = false;
            txtnm.Enabled = true;

            txtend.Enabled = true;
            txtN.Enabled = true;
            txtbairro.Enabled = true;
            txtcidade.Enabled = true;
            txtestado.Enabled = true;
            txtcep.Enabled = true;
            txtcpf.Enabled = true;
            txtrg.Enabled = true;
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
        private void ReHabilita()
        {
            txtcod.Enabled = false;
            txtnm.Enabled = false;

            txtend.Enabled = false;
            txtN.Enabled = false;
            txtbairro.Enabled = false;
            txtcidade.Enabled = false;
            txtestado.Enabled = false;
            txtcep.Enabled = false;
            txtcpf.Enabled = false;
            txtrg.Enabled = false;
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
        public frmCliente()
        {
            InitializeComponent();
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            SourceCliente.MovePrevious();
        }

        private void frmcliente_Load(object sender, EventArgs e)
        {
            this.AdapterCliente.Fill(this.cadastro_Cliente.tb_cliente);
            ReHabilita();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            SourceCliente.MoveNext();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            SourceCliente.AddNew();
            Habilita();
        }

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            SourceCliente.RemoveCurrent();
            AdapterCliente.Update(cadastro_Cliente.tb_cliente);
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            double dig1= 0, dig2= 0;

            dig1 += double.Parse(txtcpf.Text.Substring(10, 1)) * 2;
            dig1 += double.Parse(txtcpf.Text.Substring(9, 1)) * 3;
            dig1 += double.Parse(txtcpf.Text.Substring(8, 1)) * 4;
            dig1 += double.Parse(txtcpf.Text.Substring(6, 1)) * 5;
            dig1 += double.Parse(txtcpf.Text.Substring(5, 1)) * 6;
            dig1 += double.Parse(txtcpf.Text.Substring(4, 1)) * 7;
            dig1 += double.Parse(txtcpf.Text.Substring(2, 1)) * 8;
            dig1 += double.Parse(txtcpf.Text.Substring(1, 1)) * 9;
            dig1 += double.Parse(txtcpf.Text.Substring(0, 1)) * 10;
            dig1 = dig1 % 11;
            dig1 = 11 - dig1;

            dig2 += double.Parse(txtcpf.Text.Substring(12, 1)) * 2;
            dig2 += double.Parse(txtcpf.Text.Substring(10, 1)) * 3;
            dig2 += double.Parse(txtcpf.Text.Substring(9, 1)) * 4;
            dig2 += double.Parse(txtcpf.Text.Substring(8, 1)) * 5;
            dig2 += double.Parse(txtcpf.Text.Substring(6, 1)) * 6;
            dig2 += double.Parse(txtcpf.Text.Substring(5, 1)) * 7;
            dig2 += double.Parse(txtcpf.Text.Substring(4, 1)) * 8;
            dig2 += double.Parse(txtcpf.Text.Substring(2, 1)) * 9;
            dig2 += double.Parse(txtcpf.Text.Substring(1, 1)) * 10;
            dig2 += double.Parse(txtcpf.Text.Substring(0, 1)) * 11;
            dig2 = dig2 % 11;



            if (txtcpf.Text.Substring(12, 1) != dig1.ToString() ||
               txtcpf.Text.Substring(13, 1) != dig2.ToString())
            {
                MessageBox.Show("CPF Inválido!");
                txtcpf.Focus();
            }
            else
            {
                Validate();
                SourceCliente.EndEdit();
                AdapterCliente.Update(cadastro_Cliente.tb_cliente);
                ReHabilita();
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            SourceCliente.CancelEdit();
            ReHabilita();
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_pesquisa_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaCliente fpu = new frmPesquisaCliente();
            fpu.ShowDialog();
            cod = fpu.getCodigo();
            if (cod > 0)
            {
                reg = SourceCliente.Find("cd_usuario", cod);
                SourceCliente.Position = reg;
            }
        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE CLIENTE" + (char)10 + (char)10;
            strDados += "Código: " + txtcod.Text + (char)10 + (char)10;
            strDados += "Nome: " + txtnm.Text + (char)10 + (char)10;
            strDados += "Endereço: " + txtend.Text + (char)10 + (char)10;
            strDados += "Número: " + txtN.Text + (char)10 + (char)10;
            strDados += "Bairro: " + txtbairro.Text + (char)10 + (char)10;
            strDados += "Cidade: " + txtcidade.Text + (char)10 + (char)10;
            strDados += "Estado: " + txtestado.Text + (char)10 + (char)10;
            strDados += "CEP: " + txtcep.Text + (char)10 + (char)10;
            strDados += "CPF: " + txtcpf.Text + (char)10 + (char)10;
            strDados += "RG: " + txtrg.Text + (char)10 + (char)10;
            strDados += "Telefone: " + txttell.Text + (char)10 + (char)10;
            strDados += "Email: " + txtemail.Text;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new Pen(Brushes.Black), 50, 80, 800, 80);
        }
    }
}
