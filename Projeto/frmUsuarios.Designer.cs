namespace Projeto
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroDataSet1 = new Projeto.cadastroDataSet();
            this.txtnl = new System.Windows.Forms.TextBox();
            this.txtlg = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtsn = new System.Windows.Forms.TextBox();
            this.bt_anterior = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_proximo = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_pesquisa = new System.Windows.Forms.Button();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.bt_imprimir = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.tb_usuarioTableAdapter = new Projeto.cadastroDataSetTableAdapters.tb_usuarioTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "nível";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "senha";
            // 
            // txtcod
            // 
            this.txtcod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "cd_usuario", true));
            this.txtcod.Enabled = false;
            this.txtcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.Location = new System.Drawing.Point(169, 38);
            this.txtcod.MaxLength = 11;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 26);
            this.txtcod.TabIndex = 5;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tb_usuario";
            this.bindingSource1.DataSource = this.cadastroDataSet1;
            // 
            // cadastroDataSet1
            // 
            this.cadastroDataSet1.DataSetName = "cadastroDataSet";
            this.cadastroDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtnl
            // 
            this.txtnl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "sg_nivel", true));
            this.txtnl.Enabled = false;
            this.txtnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnl.Location = new System.Drawing.Point(169, 121);
            this.txtnl.MaxLength = 1;
            this.txtnl.Name = "txtnl";
            this.txtnl.Size = new System.Drawing.Size(27, 26);
            this.txtnl.TabIndex = 6;
            // 
            // txtlg
            // 
            this.txtlg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "nm_login", true));
            this.txtlg.Enabled = false;
            this.txtlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlg.Location = new System.Drawing.Point(169, 161);
            this.txtlg.MaxLength = 15;
            this.txtlg.Name = "txtlg";
            this.txtlg.Size = new System.Drawing.Size(100, 26);
            this.txtlg.TabIndex = 7;
            // 
            // txtnome
            // 
            this.txtnome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "nm_usuario", true));
            this.txtnome.Enabled = false;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(169, 79);
            this.txtnome.MaxLength = 50;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(537, 26);
            this.txtnome.TabIndex = 8;
            // 
            // txtsn
            // 
            this.txtsn.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSource1, "cd_senha", true));
            this.txtsn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "nm_login", true));
            this.txtsn.Enabled = false;
            this.txtsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsn.Location = new System.Drawing.Point(169, 202);
            this.txtsn.MaxLength = 15;
            this.txtsn.Name = "txtsn";
            this.txtsn.Size = new System.Drawing.Size(100, 26);
            this.txtsn.TabIndex = 9;
            this.txtsn.UseSystemPasswordChar = true;
            this.txtsn.TextChanged += new System.EventHandler(this.txtsn_TextChanged);
            // 
            // bt_anterior
            // 
            this.bt_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_anterior.Location = new System.Drawing.Point(46, 277);
            this.bt_anterior.Name = "bt_anterior";
            this.bt_anterior.Size = new System.Drawing.Size(89, 30);
            this.bt_anterior.TabIndex = 10;
            this.bt_anterior.Text = "anterior";
            this.bt_anterior.UseVisualStyleBackColor = true;
            this.bt_anterior.Click += new System.EventHandler(this.bt_anterior_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Enabled = false;
            this.bt_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar.Location = new System.Drawing.Point(46, 355);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(89, 30);
            this.bt_salvar.TabIndex = 11;
            this.bt_salvar.Text = "salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_proximo
            // 
            this.bt_proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_proximo.Location = new System.Drawing.Point(169, 278);
            this.bt_proximo.Name = "bt_proximo";
            this.bt_proximo.Size = new System.Drawing.Size(89, 30);
            this.bt_proximo.TabIndex = 12;
            this.bt_proximo.Text = "próximo";
            this.bt_proximo.UseVisualStyleBackColor = true;
            this.bt_proximo.Click += new System.EventHandler(this.bt_proximo_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Enabled = false;
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Location = new System.Drawing.Point(169, 355);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(89, 30);
            this.bt_cancelar.TabIndex = 13;
            this.bt_cancelar.Text = "cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_novo
            // 
            this.bt_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_novo.Location = new System.Drawing.Point(310, 277);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(89, 30);
            this.bt_novo.TabIndex = 14;
            this.bt_novo.Text = "novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_pesquisa
            // 
            this.bt_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisa.Location = new System.Drawing.Point(310, 355);
            this.bt_pesquisa.Name = "bt_pesquisa";
            this.bt_pesquisa.Size = new System.Drawing.Size(89, 30);
            this.bt_pesquisa.TabIndex = 15;
            this.bt_pesquisa.Text = "pesquisar";
            this.bt_pesquisa.UseVisualStyleBackColor = true;
            this.bt_pesquisa.Click += new System.EventHandler(this.bt_pesquisa_Click);
            // 
            // bt_alterar
            // 
            this.bt_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alterar.Location = new System.Drawing.Point(454, 277);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(89, 30);
            this.bt_alterar.TabIndex = 16;
            this.bt_alterar.Text = "alterar";
            this.bt_alterar.UseVisualStyleBackColor = true;
            this.bt_alterar.Click += new System.EventHandler(this.bt_alterar_Click);
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_imprimir.Location = new System.Drawing.Point(454, 355);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(89, 30);
            this.bt_imprimir.TabIndex = 17;
            this.bt_imprimir.Text = "imprimir";
            this.bt_imprimir.UseVisualStyleBackColor = true;
            this.bt_imprimir.Click += new System.EventHandler(this.bt_imprimir_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluir.Location = new System.Drawing.Point(617, 278);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(89, 30);
            this.bt_excluir.TabIndex = 18;
            this.bt_excluir.Text = "excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.Location = new System.Drawing.Point(617, 355);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(89, 30);
            this.bt_sair.TabIndex = 19;
            this.bt_sair.Text = "sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // tb_usuarioTableAdapter
            // 
            this.tb_usuarioTableAdapter.ClearBeforeFill = true;
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
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.txtsn);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtlg);
            this.Controls.Add(this.txtnl);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuarios";
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtnl;
        private System.Windows.Forms.TextBox txtlg;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtsn;
        private System.Windows.Forms.Button bt_anterior;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_proximo;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_pesquisa;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.Button bt_imprimir;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_sair;
        private cadastroDataSet cadastroDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private cadastroDataSetTableAdapters.tb_usuarioTableAdapter tb_usuarioTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}