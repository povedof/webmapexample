using System.Drawing;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace WindowsFormsApp1
{

   partial class Form1
   {

      /// <summary>
      ///  Required designer variable.
      /// </summary>
      [Intercepted]
      private Mobilize.Web.Controls.Interfaces.IContainer components { get; set; } = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if ( disposing && (components != null) )
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      [Mobilize.WebMap.Common.Attributes.Designer]
#region Windows Form Designer generated code
      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         label1 = new Mobilize.Web.Label();
         button1 = new Mobilize.Web.Button();
         textBox1 = new Mobilize.Web.TextBox();
         label2 = new Mobilize.Web.Label();
         SuspendLayout();
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new Point(38, 9);
         label1.Name = "label1";
         label1.Size = new Size(70, 15);
         label1.TabIndex = 0;
         label1.Text = "Hello World";
         label1.Click += label1_Click;
         // 
         // button1
         // 
         button1.Location = new Point(33, 88);
         button1.Name = "button1";
         button1.Size = new Size(75, 23);
         button1.TabIndex = 1;
         button1.Text = "button1";
         button1.UseVisualStyleBackColor = true;
         button1.Click += button1_Click;
         // 
         // textBox1
         // 
         textBox1.Location = new Point(23, 44);
         textBox1.Name = "textBox1";
         textBox1.Size = new Size(100, 23);
         textBox1.TabIndex = 2;
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Location = new Point(52, 138);
         label2.Name = "label2";
         label2.Size = new Size(0, 15);
         label2.TabIndex = 3;
         label2.Click += label2_Click;
         this.Properties().
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new Size(800, 450);
         Controls.Add(label2);
         Controls.Add(textBox1);
         Controls.Add(button1);
         Controls.Add(label1);
         Name = "Form1";
         Text = "Form1";
         ResumeLayout(false);
         this.PerformLayout();
      }
#endregion

      [Intercepted]
      private Mobilize.Web.Label label1 { get; set; }

      [Intercepted]
      private Mobilize.Web.Button button1 { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox textBox1 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label2 { get; set; }

   }

}