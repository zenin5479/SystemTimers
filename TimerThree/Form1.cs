using System;
using System.Threading.Tasks;
using System.Windows.Forms;

// System.Windows.Forms.Timer

namespace TimerThree
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      private void ButtonTimerStart_Click(object sender, EventArgs e)
      {
         // Обработка исключений
         // Всякий раз, когда обработчик событий таймера выбрасывает исключение, компонент таймера перехватывает его и подавляет
         // Следующий код не будет записывать сообщения об исключениях в консоль
         //System.Timers.Timer timer = new System.Timers.Timer(1000);
         //timer.Elapsed += (o, eventArgs) =>
         //{
         //   TextBoxOne.AppendText($"Прошедшее событие в {eventArgs.SignalTime:G}" + Environment.NewLine);
         //   throw new Exception();
         //};

         //timer.Start();

         // Исключения, возникающие в асинхронных обработчиках, не будут подавляться компонентом таймера
         // Программа покажет сообщение об ошибке и завершит работу
         System.Timers.Timer timer = new System.Timers.Timer(1000);
         timer.Elapsed += async (o, eventArgs) =>
         {
            await Task.Run(() => TextBoxOne.AppendText($"Прошедшее событие в {eventArgs.SignalTime:G}" + Environment.NewLine));
            throw new Exception();
         };

         timer.Start();

         // Реализация обработчиков
         //System.Timers.Timer timer = new System.Timers.Timer(1000);
         //timer.Elapsed += async (o, eventArgs) =>
         //{
         //   // Создаем StringBuilder
         //   StringBuilder sb = new StringBuilder();
         //   // Создаем StringWriter
         //   await using StringWriter sw = new StringWriter(sb);
         //   // Заполняем StringWriter
         //   await sw.WriteAsync($"Прошедшее событие в {eventArgs.SignalTime:G}");
         //   // Печатаем StringWriter
         //   TextBoxOne.AppendText(sw + Environment.NewLine);
         //   // Очищаем StringBuilder
         //   //sb.Remove(0, sb.Length);
         //   sb.Clear();
         //};

         //timer.Start();
      }
   }
}
