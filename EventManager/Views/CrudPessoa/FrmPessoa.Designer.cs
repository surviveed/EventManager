namespace EventManager.Views.CrudPessoa
{
    partial class FrmPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPessoa));
            this.btnDeletar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnEditar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnAdicionar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            this.txtNome = new ReaLTaiizor.Controls.HopeTextBox();
            this.hopeGroupBox1 = new ReaLTaiizor.Controls.HopeGroupBox();
            this.foxLabel3 = new ReaLTaiizor.Controls.FoxLabel();
            this.cbTipoPessoa = new ReaLTaiizor.Controls.HopeComboBox();
            this.foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            this.txtCpf = new ReaLTaiizor.Controls.HopeTextBox();
            this.foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            this.materialListViewPessoas = new ReaLTaiizor.Controls.MaterialListView();
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
            this.btnDeletar.Location = new System.Drawing.Point(680, 571);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnDeletar.Size = new System.Drawing.Size(252, 40);
            this.btnDeletar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnDeletar.TabIndex = 12;
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
            this.btnEditar.Location = new System.Drawing.Point(346, 571);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnEditar.Size = new System.Drawing.Size(252, 40);
            this.btnEditar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnEditar.TabIndex = 11;
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
            this.btnAdicionar.Location = new System.Drawing.Point(12, 571);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnAdicionar.Size = new System.Drawing.Size(252, 40);
            this.btnAdicionar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnAdicionar.TabIndex = 10;
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
            this.hopeForm1.TabIndex = 9;
            this.hopeForm1.Text = "Pessoas";
            this.hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNome.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtNome.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtNome.Hint = "";
            this.txtNome.Location = new System.Drawing.Point(98, 28);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(182, 34);
            this.txtNome.TabIndex = 4;
            this.txtNome.TabStop = false;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // hopeGroupBox1
            // 
            this.hopeGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox1.Controls.Add(this.foxLabel3);
            this.hopeGroupBox1.Controls.Add(this.cbTipoPessoa);
            this.hopeGroupBox1.Controls.Add(this.foxLabel2);
            this.hopeGroupBox1.Controls.Add(this.txtCpf);
            this.hopeGroupBox1.Controls.Add(this.foxLabel1);
            this.hopeGroupBox1.Controls.Add(this.txtNome);
            this.hopeGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox1.Location = new System.Drawing.Point(12, 52);
            this.hopeGroupBox1.Name = "hopeGroupBox1";
            this.hopeGroupBox1.ShowText = false;
            this.hopeGroupBox1.Size = new System.Drawing.Size(920, 137);
            this.hopeGroupBox1.TabIndex = 13;
            this.hopeGroupBox1.TabStop = false;
            this.hopeGroupBox1.Text = "hopeGroupBox1";
            this.hopeGroupBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // foxLabel3
            // 
            this.foxLabel3.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel3.Location = new System.Drawing.Point(286, 36);
            this.foxLabel3.Name = "foxLabel3";
            this.foxLabel3.Size = new System.Drawing.Size(100, 19);
            this.foxLabel3.TabIndex = 8;
            this.foxLabel3.Text = "Tipo de Pessoa";
            // 
            // cbTipoPessoa
            // 
            this.cbTipoPessoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoPessoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoPessoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoPessoa.FormattingEnabled = true;
            this.cbTipoPessoa.ItemHeight = 30;
            this.cbTipoPessoa.Location = new System.Drawing.Point(392, 28);
            this.cbTipoPessoa.Name = "cbTipoPessoa";
            this.cbTipoPessoa.Size = new System.Drawing.Size(194, 36);
            this.cbTipoPessoa.TabIndex = 8;
            // 
            // foxLabel2
            // 
            this.foxLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel2.Location = new System.Drawing.Point(27, 82);
            this.foxLabel2.Name = "foxLabel2";
            this.foxLabel2.Size = new System.Drawing.Size(65, 19);
            this.foxLabel2.TabIndex = 7;
            this.foxLabel2.Text = "CPF";
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.White;
            this.txtCpf.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCpf.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtCpf.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtCpf.Hint = "";
            this.txtCpf.Location = new System.Drawing.Point(98, 72);
            this.txtCpf.MaxLength = 32767;
            this.txtCpf.Multiline = false;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PasswordChar = '\0';
            this.txtCpf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCpf.SelectedText = "";
            this.txtCpf.SelectionLength = 0;
            this.txtCpf.SelectionStart = 0;
            this.txtCpf.Size = new System.Drawing.Size(182, 34);
            this.txtCpf.TabIndex = 6;
            this.txtCpf.TabStop = false;
            this.txtCpf.UseSystemPasswordChar = false;
            // 
            // foxLabel1
            // 
            this.foxLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel1.Location = new System.Drawing.Point(27, 38);
            this.foxLabel1.Name = "foxLabel1";
            this.foxLabel1.Size = new System.Drawing.Size(45, 19);
            this.foxLabel1.TabIndex = 5;
            this.foxLabel1.Text = "Nome";
            // 
            // materialListViewPessoas
            // 
            this.materialListViewPessoas.AutoSizeTable = false;
            this.materialListViewPessoas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListViewPessoas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListViewPessoas.Depth = 0;
            this.materialListViewPessoas.FullRowSelect = true;
            this.materialListViewPessoas.HideSelection = false;
            this.materialListViewPessoas.Location = new System.Drawing.Point(12, 195);
            this.materialListViewPessoas.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListViewPessoas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListViewPessoas.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialListViewPessoas.MultiSelect = false;
            this.materialListViewPessoas.Name = "materialListViewPessoas";
            this.materialListViewPessoas.OwnerDraw = true;
            this.materialListViewPessoas.Size = new System.Drawing.Size(920, 364);
            this.materialListViewPessoas.TabIndex = 14;
            this.materialListViewPessoas.UseCompatibleStateImageBehavior = false;
            this.materialListViewPessoas.View = System.Windows.Forms.View.Details;
            this.materialListViewPessoas.SelectedIndexChanged += new System.EventHandler(this.materialListViewPessoas_SelectedIndexChanged);
            // 
            // FrmPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 617);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.hopeForm1);
            this.Controls.Add(this.hopeGroupBox1);
            this.Controls.Add(this.materialListViewPessoas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1032);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "FrmPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPessoa";
            this.hopeGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.HopeRoundButton btnDeletar;
        private ReaLTaiizor.Controls.HopeRoundButton btnEditar;
        private ReaLTaiizor.Controls.HopeRoundButton btnAdicionar;
        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.HopeTextBox txtNome;
        private ReaLTaiizor.Controls.HopeGroupBox hopeGroupBox1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel3;
        private ReaLTaiizor.Controls.HopeComboBox cbTipoPessoa;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.HopeTextBox txtCpf;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.MaterialListView materialListViewPessoas;
    }
}