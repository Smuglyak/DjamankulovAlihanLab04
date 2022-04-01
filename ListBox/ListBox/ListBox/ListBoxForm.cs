namespace ListBox
{
    public partial class ListBoxTestForm : Form
    {
        public ListBoxTestForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Add(inputTextBox.Text);
            inputTextBox.Clear();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // check whether item is selected; if so, remove
             if (displayListBox.SelectedIndex != -1)
                {
                displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
                }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}