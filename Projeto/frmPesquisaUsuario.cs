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
    public partial class frmPesquisaUsuario : Form
    {
        private int codigo;

        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }
        public int getCodigo()
        {
            return (codigo);
        }
        private void tb_usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroDataSet);

        }

        private void frmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastroDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.cadastroDataSet.tb_usuario);

        }

        private void tb_usuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tb_usuarioTableAdapter.Fill(this.cadastroDataSet.tb_usuario);
            }
            else
            {
                this.tb_usuarioTableAdapter.FillByNome(this.cadastroDataSet.tb_usuario,"%"+txtNome.Text+"%");
            }
        }

        private void tb_usuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tb_usuarioDataGridView.CurrentRow.Cells[0].Value);
                Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Labelnome_Click(object sender, EventArgs e)
        {

        }
    }
}
