using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace _6Herramientas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Run();
        }
       
        public static void Run()
        {
            string[] args = System.Environment.GetCommandLineArgs();

           
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: Watcher.exe (directory)");
                return;
            }

          
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = args[1];
         
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            
            watcher.Filter = "*.txt";
            
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

           
            watcher.EnableRaisingEvents = true;

            
            Console.WriteLine("Presiona \'q\' para quitar el sample.");
            while (Console.Read() != 'q') ;
        }

        
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
        }

        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 N = new Form1();
            N.Show();
            this.Close();
        }
    }
}
