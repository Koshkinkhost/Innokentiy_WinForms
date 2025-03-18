using Innokentiy_WinForms.Classes;

namespace Innokentiy_WinForms
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar_health.Maximum = GameProvider.hero.Health;
            progressBar_health.Value = GameProvider.hero.Health;
            label_health.Text = GameProvider.hero.Health.ToString();
            label_moneyCount.Text = GameProvider.hero.Wallet.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            shop.Show();
            this.Hide();
        }

        private void button_inventory_Click(object sender, EventArgs e)
        {
            Invantory invantory = new Invantory();
            invantory.Show();
            this.Hide();
        }
    }
}
