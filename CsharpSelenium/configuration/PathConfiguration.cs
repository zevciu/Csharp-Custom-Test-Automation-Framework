using System;
using System.IO;

namespace CsharpSelenium.utilities
{
    public class PathConfiguration
    {
        public static String DRIVERS_DIR = @"\utilities\drivers\";
        public static String DRIVERS_PATH = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + DRIVERS_DIR;

        public static String SCREENSHOTS_DIR = @"\testware\screenshots\";
        public static String SCREENSHOTS_PATH = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + SCREENSHOTS_DIR;

   //     public static String RECORDINGS_DIR = @"\testware\recordings\";
   //     public static String RECORDINGS_PATH = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + RECORDINGS_DIR;

        public static String REPORTS_DIR = @"\testware\reports\";
        public static String REPORTS_PATH = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + REPORTS_DIR;

   //     public static String LOGS_DIR = @"\testware\logs\";
   //     public static String LOGS_PATH = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + REPORTS_DIR;

        public static String TIMESTAMP = DateTime.Now.ToString("yyyy-MM-dd" + " @ " + "HH.mm.ss");

    }
}
