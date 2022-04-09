
namespace Text_Box
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
            this.myTextBox1 = new MyText_Box.MyTextBox();
            this.SuspendLayout();
            // 
            // myTextBox1
            // 
            this.myTextBox1.BackColor = System.Drawing.Color.Beige;
            this.myTextBox1.ForeColor = System.Drawing.Color.BlueViolet;
            this.myTextBox1.HasDecimal = true;
            this.myTextBox1.HasNegative = false;
            this.myTextBox1.Location = new System.Drawing.Point(317, 187);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Size = new System.Drawing.Size(100, 20);
            this.myTextBox1.TabIndex = 0;
            this.myTextBox1.TextChanged += new System.EventHandler(this.myTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyText_Box.MyTextBox myTextBox1;
    }
}