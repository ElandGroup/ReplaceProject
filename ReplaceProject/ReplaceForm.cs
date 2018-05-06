using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;



namespace ReplaceProject
{
    public partial class ReplaceForm : Form
    {
        /**
         * 
         * 说明：
         * 1.替换单独文件的内容
         * 2.替换单独的文件名
         * 3.替换所有文件夹
         * 
         //*/

        #region private Member(s)

        /// <summary>
        /// ALL Folder Info List
        /// </summary>
        List<Node> nodeFolderList = null;
        /// <summary>
        /// ALL File Info List
        /// </summary>
        List<Node> nodeFileList = null;
        /// <summary>
        /// show Directory into TextBox
        /// </summary>
        string messageTextBox = string.Empty;

        /// <summary>
        /// replace file's content by Extension name list 
        /// </summary>
        List<string> fileExtensionNameList = null;

        BackgroundWorker bgWork;

        #endregion

        #region Event

        public ReplaceForm()
        {
            InitializeComponent();
            nodeFolderList = new List<Node>();
            nodeFileList = new List<Node>();
            fileExtensionNameList = new List<string>();
            txtExtension.Text = "txt.htm.html.log.txt.xml.sln.cs.csproj.config.refresh.cshtml.asax.js";
            bgWork = new BackgroundWorker();
            bgWork.DoWork += new DoWorkEventHandler(bgWork_DoWork);
            bgWork.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWork_RunWorkerCompleted);
        }

        void bgWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Successful!");
        }

        void bgWork_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                ReplaceInfo tc = e.Argument as ReplaceInfo;

                string path = tc.Path;
             
                // string path = "D:\\Projects\\test\\Eland.Template";


                //init data
                nodeFolderList.Clear();
                nodeFileList.Clear();
                messageTextBox = string.Empty;


                Node node = new Node();
                node.Name = path.Substring(path.LastIndexOf("\\") + 1);
                node.ParentPath = path.Substring(0, path.LastIndexOf("\\"));
                node.Depth = 0;
                nodeFolderList.Add(node);

                //if (string.IsNullOrEmpty(txtFind.Text) || string.IsNullOrEmpty(txtFind.Text))
                //    return;
                ///Eland.Template
                string oldValue = tc.FindName.Trim();
                ///Eland.EOAS
                string newValue = tc.ReplaceName.Trim();

                //replace first folder's directory
                string oldFullValue = string.Empty;
                if (node.Name.Contains(oldValue))
                {
                    oldFullValue = node.Name;
                    node.Name = node.Name.Replace(oldValue, newValue);
                    Directory.Move(node.ParentPath + "\\" + oldFullValue, node.ParentPath + "\\" + node.Name);
                }


                SaveDir(node);

                ReplaceFileContent(oldValue, newValue);
                ReplaceFileName(oldValue, newValue);
                ReplaceFolderName(oldValue, newValue);

               // lblMessage.Text = "Replace successful!";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                nodeFolderList = new List<Node>();
                nodeFileList = new List<Node>();
                fileExtensionNameList = new List<string>();
            }
        }
        /// <summary>
        /// btnReplaceFile_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReplaceFile_Click(object sender, EventArgs e)
        {


            //".doc.xls.ppt.txt.htm.html.log.xlsx.docx.txt.xml.sln.cs.csproj.config.refresh"
            //default extensions , this file's extension is as follows
            string DEFAULTEXTENSIONS = "txt.htm.html.log.txt.xml.sln.cs.csproj.config.refresh.cshtml.asax.js.manifest";
            string extends = txtExtension.Text;
            string[] extendArray = null;
            if (extends == null || extends.Trim() == "")
            {
                extends = DEFAULTEXTENSIONS;
            }
            extends = extends.Replace(" ", "").Replace(".", " .").ToLower();
            extendArray = extends.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            fileExtensionNameList.AddRange(extendArray);

            //selected Directory
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
            string path = folder.SelectedPath;

            if (string.IsNullOrEmpty(path)) return;

            ReplaceInfo tc = new ReplaceInfo();
            tc.Path = path;
            tc.FindName = txtFind.Text;
            tc.ReplaceName = txtReplace.Text;

            bgWork.RunWorkerAsync(tc);


        }
        /// <summary>
        /// Ctrl+A
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 1)
            {
                txtMessage.Focus();
                txtMessage.SelectAll();
            }
        }

        #endregion

        #region private Method

        /// <summary>
        /// Save directory of (file and folder)
        /// </summary>
        /// <param name="node"></param>
        private void SaveDir(Node node)
        {
            string path = string.Empty;
            if (string.IsNullOrEmpty(node.ParentPath))
                return;
            string parentName = node.Name;
            path = node.ParentPath + "\\" + parentName;

            DirectoryInfo dir = new DirectoryInfo(path);

            //save directory of File
            string newFullName = string.Empty;
            FileInfo[] fInfos = dir.GetFiles();
            foreach (FileInfo fInfo in fInfos)
            {
                Node fileNode = new Node();
                fileNode.Name = fInfo.Name;
                fileNode.ParentPath = path;
                nodeFileList.Add(fileNode);
            }

            string[] temp = path.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
            int depth = temp.Length;
            DirectoryInfo[] dirInfos = dir.GetDirectories();
            //save directory of folder
            foreach (DirectoryInfo info in dirInfos)
            {
                Node subNode = new Node();
                subNode.Name = info.Name;
                subNode.ParentPath = path;
                subNode.Depth = depth;
                nodeFolderList.Add(subNode);
                SaveDir(subNode);
            }
        }
        /// <summary>
        /// Replace File content 
        /// </summary>
        /// <param name="oldValue"></param>
        /// <param name="newValue"></param>
        private void ReplaceFileContent(string oldValue, string newValue)
        {
            try
            {
                string path = string.Empty;
                string fileContent = string.Empty;
                FileInfo fInfo = null;
                foreach (Node nd in nodeFileList)
                {
                    path = nd.ParentPath + "\\" + nd.Name;
                    fInfo = new FileInfo(path);
                    if (fInfo.Attributes != FileAttributes.Hidden
                           && fInfo.Attributes != (FileAttributes.Archive | FileAttributes.Hidden)
                         && fileExtensionNameList.Contains(fInfo.Extension.ToLower())
                        )
                    {

                        StreamReader sr = new StreamReader(path, Encoding.UTF8);
                        fileContent = sr.ReadToEnd();
                        sr.Close();

                        if (fileContent.Contains(oldValue))
                        {
                            fileContent = fileContent.Replace(oldValue, newValue);
                            WriteByEncoding(fileContent, path, "utf-8");
                            path = path.Replace(oldValue, newValue);
                            ReplaceMessage(path, nd.Name);
                        }
                    }

                }
            }
            catch (Exception ex)
            {

               // txtMessage.Text = ex.StackTrace;
            }
        }

        private void WriteByEncoding(string fileContent, string path,string encoding)
        {
            if (encoding == "utf-8")
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                sw.Write(fileContent);
                sw.Close();

            }
            else
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.Default);
                sw.Write(fileContent);
                sw.Close();

            }
        }

        private string ReadByEncoding(string path)
        {
            string content = string.Empty;

            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
            {

                using (StreamReader sr = new StreamReader(fs, Encoding.Default))
                {
                    content = sr.ReadToEnd();
                }
            }
            return content;
        }


        /// <summary>
        /// Replace File Name 
        /// </summary>
        /// <param name="oldValue">Eland.Template</param>
        /// <param name="newValue">Eland.EOAS</param>
        private void ReplaceFileName(string oldValue, string newValue)
        {
            try
            {
                string oldFullValue = string.Empty;
                string newPath = string.Empty;
                FileInfo fInfo = null;
                foreach (Node nd in nodeFileList)
                {
                    if (nd.Name.Contains(oldValue))
                    {

                        oldFullValue = nd.Name;
                        nd.Name = nd.Name.Replace(oldValue, newValue);
                        newPath = nd.ParentPath + "\\" + nd.Name;
                        fInfo = new FileInfo(newPath);
                        //skip hidden file
                        if (fInfo.Attributes != FileAttributes.Hidden
                            && fInfo.Attributes != (FileAttributes.Archive | FileAttributes.Hidden))
                            File.Move(nd.ParentPath + "\\" + oldFullValue, newPath);

                        newPath = newPath.Replace(oldValue, newValue);
                        ReplaceMessage(newPath, oldFullValue);
                    }

                }
            }
            catch (Exception ex)
            {

                //txtMessage.Text = ex.StackTrace;
            }
        }
        /// <summary>
        /// Replace Folder Name by node's depth desc
        /// </summary>
        /// <param name="oldValue"></param>
        /// <param name="newValue"></param>
        private void ReplaceFolderName(string oldValue, string newValue)
        {
            try
            {
                nodeFolderList.Sort(new Node.NodeByDepthDesc());
                string oldFullValue = string.Empty;
                string newPath = string.Empty;
                foreach (Node nd in nodeFolderList)
                {
                    if (nd.Name.Contains(oldValue))
                    {
                        oldFullValue = nd.Name;
                        nd.Name = nd.Name.Replace(oldValue, newValue);
                        newPath = nd.ParentPath + "\\" + nd.Name;
                        Directory.Move(nd.ParentPath + "\\" + oldFullValue, newPath);
                        newPath = newPath.Replace(oldValue, newValue);
                        ReplaceMessage(newPath, oldFullValue);
                    }
                }
            }
            catch (Exception ex)
            {
                //txtMessage.Text = ex.StackTrace;
            }

        }
        /// <summary>
        /// tip replaced message
        /// </summary>
        /// <param name="path"></param>
        /// <param name="message"></param>
        private void ReplaceMessage(string path, string message)
        {
            //if (chkFast.Checked)
            //{
            //    messageTextBox += path + "\r\n";
            //    txtMessage.Text = messageTextBox;
            //    return;
            //}
            //lblMessage.Text = "Replace from ...\\" + message;
            //txtMessage.Text += path + "\r\n";
            //// txtMessage.AppendText(path + "\r\n");
            //txtMessage.Focus();
            //txtMessage.Select(txtMessage.TextLength, 0);
            //txtMessage.ScrollToCaret();
            //txtMessage.SelectionStart = txtMessage.Text.Length;
            //Application.DoEvents();
        }
        #endregion



    }

    public class ReplaceInfo
    {
        public string Path { get; set; }
        public string FindName { get; set; }
        public string ReplaceName { get; set; }
    }
}
