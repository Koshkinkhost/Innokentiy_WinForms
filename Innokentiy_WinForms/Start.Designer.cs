namespace Innokentiy_WinForms
{
    partial class Start
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
            progressBar_health = new ProgressBar();
            label_health = new Label();
            label_money = new Label();
            label_moneyCount = new Label();
            button_shop = new Button();
            button_fight = new Button();
            button_inventory = new Button();
            label1 = new Label();
            label_sel_weapon = new Label();
            label_potion = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // progressBar_health
            // 
            progressBar_health.Location = new Point(682, 16);
            progressBar_health.Margin = new Padding(3, 4, 3, 4);
            progressBar_health.Maximum = 500;
            progressBar_health.Name = "progressBar_health";
            progressBar_health.Size = new Size(296, 51);
            progressBar_health.TabIndex = 0;
            // 
            // label_health
            // 
            label_health.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_health.Location = new Point(519, 16);
            label_health.Name = "label_health";
            label_health.Size = new Size(140, 51);
            label_health.TabIndex = 1;
            label_health.Text = "Здоровье";
            label_health.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_money
            // 
            label_money.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_money.Location = new Point(533, 104);
            label_money.Name = "label_money";
            label_money.Size = new Size(126, 51);
            label_money.TabIndex = 2;
            label_money.Text = "Деньги";
            label_money.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_moneyCount
            // 
            label_moneyCount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_moneyCount.Location = new Point(682, 104);
            label_moneyCount.Name = "label_moneyCount";
            label_moneyCount.Size = new Size(102, 51);
            label_moneyCount.TabIndex = 3;
            label_moneyCount.Text = "0";
            label_moneyCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button_shop
            // 
            button_shop.Font = new Font("Microsoft Sans Serif", 15.75F);
            button_shop.Location = new Point(38, 559);
            button_shop.Margin = new Padding(3, 4, 3, 4);
            button_shop.Name = "button_shop";
            button_shop.Size = new Size(142, 61);
            button_shop.TabIndex = 4;
            button_shop.Text = "Магазин";
            button_shop.UseVisualStyleBackColor = true;
            button_shop.Click += button1_Click;
            // 
            // button_fight
            // 
            button_fight.Font = new Font("Microsoft Sans Serif", 15.75F);
            button_fight.Location = new Point(231, 559);
            button_fight.Margin = new Padding(3, 4, 3, 4);
            button_fight.Name = "button_fight";
            button_fight.Size = new Size(168, 61);
            button_fight.TabIndex = 5;
            button_fight.Text = "Сражаться";
            button_fight.UseVisualStyleBackColor = true;
            // 
            // button_inventory
            // 
            button_inventory.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_inventory.Location = new Point(446, 559);
            button_inventory.Margin = new Padding(3, 4, 3, 4);
            button_inventory.Name = "button_inventory";
            button_inventory.Size = new Size(175, 61);
            button_inventory.TabIndex = 6;
            button_inventory.Text = "inventory";
            button_inventory.UseVisualStyleBackColor = true;
            button_inventory.Click += button_inventory_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(387, 183);
            label1.Name = "label1";
            label1.Size = new Size(272, 51);
            label1.TabIndex = 7;
            label1.Text = "Выбранное оружие";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_sel_weapon
            // 
            label_sel_weapon.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_sel_weapon.Location = new Point(682, 183);
            label_sel_weapon.Name = "label_sel_weapon";
            label_sel_weapon.Size = new Size(272, 51);
            label_sel_weapon.TabIndex = 8;
            label_sel_weapon.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_potion
            // 
            label_potion.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_potion.Location = new Point(682, 257);
            label_potion.Name = "label_potion";
            label_potion.Size = new Size(272, 51);
            label_potion.TabIndex = 10;
            label_potion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(387, 257);
            label3.Name = "label3";
            label3.Size = new Size(272, 51);
            label3.TabIndex = 9;
            label3.Text = "Выбранное зелье";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 704);
            Controls.Add(label_potion);
            Controls.Add(label3);
            Controls.Add(label_sel_weapon);
            Controls.Add(label1);
            Controls.Add(button_inventory);
            Controls.Add(button_fight);
            Controls.Add(button_shop);
            Controls.Add(label_moneyCount);
            Controls.Add(label_money);
            Controls.Add(label_health);
            Controls.Add(progressBar_health);
            Name = "Start";
            Text = "Form1";
            Load += Start_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar_health;
        private Label label_health;
        private Label label_money;
        private Label label_moneyCount;
        private Button button_shop;
        private Button button_fight;
        private Button button_inventory;
        private Label label1;
        private Label label_sel_weapon;
        private Label label_potion;
        private Label label3;
    }
}
