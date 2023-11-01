namespace SecretSantaMailer
{
    using Newtonsoft.Json;


    public partial class CreationForm : Form
    {
        string temp_list_name = "";
        string temp_name = "";
        string temp_email = "";
        string temp_address = "";

        Person? temp_person;

        List<Plist> plists = new List<Plist>();
        Plist? SelectedPlist;

        DirectoryInfo directory;

        public CreationForm()
        {
            InitializeComponent();
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            if (Potatoes.PersonList.Members.Count > 2)
            {
                ActiveForm.Visible = false;
                new MessageForm().ShowDialog();
            }
            else
            {
                WarningLabel.Visible = true;
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person p = Potatoes.PersonList.Members[ListBox.SelectedIndex];

            SelectedName.Text = p.Name;
            SelectedEmail.Text = p.Email;
            SelectedAddress.Text = p.Address;

            SelectedPanel.Visible = true;
            CreateListPanel.Visible = false;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            temp_name = NameTextBox.Text;
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
            Potatoes.PersonList.Members.Add(new Person(temp_name, temp_email, temp_address));
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            ListBox.Update();
            ListBox.Items.Clear();

            foreach (Person p in Potatoes.PersonList.Members)
            {
                ListBox.Items.Add(p.Name);
            }

            ListBox.EndUpdate();
        }

        private void YesRemoveButton_Click(object sender, EventArgs e)
        {
            Potatoes.PersonList.Members.RemoveAt(ListBox.SelectedIndex);
            SelectedPanel.Visible = false;
            CreateListPanel.Visible = true;
            UpdateListBox();
        }

        private void NoRemoveButton_Click(object sender, EventArgs e)
        {
            SelectedPanel.Visible = false;
            CreateListPanel.Visible = true;
        }

        private void LoadListButton_Click(object sender, EventArgs e)
        {
            LoadListPanel.Visible = true;
            CreateListPanel.Visible = false;

            plists.Clear();

            //load json lists.
            directory = Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\" + "Lists");


            foreach (var f in directory.GetFiles("*.json"))
            {
                string file_name = f.FullName;
                Plist? cereal_members = JsonConvert.DeserializeObject<Plist?>(File.ReadAllText(file_name));

                if (cereal_members == null) return;

                cereal_members.Name = Path.GetFileNameWithoutExtension(file_name);

                plists.Add(cereal_members);
            }

            UpdateLoadListBox();
        }

        private void UpdateLoadListBox()
        {
            LoadListBox.Update();
            LoadListBox.Items.Clear();

            foreach (Plist p in plists)
            {
                LoadListBox.Items.Add(p.Name);
            }

            LoadListBox.EndUpdate();
        }

        private void LoadSelectedButton_Click(object sender, EventArgs e)
        {
            if(SelectedPlist == null)
            {
                LoadWarning.Visible = true;
                return;
            }

            LoadListPanel.Visible = false;
            CreateListPanel.Visible = true;

            Potatoes.PersonList = SelectedPlist;

            if(SelectedPlist != null) ListNameTextBox.Text = SelectedPlist.Name;

            UpdateListBox();
        }

        private void ListNameTextBox_TextChanged(object sender, EventArgs e)
        {
            temp_list_name = ListNameTextBox.Text;
            Potatoes.PersonList.Name = temp_list_name;
        }

        private void SaveListButton_Click(object sender, EventArgs e)
        {
            if(ListNameTextBox.Text == null || ListNameTextBox.Text == "" || ListNameTextBox.Text.Contains(" "))
            {
                SaveWarning.Visible = true;
                return;
            }

            string file_name = temp_list_name;
            string data_list = JsonConvert.SerializeObject(Potatoes.PersonList, Formatting.None);
            System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\" + "Lists");
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + "Lists" + @"\" + file_name + ".json",
                  data_list.ToString());
        }

        private void LoadListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPlist = plists[LoadListBox.SelectedIndex];
        }

        private void RemoveListButton_Click(object sender, EventArgs e)
        {
            if (SelectedPlist != null)
            {
                File.Delete(directory + @"\" + SelectedPlist.Name + ".json");
                plists.Remove(SelectedPlist);
                UpdateLoadListBox();
            }
        }

        private void ExitLoadPanelButton_Click(object sender, EventArgs e)
        {
            SaveWarning.Visible = false;
            LoadWarning.Visible = false;
            LoadListPanel.Visible = false;
            CreateListPanel.Visible = true;
        }
    }
}
