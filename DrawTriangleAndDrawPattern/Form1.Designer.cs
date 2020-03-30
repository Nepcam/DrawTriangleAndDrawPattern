namespace DrawTriangleAndDrawPattern
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDrawTriangle = new System.Windows.Forms.Button();
            this.buttonDrawPattern = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 366);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDrawTriangle
            // 
            this.buttonDrawTriangle.Location = new System.Drawing.Point(24, 392);
            this.buttonDrawTriangle.Name = "buttonDrawTriangle";
            this.buttonDrawTriangle.Size = new System.Drawing.Size(153, 23);
            this.buttonDrawTriangle.TabIndex = 1;
            this.buttonDrawTriangle.Text = "Draw Triangle";
            this.buttonDrawTriangle.UseVisualStyleBackColor = true;
            // 
            // buttonDrawPattern
            // 
            this.buttonDrawPattern.Location = new System.Drawing.Point(333, 392);
            this.buttonDrawPattern.Name = "buttonDrawPattern";
            this.buttonDrawPattern.Size = new System.Drawing.Size(153, 23);
            this.buttonDrawPattern.TabIndex = 2;
            this.buttonDrawPattern.Text = "Draw Pattern";
            this.buttonDrawPattern.UseVisualStyleBackColor = true;
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(608, 392);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(153, 23);
            this.buttonErase.TabIndex = 3;
            this.buttonErase.Text = "Erase";
            this.buttonErase.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.buttonDrawPattern);
            this.Controls.Add(this.buttonDrawTriangle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDrawTriangle;
        private System.Windows.Forms.Button buttonDrawPattern;
        private System.Windows.Forms.Button buttonErase;
    }
}

