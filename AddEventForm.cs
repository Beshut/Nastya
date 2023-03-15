using System;
using System.Windows.Forms;

namespace Organizer1
{
    public partial class AddEventForm : Form
    {
        public Organizer organizer;
        public AddEventForm()
        {
            InitializeComponent();
        }
        public void setOrganize(ref Organizer organizer)
        {
            this.organizer = organizer;
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add(EventType.METEENG.ToString());
            comboBox1.Items.Add(EventType.TASK.ToString());
            comboBox1.Select(0, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Ticks > monthCalendar1.SelectionStart.Ticks)
            {
                MessageBox.Show("Данная дата уже прошла!");
                return;
            }
            organizer.add(new Data(
                textBox1.Text,
                monthCalendar1.SelectionStart,
                dateTimePicker1.Value.TimeOfDay,
                (EventType)Enum.Parse(typeof(EventType), comboBox1.Text, true)
                ));
            this.Close();
        }
    }
}
