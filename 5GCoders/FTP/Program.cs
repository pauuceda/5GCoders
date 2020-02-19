using System;
using System.IO;
using System.Net;
using System.Text;

namespace FTP
{
    public class WebRequestGetExample
    {
        public static void Main()
        {
            char opcio;
            string input, FTPAddress = "ftp://172.17.6.0/TractatsChampions/", username = "g04", password = "12345aA", NomArxiu;
            bool NomCorrecte = false;
            int bufferSize = 2048, readCount;

            do
            {
                Console.Write("Vols baixar un arxiu de la base de dades? S/N\n");
                input = Console.ReadLine();

                if (input.Length == 1)
                {
                    opcio = Convert.ToChar(input.ToUpper());

                    if (opcio == 'S')
                    {
                        while (!NomCorrecte)
                        {
                            Console.Write("Quin arxiu vols baixar?\n");
                            NomArxiu = Console.ReadLine();

                            try
                            {
                                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FTPAddress + NomArxiu);
                                request.Credentials = new NetworkCredential(username, password);
                                request.Method = WebRequestMethods.Ftp.DownloadFile;
                                //request.Method = WebRequestMethods.Ftp.Rename;
                                //request.RenameTo = "/TractatsChampions/" + NomArxiu;
                                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                                Stream responseStream = response.GetResponseStream();
                                StreamReader reader = new StreamReader(responseStream);

                                using (FileStream writer = new FileStream(NomArxiu, FileMode.Create))
                                {
                                    long length = response.ContentLength;
                                    byte[] buffer = new byte[bufferSize];
                                    readCount = responseStream.Read(buffer, 0, bufferSize);

                                    while (readCount > 0)
                                    {
                                        writer.Write(buffer, 0, readCount);
                                        readCount = responseStream.Read(buffer, 0, bufferSize);
                                    }
                                }

                                Console.WriteLine("\nDescàrrega completada\n");
                                reader.Close();
                                response.Close();

                                NomCorrecte = true;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("No s'ha trobat cap arxiu anomenat " + NomArxiu);
                            }
                        }

                        NomCorrecte = false;
                    }
                    else if (opcio == 'N')
                    {
                        Environment.Exit(0);
                    }
                }
            } while (input != "N");

            Environment.Exit(0);
        }
    }
}