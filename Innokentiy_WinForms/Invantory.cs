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

                if (t is Weapon)
                {
                    comboBox_weapons.Items.Add(t);
                }
                else
                {
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
            try
            {
                var selectedValue = comboBox_filter_weapon.SelectedValue?.ToString();  // Защищаем от null

                if (selectedValue == "алфавит")
                {
                    var weaponList = (List<Weapon>)comboBox_weapons.DataSource;
                    var sortedWeapons = weaponList.OrderBy(item => item.Name).ToList();  // Преобразуем в список после сортировки
                    comboBox_weapons.DataSource = sortedWeapons;
                    comboBox_weapons.DisplayMember = "Name";  // Отображаем по полю Name
                    comboBox_weapons.ValueMember = "Price";  // Или установите нужный ValueMember
                }
                else if (selectedValue == "стоимость")
                {
                    var weaponList = (List<Weapon>)comboBox_weapons.DataSource;
                    var sortedWeapons = weaponList.OrderBy(item => item.Price).ToList();  // Преобразуем в список после сортировки
                    comboBox_weapons.DataSource = sortedWeapons;
                    comboBox_weapons.DisplayMember = "Name";  // Отображаем по полю Name
                    comboBox_weapons.ValueMember = "Price";  // Или установите нужный ValueMember
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при применении фильтра: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_filter_potion_SelectedValueChanged(object sender, EventArgs e)    //чат джпт
        {
            try
            {
                var selectedValue = comboBox_filter_potion.SelectedValue?.ToString();  // Защищаем от null

                if (selectedValue == "алфавит")
                {
                    var potionList = (List<Potion>)comboBox_potion.DataSource;
                    var sortedPotions = potionList.OrderBy(item => item.Name).ToList();  // Преобразуем в список после сортировки
                    comboBox_potion.DataSource = sortedPotions;
                    comboBox_potion.DisplayMember = "Name";  // Отображаем по полю Name
                    comboBox_potion.ValueMember = "Price";  // Или установите нужный ValueMember
                }
                else if (selectedValue == "стоимость")
                {
                    var potionList = (List<Potion>)comboBox_potion.DataSource;
                    var sortedPotions = potionList.OrderBy(item => item.Price).ToList();  // Преобразуем в список после сортировки
                    comboBox_potion.DataSource = sortedPotions;
                    comboBox_potion.DisplayMember = "Name";  // Отображаем по полю Name
                    comboBox_potion.ValueMember = "Price";  // Или установите нужный ValueMember
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при применении фильтра: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
