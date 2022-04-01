namespace ListView
{
    partial class ListViewTestForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListViewTestForm));
            this.browserListView = new System.Windows.Forms.ListView();
            this.fileFolderImageList = new System.Windows.Forms.ImageList(this.components);
            this.displayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browserListView
            // 
            this.browserListView.Location = new System.Drawing.Point(12, 39);
            this.browserListView.Name = "browserListView";
            this.browserListView.Size = new System.Drawing.Size(832, 305);
            this.browserListView.SmallImageList = this.fileFolderImageList;
            this.browserListView.TabIndex = 0;
            this.browserListView.UseCompatibleStateImageBehavior = false;
            this.browserListView.View = System.Windows.Forms.View.List;
            this.browserListView.Click += new System.EventHandler(this.browserListView_Click);
            // 
            // fileFolderImageList
            // 
            this.fileFolderImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.fileFolderImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileFolderImageList.ImageStream")));
            this.fileFolderImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.fileFolderImageList.Images.SetKeyName(0, "folder.bmp");
            this.fileFolderImageList.Images.SetKeyName(1, "file.bmp");
            // 
            // displayLabel
            // 
            this.displayLabel.Location = new System.Drawing.Point(12, 9);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(832, 25);
            this.displayLabel.TabIndex = 1;
            // 
            // ListViewTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 356);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.browserListView);
            this.Name = "ListViewTestForm";
            this.Text = "ListViewTest";
            this.Load += new System.EventHandler(this.ListViewTestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Label displayLabel;
        private ImageList fileFolderImageList;
        public System.Windows.Forms.ListView browserListView;
    }
}