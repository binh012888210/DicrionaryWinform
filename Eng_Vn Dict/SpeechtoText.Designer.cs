namespace Eng_Vn_Dict
{
    partial class SpeechtoText
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
            this.Input_Speech = new System.Windows.Forms.TextBox();
            this.Output_Speech = new System.Windows.Forms.TextBox();
            this.Translate = new System.Windows.Forms.Button();
            this.outputLang = new System.Windows.Forms.ComboBox();
            this.inputLang = new System.Windows.Forms.ComboBox();
            this.record = new System.Windows.Forms.Button();
            this.stpRec = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input_Speech
            // 
            this.Input_Speech.Location = new System.Drawing.Point(12, 40);
            this.Input_Speech.Multiline = true;
            this.Input_Speech.Name = "Input_Speech";
            this.Input_Speech.Size = new System.Drawing.Size(322, 93);
            this.Input_Speech.TabIndex = 0;
            // 
            // Output_Speech
            // 
            this.Output_Speech.Location = new System.Drawing.Point(12, 199);
            this.Output_Speech.Multiline = true;
            this.Output_Speech.Name = "Output_Speech";
            this.Output_Speech.Size = new System.Drawing.Size(322, 95);
            this.Output_Speech.TabIndex = 1;
            // 
            // Translate
            // 
            this.Translate.BackColor = System.Drawing.Color.Gold;
            this.Translate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Translate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Translate.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Translate.Location = new System.Drawing.Point(229, 139);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(105, 54);
            this.Translate.TabIndex = 2;
            this.Translate.Text = "Translate";
            this.Translate.UseVisualStyleBackColor = false;
            this.Translate.Click += new System.EventHandler(this.Translate_Click);
            // 
            // outputLang
            // 
            this.outputLang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.outputLang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.outputLang.FormattingEnabled = true;
            this.outputLang.Location = new System.Drawing.Point(13, 172);
            this.outputLang.Name = "outputLang";
            this.outputLang.Size = new System.Drawing.Size(94, 21);
            this.outputLang.TabIndex = 3;
            // 
            // inputLang
            // 
            this.inputLang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputLang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputLang.FormattingEnabled = true;
            this.inputLang.Location = new System.Drawing.Point(13, 13);
            this.inputLang.Name = "inputLang";
            this.inputLang.Size = new System.Drawing.Size(94, 21);
            this.inputLang.TabIndex = 4;
            // 
            // record
            // 
            this.record.BackColor = System.Drawing.Color.WhiteSmoke;
            this.record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.record.Location = new System.Drawing.Point(229, 11);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(105, 23);
            this.record.TabIndex = 5;
            this.record.Text = "record";
            this.record.UseVisualStyleBackColor = false;
            this.record.Click += new System.EventHandler(this.record_Click);
            // 
            // stpRec
            // 
            this.stpRec.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stpRec.Enabled = false;
            this.stpRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stpRec.Location = new System.Drawing.Point(126, 11);
            this.stpRec.Name = "stpRec";
            this.stpRec.Size = new System.Drawing.Size(97, 23);
            this.stpRec.TabIndex = 6;
            this.stpRec.Text = "stop record";
            this.stpRec.UseVisualStyleBackColor = false;
            this.stpRec.Click += new System.EventHandler(this.stpRec_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(13, 139);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 23);
            this.clear.TabIndex = 7;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // SpeechtoText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(346, 306);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.stpRec);
            this.Controls.Add(this.record);
            this.Controls.Add(this.inputLang);
            this.Controls.Add(this.outputLang);
            this.Controls.Add(this.Translate);
            this.Controls.Add(this.Output_Speech);
            this.Controls.Add(this.Input_Speech);
            this.MaximizeBox = false;
            this.Name = "SpeechtoText";
            this.Text = "Speech To Text";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SpeechtoText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_Speech;
        private System.Windows.Forms.TextBox Output_Speech;
        private System.Windows.Forms.Button Translate;
        private System.Windows.Forms.ComboBox outputLang;
        private System.Windows.Forms.ComboBox inputLang;
        private System.Windows.Forms.Button record;
        private System.Windows.Forms.Button stpRec;
        private System.Windows.Forms.Button clear;
    }
}