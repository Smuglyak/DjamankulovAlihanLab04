﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleDocumentInterface
{
    public partial class ChildForm : Form
    {
        public ChildForm(string title, string resourceName)
        {
            InitializeComponent();

            Text = title; // set title text

            // set image to display in PictureBox
            displayPictureBox.Image =
            (Image)(Properties.Resources.ResourceManager.GetObject(
            resourceName));
        }
    }
}
