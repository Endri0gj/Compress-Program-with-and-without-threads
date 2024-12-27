using System.Diagnostics;
using System.IO.Compression;

namespace Laborator6_Endri_Gjini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            
            try
            {
                stopwatch.Start();
                string sourceDirectory = textBox1.Text;
                string destinationDirectory = textBox2.Text;

                if (string.IsNullOrEmpty(sourceDirectory) || string.IsNullOrEmpty(destinationDirectory))
                {
                    MessageBox.Show("Selektoni hyrjen dhe destinacionin.");
                    return;
                }

                string[] files = Directory.GetFiles(sourceDirectory);
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string compressedFilePath = Path.Combine(destinationDirectory, fileName + ".egj");

                    using (FileStream fileStream = File.Open(file, FileMode.Open))
                    using (FileStream compressedFileStream = File.Create(compressedFilePath))
                    using (var compress = new GZipStream(compressedFileStream, CompressionMode.Compress, false))
                    {
                        byte[] b = new byte[fileStream.Length];
                        int read = fileStream.Read(b, 0, b.Length);

                        while (read > 0)
                        {
                            compress.Write(b, 0, read);
                            read = fileStream.Read(b, 0, b.Length);
                        }
                    }
                }
                stopwatch.Stop();

                MessageBox.Show("Filet u kompresuan me sukses per : " + stopwatch.ElapsedMilliseconds + " milisekonda.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            textBox1.Text = folderBrowserDialog.SelectedPath;
        }


        void button2_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            try
            {
                stopwatch.Start();
                string sourceDirectory = textBox1.Text;
                string destinationDirectory = textBox2.Text;

                if (string.IsNullOrEmpty(sourceDirectory) || string.IsNullOrEmpty(destinationDirectory))
                {
                    MessageBox.Show("Selektoni hyrjen dhe destinacionin.");
                    return;
                }

                string[] files = Directory.GetFiles(sourceDirectory);
                foreach (string file in files)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    string decompressedFilePath = Path.Combine(destinationDirectory, fileName);

                    using (FileStream compressedFileStream = File.Open(file, FileMode.Open))
                    using (FileStream decompressedFileStream = File.Create(decompressedFilePath))
                    using (var decompress = new GZipStream(compressedFileStream, CompressionMode.Decompress))
                    {
                        decompress.CopyTo(decompressedFileStream);
                    }
                }
                stopwatch.Stop();
                MessageBox.Show("Filet u dekompresuan me sukses per : " + stopwatch.ElapsedMilliseconds + " milisekonda.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void button4_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            textBox2.Text = folderBrowserDialog1.SelectedPath;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            try
            {
                stopwatch.Start();
                string sourceDirectory = textBox1.Text;
                string destinationDirectory = textBox2.Text;

                if (string.IsNullOrEmpty(sourceDirectory) || string.IsNullOrEmpty(destinationDirectory))
                {
                    MessageBox.Show("Selektoni hyrjen dhe destinacionin.");
                    return;
                }

                string[] files = Directory.GetFiles(sourceDirectory);
                Parallel.ForEach(files, (file) =>
                {
                    string fileName = Path.GetFileName(file);
                    string compressedFilePath = Path.Combine(destinationDirectory, fileName + ".egj");

                    using (FileStream fileStream = File.Open(file, FileMode.Open))
                    using (FileStream compressedFileStream = File.Create(compressedFilePath))
                    using (var compress = new GZipStream(compressedFileStream, CompressionMode.Compress, false))
                    {
                        byte[] b = new byte[fileStream.Length];
                        int read = fileStream.Read(b, 0, b.Length);

                        while (read > 0)
                        {
                            compress.Write(b, 0, read);
                            read = fileStream.Read(b, 0, b.Length);
                        }
                    }
                });
                stopwatch.Stop();
                MessageBox.Show("Filet u kompresuan me sukses per : " + stopwatch.ElapsedMilliseconds + " milisekonda.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            try
            {
                string sourceDirectory = textBox1.Text;
                string destinationDirectory = textBox2.Text;

                if (string.IsNullOrEmpty(sourceDirectory) || string.IsNullOrEmpty(destinationDirectory))
                {
                    MessageBox.Show("Selektoni hyrjen dhe destinacionin.");
                    return;
                }

                string[] files = Directory.GetFiles(sourceDirectory);
                Parallel.ForEach(files, (file) =>
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    string decompressedFilePath = Path.Combine(destinationDirectory, fileName);

                    using (FileStream compressedFileStream = File.Open(file, FileMode.Open))
                    using (FileStream decompressedFileStream = File.Create(decompressedFilePath))
                    using (var decompress = new GZipStream(compressedFileStream, CompressionMode.Decompress))
                    {
                        decompress.CopyTo(decompressedFileStream);
                    }
                });
                stopwatch.Stop();
                MessageBox.Show("Filet u dekompresuan me sukses per : " + stopwatch.ElapsedMilliseconds + " milisekonda.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
