using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    private static Timer timer;

    static void Main(string[] args)
    {
        var timerState = new TimerState { Counter = 0 };

        Console.ReadKey();
        while (timerState.Counter >= 10)
        {
            Console.WriteLine(timerState.Counter);
        }

        
        Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: done.");
    }

    private static void TimerTask(object timerState)
    {
        Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff}: starting a new callback.");
        var state = timerState as TimerState;
        Interlocked.Increment(ref state.Counter);
    }

    class TimerState
    {
        public int Counter;
    }
}
