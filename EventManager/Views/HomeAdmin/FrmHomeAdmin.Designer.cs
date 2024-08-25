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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomeAdmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            this.materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            this.btnPaises = new ReaLTaiizor.Controls.HopeButton();
            this.btnUfs = new ReaLTaiizor.Controls.HopeButton();
            this.btnCidades = new ReaLTaiizor.Controls.HopeButton();
            this.btnLocais = new ReaLTaiizor.Controls.HopeButton();
            this.btnTiposDeEventos = new ReaLTaiizor.Controls.HopeButton();
            this.btnEventos = new ReaLTaiizor.Controls.HopeButton();
            this.btnSessoes = new ReaLTaiizor.Controls.HopeButton();
            this.btnPessoas = new ReaLTaiizor.Controls.HopeButton();
            this.btnAvaliacoes = new ReaLTaiizor.Controls.HopeButton();
            this.btnUsuarios = new ReaLTaiizor.Controls.HopeButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EventManager.Properties.Resources.admin;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(448, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 69);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            this.hopeForm1.Size = new System.Drawing.Size(963, 40);
            this.hopeForm1.TabIndex = 2;
            this.hopeForm1.Text = "Administrador";
            this.hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnUsuarios);
            this.materialCard1.Controls.Add(this.btnAvaliacoes);
            this.materialCard1.Controls.Add(this.btnPessoas);
            this.materialCard1.Controls.Add(this.btnSessoes);
            this.materialCard1.Controls.Add(this.btnEventos);
            this.materialCard1.Controls.Add(this.btnTiposDeEventos);
            this.materialCard1.Controls.Add(this.btnLocais);
            this.materialCard1.Controls.Add(this.btnCidades);
            this.materialCard1.Controls.Add(this.btnUfs);
            this.materialCard1.Controls.Add(this.btnPaises);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 132);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(920, 382);
            this.materialCard1.TabIndex = 4;
            // 
            // btnPaises
            // 
            this.btnPaises.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnPaises.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnPaises.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaises.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnPaises.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPaises.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPaises.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnPaises.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnPaises.Location = new System.Drawing.Point(17, 17);
            this.btnPaises.Name = "btnPaises";
            this.btnPaises.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnPaises.Size = new System.Drawing.Size(412, 40);
            this.btnPaises.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnPaises.TabIndex = 2;
            this.btnPaises.Text = "Paises";
            this.btnPaises.TextColor = System.Drawing.Color.White;
            this.btnPaises.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnPaises.Click += new System.EventHandler(this.btnPaises_Click);
            // 
            // btnUfs
            // 
            this.btnUfs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnUfs.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnUfs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUfs.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnUfs.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUfs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUfs.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnUfs.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnUfs.Location = new System.Drawing.Point(17, 63);
            this.btnUfs.Name = "btnUfs";
            this.btnUfs.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnUfs.Size = new System.Drawing.Size(412, 40);
            this.btnUfs.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnUfs.TabIndex = 3;
            this.btnUfs.Text = "UFs";
            this.btnUfs.TextColor = System.Drawing.Color.White;
            this.btnUfs.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnUfs.Click += new System.EventHandler(this.btnUfs_Click);
            // 
            // btnCidades
            // 
            this.btnCidades.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnCidades.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnCidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCidades.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnCidades.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCidades.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCidades.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnCidades.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnCidades.Location = new System.Drawing.Point(17, 109);
            this.btnCidades.Name = "btnCidades";
            this.btnCidades.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnCidades.Size = new System.Drawing.Size(412, 40);
            this.btnCidades.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnCidades.TabIndex = 4;
            this.btnCidades.Text = "Cidades";
            this.btnCidades.TextColor = System.Drawing.Color.White;
            this.btnCidades.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnCidades.Click += new System.EventHandler(this.btnCidades_Click);
            // 
            // btnLocais
            // 
            this.btnLocais.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnLocais.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnLocais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocais.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnLocais.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLocais.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLocais.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnLocais.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnLocais.Location = new System.Drawing.Point(17, 155);
            this.btnLocais.Name = "btnLocais";
            this.btnLocais.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnLocais.Size = new System.Drawing.Size(412, 40);
            this.btnLocais.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnLocais.TabIndex = 5;
            this.btnLocais.Text = "Locais";
            this.btnLocais.TextColor = System.Drawing.Color.White;
            this.btnLocais.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnLocais.Click += new System.EventHandler(this.btnLocais_Click);
            // 
            // btnTiposDeEventos
            // 
            this.btnTiposDeEventos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnTiposDeEventos.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnTiposDeEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTiposDeEventos.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnTiposDeEventos.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTiposDeEventos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTiposDeEventos.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnTiposDeEventos.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnTiposDeEventos.Location = new System.Drawing.Point(488, 17);
            this.btnTiposDeEventos.Name = "btnTiposDeEventos";
            this.btnTiposDeEventos.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnTiposDeEventos.Size = new System.Drawing.Size(412, 40);
            this.btnTiposDeEventos.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnTiposDeEventos.TabIndex = 6;
            this.btnTiposDeEventos.Text = "Tipos de Eventos";
            this.btnTiposDeEventos.TextColor = System.Drawing.Color.White;
            this.btnTiposDeEventos.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnTiposDeEventos.Click += new System.EventHandler(this.btnTiposDeEventos_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnEventos.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventos.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnEventos.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEventos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEventos.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnEventos.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnEventos.Location = new System.Drawing.Point(488, 63);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnEventos.Size = new System.Drawing.Size(412, 40);
            this.btnEventos.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnEventos.TabIndex = 7;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.TextColor = System.Drawing.Color.White;
            this.btnEventos.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnSessoes
            // 
            this.btnSessoes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnSessoes.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnSessoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSessoes.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnSessoes.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSessoes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSessoes.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnSessoes.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnSessoes.Location = new System.Drawing.Point(488, 109);
            this.btnSessoes.Name = "btnSessoes";
            this.btnSessoes.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnSessoes.Size = new System.Drawing.Size(412, 40);
            this.btnSessoes.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnSessoes.TabIndex = 8;
            this.btnSessoes.Text = "Sessões";
            this.btnSessoes.TextColor = System.Drawing.Color.White;
            this.btnSessoes.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnSessoes.Click += new System.EventHandler(this.btnSessoes_Click);
            // 
            // btnPessoas
            // 
            this.btnPessoas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnPessoas.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnPessoas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPessoas.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnPessoas.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPessoas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPessoas.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnPessoas.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnPessoas.Location = new System.Drawing.Point(17, 264);
            this.btnPessoas.Name = "btnPessoas";
            this.btnPessoas.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnPessoas.Size = new System.Drawing.Size(412, 40);
            this.btnPessoas.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnPessoas.TabIndex = 9;
            this.btnPessoas.Text = "Pessoas";
            this.btnPessoas.TextColor = System.Drawing.Color.White;
            this.btnPessoas.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnPessoas.Click += new System.EventHandler(this.btnPessoas_Click);
            // 
            // btnAvaliacoes
            // 
            this.btnAvaliacoes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnAvaliacoes.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnAvaliacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvaliacoes.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnAvaliacoes.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAvaliacoes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAvaliacoes.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnAvaliacoes.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnAvaliacoes.Location = new System.Drawing.Point(488, 155);
            this.btnAvaliacoes.Name = "btnAvaliacoes";
            this.btnAvaliacoes.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnAvaliacoes.Size = new System.Drawing.Size(412, 40);
            this.btnAvaliacoes.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnAvaliacoes.TabIndex = 10;
            this.btnAvaliacoes.Text = "Avaliações";
            this.btnAvaliacoes.TextColor = System.Drawing.Color.White;
            this.btnAvaliacoes.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnAvaliacoes.Click += new System.EventHandler(this.btnAvaliacoes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnUsuarios.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnUsuarios.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUsuarios.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnUsuarios.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnUsuarios.Location = new System.Drawing.Point(17, 310);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnUsuarios.Size = new System.Drawing.Size(412, 40);
            this.btnUsuarios.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnUsuarios.TabIndex = 11;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.TextColor = System.Drawing.Color.White;
            this.btnUsuarios.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // FrmHomeAdminNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 566);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hopeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1032);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "FrmHomeAdminNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHomeAdminNovo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.HopeButton btnPaises;
        private ReaLTaiizor.Controls.HopeButton btnAvaliacoes;
        private ReaLTaiizor.Controls.HopeButton btnPessoas;
        private ReaLTaiizor.Controls.HopeButton btnSessoes;
        private ReaLTaiizor.Controls.HopeButton btnEventos;
        private ReaLTaiizor.Controls.HopeButton btnTiposDeEventos;
        private ReaLTaiizor.Controls.HopeButton btnLocais;
        private ReaLTaiizor.Controls.HopeButton btnCidades;
        private ReaLTaiizor.Controls.HopeButton btnUfs;
        private ReaLTaiizor.Controls.HopeButton btnUsuarios;
    }
}