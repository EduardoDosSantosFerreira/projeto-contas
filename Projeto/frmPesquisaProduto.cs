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
    public partial class frmPesquisaProduto : Form
    {
        private int codigo;
        public frmPesquisaProduto()
        {
            InitializeComponent();
        }
        public int getCodigo()
        {
            return (codigo);
        }

        private void tb_produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void frmPesquisaProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tb_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_produtoTableAdapter.Fill(this.cadastroDataSet.tb_produto);

        }

        private void tb_produtoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tb_produtoTableAdapter.Fill(this.cadastroDataSet.tb_produto);
            }
            else
            {
                this.tb_produtoTableAdapter.FillByNome(this.cadastroDataSet.tb_produto, "%" + txtNome.Text + "%");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void tb_produtoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tb_produtoDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }
    }
}
