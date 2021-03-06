﻿namespace Ohana3DS_Rebirth
{
    partial class OForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ContentContainer = new System.Windows.Forms.Panel();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PicIcon = new System.Windows.Forms.PictureBox();
            this.BtnMinimize = new System.Windows.Forms.PictureBox();
            this.BtnMinMax = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.ContentContainer.SuspendLayout();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentContainer
            // 
            this.ContentContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ContentContainer.Controls.Add(this.TitleBar);
            this.ContentContainer.Location = new System.Drawing.Point(4, 4);
            this.ContentContainer.MinimumSize = new System.Drawing.Size(128, 64);
            this.ContentContainer.Name = "ContentContainer";
            this.ContentContainer.Size = new System.Drawing.Size(640, 472);
            this.ContentContainer.TabIndex = 0;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.Black;
            this.TitleBar.Controls.Add(this.LblTitle);
            this.TitleBar.Controls.Add(this.PicIcon);
            this.TitleBar.Controls.Add(this.BtnMinimize);
            this.TitleBar.Controls.Add(this.BtnMinMax);
            this.TitleBar.Controls.Add(this.BtnClose);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(640, 20);
            this.TitleBar.TabIndex = 9;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OForm_MouseDown);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(20, 1);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(33, 17);
            this.LblTitle.TabIndex = 5;
            this.LblTitle.Text = "Title";
            this.LblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OForm_MouseDown);
            // 
            // PicIcon
            // 
            this.PicIcon.Location = new System.Drawing.Point(2, 2);
            this.PicIcon.Name = "PicIcon";
            this.PicIcon.Size = new System.Drawing.Size(16, 16);
            this.PicIcon.TabIndex = 4;
            this.PicIcon.TabStop = false;
            this.PicIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OForm_MouseDown);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimize.Image = global::Ohana3DS_Rebirth.Properties.Resources.ui_icon_minimize;
            this.BtnMinimize.Location = new System.Drawing.Point(592, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(16, 20);
            this.BtnMinimize.TabIndex = 3;
            this.BtnMinimize.TabStop = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            this.BtnMinimize.MouseEnter += new System.EventHandler(this.BtnMinimize_MouseEnter);
            this.BtnMinimize.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // BtnMinMax
            // 
            this.BtnMinMax.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinMax.Image = global::Ohana3DS_Rebirth.Properties.Resources.ui_icon_maximize;
            this.BtnMinMax.Location = new System.Drawing.Point(608, 0);
            this.BtnMinMax.Name = "BtnMinMax";
            this.BtnMinMax.Size = new System.Drawing.Size(16, 20);
            this.BtnMinMax.TabIndex = 2;
            this.BtnMinMax.TabStop = false;
            this.BtnMinMax.Click += new System.EventHandler(this.BtnMinMax_Click);
            this.BtnMinMax.MouseEnter += new System.EventHandler(this.BtnMinMax_MouseEnter);
            this.BtnMinMax.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.Image = global::Ohana3DS_Rebirth.Properties.Resources.ui_icon_close;
            this.BtnClose.Location = new System.Drawing.Point(624, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(16, 20);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.BtnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.BtnClose.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // OForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(648, 480);
            this.Controls.Add(this.ContentContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(128, 64);
            this.Name = "OForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Título";
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.OForm_Layout);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OForm_MouseDown);
            this.ContentContainer.ResumeLayout(false);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnMinimize;
        private System.Windows.Forms.PictureBox BtnMinMax;
        private System.Windows.Forms.PictureBox BtnClose;
        protected System.Windows.Forms.Panel ContentContainer;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox PicIcon;
    }
}

