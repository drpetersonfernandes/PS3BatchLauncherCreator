using System;
using System.IO;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        Console.WriteLine("Select a folder to scan:");
        string? selectedFolder = SelectFolder();

        if (string.IsNullOrEmpty(selectedFolder))
        {
            Console.WriteLine("No folder selected. Exiting application.");
            MessageBox.Show("No folder selected. Exiting application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Console.WriteLine("Select the RPCS3 binary:");
        string? rpcs3BinaryPath = SelectFile();

        if (string.IsNullOrEmpty(rpcs3BinaryPath))
        {
            Console.WriteLine("No file selected. Exiting application.");
            MessageBox.Show("No file selected. Exiting application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        CreateBatchFilesForFolders(selectedFolder, rpcs3BinaryPath);
    }

    private static string? SelectFolder()
    {
        using var fbd = new FolderBrowserDialog();
        fbd.Description = "Please select the root folder where your game folders are located.";

        DialogResult result = fbd.ShowDialog();

        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
        {
            return fbd.SelectedPath;
        }

        return null;
    }


    private static string? SelectFile()
    {
        using var ofd = new OpenFileDialog();
        ofd.Title = "Please select the RPCS3 binary file (rpcs3.exe)";
        ofd.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
        ofd.FilterIndex = 1;
        ofd.RestoreDirectory = true;

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            return ofd.FileName;
        }

        return null;
    }

    private static void CreateBatchFilesForFolders(string selectedFolder, string rpcs3BinaryPath)
    {
        string[] subdirectoryEntries = Directory.GetDirectories(selectedFolder);
        int filesCreated = 0;

        foreach (string subdirectory in subdirectoryEntries)
        {
            string ebootPath = Path.Combine(subdirectory, "PS3_GAME\\USRDIR\\EBOOT.BIN");

            if (File.Exists(ebootPath))
            {
                string batchFileName = Path.Combine(selectedFolder, Path.GetFileName(subdirectory) + ".bat");
                using (StreamWriter sw = new(batchFileName))
                {
                    sw.WriteLine($"\"{rpcs3BinaryPath}\" --no-gui \"{ebootPath}\"");
                    Console.WriteLine($"Batch file created: {batchFileName}");
                }
                filesCreated++;
            }
            else
            {
                Console.WriteLine($"EBOOT.BIN not found in {subdirectory}, skipping batch file creation.");
            }
        }

        if (filesCreated > 0)
        {
            Console.WriteLine("All necessary batch files have been successfully created.");
            MessageBox.Show("All necessary batch files have been successfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            Console.WriteLine("No EBOOT.BIN files found in subdirectories. No batch files were created.");
            MessageBox.Show("No EBOOT.BIN files found in subdirectories. No batch files were created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


}
