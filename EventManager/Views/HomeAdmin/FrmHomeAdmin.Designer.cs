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
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnAvaliacoes = new System.Windows.Forms.Button();
            this.btnSessoes = new System.Windows.Forms.Button();
            this.btnPessoas = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnTiposEvento = new System.Windows.Forms.Button();
            this.btnLocais = new System.Windows.Forms.Button();
            this.btnCidades = new System.Windows.Forms.Button();
            this.btnUfs = new System.Windows.Forms.Button();
            this.btnPaises = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnAvaliacoes);
            this.panel1.Controls.Add(this.btnSessoes);
            this.panel1.Controls.Add(this.btnPessoas);
            this.panel1.Controls.Add(this.btnEventos);
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
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(98, 275);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(209, 23);
            this.btnUsuarios.TabIndex = 10;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnAvaliacoes
            // 
            this.btnAvaliacoes.Location = new System.Drawing.Point(98, 246);
            this.btnAvaliacoes.Name = "btnAvaliacoes";
            this.btnAvaliacoes.Size = new System.Drawing.Size(209, 23);
            this.btnAvaliacoes.TabIndex = 9;
            this.btnAvaliacoes.Text = "Avaliações";
            this.btnAvaliacoes.UseVisualStyleBackColor = true;
            this.btnAvaliacoes.Click += new System.EventHandler(this.btnAvaliacoes_Click);
            // 
            // btnSessoes
            // 
            this.btnSessoes.Location = new System.Drawing.Point(98, 217);
            this.btnSessoes.Name = "btnSessoes";
            this.btnSessoes.Size = new System.Drawing.Size(209, 23);
            this.btnSessoes.TabIndex = 8;
            this.btnSessoes.Text = "Sessões";
            this.btnSessoes.UseVisualStyleBackColor = true;
            this.btnSessoes.Click += new System.EventHandler(this.btnSessoes_Click_1);
            // 
            // btnPessoas
            // 
            this.btnPessoas.Location = new System.Drawing.Point(98, 188);
            this.btnPessoas.Name = "btnPessoas";
            this.btnPessoas.Size = new System.Drawing.Size(209, 23);
            this.btnPessoas.TabIndex = 7;
            this.btnPessoas.Text = "Pessoas";
            this.btnPessoas.UseVisualStyleBackColor = true;
            this.btnPessoas.Click += new System.EventHandler(this.btnPessoas_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.Location = new System.Drawing.Point(98, 159);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(209, 23);
            this.btnEventos.TabIndex = 6;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.btnSessoes_Click);
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
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnPessoas;
        private System.Windows.Forms.Button btnSessoes;
        private System.Windows.Forms.Button btnAvaliacoes;
        private System.Windows.Forms.Button btnUsuarios;
    }
}