
using Newtonsoft.Json;
using System.Data;
using System.Security.Policy;

namespace ExpdigSchedule
{
    public partial class w_main : Form
    {
        public w_main()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void w_main_Load(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"expdconfig.json");
            dataGridView1.DataSource = JsonConvert.DeserializeObject<DataTable>(json);
        }
    }
}

public class Tasks
{
    public List<Task> Task { get; set; }
}

public class Task
{
    public int Id { get; set; }
    public string Nombre { get; set; } = String.Empty;
    public List<Action> Actions { get; set; } = new List<Action>();
    public string Trigger { get; set; } = String.Empty;
    public DateTime Lastrun { get; set; } = DateTime.Now;
    public DateTime Nextrun { get; set; } = DateTime.Now;

}

public class Action
{
    public string name { get; set; }

    public string 
}

public class Trigger
{
    public string name { get; set; }
}