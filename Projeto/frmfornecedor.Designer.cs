namespace Projeto
{
    partial class frmfornecedor
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
            System.Windows.Forms.Label cd_fornecedorLabel;
            System.Windows.Forms.Label nm_fornecedorLabel;
            System.Windows.Forms.Label nm_enderecoLabel;
            System.Windows.Forms.Label cd_numeroLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label cd_ieLabel;
            System.Windows.Forms.Label de_emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfornecedor));
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label cd_cnpjLabel;
            System.Windows.Forms.Label ds_telefoneLabel;
            this.cadastroDataSet = new Projeto.cadastroDataSet();
            this.tb_fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_fornecedorTableAdapter = new Projeto.cadastroDataSetTableAdapters.tb_fornecedorTableAdapter();
            this.tableAdapterManager = new Projeto.cadastroDataSetTableAdapters.TableAdapterManager();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.txtend = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.txtsg = new System.Windows.Forms.TextBox();
            this.txtie = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
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
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.txtcnpj = new System.Windows.Forms.MaskedTextBox();
            this.txttell = new System.Windows.Forms.MaskedTextBox();
            cd_fornecedorLabel = new System.Windows.Forms.Label();
            nm_fornecedorLabel = new System.Windows.Forms.Label();
            nm_enderecoLabel = new System.Windows.Forms.Label();
            cd_numeroLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_ieLabel = new System.Windows.Forms.Label();
            de_emailLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            cd_cnpjLabel = new System.Windows.Forms.Label();
            ds_telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_fornecedorLabel
            // 
            cd_fornecedorLabel.AutoSize = true;
            cd_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_fornecedorLabel.Location = new System.Drawing.Point(330, 10);
            cd_fornecedorLabel.Name = "cd_fornecedorLabel";
            cd_fornecedorLabel.Size = new System.Drawing.Size(59, 20);
            cd_fornecedorLabel.TabIndex = 1;
            cd_fornecedorLabel.Text = "Codigo";
            cd_fornecedorLabel.Click += new System.EventHandler(this.cd_fornecedorLabel_Click);
            // 
            // nm_fornecedorLabel
            // 
            nm_fornecedorLabel.AutoSize = true;
            nm_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_fornecedorLabel.Location = new System.Drawing.Point(338, 36);
            nm_fornecedorLabel.Name = "nm_fornecedorLabel";
            nm_fornecedorLabel.Size = new System.Drawing.Size(51, 20);
            nm_fornecedorLabel.TabIndex = 3;
            nm_fornecedorLabel.Text = "Nome";
            // 
            // nm_enderecoLabel
            // 
            nm_enderecoLabel.AutoSize = true;
            nm_enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_enderecoLabel.Location = new System.Drawing.Point(311, 62);
            nm_enderecoLabel.Name = "nm_enderecoLabel";
            nm_enderecoLabel.Size = new System.Drawing.Size(78, 20);
            nm_enderecoLabel.TabIndex = 5;
            nm_enderecoLabel.Text = "Endereco";
            // 
            // cd_numeroLabel
            // 
            cd_numeroLabel.AutoSize = true;
            cd_numeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_numeroLabel.Location = new System.Drawing.Point(364, 88);
            cd_numeroLabel.Name = "cd_numeroLabel";
            cd_numeroLabel.Size = new System.Drawing.Size(25, 20);
            cd_numeroLabel.TabIndex = 7;
            cd_numeroLabel.Text = "N°";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_bairroLabel.Location = new System.Drawing.Point(338, 114);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(51, 20);
            nm_bairroLabel.TabIndex = 9;
            nm_bairroLabel.Text = "Bairro";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_cidadeLabel.Location = new System.Drawing.Point(330, 140);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(59, 20);
            nm_cidadeLabel.TabIndex = 11;
            nm_cidadeLabel.Text = "Cidade";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_estadoLabel.Location = new System.Drawing.Point(345, 166);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(44, 20);
            sg_estadoLabel.TabIndex = 13;
            sg_estadoLabel.Text = "Sigla";
            // 
            // cd_ieLabel
            // 
            cd_ieLabel.AutoSize = true;
            cd_ieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_ieLabel.Location = new System.Drawing.Point(249, 244);
            cd_ieLabel.Name = "cd_ieLabel";
            cd_ieLabel.Size = new System.Drawing.Size(140, 20);
            cd_ieLabel.TabIndex = 19;
            cd_ieLabel.Text = "Inscrição Estadual";
            // 
            // de_emailLabel
            // 
            de_emailLabel.AutoSize = true;
            de_emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            de_emailLabel.Location = new System.Drawing.Point(341, 296);
            de_emailLabel.Name = "de_emailLabel";
            de_emailLabel.Size = new System.Drawing.Size(48, 20);
            de_emailLabel.TabIndex = 23;
            de_emailLabel.Text = "Email";
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "cadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_fornecedorBindingSource
            // 
            this.tb_fornecedorBindingSource.DataMember = "tb_fornecedor";
            this.tb_fornecedorBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tb_fornecedorTableAdapter
            // 
            this.tb_fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = null;
            this.tableAdapterManager.tb_fornecedorTableAdapter = this.tb_fornecedorTableAdapter;
            this.tableAdapterManager.tb_produtoTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto.cadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtcod
            // 
            this.txtcod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_fornecedor", true));
            this.txtcod.Enabled = false;
            this.txtcod.Location = new System.Drawing.Point(395, 12);
            this.txtcod.MaxLength = 11;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 20);
            this.txtcod.TabIndex = 2;
            // 
            // txtnm
            // 
            this.txtnm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_fornecedor", true));
            this.txtnm.Enabled = false;
            this.txtnm.Location = new System.Drawing.Point(395, 38);
            this.txtnm.MaxLength = 50;
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(100, 20);
            this.txtnm.TabIndex = 4;
            // 
            // txtend
            // 
            this.txtend.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_endereco", true));
            this.txtend.Enabled = false;
            this.txtend.Location = new System.Drawing.Point(395, 64);
            this.txtend.MaxLength = 50;
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(100, 20);
            this.txtend.TabIndex = 6;
            // 
            // txtN
            // 
            this.txtN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_numero", true));
            this.txtN.Enabled = false;
            this.txtN.Location = new System.Drawing.Point(395, 90);
            this.txtN.MaxLength = 5;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 8;
            // 
            // txtbairro
            // 
            this.txtbairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_bairro", true));
            this.txtbairro.Enabled = false;
            this.txtbairro.Location = new System.Drawing.Point(395, 116);
            this.txtbairro.MaxLength = 30;
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(100, 20);
            this.txtbairro.TabIndex = 10;
            // 
            // txtcid
            // 
            this.txtcid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_cidade", true));
            this.txtcid.Enabled = false;
            this.txtcid.Location = new System.Drawing.Point(395, 142);
            this.txtcid.MaxLength = 30;
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(100, 20);
            this.txtcid.TabIndex = 12;
            // 
            // txtsg
            // 
            this.txtsg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "sg_estado", true));
            this.txtsg.Enabled = false;
            this.txtsg.Location = new System.Drawing.Point(395, 168);
            this.txtsg.MaxLength = 2;
            this.txtsg.Name = "txtsg";
            this.txtsg.Size = new System.Drawing.Size(100, 20);
            this.txtsg.TabIndex = 14;
            // 
            // txtie
            // 
            this.txtie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_ie", true));
            this.txtie.Enabled = false;
            this.txtie.Location = new System.Drawing.Point(395, 246);
            this.txtie.MaxLength = 15;
            this.txtie.Name = "txtie";
            this.txtie.Size = new System.Drawing.Size(100, 20);
            this.txtie.TabIndex = 20;
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "de_email", true));
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(395, 298);
            this.txtemail.MaxLength = 100;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 24;
            // 
            // bt_sair
            // 
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.Location = new System.Drawing.Point(647, 448);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(89, 30);
            this.bt_sair.TabIndex = 34;
            this.bt_sair.Text = "sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluir.Location = new System.Drawing.Point(647, 371);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(89, 30);
            this.bt_excluir.TabIndex = 33;
            this.bt_excluir.Text = "excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_imprimir.Location = new System.Drawing.Point(484, 448);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(89, 30);
            this.bt_imprimir.TabIndex = 32;
            this.bt_imprimir.Text = "imprimir";
            this.bt_imprimir.UseVisualStyleBackColor = true;
            this.bt_imprimir.Click += new System.EventHandler(this.bt_imprimir_Click);
            // 
            // bt_alterar
            // 
            this.bt_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alterar.Location = new System.Drawing.Point(484, 370);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(89, 30);
            this.bt_alterar.TabIndex = 31;
            this.bt_alterar.Text = "alterar";
            this.bt_alterar.UseVisualStyleBackColor = true;
            this.bt_alterar.Click += new System.EventHandler(this.bt_alterar_Click);
            // 
            // bt_pesquisa
            // 
            this.bt_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisa.Location = new System.Drawing.Point(340, 448);
            this.bt_pesquisa.Name = "bt_pesquisa";
            this.bt_pesquisa.Size = new System.Drawing.Size(89, 30);
            this.bt_pesquisa.TabIndex = 30;
            this.bt_pesquisa.Text = "pesquisar";
            this.bt_pesquisa.UseVisualStyleBackColor = true;
            this.bt_pesquisa.Click += new System.EventHandler(this.bt_pesquisa_Click);
            // 
            // bt_novo
            // 
            this.bt_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_novo.Location = new System.Drawing.Point(340, 370);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(89, 30);
            this.bt_novo.TabIndex = 29;
            this.bt_novo.Text = "novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Enabled = false;
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Location = new System.Drawing.Point(199, 448);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(89, 30);
            this.bt_cancelar.TabIndex = 28;
            this.bt_cancelar.Text = "cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_proximo
            // 
            this.bt_proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_proximo.Location = new System.Drawing.Point(199, 371);
            this.bt_proximo.Name = "bt_proximo";
            this.bt_proximo.Size = new System.Drawing.Size(89, 30);
            this.bt_proximo.TabIndex = 27;
            this.bt_proximo.Text = "próximo";
            this.bt_proximo.UseVisualStyleBackColor = true;
            this.bt_proximo.Click += new System.EventHandler(this.bt_proximo_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Enabled = false;
            this.bt_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar.Location = new System.Drawing.Point(76, 448);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(89, 30);
            this.bt_salvar.TabIndex = 26;
            this.bt_salvar.Text = "salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_anterior
            // 
            this.bt_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_anterior.Location = new System.Drawing.Point(76, 370);
            this.bt_anterior.Name = "bt_anterior";
            this.bt_anterior.Size = new System.Drawing.Size(89, 30);
            this.bt_anterior.TabIndex = 25;
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
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cepLabel.Location = new System.Drawing.Point(344, 218);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(45, 20);
            cd_cepLabel.TabIndex = 34;
            cd_cepLabel.Text = "CEP:";
            // 
            // txtcep
            // 
            this.txtcep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_cep", true));
            this.txtcep.Enabled = false;
            this.txtcep.Location = new System.Drawing.Point(395, 220);
            this.txtcep.Mask = "00000-000";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(100, 20);
            this.txtcep.TabIndex = 35;
            // 
            // cd_cnpjLabel
            // 
            cd_cnpjLabel.AutoSize = true;
            cd_cnpjLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cnpjLabel.Location = new System.Drawing.Point(340, 192);
            cd_cnpjLabel.Name = "cd_cnpjLabel";
            cd_cnpjLabel.Size = new System.Drawing.Size(49, 20);
            cd_cnpjLabel.TabIndex = 35;
            cd_cnpjLabel.Text = "CNPJ";
            // 
            // txtcnpj
            // 
            this.txtcnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_cnpj", true));
            this.txtcnpj.Enabled = false;
            this.txtcnpj.Location = new System.Drawing.Point(395, 194);
            this.txtcnpj.Mask = "00,000,000/0000,00";
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.Size = new System.Drawing.Size(100, 20);
            this.txtcnpj.TabIndex = 36;
            // 
            // ds_telefoneLabel
            // 
            ds_telefoneLabel.AutoSize = true;
            ds_telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_telefoneLabel.Location = new System.Drawing.Point(325, 273);
            ds_telefoneLabel.Name = "ds_telefoneLabel";
            ds_telefoneLabel.Size = new System.Drawing.Size(64, 17);
            ds_telefoneLabel.TabIndex = 36;
            ds_telefoneLabel.Text = "Telefone";
            // 
            // txttell
            // 
            this.txttell.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "ds_telefone", true));
            this.txttell.Enabled = false;
            this.txttell.Location = new System.Drawing.Point(395, 272);
            this.txttell.Mask = "(00)00000-0000";
            this.txttell.Name = "txttell";
            this.txttell.Size = new System.Drawing.Size(100, 20);
            this.txttell.TabIndex = 37;
            // 
            // frmfornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 498);
            this.ControlBox = false;
            this.Controls.Add(ds_telefoneLabel);
            this.Controls.Add(this.txttell);
            this.Controls.Add(cd_cnpjLabel);
            this.Controls.Add(this.txtcnpj);
            this.Controls.Add(cd_cepLabel);
            this.Controls.Add(this.txtcep);
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
            this.Controls.Add(cd_fornecedorLabel);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(nm_fornecedorLabel);
            this.Controls.Add(this.txtnm);
            this.Controls.Add(nm_enderecoLabel);
            this.Controls.Add(this.txtend);
            this.Controls.Add(cd_numeroLabel);
            this.Controls.Add(this.txtN);
            this.Controls.Add(nm_bairroLabel);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(nm_cidadeLabel);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(sg_estadoLabel);
            this.Controls.Add(this.txtsg);
            this.Controls.Add(cd_ieLabel);
            this.Controls.Add(this.txtie);
            this.Controls.Add(de_emailLabel);
            this.Controls.Add(this.txtemail);
            this.Name = "frmfornecedor";
            this.Text = "frmfornecedor";
            this.Load += new System.EventHandler(this.frmfornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tb_fornecedorBindingSource;
        private cadastroDataSetTableAdapters.tb_fornecedorTableAdapter tb_fornecedorTableAdapter;
        private cadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.TextBox txtsg;
        private System.Windows.Forms.TextBox txtie;
        private System.Windows.Forms.TextBox txtemail;
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
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.MaskedTextBox txtcnpj;
        private System.Windows.Forms.MaskedTextBox txttell;
    }
}