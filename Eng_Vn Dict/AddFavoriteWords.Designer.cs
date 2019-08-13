namespace Eng_Vn_Dict
{
    partial class AddFavoriteWords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFavoriteWords));
            this.removeButton = new System.Windows.Forms.Button();
            this.listMeaning = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.removeAllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.BurlyWood;
            this.removeButton.Location = new System.Drawing.Point(231, 127);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(88, 29);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove Entry";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // listMeaning
            // 
            this.listMeaning.FormattingEnabled = true;
            this.listMeaning.Location = new System.Drawing.Point(12, 37);
            this.listMeaning.Name = "listMeaning";
            this.listMeaning.Size = new System.Drawing.Size(203, 212);
            this.listMeaning.TabIndex = 1;
            this.listMeaning.SelectedIndexChanged += new System.EventHandler(this.listMeaning_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.BurlyWood;
            this.searchButton.Location = new System.Drawing.Point(231, 79);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 29);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.Search_And_Close_Click);
            // 
            // removeAllButton
            // 
            this.removeAllButton.BackColor = System.Drawing.Color.BurlyWood;
            this.removeAllButton.Location = new System.Drawing.Point(231, 177);
            this.removeAllButton.Name = "removeAllButton";
            this.removeAllButton.Size = new System.Drawing.Size(88, 29);
            this.removeAllButton.TabIndex = 4;
            this.removeAllButton.Text = "Remove All";
            this.removeAllButton.UseVisualStyleBackColor = false;
            this.removeAllButton.Click += new System.EventHandler(this.Remove_All_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "----  Word List  ----";
            // 
            // AddFavoriteWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(332, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeAllButton);
            this.Controls.Add(this.listMeaning);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.searchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFavoriteWords";
            this.Text = "Favorite Words List";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox listMeaning;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button removeAllButton;
        private System.Windows.Forms.Label label1;
    }
}