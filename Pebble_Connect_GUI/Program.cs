using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Pebble_Connect_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var systemPath = System.Environment.
                             GetFolderPath(
                                 Environment.SpecialFolder.CommonApplicationData
                             );

            //var completePath = Path.Combine(systemPath, "Pebble_Connect_GUI");

            var folderPath = @"C:\Users\3TTrafford\Desktop\Pebble_Connect_GUI\";

            var filePath = Path.Combine(folderPath, "save.txt");

            Directory.CreateDirectory(folderPath);

            File.Create(filePath);

            Thread Form1 = new Thread(new ThreadStart(Form1Thread));
            //Thread UserNameLoad = new Thread(new ThreadStart("TODO: Make a username load class"));
            Form1.Start();
        }

        static void Form1Thread()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
