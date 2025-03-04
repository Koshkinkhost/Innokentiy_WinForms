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
        public void Add_Gun(int damage, int weight, double price)
        {
            if (GameProvider.hero.Wallet >= price)
            {
                Weapon weapon = new Weapon(damage, weight, price);
                GameProvider.hero.Items.Add(weapon);
                GameProvider.hero.Wallet -= price;
                label_money.Text = (int.Parse(label_money.Text) - weapon.Price).ToString();

            }
            else
            {
                MessageBox.Show("Недостаточно денег");
            }

        }
        
        public void Buy_Potion(double weight, double price)
        {
            if (GameProvider.hero.Wallet >= price)
            {
                Potion potion = new Potion(weight, price);
                GameProvider.hero.Items.Add(potion);
                GameProvider.hero.Wallet -= price;
                label_money.Text = (int.Parse(label_money.Text) - potion.Price).ToString();
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
            Buy_Potion(5, 100);

        }

        private void button_buy2_Click(object sender, EventArgs e)
        {
            Buy_Potion(10, 120);

        }

        private void button_buy3_Click(object sender, EventArgs e)
        {
            Buy_Potion(5, 80);

        }

        private void button_gun1_Click(object sender, EventArgs e)
        {
            Add_Gun(20, 30, 230);
        }

        private void button_gun2_Click(object sender, EventArgs e)
        {
            Add_Gun(20, 30, 240);
        }

        private void button_gun3_Click(object sender, EventArgs e)
        {
            Add_Gun(20, 40, 250);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var result= MessageBox.Show("Уже уходите?","Предупреждение",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Start s=new Start();
                s.Show();
            }
            
        }
    }
}
