﻿namespace EventManager.Views.CrudTipoEvento
{
    partial class FrmTipoEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoEvento));
            this.btnDeletar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnEditar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.btnAdicionar = new ReaLTaiizor.Controls.HopeRoundButton();
            this.hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            this.materialListViewTiposEvento = new ReaLTaiizor.Controls.MaterialListView();
            this.txtDescricao = new ReaLTaiizor.Controls.HopeTextBox();
            this.hopeGroupBox1 = new ReaLTaiizor.Controls.HopeGroupBox();
            this.foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
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
            this.btnDeletar.Location = new System.Drawing.Point(677, 567);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnDeletar.Size = new System.Drawing.Size(252, 40);
            this.btnDeletar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnDeletar.TabIndex = 24;
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
            this.btnEditar.Location = new System.Drawing.Point(343, 567);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnEditar.Size = new System.Drawing.Size(252, 40);
            this.btnEditar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnEditar.TabIndex = 23;
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
            this.btnAdicionar.Location = new System.Drawing.Point(9, 567);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnAdicionar.Size = new System.Drawing.Size(252, 40);
            this.btnAdicionar.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnAdicionar.TabIndex = 22;
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
            this.hopeForm1.TabIndex = 21;
            this.hopeForm1.Text = "Tipos de Evento";
            this.hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // materialListViewTiposEvento
            // 
            this.materialListViewTiposEvento.AutoSizeTable = false;
            this.materialListViewTiposEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListViewTiposEvento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListViewTiposEvento.Depth = 0;
            this.materialListViewTiposEvento.FullRowSelect = true;
            this.materialListViewTiposEvento.HideSelection = false;
            this.materialListViewTiposEvento.Location = new System.Drawing.Point(9, 191);
            this.materialListViewTiposEvento.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListViewTiposEvento.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListViewTiposEvento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialListViewTiposEvento.MultiSelect = false;
            this.materialListViewTiposEvento.Name = "materialListViewTiposEvento";
            this.materialListViewTiposEvento.OwnerDraw = true;
            this.materialListViewTiposEvento.Size = new System.Drawing.Size(920, 364);
            this.materialListViewTiposEvento.TabIndex = 26;
            this.materialListViewTiposEvento.UseCompatibleStateImageBehavior = false;
            this.materialListViewTiposEvento.View = System.Windows.Forms.View.Details;
            this.materialListViewTiposEvento.SelectedIndexChanged += new System.EventHandler(this.materialListViewTiposEvento_SelectedIndexChanged);
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
            this.txtDescricao.Location = new System.Drawing.Point(144, 28);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Multiline = false;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.Size = new System.Drawing.Size(182, 34);
            this.txtDescricao.TabIndex = 4;
            this.txtDescricao.TabStop = false;
            this.txtDescricao.UseSystemPasswordChar = false;
            // 
            // hopeGroupBox1
            // 
            this.hopeGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox1.Controls.Add(this.foxLabel1);
            this.hopeGroupBox1.Controls.Add(this.txtDescricao);
            this.hopeGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox1.Location = new System.Drawing.Point(9, 48);
            this.hopeGroupBox1.Name = "hopeGroupBox1";
            this.hopeGroupBox1.ShowText = false;
            this.hopeGroupBox1.Size = new System.Drawing.Size(920, 137);
            this.hopeGroupBox1.TabIndex = 25;
            this.hopeGroupBox1.TabStop = false;
            this.hopeGroupBox1.Text = "hopeGroupBox1";
            this.hopeGroupBox1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // foxLabel1
            // 
            this.foxLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel1.Location = new System.Drawing.Point(27, 38);
            this.foxLabel1.Name = "foxLabel1";
            this.foxLabel1.Size = new System.Drawing.Size(64, 19);
            this.foxLabel1.TabIndex = 5;
            this.foxLabel1.Text = "Descrição";
            // 
            // FrmTipoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 617);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.hopeForm1);
            this.Controls.Add(this.materialListViewTiposEvento);
            this.Controls.Add(this.hopeGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1032);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "FrmTipoEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTipoEventoNovo";
            this.hopeGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.HopeRoundButton btnDeletar;
        private ReaLTaiizor.Controls.HopeRoundButton btnEditar;
        private ReaLTaiizor.Controls.HopeRoundButton btnAdicionar;
        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.MaterialListView materialListViewTiposEvento;
        private ReaLTaiizor.Controls.HopeTextBox txtDescricao;
        private ReaLTaiizor.Controls.HopeGroupBox hopeGroupBox1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
    }
}