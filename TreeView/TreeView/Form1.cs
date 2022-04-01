namespace TreeView
{
    public partial class TreeViewDirectoryStructureForm : Form
    {
        string substringDirectory;
        public TreeViewDirectoryStructureForm()
        {
            InitializeComponent();
        }

        // populate current node with subdirectories
        public void PopulateTreeView(
       string directoryValue, TreeNode parentNode)
        {
            // array stores all subdirectories in the directory
            string[] directoryArray =
            Directory.GetDirectories(directoryValue);

            // populate current node with subdirectories
            try
            {
                // check to see if any subdirectories are present
                if (directoryArray.Length != 0)
                {
                    // for every subdirectory, create new TreeNode,
                    // add as a child of current node and recursively
                    // populate child nodes with subdirectories
                    foreach (string directory in directoryArray)
                    {
                        // obtain last part of path name from the full path
                        // name by calling the GetFileNameWithoutExtension
                        // method of class Path
                        substringDirectory =
                        Path.GetFileNameWithoutExtension(directory);

                        // create TreeNode for current directory
                        TreeNode myNode = new TreeNode(substringDirectory);

                        // add current directory node to parent node
                        parentNode.Nodes.Add(myNode);

                        // recursively populate every subdirectory
                        PopulateTreeView(directory, myNode);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access denied");
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            // clear all nodes
            directoryTreeView.Nodes.Clear();
            
 // check if the directory entered by user exists
 // if it does, then fill in the TreeView,
 // if not, display error MessageBox
 if (Directory.Exists(inputTextBox.Text))
                 {
                 // add full path name to directoryTreeView
 directoryTreeView.Nodes.Add(inputTextBox.Text);
                
                 // insert subfolders
 PopulateTreeView(
 inputTextBox.Text, directoryTreeView.Nodes[0]);
                 }
             // display error MessageBox if directory not found
 else
                 {
                MessageBox.Show(inputTextBox.Text + " could not be found.",
 "Directory Not Found", MessageBoxButtons.OK,
 MessageBoxIcon.Error);
                 }
        }
    }
}