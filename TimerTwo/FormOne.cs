using System;
using System.Threading;
using System.Windows.Forms;

// System.Windows.Forms.Timer

namespace TimerTwo
{
   public partial class FormOne : Form
   {
      private readonly SynchronizationContext _synchronizationContext;

      public FormOne()
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
      }
   }
}