using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretSantaMailer
{
    public partial class CreationForm : Form
    {
        string temp_name = "";
        string temp_email = "";
        string temp_address = "";

        public CreationForm()
        {
            InitializeComponent();
            //ListBox.DataSource = Person.Members;
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            if(Person.Members.Count > 2)
            {
                ActiveForm.Visible= false;
                new MessageForm().ShowDialog();
            }
            else
            {
                WarningLabel.Visible = true;
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person p = Person.Members[ListBox.SelectedIndex];

            SelectedName.Text = p.Name;
            SelectedEmail.Text = p.Email;
            SelectedAddress.Text = p.Address;

            SelectedPanel.Visible= true;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            temp_name= NameTextBox.Text;
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            temp_email = EmailTextBox.Text;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            temp_address = AddressTextBox.Text;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Person.Members.Add(new Person(temp_name, temp_email, temp_address));
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            ListBox.Update();
            ListBox.Items.Clear();

            foreach (Person p in Person.Members)
            {
                ListBox.Items.Add(p.Name);
            }

            ListBox.EndUpdate();
        }

        private void YesRemoveButton_Click(object sender, EventArgs e)
        {
            Person.Members.RemoveAt(ListBox.SelectedIndex);
            SelectedPanel.Visible = false;
            UpdateListBox();
        }

        private void NoRemoveButton_Click(object sender, EventArgs e)
        {
            SelectedPanel.Visible = false;
        }
    }
}
