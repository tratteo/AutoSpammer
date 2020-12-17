using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

public class BackgroundTyper
{
    private Thread typerThread;

    private bool shutdownRequest;

    public int Delay { get; private set; }

    public int StartDelay { get; private set; }

    public BackgroundTyper(int delay, int startDelay)
    {
        Delay = delay;
        StartDelay = startDelay;
    }

    private event Action StartedCallback;

    public void AddStartedCallback(Action callback)
    {
        StartedCallback += callback;
    }

    public void Execute()
    {
        if (typerThread != null && typerThread.IsAlive)
        {
            typerThread.Interrupt();
        }
        typerThread = new Thread(() => Type_T());
        typerThread.Start();
        typerThread.IsBackground = true;
        shutdownRequest = false;
    }

    public void Stop()
    {
        shutdownRequest = true;
    }

    public void Join()
    {
        typerThread.Join();
    }

    public bool IsAlive()
    {
        return typerThread.IsAlive;
    }

    private void Type_T()
    {
        Thread.Sleep(StartDelay);
        StartedCallback?.Invoke();
        while (!shutdownRequest)
        {
            SendKeys.SendWait("^v");
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(Delay);
        }
    }
}