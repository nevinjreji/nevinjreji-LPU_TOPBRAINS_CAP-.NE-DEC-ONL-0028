using System.IO;
namespace Day11FileHandling
{
    class FileStreamDemo
    {
        FileStream fs = null;
        public void CreateFile(string FileName)
        {
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(FileName, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine("Hello Dsouza!! Welcome to .NET");
            }
            catch (FileNotFoundException e)
            {
                System.Console.WriteLine(e.Message);
            }
            catch (FileLoadException e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }
        public void ReadFile(string FileName)
        {
            fs = new FileStream(FileName,FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            System.Console.WriteLine(sr.ReadToEnd());

            sr.Close();
            fs.Close();
        }
    }
}
