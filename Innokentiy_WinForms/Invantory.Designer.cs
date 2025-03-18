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
            comboBox_items = new ComboBox();
            button_use = new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // comboBox_items
            // 
            comboBox_items.FormattingEnabled = true;
            comboBox_items.Location = new Point(302, 159);
            comboBox_items.Name = "comboBox_items";
            comboBox_items.Size = new Size(191, 23);
            comboBox_items.TabIndex = 1;
            // 
            // button_use
            // 
            button_use.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_use.Location = new Point(313, 222);
            button_use.Name = "button_use";
            button_use.Size = new Size(165, 43);
            button_use.TabIndex = 2;
            button_use.Text = "Использовать";
            button_use.UseVisualStyleBackColor = true;
            button_use.Click += button_use_Click;
            // 
            // Invantory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_use);
            Controls.Add(comboBox_items);
            Name = "Invantory";
            Text = "Invantory";
            Load += Invantory_Load;
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBox_items;
        private Button button_use;
    }
}