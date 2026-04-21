// Implementor
interface Device {
    void on();
    void off();
    void setVolume(int percent);
}

// Concrete Implementations
class TV implements Device {
    public void on() { System.out.println("TV ON"); }
    public void off() { System.out.println("TV OFF"); }
    public void setVolume(int percent) {
        System.out.println("TV Volume: " + percent);
    }
}

class Radio implements Device {
    public void on() { System.out.println("Radio ON"); }
    public void off() { System.out.println("Radio OFF"); }
    public void setVolume(int percent) {
        System.out.println("Radio Volume: " + percent);
    }
}

// Abstraction
class RemoteControl {
    protected Device device;

    public RemoteControl(Device device) {
        this.device = device;
    }

    public void togglePower() {
        device.on();
    }
}

// Refined Abstraction
class AdvancedRemote extends RemoteControl {
    public AdvancedRemote(Device device) {
        super(device);
    }

    public void mute() {
        device.setVolume(0);
    }
}