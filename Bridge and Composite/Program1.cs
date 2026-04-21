using System;

class Program
{
    static void Main(string[] args)
    {
        IDevice tv = new TV();
        RemoteControl remote = new RemoteControl(tv);

        remote.TogglePower();

        AdvancedRemote adv = new AdvancedRemote(tv);
        adv.Mute();
    }
}
// Implementor
public interface IDevice
{
    void On();
    void Off();
    void SetVolume(int percent);
}

// Concrete Implementors
public class TV : IDevice
{
    public void On() => Console.WriteLine("TV is ON");
    public void Off() => Console.WriteLine("TV is OFF");
    public void SetVolume(int percent) => Console.WriteLine($"TV volume: {percent}");
}

public class Radio : IDevice
{
    public void On() => Console.WriteLine("Radio is ON");
    public void Off() => Console.WriteLine("Radio is OFF");
    public void SetVolume(int percent) => Console.WriteLine($"Radio volume: {percent}");
}

// Abstraction
public class RemoteControl
{
    protected IDevice device;

    public RemoteControl(IDevice device)
    {
        this.device = device;
    }

    public virtual void TogglePower()
    {
        device.On();
    }
}

// Refined Abstraction
public class AdvancedRemote : RemoteControl
{
    public AdvancedRemote(IDevice device) : base(device) { }

    public void Mute()
    {
        device.SetVolume(0);
    }
}
