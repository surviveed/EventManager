namespace EventManager.Views.Home
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.hopeGroupBox1 = new ReaLTaiizor.Controls.HopeGroupBox();
            this.headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            this.txtLimparFiltros = new ReaLTaiizor.Controls.HopeButton();
            this.foxLabel5 = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel4 = new ReaLTaiizor.Controls.FoxLabel();
            this.cbFiltroTipoEvento = new ReaLTaiizor.Controls.HopeComboBox();
            this.txtFiltroNome = new ReaLTaiizor.Controls.HopeTextBox();
            this.materialListViewEventos = new ReaLTaiizor.Controls.MaterialListView();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.btnLogout = new ReaLTaiizor.Controls.MetroEllipse();
            this.btnAdmin = new ReaLTaiizor.Controls.MetroEllipse();
            this.hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            this.hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            this.hopeGroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hopeGroupBox1
            // 
            this.hopeGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox1.Controls.Add(this.headerLabel1);
            this.hopeGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox1.Location = new System.Drawing.Point(12, 60);
            this.hopeGroupBox1.Name = "hopeGroupBox1";
            this.hopeGroupBox1.ShowText = false;
            this.hopeGroupBox1.Size = new System.Drawing.Size(920, 57);
            this.hopeGroupBox1.TabIndex = 2;
            this.hopeGroupBox1.TabStop = false;
            this.hopeGroupBox1.Text = "hopeGroupBox1";
            this.hopeGroupBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // headerLabel1
            // 
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerLabel1.Location = new System.Drawing.Point(418, 15);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(115, 18);
            this.headerLabel1.TabIndex = 3;
            this.headerLabel1.Text = "EventManager";
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
            this.txtLimparFiltros.Location = new System.Drawing.Point(811, 130);
            this.txtLimparFiltros.Name = "txtLimparFiltros";
            this.txtLimparFiltros.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtLimparFiltros.Size = new System.Drawing.Size(120, 40);
            this.txtLimparFiltros.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.txtLimparFiltros.TabIndex = 18;
            this.txtLimparFiltros.Text = "Limpar";
            this.txtLimparFiltros.TextColor = System.Drawing.Color.White;
            this.txtLimparFiltros.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.txtLimparFiltros.Click += new System.EventHandler(this.txtLimparFiltros_Click);
            // 
            // foxLabel5
            // 
            this.foxLabel5.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.foxLabel5.Location = new System.Drawing.Point(419, 141);
            this.foxLabel5.Name = "foxLabel5";
            this.foxLabel5.Size = new System.Drawing.Size(100, 19);
            this.foxLabel5.TabIndex = 14;
            this.foxLabel5.Text = "Tipo de Evento";
            // 
            // foxLabel4
            // 
            this.foxLabel4.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.foxLabel4.Location = new System.Drawing.Point(80, 141);
            this.foxLabel4.Name = "foxLabel4";
            this.foxLabel4.Size = new System.Drawing.Size(45, 19);
            this.foxLabel4.TabIndex = 16;
            this.foxLabel4.Text = "Nome";
            // 
            // cbFiltroTipoEvento
            // 
            this.cbFiltroTipoEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFiltroTipoEvento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFiltroTipoEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFiltroTipoEvento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltroTipoEvento.FormattingEnabled = true;
            this.cbFiltroTipoEvento.ItemHeight = 30;
            this.cbFiltroTipoEvento.Location = new System.Drawing.Point(525, 132);
            this.cbFiltroTipoEvento.Name = "cbFiltroTipoEvento";
            this.cbFiltroTipoEvento.Size = new System.Drawing.Size(280, 36);
            this.cbFiltroTipoEvento.TabIndex = 17;
            this.cbFiltroTipoEvento.SelectedIndexChanged += new System.EventHandler(this.cbFiltroTipoEvento_SelectedIndexChanged);
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
            this.txtFiltroNome.Location = new System.Drawing.Point(131, 133);
            this.txtFiltroNome.MaxLength = 32767;
            this.txtFiltroNome.Multiline = false;
            this.txtFiltroNome.Name = "txtFiltroNome";
            this.txtFiltroNome.PasswordChar = '\0';
            this.txtFiltroNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltroNome.SelectedText = "";
            this.txtFiltroNome.SelectionLength = 0;
            this.txtFiltroNome.SelectionStart = 0;
            this.txtFiltroNome.Size = new System.Drawing.Size(282, 34);
            this.txtFiltroNome.TabIndex = 15;
            this.txtFiltroNome.TabStop = false;
            this.txtFiltroNome.UseSystemPasswordChar = false;
            this.txtFiltroNome.TextChanged += new System.EventHandler(this.txtFiltroNome_TextChanged);
            // 
            // materialListViewEventos
            // 
            this.materialListViewEventos.AutoSizeTable = false;
            this.materialListViewEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListViewEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListViewEventos.Depth = 0;
            this.materialListViewEventos.FullRowSelect = true;
            this.materialListViewEventos.HideSelection = false;
            this.materialListViewEventos.Location = new System.Drawing.Point(12, 176);
            this.materialListViewEventos.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListViewEventos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListViewEventos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialListViewEventos.MultiSelect = false;
            this.materialListViewEventos.Name = "materialListViewEventos";
            this.materialListViewEventos.OwnerDraw = true;
            this.materialListViewEventos.Size = new System.Drawing.Size(920, 381);
            this.materialListViewEventos.TabIndex = 20;
            this.materialListViewEventos.UseCompatibleStateImageBehavior = false;
            this.materialListViewEventos.View = System.Windows.Forms.View.Details;
            this.materialListViewEventos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.materialListViewEventos_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(0, 563);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(944, 54);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 21;
            this.panel1.Text = "panel1";
            // 
            // btnLogout
            // 
            this.btnLogout.BorderThickness = 0;
            this.btnLogout.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogout.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnLogout.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogout.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnLogout.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnLogout.HoverTextColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::EventManager.Properties.Resources.logout;
            this.btnLogout.ImageSize = new System.Drawing.Size(32, 32);
            this.btnLogout.IsDerivedStyle = true;
            this.btnLogout.Location = new System.Drawing.Point(891, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogout.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnLogout.NormalTextColor = System.Drawing.Color.Black;
            this.btnLogout.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLogout.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLogout.PressTextColor = System.Drawing.Color.White;
            this.btnLogout.Size = new System.Drawing.Size(40, 40);
            this.btnLogout.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btnLogout.StyleManager = null;
            this.btnLogout.TabIndex = 1;
            this.btnLogout.ThemeAuthor = "Taiizor";
            this.btnLogout.ThemeName = "MetroLight";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BorderThickness = 0;
            this.btnAdmin.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdmin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnAdmin.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdmin.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAdmin.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAdmin.HoverTextColor = System.Drawing.Color.White;
            this.btnAdmin.Image = global::EventManager.Properties.Resources.admin;
            this.btnAdmin.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAdmin.IsDerivedStyle = true;
            this.btnAdmin.Location = new System.Drawing.Point(11, 8);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdmin.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnAdmin.NormalTextColor = System.Drawing.Color.Black;
            this.btnAdmin.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAdmin.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAdmin.PressTextColor = System.Drawing.Color.White;
            this.btnAdmin.Size = new System.Drawing.Size(40, 40);
            this.btnAdmin.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btnAdmin.StyleManager = null;
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.ThemeAuthor = "Taiizor";
            this.btnAdmin.ThemeName = "MetroLight";
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // hopePictureBox1
            // 
            this.hopePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox1.Image = global::EventManager.Properties.Resources.search;
            this.hopePictureBox1.Location = new System.Drawing.Point(11, 132);
            this.hopePictureBox1.Name = "hopePictureBox1";
            this.hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox1.Size = new System.Drawing.Size(35, 36);
            this.hopePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox1.TabIndex = 19;
            this.hopePictureBox1.TabStop = false;
            this.hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
            this.hopeForm1.TabIndex = 1;
            this.hopeForm1.Text = "EventManager";
            this.hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialListViewEventos);
            this.Controls.Add(this.hopePictureBox1);
            this.Controls.Add(this.txtLimparFiltros);
            this.Controls.Add(this.foxLabel5);
            this.Controls.Add(this.foxLabel4);
            this.Controls.Add(this.cbFiltroTipoEvento);
            this.Controls.Add(this.txtFiltroNome);
            this.Controls.Add(this.hopeGroupBox1);
            this.Controls.Add(this.hopeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1032);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.hopeGroupBox1.ResumeLayout(false);
            this.hopeGroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.HopeGroupBox hopeGroupBox1;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.HopeButton txtLimparFiltros;
        private ReaLTaiizor.Controls.FoxLabel foxLabel5;
        private ReaLTaiizor.Controls.FoxLabel foxLabel4;
        private ReaLTaiizor.Controls.HopeComboBox cbFiltroTipoEvento;
        private ReaLTaiizor.Controls.HopeTextBox txtFiltroNome;
        private ReaLTaiizor.Controls.MaterialListView materialListViewEventos;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.MetroEllipse btnAdmin;
        private ReaLTaiizor.Controls.MetroEllipse btnLogout;
    }
}