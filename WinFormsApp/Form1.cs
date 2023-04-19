using DataProvider;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private PersonRepository personRepository = new PersonRepository();
        private List<Guid> personGuid = new List<Guid>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var person in personRepository.GetAll())
            {
                personGuid.Add(person.PersonId);
                this.listBox1.Items.Add(person.FirstName + " " + person.LastName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var person = personRepository.Get(personGuid[listBox1.SelectedIndex]);
            textBox1.Text = person.FirstName + " " + person.LastName + " " + person.Age.ToString() + " ans";
            textBox1.Visible = true;
        }
    }
}