namespace Eng_Vn_Dict
{
    partial class EngtoVnDict
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EngtoVnDict));
            this.wordSearch = new System.Windows.Forms.TextBox();
            this.wordList = new System.Windows.Forms.ListBox();
            this.wordMeaning = new System.Windows.Forms.RichTextBox();
            this.viewImageButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseTool = new System.Windows.Forms.ToolStripMenuItem();
            this.addTopics = new System.Windows.Forms.ToolStripMenuItem();
            this.advanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Speech_Text = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteWordsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFavortiteWords = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.speakButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // wordSearch
            // 
            this.wordSearch.Location = new System.Drawing.Point(12, 36);
            this.wordSearch.MaxLength = 20;
            this.wordSearch.Name = "wordSearch";
            this.wordSearch.Size = new System.Drawing.Size(263, 20);
            this.wordSearch.TabIndex = 1;
            this.wordSearch.TextChanged += new System.EventHandler(this.wordSearch_TextChanged);
            // 
            // wordList
            // 
            this.wordList.BackColor = System.Drawing.SystemColors.Info;
            this.wordList.FormattingEnabled = true;
            this.wordList.Location = new System.Drawing.Point(12, 97);
            this.wordList.Name = "wordList";
            this.wordList.Size = new System.Drawing.Size(263, 407);
            this.wordList.TabIndex = 3;
            this.wordList.SelectedIndexChanged += new System.EventHandler(this.wordList_SelectedIndexChanged);
            // 
            // wordMeaning
            // 
            this.wordMeaning.BackColor = System.Drawing.SystemColors.Info;
            this.wordMeaning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wordMeaning.Location = new System.Drawing.Point(281, 36);
            this.wordMeaning.Name = "wordMeaning";
            this.wordMeaning.ReadOnly = true;
            this.wordMeaning.Size = new System.Drawing.Size(314, 345);
            this.wordMeaning.TabIndex = 5;
            this.wordMeaning.Text = "";
            // 
            // viewImageButton
            // 
            this.viewImageButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.viewImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewImageButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.viewImageButton.Location = new System.Drawing.Point(186, 62);
            this.viewImageButton.Name = "viewImageButton";
            this.viewImageButton.Size = new System.Drawing.Size(89, 29);
            this.viewImageButton.TabIndex = 8;
            this.viewImageButton.Text = "View Image";
            this.viewImageButton.UseVisualStyleBackColor = false;
            this.viewImageButton.Click += new System.EventHandler(this.viewImageButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PapayaWhip;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addTopics,
            this.advanceToolStripMenuItem,
            this.favoriteWordsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseTool});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // CloseTool
            // 
            this.CloseTool.Name = "CloseTool";
            this.CloseTool.Size = new System.Drawing.Size(103, 22);
            this.CloseTool.Text = "&Close";
            this.CloseTool.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // addTopics
            // 
            this.addTopics.Name = "addTopics";
            this.addTopics.Size = new System.Drawing.Size(53, 20);
            this.addTopics.Text = "&Topics";
            this.addTopics.Click += new System.EventHandler(this.addTopics_Click);
            // 
            // advanceToolStripMenuItem
            // 
            this.advanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Speech_Text});
            this.advanceToolStripMenuItem.Name = "advanceToolStripMenuItem";
            this.advanceToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.advanceToolStripMenuItem.Text = "A&dvance";
            // 
            // Speech_Text
            // 
            this.Speech_Text.Name = "Speech_Text";
            this.Speech_Text.Size = new System.Drawing.Size(148, 22);
            this.Speech_Text.Text = "&Speech to text";
            this.Speech_Text.Click += new System.EventHandler(this.Speech2Text_Click);
            // 
            // favoriteWordsToolStripMenuItem
            // 
            this.favoriteWordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favoriteWordsManagementToolStripMenuItem});
            this.favoriteWordsToolStripMenuItem.Name = "favoriteWordsToolStripMenuItem";
            this.favoriteWordsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.favoriteWordsToolStripMenuItem.Text = "Favorite Words";
            // 
            // favoriteWordsManagementToolStripMenuItem
            // 
            this.favoriteWordsManagementToolStripMenuItem.Name = "favoriteWordsManagementToolStripMenuItem";
            this.favoriteWordsManagementToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.favoriteWordsManagementToolStripMenuItem.Text = "Favorite Word List";
            this.favoriteWordsManagementToolStripMenuItem.Click += new System.EventHandler(this.favoriteWordsManagementToolStripMenuItem_Click);
            // 
            // addFavortiteWords
            // 
            this.addFavortiteWords.BackColor = System.Drawing.Color.Tan;
            this.addFavortiteWords.BackgroundImage = global::Eng_Vn_Dict.Properties.Resources.Icojam_Onebit_Star_0;
            this.addFavortiteWords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addFavortiteWords.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.addFavortiteWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFavortiteWords.ForeColor = System.Drawing.Color.SkyBlue;
            this.addFavortiteWords.Location = new System.Drawing.Point(149, 62);
            this.addFavortiteWords.Name = "addFavortiteWords";
            this.addFavortiteWords.Size = new System.Drawing.Size(31, 29);
            this.addFavortiteWords.TabIndex = 10;
            this.addFavortiteWords.UseVisualStyleBackColor = false;
            this.addFavortiteWords.Click += new System.EventHandler(this.addFavortiteWord_Click);
            this.addFavortiteWords.MouseEnter += new System.EventHandler(this.addFavortiteWord_MouseEnter);
            this.addFavortiteWords.MouseLeave += new System.EventHandler(this.addFavortiteWord_MouseLeave);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox.Location = new System.Drawing.Point(281, 387);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(129, 117);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // speakButton
            // 
            this.speakButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.speakButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speakButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speakButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.speakButton.Image = global::Eng_Vn_Dict.Properties.Resources.speech;
            this.speakButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.speakButton.Location = new System.Drawing.Point(12, 62);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(90, 29);
            this.speakButton.TabIndex = 6;
            this.speakButton.Text = "Speak";
            this.speakButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.speakButton.UseVisualStyleBackColor = false;
            this.speakButton.Click += new System.EventHandler(this.speakButton_Click);
            // 
            // EngtoVnDict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(607, 520);
            this.Controls.Add(this.addFavortiteWords);
            this.Controls.Add(this.viewImageButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.speakButton);
            this.Controls.Add(this.wordMeaning);
            this.Controls.Add(this.wordList);
            this.Controls.Add(this.wordSearch);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "EngtoVnDict";
            this.Text = "Engish to Vietnamese Dictionary";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox wordSearch;
        private System.Windows.Forms.ListBox wordList;
        private System.Windows.Forms.RichTextBox wordMeaning;
        private System.Windows.Forms.Button speakButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button viewImageButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseTool;
        private System.Windows.Forms.ToolStripMenuItem addTopics;
        private System.Windows.Forms.ToolStripMenuItem advanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Speech_Text;
        private System.Windows.Forms.Button addFavortiteWords;
        private System.Windows.Forms.ToolStripMenuItem favoriteWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoriteWordsManagementToolStripMenuItem;
    }
}

