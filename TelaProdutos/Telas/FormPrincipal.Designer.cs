namespace TelaProdutos.Telas
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menu = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            menuProdutos = new ToolStripMenuItem();
            grupoToolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1181, 24);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuProdutos, grupoToolStripMenuItem1 });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // menuProdutos
            // 
            menuProdutos.Name = "menuProdutos";
            menuProdutos.Size = new Size(180, 22);
            menuProdutos.Text = "Produtos";
            menuProdutos.Click += menuProdutos_Click;
            // 
            // grupoToolStripMenuItem1
            // 
            grupoToolStripMenuItem1.Name = "grupoToolStripMenuItem1";
            grupoToolStripMenuItem1.Size = new Size(180, 22);
            grupoToolStripMenuItem1.Text = "Grupo / Sub-Grupo";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 21, 23);
            ClientSize = new Size(1181, 737);
            Controls.Add(menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu;
            Name = "FormPrincipal";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Principal";
            Load += FormPrincipal_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem menuProdutos;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem grupoToolStripMenuItem1;
    }
}