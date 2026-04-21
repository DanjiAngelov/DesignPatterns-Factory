using System;
using System.Collections.Generic;

// Component
abstract class FileSystemItem
{
    public string Name { get; set; }

    public FileSystemItem(string name)
    {
        Name = name;
    }

    public abstract void Display(int depth);
}

// Leaf
class File : FileSystemItem
{
    public File(string name) : base(name) { }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);
    }
}

// Composite
class Folder : FileSystemItem
{
    private List<FileSystemItem> items = new List<FileSystemItem>();

    public Folder(string name) : base(name) { }

    public void Add(FileSystemItem item)
    {
        items.Add(item);
    }

    public void Remove(FileSystemItem item)
    {
        items.Remove(item);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);

        foreach (var item in items)
        {
            item.Display(depth + 2);
        }
    }
}

// Entry Point (ВАЖНО!)
class Program
{
    static void Main(string[] args)
    {
        // Създаваме файлове
        File file1 = new File("file1.txt");
        File file2 = new File("file2.txt");
        File file3 = new File("file3.txt");

        // Създаваме папки
        Folder root = new Folder("Root");
        Folder subFolder1 = new Folder("SubFolder1");
        Folder subFolder2 = new Folder("SubFolder2");

        // Строим структура
        subFolder1.Add(file1);
        subFolder1.Add(file2);

        subFolder2.Add(file3);

        root.Add(subFolder1);
        root.Add(subFolder2);

        // Показване
        root.Display(1);
    }
}