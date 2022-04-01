namespace MultipleDocumentInterface
{
    public partial class UsingMDIForm : Form
    {
        public UsingMDIForm()
        {
            InitializeComponent();
        }
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lavenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create new child
            var child = new ChildForm(
            "Lavender Flowers", "lavenderflowers");
            child.MdiParent = this; // set parent
            child.Show(); // display child 
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create new child
            var child = new ChildForm(
            "Purple Flowers", "purpleflowers");
            child.MdiParent = this; // set parent
            child.Show(); // display child
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create new child
            var child = new ChildForm(
            "Yellow Flowers", "yellowflowers");
            child.MdiParent = this; // set parent
            child.Show(); // display child 
        }
    }
}