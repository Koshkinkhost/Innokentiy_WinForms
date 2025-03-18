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
            SuspendLayout();
            // 
            // progressBar_health
            // 
            progressBar_health.Location = new Point(597, 12);
            progressBar_health.Name = "progressBar_health";
            progressBar_health.Size = new Size(259, 38);
            progressBar_health.TabIndex = 0;
            // 
            // label_health
            // 
            label_health.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_health.Location = new Point(489, 12);
            label_health.Name = "label_health";
            label_health.Size = new Size(89, 38);
            label_health.TabIndex = 1;
            label_health.Text = "0";
            label_health.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_money
            // 
            label_money.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_money.Location = new Point(489, 71);
            label_money.Name = "label_money";
            label_money.Size = new Size(89, 38);
            label_money.TabIndex = 2;
            label_money.Text = "Деньги";
            label_money.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_moneyCount
            // 
            label_moneyCount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_moneyCount.Location = new Point(597, 71);
            label_moneyCount.Name = "label_moneyCount";
            label_moneyCount.Size = new Size(89, 38);
            label_moneyCount.TabIndex = 3;
            label_moneyCount.Text = "0";
            label_moneyCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button_shop
            // 
            button_shop.Font = new Font("Microsoft Sans Serif", 15.75F);
            button_shop.Location = new Point(33, 419);
            button_shop.Name = "button_shop";
            button_shop.Size = new Size(111, 46);
            button_shop.TabIndex = 4;
            button_shop.Text = "Магазин";
            button_shop.UseVisualStyleBackColor = true;
            button_shop.Click += button1_Click;
            // 
            // button_fight
            // 
            button_fight.Font = new Font("Microsoft Sans Serif", 15.75F);
            button_fight.Location = new Point(202, 419);
            button_fight.Name = "button_fight";
            button_fight.Size = new Size(135, 46);
            button_fight.TabIndex = 5;
            button_fight.Text = "Сражаться";
            button_fight.UseVisualStyleBackColor = true;
            // 
            // button_inventory
            // 
            button_inventory.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_inventory.Location = new Point(390, 419);
            button_inventory.Name = "button_inventory";
            button_inventory.Size = new Size(153, 46);
            button_inventory.TabIndex = 6;
            button_inventory.Text = "inventory";
            button_inventory.UseVisualStyleBackColor = true;
            button_inventory.Click += button_inventory_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 528);
            Controls.Add(button_inventory);
            Controls.Add(button_fight);
            Controls.Add(button_shop);
            Controls.Add(label_moneyCount);
            Controls.Add(label_money);
            Controls.Add(label_health);
            Controls.Add(progressBar_health);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Start";
            Text = "Form1";
            Load += Form1_Load;
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
    }
}
