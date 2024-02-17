using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeriYapilariProjesi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBoxEkle = new System.Windows.Forms.TextBox();
            this.ekleButton = new System.Windows.Forms.Button();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            this.araButton = new System.Windows.Forms.Button();
            this.minimumBulButton = new System.Windows.Forms.Button();
            this.maksimumBulButton = new System.Windows.Forms.Button();
            this.inorderButton = new System.Windows.Forms.Button();
            this.preorderButton = new System.Windows.Forms.Button();
            this.postorderButton = new System.Windows.Forms.Button();
            this.panelAgac = new System.Windows.Forms.Panel();
            this.textBoxMinimum = new System.Windows.Forms.TextBox();
            this.textBoxMaksimum = new System.Windows.Forms.TextBox();
            this.textBoxGezinmeSonuc = new System.Windows.Forms.TextBox();
            this.temizleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEkle
            // 
            this.textBoxEkle.Location = new System.Drawing.Point(700, 20);
            this.textBoxEkle.Name = "textBoxEkle";
            this.textBoxEkle.Size = new System.Drawing.Size(100, 20);
            this.textBoxEkle.TabIndex = 0;
            // 
            // ekleButton
            // 
            this.ekleButton.Location = new System.Drawing.Point(600, 20);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(80, 25);
            this.ekleButton.TabIndex = 1;
            this.ekleButton.Text = "Ekle";
            this.ekleButton.Click += new System.EventHandler(this.EkleButton_Click);
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(700, 60);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(100, 20);
            this.textBoxAra.TabIndex = 2;
            // 
            // araButton
            // 
            this.araButton.Location = new System.Drawing.Point(600, 65);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(80, 25);
            this.araButton.TabIndex = 3;
            this.araButton.Text = "Ara";
            this.araButton.Click += new System.EventHandler(this.AraButton_Click);
            // 
            // minimumBulButton
            // 
            this.minimumBulButton.Location = new System.Drawing.Point(600, 110);
            this.minimumBulButton.Name = "minimumBulButton";
            this.minimumBulButton.Size = new System.Drawing.Size(120, 25);
            this.minimumBulButton.TabIndex = 4;
            this.minimumBulButton.Text = "Minimum Bul";
            this.minimumBulButton.Click += new System.EventHandler(this.MinimumBulButton_Click);
            // 
            // maksimumBulButton
            // 
            this.maksimumBulButton.Location = new System.Drawing.Point(600, 155);
            this.maksimumBulButton.Name = "maksimumBulButton";
            this.maksimumBulButton.Size = new System.Drawing.Size(120, 25);
            this.maksimumBulButton.TabIndex = 5;
            this.maksimumBulButton.Text = "Maksimum Bul";
            this.maksimumBulButton.Click += new System.EventHandler(this.MaksimumBulButton_Click);
            // 
            // inorderButton
            // 
            this.inorderButton.Location = new System.Drawing.Point(900, 375);
            this.inorderButton.Name = "inorderButton";
            this.inorderButton.Size = new System.Drawing.Size(120, 25);
            this.inorderButton.TabIndex = 6;
            this.inorderButton.Text = "Inorder";
            this.inorderButton.Click += new System.EventHandler(this.InorderButton_Click);
            // 
            // preorderButton
            // 
            this.preorderButton.Location = new System.Drawing.Point(900, 325);
            this.preorderButton.Name = "preorderButton";
            this.preorderButton.Size = new System.Drawing.Size(120, 25);
            this.preorderButton.TabIndex = 7;
            this.preorderButton.Text = "Preorder";
            this.preorderButton.Click += new System.EventHandler(this.PreorderButton_Click);
            // 
            // postorderButton
            // 
            this.postorderButton.Location = new System.Drawing.Point(900, 275);
            this.postorderButton.Name = "postorderButton";
            this.postorderButton.Size = new System.Drawing.Size(120, 25);
            this.postorderButton.TabIndex = 8;
            this.postorderButton.Text = "Postorder";
            this.postorderButton.Click += new System.EventHandler(this.PostorderButton_Click);
            // 
            // panelAgac
            // 
            this.panelAgac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAgac.Location = new System.Drawing.Point(15, 200);
            this.panelAgac.Name = "panelAgac";
            this.panelAgac.Size = new System.Drawing.Size(800, 400);
            this.panelAgac.AutoScroll = false;
            this.panelAgac.TabIndex = 9;
            
            

            // 
            // textBoxMinimum
            // 
            this.textBoxMinimum.Location = new System.Drawing.Point(725, 110);
            this.textBoxMinimum.Name = "textBoxMinimum";
            this.textBoxMinimum.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinimum.TabIndex = 10;
            // 
            // textBoxMaksimum
            // 
            this.textBoxMaksimum.Location = new System.Drawing.Point(725, 150);
            this.textBoxMaksimum.Name = "textBoxMaksimum";
            this.textBoxMaksimum.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaksimum.TabIndex = 11;
            // 
            // textBoxGezinmeSonuc
            // 
            this.textBoxGezinmeSonuc.Location = new System.Drawing.Point(900, 100);
            this.textBoxGezinmeSonuc.Multiline = true;
            this.textBoxGezinmeSonuc.Name = "textBoxGezinmeSonuc";
            this.textBoxGezinmeSonuc.Size = new System.Drawing.Size(200, 100);
            this.textBoxGezinmeSonuc.TabIndex = 12;
            // 
            // temizleButton
            // 
            this.temizleButton.Location = new System.Drawing.Point(900, 220);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Size = new System.Drawing.Size(120, 25);
            this.temizleButton.TabIndex = 13;
            this.temizleButton.Text = "Temizle";
            this.temizleButton.Click += new System.EventHandler(this.TemizleButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1161, 614);
            this.Controls.Add(this.textBoxEkle);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.minimumBulButton);
            this.Controls.Add(this.maksimumBulButton);
            this.Controls.Add(this.inorderButton);
            this.Controls.Add(this.preorderButton);
            this.Controls.Add(this.postorderButton);
            this.Controls.Add(this.panelAgac);
            this.Controls.Add(this.textBoxMinimum);
            this.Controls.Add(this.textBoxMaksimum);
            this.Controls.Add(this.textBoxGezinmeSonuc);
            this.Controls.Add(this.temizleButton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        
        private TextBox textBoxEkle;
        private TextBox textBoxGezinmeSonuc;
        private TextBox textBoxMaksimum;
        private TextBox textBoxMinimum;
        private Panel panelAgac;
        private Button ekleButton;
        private Button araButton;
        private Button minimumBulButton;
        private Button maksimumBulButton;
        private Button inorderButton;
        private Button preorderButton;
        private Button postorderButton;
        private Button temizleButton;
        private TextBox textBoxAra;
    }
}
