namespace DateTimePicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            buttonSetMin = new Button();
            buttonSetMax = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // buttonSetMin
            // 
            buttonSetMin.Location = new Point(12, 44);
            buttonSetMin.Name = "buttonSetMin";
            buttonSetMin.Size = new Size(75, 23);
            buttonSetMin.TabIndex = 1;
            buttonSetMin.Text = "Set Min";
            buttonSetMin.UseVisualStyleBackColor = true;
            buttonSetMin.Click += buttonSetMin_Click;
            // 
            // buttonSetMax
            // 
            buttonSetMax.Location = new Point(93, 44);
            buttonSetMax.Name = "buttonSetMax";
            buttonSetMax.Size = new Size(75, 23);
            buttonSetMax.TabIndex = 2;
            buttonSetMax.Text = "Set Max";
            buttonSetMax.UseVisualStyleBackColor = true;
            buttonSetMax.Click += buttonSetMax_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 73);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 154);
            textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 258);
            Controls.Add(textBox1);
            Controls.Add(buttonSetMax);
            Controls.Add(buttonSetMin);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Button buttonSetMin;
        private Button buttonSetMax;
        private TextBox textBox1;
    }
}
