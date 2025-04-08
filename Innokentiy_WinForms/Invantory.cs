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
        private List<Item> weapons;
        private List<Item> potion;
        private void Invantory_Load(object sender, EventArgs e)
        {
            weapons= new List<Item>();
            potion= new List<Item>();

            foreach (var t in GameProvider.hero.Items)
            {

                if (t is Weapon)
                {
                    comboBox_weapons.Items.Add(t);
                    weapons.Add(t);
                }
                else
                {
                    potion.Add(t);

                    comboBox_potion.Items.Add(t);

                }
            }
            foreach (var t in Invantory.Filters)
            {
                comboBox_filter_weapon.Items.Add(t);
                comboBox_filter_potion.Items.Add(t);
            }
        }

        private void button_use_Click(object sender, EventArgs e)
        {
            if (comboBox_weapons.SelectedItem is not null && comboBox_potion.SelectedItem is not null)
            {
                GameProvider.hero.weapon = (Weapon)comboBox_weapons.SelectedItem;
                GameProvider.hero.potion = (Potion)comboBox_potion.SelectedItem;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start s = new Start();
            s.Show();
        }

        public static string[] Filters = { "алфавит", "стоимость" };

        private void comboBox_filter_weapon_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (comboBox_filter_weapon.SelectedIndex != -1 && comboBox_filter_weapon.SelectedItem.ToString()=="алфавит")
            {



                weapons.Sort((x, y) => x.Name.CompareTo(y.Name));
                RefreshComboBox(weapons);
                
             
             
            }
            else if(comboBox_filter_weapon.SelectedIndex != -1 && comboBox_filter_weapon.SelectedItem.ToString() == "стоимость")
            {
                weapons.Sort((x, y) => x.Price.CompareTo(y.Price));
                RefreshComboBox(weapons);
            }

        }
      

        private void RefreshComboBox(List<Item> items)
        {
            
            comboBox_weapons.Items.Clear();
            List<Item> list = new List<Item>();
            foreach (var t in items)
            {

                if (t is Weapon)
                {
                    comboBox_weapons.Items.Add(t);
                    list.Add(t);
                }
                else
                {
                    list.Add(t);

                    comboBox_potion.Items.Add(t);

                }
            }
        }

        private void comboBox_filter_potion_SelectedValueChanged(object sender, EventArgs e)    //чат джпт
        {
          
        }

        /*private void comboBox_filter_weapon_SelectedValueChanged(object sender, EventArgs e)           //Моё решение
        {
            if (comboBox_filter_weapon.SelectedValue.ToString() == "алфавит")
            {
                var weaponList = (List<Weapon>)comboBox_weapons.DataSource;
                comboBox_weapons.DataSource = weaponList.OrderBy(item => item.Name);
            }
            if (comboBox_filter_weapon.SelectedValue.ToString() == "стоимость")
            {
                var weaponList = (List<Weapon>)comboBox_weapons.DataSource;
                comboBox_weapons.DataSource = weaponList.OrderBy(item => item.Price);
            }
        }

        private void comboBox_filter_potion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_filter_potion.SelectedValue.ToString() == "алфавит")
            {
                var potionList = (List<Potion>)comboBox_potion.DataSource;
                comboBox_potion.DataSource = potionList.OrderBy(item => item.Name);
            }
            if (comboBox_filter_potion.SelectedValue.ToString() == "стоимость")
            {
                var potionList = (List<Potion>)comboBox_potion.DataSource;
                comboBox_potion.DataSource = potionList.OrderBy(item => item.Price);
            }
        }*/
    }
}
