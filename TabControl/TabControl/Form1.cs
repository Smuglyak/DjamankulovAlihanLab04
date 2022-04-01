namespace TabControl
{
    public partial class usingTabsForm : Form
    {
        public usingTabsForm()
        {
            InitializeComponent();
            displayLabel.Text = "Hello!"; // change text to Hello!

        }
        

        private void blackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Black; // change color to black
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Red; // change color to red
        }

        private void greenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Green; // change color to green
        }

        private void size12RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.Name, 12);
        }

        private void size16RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.Name, 16);
        }

        private void size20RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.Name, 20);
        }

        private void helloRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Text = "Hello!"; // change text to Hello!
        }

        private void goodbyeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Text = "Goodbye!"; // change text to Goodbye!
        }
    }
}