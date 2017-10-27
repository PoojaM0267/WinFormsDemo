using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DirectoryStructureApplication
{
    public partial class CreateDirectoryStructure : Form
    {
        public CreateDirectoryStructure()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the selectRootFolder control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void selectRootFolder_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedRootFolder = folderBrowserDialog.SelectedPath;
                
                if(!string.IsNullOrEmpty(selectedRootFolder))
                {
                    // Show selected root folder in a label
                    selectedFolder.Visible = true;
                    selectedFolder.Text = selectedRootFolder;

                    var xmlToWrite = CreateXML(selectedRootFolder);
                    xmlToWrite.Save("DirectoryStructure.xml");
                }
            }
        }

        /// <summary>
        /// Creates the XML for the folder structure.
        /// </summary>
        /// <param name="rootFolder">The root folder.</param>
        /// <returns>The XMl content to write</returns>
        private static XElement CreateXML(string rootFolder)
        {
            var xmlInfo = new XElement("serverfiles");
            xmlInfo.Add(new XElement("folder", new XAttribute("name", rootFolder)));

            foreach(var subDirectory in Directory.GetDirectories(rootFolder))
            {
                xmlInfo.Add(CreateSubdirectoryXML(subDirectory));
            }

            return xmlInfo;
        }

        /// <summary>
        /// Creates the subdirectory XML.
        /// </summary>
        /// <param name="subDirectory">The sub directory.</param>
        /// <returns>The XMl content for subdirectories</returns>
        private static XElement CreateSubdirectoryXML(string subDirectory)
        {
            var xmlSubInfo = new XElement("folder", new XAttribute("name", subDirectory));
            
            foreach (var subDir in Directory.GetDirectories(subDirectory))
            {
                xmlSubInfo.Add(CreateSubdirectoryXML(subDir));
            }

            return xmlSubInfo;
        }

        /// <summary>
        /// Handles the Click event of the closeDialog control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void closeDialog_Click(object sender, EventArgs e)
        {
            // Close the form.
            Close();
        }
    }
}
