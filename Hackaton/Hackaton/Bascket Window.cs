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
    public partial class BascketWin : Form
    {
        public BascketWin()
        {
            InitializeComponent();
            var p = new Product(new Bitmap(@"C:\Users\dmitr\Desktop\Dima HW\ЯТП_С#\Hackathon\Hackaton\Hackaton\Images\Gazon.jpeg"),
                100,
                null,
                "Газон",
                null,
                "газон обыкновенный");
            Controls.Add(CreateProductGroupBox(p, new Point(20, 20)));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public GroupBox CreateProductGroupBox(Product product, Point location)
        {
            var groupBox = new GroupBox();
            groupBox.Text = product.Name;
            groupBox.ForeColor = new Color();
            groupBox.Width = 200;
            groupBox.Height = 150;

            #region picture
            var pictureBox = new PictureBox();
            pictureBox.Height = groupBox.Height - 15;
            pictureBox.Width = groupBox.Width;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = product.Image;
            pictureBox.Location = new Point(0, 15);
            #endregion

            //var buttonPlus = new Button();
            //buttonPlus;

            groupBox.Controls.Add(pictureBox);
            groupBox.Location = location;
            return groupBox;
        }

        private void CreateDocument_Click(object sender, EventArgs e)
        {

        }
    }
}
