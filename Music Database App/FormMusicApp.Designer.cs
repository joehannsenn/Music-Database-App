namespace Music_Database_App
{
    partial class FormMusicApp
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
            LabelInput = new Label();
            ButtonCreateCategory = new Button();
            ButtonCreateArtist = new Button();
            ButtonCreateAlbum = new Button();
            ButtonCreateSong = new Button();
            TextBoxInput = new TextBox();
            LabelAttribution = new Label();
            LabelEmail = new LinkLabel();
            DataGridView = new DataGridView();
            ButtonUpdate = new Button();
            ButtonDelete = new Button();
            ButtonViewSongs = new Button();
            ButtonViewAlbum = new Button();
            ButtonViewArtist = new Button();
            ButtonViewCategory = new Button();
            ButtonFindArtists = new Button();
            ButtonFindSongs = new Button();
            ButtonFindAlbums = new Button();
            TextBoxQuery = new TextBox();
            LabelQuery = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // LabelInput
            // 
            LabelInput.AutoSize = true;
            LabelInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelInput.ForeColor = SystemColors.HighlightText;
            LabelInput.Location = new Point(173, 29);
            LabelInput.Name = "LabelInput";
            LabelInput.Size = new Size(62, 28);
            LabelInput.TabIndex = 1;
            LabelInput.Text = "Input:";
            // 
            // ButtonCreateCategory
            // 
            ButtonCreateCategory.Location = new Point(173, 93);
            ButtonCreateCategory.Name = "ButtonCreateCategory";
            ButtonCreateCategory.Size = new Size(206, 29);
            ButtonCreateCategory.TabIndex = 2;
            ButtonCreateCategory.Text = "Create Category";
            ButtonCreateCategory.UseVisualStyleBackColor = true;
            ButtonCreateCategory.Click += CategoryButton_Click;
            // 
            // ButtonCreateArtist
            // 
            ButtonCreateArtist.Location = new Point(403, 93);
            ButtonCreateArtist.Name = "ButtonCreateArtist";
            ButtonCreateArtist.Size = new Size(206, 29);
            ButtonCreateArtist.TabIndex = 3;
            ButtonCreateArtist.Text = "Create Artist";
            ButtonCreateArtist.UseVisualStyleBackColor = true;
            ButtonCreateArtist.Click += ArtistButton_Click;
            // 
            // ButtonCreateAlbum
            // 
            ButtonCreateAlbum.Location = new Point(633, 93);
            ButtonCreateAlbum.Name = "ButtonCreateAlbum";
            ButtonCreateAlbum.Size = new Size(206, 29);
            ButtonCreateAlbum.TabIndex = 4;
            ButtonCreateAlbum.Text = "Create Album";
            ButtonCreateAlbum.UseVisualStyleBackColor = true;
            ButtonCreateAlbum.Click += AlbumButton_Click;
            // 
            // ButtonCreateSong
            // 
            ButtonCreateSong.Location = new Point(863, 93);
            ButtonCreateSong.Name = "ButtonCreateSong";
            ButtonCreateSong.Size = new Size(207, 29);
            ButtonCreateSong.TabIndex = 5;
            ButtonCreateSong.Text = "Create Song";
            ButtonCreateSong.UseVisualStyleBackColor = true;
            ButtonCreateSong.Click += SongButton_Click;
            // 
            // TextBoxInput
            // 
            TextBoxInput.Location = new Point(173, 60);
            TextBoxInput.Name = "TextBoxInput";
            TextBoxInput.Size = new Size(897, 27);
            TextBoxInput.TabIndex = 23;
            // 
            // LabelAttribution
            // 
            LabelAttribution.AutoSize = true;
            LabelAttribution.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelAttribution.ForeColor = SystemColors.HighlightText;
            LabelAttribution.Location = new Point(15, 812);
            LabelAttribution.Name = "LabelAttribution";
            LabelAttribution.Size = new Size(141, 84);
            LabelAttribution.TabIndex = 8;
            LabelAttribution.Text = "Joseph Hansen\r\n\r\nCS3310";
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Font = new Font("Segoe UI", 12F);
            LabelEmail.LinkColor = Color.Blue;
            LabelEmail.Location = new Point(15, 839);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(211, 28);
            LabelEmail.TabIndex = 9;
            LabelEmail.TabStop = true;
            LabelEmail.Text = "josephhansen@isu.edu";
            LabelEmail.LinkClicked += linkLabel1_LinkClicked;
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(173, 155);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(897, 543);
            DataGridView.TabIndex = 10;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(1094, 41);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(209, 64);
            ButtonUpdate.TabIndex = 11;
            ButtonUpdate.Text = "Update Selected Attribute\r\n(auto-link)\r\n";
            ButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(863, 717);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(207, 29);
            ButtonDelete.TabIndex = 13;
            ButtonDelete.Text = "Delete Row";
            ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonViewSongs
            // 
            ButtonViewSongs.Location = new Point(15, 336);
            ButtonViewSongs.Name = "ButtonViewSongs";
            ButtonViewSongs.Size = new Size(138, 29);
            ButtonViewSongs.TabIndex = 17;
            ButtonViewSongs.Text = "View Songs";
            ButtonViewSongs.UseVisualStyleBackColor = true;
            // 
            // ButtonViewAlbum
            // 
            ButtonViewAlbum.Location = new Point(15, 276);
            ButtonViewAlbum.Name = "ButtonViewAlbum";
            ButtonViewAlbum.Size = new Size(138, 29);
            ButtonViewAlbum.TabIndex = 16;
            ButtonViewAlbum.Text = "View Albums";
            ButtonViewAlbum.UseVisualStyleBackColor = true;
            // 
            // ButtonViewArtist
            // 
            ButtonViewArtist.Location = new Point(15, 216);
            ButtonViewArtist.Name = "ButtonViewArtist";
            ButtonViewArtist.Size = new Size(138, 29);
            ButtonViewArtist.TabIndex = 15;
            ButtonViewArtist.Text = "View Artists";
            ButtonViewArtist.UseVisualStyleBackColor = true;
            // 
            // ButtonViewCategory
            // 
            ButtonViewCategory.Location = new Point(15, 156);
            ButtonViewCategory.Name = "ButtonViewCategory";
            ButtonViewCategory.Size = new Size(138, 29);
            ButtonViewCategory.TabIndex = 14;
            ButtonViewCategory.Text = "View Categories";
            ButtonViewCategory.UseVisualStyleBackColor = true;
            // 
            // ButtonFindArtists
            // 
            ButtonFindArtists.Location = new Point(1094, 299);
            ButtonFindArtists.Name = "ButtonFindArtists";
            ButtonFindArtists.Size = new Size(273, 29);
            ButtonFindArtists.TabIndex = 18;
            ButtonFindArtists.Text = "Find Artist with Albums in Year...";
            ButtonFindArtists.UseVisualStyleBackColor = true;
            // 
            // ButtonFindSongs
            // 
            ButtonFindSongs.Location = new Point(1094, 239);
            ButtonFindSongs.Name = "ButtonFindSongs";
            ButtonFindSongs.Size = new Size(273, 29);
            ButtonFindSongs.TabIndex = 19;
            ButtonFindSongs.Text = "Find Songs by Artist...";
            ButtonFindSongs.UseVisualStyleBackColor = true;
            // 
            // ButtonFindAlbums
            // 
            ButtonFindAlbums.Location = new Point(1094, 359);
            ButtonFindAlbums.Name = "ButtonFindAlbums";
            ButtonFindAlbums.Size = new Size(273, 29);
            ButtonFindAlbums.TabIndex = 20;
            ButtonFindAlbums.Text = "Find Albums with Song in Category...";
            ButtonFindAlbums.UseVisualStyleBackColor = true;
            // 
            // TextBoxQuery
            // 
            TextBoxQuery.Location = new Point(1094, 187);
            TextBoxQuery.Name = "TextBoxQuery";
            TextBoxQuery.Size = new Size(273, 27);
            TextBoxQuery.TabIndex = 21;
            // 
            // LabelQuery
            // 
            LabelQuery.AutoSize = true;
            LabelQuery.Font = new Font("Segoe UI", 12F);
            LabelQuery.ForeColor = SystemColors.HighlightText;
            LabelQuery.Location = new Point(1094, 156);
            LabelQuery.Name = "LabelQuery";
            LabelQuery.Size = new Size(132, 28);
            LabelQuery.TabIndex = 22;
            LabelQuery.Text = "Search Query:";
            // 
            // FormMusicApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1393, 909);
            Controls.Add(LabelQuery);
            Controls.Add(TextBoxQuery);
            Controls.Add(ButtonFindAlbums);
            Controls.Add(ButtonFindSongs);
            Controls.Add(ButtonFindArtists);
            Controls.Add(ButtonViewSongs);
            Controls.Add(ButtonViewAlbum);
            Controls.Add(ButtonViewArtist);
            Controls.Add(ButtonViewCategory);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonUpdate);
            Controls.Add(DataGridView);
            Controls.Add(LabelEmail);
            Controls.Add(LabelAttribution);
            Controls.Add(TextBoxInput);
            Controls.Add(ButtonCreateSong);
            Controls.Add(ButtonCreateAlbum);
            Controls.Add(ButtonCreateArtist);
            Controls.Add(ButtonCreateCategory);
            Controls.Add(LabelInput);
            Name = "FormMusicApp";
            Text = "Music Database Application";
            Load += FormMusicApp_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LabelInput;
        private Button ButtonCreateCategory;
        private Button ButtonCreateArtist;
        private Button ButtonCreateAlbum;
        private Button ButtonCreateSong;
        private TextBox TextBoxInput;
        private Label LabelAttribution;
        private LinkLabel LabelEmail;
        private DataGridView DataGridView;
        private Button ButtonUpdate;
        private Button ButtonDelete;
        private Button ButtonViewSongs;
        private Button ButtonViewAlbum;
        private Button ButtonViewArtist;
        private Button ButtonViewCategory;
        private Button ButtonFindArtists;
        private Button ButtonFindSongs;
        private Button ButtonFindAlbums;
        private TextBox TextBoxQuery;
        private Label LabelQuery;
    }
}
