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
    public partial class frmPesquisaFornecedor : Form
    {
        private int codigo;
        public frmPesquisaFornecedor()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return (codigo);
        }

        private void tb_fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void frmPesquisaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedorTableAdapter.Fill(this.cadastroDataSet.tb_fornecedor);

        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tb_fornecedorTableAdapter.Fill(this.cadastroDataSet.tb_fornecedor);
            }
            else
            {
                this.tb_fornecedorTableAdapter.FillByNome(this.cadastroDataSet.tb_fornecedor, "%" + txtNome.Text + "%");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void tb_fornecedorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tb_fornecedorDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }
    }
}
