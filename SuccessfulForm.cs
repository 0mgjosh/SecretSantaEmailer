namespace SecretSantaMailer
{
    public partial class SuccessfulForm : Form
    {
        public SuccessfulForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
