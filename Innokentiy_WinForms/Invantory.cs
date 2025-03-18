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
            comboBox_items.Items.Add(GameProvider.hero.Items);
        }

        private void button_use_Click(object sender, EventArgs e)
        {
            
        }
    }
}
