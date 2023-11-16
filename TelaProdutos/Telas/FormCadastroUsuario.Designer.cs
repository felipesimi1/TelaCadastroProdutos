namespace TelaProdutos.Telas
{
    partial class FormCadastroUsuario
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroUsuario));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnFiltrar = new Button();
            imageList1 = new ImageList(components);
            label4 = new Label();
            txtFCodUser = new TextBox();
            txtFNome = new TextBox();
            label5 = new Label();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            bindingSourceTabUsuarios = new BindingSource(components);
            label6 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtCodUser = new TextBox();
            txtNome = new TextBox();
            cbIdCargo = new ComboBox();
            label2 = new Label();
            Cargo = new Label();
            cbAdministrador = new CheckBox();
            cbCargo = new ComboBox();
            lista = new DataGridView();
            idUsuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            administradorDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            btnCancelar = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            btnExcluir = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceTabUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lista).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 421);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnFiltrar);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtFCodUser);
            tabPage1.Controls.Add(txtFNome);
            tabPage1.Controls.Add(label5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Filtro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltrar.ImageIndex = 2;
            btnFiltrar.ImageList = imageList1;
            btnFiltrar.Location = new Point(661, 63);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(4, 0, 2, 0);
            btnFiltrar.Size = new Size(96, 37);
            btnFiltrar.TabIndex = 15;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.TextAlign = ContentAlignment.MiddleRight;
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "adicionar.png");
            imageList1.Images.SetKeyName(1, "erro.png");
            imageList1.Images.SetKeyName(2, "filtro.png");
            imageList1.Images.SetKeyName(3, "lixo.png");
            imageList1.Images.SetKeyName(4, "procurar.png");
            imageList1.Images.SetKeyName(5, "registro.png");
            imageList1.Images.SetKeyName(6, "salve-.png");
            imageList1.Images.SetKeyName(7, "verifica.png");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 25);
            label4.Name = "label4";
            label4.Size = new Size(123, 17);
            label4.TabIndex = 11;
            label4.Text = "Código do Usuário:";
            // 
            // txtFCodUser
            // 
            txtFCodUser.BorderStyle = BorderStyle.FixedSingle;
            txtFCodUser.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFCodUser.Location = new Point(145, 20);
            txtFCodUser.Name = "txtFCodUser";
            txtFCodUser.Size = new Size(114, 22);
            txtFCodUser.TabIndex = 12;
            // 
            // txtFNome
            // 
            txtFNome.BorderStyle = BorderStyle.FixedSingle;
            txtFNome.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFNome.Location = new Point(368, 20);
            txtFNome.Name = "txtFNome";
            txtFNome.Size = new Size(389, 22);
            txtFNome.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(313, 25);
            label5.Name = "label5";
            label5.Size = new Size(47, 17);
            label5.TabIndex = 13;
            label5.Text = "Nome:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(lista);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dados";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCodUser);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(cbIdCargo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Cargo);
            groupBox1.Controls.Add(cbAdministrador);
            groupBox1.Controls.Add(cbCargo);
            groupBox1.Location = new Point(8, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 208);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.DataBindings.Add(new Binding("Text", bindingSourceTabUsuarios, "Email", true));
            txtEmail.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(157, 83);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(389, 22);
            txtEmail.TabIndex = 14;
            // 
            // bindingSourceTabUsuarios
            // 
            bindingSourceTabUsuarios.DataSource = typeof(Models.DataLayer.TabUsuario);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(108, 88);
            label6.Name = "label6";
            label6.Size = new Size(42, 17);
            label6.TabIndex = 13;
            label6.Text = "Email:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.DataBindings.Add(new Binding("Text", bindingSourceTabUsuarios, "Senha", true));
            textBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(157, 140);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(235, 22);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(123, 17);
            label1.TabIndex = 3;
            label1.Text = "Código do Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(104, 145);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 11;
            label3.Text = "Senha:";
            // 
            // txtCodUser
            // 
            txtCodUser.BorderStyle = BorderStyle.FixedSingle;
            txtCodUser.DataBindings.Add(new Binding("Text", bindingSourceTabUsuarios, "IdUsuario", true));
            txtCodUser.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodUser.Location = new Point(157, 27);
            txtCodUser.Name = "txtCodUser";
            txtCodUser.ReadOnly = true;
            txtCodUser.Size = new Size(114, 22);
            txtCodUser.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.DataBindings.Add(new Binding("Text", bindingSourceTabUsuarios, "Usuario", true));
            txtNome.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(157, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(389, 22);
            txtNome.TabIndex = 10;
            // 
            // cbIdCargo
            // 
            cbIdCargo.DataBindings.Add(new Binding("Text", bindingSourceTabUsuarios, "IdCargo", true));
            cbIdCargo.FlatStyle = FlatStyle.System;
            cbIdCargo.FormattingEnabled = true;
            cbIdCargo.Location = new Point(157, 111);
            cbIdCargo.Name = "cbIdCargo";
            cbIdCargo.Size = new Size(68, 23);
            cbIdCargo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(103, 60);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 9;
            label2.Text = "Nome:";
            // 
            // Cargo
            // 
            Cargo.AutoSize = true;
            Cargo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Cargo.Location = new Point(103, 117);
            Cargo.Name = "Cargo";
            Cargo.Size = new Size(47, 17);
            Cargo.TabIndex = 6;
            Cargo.Text = "Cargo:";
            // 
            // cbAdministrador
            // 
            cbAdministrador.AutoSize = true;
            cbAdministrador.CheckAlign = ContentAlignment.MiddleRight;
            cbAdministrador.DataBindings.Add(new Binding("CheckState", bindingSourceTabUsuarios, "Administrador", true));
            cbAdministrador.FlatStyle = FlatStyle.System;
            cbAdministrador.Location = new Point(419, 142);
            cbAdministrador.Name = "cbAdministrador";
            cbAdministrador.Size = new Size(111, 20);
            cbAdministrador.TabIndex = 8;
            cbAdministrador.Text = "Administrador:";
            cbAdministrador.UseVisualStyleBackColor = true;
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(232, 111);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(314, 23);
            cbCargo.TabIndex = 7;
            // 
            // lista
            // 
            lista.AllowUserToAddRows = false;
            lista.AllowUserToDeleteRows = false;
            lista.AutoGenerateColumns = false;
            lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lista.BackgroundColor = Color.White;
            lista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lista.Columns.AddRange(new DataGridViewColumn[] { idUsuarioDataGridViewTextBoxColumn, usuarioDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, administradorDataGridViewCheckBoxColumn });
            lista.DataSource = bindingSourceTabUsuarios;
            lista.Dock = DockStyle.Top;
            lista.Location = new Point(3, 3);
            lista.Name = "lista";
            lista.ReadOnly = true;
            lista.RowHeadersWidth = 20;
            lista.RowTemplate.Height = 25;
            lista.Size = new Size(786, 150);
            lista.TabIndex = 0;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            idUsuarioDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            idUsuarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // administradorDataGridViewCheckBoxColumn
            // 
            administradorDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            administradorDataGridViewCheckBoxColumn.DataPropertyName = "Administrador";
            administradorDataGridViewCheckBoxColumn.HeaderText = "Administrador";
            administradorDataGridViewCheckBoxColumn.Name = "administradorDataGridViewCheckBoxColumn";
            administradorDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 1;
            btnCancelar.ImageList = imageList1;
            btnCancelar.Location = new Point(692, 441);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(4, 0, 2, 0);
            btnCancelar.Size = new Size(96, 37);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 6;
            btnSalvar.ImageList = imageList1;
            btnSalvar.Location = new Point(386, 441);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Padding = new Padding(4, 0, 2, 0);
            btnSalvar.Size = new Size(96, 37);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 0;
            btnNovo.ImageList = imageList1;
            btnNovo.Location = new Point(488, 441);
            btnNovo.Name = "btnNovo";
            btnNovo.Padding = new Padding(4, 0, 2, 0);
            btnNovo.Size = new Size(96, 37);
            btnNovo.TabIndex = 11;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 3;
            btnExcluir.ImageList = imageList1;
            btnExcluir.Location = new Point(590, 441);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(4, 0, 2, 0);
            btnExcluir.Size = new Size(96, 37);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FormCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCadastroUsuario";
            Text = "Usuários";
            Load += FormCadastroUsuario_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceTabUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)lista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView lista;
        private BindingSource bindingSourceTabUsuarios;
        private TextBox txtCodUser;
        private Label label1;
        private ComboBox cbCargo;
        private Label Cargo;
        private ComboBox cbIdCargo;
        private CheckBox cbAdministrador;
        private Button btnCancelar;
        private Button btnSalvar;
        private ImageList imageList1;
        private Button btnNovo;
        private Button btnExcluir;
        private TextBox txtNome;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox txtFCodUser;
        private TextBox txtFNome;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnFiltrar;
        private TextBox txtEmail;
        private Label label6;
        private DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn administradorDataGridViewCheckBoxColumn;
    }
}