namespace EventManager.Views.Details
{
    partial class FrmEventoDetalhes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEventoDetalhes));
            this.materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            this.lblDescricao = new ReaLTaiizor.Controls.MetroLabel();
            this.lblNome = new ReaLTaiizor.Controls.BigLabel();
            this.hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            this.materialCard2 = new ReaLTaiizor.Controls.MaterialCard();
            this.lblDescricaoTipoEvento = new ReaLTaiizor.Controls.BigLabel();
            this.materialCard3 = new ReaLTaiizor.Controls.MaterialCard();
            this.metroLabel3 = new ReaLTaiizor.Controls.MetroLabel();
            this.materialCard4 = new ReaLTaiizor.Controls.MaterialCard();
            this.lblNumeroDeOrganizadores = new ReaLTaiizor.Controls.NightLinkLabel();
            this.lblNumeroDeSessoes = new ReaLTaiizor.Controls.NightLinkLabel();
            this.metroLabel2 = new ReaLTaiizor.Controls.MetroLabel();
            this.metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            this.foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            this.materialListViewSessoes = new ReaLTaiizor.Controls.MaterialListView();
            this.foreverGroupBox2 = new ReaLTaiizor.Controls.ForeverGroupBox();
            this.materialListViewOrganizadores = new ReaLTaiizor.Controls.MaterialListView();
            this.groupBoxAvaliacoes = new ReaLTaiizor.Controls.ForeverGroupBox();
            this.materialListViewAvaliacoes = new ReaLTaiizor.Controls.MaterialListView();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.foreverGroupBox1.SuspendLayout();
            this.foreverGroupBox2.SuspendLayout();
            this.groupBoxAvaliacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblDescricao);
            this.materialCard1.Controls.Add(this.lblNome);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(23, 57);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(446, 226);
            this.materialCard1.TabIndex = 3;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDescricao.IsDerivedStyle = true;
            this.lblDescricao.Location = new System.Drawing.Point(25, 75);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(404, 137);
            this.lblDescricao.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblDescricao.StyleManager = null;
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.ThemeAuthor = "Taiizor";
            this.lblDescricao.ThemeName = "MetroLight";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblNome.Location = new System.Drawing.Point(17, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(112, 46);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
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
            this.hopeForm1.TabIndex = 2;
            this.hopeForm1.Text = "EventManager";
            this.hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lblDescricaoTipoEvento);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(497, 57);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(424, 82);
            this.materialCard2.TabIndex = 4;
            // 
            // lblDescricaoTipoEvento
            // 
            this.lblDescricaoTipoEvento.AutoSize = true;
            this.lblDescricaoTipoEvento.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricaoTipoEvento.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lblDescricaoTipoEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblDescricaoTipoEvento.Location = new System.Drawing.Point(17, 14);
            this.lblDescricaoTipoEvento.Name = "lblDescricaoTipoEvento";
            this.lblDescricaoTipoEvento.Size = new System.Drawing.Size(244, 46);
            this.lblDescricaoTipoEvento.TabIndex = 5;
            this.lblDescricaoTipoEvento.Text = "Tipo de Evento";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.metroLabel3);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(497, 149);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(424, 53);
            this.materialCard3.TabIndex = 5;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroLabel3.IsDerivedStyle = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 17);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(147, 23);
            this.metroLabel3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Média das avaliações";
            this.metroLabel3.ThemeAuthor = "Taiizor";
            this.metroLabel3.ThemeName = "MetroLight";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.lblNumeroDeOrganizadores);
            this.materialCard4.Controls.Add(this.lblNumeroDeSessoes);
            this.materialCard4.Controls.Add(this.metroLabel2);
            this.materialCard4.Controls.Add(this.metroLabel1);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(497, 210);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(424, 73);
            this.materialCard4.TabIndex = 6;
            // 
            // lblNumeroDeOrganizadores
            // 
            this.lblNumeroDeOrganizadores.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.lblNumeroDeOrganizadores.AutoSize = true;
            this.lblNumeroDeOrganizadores.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroDeOrganizadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNumeroDeOrganizadores.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDeOrganizadores.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblNumeroDeOrganizadores.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.lblNumeroDeOrganizadores.Location = new System.Drawing.Point(295, 37);
            this.lblNumeroDeOrganizadores.Name = "lblNumeroDeOrganizadores";
            this.lblNumeroDeOrganizadores.Size = new System.Drawing.Size(23, 25);
            this.lblNumeroDeOrganizadores.TabIndex = 7;
            this.lblNumeroDeOrganizadores.TabStop = true;
            this.lblNumeroDeOrganizadores.Text = "2";
            this.lblNumeroDeOrganizadores.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            // 
            // lblNumeroDeSessoes
            // 
            this.lblNumeroDeSessoes.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.lblNumeroDeSessoes.AutoSize = true;
            this.lblNumeroDeSessoes.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroDeSessoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNumeroDeSessoes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDeSessoes.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblNumeroDeSessoes.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.lblNumeroDeSessoes.Location = new System.Drawing.Point(73, 37);
            this.lblNumeroDeSessoes.Name = "lblNumeroDeSessoes";
            this.lblNumeroDeSessoes.Size = new System.Drawing.Size(23, 25);
            this.lblNumeroDeSessoes.TabIndex = 5;
            this.lblNumeroDeSessoes.TabStop = true;
            this.lblNumeroDeSessoes.Text = "2";
            this.lblNumeroDeSessoes.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroLabel2.IsDerivedStyle = true;
            this.metroLabel2.Location = new System.Drawing.Point(222, 14);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(185, 23);
            this.metroLabel2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Número de Organizadores";
            this.metroLabel2.ThemeAuthor = "Taiizor";
            this.metroLabel2.ThemeName = "MetroLight";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroLabel1.IsDerivedStyle = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(164, 23);
            this.metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Número de Sessões";
            this.metroLabel1.ThemeAuthor = "Taiizor";
            this.metroLabel1.ThemeName = "MetroLight";
            // 
            // foreverGroupBox1
            // 
            this.foreverGroupBox1.ArrowColorF = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.foreverGroupBox1.ArrowColorH = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.foreverGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.foreverGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.foreverGroupBox1.Controls.Add(this.materialListViewSessoes);
            this.foreverGroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverGroupBox1.Location = new System.Drawing.Point(23, 285);
            this.foreverGroupBox1.Name = "foreverGroupBox1";
            this.foreverGroupBox1.ShowArrow = true;
            this.foreverGroupBox1.ShowText = true;
            this.foreverGroupBox1.Size = new System.Drawing.Size(898, 245);
            this.foreverGroupBox1.TabIndex = 7;
            this.foreverGroupBox1.Text = "Sessões";
            this.foreverGroupBox1.TextColor = System.Drawing.Color.White;
            // 
            // materialListViewSessoes
            // 
            this.materialListViewSessoes.AutoSizeTable = false;
            this.materialListViewSessoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListViewSessoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListViewSessoes.Depth = 0;
            this.materialListViewSessoes.FullRowSelect = true;
            this.materialListViewSessoes.HideSelection = false;
            this.materialListViewSessoes.Location = new System.Drawing.Point(25, 42);
            this.materialListViewSessoes.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListViewSessoes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListViewSessoes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialListViewSessoes.MultiSelect = false;
            this.materialListViewSessoes.Name = "materialListViewSessoes";
            this.materialListViewSessoes.OwnerDraw = true;
            this.materialListViewSessoes.Size = new System.Drawing.Size(846, 176);
            this.materialListViewSessoes.TabIndex = 21;
            this.materialListViewSessoes.UseCompatibleStateImageBehavior = false;
            this.materialListViewSessoes.View = System.Windows.Forms.View.Details;
            // 
            // foreverGroupBox2
            // 
            this.foreverGroupBox2.ArrowColorF = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.foreverGroupBox2.ArrowColorH = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.foreverGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.foreverGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.foreverGroupBox2.Controls.Add(this.materialListViewOrganizadores);
            this.foreverGroupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverGroupBox2.Location = new System.Drawing.Point(23, 536);
            this.foreverGroupBox2.Name = "foreverGroupBox2";
            this.foreverGroupBox2.ShowArrow = true;
            this.foreverGroupBox2.ShowText = true;
            this.foreverGroupBox2.Size = new System.Drawing.Size(446, 212);
            this.foreverGroupBox2.TabIndex = 8;
            this.foreverGroupBox2.Text = "Organizadores";
            this.foreverGroupBox2.TextColor = System.Drawing.Color.White;
            // 
            // materialListViewOrganizadores
            // 
            this.materialListViewOrganizadores.AutoSizeTable = false;
            this.materialListViewOrganizadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListViewOrganizadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListViewOrganizadores.Depth = 0;
            this.materialListViewOrganizadores.FullRowSelect = true;
            this.materialListViewOrganizadores.HideSelection = false;
            this.materialListViewOrganizadores.Location = new System.Drawing.Point(26, 43);
            this.materialListViewOrganizadores.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListViewOrganizadores.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListViewOrganizadores.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialListViewOrganizadores.MultiSelect = false;
            this.materialListViewOrganizadores.Name = "materialListViewOrganizadores";
            this.materialListViewOrganizadores.OwnerDraw = true;
            this.materialListViewOrganizadores.Size = new System.Drawing.Size(387, 139);
            this.materialListViewOrganizadores.TabIndex = 22;
            this.materialListViewOrganizadores.UseCompatibleStateImageBehavior = false;
            this.materialListViewOrganizadores.View = System.Windows.Forms.View.Details;
            // 
            // groupBoxAvaliacoes
            // 
            this.groupBoxAvaliacoes.ArrowColorF = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.groupBoxAvaliacoes.ArrowColorH = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.groupBoxAvaliacoes.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAvaliacoes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.groupBoxAvaliacoes.Controls.Add(this.materialListViewAvaliacoes);
            this.groupBoxAvaliacoes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAvaliacoes.Location = new System.Drawing.Point(475, 536);
            this.groupBoxAvaliacoes.Name = "groupBoxAvaliacoes";
            this.groupBoxAvaliacoes.ShowArrow = true;
            this.groupBoxAvaliacoes.ShowText = true;
            this.groupBoxAvaliacoes.Size = new System.Drawing.Size(446, 212);
            this.groupBoxAvaliacoes.TabIndex = 9;
            this.groupBoxAvaliacoes.Text = "Avaliações";
            this.groupBoxAvaliacoes.TextColor = System.Drawing.Color.White;
            this.groupBoxAvaliacoes.Visible = false;
            // 
            // materialListViewAvaliacoes
            // 
            this.materialListViewAvaliacoes.AutoSizeTable = false;
            this.materialListViewAvaliacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListViewAvaliacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListViewAvaliacoes.Depth = 0;
            this.materialListViewAvaliacoes.FullRowSelect = true;
            this.materialListViewAvaliacoes.HideSelection = false;
            this.materialListViewAvaliacoes.Location = new System.Drawing.Point(26, 43);
            this.materialListViewAvaliacoes.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListViewAvaliacoes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListViewAvaliacoes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialListViewAvaliacoes.MultiSelect = false;
            this.materialListViewAvaliacoes.Name = "materialListViewAvaliacoes";
            this.materialListViewAvaliacoes.OwnerDraw = true;
            this.materialListViewAvaliacoes.Size = new System.Drawing.Size(387, 139);
            this.materialListViewAvaliacoes.TabIndex = 22;
            this.materialListViewAvaliacoes.UseCompatibleStateImageBehavior = false;
            this.materialListViewAvaliacoes.View = System.Windows.Forms.View.Details;
            // 
            // FrmEventoDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 760);
            this.Controls.Add(this.groupBoxAvaliacoes);
            this.Controls.Add(this.foreverGroupBox2);
            this.Controls.Add(this.foreverGroupBox1);
            this.Controls.Add(this.materialCard4);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.hopeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1032);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "FrmEventoDetalhes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEventoDetalhes";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.foreverGroupBox1.ResumeLayout(false);
            this.foreverGroupBox2.ResumeLayout(false);
            this.groupBoxAvaliacoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MetroLabel lblDescricao;
        private ReaLTaiizor.Controls.BigLabel lblNome;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.BigLabel lblDescricaoTipoEvento;
        private ReaLTaiizor.Controls.MaterialCard materialCard3;
        private ReaLTaiizor.Controls.MaterialCard materialCard4;
        private ReaLTaiizor.Controls.NightLinkLabel lblNumeroDeOrganizadores;
        private ReaLTaiizor.Controls.NightLinkLabel lblNumeroDeSessoes;
        private ReaLTaiizor.Controls.MetroLabel metroLabel2;
        private ReaLTaiizor.Controls.MetroLabel metroLabel1;
        private ReaLTaiizor.Controls.MetroLabel metroLabel3;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox2;
        private ReaLTaiizor.Controls.MaterialListView materialListViewSessoes;
        private ReaLTaiizor.Controls.MaterialListView materialListViewOrganizadores;
        private ReaLTaiizor.Controls.ForeverGroupBox groupBoxAvaliacoes;
        private ReaLTaiizor.Controls.MaterialListView materialListViewAvaliacoes;
    }
}