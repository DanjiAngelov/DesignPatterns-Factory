// Abstract Products
interface Chair {
    void sitOn();
}

interface Table {
    void use();
}

// Modern Products
class ModernChair implements Chair {
    public void sitOn() {
        System.out.println("Sitting on a modern chair");
    }
}

class ModernTable implements Table {
    public void use() {
        System.out.println("Using a modern table");
    }
}

// Victorian Products
class VictorianChair implements Chair {
    public void sitOn() {
        System.out.println("Sitting on a Victorian chair");
    }
}

class VictorianTable implements Table {
    public void use() {
        System.out.println("Using a Victorian table");
    }
}

// Abstract Factory
interface FurnitureFactory {
    Chair createChair();
    Table createTable();
}

// Concrete Factories
class ModernFactory implements FurnitureFactory {
    public Chair createChair() {
        return new ModernChair();
    }

    public Table createTable() {
        return new ModernTable();
    }
}

class VictorianFactory implements FurnitureFactory {
    public Chair createChair() {
        return new VictorianChair();
    }

    public Table createTable() {
        return new VictorianTable();
    }
}

// Client
public class Main {
    public static void main(String[] args) {
        FurnitureFactory factory = new ModernFactory();

        Chair chair = factory.createChair();
        Table table = factory.createTable();

        chair.sitOn();
        table.use();
    }
}