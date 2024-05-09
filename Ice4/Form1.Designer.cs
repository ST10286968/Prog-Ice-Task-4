namespace Ice4
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
            button1 = new Button();
            Value1 = new TextBox();
            Value2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Display = new RichTextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(119, 160);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Answer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Value1
            // 
            Value1.Location = new Point(286, 29);
            Value1.Name = "Value1";
            Value1.Size = new Size(125, 27);
            Value1.TabIndex = 1;
            // 
            // Value2
            // 
            Value2.Location = new Point(286, 101);
            Value2.Name = "Value2";
            Value2.Size = new Size(125, 27);
            Value2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 36);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 3;
            label1.Text = "Value 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 104);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 4;
            label2.Text = "Value 2:";
            // 
            // Display
            // 
            Display.Location = new Point(12, 209);
            Display.Name = "Display";
            Display.Size = new Size(505, 103);
            Display.TabIndex = 6;
            Display.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(302, 160);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 324);
            Controls.Add(button2);
            Controls.Add(Display);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Value2);
            Controls.Add(Value1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Value1;
        private TextBox Value2;
        private Label label1;
        private Label label2;
        private RichTextBox Display;
        private Button button2;
    }
}
