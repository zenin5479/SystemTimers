using System;
using System.Timers;
using System.Windows.Forms;

// System.Timers

namespace TimerOne
{
   public partial class Form1 : Form
   {
      System.Timers.Timer _timer;

      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      private void ButtonStart_Click(object sender, EventArgs e)
      {
         _timer = new System.Timers.Timer(1000);
         _timer.Elapsed += OnEventExecution;
         //_timer.Start();
         _timer.Enabled = true;
      }

      public void OnEventExecution(object sender, ElapsedEventArgs eventArgs)
      {
         //TextBoxSeconds.AppendText($"Прошедшее событие в {eventArgs.SignalTime:G}" + Environment.NewLine);
         //TextBoxSeconds.AppendText(string.Format($"Прошедшее событие в {eventArgs.SignalTime:G}") + Environment.NewLine);
         TextBoxSeconds.AppendText(string.Format("Прошедшее событие в {0:G}", eventArgs.SignalTime) + Environment.NewLine);
      }

      private void ButtonStop_Click(object sender, EventArgs e)
      {
         _timer.Stop();
      }

      private void ButtonReset_Click(object sender, EventArgs e)
      {
         TextBoxSeconds.Clear();
      }
   }
}