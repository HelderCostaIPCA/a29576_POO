namespace POO
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void bt_resources_click(object sender, EventArgs e)
        {
            Resources Resources = new Resources(); 
            Resources.Show();
        }
    }
}
