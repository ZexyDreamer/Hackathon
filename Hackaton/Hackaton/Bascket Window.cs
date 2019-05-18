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
                10,
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

        private Dictionary<GroupBox, Product> boxProduct =
            new Dictionary<GroupBox, Product>();

        public GroupBox CreateProductGroupBox(Product product, Point location)
        {
            var groupBox = new GroupBox();

            groupBox.Text = product.Name;
            groupBox.ForeColor = new Color();
            groupBox.Width = 200;
            groupBox.Height = 150;

            #region bg
            var backGround = new PictureBox();
            backGround.Height = groupBox.Height - 15;
            backGround.Width = groupBox.Width;
            backGround.SizeMode = PictureBoxSizeMode.StretchImage;
            backGround.Image = product.Image;
            backGround.Location = new Point(0, 15);
            groupBox.Controls.Add(backGround);
            backGround.SendToBack();
            #endregion

            #region Price
            var priceTextBox = new TextBox();
            priceTextBox.TextAlign = HorizontalAlignment.Center;
            priceTextBox.Width = groupBox.Width - 100;
            priceTextBox.Height = 30;
            priceTextBox.Location = new Point(50, groupBox.Height - 40);
            priceTextBox.Text = $"Price: {product.Price}";
            priceTextBox.Enabled = false;
            groupBox.Controls.Add(priceTextBox);
            priceTextBox.BringToFront();
            #endregion

            #region buttonPlus
            var buttonPlus = new PictureBox();
            buttonPlus.BackColor = Color.Transparent;
            buttonPlus.SizeMode = PictureBoxSizeMode.AutoSize;
            buttonPlus.Location = new Point(groupBox.Width - 40, groupBox.Height - 40);
            buttonPlus.Image = new Bitmap(@"C:\Users\dmitr\Desktop\Dima HW\ЯТП_С#\Hackathon\Hackaton\Hackaton\Images\plusButton.png");
            buttonPlus.Click += (sender, e) =>
            {
                product.Count++;
                priceTextBox.Text = $"Price: {product.Price}";
            };
            groupBox.Controls.Add(buttonPlus);
            buttonPlus.BringToFront();
            #endregion

            #region buttonMinus
            var buttonMinus = new PictureBox();
            buttonMinus.BackColor = Color.Transparent;
            buttonMinus.SizeMode = PictureBoxSizeMode.AutoSize;
            buttonMinus.Location = new Point(10, groupBox.Height - 40);
            buttonMinus.Image = new Bitmap(@"C:\Users\dmitr\Desktop\Dima HW\ЯТП_С#\Hackathon\Hackaton\Hackaton\Images\minusButton.png");
            buttonMinus.Click += (sender, e) =>
            {
                product.Count--;
                priceTextBox.Text = $"Price: {product.Price}";
            };
            groupBox.Controls.Add(buttonMinus);
            buttonMinus.BringToFront();
            #endregion

            groupBox.Location = location;
            return groupBox;
        }

        private void CreateDocument_Click(object sender, EventArgs e)
        {

        }

        private void BascketWin_Load(object sender, EventArgs e)
        {

        }
    }
}
