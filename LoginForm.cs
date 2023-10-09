namespace SecretSantaMailer
{
    using MimeKit;
    using MimeKit.Text;
    using MailKit.Net.Smtp;
    using static Potatoes;
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Email == null || Password == null)
            {
                this.InvalidLabel.Text = "Email, or Password field is empty.";
                this.InvalidLabel.Visible = true;
                return;
            }
            else
            {
                try
                {
                    // Send Test Email

                    var email = new MimeMessage();

                    email.From.Add(MailboxAddress.Parse(Email));
                    email.To.Add(MailboxAddress.Parse(Email));
                    email.Subject = "Secret Santa Mailer";
                    email.Body = new TextPart(TextFormat.Text) { Text = "Login Sucessful." };

                    using var smtp = new SmtpClient();
                    smtp.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                    smtp.Authenticate(Email, Password);
                    smtp.Send(email);
                    smtp.Disconnect(true);
                }
                catch (Exception ex)
                {
                    //string exception = ex.ToString();
                    this.InvalidLabel.Text = "Credentials Invalid, \n \n Use Gmails 3rd Party App Password";
                    this.InvalidLabel.Visible = true;
                    return;
                }
            }

            ActiveForm.Visible = false;
            new CreationForm().ShowDialog();
        }

        private void EmailInput_TextChanged(object sender, EventArgs e)
        {
            Email = EmailInput.Text;
        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {
            Password = PasswordInput.Text;
        }
    }
}