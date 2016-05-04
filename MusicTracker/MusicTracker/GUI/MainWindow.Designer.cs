namespace MusicTracker.GUI
{
    partial class MainWindow
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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Not Downloaded", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Downloaded", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lvMain = new System.Windows.Forms.ListView();
            this.clTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpWelcome = new System.Windows.Forms.TabPage();
            this.tpEdit = new System.Windows.Forms.TabPage();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWelcomeSubtext = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.lblNewTitle = new System.Windows.Forms.Label();
            this.lblNewArtist = new System.Windows.Forms.Label();
            this.cbAddGenre = new System.Windows.Forms.ComboBox();
            this.lblNewGenre = new System.Windows.Forms.Label();
            this.tbAddArtist = new System.Windows.Forms.TextBox();
            this.tbAddTitle = new System.Windows.Forms.TextBox();
            this.btnAddNotDownloaded = new System.Windows.Forms.Button();
            this.btnAddDownloaded = new System.Windows.Forms.Button();
            this.btnCleanGenres = new System.Windows.Forms.Button();
            this.lblCleanDescription = new System.Windows.Forms.Label();
            this.tbEditTitle = new System.Windows.Forms.TextBox();
            this.tbEditArtist = new System.Windows.Forms.TextBox();
            this.lblEditGenre = new System.Windows.Forms.Label();
            this.cbEditGenre = new System.Windows.Forms.ComboBox();
            this.lblEditArtist = new System.Windows.Forms.Label();
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpWelcome.SuspendLayout();
            this.tpEdit.SuspendLayout();
            this.tpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMain
            // 
            this.lvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clTitle,
            this.clArtist,
            this.clGenre});
            listViewGroup3.Header = "Not Downloaded";
            listViewGroup3.Name = "lvgNotDownloaded";
            listViewGroup4.Header = "Downloaded";
            listViewGroup4.Name = "lvgDownloaded";
            this.lvMain.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.lvMain.Location = new System.Drawing.Point(12, 12);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(473, 437);
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.View = System.Windows.Forms.View.Details;
            // 
            // clTitle
            // 
            this.clTitle.Text = "Title";
            this.clTitle.Width = 211;
            // 
            // clArtist
            // 
            this.clArtist.Text = "Artist";
            this.clArtist.Width = 142;
            // 
            // clGenre
            // 
            this.clGenre.Text = "Genre";
            this.clGenre.Width = 116;
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpWelcome);
            this.tcMain.Controls.Add(this.tpAdd);
            this.tcMain.Controls.Add(this.tpEdit);
            this.tcMain.Location = new System.Drawing.Point(491, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(216, 437);
            this.tcMain.TabIndex = 1;
            // 
            // tpWelcome
            // 
            this.tpWelcome.Controls.Add(this.lblVersion);
            this.tpWelcome.Controls.Add(this.lblWelcomeSubtext);
            this.tpWelcome.Controls.Add(this.lblWelcome);
            this.tpWelcome.Location = new System.Drawing.Point(4, 22);
            this.tpWelcome.Name = "tpWelcome";
            this.tpWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tpWelcome.Size = new System.Drawing.Size(208, 411);
            this.tpWelcome.TabIndex = 0;
            this.tpWelcome.Text = "Welcome";
            this.tpWelcome.UseVisualStyleBackColor = true;
            // 
            // tpEdit
            // 
            this.tpEdit.Controls.Add(this.btnEditSave);
            this.tpEdit.Controls.Add(this.tbEditTitle);
            this.tpEdit.Controls.Add(this.tbEditArtist);
            this.tpEdit.Controls.Add(this.lblEditGenre);
            this.tpEdit.Controls.Add(this.cbEditGenre);
            this.tpEdit.Controls.Add(this.lblEditArtist);
            this.tpEdit.Controls.Add(this.lblEditTitle);
            this.tpEdit.Location = new System.Drawing.Point(4, 22);
            this.tpEdit.Name = "tpEdit";
            this.tpEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpEdit.Size = new System.Drawing.Size(208, 411);
            this.tpEdit.TabIndex = 1;
            this.tpEdit.Text = "Edit Track";
            this.tpEdit.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWelcome.Location = new System.Drawing.Point(6, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(196, 52);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcomeSubtext
            // 
            this.lblWelcomeSubtext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcomeSubtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWelcomeSubtext.Location = new System.Drawing.Point(6, 65);
            this.lblWelcomeSubtext.Name = "lblWelcomeSubtext";
            this.lblWelcomeSubtext.Size = new System.Drawing.Size(196, 325);
            this.lblWelcomeSubtext.TabIndex = 1;
            this.lblWelcomeSubtext.Text = resources.GetString("lblWelcomeSubtext.Text");
            this.lblWelcomeSubtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.Location = new System.Drawing.Point(6, 385);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(196, 23);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version ?";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpAdd
            // 
            this.tpAdd.Controls.Add(this.lblCleanDescription);
            this.tpAdd.Controls.Add(this.btnCleanGenres);
            this.tpAdd.Controls.Add(this.btnAddDownloaded);
            this.tpAdd.Controls.Add(this.btnAddNotDownloaded);
            this.tpAdd.Controls.Add(this.tbAddTitle);
            this.tpAdd.Controls.Add(this.tbAddArtist);
            this.tpAdd.Controls.Add(this.lblNewGenre);
            this.tpAdd.Controls.Add(this.cbAddGenre);
            this.tpAdd.Controls.Add(this.lblNewArtist);
            this.tpAdd.Controls.Add(this.lblNewTitle);
            this.tpAdd.Location = new System.Drawing.Point(4, 22);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Size = new System.Drawing.Size(208, 411);
            this.tpAdd.TabIndex = 2;
            this.tpAdd.Text = "Add Track";
            this.tpAdd.UseVisualStyleBackColor = true;
            // 
            // lblNewTitle
            // 
            this.lblNewTitle.AutoSize = true;
            this.lblNewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewTitle.Location = new System.Drawing.Point(18, 31);
            this.lblNewTitle.Name = "lblNewTitle";
            this.lblNewTitle.Size = new System.Drawing.Size(39, 17);
            this.lblNewTitle.TabIndex = 0;
            this.lblNewTitle.Text = "Title:";
            // 
            // lblNewArtist
            // 
            this.lblNewArtist.AutoSize = true;
            this.lblNewArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewArtist.Location = new System.Drawing.Point(18, 57);
            this.lblNewArtist.Name = "lblNewArtist";
            this.lblNewArtist.Size = new System.Drawing.Size(44, 17);
            this.lblNewArtist.TabIndex = 1;
            this.lblNewArtist.Text = "Artist:";
            // 
            // cbAddGenre
            // 
            this.cbAddGenre.FormattingEnabled = true;
            this.cbAddGenre.Location = new System.Drawing.Point(76, 82);
            this.cbAddGenre.Name = "cbAddGenre";
            this.cbAddGenre.Size = new System.Drawing.Size(112, 21);
            this.cbAddGenre.TabIndex = 3;
            // 
            // lblNewGenre
            // 
            this.lblNewGenre.AutoSize = true;
            this.lblNewGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewGenre.Location = new System.Drawing.Point(18, 83);
            this.lblNewGenre.Name = "lblNewGenre";
            this.lblNewGenre.Size = new System.Drawing.Size(52, 17);
            this.lblNewGenre.TabIndex = 3;
            this.lblNewGenre.Text = "Genre:";
            // 
            // tbAddArtist
            // 
            this.tbAddArtist.Location = new System.Drawing.Point(76, 56);
            this.tbAddArtist.Name = "tbAddArtist";
            this.tbAddArtist.Size = new System.Drawing.Size(112, 20);
            this.tbAddArtist.TabIndex = 2;
            // 
            // tbAddTitle
            // 
            this.tbAddTitle.Location = new System.Drawing.Point(76, 30);
            this.tbAddTitle.Name = "tbAddTitle";
            this.tbAddTitle.Size = new System.Drawing.Size(112, 20);
            this.tbAddTitle.TabIndex = 1;
            // 
            // btnAddNotDownloaded
            // 
            this.btnAddNotDownloaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNotDownloaded.Location = new System.Drawing.Point(21, 118);
            this.btnAddNotDownloaded.Name = "btnAddNotDownloaded";
            this.btnAddNotDownloaded.Size = new System.Drawing.Size(75, 75);
            this.btnAddNotDownloaded.TabIndex = 4;
            this.btnAddNotDownloaded.Text = "Add as not downloaded";
            this.btnAddNotDownloaded.UseVisualStyleBackColor = true;
            // 
            // btnAddDownloaded
            // 
            this.btnAddDownloaded.Location = new System.Drawing.Point(113, 118);
            this.btnAddDownloaded.Name = "btnAddDownloaded";
            this.btnAddDownloaded.Size = new System.Drawing.Size(75, 75);
            this.btnAddDownloaded.TabIndex = 5;
            this.btnAddDownloaded.Text = "Add as downloaded";
            this.btnAddDownloaded.UseVisualStyleBackColor = true;
            // 
            // btnCleanGenres
            // 
            this.btnCleanGenres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCleanGenres.Location = new System.Drawing.Point(3, 370);
            this.btnCleanGenres.Name = "btnCleanGenres";
            this.btnCleanGenres.Size = new System.Drawing.Size(202, 38);
            this.btnCleanGenres.TabIndex = 6;
            this.btnCleanGenres.Text = "CLEAN UP UNUSED GENRES";
            this.btnCleanGenres.UseVisualStyleBackColor = true;
            // 
            // lblCleanDescription
            // 
            this.lblCleanDescription.Location = new System.Drawing.Point(3, 337);
            this.lblCleanDescription.Name = "lblCleanDescription";
            this.lblCleanDescription.Size = new System.Drawing.Size(202, 30);
            this.lblCleanDescription.TabIndex = 9;
            this.lblCleanDescription.Text = "Warning: the button below will remove all unused genres";
            this.lblCleanDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEditTitle
            // 
            this.tbEditTitle.Location = new System.Drawing.Point(76, 30);
            this.tbEditTitle.Name = "tbEditTitle";
            this.tbEditTitle.Size = new System.Drawing.Size(112, 20);
            this.tbEditTitle.TabIndex = 11;
            // 
            // tbEditArtist
            // 
            this.tbEditArtist.Location = new System.Drawing.Point(76, 56);
            this.tbEditArtist.Name = "tbEditArtist";
            this.tbEditArtist.Size = new System.Drawing.Size(112, 20);
            this.tbEditArtist.TabIndex = 10;
            // 
            // lblEditGenre
            // 
            this.lblEditGenre.AutoSize = true;
            this.lblEditGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEditGenre.Location = new System.Drawing.Point(18, 83);
            this.lblEditGenre.Name = "lblEditGenre";
            this.lblEditGenre.Size = new System.Drawing.Size(52, 17);
            this.lblEditGenre.TabIndex = 9;
            this.lblEditGenre.Text = "Genre:";
            // 
            // cbEditGenre
            // 
            this.cbEditGenre.FormattingEnabled = true;
            this.cbEditGenre.Location = new System.Drawing.Point(76, 82);
            this.cbEditGenre.Name = "cbEditGenre";
            this.cbEditGenre.Size = new System.Drawing.Size(112, 21);
            this.cbEditGenre.TabIndex = 8;
            // 
            // lblEditArtist
            // 
            this.lblEditArtist.AutoSize = true;
            this.lblEditArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEditArtist.Location = new System.Drawing.Point(18, 57);
            this.lblEditArtist.Name = "lblEditArtist";
            this.lblEditArtist.Size = new System.Drawing.Size(44, 17);
            this.lblEditArtist.TabIndex = 7;
            this.lblEditArtist.Text = "Artist:";
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEditTitle.Location = new System.Drawing.Point(18, 31);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(39, 17);
            this.lblEditTitle.TabIndex = 6;
            this.lblEditTitle.Text = "Title:";
            // 
            // btnEditSave
            // 
            this.btnEditSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditSave.Location = new System.Drawing.Point(21, 118);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(167, 34);
            this.btnEditSave.TabIndex = 12;
            this.btnEditSave.Text = "SAVE";
            this.btnEditSave.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 461);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.lvMain);
            this.MinimumSize = new System.Drawing.Size(735, 500);
            this.Name = "MainWindow";
            this.Text = "Music Tracker";
            this.tcMain.ResumeLayout(false);
            this.tpWelcome.ResumeLayout(false);
            this.tpEdit.ResumeLayout(false);
            this.tpEdit.PerformLayout();
            this.tpAdd.ResumeLayout(false);
            this.tpAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.ColumnHeader clTitle;
        private System.Windows.Forms.ColumnHeader clArtist;
        private System.Windows.Forms.ColumnHeader clGenre;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpWelcome;
        private System.Windows.Forms.TabPage tpEdit;
        private System.Windows.Forms.Label lblWelcomeSubtext;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.Label lblCleanDescription;
        private System.Windows.Forms.Button btnCleanGenres;
        private System.Windows.Forms.Button btnAddDownloaded;
        private System.Windows.Forms.Button btnAddNotDownloaded;
        private System.Windows.Forms.TextBox tbAddTitle;
        private System.Windows.Forms.TextBox tbAddArtist;
        private System.Windows.Forms.Label lblNewGenre;
        private System.Windows.Forms.ComboBox cbAddGenre;
        private System.Windows.Forms.Label lblNewArtist;
        private System.Windows.Forms.Label lblNewTitle;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.TextBox tbEditTitle;
        private System.Windows.Forms.TextBox tbEditArtist;
        private System.Windows.Forms.Label lblEditGenre;
        private System.Windows.Forms.ComboBox cbEditGenre;
        private System.Windows.Forms.Label lblEditArtist;
        private System.Windows.Forms.Label lblEditTitle;
    }
}

