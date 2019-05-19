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
            this.CreateDocument.Location = new System.Drawing.Point(324, 476);
            this.CreateDocument.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateDocument.Name = "CreateDocument";
            this.CreateDocument.Size = new System.Drawing.Size(226, 71);
            this.CreateDocument.TabIndex = 0;
            this.CreateDocument.Text = "Создать документ";
            this.CreateDocument.UseVisualStyleBackColor = true;
            this.CreateDocument.Click += new System.EventHandler(this.CreateDocument_Click);
            // 
            // TotalPrice
            // 
            this.TotalPrice.Enabled = false;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalPrice.Location = new System.Drawing.Point(15, 493);
            this.TotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(303, 35);
            this.TotalPrice.TabIndex = 1;
            this.TotalPrice.Text = " ";
            // 
            // Cleaner
            // 
            this.Cleaner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cleaner.Location = new System.Drawing.Point(556, 476);
            this.Cleaner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cleaner.Name = "Cleaner";
            this.Cleaner.Size = new System.Drawing.Size(198, 71);
            this.Cleaner.TabIndex = 3;
            this.Cleaner.Text = "Очистить";
            this.Cleaner.UseVisualStyleBackColor = true;
            this.Cleaner.Click += new System.EventHandler(this.Cleaner_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Location = new System.Drawing.Point(0, 15);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(763, 448);
            this.mainPanel.TabIndex = 4;
            // 
            // BascketWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(763, 555);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.Cleaner);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.CreateDocument);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "BascketWin";
            this.Text = "Bascket";
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

