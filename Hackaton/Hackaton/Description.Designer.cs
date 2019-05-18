namespace Hackaton
{
    partial class Description
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Description));
            this.CloseOK = new System.Windows.Forms.Button();
            this.TextDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CloseOK
            // 
            this.CloseOK.Location = new System.Drawing.Point(12, 44);
            this.CloseOK.Name = "CloseOK";
            this.CloseOK.Size = new System.Drawing.Size(75, 23);
            this.CloseOK.TabIndex = 0;
            this.CloseOK.Text = "OK";
            this.CloseOK.UseVisualStyleBackColor = true;
            // 
            // TextDescription
            // 
            this.TextDescription.Enabled = false;
            this.TextDescription.Location = new System.Drawing.Point(12, 12);
            this.TextDescription.Multiline = true;
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.Size = new System.Drawing.Size(100, 26);
            this.TextDescription.TabIndex = 1;
            // 
            // Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(176, 76);
            this.Controls.Add(this.TextDescription);
            this.Controls.Add(this.CloseOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Description";
            this.Text = "Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseOK;
        private System.Windows.Forms.TextBox TextDescription;
    }
}