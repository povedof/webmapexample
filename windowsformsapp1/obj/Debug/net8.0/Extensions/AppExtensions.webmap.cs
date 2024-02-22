#pragma warning disable
#line 1 "Extensions\\AppExtensions.cs"
#pragma warning disable
#line 1 "Extensions\\AppExtensions.cs"

namespace WindowsFormsApp1
{
    public static partial class AppExtensions
    {
        public static ExtApplication ExtApp(this Mobilize.WebMap.Common.DCP.IApplication app) => app as ExtApplication;
        public static ExtApplication ExtApp(this object obj) => Mobilize.Web.Application.CurrentApplication as ExtApplication;
    }
}


#pragma warning restore
