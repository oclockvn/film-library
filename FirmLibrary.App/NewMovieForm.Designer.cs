namespace FirmLibrary.App
{
    partial class NewMovieForm
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
            txtImdbId = new TextBox();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            txtGenre = new TextBox();
            label4 = new Label();
            txtDirector = new TextBox();
            label5 = new Label();
            txtActor = new TextBox();
            label6 = new Label();
            txtImdb = new TextBox();
            label7 = new Label();
            btnAdd = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtImdbId
            // 
            txtImdbId.Location = new Point(6, 30);
            txtImdbId.Name = "txtImdbId";
            txtImdbId.Size = new Size(527, 31);
            txtImdbId.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(539, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtImdbId);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(657, 78);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "IMDB Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 112);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 4;
            label1.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(18, 140);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(527, 31);
            txtTitle.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(18, 224);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(895, 78);
            txtDescription.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 196);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 6;
            label2.Text = "Description";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(18, 346);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(230, 31);
            textBox4.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 318);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 8;
            label3.Text = "Release date";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(18, 428);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(527, 31);
            txtGenre.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 400);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 10;
            label4.Text = "Genre";
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(18, 515);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(527, 31);
            txtDirector.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 487);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 12;
            label5.Text = "Director";
            // 
            // txtActor
            // 
            txtActor.Location = new Point(18, 606);
            txtActor.Name = "txtActor";
            txtActor.Size = new Size(527, 31);
            txtActor.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 578);
            label6.Name = "label6";
            label6.Size = new Size(63, 25);
            label6.TabIndex = 14;
            label6.Text = "Actors";
            // 
            // txtImdb
            // 
            txtImdb.Location = new Point(551, 140);
            txtImdb.Name = "txtImdb";
            txtImdb.Size = new Size(163, 31);
            txtImdb.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(545, 112);
            label7.Name = "label7";
            label7.Size = new Size(56, 25);
            label7.TabIndex = 16;
            label7.Text = "IMDB";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 661);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Save";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // NewMovieForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 720);
            Controls.Add(btnAdd);
            Controls.Add(txtImdb);
            Controls.Add(label7);
            Controls.Add(txtActor);
            Controls.Add(label6);
            Controls.Add(txtDirector);
            Controls.Add(label5);
            Controls.Add(txtGenre);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "NewMovieForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Movie";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtImdbId;
        private Button btnSearch;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private Label label2;
        private TextBox textBox4;
        private Label label3;
        private TextBox txtGenre;
        private Label label4;
        private TextBox txtDirector;
        private Label label5;
        private TextBox txtActor;
        private Label label6;
        private TextBox txtImdb;
        private Label label7;
        private Button btnAdd;
    }
}