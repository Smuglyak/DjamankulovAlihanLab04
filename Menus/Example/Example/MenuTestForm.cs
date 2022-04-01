using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class MenuTestForm : Form
    {
        public MenuTestForm()
        {
            InitializeComponent();
            timesToolStripMenuItem.Checked = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an example\nof using menus.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ClearColor()
        {
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
        }

        private void ClearFont()
        {
            timesToolStripMenuItem.Checked = false;
            comicToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Green;
            greenToolStripMenuItem.Checked = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
        }
        private void comicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            
            // set Comic Sans font
            comicToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Comic Sans MS", 14,
            displayLabel.Font.Style);
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // reset checkmarks for Font ToolStripMenuItems
             ClearFont();

            // set Courier font
            courierToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Courier", 14,
            displayLabel.Font.Style);
        }

        

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            
             // set Times New Roman font
            timesToolStripMenuItem.Checked = true;
            displayLabel.Font = new Font("Times New Roman", 14,
            displayLabel.Font.Style);
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;
            // use Xor to toggle bold, keep all other styles
            displayLabel.Font = new Font(displayLabel.Font,
            displayLabel.Font.Style ^ FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // toggle checkmark
             italicToolStripMenuItem.Checked =
            !italicToolStripMenuItem.Checked;
            
            // use Xor to toggle italic, keep all other styles
            displayLabel.Font = new Font(displayLabel.Font,
            displayLabel.Font.Style ^ FontStyle.Italic);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
