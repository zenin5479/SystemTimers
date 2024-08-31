using System;
using System.Diagnostics.Tracing;
using System.Threading;
using System.Windows.Forms;

// System.Windows.Forms.Timer

namespace TimerTwo
{
   public partial class Form1 : Form
   {
      private readonly SynchronizationContext _synchronizationContext;

      public Form1()
      {
         InitializeComponent();
         _synchronizationContext = SynchronizationContext.Current;
         Thread thread = new Thread(LongProcess);
         thread.Start();
      }

      private void LongProcess()
      {
         for (int i = 0; i < 100; i++)
         {
            Thread.Sleep(10);
            int j = i;
            _synchronizationContext.Post((o) => TextBoxOne.Text = j.ToString(), null);
         }
         TextBoxOne.AppendText(Environment.NewLine);
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         // Синхронизировать таймер с Form1
         //timer.SynchronizingObject = this;
      }

      private void ButtonTimerStart_Click(object sender, EventArgs e)
      {
         // Timer.SynchronizingObject 
         // Возвращает или задает объект, используемый для упорядочивания вызовов обработчика событий,
         // которые выполняются по истечении определенного интервала
         // Обычно Timer вызывает обработчик события Elapsed в пуле системных потоков
         // Это может не сработать, если источником события является визуальный компонент Windows Forms, такой как форма, текстовое поле или кнопка
         // Чтобы избежать этого, необходимо задать свойству SynchronizingObject ссылку на компонент, который обрабатывает событие
         // Таким образом, таймер вызовет обработчик события в том же потоке, где находится компонент
         System.Timers.Timer timer = new System.Timers.Timer(1000);
         // Синхронизировать таймер с текстовым полем
         timer.SynchronizingObject = TextBoxOne;
         timer.Elapsed += (o, eventArgs) =>
         {
            TextBoxOne.AppendText($"Прошедшее событие в {eventArgs.SignalTime:G}" + Environment.NewLine);
         };
         timer.Start();
         // Утилизация таймера
         //timer.Dispose();

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
         //System.Timers.Timer timer = new System.Timers.Timer(1000);
         //timer.Elapsed += async (o, eventArgs) =>
         //{
         //   await Task.Run(() => TextBoxOne.AppendText($"Прошедшее событие в {eventArgs.SignalTime:G}" + Environment.NewLine));
         //   throw new Exception();
         //};

         //timer.Start();

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