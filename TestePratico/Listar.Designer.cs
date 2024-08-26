namespace TestePratico
{
    partial class Listar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listar));
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.DgvParte1 = new System.Windows.Forms.DataGridView();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvParte2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvParte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvParte2)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.Location = new System.Drawing.Point(403, 30);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(294, 58);
            this.LabelTitulo.TabIndex = 13;
            this.LabelTitulo.Text = "LISTANDO...";
            // 
            // DgvParte1
            // 
            this.DgvParte1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvParte1.Location = new System.Drawing.Point(160, 213);
            this.DgvParte1.Name = "DgvParte1";
            this.DgvParte1.RowHeadersWidth = 51;
            this.DgvParte1.RowTemplate.Height = 24;
            this.DgvParte1.Size = new System.Drawing.Size(742, 416);
            this.DgvParte1.TabIndex = 16;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(386, 971);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(281, 82);
            this.BtnVoltar.TabIndex = 17;
            this.BtnVoltar.Text = "VOLTAR";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "MÉDIA DE CADA ALUNO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 678);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 38);
            this.label2.TabIndex = 20;
            this.label2.Text = "MÉDIA GERAL";
            // 
            // DgvParte2
            // 
            this.DgvParte2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvParte2.Location = new System.Drawing.Point(160, 719);
            this.DgvParte2.Name = "DgvParte2";
            this.DgvParte2.RowHeadersWidth = 51;
            this.DgvParte2.RowTemplate.Height = 24;
            this.DgvParte2.Size = new System.Drawing.Size(742, 225);
            this.DgvParte2.TabIndex = 19;
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 1112);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvParte2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.DgvParte1);
            this.Controls.Add(this.LabelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Listar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTANDO";
            ((System.ComponentModel.ISupportInitialize)(this.DgvParte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvParte2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.DataGridView DgvParte1;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvParte2;
    }
}