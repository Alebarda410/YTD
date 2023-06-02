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
            this.SetSaveFolderButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
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
            // 
            // LogRichTextBox
            // 
            this.LogRichTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogRichTextBox.Location = new System.Drawing.Point(12, 158);
            this.LogRichTextBox.Name = "LogRichTextBox";
            this.LogRichTextBox.Size = new System.Drawing.Size(762, 324);
            this.LogRichTextBox.TabIndex = 2;
            this.LogRichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
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
            this.QualityComboBox.Location = new System.Drawing.Point(239, 80);
            this.QualityComboBox.Name = "QualityComboBox";
            this.QualityComboBox.Size = new System.Drawing.Size(96, 33);
            this.QualityComboBox.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(647, 78);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(127, 35);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Скачать";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SetSaveFolderButton
            // 
            this.SetSaveFolderButton.Location = new System.Drawing.Point(341, 78);
            this.SetSaveFolderButton.Name = "SetSaveFolderButton";
            this.SetSaveFolderButton.Size = new System.Drawing.Size(300, 35);
            this.SetSaveFolderButton.TabIndex = 9;
            this.SetSaveFolderButton.Text = "Выбрать место сохранения";
            this.SetSaveFolderButton.UseVisualStyleBackColor = true;
            this.SetSaveFolderButton.Click += new System.EventHandler(this.SetSaveFolderButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(393, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(191, 29);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Скачивание M3U8";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(239, 45);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(148, 29);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Только аудио";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Расширенные опции:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(239, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(534, 33);
            this.textBox1.TabIndex = 13;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(590, 45);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(183, 29);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "Вести файл логов";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(14, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ручные опции:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 491);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SetSaveFolderButton);
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
        private Button SetSaveFolderButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label3;
        private TextBox textBox1;
        private CheckBox checkBox3;
        private Label label4;
    }
}