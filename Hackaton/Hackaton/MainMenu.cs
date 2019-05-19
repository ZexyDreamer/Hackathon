using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackaton
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BascketWin().Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void category1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var point = new Point(30, 15);
            panel1.Controls.Clear();
            foreach (var product in Program.list)
            {
                panel1.Controls.Add(CreateProductGroupBox(product, point));
                if (point.X == 30)
                    point = new Point(point.X + 200, point.Y);
                else
                    point = new Point(30, point.Y + 135);
            }
        }

        public GroupBox CreateProductGroupBox(Product product, Point location)
        {
            var groupBox = new GroupBox();
            groupBox.Text = product.Name;
            groupBox.Width = 150;
            groupBox.Height = 80;
            var pictureBox = new PictureBox();
            pictureBox.Location = new Point(0, 15);
            pictureBox.Height = 70;
            pictureBox.Width = 150;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = product.Image;
            groupBox.Controls.Add(pictureBox);
            var pb2 = new PictureBox();
            pb2.Location = new Point(0, 60);
            pb2.Image = new Bitmap(@"../../Images/plusButton.png");
            pb2.Width = 20;
            pb2.Height = 20;
            pb2.Click += (sender, e) =>
            {
                bool flag = true;
                foreach (var p in Bascket.Products)
                {
                    if (p.Equals(product))
                    {
                        p.Count++;
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    product.Count = 1;
                    Bascket.Products.Add(product);
                }
            };
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            groupBox.Controls.Add(pb2);
            groupBox.Location = location;
            groupBox.Controls[1].BringToFront();
            return groupBox;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void category2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProduct(Categories.BuildingMaterials);
        }

        private void ShowProduct(Categories category)
        {
            var point = new Point(30, 15);
            panel1.Controls.Clear();
            foreach (var product in Program.list)
            {
                if (product.Category.Equals(category))
                {
                    panel1.Controls.Add(CreateProductGroupBox(product, point));
                    if (point.X == 30)
                        point = new Point(point.X + 200, point.Y);
                    else
                        point = new Point(30, point.Y + 135);
                }
            }
        }

        private void category3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProduct(Categories.Tools);
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProduct(Categories.Other);
        }
    }
}
