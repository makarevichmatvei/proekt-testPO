namespace Calc142
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
            this.TextIn1 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.TextIn2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextIn1
            // 
            this.TextIn1.Location = new System.Drawing.Point(13, 13);
            this.TextIn1.Name = "TextIn1";
            this.TextIn1.Size = new System.Drawing.Size(100, 20);
            this.TextIn1.TabIndex = 0;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(14, 65);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(30, 30);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(49, 65);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(30, 30);
            this.minus.TabIndex = 3;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(84, 65);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(30, 30);
            this.multiply.TabIndex = 4;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(119, 65);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(30, 30);
            this.divide.TabIndex = 5;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(155, 16);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Result";
            // 
            // TextIn2
            // 
            this.TextIn2.Location = new System.Drawing.Point(13, 39);
            this.TextIn2.Name = "TextIn2";
            this.TextIn2.Size = new System.Drawing.Size(100, 20);
            this.TextIn2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.TextIn2);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.TextIn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextIn1;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox TextIn2;
    }
}

