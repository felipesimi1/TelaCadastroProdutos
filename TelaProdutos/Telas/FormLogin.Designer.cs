namespace TelaProdutos.Telas
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            imageList1 = new ImageList(components);
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(89, 50);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(191, 23);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "Usuário";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.White;
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Location = new Point(89, 94);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(191, 23);
            txtSenha.TabIndex = 3;
            txtSenha.Text = "Senha";
            txtSenha.Enter += txtSenha_Enter;
            txtSenha.Leave += txtSenha_Leave;
            // 
            // btnEntrar
            // 
            btnEntrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEntrar.FlatStyle = FlatStyle.Popup;
            btnEntrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntrar.ImageIndex = 0;
            btnEntrar.ImageList = imageList1;
            btnEntrar.Location = new Point(89, 140);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Padding = new Padding(4, 0, 0, 0);
            btnEntrar.Size = new Size(85, 30);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextAlign = ContentAlignment.MiddleRight;
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "verifica.png");
            imageList1.Images.SetKeyName(1, "erro.png");
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageKey = "erro.png";
            btnCancelar.ImageList = imageList1;
            btnCancelar.Location = new Point(195, 140);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(3, 0, 0, 0);
            btnCancelar.Size = new Size(85, 30);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(363, 217);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            TopMost = true;
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Button btnCancelar;
        private ImageList imageList1;
    }
}