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

        private void Shop_Load(object sender, EventArgs e)
        {
            label_money.Text = GameProvider.hero.Wallet.ToString();
        }

        private void button_buy1_Click(object sender, EventArgs e)
        {
            Potion potion = new Potion(5, 100);
            GameProvider.hero.Items.Add(potion);
            label_money.Text = (int.Parse(label_money.Text) - potion.Price).ToString();
        }

        private void button_buy2_Click(object sender, EventArgs e)
        {
            Potion potion = new Potion(5, 110);
            GameProvider.hero.Items.Add(potion);
            label_money.Text = (int.Parse(label_money.Text) - potion.Price).ToString();
        }

        private void button_buy3_Click(object sender, EventArgs e)
        {
            Potion potion = new Potion(5, 120);
            GameProvider.hero.Items.Add(potion);
            label_money.Text = (int.Parse(label_money.Text) - potion.Price).ToString();
        }

        private void button_gun1_Click(object sender, EventArgs e)
        {
            Weapon weapon = new Weapon(20, 30, 230);
            GameProvider.hero.Items.Add(weapon);
            label_money.Text = (int.Parse(label_money.Text) - weapon.Price).ToString();
        }

        private void button_gun2_Click(object sender, EventArgs e)
        {
            Weapon weapon = new Weapon(20, 30, 240);
            GameProvider.hero.Items.Add(weapon);
            label_money.Text = (int.Parse(label_money.Text) - weapon.Price).ToString();
        }

        private void button_gun3_Click(object sender, EventArgs e)
        {
            Weapon weapon = new Weapon(20, 30, 250);
            GameProvider.hero.Items.Add(weapon);
            label_money.Text = (int.Parse(label_money.Text) - weapon.Price).ToString();
        }
    }
}
