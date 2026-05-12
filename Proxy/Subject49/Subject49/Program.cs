using System;

namespace ProxyPattern
{
    // Интерфейс
    public interface IFile
    {
        void ReadFile();
    }

    // Реален обект
    public class RealFile : IFile
    {
        private string fileName;

        public RealFile(string fileName)
        {
            this.fileName = fileName;
            LoadFile();
        }

        private void LoadFile()
        {
            Console.WriteLine($"Зареждане на файл: {fileName}");
        }

        public void ReadFile()
        {
            Console.WriteLine($"Четене на файл: {fileName}");
        }
    }

    // Proxy клас
    public class ProxyFile : IFile
    {
        private RealFile realFile;
        private string fileName;
        private string userRole;

        public ProxyFile(string fileName, string userRole)
        {
            this.fileName = fileName;
            this.userRole = userRole;
        }

        public void ReadFile()
        {
            if (userRole == "admin")
            {
                if (realFile == null)
                {
                    realFile = new RealFile(fileName);
                }

                realFile.ReadFile();
            }
            else
            {
                Console.WriteLine("Достъпът е отказан!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFile file1 = new ProxyFile("secret.txt", "admin");
            file1.ReadFile();

            Console.WriteLine();

            IFile file2 = new ProxyFile("secret.txt", "guest");
            file2.ReadFile();
        }
    }
}