namespace YTD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.UrlLinkTextBox = new System.Windows.Forms.TextBox();
            this.LogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QualityComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SetSaveFolderButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ссылка для скачивания:";
            // 
            // UrlLinkTextBox
            // 
            this.UrlLinkTextBox.Location = new System.Drawing.Point(239, 6);
            this.UrlLinkTextBox.Name = "UrlLinkTextBox";
            this.UrlLinkTextBox.Size = new System.Drawing.Size(535, 33);
            this.UrlLinkTextBox.TabIndex = 1;
            this.UrlLinkTextBox.Text = "https://youtu.be/pbyt-jBti4Y";
            // 
            // LogRichTextBox
            // 
            this.LogRichTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogRichTextBox.Location = new System.Drawing.Point(12, 114);
            this.LogRichTextBox.Name = "LogRichTextBox";
            this.LogRichTextBox.Size = new System.Drawing.Size(762, 228);
            this.LogRichTextBox.TabIndex = 2;
            this.LogRichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выбрать макс качество:";
            // 
            // QualityComboBox
            // 
            this.QualityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QualityComboBox.FormattingEnabled = true;
            this.QualityComboBox.Items.AddRange(new object[] {
            "4320",
            "2160",
            "1440",
            "1080"});
            this.QualityComboBox.Location = new System.Drawing.Point(239, 45);
            this.QualityComboBox.Name = "QualityComboBox";
            this.QualityComboBox.Size = new System.Drawing.Size(96, 33);
            this.QualityComboBox.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(647, 43);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(127, 35);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Скачать";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 85);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(762, 23);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 7;
            // 
            // SetSaveFolderButton
            // 
            this.SetSaveFolderButton.Location = new System.Drawing.Point(341, 43);
            this.SetSaveFolderButton.Name = "SetSaveFolderButton";
            this.SetSaveFolderButton.Size = new System.Drawing.Size(300, 35);
            this.SetSaveFolderButton.TabIndex = 9;
            this.SetSaveFolderButton.Text = "Выбрать место сохранения";
            this.SetSaveFolderButton.UseVisualStyleBackColor = true;
            this.SetSaveFolderButton.Click += new System.EventHandler(this.SetSaveFolderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 354);
            this.Controls.Add(this.SetSaveFolderButton);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.QualityComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogRichTextBox);
            this.Controls.Add(this.UrlLinkTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox UrlLinkTextBox;
        private RichTextBox LogRichTextBox;
        private Label label2;
        private ComboBox QualityComboBox;
        private Button SaveButton;
        private ProgressBar ProgressBar;
        private Button SetSaveFolderButton;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}