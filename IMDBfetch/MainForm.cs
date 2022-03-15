// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace IMDBfetch
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Reflection;
    using System.Windows.Forms;
    using System.Xml.Serialization;
    using Microsoft.VisualBasic;
    using PublicDomain;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The search web client.
        /// </summary>
        private WebClient searchWebClient = new WebClient();

        /// <summary>
        /// The info web client.
        /// </summary>
        private WebClient infoWebClient = new WebClient();

        /// <summary>
        /// The image web client.
        /// </summary>
        private WebClient imageWebClient = new WebClient();

        /// <summary>
        /// The API calls web client.
        /// </summary>
        private WebClient apiCallsWebClient = new WebClient();

        /// <summary>
        /// The directory.
        /// </summary>
        private string directory;

        /// <summary>
        /// The file path.
        /// </summary>
        private string filePath;

        /// <summary>
        /// The fetched count.
        /// </summary>
        private int fetchedCount = 0;

        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// The settings data.
        /// </summary>
        private SettingsData settingsData = null;

        /// <summary>
        /// The data table.
        /// </summary>
        private DataTable dataTable = new DataTable();

        /// <summary>
        /// The settings data path.
        /// </summary>
        private string settingsDataPath = $"{Application.ProductName}-SettingsData.txt";

        /// <summary>
        /// The target URI.
        /// </summary>
        private Uri targetUri = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:IMDBfetch.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Set icons */

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set PublicDomain.is tool strip menu item image
            this.freeReleasesPublicDomainIsToolStripMenuItem.Image = this.associatedIcon.ToBitmap();

            // SSL fix
            System.Net.ServicePointManager.Expect100Continue = true;
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            /* Data table */

            DataColumn column1 = new DataColumn();
            DataColumn column2 = new DataColumn();
            DataColumn column3 = new DataColumn();
            column1.DataType = System.Type.GetType("System.String");
            column2.DataType = System.Type.GetType("System.String");
            column3.DataType = System.Type.GetType("System.String");
            column1.ColumnName = "ID";
            column2.ColumnName = "Title";
            column3.ColumnName = "Description";
            dataTable.Columns.Add(column1);
            dataTable.Columns.Add(column2);
            dataTable.Columns.Add(column3);

            /* Settings data */

            // Saved settings flag
            bool prevSettingsData = false;

            // Check for settings file
            if (!File.Exists(this.settingsDataPath))
            {
                // Create new settings file
                this.SaveSettingsFile(this.settingsDataPath, new SettingsData());

                // Center form
                this.CenterToScreen();
            }
            else
            {
                // Set flag
                prevSettingsData = true;
            }

            // Load settings from disk
            this.settingsData = this.LoadSettingsFile(this.settingsDataPath);

            // Check for previous settings
            if (prevSettingsData)
            {
                // Set values
                this.directoryTextBox.Text = this.settingsData.Directory;
                this.Location = this.settingsData.Location;
                this.Size = this.settingsData.Size;
            }

            // Check radio button
            switch (this.settingsData.SortRadioButton)
            {
                case "rawRadioButton":
                    this.rawRadioButton.Checked = true;

                    break;

                case "idRadioButton":
                    this.idRadioButton.Checked = true;

                    break;

                case "titleRadioButton":
                    this.titleRadioButton.Checked = true;

                    break;

                case "descriptionRadioButton":
                    this.descriptionRadioButton.Checked = true;

                    break;
            }

            // Desc
            this.descCheckBox.Checked = this.settingsData.Desc;

            /* WebClients */

            this.searchWebClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(OnSearchDownloadStringCompleted);
            this.searchWebClient.Proxy = null;

            this.infoWebClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(OnInfoDownloadStringCompleted);
            this.infoWebClient.Proxy = null;

            this.imageWebClient.DownloadFileCompleted += new AsyncCompletedEventHandler(OnDownloadFileCompleted);
            this.imageWebClient.Proxy = null;

            this.apiCallsWebClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(OnApiCallsDownloadStringCompleted);
            this.apiCallsWebClient.Proxy = null;
        }

        /// <summary>
        /// Handles the search download string completed event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSearchDownloadStringCompleted(Object sender, DownloadStringCompletedEventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the info download string completed event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnInfoDownloadStringCompleted(Object sender, DownloadStringCompletedEventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the download file completed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the api calls download string completed event.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnApiCallsDownloadStringCompleted(Object sender, DownloadStringCompletedEventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the fetch button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFetchButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnBrowseButtonClick(object sender, EventArgs e)
        {
            this.folderBrowserDialog.SelectedPath = string.Empty;

            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK && this.folderBrowserDialog.SelectedPath.Length > 0)
            {
                this.directoryTextBox.Text = this.folderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// Handles the radio button checked changed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the desc check box checked changed.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDescCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the APIK ey tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAPIKeyToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Get raw value
            string userValue = Interaction.InputBox("API key from imdb-api.com )", "Edit key", this.settingsData.ApiKey);

            // Check length
            if (userValue.Length == 0)
            {
                // Halt flow
                return;
            }

            try
            {
                // TODO Validate API key [StartsWith("k_")]

                // Set API key
                this.settingsData.ApiKey = userValue;
            }
            catch (Exception ex)
            {
                // Advise user
                MessageBox.Show($"API key format error:{Environment.NewLine}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }


        /// <summary>
        /// Handles the free releases public domain is tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainIsToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our website
            Process.Start("https://publicdomain.is");
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/publicdomain/imdbfetch/");
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the directory text box drag drop.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDirectoryTextBoxDragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var possibleDirectory = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (Directory.Exists(possibleDirectory[0]))
                {
                    this.directoryTextBox.Text = possibleDirectory[0];
                }
            }
        }

        /// <summary>
        /// Handles the directory text box drag enter.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDirectoryTextBoxDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        /// <summary>
        /// Handles the image picture box mouse move.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnImagePictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var files = new string[] { this.filePath };

                this.imagePictureBox.DoDragDrop(new DataObject(DataFormats.FileDrop, files), DragDropEffects.Copy | DragDropEffects.Move);
            }
        }

        /// <summary>
        /// Gets the name of the valid file path.
        /// </summary>
        /// <returns>The valid file path name.</returns>
        /// <param name="rawName">Raw name.</param>
        private string GetValidFilePathName(string rawName)
        {
            var invalidCharList = new List<char>();

            invalidCharList.AddRange(Path.GetInvalidFileNameChars());

            invalidCharList.AddRange(Path.GetInvalidPathChars());

            foreach (var c in invalidCharList)
            {
                rawName = rawName.Replace(c.ToString(), string.Empty);
            }

            // Return processed raw name variable
            return rawName;
        }

        /// <summary>
        /// Handles the main form load.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormLoad(object sender, EventArgs e)
        {
            // Focus search text box
            this.searchTextBox.Focus();
        }

        /// <summary>
        /// Handles the main form form closing.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Loads the settings file.
        /// </summary>
        /// <returns>The settings file.</returns>
        /// <param name="settingsFilePath">Settings file path.</param>
        private SettingsData LoadSettingsFile(string settingsFilePath)
        {
            // Use file stream
            using (FileStream fileStream = File.OpenRead(settingsFilePath))
            {
                // Set xml serialzer
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                // Return populated settings data
                return xmlSerializer.Deserialize(fileStream) as SettingsData;
            }
        }

        /// <summary>
        /// Saves the settings file.
        /// </summary>
        /// <param name="settingsFilePath">Settings file path.</param>
        /// <param name="settingsDataParam">Settings data parameter.</param>
        private void SaveSettingsFile(string settingsFilePath, SettingsData settingsDataParam)
        {
            try
            {
                // Use stream writer
                using (StreamWriter streamWriter = new StreamWriter(settingsFilePath, false))
                {
                    // Set xml serialzer
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                    // Serialize settings data
                    xmlSerializer.Serialize(streamWriter, settingsDataParam);
                }
            }
            catch (Exception exception)
            {
                // Advise user
                MessageBox.Show($"Error saving settings file.{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{exception.Message}", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program        
            this.Close();
        }
    }
}
