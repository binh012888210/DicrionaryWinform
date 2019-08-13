namespace Eng_Vn_Dict
{
    partial class Topics
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
            this.components = new System.ComponentModel.Container();
            this.tList = new System.Windows.Forms.ComboBox();
            this.tWrdList = new System.Windows.Forms.TreeView();
            this.WPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.OPanel = new System.Windows.Forms.Panel();
            this.OpPanel = new System.Windows.Forms.Panel();
            this.tRemove_Button = new System.Windows.Forms.Button();
            this.tEdit_Button = new System.Windows.Forms.Button();
            this.tAdd_Button = new System.Windows.Forms.Button();
            this.EPanel = new System.Windows.Forms.Panel();
            this.tButton = new System.Windows.Forms.Button();
            this.SPanel = new System.Windows.Forms.Panel();
            this.tName_Update = new System.Windows.Forms.TextBox();
            this.tName_Box = new System.Windows.Forms.ComboBox();
            this.tWord_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MPanel = new System.Windows.Forms.Panel();
            this.tMeaning = new System.Windows.Forms.RichTextBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.runTime = new System.Windows.Forms.Timer(this.components);
            this.WPanel.SuspendLayout();
            this.OPanel.SuspendLayout();
            this.OpPanel.SuspendLayout();
            this.EPanel.SuspendLayout();
            this.SPanel.SuspendLayout();
            this.MPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tList
            // 
            this.tList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tList.FormattingEnabled = true;
            this.tList.Location = new System.Drawing.Point(70, 17);
            this.tList.Margin = new System.Windows.Forms.Padding(4);
            this.tList.Name = "tList";
            this.tList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tList.Size = new System.Drawing.Size(260, 21);
            this.tList.TabIndex = 0;
            this.tList.SelectedIndexChanged += new System.EventHandler(this.tList_SelectedIndexChanged);
            this.tList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tList_MouseDown);
            // 
            // tWrdList
            // 
            this.tWrdList.BackColor = System.Drawing.SystemColors.Info;
            this.tWrdList.FullRowSelect = true;
            this.tWrdList.HideSelection = false;
            this.tWrdList.Indent = 15;
            this.tWrdList.Location = new System.Drawing.Point(12, 55);
            this.tWrdList.Name = "tWrdList";
            this.tWrdList.ShowLines = false;
            this.tWrdList.Size = new System.Drawing.Size(318, 502);
            this.tWrdList.TabIndex = 7;
            this.tWrdList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tWrdList_NodeMouseClick);
            // 
            // WPanel
            // 
            this.WPanel.Controls.Add(this.label3);
            this.WPanel.Controls.Add(this.tWrdList);
            this.WPanel.Controls.Add(this.tList);
            this.WPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.WPanel.Location = new System.Drawing.Point(0, 0);
            this.WPanel.Name = "WPanel";
            this.WPanel.Size = new System.Drawing.Size(343, 570);
            this.WPanel.TabIndex = 9;
            this.WPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WPanel_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Topic :";
            // 
            // OPanel
            // 
            this.OPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.OPanel.Controls.Add(this.OpPanel);
            this.OPanel.Controls.Add(this.EPanel);
            this.OPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OPanel.Location = new System.Drawing.Point(343, 0);
            this.OPanel.Name = "OPanel";
            this.OPanel.Size = new System.Drawing.Size(439, 55);
            this.OPanel.TabIndex = 10;
            this.OPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OPanel_MouseDown);
            // 
            // OpPanel
            // 
            this.OpPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.OpPanel.Controls.Add(this.tRemove_Button);
            this.OpPanel.Controls.Add(this.tEdit_Button);
            this.OpPanel.Controls.Add(this.tAdd_Button);
            this.OpPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.OpPanel.Location = new System.Drawing.Point(369, 0);
            this.OpPanel.Name = "OpPanel";
            this.OpPanel.Size = new System.Drawing.Size(10, 55);
            this.OpPanel.TabIndex = 1;
            this.OpPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OpPanel_MouseDown);
            // 
            // tRemove_Button
            // 
            this.tRemove_Button.BackgroundImage = global::Eng_Vn_Dict.Properties.Resources.if_meanicons_24_197210;
            this.tRemove_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tRemove_Button.Enabled = false;
            this.tRemove_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tRemove_Button.FlatAppearance.BorderSize = 0;
            this.tRemove_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tRemove_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tRemove_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tRemove_Button.Location = new System.Drawing.Point(315, 15);
            this.tRemove_Button.Margin = new System.Windows.Forms.Padding(4);
            this.tRemove_Button.Name = "tRemove_Button";
            this.tRemove_Button.Size = new System.Drawing.Size(32, 32);
            this.tRemove_Button.TabIndex = 5;
            this.tRemove_Button.UseVisualStyleBackColor = true;
            this.tRemove_Button.Click += new System.EventHandler(this.tRemove_Button_Click);
            // 
            // tEdit_Button
            // 
            this.tEdit_Button.BackgroundImage = global::Eng_Vn_Dict.Properties.Resources.if_doc_edit_42214;
            this.tEdit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tEdit_Button.Enabled = false;
            this.tEdit_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tEdit_Button.FlatAppearance.BorderSize = 0;
            this.tEdit_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tEdit_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tEdit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tEdit_Button.Location = new System.Drawing.Point(182, 15);
            this.tEdit_Button.Margin = new System.Windows.Forms.Padding(4);
            this.tEdit_Button.Name = "tEdit_Button";
            this.tEdit_Button.Size = new System.Drawing.Size(32, 32);
            this.tEdit_Button.TabIndex = 6;
            this.tEdit_Button.UseVisualStyleBackColor = true;
            this.tEdit_Button.Click += new System.EventHandler(this.tEdit_Button_Click);
            // 
            // tAdd_Button
            // 
            this.tAdd_Button.BackgroundImage = global::Eng_Vn_Dict.Properties.Resources.if_Vector_icons_55_1041645;
            this.tAdd_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tAdd_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tAdd_Button.FlatAppearance.BorderSize = 0;
            this.tAdd_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tAdd_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tAdd_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tAdd_Button.Location = new System.Drawing.Point(38, 15);
            this.tAdd_Button.Margin = new System.Windows.Forms.Padding(4);
            this.tAdd_Button.Name = "tAdd_Button";
            this.tAdd_Button.Size = new System.Drawing.Size(32, 32);
            this.tAdd_Button.TabIndex = 3;
            this.tAdd_Button.UseVisualStyleBackColor = true;
            this.tAdd_Button.Click += new System.EventHandler(this.tAdd_Button_Click);
            this.tAdd_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tAdd_Button_MouseDown);
            // 
            // EPanel
            // 
            this.EPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.EPanel.Controls.Add(this.tButton);
            this.EPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.EPanel.Location = new System.Drawing.Point(379, 0);
            this.EPanel.Name = "EPanel";
            this.EPanel.Size = new System.Drawing.Size(60, 55);
            this.EPanel.TabIndex = 0;
            this.EPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EPanel_MouseDown);
            // 
            // tButton
            // 
            this.tButton.BackgroundImage = global::Eng_Vn_Dict.Properties.Resources.if_85_111106;
            this.tButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tButton.FlatAppearance.BorderSize = 0;
            this.tButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tButton.Location = new System.Drawing.Point(15, 15);
            this.tButton.Margin = new System.Windows.Forms.Padding(4);
            this.tButton.Name = "tButton";
            this.tButton.Size = new System.Drawing.Size(32, 32);
            this.tButton.TabIndex = 8;
            this.tButton.UseVisualStyleBackColor = true;
            this.tButton.Click += new System.EventHandler(this.tButton_Click);
            // 
            // SPanel
            // 
            this.SPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.SPanel.Controls.Add(this.tName_Update);
            this.SPanel.Controls.Add(this.tName_Box);
            this.SPanel.Controls.Add(this.tWord_Box);
            this.SPanel.Controls.Add(this.label2);
            this.SPanel.Controls.Add(this.label1);
            this.SPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SPanel.Location = new System.Drawing.Point(343, 55);
            this.SPanel.Name = "SPanel";
            this.SPanel.Size = new System.Drawing.Size(439, 0);
            this.SPanel.TabIndex = 11;
            this.SPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SPanel_MouseDown);
            // 
            // tName_Update
            // 
            this.tName_Update.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tName_Update.Enabled = false;
            this.tName_Update.Location = new System.Drawing.Point(182, 26);
            this.tName_Update.Name = "tName_Update";
            this.tName_Update.Size = new System.Drawing.Size(240, 20);
            this.tName_Update.TabIndex = 5;
            this.tName_Update.Visible = false;
            // 
            // tName_Box
            // 
            this.tName_Box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tName_Box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tName_Box.FormattingEnabled = true;
            this.tName_Box.Location = new System.Drawing.Point(182, 26);
            this.tName_Box.Name = "tName_Box";
            this.tName_Box.Size = new System.Drawing.Size(240, 21);
            this.tName_Box.TabIndex = 4;
            // 
            // tWord_Box
            // 
            this.tWord_Box.Location = new System.Drawing.Point(182, 81);
            this.tWord_Box.Name = "tWord_Box";
            this.tWord_Box.Size = new System.Drawing.Size(240, 20);
            this.tWord_Box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Word";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Topic Name";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // MPanel
            // 
            this.MPanel.Controls.Add(this.tMeaning);
            this.MPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPanel.Location = new System.Drawing.Point(343, 55);
            this.MPanel.Name = "MPanel";
            this.MPanel.Size = new System.Drawing.Size(439, 515);
            this.MPanel.TabIndex = 12;
            this.MPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MPanel_MouseDown);
            // 
            // tMeaning
            // 
            this.tMeaning.BackColor = System.Drawing.SystemColors.Info;
            this.tMeaning.Location = new System.Drawing.Point(0, 18);
            this.tMeaning.Name = "tMeaning";
            this.tMeaning.ReadOnly = true;
            this.tMeaning.Size = new System.Drawing.Size(422, 485);
            this.tMeaning.TabIndex = 0;
            this.tMeaning.Text = "";
            this.tMeaning.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tMeaning_MouseDown);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 5;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Timer2
            // 
            this.Timer2.Interval = 30;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // runTime
            // 
            this.runTime.Interval = 500;
            this.runTime.Tick += new System.EventHandler(this.runTime_Tick);
            // 
            // Topics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(782, 570);
            this.Controls.Add(this.MPanel);
            this.Controls.Add(this.SPanel);
            this.Controls.Add(this.OPanel);
            this.Controls.Add(this.WPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Topics";
            this.Text = "Topics";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Topics_Load);
            this.WPanel.ResumeLayout(false);
            this.WPanel.PerformLayout();
            this.OPanel.ResumeLayout(false);
            this.OpPanel.ResumeLayout(false);
            this.EPanel.ResumeLayout(false);
            this.SPanel.ResumeLayout(false);
            this.SPanel.PerformLayout();
            this.MPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox tList;
        private System.Windows.Forms.Button tAdd_Button;
        private System.Windows.Forms.Button tRemove_Button;
        private System.Windows.Forms.Button tEdit_Button;
        private System.Windows.Forms.TreeView tWrdList;
        private System.Windows.Forms.Panel WPanel;
        private System.Windows.Forms.Panel OPanel;
        private System.Windows.Forms.Panel SPanel;
        private System.Windows.Forms.TextBox tWord_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MPanel;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Panel OpPanel;
        private System.Windows.Forms.Panel EPanel;
        private System.Windows.Forms.Button tButton;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.RichTextBox tMeaning;
        private System.Windows.Forms.ComboBox tName_Box;
        private System.Windows.Forms.TextBox tName_Update;
        private System.Windows.Forms.Timer runTime;
        private System.Windows.Forms.Label label3;
    }
}