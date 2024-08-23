namespace EventManager.Views.HomeAdmin
{
    partial class FrmHomeAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLocais = new System.Windows.Forms.Button();
            this.btnCidades = new System.Windows.Forms.Button();
            this.btnUfs = new System.Windows.Forms.Button();
            this.btnPaises = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTiposEvento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTiposEvento);
            this.panel1.Controls.Add(this.btnLocais);
            this.panel1.Controls.Add(this.btnCidades);
            this.panel1.Controls.Add(this.btnUfs);
            this.panel1.Controls.Add(this.btnPaises);
            this.panel1.Location = new System.Drawing.Point(198, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 332);
            this.panel1.TabIndex = 0;
            // 
            // btnLocais
            // 
            this.btnLocais.Location = new System.Drawing.Point(98, 101);
            this.btnLocais.Name = "btnLocais";
            this.btnLocais.Size = new System.Drawing.Size(209, 23);
            this.btnLocais.TabIndex = 3;
            this.btnLocais.Text = "Locais";
            this.btnLocais.UseVisualStyleBackColor = true;
            this.btnLocais.Click += new System.EventHandler(this.btnLocais_Click);
            // 
            // btnCidades
            // 
            this.btnCidades.Location = new System.Drawing.Point(98, 72);
            this.btnCidades.Name = "btnCidades";
            this.btnCidades.Size = new System.Drawing.Size(209, 23);
            this.btnCidades.TabIndex = 2;
            this.btnCidades.Text = "Cidades";
            this.btnCidades.UseVisualStyleBackColor = true;
            this.btnCidades.Click += new System.EventHandler(this.btnCidades_Click);
            // 
            // btnUfs
            // 
            this.btnUfs.Location = new System.Drawing.Point(98, 43);
            this.btnUfs.Name = "btnUfs";
            this.btnUfs.Size = new System.Drawing.Size(209, 23);
            this.btnUfs.TabIndex = 1;
            this.btnUfs.Text = "Ufs";
            this.btnUfs.UseVisualStyleBackColor = true;
            this.btnUfs.Click += new System.EventHandler(this.btnUfs_Click);
            // 
            // btnPaises
            // 
            this.btnPaises.Location = new System.Drawing.Point(98, 14);
            this.btnPaises.Name = "btnPaises";
            this.btnPaises.Size = new System.Drawing.Size(209, 23);
            this.btnPaises.TabIndex = 0;
            this.btnPaises.Text = "Paises";
            this.btnPaises.UseVisualStyleBackColor = true;
            this.btnPaises.Click += new System.EventHandler(this.btnPaises_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(198, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 88);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // btnTiposEvento
            // 
            this.btnTiposEvento.Location = new System.Drawing.Point(98, 130);
            this.btnTiposEvento.Name = "btnTiposEvento";
            this.btnTiposEvento.Size = new System.Drawing.Size(209, 23);
            this.btnTiposEvento.TabIndex = 4;
            this.btnTiposEvento.Text = "Tipos de Evento";
            this.btnTiposEvento.UseVisualStyleBackColor = true;
            this.btnTiposEvento.Click += new System.EventHandler(this.btnTiposEvento_Click);
            // 
            // FrmHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmHomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeAdmin";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPaises;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUfs;
        private System.Windows.Forms.Button btnCidades;
        private System.Windows.Forms.Button btnLocais;
        private System.Windows.Forms.Button btnTiposEvento;
    }
}