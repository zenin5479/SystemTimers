namespace TimerOne
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
         ButtonStop = new System.Windows.Forms.Button();
         LabelStopwatch = new System.Windows.Forms.Label();
         ButtonReset = new System.Windows.Forms.Button();
         ButtonStart = new System.Windows.Forms.Button();
         TextBoxSeconds = new System.Windows.Forms.TextBox();
         SuspendLayout();
         // 
         // ButtonStop
         // 
         ButtonStop.Location = new System.Drawing.Point(81, 224);
         ButtonStop.Margin = new System.Windows.Forms.Padding(4);
         ButtonStop.Name = "ButtonStop";
         ButtonStop.Size = new System.Drawing.Size(60, 32);
         ButtonStop.TabIndex = 44;
         ButtonStop.Text = "Стоп";
         ButtonStop.UseVisualStyleBackColor = true;
         // 
         // LabelStopwatch
         // 
         LabelStopwatch.AutoSize = true;
         LabelStopwatch.Location = new System.Drawing.Point(12, 9);
         LabelStopwatch.Name = "LabelStopwatch";
         LabelStopwatch.Size = new System.Drawing.Size(99, 21);
         LabelStopwatch.TabIndex = 43;
         LabelStopwatch.Text = "Секундомер";
         // 
         // ButtonReset
         // 
         ButtonReset.Location = new System.Drawing.Point(296, 224);
         ButtonReset.Margin = new System.Windows.Forms.Padding(4);
         ButtonReset.Name = "ButtonReset";
         ButtonReset.Size = new System.Drawing.Size(65, 32);
         ButtonReset.TabIndex = 42;
         ButtonReset.Text = "Сброс";
         ButtonReset.UseVisualStyleBackColor = true;
         // 
         // ButtonStart
         // 
         ButtonStart.Location = new System.Drawing.Point(13, 224);
         ButtonStart.Margin = new System.Windows.Forms.Padding(4);
         ButtonStart.Name = "ButtonStart";
         ButtonStart.Size = new System.Drawing.Size(60, 32);
         ButtonStart.TabIndex = 41;
         ButtonStart.Text = "Старт";
         ButtonStart.UseVisualStyleBackColor = true;
         // 
         // TextBoxSeconds
         // 
         TextBoxSeconds.Location = new System.Drawing.Point(13, 34);
         TextBoxSeconds.Margin = new System.Windows.Forms.Padding(4);
         TextBoxSeconds.Multiline = true;
         TextBoxSeconds.Name = "TextBoxSeconds";
         TextBoxSeconds.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         TextBoxSeconds.Size = new System.Drawing.Size(348, 182);
         TextBoxSeconds.TabIndex = 40;
         // 
         // Form1
         // 
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         ClientSize = new System.Drawing.Size(374, 265);
         Controls.Add(ButtonStop);
         Controls.Add(LabelStopwatch);
         Controls.Add(ButtonReset);
         Controls.Add(ButtonStart);
         Controls.Add(TextBoxSeconds);
         Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         Name = "Form1";
         Text = "Таймер";
         Load += Form1_Load;
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Button ButtonStop;
      private System.Windows.Forms.Label LabelStopwatch;
      private System.Windows.Forms.Button ButtonReset;
      private System.Windows.Forms.Button ButtonStart;
      internal System.Windows.Forms.TextBox TextBoxSeconds;
   }
}