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
    public partial class Invantory : Form
    {
        public Invantory()
        {
            InitializeComponent();
        }

        private void Invantory_Load(object sender, EventArgs e)
        {
            foreach (var t in GameProvider.hero.Items)
            {

                if(t is Weapon)
                {
                    comboBox_weapons.Items.Add(t);
                }
                else
                {
                    comboBox_potion.Items.Add(t);

                }

            }

              
        }

        private void button_use_Click(object sender, EventArgs e)
        {
            if(comboBox_weapons.SelectedItem is not null && comboBox_potion.SelectedItem is not null)
            {
                GameProvider.hero.weapon = (Weapon)comboBox_weapons.SelectedItem;
                GameProvider.hero.potion = (Potion)comboBox_potion.SelectedItem;
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start s=new Start();
            s.Show();
        }
    }
}
