namespace CheckedListBox
{
    public partial class CheckedListBoxTestForm : Form
    {
        public CheckedListBoxTestForm()
        {
            InitializeComponent();
        }

        private void itemCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // obtain reference of selected item
             string item = itemCheckedListBox.SelectedItem.ToString();
            
// if item checked, add to ListBox
// otherwise remove from ListBox
if (e.NewValue == CheckState.Checked)
                {
                displayListBox.Items.Add(item);
                }
            else
            {
            displayListBox.Items.Remove(item);
                }
        }

        private void itemCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}