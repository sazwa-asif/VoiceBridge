namespace TESTT
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(255, 128, 0);
            textBox1.Location = new Point(235, 537);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 46);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(101, 342);
            label1.Name = "label1";
            label1.Size = new Size(540, 85);
            label1.TabIndex = 1;
            label1.Text = "LOGIN TO PLAY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(118, 477);
            label2.Name = "label2";
            label2.Size = new Size(183, 38);
            label2.TabIndex = 2;
            label2.Text = "USERNAME";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.username;
            pictureBox1.Location = new Point(128, 537);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 45);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(255, 128, 0);
            textBox2.Location = new Point(235, 709);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 46);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.MouseHover += textBox2_MouseHover;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.password;
            pictureBox2.Location = new Point(128, 709);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 51);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(118, 638);
            label3.Name = "label3";
            label3.Size = new Size(182, 38);
            label3.TabIndex = 6;
            label3.Text = "PASSWORD";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(192, 852);
            button1.Name = "button1";
            button1.Size = new Size(266, 65);
            button1.TabIndex = 8;
            button1.Text = "CLICK TO PLAY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(118, 966);
            label4.Name = "label4";
            label4.Size = new Size(203, 25);
            label4.TabIndex = 9;
            label4.Text = "Don't have an account?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(363, 966);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 10;
            label5.Text = "Register Here";
            label5.Click += label5_Click;
            label5.MouseHover += label5_MouseHover;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1024);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
    }
}