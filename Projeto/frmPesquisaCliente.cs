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
    public partial class frmPesquisaCliente : Form
    {
        private int codigo;
        public frmPesquisaCliente()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return (codigo);
        }

        private void tb_clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void frmPesquisaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tb_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_clienteTableAdapter.Fill(this.cadastroDataSet.tb_cliente);

        }

        private void tb_clienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tb_clienteTableAdapter.Fill(this.cadastroDataSet.tb_cliente);
            }
            else
            {
                this.tb_clienteTableAdapter.FillByNome(this.cadastroDataSet.tb_cliente, "%" + txtNome.Text + "%");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void tb_clienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tb_clienteDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }
    }
    
}
