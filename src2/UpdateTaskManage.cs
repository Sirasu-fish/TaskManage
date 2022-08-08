using System.Diagnostics;

namespace UpdateTaskManage
{
    public partial class UpdateTaskManage : Form
    {
        public UpdateTaskManage()
        {
            InitializeComponent();
            string currentpath = (Application.ExecutablePath).Replace(Path.GetFileName(Application.ExecutablePath), "");

            if (!File.Exists(currentpath + "\\TaskManage.zip"))
            {
                Process.Start(currentpath + "\\TaskManage.exe");
                this.Close();
            }

            if (Directory.Exists(currentpath + "\\TaskManage"))
            {
                Directory.Delete(currentpath + "\\TaskManage", true);
            }

            if (!Directory.Exists(currentpath + "\\TaskManage"))
            {
                System.IO.Compression.ZipFile.ExtractToDirectory(currentpath + "\\TaskManage.zip", currentpath + "\\TaskManage", false);
            }

            // ファイル名取得して同じファイルは削除
            string[] files = Directory.GetFiles(currentpath + "\\TaskManage", "*");
            foreach (string file in files)
            {
                if (file.Contains("UpdateTask"))
                {
                    continue;
                }
                if (File.Exists(Path.GetFileName(file)))
                {
                    File.Delete(currentpath + "\\" + Path.GetFileName(file));
                }
            }

            foreach (string file in files)
            {
                if (file.Contains("UpdateTask"))
                {
                    continue;
                }
                File.Move(currentpath + "\\TaskManage\\" + Path.GetFileName(file), currentpath + Path.GetFileName(file));
            }

            if (Directory.Exists(currentpath + "\\TaskManage"))
            {
                Directory.Delete(currentpath + "\\TaskManage", true);
            }
            Process.Start(currentpath + "\\TaskManage.exe");
            this.Close();
        }
    }
}