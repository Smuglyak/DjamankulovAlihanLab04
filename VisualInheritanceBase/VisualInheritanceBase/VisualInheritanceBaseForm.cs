using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualInheritanceBase
{
    public partial class VisualInheritanceBaseForm : Form
    {
        public VisualInheritanceBaseForm()
        {
            InitializeComponent();
        }

        private void learnMoreButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
"Bugs, Bugs, Bugs is a product of deitel.com",
"Learn More", MessageBoxButtons.OK,
MessageBoxIcon.Information);
        }
    }
}
