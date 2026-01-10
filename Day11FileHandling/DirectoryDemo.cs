using System.IO;
namespace Day11FileHandling
{
    public class DirectoryDemo
    {
        public void DirectoryDemoFunc(string directoryName)
        {
            if (Directory.Exists(directoryName))
            {
                System.Console.WriteLine("Folder Already Exists...");
            }
            else
            {
                Directory.CreateDirectory(directoryName);
                System.Console.WriteLine("Folder Created...");
            }
        }

        public void DriveInfoFunc(string driveName)
        {
            DriveInfo dInfo = new DriveInfo(driveName);

            System.Console.WriteLine($"Drive Name {dInfo.Name}");
            System.Console.WriteLine($"Drive File System {dInfo.DriveFormat}");
            System.Console.WriteLine($"Drive Type {dInfo.DriveType}");
            System.Console.WriteLine($"Drive Total Size {dInfo.TotalSize}");
            System.Console.WriteLine($"Drive Free Space {dInfo.TotalFreeSpace}");
        }

        public void PathDemoFunc()
        {
            string s = @"C:\temp\MyData.text\machine.config";
            System.Console.WriteLine(Path.GetFileName(s));
            System.Console.WriteLine(Path.GetTempPath());
            
        }
    }
}