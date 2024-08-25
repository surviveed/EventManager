namespace EventManager.Views.CrudSessao
{
    partial class FrmEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEvento));
            this.hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            this.btnAdicionar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnEditar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnDeletar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.txtNome = new ReaLTaiizor.Controls.HopeTextBox();
            this.hopeGroupBox1 = new ReaLTaiizor.Controls.HopeGroupBox();
            this.foxLabel3 = new ReaLTaiizor.Controls.FoxLabel();
            this.cbTipoEvento = new ReaLTaiizor.Controls.HopeComboBox();
            this.foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            this.txtDescricao = new ReaLTaiizor.Controls.HopeTextBox();
            this.foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            this.materialListViewEventos = new ReaLTaiizor.Controls.MaterialListView();
            this.foxLabel4 = new ReaLTaiizor.Controls.FoxLabel();
            this.txtFiltroNome = new ReaLTaiizor.Controls.HopeTextBox();
            this.foxLabel5 = new ReaLTaiizor.Controls.FoxLabel();
            this.cbFiltroTipoEvento = new ReaLTaiizor.Controls.HopeComboBox();
            this.txtLimparFiltros = new ReaLTaiizor.Controls.HopeButton();
            this.hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            this.hopeGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.hopeForm1.TabIndex = 0;
            this.hopeForm1.Text = "Eventos";
            this.hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
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
            this.btnAdicionar.Location = new System.Drawing.Point(12, 565);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnAdicionar.Size = new System.Drawing.Size(252, 40);
            this.btnAdicionar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextColor = System.Drawing.Color.White;
            this.btnAdicionar.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(346, 565);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnEditar.Size = new System.Drawing.Size(252, 40);
            this.btnEditar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnDeletar.Location = new System.Drawing.Point(680, 565);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnDeletar.Size = new System.Drawing.Size(252, 40);
            this.btnDeletar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextColor = System.Drawing.Color.White;
            this.btnDeletar.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
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
            this.hopeGroupBox1.Controls.Add(this.cbTipoEvento);
            this.hopeGroupBox1.Controls.Add(this.foxLabel2);
            this.hopeGroupBox1.Controls.Add(this.txtDescricao);
            this.hopeGroupBox1.Controls.Add(this.foxLabel1);
            this.hopeGroupBox1.Controls.Add(this.txtNome);
            this.hopeGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox1.Location = new System.Drawing.Point(12, 46);
            this.hopeGroupBox1.Name = "hopeGroupBox1";
            this.hopeGroupBox1.ShowText = false;
            this.hopeGroupBox1.Size = new System.Drawing.Size(920, 137);
            this.hopeGroupBox1.TabIndex = 5;
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
            this.foxLabel3.Text = "Tipo de Evento";
            // 
            // cbTipoEvento
            // 
            this.cbTipoEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoEvento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoEvento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoEvento.FormattingEnabled = true;
            this.cbTipoEvento.ItemHeight = 30;
            this.cbTipoEvento.Location = new System.Drawing.Point(392, 28);
            this.cbTipoEvento.Name = "cbTipoEvento";
            this.cbTipoEvento.Size = new System.Drawing.Size(194, 36);
            this.cbTipoEvento.TabIndex = 8;
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
            this.foxLabel2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDescricao.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtDescricao.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtDescricao.Hint = "";
            this.txtDescricao.Location = new System.Drawing.Point(98, 72);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Multiline = false;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.Size = new System.Drawing.Size(182, 34);
            this.txtDescricao.TabIndex = 6;
            this.txtDescricao.TabStop = false;
            this.txtDescricao.UseSystemPasswordChar = false;
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
            // materialListViewEventos
            // 
            this.materialListViewEventos.AutoSizeTable = false;
            this.materialListViewEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListViewEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListViewEventos.Depth = 0;
            this.materialListViewEventos.FullRowSelect = true;
            this.materialListViewEventos.HideSelection = false;
            this.materialListViewEventos.Location = new System.Drawing.Point(12, 253);
            this.materialListViewEventos.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListViewEventos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListViewEventos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialListViewEventos.MultiSelect = false;
            this.materialListViewEventos.Name = "materialListViewEventos";
            this.materialListViewEventos.OwnerDraw = true;
            this.materialListViewEventos.Size = new System.Drawing.Size(920, 300);
            this.materialListViewEventos.TabIndex = 8;
            this.materialListViewEventos.UseCompatibleStateImageBehavior = false;
            this.materialListViewEventos.View = System.Windows.Forms.View.Details;
            this.materialListViewEventos.SelectedIndexChanged += new System.EventHandler(this.materialListViewEventos_SelectedIndexChanged_1);
            // 
            // foxLabel4
            // 
            this.foxLabel4.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.foxLabel4.Location = new System.Drawing.Point(81, 209);
            this.foxLabel4.Name = "foxLabel4";
            this.foxLabel4.Size = new System.Drawing.Size(45, 19);
            this.foxLabel4.TabIndex = 10;
            this.foxLabel4.Text = "Nome";
            // 
            // txtFiltroNome
            // 
            this.txtFiltroNome.BackColor = System.Drawing.Color.White;
            this.txtFiltroNome.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFiltroNome.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtFiltroNome.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtFiltroNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtFiltroNome.Hint = "";
            this.txtFiltroNome.Location = new System.Drawing.Point(132, 201);
            this.txtFiltroNome.MaxLength = 32767;
            this.txtFiltroNome.Multiline = false;
            this.txtFiltroNome.Name = "txtFiltroNome";
            this.txtFiltroNome.PasswordChar = '\0';
            this.txtFiltroNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltroNome.SelectedText = "";
            this.txtFiltroNome.SelectionLength = 0;
            this.txtFiltroNome.SelectionStart = 0;
            this.txtFiltroNome.Size = new System.Drawing.Size(282, 34);
            this.txtFiltroNome.TabIndex = 9;
            this.txtFiltroNome.TabStop = false;
            this.txtFiltroNome.UseSystemPasswordChar = false;
            this.txtFiltroNome.TextChanged += new System.EventHandler(this.txtFiltroNome_TextChanged);
            // 
            // foxLabel5
            // 
            this.foxLabel5.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.foxLabel5.Location = new System.Drawing.Point(420, 209);
            this.foxLabel5.Name = "foxLabel5";
            this.foxLabel5.Size = new System.Drawing.Size(100, 19);
            this.foxLabel5.TabIndex = 9;
            this.foxLabel5.Text = "Tipo de Evento";
            // 
            // cbFiltroTipoEvento
            // 
            this.cbFiltroTipoEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFiltroTipoEvento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFiltroTipoEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFiltroTipoEvento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltroTipoEvento.FormattingEnabled = true;
            this.cbFiltroTipoEvento.ItemHeight = 30;
            this.cbFiltroTipoEvento.Location = new System.Drawing.Point(526, 200);
            this.cbFiltroTipoEvento.Name = "cbFiltroTipoEvento";
            this.cbFiltroTipoEvento.Size = new System.Drawing.Size(280, 36);
            this.cbFiltroTipoEvento.TabIndex = 10;
            this.cbFiltroTipoEvento.SelectedIndexChanged += new System.EventHandler(this.cbFiltroTipoEvento_SelectedIndexChanged);
            // 
            // txtLimparFiltros
            // 
            this.txtLimparFiltros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtLimparFiltros.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.txtLimparFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLimparFiltros.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.txtLimparFiltros.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtLimparFiltros.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLimparFiltros.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtLimparFiltros.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.txtLimparFiltros.Location = new System.Drawing.Point(812, 198);
            this.txtLimparFiltros.Name = "txtLimparFiltros";
            this.txtLimparFiltros.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtLimparFiltros.Size = new System.Drawing.Size(120, 40);
            this.txtLimparFiltros.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.txtLimparFiltros.TabIndex = 12;
            this.txtLimparFiltros.Text = "Limpar";
            this.txtLimparFiltros.TextColor = System.Drawing.Color.White;
            this.txtLimparFiltros.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.txtLimparFiltros.Click += new System.EventHandler(this.txtLimparFiltros_Click);
            // 
            // hopePictureBox1
            // 
            this.hopePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox1.Image = global::EventManager.Properties.Resources.search;
            this.hopePictureBox1.Location = new System.Drawing.Point(12, 200);
            this.hopePictureBox1.Name = "hopePictureBox1";
            this.hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox1.Size = new System.Drawing.Size(35, 36);
            this.hopePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox1.TabIndex = 13;
            this.hopePictureBox1.TabStop = false;
            this.hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // FrmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 617);
            this.Controls.Add(this.hopePictureBox1);
            this.Controls.Add(this.txtLimparFiltros);
            this.Controls.Add(this.foxLabel5);
            this.Controls.Add(this.foxLabel4);
            this.Controls.Add(this.cbFiltroTipoEvento);
            this.Controls.Add(this.txtFiltroNome);
            this.Controls.Add(this.materialListViewEventos);
            this.Controls.Add(this.hopeGroupBox1);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.hopeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1032);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "FrmEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sessões";
            this.hopeGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.HopeRoundButton btnAdicionar;
        private ReaLTaiizor.Controls.HopeRoundButton btnEditar;
        private ReaLTaiizor.Controls.HopeRoundButton btnDeletar;
        private ReaLTaiizor.Controls.HopeTextBox txtNome;
        private ReaLTaiizor.Controls.HopeGroupBox hopeGroupBox1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel3;
        private ReaLTaiizor.Controls.HopeComboBox cbTipoEvento;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.HopeTextBox txtDescricao;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.MaterialListView materialListViewEventos;
        private ReaLTaiizor.Controls.FoxLabel foxLabel4;
        private ReaLTaiizor.Controls.HopeTextBox txtFiltroNome;
        private ReaLTaiizor.Controls.FoxLabel foxLabel5;
        private ReaLTaiizor.Controls.HopeComboBox cbFiltroTipoEvento;
        private ReaLTaiizor.Controls.HopeButton txtLimparFiltros;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
    }
}