namespace ISHospital
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void bAddInfo_Click(object sender, EventArgs e)
        {
            Form formAddInfo = new AddInfoForm();
            this.Hide();
            formAddInfo.ShowDialog();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}