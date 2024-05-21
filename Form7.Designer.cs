namespace WinFormsApp2
{
    partial class Form7
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 68);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 181);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "ISBN";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(54, 232);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(537, 82);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 6;
            label4.Text = "Author";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(537, 117);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(537, 181);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 8;
            label5.Text = "Publication Year";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(537, 232);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(195, 383);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 301);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 13;
            label3.Text = "Edition";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(54, 346);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(540, 296);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 15;
            label6.Text = "user id";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(540, 336);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 16;
            // 
            // button2
            // 
            button2.Location = new Point(481, 383);
            button2.Name = "button2";
            button2.Size = new Size(112, 29);
            button2.TabIndex = 17;
            button2.Text = "Return to list";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Button button1;
        private Label label3;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox6;
        private Button button2;
    }
}