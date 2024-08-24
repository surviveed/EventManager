namespace EventManager.Views.CrudAvaliacao
{
    partial class FrmAvaliacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAvaliacao));
            this.btnDeletar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnEditar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnAdicionar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            this.hopeGroupBox1 = new ReaLTaiizor.Controls.HopeGroupBox();
            this.txtComentario = new ReaLTaiizor.Controls.HopeRichTextBox();
            this.foxLabel4 = new ReaLTaiizor.Controls.FoxLabel();
            this.cbSessao = new ReaLTaiizor.Controls.HopeComboBox();
            this.foxLabel3 = new ReaLTaiizor.Controls.FoxLabel();
            this.cbPessoa = new ReaLTaiizor.Controls.HopeComboBox();
            this.foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            this.txtNota = new ReaLTaiizor.Controls.HopeTextBox();
            this.materialListViewAvaliacoes = new ReaLTaiizor.Controls.MaterialListView();
            this.hopeGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeletar
            // 
            this.btnDeletar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnDeletar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnDeletar.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDeletar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnDeletar.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnDeletar.Location = new System.Drawing.Point(678, 565);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnDeletar.Size = new System.Drawing.Size(252, 40);
            this.btnDeletar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnDeletar.TabIndex = 18;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextColor = System.Drawing.Color.White;
            this.btnDeletar.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnEditar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnEditar.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnEditar.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnEditar.Location = new System.Drawing.Point(344, 565);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnEditar.Size = new System.Drawing.Size(252, 40);
            this.btnEditar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnAdicionar.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnAdicionar.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdicionar.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnAdicionar.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnAdicionar.Location = new System.Drawing.Point(10, 565);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnAdicionar.Size = new System.Drawing.Size(252, 40);
            this.btnAdicionar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnAdicionar.TabIndex = 16;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextColor = System.Drawing.Color.White;
            this.btnAdicionar.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // hopeForm1
            // 
            this.hopeForm1.ControlBoxColorH = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.hopeForm1.ControlBoxColorHC = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeForm1.ControlBoxColorN = System.Drawing.Color.White;
            this.hopeForm1.Cursor = System.Windows.Forms.Cursors.Default;
            this.hopeForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hopeForm1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.hopeForm1.Image = ((System.Drawing.Image)(resources.GetObject("hopeForm1.Image")));
            this.hopeForm1.Location = new System.Drawing.Point(0, 0);
            this.hopeForm1.MaximizeBox = false;
            this.hopeForm1.Name = "hopeForm1";
            this.hopeForm1.Size = new System.Drawing.Size(944, 40);
            this.hopeForm1.TabIndex = 15;
            this.hopeForm1.Text = "Avaliações";
            this.hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // hopeGroupBox1
            // 
            this.hopeGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox1.Controls.Add(this.txtComentario);
            this.hopeGroupBox1.Controls.Add(this.foxLabel4);
            this.hopeGroupBox1.Controls.Add(this.cbSessao);
            this.hopeGroupBox1.Controls.Add(this.foxLabel3);
            this.hopeGroupBox1.Controls.Add(this.cbPessoa);
            this.hopeGroupBox1.Controls.Add(this.foxLabel2);
            this.hopeGroupBox1.Controls.Add(this.foxLabel1);
            this.hopeGroupBox1.Controls.Add(this.txtNota);
            this.hopeGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox1.Location = new System.Drawing.Point(10, 46);
            this.hopeGroupBox1.Name = "hopeGroupBox1";
            this.hopeGroupBox1.ShowText = false;
            this.hopeGroupBox1.Size = new System.Drawing.Size(920, 137);
            this.hopeGroupBox1.TabIndex = 19;
            this.hopeGroupBox1.TabStop = false;
            this.hopeGroupBox1.Text = "hopeGroupBox1";
            this.hopeGroupBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // txtComentario
            // 
            this.txtComentario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtComentario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtComentario.Hint = "";
            this.txtComentario.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtComentario.Location = new System.Drawing.Point(482, 19);
            this.txtComentario.MaxLength = 32767;
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.PasswordChar = '\0';
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComentario.SelectedText = "";
            this.txtComentario.SelectionLength = 0;
            this.txtComentario.SelectionStart = 0;
            this.txtComentario.Size = new System.Drawing.Size(422, 102);
            this.txtComentario.TabIndex = 21;
            this.txtComentario.TabStop = false;
            this.txtComentario.UseSystemPasswordChar = false;
            // 
            // foxLabel4
            // 
            this.foxLabel4.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel4.Location = new System.Drawing.Point(14, 71);
            this.foxLabel4.Name = "foxLabel4";
            this.foxLabel4.Size = new System.Drawing.Size(52, 19);
            this.foxLabel4.TabIndex = 9;
            this.foxLabel4.Text = "Sessão";
            // 
            // cbSessao
            // 
            this.cbSessao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSessao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSessao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSessao.FormattingEnabled = true;
            this.cbSessao.ItemHeight = 30;
            this.cbSessao.Location = new System.Drawing.Point(74, 63);
            this.cbSessao.Name = "cbSessao";
            this.cbSessao.Size = new System.Drawing.Size(121, 36);
            this.cbSessao.TabIndex = 10;
            // 
            // foxLabel3
            // 
            this.foxLabel3.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel3.Location = new System.Drawing.Point(14, 27);
            this.foxLabel3.Name = "foxLabel3";
            this.foxLabel3.Size = new System.Drawing.Size(52, 19);
            this.foxLabel3.TabIndex = 8;
            this.foxLabel3.Text = "Pessoa";
            // 
            // cbPessoa
            // 
            this.cbPessoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPessoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPessoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPessoa.FormattingEnabled = true;
            this.cbPessoa.ItemHeight = 30;
            this.cbPessoa.Location = new System.Drawing.Point(74, 19);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Size = new System.Drawing.Size(304, 36);
            this.cbPessoa.TabIndex = 8;
            // 
            // foxLabel2
            // 
            this.foxLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel2.Location = new System.Drawing.Point(395, 28);
            this.foxLabel2.Name = "foxLabel2";
            this.foxLabel2.Size = new System.Drawing.Size(81, 19);
            this.foxLabel2.TabIndex = 7;
            this.foxLabel2.Text = "Comentário";
            // 
            // foxLabel1
            // 
            this.foxLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel1.Location = new System.Drawing.Point(222, 71);
            this.foxLabel1.Name = "foxLabel1";
            this.foxLabel1.Size = new System.Drawing.Size(45, 19);
            this.foxLabel1.TabIndex = 5;
            this.foxLabel1.Text = "Nota";
            // 
            // txtNota
            // 
            this.txtNota.BackColor = System.Drawing.Color.White;
            this.txtNota.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNota.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtNota.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtNota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtNota.Hint = "";
            this.txtNota.Location = new System.Drawing.Point(273, 65);
            this.txtNota.MaxLength = 32767;
            this.txtNota.Multiline = false;
            this.txtNota.Name = "txtNota";
            this.txtNota.PasswordChar = '\0';
            this.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNota.SelectedText = "";
            this.txtNota.SelectionLength = 0;
            this.txtNota.SelectionStart = 0;
            this.txtNota.Size = new System.Drawing.Size(105, 34);
            this.txtNota.TabIndex = 4;
            this.txtNota.TabStop = false;
            this.txtNota.UseSystemPasswordChar = false;
            // 
            // materialListViewAvaliacoes
            // 
            this.materialListViewAvaliacoes.AutoSizeTable = false;
            this.materialListViewAvaliacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListViewAvaliacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListViewAvaliacoes.Depth = 0;
            this.materialListViewAvaliacoes.FullRowSelect = true;
            this.materialListViewAvaliacoes.HideSelection = false;
            this.materialListViewAvaliacoes.Location = new System.Drawing.Point(10, 189);
            this.materialListViewAvaliacoes.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListViewAvaliacoes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListViewAvaliacoes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialListViewAvaliacoes.MultiSelect = false;
            this.materialListViewAvaliacoes.Name = "materialListViewAvaliacoes";
            this.materialListViewAvaliacoes.OwnerDraw = true;
            this.materialListViewAvaliacoes.Size = new System.Drawing.Size(920, 364);
            this.materialListViewAvaliacoes.TabIndex = 20;
            this.materialListViewAvaliacoes.UseCompatibleStateImageBehavior = false;
            this.materialListViewAvaliacoes.View = System.Windows.Forms.View.Details;
            this.materialListViewAvaliacoes.SelectedIndexChanged += new System.EventHandler(this.materialListViewAvaliacoes_SelectedIndexChanged);
            // 
            // FrmAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 617);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.hopeForm1);
            this.Controls.Add(this.hopeGroupBox1);
            this.Controls.Add(this.materialListViewAvaliacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1032);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "FrmAvaliacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAvaliacao";
            this.hopeGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.HopeRoundButton btnDeletar;
        private ReaLTaiizor.Controls.HopeRoundButton btnEditar;
        private ReaLTaiizor.Controls.HopeRoundButton btnAdicionar;
        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.HopeGroupBox hopeGroupBox1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel3;
        private ReaLTaiizor.Controls.HopeComboBox cbPessoa;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.HopeTextBox txtNota;
        private ReaLTaiizor.Controls.MaterialListView materialListViewAvaliacoes;
        private ReaLTaiizor.Controls.FoxLabel foxLabel4;
        private ReaLTaiizor.Controls.HopeComboBox cbSessao;
        private ReaLTaiizor.Controls.HopeRichTextBox txtComentario;
    }
}