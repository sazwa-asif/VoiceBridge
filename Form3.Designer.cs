namespace TESTT
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(50, 71);
            label1.Name = "label1";
            label1.Size = new Size(376, 61);
            label1.TabIndex = 0;
            label1.Text = "GET STARTED!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(50, 191);
            label2.Name = "label2";
            label2.Size = new Size(204, 43);
            label2.TabIndex = 1;
            label2.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(50, 342);
            label3.Name = "label3";
            label3.Size = new Size(182, 38);
            label3.TabIndex = 2;
            label3.Text = "PASSWORD";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(255, 128, 0);
            textBox1.Location = new Point(142, 254);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 47);
            textBox1.TabIndex = 3;
            textBox1.MouseHover += textBox1_MouseHover;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(255, 128, 0);
            textBox2.Location = new Point(142, 416);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 54);
            textBox2.TabIndex = 4;
            textBox2.MouseHover += textBox2_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.username;
            pictureBox1.Location = new Point(60, 254);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 47);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.password;
            pictureBox2.Location = new Point(60, 416);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 54);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(142, 559);
            button1.Name = "button1";
            button1.Size = new Size(210, 89);
            button1.TabIndex = 8;
            button1.Text = "SIGN UP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseHover += button1_MouseHover;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(680, 664);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIGNUP";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
    }
}