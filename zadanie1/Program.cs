using System;
using System.Timers;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Timer timer = new Timer();
        timer.Interval = 5000;
        timer.Elapsed += TimerElapsed;
        timer.Start();
        Console.WriteLine("Нажмите клавишу для остановки");
        Console.ReadKey();
        timer.Stop();

    }
    static void TimerElapsed(object sender, ElapsedEventArgs e)
    {
        Process.Start("notepad.exe");
        Console.WriteLine("Список процессов");
        foreach (Process process in Process.GetProcesses())
        {
            Console.WriteLine($"Имя:{process.ProcessName},Время запуска:{process.StartTime}");
        }
        Console.WriteLine();
    }
}

