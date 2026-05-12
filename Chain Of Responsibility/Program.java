abstract class Handler {
    protected Handler nextHandler;

    public void setNextHandler(Handler nextHandler) {
        this.nextHandler = nextHandler;
    }

    public abstract void handleRequest(int level);
}

class LowLevelSupport extends Handler {
    public void handleRequest(int level) {
        if (level <= 1) {
            System.out.println("Low level support handled the request.");
        } else if (nextHandler != null) {
            nextHandler.handleRequest(level);
        }
    }
}

class MidLevelSupport extends Handler {
    public void handleRequest(int level) {
        if (level <= 2) {
            System.out.println("Mid level support handled the request.");
        } else if (nextHandler != null) {
            nextHandler.handleRequest(level);
        }
    }
}

class HighLevelSupport extends Handler {
    public void handleRequest(int level) {
        System.out.println("High level support handled the request.");
    }
}

public class Main {
    public static void main(String[] args) {

        Handler low = new LowLevelSupport();
        Handler mid = new MidLevelSupport();
        Handler high = new HighLevelSupport();

        low.setNextHandler(mid);
        mid.setNextHandler(high);

        low.handleRequest(1);
        low.handleRequest(2);
        low.handleRequest(3);
    }
}