using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackaton
{
    public partial class Enter_Form : Form
    {
        public Enter_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "Введите адрес")
            {
                textBox1.Text = "Введите адрес";
                return;
            }
            if (textBox2.Text == "" || textBox2.Text == "Введите путь до файла")
            {
                textBox2.Text = "Введите путь до файла";
                return;
            }
            var text = $"\t\t\t\tПодписной лист\n" +
                $"Сбор подписей жильцов дома по вопросу улучшения двора дома по адресу {textBox1.Text}.\n" +
                $"№ п/п		Ф.И.О. полностью		№ квартиры		Дата		Подпись";
            var file = File.Create(textBox2.Text);
            file.Close();
            File.AppendAllLines(textBox2.Text, text.Split('\n'));
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox2.Text = folderBrowserDialog1.SelectedPath + @"\CollectionSignatures.txt";
        }
    }
}
