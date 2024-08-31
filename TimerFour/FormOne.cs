using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

// System.Windows.Forms.Timer

namespace TimerFour
{
   public partial class FormOne : Form
   {
      public FormOne()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      private void ButtonTimerStart_Click(object sender, EventArgs e)
      {
         // Реализация обработчиков
         System.Timers.Timer timer = new System.Timers.Timer(1000);
         timer.Elapsed += async (o, eventArgs) =>
         {
            // Создаем StringBuilder
            StringBuilder sb = new StringBuilder();
            // Создаем StringWriter
            await using StringWriter sw = new StringWriter(sb);
            // Заполняем StringWriter
            await sw.WriteAsync($"Прошедшее событие в {eventArgs.SignalTime:G}");
            // Печатаем StringWriter
            TextBoxOne.AppendText(sw + Environment.NewLine);
            // Очищаем StringBuilder
            //sb.Remove(0, sb.Length);
            sb.Clear();
         };

         timer.Start();
      }
   }
}