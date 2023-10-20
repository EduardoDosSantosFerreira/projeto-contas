namespace Projeto
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label cd_cpfLabel;
            System.Windows.Forms.Label ds_telefoneLabel;
            this.bt_imprimir = new System.Windows.Forms.Button();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.bt_pesquisa = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_proximo = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_anterior = new System.Windows.Forms.Button();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.SourceCliente = new System.Windows.Forms.BindingSource(this.components);
            this.cadastro_Cliente = new Projeto.cadastroDataSet();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtend = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.bt_sair = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AdapterCliente = new Projeto.cadastroDataSetTableAdapters.tb_clienteTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tableAdapterManager = new Projeto.cadastroDataSetTableAdapters.TableAdapterManager();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txttell = new System.Windows.Forms.MaskedTextBox();
            cd_cepLabel = new System.Windows.Forms.Label();
            cd_cpfLabel = new System.Windows.Forms.Label();
            ds_telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SourceCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_imprimir.Location = new System.Drawing.Point(435, 556);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(89, 30);
            this.bt_imprimir.TabIndex = 25;
            this.bt_imprimir.Text = "imprimir";
            this.bt_imprimir.UseVisualStyleBackColor = true;
            this.bt_imprimir.Click += new System.EventHandler(this.bt_imprimir_Click);
            // 
            // bt_alterar
            // 
            this.bt_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alterar.Location = new System.Drawing.Point(435, 478);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(89, 30);
            this.bt_alterar.TabIndex = 24;
            this.bt_alterar.Text = "alterar";
            this.bt_alterar.UseVisualStyleBackColor = true;
            this.bt_alterar.Click += new System.EventHandler(this.bt_alterar_Click);
            // 
            // bt_pesquisa
            // 
            this.bt_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisa.Location = new System.Drawing.Point(291, 556);
            this.bt_pesquisa.Name = "bt_pesquisa";
            this.bt_pesquisa.Size = new System.Drawing.Size(89, 30);
            this.bt_pesquisa.TabIndex = 23;
            this.bt_pesquisa.Text = "pesquisar";
            this.bt_pesquisa.UseVisualStyleBackColor = true;
            this.bt_pesquisa.Click += new System.EventHandler(this.bt_pesquisa_Click);
            // 
            // bt_novo
            // 
            this.bt_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_novo.Location = new System.Drawing.Point(291, 478);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(89, 30);
            this.bt_novo.TabIndex = 22;
            this.bt_novo.Text = "novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Enabled = false;
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Location = new System.Drawing.Point(150, 556);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(89, 30);
            this.bt_cancelar.TabIndex = 21;
            this.bt_cancelar.Text = "cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_proximo
            // 
            this.bt_proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_proximo.Location = new System.Drawing.Point(150, 479);
            this.bt_proximo.Name = "bt_proximo";
            this.bt_proximo.Size = new System.Drawing.Size(89, 30);
            this.bt_proximo.TabIndex = 20;
            this.bt_proximo.Text = "próximo";
            this.bt_proximo.UseVisualStyleBackColor = true;
            this.bt_proximo.Click += new System.EventHandler(this.bt_proximo_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Enabled = false;
            this.bt_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar.Location = new System.Drawing.Point(27, 556);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(89, 30);
            this.bt_salvar.TabIndex = 19;
            this.bt_salvar.Text = "salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_anterior
            // 
            this.bt_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_anterior.Location = new System.Drawing.Point(27, 478);
            this.bt_anterior.Name = "bt_anterior";
            this.bt_anterior.Size = new System.Drawing.Size(89, 30);
            this.bt_anterior.TabIndex = 18;
            this.bt_anterior.Text = "anterior";
            this.bt_anterior.UseVisualStyleBackColor = true;
            this.bt_anterior.Click += new System.EventHandler(this.bt_anterior_Click);
            // 
            // txtnm
            // 
            this.txtnm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SourceCliente, "nm_cliente", true));
            this.txtnm.Enabled = false;
            this.txtnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnm.Location = new System.Drawing.Point(292, 64);
            this.txtnm.MaxLength = 50;
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(100, 26);
            this.txtnm.TabIndex = 26;
            // 
            // SourceCliente
            // 
            this.SourceCliente.DataMember = "tb_cliente";
            this.SourceCliente.DataSource = this.cadastro_Cliente;
            // 
            // cadastro_Cliente
            // 
            this.cadastro_Cliente.DataSetName = "cadastroDataSet";
            this.cadastro_Cliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtemail
            // 
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SourceCliente, "ds_email", true));
            this.txtemail.Enabled = false;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(291, 409);
            this.txtemail.MaxLength = 100;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 26);
            this.txtemail.TabIndex = 28;
            // 
            // txtrg
            // 
            this.txtrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SourceCliente, "cd_rg", true));
            this.txtrg.Enabled = false;
            this.txtrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrg.Location = new System.Drawing.Point(291, 340);
            this.txtrg.MaxLength = 15;
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(100, 26);
            this.txtrg.TabIndex = 29;
            // 
            // txtcod
            // 
            this.txtcod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SourceCliente, "cd_cliente", true));
            this.txtcod.Enabled = false;
            this.txtcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.Location = new System.Drawing.Point(292, 28);
            this.txtcod.MaxLength = 11;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 26);
            this.txtcod.TabIndex = 31;
            // 
            // txtend
            // 
            this.txtend.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SourceCliente, "nm_endereco", true));
            this.txtend.Enabled = false;
            this.txtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtend.Location = new System.Drawing.Point(292, 100);
            this.txtend.MaxLength = 50;
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(100, 26);
            this.txtend.TabIndex = 32;
            // 
            // txtN
            // 
            this.txtN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SourceCliente, "cd_numero", true));
            this.txtN.Enabled = false;
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(292, 136);
            this.txtN.MaxLength = 5;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 26);
            this.txtN.TabIndex = 33;
            // 
            // txtbairro
            // 
            this.txtbairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SourceCliente, "nm_bairro", true));
            this.txtbairro.Enabled = false;
            this.txtbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbairro.Location = new System.Drawing.Point(291, 172);
            this.txtbairro.MaxLength = 30;
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(100, 26);
            this.txtbairro.TabIndex = 34;
            // 
            // txtcidade
            // 
            this.txtcidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SourceCliente, "nm_cidade", true));
            this.txtcidade.Enabled = false;
            this.txtcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcidade.Location = new System.Drawing.Point(292, 208);
            this.txtcidade.MaxLength = 30;
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(100, 26);
            this.txtcidade.TabIndex = 35;
            // 
            // txtestado
            // 
            this.txtestado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SourceCliente, "sg_estado", true));
            this.txtestado.Enabled = false;
            this.txtestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestado.Location = new System.Drawing.Point(292, 244);
            this.txtestado.MaxLength = 2;
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(100, 26);
            this.txtestado.TabIndex = 36;
            // 
            // bt_sair
            // 
            this.bt_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.Location = new System.Drawing.Point(568, 556);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(89, 30);
            this.bt_sair.TabIndex = 39;
            this.bt_sair.Text = "sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excluir.Location = new System.Drawing.Point(568, 479);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(89, 30);
            this.bt_excluir.TabIndex = 38;
            this.bt_excluir.Text = "excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Bairro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "N°";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(215, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "Estado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(245, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "RG";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(227, 415);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 51;
            this.label12.Text = "Email";
            // 
            // AdapterCliente
            // 
            this.AdapterCliente.ClearBeforeFill = true;
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
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = this.AdapterCliente;
            this.tableAdapterManager.tb_fornecedorTableAdapter = null;
            this.tableAdapterManager.tb_produtoTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto.cadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cepLabel.Location = new System.Drawing.Point(230, 279);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(45, 20);
            cd_cepLabel.TabIndex = 51;
            cd_cepLabel.Text = "CEP:";
            // 
            // txtcep
            // 
            this.txtcep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SourceCliente, "cd_cep", true));
            this.txtcep.Enabled = false;
            this.txtcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcep.Location = new System.Drawing.Point(291, 276);
            this.txtcep.Mask = "00000-000";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(100, 26);
            this.txtcep.TabIndex = 52;
            // 
            // cd_cpfLabel
            // 
            cd_cpfLabel.AutoSize = true;
            cd_cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cpfLabel.Location = new System.Drawing.Point(231, 311);
            cd_cpfLabel.Name = "cd_cpfLabel";
            cd_cpfLabel.Size = new System.Drawing.Size(44, 20);
            cd_cpfLabel.TabIndex = 52;
            cd_cpfLabel.Text = "CPF:";
            // 
            // txtcpf
            // 
            this.txtcpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SourceCliente, "cd_cpf", true));
            this.txtcpf.Enabled = false;
            this.txtcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(291, 308);
            this.txtcpf.Mask = "000,000,000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(121, 26);
            this.txtcpf.TabIndex = 53;
            // 
            // ds_telefoneLabel
            // 
            ds_telefoneLabel.AutoSize = true;
            ds_telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_telefoneLabel.Location = new System.Drawing.Point(182, 378);
            ds_telefoneLabel.Name = "ds_telefoneLabel";
            ds_telefoneLabel.Size = new System.Drawing.Size(93, 20);
            ds_telefoneLabel.TabIndex = 53;
            ds_telefoneLabel.Text = "TELEFONE";
            // 
            // txttell
            // 
            this.txttell.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SourceCliente, "ds_telefone", true));
            this.txttell.Enabled = false;
            this.txttell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttell.Location = new System.Drawing.Point(292, 372);
            this.txttell.Mask = "(00)00000-0000";
            this.txttell.Name = "txttell";
            this.txttell.Size = new System.Drawing.Size(100, 26);
            this.txttell.TabIndex = 54;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 606);
            this.Controls.Add(ds_telefoneLabel);
            this.Controls.Add(this.txttell);
            this.Controls.Add(cd_cpfLabel);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(cd_cepLabel);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtend);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnm);
            this.Controls.Add(this.bt_imprimir);
            this.Controls.Add(this.bt_alterar);
            this.Controls.Add(this.bt_pesquisa);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_proximo);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.bt_anterior);
            this.Name = "frmCliente";
            this.Text = "frmcliente";
            this.Load += new System.EventHandler(this.frmcliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SourceCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_imprimir;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.Button bt_pesquisa;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_proximo;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_anterior;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private cadastroDataSet cadastro_Cliente;
        private System.Windows.Forms.BindingSource SourceCliente;
        private cadastroDataSetTableAdapters.tb_clienteTableAdapter AdapterCliente;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private cadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.MaskedTextBox txttell;
    }
}