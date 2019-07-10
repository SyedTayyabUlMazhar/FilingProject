namespace DirectoryAndFiling
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCreate = new System.Windows.Forms.TabPage();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBoxSubFolder = new System.Windows.Forms.ComboBox();
            this.comboBoxFolder = new System.Windows.Forms.ComboBox();
            this.comboBoxDrive = new System.Windows.Forms.ComboBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelSubfolder = new System.Windows.Forms.Label();
            this.labelFolder = new System.Windows.Forms.Label();
            this.labelDrive = new System.Windows.Forms.Label();
            this.tabPageFile = new System.Windows.Forms.TabPage();
            this.FileTabComboBoxSubFolder = new System.Windows.Forms.ComboBox();
            this.FileTabComboBoxFolder = new System.Windows.Forms.ComboBox();
            this.FileTabComboBoxDrive = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FileTabComboBoxFileName = new System.Windows.Forms.ComboBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageCreate.SuspendLayout();
            this.tabPageFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCreate);
            this.tabControl1.Controls.Add(this.tabPageFile);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCreate
            // 
            this.tabPageCreate.Controls.Add(this.textBoxFileName);
            this.tabPageCreate.Controls.Add(this.buttonCreate);
            this.tabPageCreate.Controls.Add(this.comboBoxSubFolder);
            this.tabPageCreate.Controls.Add(this.comboBoxFolder);
            this.tabPageCreate.Controls.Add(this.comboBoxDrive);
            this.tabPageCreate.Controls.Add(this.labelFileName);
            this.tabPageCreate.Controls.Add(this.labelSubfolder);
            this.tabPageCreate.Controls.Add(this.labelFolder);
            this.tabPageCreate.Controls.Add(this.labelDrive);
            this.tabPageCreate.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreate.Name = "tabPageCreate";
            this.tabPageCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreate.Size = new System.Drawing.Size(791, 306);
            this.tabPageCreate.TabIndex = 0;
            this.tabPageCreate.Text = "Create";
            this.tabPageCreate.UseVisualStyleBackColor = true;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(227, 154);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(121, 20);
            this.textBoxFileName.TabIndex = 9;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(249, 206);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 8;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // comboBoxSubFolder
            // 
            this.comboBoxSubFolder.FormattingEnabled = true;
            this.comboBoxSubFolder.Location = new System.Drawing.Point(227, 116);
            this.comboBoxSubFolder.Name = "comboBoxSubFolder";
            this.comboBoxSubFolder.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubFolder.TabIndex = 6;
            // 
            // comboBoxFolder
            // 
            this.comboBoxFolder.FormattingEnabled = true;
            this.comboBoxFolder.Location = new System.Drawing.Point(227, 79);
            this.comboBoxFolder.Name = "comboBoxFolder";
            this.comboBoxFolder.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFolder.TabIndex = 5;
            // 
            // comboBoxDrive
            // 
            this.comboBoxDrive.FormattingEnabled = true;
            this.comboBoxDrive.Location = new System.Drawing.Point(227, 41);
            this.comboBoxDrive.Name = "comboBoxDrive";
            this.comboBoxDrive.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDrive.TabIndex = 4;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(154, 157);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(60, 13);
            this.labelFileName.TabIndex = 3;
            this.labelFileName.Text = "File Name :";
            // 
            // labelSubfolder
            // 
            this.labelSubfolder.AutoSize = true;
            this.labelSubfolder.Location = new System.Drawing.Point(156, 118);
            this.labelSubfolder.Name = "labelSubfolder";
            this.labelSubfolder.Size = new System.Drawing.Size(58, 13);
            this.labelSubfolder.TabIndex = 2;
            this.labelSubfolder.Text = "Subfolder :";
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.Location = new System.Drawing.Point(172, 81);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(42, 13);
            this.labelFolder.TabIndex = 1;
            this.labelFolder.Text = "Folder :";
            // 
            // labelDrive
            // 
            this.labelDrive.AutoSize = true;
            this.labelDrive.Location = new System.Drawing.Point(178, 45);
            this.labelDrive.Name = "labelDrive";
            this.labelDrive.Size = new System.Drawing.Size(38, 13);
            this.labelDrive.TabIndex = 0;
            this.labelDrive.Text = "Drive :";
            // 
            // tabPageFile
            // 
            this.tabPageFile.Controls.Add(this.buttonDelete);
            this.tabPageFile.Controls.Add(this.buttonWrite);
            this.tabPageFile.Controls.Add(this.buttonRead);
            this.tabPageFile.Controls.Add(this.FileTabComboBoxFileName);
            this.tabPageFile.Controls.Add(this.richTextBox1);
            this.tabPageFile.Controls.Add(this.FileTabComboBoxSubFolder);
            this.tabPageFile.Controls.Add(this.FileTabComboBoxFolder);
            this.tabPageFile.Controls.Add(this.FileTabComboBoxDrive);
            this.tabPageFile.Controls.Add(this.label1);
            this.tabPageFile.Controls.Add(this.label2);
            this.tabPageFile.Controls.Add(this.label3);
            this.tabPageFile.Controls.Add(this.label4);
            this.tabPageFile.Location = new System.Drawing.Point(4, 22);
            this.tabPageFile.Name = "tabPageFile";
            this.tabPageFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFile.Size = new System.Drawing.Size(791, 306);
            this.tabPageFile.TabIndex = 1;
            this.tabPageFile.Text = "File";
            this.tabPageFile.UseVisualStyleBackColor = true;
            // 
            // FileTabComboBoxSubFolder
            // 
            this.FileTabComboBoxSubFolder.FormattingEnabled = true;
            this.FileTabComboBoxSubFolder.Location = new System.Drawing.Point(91, 101);
            this.FileTabComboBoxSubFolder.Name = "FileTabComboBoxSubFolder";
            this.FileTabComboBoxSubFolder.Size = new System.Drawing.Size(121, 21);
            this.FileTabComboBoxSubFolder.TabIndex = 16;
            // 
            // FileTabComboBoxFolder
            // 
            this.FileTabComboBoxFolder.FormattingEnabled = true;
            this.FileTabComboBoxFolder.Location = new System.Drawing.Point(91, 64);
            this.FileTabComboBoxFolder.Name = "FileTabComboBoxFolder";
            this.FileTabComboBoxFolder.Size = new System.Drawing.Size(121, 21);
            this.FileTabComboBoxFolder.TabIndex = 15;
            // 
            // FileTabComboBoxDrive
            // 
            this.FileTabComboBoxDrive.FormattingEnabled = true;
            this.FileTabComboBoxDrive.Location = new System.Drawing.Point(91, 26);
            this.FileTabComboBoxDrive.Name = "FileTabComboBoxDrive";
            this.FileTabComboBoxDrive.Size = new System.Drawing.Size(121, 21);
            this.FileTabComboBoxDrive.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "File Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Subfolder :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Folder :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Drive :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(270, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(513, 272);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // FileTabComboBoxFileName
            // 
            this.FileTabComboBoxFileName.FormattingEnabled = true;
            this.FileTabComboBoxFileName.Location = new System.Drawing.Point(91, 139);
            this.FileTabComboBoxFileName.Name = "FileTabComboBoxFileName";
            this.FileTabComboBoxFileName.Size = new System.Drawing.Size(121, 21);
            this.FileTabComboBoxFileName.TabIndex = 19;
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(21, 197);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(49, 23);
            this.buttonRead.TabIndex = 20;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(112, 197);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(49, 23);
            this.buttonWrite.TabIndex = 21;
            this.buttonWrite.Text = "Write";
            this.buttonWrite.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(193, 197);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(49, 23);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCreate.ResumeLayout(false);
            this.tabPageCreate.PerformLayout();
            this.tabPageFile.ResumeLayout(false);
            this.tabPageFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCreate;
        private System.Windows.Forms.TabPage tabPageFile;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ComboBox comboBoxSubFolder;
        private System.Windows.Forms.ComboBox comboBoxFolder;
        private System.Windows.Forms.ComboBox comboBoxDrive;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelSubfolder;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.Label labelDrive;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.ComboBox FileTabComboBoxFileName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox FileTabComboBoxSubFolder;
        private System.Windows.Forms.ComboBox FileTabComboBoxFolder;
        private System.Windows.Forms.ComboBox FileTabComboBoxDrive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Button buttonRead;
    }
}

