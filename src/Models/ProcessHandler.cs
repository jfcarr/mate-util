using System.Diagnostics;

namespace MateUtil.Models
{
    public static class ProcessHandler
    {
        public static (int, string) RunCommand(string commandName, string commandArgs)
        {
            try
            {
                var process = new Process();

                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.FileName = commandName;
                process.StartInfo.Arguments = commandArgs;

                process.Start();

                return (0, process.StandardOutput.ReadToEnd());
            }
            catch (Exception ex)
            {
                return (-1, ex.Message);
            }
        }
    }
}