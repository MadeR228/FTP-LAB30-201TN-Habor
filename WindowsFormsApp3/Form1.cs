using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            tbPass.PasswordChar = '*';
        }

        // При підключенні до сервера, виведемо список файлів та каталогів в TreeView
        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text);
            request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] tokens = line.Split(' ');
                string fileName = tokens[tokens.Length - 1];
                if (tokens[0].StartsWith("d"))
                {
                    // Каталог
                    treeView1.Nodes.Add(fileName, fileName, 0);
                }
                else
                {
                    // Файл
                    treeView1.Nodes.Add(fileName, fileName, 1);
                }
            }
            reader.Close();
            response.Close();
        }

        private string selectedNodePath = ""; // Змінна для зберігання шляху вибраного вузла
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Отримуємо повний шлях до вибраного вузла
            selectedNodePath = e.Node.FullPath;

            // Очищаємо вміст TreeView
            treeView1.Nodes.Clear();

            // Відображаємо вміст вибраного каталогу
            DisplayDirectoryContents(tbHost.Text + selectedNodePath);

            // Отримуємо кореневий шлях для виведення інших каталогів
            string rootPath = selectedNodePath.Substring(0, selectedNodePath.LastIndexOf("/") + 1);

            // Відображаємо вміст інших каталогів
            DisplayDirectoryContents(tbHost.Text + rootPath);
        }

        private void DisplayDirectoryContents(string path)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(path);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] tokens = line.Split(' ');
                    string fileName = tokens[tokens.Length - 1];
                    if (tokens[0].StartsWith("d"))
                    {
                        // Каталог
                        treeView1.Nodes.Add(fileName, fileName, 0);
                    }
                    else
                    {
                        // Файл
                        treeView1.Nodes.Add(fileName, fileName, 1);
                    }
                }
                reader.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }

        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string newFileName = tbUploadFile.Text; // Отримати ім'я файлу з текстового поля

                // Перевірка, чи введено ім'я файлу
                if (string.IsNullOrWhiteSpace(newFileName))
                {
                    MessageBox.Show("Будь ласка, введіть назву файлу.");
                    return;
                }

                // Створити пустий файл
                File.Create(newFileName).Close();

                // Завантажити файл на FTP сервер
                string filePathOnServer = tbWay.Text + Path.GetFileName(newFileName);
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(tbHost.Text + filePathOnServer);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                using (FileStream fileStream = File.OpenRead(newFileName))
                using (Stream ftpStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(ftpStream);
                }

                MessageBox.Show("Файл " + newFileName + " створено та завантажено на сервер.");
                // Оновити вміст TreeView
                RefreshTreeView();
            }
            catch (WebException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримати повний шлях до нового каталогу
                string fullPath = tbHost.Text + tbWay.Text + "/" + tbNewDir.Text;

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(fullPath);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("Каталог " + tbNewDir.Text + " створено.");
                }

                // Оновити вміст TreeView
                RefreshTreeView();
            }
            catch (WebException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        // Метод для оновлення вмісту TreeView
        private void RefreshTreeView()
        {
            treeView1.Nodes.Clear(); // Очищаємо вміст TreeView
            DisplayDirectoryContents(tbHost.Text); // Відображаємо вміст кореневого каталогу
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                string fileNameToDelete = tbDeleteFile.Text; // Отримуємо ім'я файлу для видалення

                // Формуємо повний шлях до файлу на сервері
                string fullPath = tbHost.Text + tbWay.Text + "/" + fileNameToDelete;

                // Створюємо запит для видалення файлу
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(fullPath);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.DeleteFile;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("Файл " + fileNameToDelete + " видалено.");
                }

                RefreshTreeView();
            }
            catch (WebException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string directoryToDelete = tbDelete.Text; // Отримуємо назву каталогу для видалення

                // Формуємо повний шлях до каталогу на сервері
                string fullPath = tbHost.Text + tbWay.Text + "/" + directoryToDelete;

                // Викликаємо метод RemoveDirectory для видалення каталогу
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(fullPath);
                request.Credentials = new NetworkCredential(tbUser.Text, tbPass.Text);
                request.Method = WebRequestMethods.Ftp.RemoveDirectory;

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show("Каталог " + directoryToDelete + " видалено.");
                }

                // Оновлюємо вміст TreeView
                RefreshTreeView();
            }
            catch (WebException ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
    }
}
