using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace FTP
{
    public partial class UploadFile : Form
    {
        FtpWebRequest ftpRequest;
        private OpenFileDialog OFD;
        private int cnstIntLengthBuffer = 2048;
        string FTPAddress = "ftp://172.17.6.0/TractatsChampions/", username = "g04", password = "12345aA", fileName, filePath, NomFitxer;

        public UploadFile()
        {
            InitializeComponent();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                NomFitxer = string.Format(FTPAddress + FileTextBox.Text);

                ftpRequest = (FtpWebRequest)WebRequest.Create(NomFitxer);
                ftpRequest.Credentials = new NetworkCredential(username, password);
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                ftpRequest.UsePassive = true;
                ftpRequest.UseBinary = true;
                ftpRequest.KeepAlive = false;

                using (FileStream stmFile = System.IO.File.OpenRead(filePath))
                {
                    using (Stream stmFTP = ftpRequest.GetRequestStream())
                    {
                        byte[] arrBytBuffer = new byte[cnstIntLengthBuffer];
                        int intRead;

                        while ((intRead = stmFile.Read(arrBytBuffer, 0, cnstIntLengthBuffer)) != 0)
                        {
                            stmFTP.Write(arrBytBuffer, 0, intRead);
                        }

                        stmFTP.Close();
                    }

                    stmFile.Close();
                }

                MessageBox.Show("L'arxiu s'ha penjat amb éxit", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("No s'ha pogut penjar l'arxiu", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FileTextBox.Text = null;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            OFD = new OpenFileDialog();

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                filePath = OFD.FileName;
                fileName = filePath.Substring(filePath.LastIndexOf(("\\")) + 1);
                FileTextBox.Text = fileName;
            }
        }
    }
}