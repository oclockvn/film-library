namespace FirmLibrary.App
{
    partial class IndexForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("Title");
            ListViewItem listViewItem2 = new ListViewItem("Rating");
            ListViewItem listViewItem3 = new ListViewItem("Description");
            ListViewItem listViewItem4 = new ListViewItem("Director");
            ListViewItem listViewItem5 = new ListViewItem("Release date");
            txtSearch = new TextBox();
            btnClear = new Button();
            btnNew = new Button();
            lvMovie = new ListView();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(431, 31);
            txtSearch.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(449, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.Location = new Point(1152, 12);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 34);
            btnNew.TabIndex = 2;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // lvMovie
            // 
            lvMovie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvMovie.GridLines = true;
            lvMovie.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            lvMovie.Location = new Point(12, 60);
            lvMovie.Name = "lvMovie";
            lvMovie.Size = new Size(1252, 879);
            lvMovie.TabIndex = 3;
            lvMovie.UseCompatibleStateImageBehavior = false;
            lvMovie.View = View.Details;
            // 
            // IndexForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 951);
            Controls.Add(lvMovie);
            Controls.Add(btnNew);
            Controls.Add(btnClear);
            Controls.Add(txtSearch);
            Name = "IndexForm";
            Text = "Film Library | version 1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnClear;
        private Button btnNew;
        private ListView lvMovie;
    }
}