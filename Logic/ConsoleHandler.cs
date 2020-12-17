using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class ConsoleHandler
{
    private TextBox box;
    private Queue<string> log;

    public ConsoleHandler(TextBox box)
    {
        this.box = box;
        log = new Queue<string>();
    }

    public void Append(string line)
    {
        log.Enqueue(line);
        Refresh();
    }

    public void ReplaceLast(string line)
    {
        log.Dequeue();
        log.Enqueue(line);
        Refresh();
    }

    public void RemoveLast(string line, int amount = 1)
    {
        for (int i = 0; i < amount; i++)
        {
            log.Dequeue();
        }

        Refresh();
    }

    public void ClearConsole()
    {
        log.Clear();
        Refresh();
    }

    private void Refresh()
    {
        box.Invoke((Action)delegate
        {
            box.Text = "";
            foreach (string line in log)
            {
                box.AppendText(line);
                box.AppendText(Environment.NewLine);
            }
        });
    }
}