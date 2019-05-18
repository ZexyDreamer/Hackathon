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
            DoubleBuffered = true;
            InitializeComponent();
            CreatePoducts();
        }

        private Dictionary<GroupBox, Product> boxProduct =
            new Dictionary<GroupBox, Product>();

        public GroupBox CreateProductGroupBox(Product product, Point location)
        {
            var groupBox = new GroupBox();
            boxProduct[groupBox] = product;

            groupBox.Text = product.Name;
            groupBox.ForeColor = new Color();

            groupBox.Width = (ClientSize.Width - 60) / 2;
            groupBox.Height = (int)(groupBox.Width / Math.Sqrt(2));

            #region bg
            var backGround = new PictureBox();
            backGround.Height = groupBox.Height - 15;
            backGround.Width = groupBox.Width;
            backGround.SizeMode = PictureBoxSizeMode.StretchImage;
            backGround.Image = product.Image;
            backGround.Location = new Point(0, 15);
            backGround.Click += (sender, e) =>
            {
                new Description(product.Description).Show();

            };
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
                RefreshTotalPrice();
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
                if (product.Count > 0)
                    product.Count--;
                priceTextBox.Text = $"Price: {product.Price}";
                RefreshTotalPrice();
            };
            groupBox.Controls.Add(buttonMinus);
            buttonMinus.BringToFront();
            #endregion

            #region buttonDelete
            var buttonDelete = new PictureBox();
            buttonDelete.BackColor = Color.Transparent;
            buttonDelete.SizeMode = PictureBoxSizeMode.AutoSize;
            buttonDelete.Location = new Point(groupBox.Width - 40, 25);
            buttonDelete.Image = new Bitmap(@"C:\Users\dmitr\Desktop\Dima HW\ЯТП_С#\Hackathon\Hackaton\Hackaton\Images\deleteButton.png");
            buttonDelete.Click += (sender, e) =>
            {
                Bascket.Products.Remove(boxProduct[groupBox]);
                boxProduct.Remove(groupBox);
                mainPanel.Controls.Remove(groupBox);
                RefreshProducts();
                RefreshTotalPrice();
            };
            groupBox.Controls.Add(buttonDelete);
            buttonDelete.BringToFront();
            #endregion

            groupBox.Location = location;
            return groupBox;
        }

        private void RefreshProducts()
        {
            int i = 0;
            mainPanel.Controls.Clear();
            foreach (var pair in boxProduct)
            {
                pair.Key.Location = GetLocation(i);
                mainPanel.Controls.Add(pair.Key);
                i++;
            }
            Validate();
        }

        public void CreatePoducts()
        {
            for (int i = 0; i < Bascket.Products.Count; i++)
            {
                mainPanel.Controls.Add(CreateProductGroupBox(Bascket.Products[i], GetLocation(i)));
            }
            RefreshTotalPrice();
        }

        private Point GetLocation(int i)
        {
            int width = (ClientSize.Width - 60) / 2;
            int height = (int)(width / Math.Sqrt(2));
            if (i == 0)
                return new Point(20, 0);
            if (i == 1)
                return new Point(40 + width, 0);
            var p = new Point(0, height + 20);
            var res = GetLocation(i - 2);
            res.Offset(p);
            return res;
        }

        private void RefreshTotalPrice()
        {
            TotalPrice.Text = $"Total Price: {Bascket.Price}";
        }

        private void Cleaner_Click(object sender, EventArgs e)
        {
            foreach (var pair in boxProduct)
            {
                mainPanel.Controls.Remove(pair.Key);
            }
            Bascket.Products.Clear();
            RefreshTotalPrice();
            boxProduct.Clear();
            Validate(); 
        }
    }
}
