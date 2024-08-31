namespace TimerFour
{
   partial class Form1
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         TextBoxOne = new System.Windows.Forms.TextBox();
         ButtonTimerStart = new System.Windows.Forms.Button();
         SuspendLayout();
         // 
         // TextBoxOne
         // 
         TextBoxOne.Location = new System.Drawing.Point(12, 50);
         TextBoxOne.Multiline = true;
         TextBoxOne.Name = "TextBoxOne";
         TextBoxOne.Size = new System.Drawing.Size(370, 177);
         TextBoxOne.TabIndex = 15;
         // 
         // ButtonTimerStart
         // 
         ButtonTimerStart.Location = new System.Drawing.Point(12, 12);
         ButtonTimerStart.Name = "ButtonTimerStart";
         ButtonTimerStart.Size = new System.Drawing.Size(127, 32);
         ButtonTimerStart.TabIndex = 14;
         ButtonTimerStart.Text = "Старт таймера";
         ButtonTimerStart.UseVisualStyleBackColor = true;
         ButtonTimerStart.Click += ButtonTimerStart_Click;
         // 
         // Form1
         // 
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         ClientSize = new System.Drawing.Size(394, 237);
         Controls.Add(TextBoxOne);
         Controls.Add(ButtonTimerStart);
         Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "Form1";
         Text = "Таймер";
         Load += Form1_Load;
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.TextBox TextBoxOne;
      private System.Windows.Forms.Button ButtonTimerStart;
   }
}