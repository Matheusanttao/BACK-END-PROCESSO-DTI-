namespace TestePratico
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastro.Location = new System.Drawing.Point(199, 169);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(333, 90);
            this.BtnCadastro.TabIndex = 0;
            this.BtnCadastro.Text = "CADASTRO";
            this.BtnCadastro.UseVisualStyleBackColor = true;
            this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListar.Location = new System.Drawing.Point(199, 321);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(333, 90);
            this.BtnListar.TabIndex = 1;
            this.BtnListar.Text = "LISTAR";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(512, 480);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(123, 62);
            this.BtnSair.TabIndex = 2;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.Location = new System.Drawing.Point(155, 42);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(416, 58);
            this.LabelTitulo.TabIndex = 3;
            this.LabelTitulo.Text = "SEJA BEM VINDO!";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 647);
            this.Controls.Add(this.LabelTitulo);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.BtnCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LabelTitulo;
    }
}

