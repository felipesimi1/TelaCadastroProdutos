namespace TelaProdutos
{
    partial class FormCadastroProduto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            imageList1 = new ImageList(components);
            btnExcluir = new Button();
            btnNovo = new Button();
            btnSalvar = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnFiltrar = new Button();
            groupBox5 = new GroupBox();
            txtFCodSubs = new TextBox();
            label21 = new Label();
            txtFCodFabrica = new TextBox();
            label22 = new Label();
            txtFLocalizacao2 = new TextBox();
            label23 = new Label();
            txtFLocalizacao = new TextBox();
            label24 = new Label();
            txtFModelo = new TextBox();
            label25 = new Label();
            groupBox6 = new GroupBox();
            txtFDescrição = new TextBox();
            label28 = new Label();
            txtFCodProd = new TextBox();
            label29 = new Label();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            cbReferência = new ComboBox();
            tabEstoqueReferênciumBindingSource = new BindingSource(components);
            txtDataCadastro = new TextBox();
            tabEstoqueBindingSource = new BindingSource(components);
            txtUsuario = new TextBox();
            label20 = new Label();
            label19 = new Label();
            groupBox4 = new GroupBox();
            cbProdFalta = new CheckBox();
            cbProdObs = new CheckBox();
            groupBox3 = new GroupBox();
            txtTempMin = new TextBox();
            label16 = new Label();
            txtTempMax = new TextBox();
            label17 = new Label();
            txtComprimento = new TextBox();
            label18 = new Label();
            txtPeso2 = new TextBox();
            label15 = new Label();
            txtLargura = new TextBox();
            label14 = new Label();
            txtAltura = new TextBox();
            label13 = new Label();
            txtVolume = new TextBox();
            label12 = new Label();
            txtPeso = new TextBox();
            label11 = new Label();
            txtCodSubs = new TextBox();
            label10 = new Label();
            txtCodFabrica = new TextBox();
            label9 = new Label();
            txtLocalizacao2 = new TextBox();
            label8 = new Label();
            txtLocalizacao = new TextBox();
            label7 = new Label();
            txtModelo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            cbGrupo = new ComboBox();
            label4 = new Label();
            cbIdGrupo = new ComboBox();
            groupBox1 = new GroupBox();
            cbIdSubGrupo = new ComboBox();
            txtDescrição = new TextBox();
            label3 = new Label();
            txtCodTab = new TextBox();
            txtCodProd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lista = new DataGridView();
            idItemDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriçãoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            grupoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            referênciaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tabEstoqueGrupoBindingSource = new BindingSource(components);
            btnCancelar = new Button();
            bindingSource1 = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabEstoqueReferênciumBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabEstoqueBindingSource).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabEstoqueGrupoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "salve-.png");
            imageList1.Images.SetKeyName(1, "adicionar.png");
            imageList1.Images.SetKeyName(2, "erro.png");
            imageList1.Images.SetKeyName(3, "lixo.png");
            imageList1.Images.SetKeyName(4, "procurar.png");
            imageList1.Images.SetKeyName(5, "registro.png");
            imageList1.Images.SetKeyName(6, "filtro.png");
            imageList1.Images.SetKeyName(7, "filtro.png");
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 3;
            btnExcluir.ImageList = imageList1;
            btnExcluir.Location = new Point(898, 547);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(4, 0, 2, 0);
            btnExcluir.Size = new Size(96, 37);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 1;
            btnNovo.ImageList = imageList1;
            btnNovo.Location = new Point(796, 547);
            btnNovo.Name = "btnNovo";
            btnNovo.Padding = new Padding(4, 0, 2, 0);
            btnNovo.Size = new Size(96, 37);
            btnNovo.TabIndex = 4;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 0;
            btnSalvar.ImageList = imageList1;
            btnSalvar.Location = new Point(694, 547);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(4, 0, 2, 0);
            btnSalvar.Size = new Size(96, 37);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1103, 541);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(btnFiltrar);
            tabPage1.Controls.Add(groupBox5);
            tabPage1.Controls.Add(groupBox6);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1095, 513);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Filtro";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltrar.ImageIndex = 7;
            btnFiltrar.ImageList = imageList1;
            btnFiltrar.Location = new Point(933, 209);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(4, 0, 2, 0);
            btnFiltrar.Size = new Size(96, 37);
            btnFiltrar.TabIndex = 9;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.TextAlign = ContentAlignment.MiddleRight;
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtFCodSubs);
            groupBox5.Controls.Add(label21);
            groupBox5.Controls.Add(txtFCodFabrica);
            groupBox5.Controls.Add(label22);
            groupBox5.Controls.Add(txtFLocalizacao2);
            groupBox5.Controls.Add(label23);
            groupBox5.Controls.Add(txtFLocalizacao);
            groupBox5.Controls.Add(label24);
            groupBox5.Controls.Add(txtFModelo);
            groupBox5.Controls.Add(label25);
            groupBox5.Location = new Point(55, 110);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(974, 93);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            // 
            // txtFCodSubs
            // 
            txtFCodSubs.BorderStyle = BorderStyle.FixedSingle;
            txtFCodSubs.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFCodSubs.Location = new Point(135, 57);
            txtFCodSubs.Name = "txtFCodSubs";
            txtFCodSubs.Size = new Size(114, 22);
            txtFCodSubs.TabIndex = 15;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(62, 62);
            label21.Name = "label21";
            label21.Size = new Size(67, 17);
            label21.TabIndex = 14;
            label21.Text = "Cód Subs:";
            // 
            // txtFCodFabrica
            // 
            txtFCodFabrica.BorderStyle = BorderStyle.FixedSingle;
            txtFCodFabrica.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFCodFabrica.Location = new Point(348, 57);
            txtFCodFabrica.Name = "txtFCodFabrica";
            txtFCodFabrica.Size = new Size(114, 22);
            txtFCodFabrica.TabIndex = 13;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(261, 62);
            label22.Name = "label22";
            label22.Size = new Size(81, 17);
            label22.TabIndex = 12;
            label22.Text = "Cód Fábrica:";
            // 
            // txtFLocalizacao2
            // 
            txtFLocalizacao2.BorderStyle = BorderStyle.FixedSingle;
            txtFLocalizacao2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFLocalizacao2.Location = new Point(776, 29);
            txtFLocalizacao2.Name = "txtFLocalizacao2";
            txtFLocalizacao2.Size = new Size(112, 22);
            txtFLocalizacao2.TabIndex = 11;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(681, 34);
            label23.Name = "label23";
            label23.Size = new Size(89, 17);
            label23.TabIndex = 10;
            label23.Text = "Localização 2:";
            // 
            // txtFLocalizacao
            // 
            txtFLocalizacao.BorderStyle = BorderStyle.FixedSingle;
            txtFLocalizacao.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFLocalizacao.Location = new Point(563, 29);
            txtFLocalizacao.Name = "txtFLocalizacao";
            txtFLocalizacao.Size = new Size(114, 22);
            txtFLocalizacao.TabIndex = 9;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(479, 34);
            label24.Name = "label24";
            label24.Size = new Size(78, 17);
            label24.TabIndex = 8;
            label24.Text = "Localização:";
            // 
            // txtFModelo
            // 
            txtFModelo.BorderStyle = BorderStyle.FixedSingle;
            txtFModelo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFModelo.Location = new Point(137, 29);
            txtFModelo.Name = "txtFModelo";
            txtFModelo.Size = new Size(325, 22);
            txtFModelo.TabIndex = 7;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(74, 34);
            label25.Name = "label25";
            label25.Size = new Size(57, 17);
            label25.TabIndex = 6;
            label25.Text = "Modelo:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtFDescrição);
            groupBox6.Controls.Add(label28);
            groupBox6.Controls.Add(txtFCodProd);
            groupBox6.Controls.Add(label29);
            groupBox6.Location = new Point(55, 30);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(974, 74);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            // 
            // txtFDescrição
            // 
            txtFDescrição.BorderStyle = BorderStyle.FixedSingle;
            txtFDescrição.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFDescrição.Location = new Point(335, 16);
            txtFDescrição.Multiline = true;
            txtFDescrição.Name = "txtFDescrição";
            txtFDescrição.Size = new Size(168, 50);
            txtFDescrição.TabIndex = 5;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(261, 21);
            label28.Name = "label28";
            label28.Size = new Size(68, 17);
            label28.TabIndex = 4;
            label28.Text = "Descrição:";
            // 
            // txtFCodProd
            // 
            txtFCodProd.BorderStyle = BorderStyle.FixedSingle;
            txtFCodProd.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFCodProd.Location = new Point(137, 16);
            txtFCodProd.Name = "txtFCodProd";
            txtFCodProd.Size = new Size(114, 22);
            txtFCodProd.TabIndex = 2;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label29.Location = new Point(6, 21);
            label29.Name = "label29";
            label29.Size = new Size(125, 17);
            label29.TabIndex = 0;
            label29.Text = "Código do Produto:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(lista);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1095, 513);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dados";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbIdSubGrupo);
            groupBox2.Controls.Add(cbReferência);
            groupBox2.Controls.Add(txtDataCadastro);
            groupBox2.Controls.Add(txtUsuario);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(txtVolume);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtPeso);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtCodSubs);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtCodFabrica);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtLocalizacao2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtLocalizacao);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtModelo);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cbGrupo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cbIdGrupo);
            groupBox2.Location = new Point(39, 249);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1018, 247);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // cbReferência
            // 
            cbReferência.DataBindings.Add(new Binding("Text", tabEstoqueReferênciumBindingSource, "Referência", true));
            cbReferência.FormattingEnabled = true;
            cbReferência.Location = new Point(178, 54);
            cbReferência.Name = "cbReferência";
            cbReferência.Size = new Size(288, 23);
            cbReferência.TabIndex = 27;
            cbReferência.SelectedValueChanged += cbReferência_SelectedValueChanged;
            // 
            // tabEstoqueReferênciumBindingSource
            // 
            tabEstoqueReferênciumBindingSource.DataSource = typeof(Models.DataLayer.TabEstoqueReferêncium);
            // 
            // txtDataCadastro
            // 
            txtDataCadastro.BackColor = Color.White;
            txtDataCadastro.BorderStyle = BorderStyle.None;
            txtDataCadastro.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "DataCadastro", true));
            txtDataCadastro.Location = new Point(138, 226);
            txtDataCadastro.Name = "txtDataCadastro";
            txtDataCadastro.Size = new Size(100, 16);
            txtDataCadastro.TabIndex = 26;
            // 
            // tabEstoqueBindingSource
            // 
            tabEstoqueBindingSource.DataSource = typeof(Models.DataLayer.TabEstoque);
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "IdUsuário", true));
            txtUsuario.Location = new Point(298, 226);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 16);
            txtUsuario.TabIndex = 25;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(249, 227);
            label20.Name = "label20";
            label20.Size = new Size(50, 15);
            label20.TabIndex = 23;
            label20.Text = "Usuário:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(57, 226);
            label19.Name = "label19";
            label19.Size = new Size(75, 15);
            label19.TabIndex = 22;
            label19.Text = "Dt. Cadastro:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbProdFalta);
            groupBox4.Controls.Add(cbProdObs);
            groupBox4.Location = new Point(486, 141);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(511, 44);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            // 
            // cbProdFalta
            // 
            cbProdFalta.AutoSize = true;
            cbProdFalta.CheckAlign = ContentAlignment.MiddleRight;
            cbProdFalta.DataBindings.Add(new Binding("CheckState", tabEstoqueBindingSource, "BitProdutoEmFalta", true));
            cbProdFalta.FlatStyle = FlatStyle.System;
            cbProdFalta.Location = new Point(298, 16);
            cbProdFalta.Name = "cbProdFalta";
            cbProdFalta.Size = new Size(126, 20);
            cbProdFalta.TabIndex = 1;
            cbProdFalta.Text = "Produto em Falta:";
            cbProdFalta.UseVisualStyleBackColor = true;
            // 
            // cbProdObs
            // 
            cbProdObs.AutoSize = true;
            cbProdObs.CheckAlign = ContentAlignment.MiddleRight;
            cbProdObs.DataBindings.Add(new Binding("CheckState", tabEstoqueBindingSource, "BitProdutoObsoleto", true));
            cbProdObs.FlatStyle = FlatStyle.System;
            cbProdObs.Location = new Point(61, 16);
            cbProdObs.Name = "cbProdObs";
            cbProdObs.Size = new Size(129, 20);
            cbProdObs.TabIndex = 0;
            cbProdObs.Text = "Produto Obsoleto:";
            cbProdObs.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTempMin);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(txtTempMax);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(txtComprimento);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(txtPeso2);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(txtLargura);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(txtAltura);
            groupBox3.Controls.Add(label13);
            groupBox3.Location = new Point(486, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(511, 113);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cubagem";
            // 
            // txtTempMin
            // 
            txtTempMin.BorderStyle = BorderStyle.FixedSingle;
            txtTempMin.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "CurTemperaturaMinima", true));
            txtTempMin.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTempMin.Location = new Point(372, 78);
            txtTempMin.Name = "txtTempMin";
            txtTempMin.Size = new Size(114, 22);
            txtTempMin.TabIndex = 32;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(255, 83);
            label16.Name = "label16";
            label16.Size = new Size(111, 17);
            label16.TabIndex = 31;
            label16.Text = "Temperatura Min:";
            // 
            // txtTempMax
            // 
            txtTempMax.BorderStyle = BorderStyle.FixedSingle;
            txtTempMax.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "CurTemperaturaMaxima", true));
            txtTempMax.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTempMax.Location = new Point(372, 50);
            txtTempMax.Name = "txtTempMax";
            txtTempMax.Size = new Size(114, 22);
            txtTempMax.TabIndex = 30;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(252, 55);
            label17.Name = "label17";
            label17.Size = new Size(114, 17);
            label17.TabIndex = 29;
            label17.Text = "Temperatura Max:";
            // 
            // txtComprimento
            // 
            txtComprimento.BorderStyle = BorderStyle.FixedSingle;
            txtComprimento.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "CurComprimento", true));
            txtComprimento.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtComprimento.Location = new Point(372, 22);
            txtComprimento.Name = "txtComprimento";
            txtComprimento.Size = new Size(114, 22);
            txtComprimento.TabIndex = 28;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(275, 27);
            label18.Name = "label18";
            label18.Size = new Size(91, 17);
            label18.TabIndex = 27;
            label18.Text = "Comprimento:";
            // 
            // txtPeso2
            // 
            txtPeso2.BorderStyle = BorderStyle.FixedSingle;
            txtPeso2.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "Peso", true));
            txtPeso2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPeso2.Location = new Point(86, 78);
            txtPeso2.Name = "txtPeso2";
            txtPeso2.Size = new Size(134, 22);
            txtPeso2.TabIndex = 26;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(41, 83);
            label15.Name = "label15";
            label15.Size = new Size(39, 17);
            label15.TabIndex = 25;
            label15.Text = "Peso:";
            // 
            // txtLargura
            // 
            txtLargura.BorderStyle = BorderStyle.FixedSingle;
            txtLargura.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "Largura", true));
            txtLargura.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLargura.Location = new Point(86, 50);
            txtLargura.Name = "txtLargura";
            txtLargura.Size = new Size(134, 22);
            txtLargura.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(24, 55);
            label14.Name = "label14";
            label14.Size = new Size(56, 17);
            label14.TabIndex = 23;
            label14.Text = "Largura:";
            // 
            // txtAltura
            // 
            txtAltura.BorderStyle = BorderStyle.FixedSingle;
            txtAltura.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "Altura", true));
            txtAltura.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAltura.Location = new Point(86, 22);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(134, 22);
            txtAltura.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(35, 27);
            label13.Name = "label13";
            label13.Size = new Size(45, 17);
            label13.TabIndex = 21;
            label13.Text = "Altura:";
            // 
            // txtVolume
            // 
            txtVolume.BorderStyle = BorderStyle.FixedSingle;
            txtVolume.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "Volume", true));
            txtVolume.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtVolume.Location = new Point(354, 167);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(114, 22);
            txtVolume.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(294, 172);
            label12.Name = "label12";
            label12.Size = new Size(54, 17);
            label12.TabIndex = 18;
            label12.Text = "Volume:";
            // 
            // txtPeso
            // 
            txtPeso.BorderStyle = BorderStyle.FixedSingle;
            txtPeso.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "Peso", true));
            txtPeso.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPeso.Location = new Point(103, 167);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(135, 22);
            txtPeso.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(58, 172);
            label11.Name = "label11";
            label11.Size = new Size(39, 17);
            label11.TabIndex = 16;
            label11.Text = "Peso:";
            // 
            // txtCodSubs
            // 
            txtCodSubs.BorderStyle = BorderStyle.FixedSingle;
            txtCodSubs.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "CódigoVelho", true));
            txtCodSubs.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodSubs.Location = new Point(333, 139);
            txtCodSubs.Name = "txtCodSubs";
            txtCodSubs.Size = new Size(135, 22);
            txtCodSubs.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(260, 144);
            label10.Name = "label10";
            label10.Size = new Size(67, 17);
            label10.TabIndex = 14;
            label10.Text = "Cód Subs:";
            // 
            // txtCodFabrica
            // 
            txtCodFabrica.BorderStyle = BorderStyle.FixedSingle;
            txtCodFabrica.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "CódigoFábrica", true));
            txtCodFabrica.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodFabrica.Location = new Point(103, 139);
            txtCodFabrica.Name = "txtCodFabrica";
            txtCodFabrica.Size = new Size(135, 22);
            txtCodFabrica.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(16, 144);
            label9.Name = "label9";
            label9.Size = new Size(81, 17);
            label9.TabIndex = 12;
            label9.Text = "Cód Fábrica:";
            // 
            // txtLocalizacao2
            // 
            txtLocalizacao2.BorderStyle = BorderStyle.FixedSingle;
            txtLocalizacao2.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "Localização2", true));
            txtLocalizacao2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLocalizacao2.Location = new Point(354, 111);
            txtLocalizacao2.Name = "txtLocalizacao2";
            txtLocalizacao2.Size = new Size(112, 22);
            txtLocalizacao2.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(259, 116);
            label8.Name = "label8";
            label8.Size = new Size(89, 17);
            label8.TabIndex = 10;
            label8.Text = "Localização 2:";
            // 
            // txtLocalizacao
            // 
            txtLocalizacao.BorderStyle = BorderStyle.FixedSingle;
            txtLocalizacao.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "Localização", true));
            txtLocalizacao.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLocalizacao.Location = new Point(103, 111);
            txtLocalizacao.Name = "txtLocalizacao";
            txtLocalizacao.Size = new Size(135, 22);
            txtLocalizacao.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(19, 116);
            label7.Name = "label7";
            label7.Size = new Size(78, 17);
            label7.TabIndex = 8;
            label7.Text = "Localização:";
            // 
            // txtModelo
            // 
            txtModelo.BorderStyle = BorderStyle.FixedSingle;
            txtModelo.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "Modelo", true));
            txtModelo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtModelo.Location = new Point(103, 83);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(363, 22);
            txtModelo.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(40, 88);
            label6.Name = "label6";
            label6.Size = new Size(57, 17);
            label6.TabIndex = 6;
            label6.Text = "Modelo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(23, 60);
            label5.Name = "label5";
            label5.Size = new Size(74, 17);
            label5.TabIndex = 4;
            label5.Text = "Sub Grupo:";
            // 
            // cbGrupo
            // 
            cbGrupo.FormattingEnabled = true;
            cbGrupo.Location = new Point(178, 25);
            cbGrupo.Name = "cbGrupo";
            cbGrupo.Size = new Size(288, 23);
            cbGrupo.TabIndex = 2;
            cbGrupo.SelectedValueChanged += cbGrupo_SelectedValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(49, 31);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 1;
            label4.Text = "Grupo:";
            // 
            // cbIdGrupo
            // 
            cbIdGrupo.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "Grupo", true));
            cbIdGrupo.FlatStyle = FlatStyle.System;
            cbIdGrupo.FormattingEnabled = true;
            cbIdGrupo.Location = new Point(103, 25);
            cbIdGrupo.Name = "cbIdGrupo";
            cbIdGrupo.Size = new Size(68, 23);
            cbIdGrupo.TabIndex = 0;
            cbIdGrupo.SelectedValueChanged += cbIdGrupo_SelectedValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDescrição);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCodTab);
            groupBox1.Controls.Add(txtCodProd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 169);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1018, 74);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // cbIdSubGrupo
            // 
            cbIdSubGrupo.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "Referência", true));
            cbIdSubGrupo.FormattingEnabled = true;
            cbIdSubGrupo.Location = new Point(103, 54);
            cbIdSubGrupo.Name = "cbIdSubGrupo";
            cbIdSubGrupo.Size = new Size(68, 23);
            cbIdSubGrupo.TabIndex = 28;
            // 
            // txtDescrição
            // 
            txtDescrição.BorderStyle = BorderStyle.FixedSingle;
            txtDescrição.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "Descrição", true));
            txtDescrição.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescrição.Location = new Point(407, 15);
            txtDescrição.Multiline = true;
            txtDescrição.Name = "txtDescrição";
            txtDescrição.Size = new Size(431, 50);
            txtDescrição.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(333, 20);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 4;
            label3.Text = "Descrição:";
            // 
            // txtCodTab
            // 
            txtCodTab.BackColor = SystemColors.Control;
            txtCodTab.BorderStyle = BorderStyle.FixedSingle;
            txtCodTab.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "PkIntEstoque", true));
            txtCodTab.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodTab.Location = new Point(185, 43);
            txtCodTab.Name = "txtCodTab";
            txtCodTab.ReadOnly = true;
            txtCodTab.RightToLeft = RightToLeft.Yes;
            txtCodTab.Size = new Size(114, 22);
            txtCodTab.TabIndex = 3;
            txtCodTab.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCodProd
            // 
            txtCodProd.BorderStyle = BorderStyle.FixedSingle;
            txtCodProd.DataBindings.Add(new Binding("Text", tabEstoqueBindingSource, "IdItem", true));
            txtCodProd.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodProd.Location = new Point(185, 15);
            txtCodProd.Name = "txtCodProd";
            txtCodProd.Size = new Size(114, 22);
            txtCodProd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(64, 48);
            label2.Name = "label2";
            label2.Size = new Size(115, 17);
            label2.TabIndex = 1;
            label2.Text = "Código da Tabela:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 20);
            label1.Name = "label1";
            label1.Size = new Size(125, 17);
            label1.TabIndex = 0;
            label1.Text = "Código do Produto:";
            // 
            // lista
            // 
            lista.AllowUserToAddRows = false;
            lista.AllowUserToDeleteRows = false;
            lista.AllowUserToOrderColumns = true;
            lista.AutoGenerateColumns = false;
            lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lista.Columns.AddRange(new DataGridViewColumn[] { idItemDataGridViewTextBoxColumn, descriçãoDataGridViewTextBoxColumn, grupoDataGridViewTextBoxColumn, referênciaDataGridViewTextBoxColumn });
            lista.DataSource = tabEstoqueBindingSource;
            lista.Dock = DockStyle.Top;
            lista.Location = new Point(3, 3);
            lista.Name = "lista";
            lista.ReadOnly = true;
            lista.RowHeadersWidth = 25;
            lista.RowTemplate.Height = 25;
            lista.Size = new Size(1089, 150);
            lista.TabIndex = 8;
            lista.SelectionChanged += lista_SelectionChanged;
            // 
            // idItemDataGridViewTextBoxColumn
            // 
            idItemDataGridViewTextBoxColumn.DataPropertyName = "IdItem";
            idItemDataGridViewTextBoxColumn.HeaderText = "IdItem";
            idItemDataGridViewTextBoxColumn.Name = "idItemDataGridViewTextBoxColumn";
            idItemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriçãoDataGridViewTextBoxColumn
            // 
            descriçãoDataGridViewTextBoxColumn.DataPropertyName = "Descrição";
            descriçãoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            descriçãoDataGridViewTextBoxColumn.Name = "descriçãoDataGridViewTextBoxColumn";
            descriçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grupoDataGridViewTextBoxColumn
            // 
            grupoDataGridViewTextBoxColumn.DataPropertyName = "Grupo";
            grupoDataGridViewTextBoxColumn.HeaderText = "Grupo";
            grupoDataGridViewTextBoxColumn.Name = "grupoDataGridViewTextBoxColumn";
            grupoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referênciaDataGridViewTextBoxColumn
            // 
            referênciaDataGridViewTextBoxColumn.DataPropertyName = "Referência";
            referênciaDataGridViewTextBoxColumn.HeaderText = "Referência";
            referênciaDataGridViewTextBoxColumn.Name = "referênciaDataGridViewTextBoxColumn";
            referênciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabEstoqueGrupoBindingSource
            // 
            tabEstoqueGrupoBindingSource.DataSource = typeof(Models.DataLayer.TabEstoqueGrupo);
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 2;
            btnCancelar.ImageList = imageList1;
            btnCancelar.Location = new Point(1000, 547);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(4, 0, 2, 0);
            btnCancelar.Size = new Size(96, 37);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 597);
            Controls.Add(btnCancelar);
            Controls.Add(tabControl1);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Produto";
            Load += FormCadastroProduto_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabEstoqueReferênciumBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabEstoqueBindingSource).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lista).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabEstoqueGrupoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private Button btnExcluir;
        private Button btnNovo;
        private Button btnSalvar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private TextBox txtUsuario;
        private Label label20;
        private Label label19;
        private GroupBox groupBox4;
        private CheckBox cbProdFalta;
        private CheckBox cbProdObs;
        private GroupBox groupBox3;
        private TextBox txtTempMin;
        private Label label16;
        private TextBox txtTempMax;
        private Label label17;
        private TextBox txtComprimento;
        private Label label18;
        private TextBox txtPeso2;
        private Label label15;
        private TextBox txtLargura;
        private Label label14;
        private TextBox txtAltura;
        private Label label13;
        private TextBox txtVolume;
        private Label label12;
        private TextBox txtPeso;
        private Label label11;
        private TextBox txtCodSubs;
        private Label label10;
        private TextBox txtCodFabrica;
        private Label label9;
        private TextBox txtLocalizacao2;
        private Label label8;
        private TextBox txtLocalizacao;
        private Label label7;
        private TextBox txtModelo;
        private Label label6;
        private Label label5;
        private ComboBox cbGrupo;
        private Label label4;
        private ComboBox cbIdGrupo;
        private GroupBox groupBox1;
        private TextBox txtDescrição;
        private Label label3;
        private TextBox txtCodTab;
        private TextBox txtCodProd;
        private Label label2;
        private Label label1;
        private DataGridView lista;
        private Button btnFiltrar;
        private GroupBox groupBox5;
        private TextBox txtFCodSubs;
        private Label label21;
        private TextBox txtFCodFabrica;
        private Label label22;
        private TextBox txtFLocalizacao2;
        private Label label23;
        private TextBox txtFLocalizacao;
        private Label label24;
        private TextBox txtFModelo;
        private Label label25;
        private GroupBox groupBox6;
        private TextBox txtFDescrição;
        private Label label28;
        private TextBox txtFCodProd;
        private Label label29;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn tabEstoqueGrupoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tabEstoqueReferênciumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeGrupoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subGrupoDataGridViewTextBoxColumn;
        private BindingSource bindingSource1;
        private BindingSource tabEstoqueBindingSource;
        private DataGridViewTextBoxColumn idItemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriçãoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn grupoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn referênciaDataGridViewTextBoxColumn;
        private TextBox txtDataCadastro;
        internal BindingSource tabEstoqueReferênciumBindingSource;
        internal BindingSource tabEstoqueGrupoBindingSource;
        private ComboBox cbReferência;
        private ComboBox cbIdSubGrupo;
    }
}