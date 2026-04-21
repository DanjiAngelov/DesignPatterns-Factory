import java.util.ArrayList;
import java.util.List;

// Component
abstract class FileSystemItem {
    protected String name;

    public FileSystemItem(String name) {
        this.name = name;
    }

    public abstract void display(int depth);
}

// Leaf
class File extends FileSystemItem {
    public File(String name) {
        super(name);
    }

    public void display(int depth) {
        System.out.println("-".repeat(depth) + name);
    }
}

// Composite
class Folder extends FileSystemItem {
    private List<FileSystemItem> items = new ArrayList<>();

    public Folder(String name) {
        super(name);
    }

    public void add(FileSystemItem item) {
        items.add(item);
    }

    public void display(int depth) {
        System.out.println("-".repeat(depth) + name);

        for (FileSystemItem item : items) {
            item.display(depth + 2);
        }
    }
}