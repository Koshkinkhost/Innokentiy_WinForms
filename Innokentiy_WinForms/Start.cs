using Innokentiy_WinForms.Classes;

namespace Innokentiy_WinForms
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shop shop = new Shop();
            shop.Show();
        }

        private void button_inventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invantory invantory = new Invantory();
            invantory.Show();
        }

        private void Start_Load_1(object sender, EventArgs e)
        {
            progressBar_health.Value = GameProvider.hero.Health;
            progressBar_health.Maximum = GameProvider.hero.Health;

            label_moneyCount.Text = GameProvider.hero.Wallet.ToString();
            if(GameProvider.hero.weapon is not null && GameProvider.hero.potion is not null )
            {
                label_potion.Text= GameProvider.hero.potion.Name;
                label_sel_weapon.Text= GameProvider.hero.weapon.Name;
            }

        }
    }
}
