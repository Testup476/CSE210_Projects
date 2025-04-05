namespace MINDFULNESS;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) 
    : base("Breathing","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",duration)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        DateTime endTime= DateTime.Now.AddSeconds(_duration);
        int HalfTime=_duration/2;

        while(DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in..");
            ShowCountDown(HalfTime);
            Console.WriteLine("Breath Out..");
            ShowCountDown(HalfTime);
        }
        DisplayEndingMessage();
    }
}