namespace PZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\фоточки\dd";
            RenameFiles(path);
        }
        static void RenameFiles(string path)
        {
            string[] files = Directory.GetFiles(path, "*.txt");
            foreach (string filepath in files)
            {
                string filename = Path.GetFileName(filepath);
                string newname = filename + "NEW.txt";
                string newpath = Path.Combine(path, newname);
                File.Move(filepath, newpath);
            }
        }
    }
}