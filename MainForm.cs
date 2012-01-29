using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SyncSpirit.Utils;
using DiskFileSync.Beans;

namespace SyncSpirit.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        /*******************************
         * Event handlers ::
         *******************************/
        private void fromBtn_Click(object sender, EventArgs e)
        {
            this.fromPath.Text = selectFolder();
        }

        private void toBtn_Click(object sender, EventArgs e)
        {
            this.toPath.Text = selectFolder();
        }

        private void syncBtn_Click(object sender, EventArgs e)
        {
            if (this.fromPath.Text != "")
            {
                this.showFilesOfPathInList(this.fromPath.Text, this.toPath.Text);
            }
        }

        /*******************************
         * Inner methods ::
         *******************************/
        private string selectFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            return null;
        }

        private void showFilesOfPathInList(string fromPath, string toPath)
        {
            this.listView1.Items.Clear();
            /*
            List<FileInfo> fileList = new List<FileInfo>();
            gatherFilesInPath(path, fileList, true);
            foreach (FileInfo fileInfo in fileList)
            {
                string fileName = fileInfo.Name;
                string createDate = fileInfo.CreationTime.ToString();
                string modifiedDate = fileInfo.LastAccessTime.ToString();
                string size = FileUtils.GetSizeWithUnit(fileInfo.Length.ToString());

                ListViewItem item = new ListViewItem(new string[] { fileName, createDate, modifiedDate, size });
                //item.SubItems.Add("file"); what's the usage?
                this.listView1.Items.Add(item);
            }*/

            List<SyncBean<Object>> syncBeanList = new List<SyncBean<Object>>();
            gatherSyncBeans(fromPath, toPath, syncBeanList, false);
            foreach (SyncBean<Object> syncBean in syncBeanList)
            {
                string from = "", to = "", fmt = "", tmt = "", action = "";
                if (syncBean.SyncType == SyncActionType.ADD_FOLDER)
                {
                    DirectoryInfo fromFolder = (DirectoryInfo)syncBean.FromInfo;
                    DirectoryInfo toFolder = (DirectoryInfo)syncBean.ToInfo;
                    from = fromFolder.FullName;
                    fmt = fromFolder.LastWriteTime.ToString();
                    to = toFolder.FullName;
                    if(toFolder.Exists)
                        tmt = toFolder.LastWriteTime.ToString();
                    action = syncBean.SyncType.ToString();

                    //Sync
                    toFolder.Create();
                }
                else
                {
                    FileInfo fromFile = (FileInfo)syncBean.FromInfo;
                    FileInfo toFile = (FileInfo)syncBean.ToInfo;
                    from = fromFile.FullName;
                    to = toFile.FullName;
                    fmt = fromFile.LastWriteTime.ToString();
                    if(toFile.Exists)
                        tmt = toFile.LastWriteTime.ToString();
                    action = syncBean.SyncType.ToString();


                    //Sync
                    File.Copy(from, to, true);
                }
                ListViewItem item = new ListViewItem(new string[] { from, to, fmt, tmt, action } );
                this.listView1.Items.Add(item);
            }
        }

        [Obsolete]
        private void gatherFilesInPath(string path, List<FileInfo> fileList, bool root)
        {
            if (!Directory.Exists(path))
                return;

            string[] dirPaths = Directory.GetDirectories(path);
            foreach (string dirPath in dirPaths)
            {
                gatherFilesInPath(dirPath, fileList, false);
            }

            string[] filePaths = Directory.GetFiles(path);
            foreach (string filePath in filePaths)
            {
                FileInfo fileInfo = new FileInfo(filePath);
                fileList.Add(fileInfo);
            }
        }

        private void gatherSyncBeans(string fromPath, string toPath, List<SyncBean<Object>> syncBeanList, bool leaf)
        {
            if (leaf == false && !Directory.Exists(fromPath))
                return;

            string[] fromPathDirs = Directory.GetDirectories(fromPath);
            foreach (string dirPath in fromPathDirs)
            {
                string dirName = dirPath.Substring(dirPath.LastIndexOf(Path.DirectorySeparatorChar));
                string toDirPath = toPath + Path.DirectorySeparatorChar + dirName;
                if (!Directory.Exists(toDirPath))
                {
                    syncBeanList.Add(new SyncBean<Object>(new DirectoryInfo(dirPath), new DirectoryInfo(toDirPath), SyncActionType.ADD_FOLDER));
                }
                gatherSyncBeans(dirPath, toDirPath, syncBeanList, true);
            }


            string[] fromPathFiles = Directory.GetFiles(fromPath);
            foreach (string filePathFile in fromPathFiles)
            {
                FileInfo fromFileInfo = new FileInfo(filePathFile);
                FileInfo toFileInfo = new FileInfo(toPath + "/" + fromFileInfo.Name);
                //sync logic
                if (toFileInfo.Exists == false)
                {
                    syncBeanList.Add(new SyncBean<Object>(fromFileInfo, toFileInfo, SyncActionType.ADD_FILE));
                }
                else
                {
                    if (fromFileInfo.LastWriteTime > toFileInfo.LastWriteTime)
                    {
                        syncBeanList.Add(new SyncBean<Object>(fromFileInfo, toFileInfo, SyncActionType.UPDATE_FILE));
                    }
                }
            }
        }
    }
}
