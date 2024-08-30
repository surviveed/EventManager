namespace EventManager.Views.Login
{
    partial class FrmLogin
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
            this.txtSenha = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtEmail = new ReaLTaiizor.Controls.HopeTextBox();
            this.btnEntrar = new ReaLTaiizor.Controls.MaterialButton();
            this.btnCadastrar = new ReaLTaiizor.Controls.MaterialButton();
            this.labelErro = new ReaLTaiizor.Controls.NightLinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            this.foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.BaseColor = System.Drawing.Color.Transparent;
            this.txtSenha.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.txtSenha.BorderColorB = System.Drawing.Color.DarkGray;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(157)))), ((int)(((byte)(223)))));
            this.txtSenha.Hint = "";
            this.txtSenha.Location = new System.Drawing.Point(10, 377);
            this.txtSenha.MaxLength = 128;
            this.txtSenha.Multiline = false;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(281, 38);
            this.txtSenha.TabIndex = 10;
            this.txtSenha.TabStop = false;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BaseColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.txtEmail.BorderColorB = System.Drawing.Color.DarkGray;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(157)))), ((int)(((byte)(223)))));
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(10, 299);
            this.txtEmail.MaxLength = 128;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(281, 38);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TabStop = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrar.AutoSize = false;
            this.btnEntrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEntrar.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEntrar.Depth = 0;
            this.btnEntrar.HighEmphasis = true;
            this.btnEntrar.Icon = null;
            this.btnEntrar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnEntrar.Location = new System.Drawing.Point(182, 521);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEntrar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEntrar.Size = new System.Drawing.Size(108, 36);
            this.btnEntrar.TabIndex = 23;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEntrar.UseAccentColor = false;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadastrar.AutoSize = false;
            this.btnCadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastrar.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCadastrar.Depth = 0;
            this.btnCadastrar.HighEmphasis = true;
            this.btnCadastrar.Icon = null;
            this.btnCadastrar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnCadastrar.Location = new System.Drawing.Point(10, 521);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCadastrar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCadastrar.Size = new System.Drawing.Size(108, 36);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "Cadastrar-se";
            this.btnCadastrar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCadastrar.UseAccentColor = true;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // labelErro
            // 
            this.labelErro.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.labelErro.AutoSize = true;
            this.labelErro.BackColor = System.Drawing.Color.Transparent;
            this.labelErro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelErro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelErro.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.labelErro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.labelErro.Location = new System.Drawing.Point(7, 429);
            this.labelErro.Name = "labelErro";
            this.labelErro.Size = new System.Drawing.Size(0, 15);
            this.labelErro.TabIndex = 25;
            this.labelErro.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EventManager.Properties.Resources.calendar;
            this.pictureBox1.Location = new System.Drawing.Point(62, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EventManager.Properties.Resources.undraw_Booking_re_gw4j1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(297, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 572);
            this.panel1.TabIndex = 8;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = false;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(397, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 7;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(157)))), ((int)(((byte)(253)))));
            this.bigLabel1.Location = new System.Drawing.Point(22, 160);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(237, 45);
            this.bigLabel1.TabIndex = 26;
            this.bigLabel1.Text = "EventManager";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Controls.Add(this.bigLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(10, 23);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(280, 215);
            this.materialCard1.TabIndex = 27;
            // 
            // foxLabel1
            // 
            this.foxLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foxLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(157)))), ((int)(((byte)(253)))));
            this.foxLabel1.Location = new System.Drawing.Point(8, 265);
            this.foxLabel1.Name = "foxLabel1";
            this.foxLabel1.Size = new System.Drawing.Size(90, 28);
            this.foxLabel1.TabIndex = 28;
            this.foxLabel1.Text = "Email";
            // 
            // foxLabel2
            // 
            this.foxLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foxLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(157)))), ((int)(((byte)(253)))));
            this.foxLabel2.Location = new System.Drawing.Point(8, 343);
            this.foxLabel2.Name = "foxLabel2";
            this.foxLabel2.Size = new System.Drawing.Size(90, 28);
            this.foxLabel2.TabIndex = 29;
            this.foxLabel2.Text = "Senha";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 572);
            this.Controls.Add(this.foxLabel2);
            this.Controls.Add(this.foxLabel1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.labelErro);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.HopeTextBox txtSenha;
        private ReaLTaiizor.Controls.HopeTextBox txtEmail;
        private ReaLTaiizor.Controls.MaterialButton btnEntrar;
        private ReaLTaiizor.Controls.MaterialButton btnCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.NightLinkLabel labelErro;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
    }
}