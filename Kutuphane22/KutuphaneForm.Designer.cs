﻿
namespace Kutuphane22
{
    partial class KutuphaneForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiHesabim = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBagisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCikisYap = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.cmbTurler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiKitapOduncAl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKitapImhaEt = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHesabim,
            this.tsmiBagisYap,
            this.tsmiCikisYap});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiHesabim
            // 
            this.tsmiHesabim.Name = "tsmiHesabim";
            this.tsmiHesabim.Size = new System.Drawing.Size(66, 20);
            this.tsmiHesabim.Text = "Hesabım";
            this.tsmiHesabim.Click += new System.EventHandler(this.tsmiHesabim_Click);
            // 
            // tsmiBagisYap
            // 
            this.tsmiBagisYap.Name = "tsmiBagisYap";
            this.tsmiBagisYap.Size = new System.Drawing.Size(69, 20);
            this.tsmiBagisYap.Text = "Bağış Yap";
            this.tsmiBagisYap.Click += new System.EventHandler(this.tsmiBagisYap_Click);
            // 
            // tsmiCikisYap
            // 
            this.tsmiCikisYap.Name = "tsmiCikisYap";
            this.tsmiCikisYap.Size = new System.Drawing.Size(66, 20);
            this.tsmiCikisYap.Text = "Çıkış Yap";
            this.tsmiCikisYap.Click += new System.EventHandler(this.tsmiCikisYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kütüphane";
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(12, 60);
            this.dgvKitaplar.MultiSelect = false;
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.ReadOnly = true;
            this.dgvKitaplar.RowHeadersVisible = false;
            this.dgvKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitaplar.Size = new System.Drawing.Size(739, 325);
            this.dgvKitaplar.TabIndex = 2;
            this.dgvKitaplar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvKitaplar_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arama";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(289, 34);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(164, 20);
            this.txtArama.TabIndex = 4;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // cmbTurler
            // 
            this.cmbTurler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurler.FormattingEnabled = true;
            this.cmbTurler.Location = new System.Drawing.Point(630, 34);
            this.cmbTurler.Name = "cmbTurler";
            this.cmbTurler.Size = new System.Drawing.Size(121, 21);
            this.cmbTurler.TabIndex = 5;
            this.cmbTurler.SelectedIndexChanged += new System.EventHandler(this.cmbTurler_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Türler";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKitapOduncAl,
            this.tsmiKitapImhaEt});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // tsmiKitapOduncAl
            // 
            this.tsmiKitapOduncAl.Name = "tsmiKitapOduncAl";
            this.tsmiKitapOduncAl.Size = new System.Drawing.Size(154, 22);
            this.tsmiKitapOduncAl.Text = "Kitap Ödünç Al";
            this.tsmiKitapOduncAl.Click += new System.EventHandler(this.tsmiKitapOduncAl_Click);
            // 
            // tsmiKitapImhaEt
            // 
            this.tsmiKitapImhaEt.Name = "tsmiKitapImhaEt";
            this.tsmiKitapImhaEt.Size = new System.Drawing.Size(180, 22);
            this.tsmiKitapImhaEt.Text = "Kitabı İmha Et";
            this.tsmiKitapImhaEt.Click += new System.EventHandler(this.tsmiKitapImhaEt_Click);
            // 
            // KutuphaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 397);
            this.Controls.Add(this.cmbTurler);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvKitaplar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KutuphaneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KutuphaneForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KutuphaneForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHesabim;
        private System.Windows.Forms.ToolStripMenuItem tsmiBagisYap;
        private System.Windows.Forms.ToolStripMenuItem tsmiCikisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox cmbTurler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiKitapOduncAl;
        private System.Windows.Forms.ToolStripMenuItem tsmiKitapImhaEt;
    }
}