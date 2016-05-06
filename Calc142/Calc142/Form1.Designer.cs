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
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.Exp = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Button();
            this.Tangent = new System.Windows.Forms.Button();
            this.Logorifm = new System.Windows.Forms.Button();
            this.Log10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextIn1
            // 
            this.TextIn1.Location = new System.Drawing.Point(12, 13);
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
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(14, 101);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(40, 30);
            this.Sin.TabIndex = 8;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.OneClick);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(60, 101);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(40, 30);
            this.Cos.TabIndex = 9;
            this.Cos.Text = "cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.OneClick);
            // 
            // Power
            // 
            this.Power.Location = new System.Drawing.Point(106, 101);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(40, 30);
            this.Power.TabIndex = 10;
            this.Power.Text = "^";
            this.Power.UseVisualStyleBackColor = true;
            this.Power.Click += new System.EventHandler(this.Click);
            // 
            // Exp
            // 
            this.Exp.Location = new System.Drawing.Point(152, 101);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(40, 30);
            this.Exp.TabIndex = 11;
            this.Exp.Text = "exp";
            this.Exp.UseVisualStyleBackColor = true;
            this.Exp.Click += new System.EventHandler(this.OneClick);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(198, 101);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(40, 30);
            this.Sqrt.TabIndex = 12;
            this.Sqrt.Text = "√";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.OneClick);
            // 
            // Percent
            // 
            this.Percent.Location = new System.Drawing.Point(14, 137);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(40, 30);
            this.Percent.TabIndex = 14;
            this.Percent.Text = "%";
            this.Percent.UseVisualStyleBackColor = true;
            this.Percent.Click += new System.EventHandler(this.Click);
            // 
            // Tangent
            // 
            this.Tangent.Location = new System.Drawing.Point(60, 137);
            this.Tangent.Name = "Tangent";
            this.Tangent.Size = new System.Drawing.Size(40, 30);
            this.Tangent.TabIndex = 15;
            this.Tangent.Text = "tan";
            this.Tangent.UseVisualStyleBackColor = true;
            this.Tangent.Click += new System.EventHandler(this.OneClick);
            // 
            // Logorifm
            // 
            this.Logorifm.Location = new System.Drawing.Point(106, 137);
            this.Logorifm.Name = "Logorifm";
            this.Logorifm.Size = new System.Drawing.Size(40, 30);
            this.Logorifm.TabIndex = 16;
            this.Logorifm.Text = "log";
            this.Logorifm.UseVisualStyleBackColor = true;
            this.Logorifm.Click += new System.EventHandler(this.Click);
            // 
            // Log10
            // 
            this.Log10.Location = new System.Drawing.Point(152, 137);
            this.Log10.Name = "Log10";
            this.Log10.Size = new System.Drawing.Size(40, 30);
            this.Log10.TabIndex = 17;
            this.Log10.Text = "ln10";
            this.Log10.UseVisualStyleBackColor = true;
            this.Log10.Click += new System.EventHandler(this.OneClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Log10);
            this.Controls.Add(this.Logorifm);
            this.Controls.Add(this.Tangent);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
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
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Power;
        private System.Windows.Forms.Button Exp;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Percent;
        private System.Windows.Forms.Button Tangent;
        private System.Windows.Forms.Button Logorifm;
        private System.Windows.Forms.Button Log10;
    }
}

