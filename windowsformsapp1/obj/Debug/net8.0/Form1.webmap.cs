#pragma warning disable
#line 1 "Form1.cs"
#pragma warning disable
#line 1 "Form1.cs"
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilize.WebMap.Common.Attributes;

namespace WindowsFormsApp1
{

   [Observable]
   public partial class Form1
      : Mobilize.Web.Form
   {

      public Form1()
      {
#line hidden
this.Mobilize_Initialize_Properties();
#line 21
         InitializeComponent();
      }

      private void label1_Click(object sender, EventArgs e)
      {
      }

      private void button1_Click(object sender, EventArgs e)
      {
         this.label2.Text = this.textBox1.Text;
      }

      private void label2_Click(object sender, EventArgs e)
      {
      }

   }

}
#pragma warning restore
