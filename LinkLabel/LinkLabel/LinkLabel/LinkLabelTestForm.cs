namespace LinkLabel
{
    public partial class LinkLabelTestForm : Form
    {
        public LinkLabelTestForm()
        {
            InitializeComponent();
        }

        private void cDriveLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // change LinkColor after it has been clicked
             cDriveLinkLabel.LinkVisited = true;
            
            System.Diagnostics.Process.Start("explorer.exe", @"C:\");

        }

        private void deitelLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // change LinkColor after it has been clicked
            deitelLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://deitel.com/");
        }

        private void notepadLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // change LinkColor after it has been clicked
            notepadLinkLabel.LinkVisited = true;
            // program called as if in run
            // menu and full path not needed
            System.Diagnostics.Process.Start("notepad");

        }

        private void VanierHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VanierHomePage.LinkVisited = true;
            System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://vaniercollege.omnivox.ca/Login/Account/Login?ReturnUrl=%2fintr%2f");
        }
    }
}