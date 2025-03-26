namespace Innokentiy_WinForms
{
    partial class Invantory
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            comboBox_weapons = new ComboBox();
            button_use = new Button();
            button1 = new Button();
            comboBox_potion = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox_filter_weapon = new ComboBox();
            comboBox_filter_potion = new ComboBox();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // comboBox_weapons
            // 
            comboBox_weapons.FormattingEnabled = true;
            comboBox_weapons.Location = new Point(209, 122);
            comboBox_weapons.Name = "comboBox_weapons";
            comboBox_weapons.Size = new Size(305, 23);
            comboBox_weapons.TabIndex = 1;
            // 
            // button_use
            // 
            button_use.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_use.Location = new Point(282, 222);
            button_use.Name = "button_use";
            button_use.Size = new Size(165, 43);
            button_use.TabIndex = 2;
            button_use.Text = "Использовать";
            button_use.UseVisualStyleBackColor = true;
            button_use.Click += button_use_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 405);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(160, 34);
            button1.TabIndex = 3;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox_potion
            // 
            comboBox_potion.FormattingEnabled = true;
            comboBox_potion.Location = new Point(209, 149);
            comboBox_potion.Name = "comboBox_potion";
            comboBox_potion.Size = new Size(305, 23);
            comboBox_potion.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 124);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Оружие";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 155);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Зелье";
            // 
            // comboBox_filter_weapon
            // 
            comboBox_filter_weapon.FormattingEnabled = true;
            comboBox_filter_weapon.Location = new Point(520, 122);
            comboBox_filter_weapon.Name = "comboBox_filter_weapon";
            comboBox_filter_weapon.Size = new Size(85, 23);
            comboBox_filter_weapon.Sorted = true;
            comboBox_filter_weapon.TabIndex = 7;
            comboBox_filter_weapon.SelectedValueChanged += comboBox_filter_weapon_SelectedValueChanged;
            // 
            // comboBox_filter_potion
            // 
            comboBox_filter_potion.FormattingEnabled = true;
            comboBox_filter_potion.Location = new Point(520, 149);
            comboBox_filter_potion.Name = "comboBox_filter_potion";
            comboBox_filter_potion.Size = new Size(85, 23);
            comboBox_filter_potion.TabIndex = 8;
            comboBox_filter_potion.SelectedValueChanged += comboBox_filter_potion_SelectedValueChanged;
            // 
            // Invantory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox_filter_potion);
            Controls.Add(comboBox_filter_weapon);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_potion);
            Controls.Add(button1);
            Controls.Add(button_use);
            Controls.Add(comboBox_weapons);
            Name = "Invantory";
            Text = "Invantory";
            Load += Invantory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBox_weapons;
        private Button button_use;
        private Button button1;
        private ComboBox comboBox_potion;
        private Label label1;
        private Label label2;
        private ComboBox comboBox_filter_weapon;
        private ComboBox comboBox_filter_potion;
    }
}