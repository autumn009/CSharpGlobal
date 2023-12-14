namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void set(DateTime dt)
        {
            try
            {
                dateTimePicker1.Value = dt;
            }
            catch (Exception ex)
            {
                textBox1.Text = $"Min {dateTimePicker1.MinDate}\r\n";
                textBox1.Text += $"Max {dateTimePicker1.MaxDate}\r\n";
                textBox1.Text += $"MinimumDateTime {System.Windows.Forms.DateTimePicker.MinimumDateTime}\r\n";
                textBox1.Text += $"MaximumDateTime {System.Windows.Forms.DateTimePicker.MaximumDateTime}\r\n";
                textBox1.Text+= ex.ToString();
            }
        }

        private void buttonSetMin_Click(object sender, EventArgs e)
        {
            set(DateTime.MinValue);
        }

        private void buttonSetMax_Click(object sender, EventArgs e)
        {
            set(DateTime.MaxValue);
        }
    }
}
