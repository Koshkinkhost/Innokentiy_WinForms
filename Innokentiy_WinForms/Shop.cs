using Innokentiy_WinForms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innokentiy_WinForms
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }
        public void Add_Gun(int damage, string name, int weight, double price)
        {
            if (GameProvider.hero.Wallet >= price)
            {
                Weapon weapon = new Weapon(damage, weight, price, name);
                GameProvider.hero.Items.Add(weapon);
                GameProvider.hero.Wallet -= price;
                label_money.Text = (int.Parse(label_money.Text) - price).ToString();

            }
            else
            {
                MessageBox.Show("Недостаточно денег");
            }

        }
        
        public void Buy_Potion(int health, string name, double weight, double price)
        {
            if (GameProvider.hero.Wallet >= price)
            {
                Potion potion = new Potion(health, name, weight, price);
                GameProvider.hero.Items.Add(potion);
                GameProvider.hero.Wallet -= price;
                label_money.Text = (int.Parse(label_money.Text) - price).ToString();
            }
            else
            {
                MessageBox.Show("Недостаточно денег");
            }

        }

        private void Shop_Load(object sender, EventArgs e)
        {
            label_money.Text = GameProvider.hero.Wallet.ToString();
        }

        private void button_buy1_Click(object sender, EventArgs e)
        {
            Buy_Potion(10, "слабое зелье восстановления", 5, 100);
        }

        private void button_buy2_Click(object sender, EventArgs e)
        {
            Buy_Potion(15,"среднее зелье восстановления", 5 ,110);
        }

        private void button_buy3_Click(object sender, EventArgs e)
        {
            Buy_Potion(20, "сильное зелье восстановления", 5, 120);
        }

        private void button_gun1_Click(object sender, EventArgs e)
        {
            Add_Gun(20,"Ak-47", 30, 230);
        }

        private void button_gun2_Click(object sender, EventArgs e)
        {
            Add_Gun(22,"AWP", 30, 240);
        }

        private void button_gun3_Click(object sender, EventArgs e)
        {
            Add_Gun(30, "XSEM", 40, 250);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var result= MessageBox.Show("Уже уходите?","Предупреждение",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                this.Hide();
                Start s = new Start();
                s.Show();
            }
            
        }
    }
}
