
namespace ConsoleApp7;

internal class Projector
{
    public bool isOn { get; set; }


    public void Start()
    {
        isOn = true;
        Console.WriteLine("======Cinema opened=====.");
    }

    public void Stop()
    {
        isOn = false;
        Console.WriteLine("\"======Cinema closed=====\").");
    }


}
