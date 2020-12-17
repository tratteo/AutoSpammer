using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSpammer
{
    public partial class MainForm : Form
    {
        private BackgroundTyper typer;

        private Thread clipboardInfoThread;

        private ConsoleHandler consoleHandler;

        private bool shutdown;

        public MainForm()
        {
            InitializeComponent();
            consoleHandler = new ConsoleHandler(console);
        }

        private void typeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            typer = new BackgroundTyper((int)delayValue.Value, (int)startDelayValue.Value);
            typer.Execute();
            consoleHandler.Append("Starting bot...");
            typer.AddStartedCallback(() => consoleHandler.Append("Bot started with delay: " + typer.Delay));
            while (typer.IsAlive())
            {
                Application.DoEvents();
            }
            Debug.Write(typeof(string).Assembly.ImageRuntimeVersion);
        }

        private void stopBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (typer.IsAlive())
            {
                typer?.Stop();
                consoleHandler.Append("Bot stopped");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            shutdown = true;
            if (clipboardInfoThread.ThreadState == System.Threading.ThreadState.Running)
            {
                clipboardInfoThread?.Join();
            }
            if (typer != null)
            {
                typer.Stop();
                typer.Join();
            }
        }

        private void Poll()
        {
            while (!shutdown)
            {
                infoText.Invoke((Action)delegate
                {
                    infoText.Text = Clipboard.GetText();
                });

                Thread.Sleep(500);
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            clipboardInfoThread = new Thread(new ThreadStart(Poll));
            clipboardInfoThread.SetApartmentState(ApartmentState.STA);
            clipboardInfoThread.IsBackground = true;
            clipboardInfoThread.Start();
            shutdown = false;
        }

        private void clearConsoleBtn_Click(object sender, EventArgs e)
        {
            consoleHandler.ClearConsole();
        }

        private void infoTooltip_Click(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.infoTooltip, "Copy to clipboard the text you want to spam, the bot will use the shortcut CRTL+V");
        }
    }
}