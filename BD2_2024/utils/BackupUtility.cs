using System;
using System.Diagnostics;

public class BackupUtility
{
    public void RealizarBackup()
    {
        string pgDumpPath = @"C:\Program Files\PostgreSQL\16\pgAdmin 4\runtime\pg_dump.exe";
        string fileName = $"backupVENDAS_{DateTime.Now:yyyyMMddHHmmss}.sql";
        string filePath = @"C:\Users\DEV-TH~1\Desktop\" + fileName;
        string host = "127.0.0.1";
        string port = "5432";
        string username = "postgres";
        string password = "root";
        string database = "mySales";
        string schema = "public";

        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = pgDumpPath,
            Arguments = $"--file \"{filePath}\" --host \"{host}\" --port \"{port}\" --username \"{username}\" --no-password --verbose --schema \"{schema}\" \"{database}\"",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        startInfo.EnvironmentVariables["PGPASSWORD"] = password;

        using (Process process = new Process { StartInfo = startInfo })
        {
            process.OutputDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    Console.WriteLine("OUTPUT: " + e.Data);
                }
            };

            process.ErrorDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    if (e.Data.StartsWith("pg_dump: "))
                    {
                        Console.WriteLine("LOG: " + e.Data);
                    }
                    else
                    {
                        Console.WriteLine("ERROR: " + e.Data);
                    }
                }
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();

            int exitCode = process.ExitCode;

            if (exitCode != 0)
            {
                Console.WriteLine("Falha no backup: " + exitCode);
            }
        }
    }
}