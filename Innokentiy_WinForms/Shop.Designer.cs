namespace Innokentiy_WinForms
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            label_money = new Label();
            panel1 = new Panel();
            button_buy1 = new Button();
            pictureBox_potion1 = new PictureBox();
            panel3 = new Panel();
            button_buy3 = new Button();
            pictureBox_potion3 = new PictureBox();
            pictureBox_potion2 = new PictureBox();
            panel2 = new Panel();
            button_buy2 = new Button();
            button_gun1 = new Button();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            button_gun2 = new Button();
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            button_gun3 = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_potion1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_potion3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_potion2).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label_money
            // 
            label_money.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_money.Location = new Point(713, 9);
            label_money.Name = "label_money";
            label_money.Size = new Size(75, 33);
            label_money.TabIndex = 0;
            label_money.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(button_buy1);
            panel1.Controls.Add(pictureBox_potion1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 67);
            panel1.TabIndex = 1;
            // 
            // button_buy1
            // 
            button_buy1.BackColor = SystemColors.Info;
            button_buy1.Location = new Point(69, 13);
            button_buy1.Name = "button_buy1";
            button_buy1.Size = new Size(124, 41);
            button_buy1.TabIndex = 1;
            button_buy1.Text = "Приобрести(100)";
            button_buy1.UseVisualStyleBackColor = false;
            button_buy1.Click += button_buy1_Click;
            // 
            // pictureBox_potion1
            // 
            pictureBox_potion1.Image = Properties.Resources.potion1;
            pictureBox_potion1.Location = new Point(3, 3);
            pictureBox_potion1.Name = "pictureBox_potion1";
            pictureBox_potion1.Size = new Size(60, 60);
            pictureBox_potion1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_potion1.TabIndex = 0;
            pictureBox_potion1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Info;
            panel3.Controls.Add(button_buy3);
            panel3.Controls.Add(pictureBox_potion3);
            panel3.Location = new Point(12, 158);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 67);
            panel3.TabIndex = 3;
            // 
            // button_buy3
            // 
            button_buy3.BackColor = SystemColors.Info;
            button_buy3.ForeColor = SystemColors.ControlText;
            button_buy3.Location = new Point(69, 13);
            button_buy3.Name = "button_buy3";
            button_buy3.Size = new Size(124, 41);
            button_buy3.TabIndex = 3;
            button_buy3.Text = "Приобрести(120)";
            button_buy3.UseVisualStyleBackColor = false;
            button_buy3.Click += button_buy3_Click;
            // 
            // pictureBox_potion3
            // 
            pictureBox_potion3.Image = (Image)resources.GetObject("pictureBox_potion3.Image");
            pictureBox_potion3.Location = new Point(3, 3);
            pictureBox_potion3.Name = "pictureBox_potion3";
            pictureBox_potion3.Size = new Size(60, 60);
            pictureBox_potion3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_potion3.TabIndex = 0;
            pictureBox_potion3.TabStop = false;
            // 
            // pictureBox_potion2
            // 
            pictureBox_potion2.Image = (Image)resources.GetObject("pictureBox_potion2.Image");
            pictureBox_potion2.Location = new Point(3, 3);
            pictureBox_potion2.Name = "pictureBox_potion2";
            pictureBox_potion2.Size = new Size(60, 60);
            pictureBox_potion2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_potion2.TabIndex = 0;
            pictureBox_potion2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(button_buy2);
            panel2.Controls.Add(pictureBox_potion2);
            panel2.Location = new Point(12, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 67);
            panel2.TabIndex = 2;
            // 
            // button_buy2
            // 
            button_buy2.BackColor = SystemColors.Info;
            button_buy2.Location = new Point(69, 12);
            button_buy2.Name = "button_buy2";
            button_buy2.Size = new Size(124, 41);
            button_buy2.TabIndex = 2;
            button_buy2.Text = "Приобрести(110)";
            button_buy2.UseVisualStyleBackColor = false;
            button_buy2.Click += button_buy2_Click;
            // 
            // button_gun1
            // 
            button_gun1.BackColor = SystemColors.Info;
            button_gun1.ForeColor = SystemColors.ControlText;
            button_gun1.Location = new Point(69, 13);
            button_gun1.Name = "button_gun1";
            button_gun1.Size = new Size(124, 41);
            button_gun1.TabIndex = 3;
            button_gun1.Text = "Приобрести(230)";
            button_gun1.UseVisualStyleBackColor = false;
            button_gun1.Click += button_gun1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Info;
            panel4.Controls.Add(button_gun1);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(245, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(208, 67);
            panel4.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Info;
            panel5.Controls.Add(button_gun2);
            panel5.Controls.Add(pictureBox2);
            panel5.Location = new Point(245, 85);
            panel5.Name = "panel5";
            panel5.Size = new Size(208, 67);
            panel5.TabIndex = 5;
            // 
            // button_gun2
            // 
            button_gun2.BackColor = SystemColors.Info;
            button_gun2.ForeColor = SystemColors.ControlText;
            button_gun2.Location = new Point(69, 13);
            button_gun2.Name = "button_gun2";
            button_gun2.Size = new Size(124, 41);
            button_gun2.TabIndex = 3;
            button_gun2.Text = "Приобрести(240)";
            button_gun2.UseVisualStyleBackColor = false;
            button_gun2.Click += button_gun2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Info;
            panel6.Controls.Add(button_gun3);
            panel6.Controls.Add(pictureBox3);
            panel6.Location = new Point(245, 158);
            panel6.Name = "panel6";
            panel6.Size = new Size(208, 67);
            panel6.TabIndex = 6;
            // 
            // button_gun3
            // 
            button_gun3.BackColor = SystemColors.Info;
            button_gun3.ForeColor = SystemColors.ControlText;
            button_gun3.Location = new Point(69, 13);
            button_gun3.Name = "button_gun3";
            button_gun3.Size = new Size(124, 41);
            button_gun3.TabIndex = 3;
            button_gun3.Text = "Приобрести(250)";
            button_gun3.UseVisualStyleBackColor = false;
            button_gun3.Click += button_gun3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(565, 7);
            label1.Name = "label1";
            label1.Size = new Size(113, 33);
            label1.TabIndex = 7;
            label1.Text = "Кошелёк";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(15, 366);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(160, 34);
            button1.TabIndex = 8;
            button1.Text = "⏎Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Shop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label_money);
            Name = "Shop";
            Text = "Shop";
            Load += Shop_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_potion1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_potion3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_potion2).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_money;
        private Panel panel1;
        private PictureBox pictureBox_potion1;
        private Panel panel3;
        private PictureBox pictureBox_potion3;
        private Button button_buy1;
        private PictureBox pictureBox_potion2;
        private Panel panel2;
        private Button button_buy3;
        private Button button_buy2;
        private Button button_gun1;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Button button_gun2;
        private PictureBox pictureBox2;
        private Panel panel6;
        private Button button_gun3;
        private PictureBox pictureBox3;
        private Label label1;
        private Button button1;
    }
}