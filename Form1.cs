using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeriYapilariProjesi
{
    public partial class Form1 : Form
    {
        private class TreeNode
        {
            public int Data;
            public TreeNode Left;
            public TreeNode Right;
        }

        private TreeNode root;

        public Form1()
        {
            InitializeComponent();
     
            root = null;
           
            // Form yüklenirken otomatik boyutlandırma özelliklerini ayarla
            this.Load += Form1_Load;
        }
      
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // Form içindeki panelin otomatik boyutlandırma özelliklerini ayarla
            panelAgac.AutoSize = true;
            panelAgac.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEkle.Text))
                return;

            int sayi = int.Parse(textBoxEkle.Text);
            Ekle(sayi, ref root);

            // Paneli temizle ve tüm düğümleri tekrar ekle
            panelAgac.Controls.Clear();
            DugumleriFormaEkle(root, 400, 30, panelAgac);

            textBoxEkle.Clear();
        }

        private void Ekle(int sayi, ref TreeNode node)
        {
            if (node == null)
            {
                node = new TreeNode { Data = sayi };
            }
            else if (sayi < node.Data)
            {
                Ekle(sayi, ref node.Left);
            }
            else if (sayi > node.Data)
            {
                Ekle(sayi, ref node.Right);
            }
        }

        private void AraButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAra.Text))
                return;

            int arananSayi = int.Parse(textBoxAra.Text);
            TreeNode bulunanDugum = Ara(arananSayi, root);
            RenkDegistir(bulunanDugum, Color.Red);
            textBoxAra.Clear();
        }

        private TreeNode Ara(int arananSayi, TreeNode node)
        {
            if (node == null || node.Data == arananSayi)
            {
                if (node != null)
                    MessageBox.Show($"{arananSayi} bulundu!");
                else
                    MessageBox.Show($"{arananSayi} bulunamadı!");

                return node;
            }

            if (arananSayi < node.Data)
            {
                return Ara(arananSayi, node.Left);
            }
            else
            {
                return Ara(arananSayi, node.Right);
            }
        }

        private void MinimumBulButton_Click(object sender, EventArgs e)
        {
            TreeNode minimumDugum = MinimumBul(root);
            if (minimumDugum != null)
            {
                textBoxMinimum.Text = minimumDugum.Data.ToString();
                RenkDegistir(minimumDugum, Color.Green);
            }
            else
            {
                textBoxMinimum.Text = "Ağaç boş";
            }
        }

        private TreeNode MinimumBul(TreeNode node)
        {
            if (node == null)
                return null;

            while (node.Left != null)
                node = node.Left;

            return node;
        }

        private void MaksimumBulButton_Click(object sender, EventArgs e)
        {
            TreeNode maksimumDugum = MaksimumBul(root);
            if (maksimumDugum != null)
            {
                textBoxMaksimum.Text = maksimumDugum.Data.ToString();
                RenkDegistir(maksimumDugum, Color.Blue);
            }
            else
            {
                textBoxMaksimum.Text = "Ağaç boş";
            }
        }

        private TreeNode MaksimumBul(TreeNode node)
        {
            if (node == null)
                return null;

            while (node.Right != null)
                node = node.Right;

            return node;
        }

        private void InorderButton_Click(object sender, EventArgs e)
        {
            textBoxGezinmeSonuc.Text = "Inorder: " + Inorder(root);
        }

        private string Inorder(TreeNode node)
        {
            if (node == null)
                return "";

            return Inorder(node.Left) + node.Data + " " + Inorder(node.Right);
        }

        private void PreorderButton_Click(object sender, EventArgs e)
        {
            textBoxGezinmeSonuc.Text = "Preorder: " + Preorder(root);
        }

        private string Preorder(TreeNode node)
        {
            if (node == null)
                return "";

            return node.Data + " " + Preorder(node.Left) + Preorder(node.Right);
        }

        private void PostorderButton_Click(object sender, EventArgs e)
        {
            textBoxGezinmeSonuc.Text = "Postorder: " + Postorder(root);
        }

        private string Postorder(TreeNode node)
        {
            if (node == null)
                return "";

            return Postorder(node.Left) + Postorder(node.Right) + node.Data + " ";
        }

        private void DugumleriFormaEkle(TreeNode node, int x, int y, Panel panel)
        {
            if (node != null)
            {
                Label label = new Label();
                label.Text = node.Data.ToString();
                label.AutoSize = true;
                label.Location = new Point(x, y);
                panel.Controls.Add(label);

                int solX = x - 30;
                int sagX = x + 30;
                DugumleriFormaEkle(node.Left, solX, y + 60, panel);
                DugumleriFormaEkle(node.Right, sagX, y + 60, panel);

                // Panelin otomatik boyutlandırma özelliğini güncelle
                panelAgac.PerformLayout();
            }
        }

        private void TemizleButton_Click(object sender, EventArgs e)
        {
            root = null;
            panelAgac.Controls.Clear();
            textBoxMinimum.Clear();
            textBoxMaksimum.Clear();
            textBoxGezinmeSonuc.Clear();
        }

        private void RenkDegistir(TreeNode node, Color color)
        {
            if (node != null)
            {
                foreach (Control control in panelAgac.Controls)
                {
                    if (control is Label label && label.Text == node.Data.ToString())
                    {
                        label.ForeColor = color;
                        break;
                    }
                }
            }
        }
    }
}
