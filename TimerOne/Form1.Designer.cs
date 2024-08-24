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
         SuspendLayout();
         // 
         // Form1
         // 
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         ClientSize = new System.Drawing.Size(525, 375);
         Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         Name = "Form1";
         Text = "Таймер";
         Load += Form1_Load;
         ResumeLayout(false);
      }

      #endregion
   }
}