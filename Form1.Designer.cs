namespace TESTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(299, 6);
            label1.Name = "label1";
            label1.Size = new Size(476, 61);
            label1.TabIndex = 0;
            label1.Text = "GUESS THE SOUND";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(849, 31);
            label2.Name = "label2";
            label2.Size = new Size(104, 38);
            label2.TabIndex = 1;
            label2.Text = "SCORE";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.listen1;
            pictureBox1.Location = new Point(259, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(654, 558);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Indigo;
            textBox1.Location = new Point(259, 737);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 55);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Stencil", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Indigo;
            button1.Location = new Point(640, 737);
            button1.Name = "button1";
            button1.Size = new Size(168, 55);
            button1.TabIndex = 4;
            button1.Text = "NEXT";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1077, 843);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GAME SCREEN";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button1;
    }
}
