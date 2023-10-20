namespace Projeto
{
    partial class frmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label Codigo;
            System.Windows.Forms.Label Nome;
            System.Windows.Forms.Label sg_unidadeLabel;
            System.Windows.Forms.Label nm_marcaLabel;
            System.Windows.Forms.Label vl_custoLabel;
            System.Windows.Forms.Label vl_vendaLabel;
            System.Windows.Forms.Label qt_estoqueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.cadastroDataSet = new Projeto.cadastroDataSet();
            this.tb_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_produtoTableAdapter = new Projeto.cadastroDataSetTableAdapters.tb_produtoTableAdapter();
            this.tableAdapterManager = new Projeto.cadastroDataSetTableAdapters.TableAdapterManager();
            this.txtcd = new System.Windows.Forms.TextBox();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtct = new System.Windows.Forms.TextBox();
            this.txtVV = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.bt_sair = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_imprimir = new System.Windows.Forms.Button();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.bt_pesquisa = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_proximo = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_anterior = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            Codigo = new System.Windows.Forms.Label();
            Nome = new System.Windows.Forms.Label();
            sg_unidadeLabel = new System.Windows.Forms.Label();
            nm_marcaLabel = new System.Windows.Forms.Label();
            vl_custoLabel = new System.Windows.Forms.Label();
            vl_vendaLabel = new System.Windows.Forms.Label();
            qt_estoqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Codigo
            // 
            Codigo.AutoSize = true;
            Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Codigo.Location = new System.Drawing.Point(142, 79);
            Codigo.Name = "Codigo";
            Codigo.Size = new System.Drawing.Size(63, 20);
            Codigo.TabIndex = 1;
            Codigo.Text = "Codigo:";
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Nome.Location = new System.Drawing.Point(150, 105);
            Nome.Name = "Nome";
            Nome.Size = new System.Drawing.Size(55, 20);
            Nome.TabIndex = 3;
            Nome.Text = "Nome:";
            // 
            // sg_unidadeLabel
            // 
            sg_unidadeLabel.AutoSize = true;
            sg_unidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_unidadeLabel.Location = new System.Drawing.Point(132, 131);
            sg_unidadeLabel.Name = "sg_unidadeLabel";
            sg_unidadeLabel.Size = new System.Drawing.Size(73, 20);
            sg_unidadeLabel.TabIndex = 5;
            sg_unidadeLabel.Text = "Unidade:";
            // 
            // nm_marcaLabel
            // 
            nm_marcaLabel.AutoSize = true;
            nm_marcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_marcaLabel.Location = new System.Drawing.Point(148, 157);
            nm_marcaLabel.Name = "nm_marcaLabel";
            nm_marcaLabel.Size = new System.Drawing.Size(57, 20);
            nm_marcaLabel.TabIndex = 7;
            nm_marcaLabel.Text = "Marca:";
            // 
            // vl_custoLabel
            // 
            vl_custoLabel.AutoSize = true;
            vl_custoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_custoLabel.Location = new System.Drawing.Point(150, 183);
            vl_custoLabel.Name = "vl_custoLabel";
            vl_custoLabel.Size = new System.Drawing.Size(55, 20);
            vl_custoLabel.TabIndex = 9;
            vl_custoLabel.Text = "Custo:";
            // 
            // vl_vendaLabel
            // 
            vl_vendaLabel.AutoSize = true;
            vl_vendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_vendaLabel.Location = new System.Drawing.Point(82, 209);
            vl_vendaLabel.Name = "vl_vendaLabel";
            vl_vendaLabel.Size = new System.Drawing.Size(123, 20);
            vl_vendaLabel.TabIndex = 11;
            vl_vendaLabel.Text = "Valor da Venda:";
            // 
            // qt_estoqueLabel
            // 
            qt_estoqueLabel.AutoSize = true;
            qt_estoqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qt_estoqueLabel.Location = new System.Drawing.Point(118, 235);
            qt_estoqueLabel.Name = "qt_estoqueLabel";
            qt_estoqueLabel.Size = new System.Drawing.Size(87, 20);
            qt_estoqueLabel.TabIndex = 13;
            qt_estoqueLabel.Text = "Quatidade:";
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "cadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_produtoBindingSource
            // 
            this.tb_produtoBindingSource.DataMember = "tb_produto";
            this.tb_produtoBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tb_produtoTableAdapter
            // 
            this.tb_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = null;
            this.tableAdapterManager.tb_fornecedorTableAdapter = null;
            this.tableAdapterManager.tb_produtoTableAdapter = this.tb_produtoTableAdapter;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto.cadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtcd
            // 
            this.txtcd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "cd_produto", true));
            this.txtcd.Enabled = false;
            this.txtcd.Location = new System.Drawing.Point(211, 79);
            this.txtcd.MaxLength = 11;
            this.txtcd.Name = "txtcd";
            this.txtcd.Size = new System.Drawing.Size(100, 20);
            this.txtcd.TabIndex = 2;
            // 
            // txtnm
            // 
            this.txtnm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "nm_produto", true));
            this.txtnm.Enabled = false;
            this.txtnm.Location = new System.Drawing.Point(211, 105);
            this.txtnm.MaxLength = 50;
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(100, 20);
            this.txtnm.TabIndex = 4;
            // 
            // txtN
            // 
            this.txtN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "sg_unidade", true));
            this.txtN.Enabled = false;
            this.txtN.Location = new System.Drawing.Point(211, 131);
            this.txtN.MaxLength = 2;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 6;
            // 
            // txtmarca
            // 
            this.txtmarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "nm_marca", true));
            this.txtmarca.Enabled = false;
            this.txtmarca.Location = new System.Drawing.Point(211, 157);
            this.txtmarca.MaxLength = 20;
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(100, 20);
            this.txtmarca.TabIndex = 8;
            // 
            // txtct
            // 
            this.txtct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "vl_custo", true));
            this.txtct.Enabled = false;
            this.txtct.Location = new System.Drawing.Point(211, 183);
            this.txtct.MaxLength = 15;
            this.txtct.Name = "txtct";
            this.txtct.Size = new System.Drawing.Size(100, 20);
            this.txtct.TabIndex = 10;
            // 
            // txtVV
            // 
            this.txtVV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "vl_venda", true));
            this.txtVV.Enabled = false;
            this.txtVV.Location = new System.Drawing.Point(211, 209);
            this.txtVV.MaxLength = 15;
            this.txtVV.Name = "txtVV";
            this.txtVV.Size = new System.Drawing.Size(100, 20);
            this.txtVV.TabIndex = 12;
            // 
            // txtQ
            // 
            this.txtQ.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_produtoBindingSource, "qt_estoque", true));
            this.txtQ.Enabled = false;
            this.txtQ.Location = new System.Drawing.Point(211, 235);
            this.txtQ.MaxLength = 4;
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(100, 20);
            this.txtQ.TabIndex = 14;
            // 
            // bt_sair
            // 
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.Location = new System.Drawing.Point(484, 387);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(81, 30);
            this.bt_sair.TabIndex = 44;
            this.bt_sair.Text = "sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluir.Location = new System.Drawing.Point(484, 309);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(81, 30);
            this.bt_excluir.TabIndex = 43;
            this.bt_excluir.Text = "excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_imprimir.Location = new System.Drawing.Point(372, 387);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(81, 30);
            this.bt_imprimir.TabIndex = 42;
            this.bt_imprimir.Text = "imprimir";
            this.bt_imprimir.UseVisualStyleBackColor = true;
            this.bt_imprimir.Click += new System.EventHandler(this.bt_imprimir_Click);
            // 
            // bt_alterar
            // 
            this.bt_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alterar.Location = new System.Drawing.Point(372, 309);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(81, 30);
            this.bt_alterar.TabIndex = 41;
            this.bt_alterar.Text = "alterar";
            this.bt_alterar.UseVisualStyleBackColor = true;
            this.bt_alterar.Click += new System.EventHandler(this.bt_alterar_Click);
            // 
            // bt_pesquisa
            // 
            this.bt_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisa.Location = new System.Drawing.Point(260, 387);
            this.bt_pesquisa.Name = "bt_pesquisa";
            this.bt_pesquisa.Size = new System.Drawing.Size(81, 30);
            this.bt_pesquisa.TabIndex = 40;
            this.bt_pesquisa.Text = "pesquisar";
            this.bt_pesquisa.UseVisualStyleBackColor = true;
            this.bt_pesquisa.Click += new System.EventHandler(this.bt_pesquisa_Click);
            // 
            // bt_novo
            // 
            this.bt_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_novo.Location = new System.Drawing.Point(260, 309);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(81, 30);
            this.bt_novo.TabIndex = 39;
            this.bt_novo.Text = "novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Enabled = false;
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Location = new System.Drawing.Point(148, 387);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(81, 30);
            this.bt_cancelar.TabIndex = 38;
            this.bt_cancelar.Text = "cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_proximo
            // 
            this.bt_proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_proximo.Location = new System.Drawing.Point(148, 310);
            this.bt_proximo.Name = "bt_proximo";
            this.bt_proximo.Size = new System.Drawing.Size(81, 30);
            this.bt_proximo.TabIndex = 37;
            this.bt_proximo.Text = "próximo";
            this.bt_proximo.UseVisualStyleBackColor = true;
            this.bt_proximo.Click += new System.EventHandler(this.bt_proximo_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Enabled = false;
            this.bt_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar.Location = new System.Drawing.Point(36, 387);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(81, 30);
            this.bt_salvar.TabIndex = 36;
            this.bt_salvar.Text = "salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_anterior
            // 
            this.bt_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_anterior.Location = new System.Drawing.Point(36, 309);
            this.bt_anterior.Name = "bt_anterior";
            this.bt_anterior.Size = new System.Drawing.Size(81, 30);
            this.bt_anterior.TabIndex = 35;
            this.bt_anterior.Text = "anterior";
            this.bt_anterior.UseVisualStyleBackColor = true;
            this.bt_anterior.Click += new System.EventHandler(this.bt_anterior_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.ControlBox = false;
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.bt_imprimir);
            this.Controls.Add(this.bt_alterar);
            this.Controls.Add(this.bt_pesquisa);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_proximo);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.bt_anterior);
            this.Controls.Add(Codigo);
            this.Controls.Add(this.txtcd);
            this.Controls.Add(Nome);
            this.Controls.Add(this.txtnm);
            this.Controls.Add(sg_unidadeLabel);
            this.Controls.Add(this.txtN);
            this.Controls.Add(nm_marcaLabel);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(vl_custoLabel);
            this.Controls.Add(this.txtct);
            this.Controls.Add(vl_vendaLabel);
            this.Controls.Add(this.txtVV);
            this.Controls.Add(qt_estoqueLabel);
            this.Controls.Add(this.txtQ);
            this.Name = "frmProduto";
            this.Text = "frmProduto";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tb_produtoBindingSource;
        private cadastroDataSetTableAdapters.tb_produtoTableAdapter tb_produtoTableAdapter;
        private cadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtcd;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtct;
        private System.Windows.Forms.TextBox txtVV;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_imprimir;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.Button bt_pesquisa;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_proximo;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_anterior;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}