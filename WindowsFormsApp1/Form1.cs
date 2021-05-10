using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBO = new FolderBrowserDialog();
            if (FBO.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    Folderdata(FBO.SelectedPath);
                    LisrDirectory(FoldersAndF, FBO.SelectedPath);
                    CreateXml(FBO.SelectedPath);

                }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }



        private void LisrDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {


            var DirectoryNode = new TreeNode(directoryInfo.Name);

            foreach (var directory in directoryInfo.GetDirectories())

                DirectoryNode.Nodes.Add(CreateDirectoryNode(directory));


            foreach (var files in directoryInfo.GetFiles())


                DirectoryNode.Nodes.Add(new TreeNode(files.Name));


            return DirectoryNode;

        }


        void CreateXml(string pathToFolder)
        {
            int i = 0;
            long length = 0;
            var rootDirInfo = new DirectoryInfo(pathToFolder);
                using (XmlWriter writer = XmlWriter.Create("folders.xml"))
                {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings { ConformanceLevel = ConformanceLevel.Fragment };

                XmlWriterSettings settings = new XmlWriterSettings();
                    settings.OmitXmlDeclaration = true;
                    settings.ConformanceLevel = ConformanceLevel.Fragment;
                    settings.CloseOutput = false;
                writer.WriteStartElement(rootDirInfo.Name.ToString());
                if (rootDirInfo.GetDirectories().Count() > 0)
                {
                    foreach (var directory in rootDirInfo.GetDirectories())
                    {
                       
                        writer.WriteStartElement("folderName", directory.Name.ToString());

                        foreach (var files in directory.GetFiles())
                        {
                            length += files.Length;
                            i++;
                            writer.WriteStartElement("fileName", files.Name);
                            writer.WriteElementString("FileSize", files.Length.ToString());
                            writer.WriteElementString("CreationTime", files.CreationTime.ToString());
                            writer.WriteElementString("fileLastAccessTime", files.LastAccessTime.ToString());
                            writer.WriteElementString("FileLastModifiedTime", files.LastWriteTime.ToString());
                            writer.WriteEndElement();
                        }
                    }
                    writer.WriteElementString("FolderSize", length.ToString());
                    writer.WriteElementString("NuberOfFiles", i.ToString());
                    writer.WriteEndElement();

                }
                
                    foreach (var files in rootDirInfo.GetFiles())
                    {
                        writer.WriteStartElement(rootDirInfo.Name.ToString());
                        writer.WriteStartElement("fileName", files.Name);
                        writer.WriteElementString("FileSize", files.Length.ToString());
                        writer.WriteElementString("CreationTime", files.CreationTime.ToString());
                        writer.WriteElementString("fileLastAccessTime", files.LastAccessTime.ToString());
                        writer.WriteElementString("FileLastModifiedTime", files.LastWriteTime.ToString());
                        writer.WriteEndElement();
                    }
                
               



                writer.WriteEndElement();
               
                  
                     writer.WriteEndDocument();
                     writer.Flush();
                     writer.Close();


            } 

        
        }

        void Folderdata(string path)
        {
            
            var rootFolder = new DirectoryInfo(path);
            dataFolder.Columns.Add("Folder name", 77, HorizontalAlignment.Center);
            dataFolder.Columns.Add("Folder size", 66, HorizontalAlignment.Center);
            dataFolder.Columns.Add("Number of files", 88, HorizontalAlignment.Center);
            ListViewItem eachRow = new ListViewItem(rootFolder.Name);
            long length = 0;
            int i = 0;
          
            
                foreach (var files in rootFolder.GetFiles())
                {
                    length += files.Length;
                    i++;
                }
            
           

                
                
          
            ListViewItem.ListViewSubItem folderSize = new ListViewItem.ListViewSubItem(eachRow, length.ToString());
                ListViewItem.ListViewSubItem numberOfFiles = new ListViewItem.ListViewSubItem(eachRow, i.ToString());
                eachRow.SubItems.Add(folderSize);
                eachRow.SubItems.Add(numberOfFiles);
                dataFolder.Items.Add(eachRow);
            }
   

    }
}


