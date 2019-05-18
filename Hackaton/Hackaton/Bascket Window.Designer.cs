namespace Hackaton
{
    partial class BascketWin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BascketWin));
            this.CreateDocument = new System.Windows.Forms.Button();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.Cleaner = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CreateDocument
            // 
            this.CreateDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateDocument.Location = new System.Drawing.Point(523, 305);
            this.CreateDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateDocument.Name = "CreateDocument";
            this.CreateDocument.Size = new System.Drawing.Size(178, 46);
            this.CreateDocument.TabIndex = 0;
            this.CreateDocument.Text = "Create Document";
            this.CreateDocument.UseVisualStyleBackColor = true;
            // 
            // TotalPrice
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(277, 313);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Price: ";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BascketWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CreateDocument);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BascketWin";
            this.Text = "Bascket";
            this.Load += new System.EventHandler(this.BascketWin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateDocument;
        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.Button Cleaner;
        private System.Windows.Forms.Panel mainPanel;
    }
}

