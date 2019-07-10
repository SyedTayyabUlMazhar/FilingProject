using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryAndFiling
{
    public partial class Form1 : Form
    {
        string backSlash = "\\";
        bool textFileNameExists = false;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            comboBoxDrive.SelectedValueChanged += ComboBoxDrive_SelectedValueChanged;
            comboBoxFolder.SelectedValueChanged += ComboBoxFolder_SelectedValueChanged;

            FileTabComboBoxDrive.SelectedValueChanged += FileTabComboBoxDrive_SelectedValueChanged;
            FileTabComboBoxFolder.SelectedValueChanged += FileTabComboBoxFolder_SelectedValueChanged;
            FileTabComboBoxSubFolder.SelectedValueChanged += FileTabComboBoxSubFolder_SelectedValueChanged;

            buttonCreate.Click += ButtonCreate_Click;

            buttonRead.Click += ButtonRead_Click;
            buttonWrite.Click += ButtonWrite_Click;
            buttonDelete.Click += ButtonDelete_Click;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string filePath = FileTabComboBoxDrive.Text
                + FileTabComboBoxFolder.Text + "\\"
                + FileTabComboBoxSubFolder.Text + "\\"
                + FileTabComboBoxFileName.Text;

            File.Delete(filePath);
        }

        private void ButtonWrite_Click(object sender, EventArgs e)
        {
            string filePath = FileTabComboBoxDrive.Text
                + FileTabComboBoxFolder.Text + "\\"
                + FileTabComboBoxSubFolder.Text + "\\"
                + FileTabComboBoxFileName.Text;

            File.WriteAllText(filePath, richTextBox1.Text);
        }

        private void ButtonRead_Click(object sender, EventArgs e)
        {
            string filePath = FileTabComboBoxDrive.Text
                + FileTabComboBoxFolder.Text + "\\"
                + FileTabComboBoxSubFolder.Text + "\\"
                + FileTabComboBoxFileName.Text;

            string textRead = File.ReadAllText(filePath);
            richTextBox1.Text = textRead;
        }

        private void FileTabComboBoxSubFolder_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadTextFileNamesInComboxBox();
        }

        private void LoadTextFileNamesInComboxBox()
        {
            FileTabComboBoxFileName.Text = "";
            FileTabComboBoxFileName.Items.Clear();
            string path = FileTabComboBoxDrive.Text + FileTabComboBoxFolder.Text + "\\" + FileTabComboBoxSubFolder.Text + "\\";

            IEnumerable<string> fileNames = Directory.EnumerateFiles(path, "*.txt");
            foreach (string fileName in fileNames)
                FileTabComboBoxFileName.Items.Add(fileName.Substring(fileName.LastIndexOf("\\") + 1));
        }

        private void FileTabComboBoxFolder_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadSubFolderNameInComboBox(FileTabComboBoxDrive.Text + FileTabComboBoxFolder.Text + "\\", FileTabComboBoxSubFolder);
        }

        private void FileTabComboBoxDrive_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadFolderNameInComboBox(FileTabComboBoxDrive.Text, FileTabComboBoxFolder);
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            //if (textBoxFileName.Text.Equals("")) textFileNameExists = false;
            //else textFileNameExists = true;

            string path = getPathToCreate();
            Directory.CreateDirectory(path);

            if (!textBoxFileName.Text.Equals(""))
                File.Create(path + "\\" + textBoxFileName.Text + ".txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDriveNamesInComboBox(comboBoxDrive);
            LoadDriveNamesInComboBox(FileTabComboBoxDrive);
        }

        private void ComboBoxDrive_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadFolderNameInComboBox(comboBoxDrive.Text, comboBoxFolder);
        }

        private void ComboBoxFolder_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadSubFolderNameInComboBox(comboBoxDrive.Text + comboBoxFolder.Text + "\\", comboBoxSubFolder);
        }

        private void LoadDriveNamesInComboBox(ComboBox drive)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach(DriveInfo driveInfo in drives)
            {
                drive.Items.Add(driveInfo.Name);
            }
        }

        private void LoadFolderNameInComboBox(String drive, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Text = "";

            
            IEnumerable<String> dirs = Directory.EnumerateDirectories(drive);

            foreach(String dir in dirs)
            {
                string folderName = dir.Substring(dir.LastIndexOf("\\")+1);
                comboBox.Items.Add(folderName);
            }

        }

        private void LoadSubFolderNameInComboBox(string folderPath, ComboBox comboBox)
        {
            comboBoxSubFolder.Items.Clear();
            comboBoxSubFolder.Text = "";

            //string folderPath = comboBoxDrive.Text + comboBoxFolder.Text + "\\";
            IEnumerable<String> dirs = Directory.EnumerateDirectories(folderPath);

            foreach (String dir in dirs)
            {
                string subFolderName = dir.Substring(dir.LastIndexOf("\\") + 1);
                comboBox.Items.Add(subFolderName);
            }

        }

        private string getPathToCreate()
        {

            String path = comboBoxDrive.Text
                + comboBoxFolder.Text + "\\"
                + comboBoxSubFolder.Text;
               
            return path;
        }
    }
}
