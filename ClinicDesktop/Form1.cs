using ClinicServiceNamespace;

namespace ClinicDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
           
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            ICollection<Client> clients = clinicClient.ClientGetAllAsync().Result;
            listViewClients.Items.Clear();
            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.ClientId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.SurName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.FirstName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Patronymic
                });
                listViewClients.Items.Add(item);
            }
        }
        private void btnUpdatePets_Click(object sender, EventArgs e)

        {
            

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewPets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

