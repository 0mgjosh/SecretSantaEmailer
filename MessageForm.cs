using MailKit.Net.Smtp;
using MimeKit;
using static SecretSantaMailer.Potatoes;

namespace SecretSantaMailer
{
    public partial class MessageForm : Form
    {
        private string subject;
        private string custom_message = " ";

        private Random rand = new();


        public MessageForm()
        {
            InitializeComponent();

            foreach(Person p in Person.Members)
            {
                Person.Members_Remaining.Add(p);
            }

            subject = SubjectTextBox.Text;
        }

        private void SubjectTextBox_TextChanged(object sender, EventArgs e)
        {
            subject = SubjectTextBox.Text;
        }

        private void CustomMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            custom_message = CustomMessageTextBox.Text;
        }

        private bool AssignMembers()
        {
            for (int i = 0; i < Person.Members.Count; i++)
            {
                AssignMembers:

                int random_index = rand.Next(0, Person.Members_Remaining.Count());

                if (Person.Members[i] == Person.Members_Remaining[random_index]) goto AssignMembers;

                Person.Members[i].AssignedPerson = Person.Members_Remaining[random_index];

                Person.Members_Remaining.RemoveAt(random_index);
            }


            return true;
        }
        
        
        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            AssignMembers();

            using var smtp = new SmtpClient();
            
            try
            {
                smtp.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                smtp.Authenticate(Email, Password);
            } 
            catch
            {
                WarningLabel.Visible = true;
            }

            foreach(Person p in Person.Members)
            {
                var email_object = new MimeMessage();

                email_object.From.Add(MailboxAddress.Parse(Email));
                email_object.To.Add(MailboxAddress.Parse(p.Email));
                email_object.Subject = subject;
                email_object.Body = new TextPart(MimeKit.Text.TextFormat.Text)
                {
                    Text = "Hey "+ p.Name + " You're " + p.AssignedPerson.Name + "'s Secret Santa🎅🎅🎅 \n\n\n" + custom_message
                };

                smtp.Send(email_object);
            }

            ActiveForm.Visible = false;
            new SuccessfulForm().ShowDialog();
        }

        private void MessagePreviewTextBox_TextChanged(object sender, EventArgs e)
        {
            // unused
        }
    }
}
