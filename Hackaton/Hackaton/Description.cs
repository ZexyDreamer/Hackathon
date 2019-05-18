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
    public partial class Description : Form
    {
        public Description(string description)
        {
            InitializeComponent();
            ValidateForm(description);
        }

        private void ValidateForm(string description)
        {
            TextDescription.Location = new Point(0, 0);
            TextDescription.Text = description;
            var lines = description.Split('\n');
            var width = 10;
            var heigth = 25;
            TextDescription.Size = new Size(width * lines.Max(l => l.Length), heigth * lines.Length);

            CloseOK.Location = new Point(0, TextDescription.Height);
            CloseOK.Size = new Size(TextDescription.Width, 30);
            CloseOK.Click += (sender, e) => Close();

            ClientSize = new Size(TextDescription.Width, TextDescription.Height + 30);
        }
    }
}