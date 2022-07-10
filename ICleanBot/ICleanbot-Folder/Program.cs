using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace I_Clear
{
    internal class Program
    {


     

        static void Main(string[] args)
        {



            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" are You Sure You Want This Application TO Begin Cleaning [Y] [N]:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            string Inp = Console.ReadLine().ToUpper();
            if (Inp == "Y")
            {
                Console.WriteLine("Starting.....");
                WindowsF();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("YOU Quit");
            }




        }
      
        public  static void WindowsF()
        {





         
            var path = $@"C:\Windows\Downloaded Program Files";
            DirectoryInfo di = new DirectoryInfo(path);





            var FIlES = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (var files in FIlES)
            {
                Console.WriteLine($"{Path.GetFileName(files)}: GetCreationTime: {Directory.GetCreationTime(files)} , GetLastAccessTime: {Directory.GetLastAccessTime(files)}");//Print every file that is inside the path
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    Console.WriteLine($"{dir.Name}: GetCreationTime: {dir.CreationTime}, GetLastAccessTime:{dir.LastAccessTime}");

                }

                try
                {
                    Console.WriteLine($"Deleting {Path.GetFileName(files)}");
                    File.Delete(files);

                }
                catch
                {
                    continue;
                }


            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                try
                {
                    Console.WriteLine($"Deleting {dir}");
                    dir.Delete(true);
                }
                catch
                {
                    continue;
                }
            }

            Temp();


        }

        public static void Temp()
        {

            var path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\AppData\Local\Temp";
            DirectoryInfo di = new DirectoryInfo(path);
            Console.WriteLine("Starting.....");
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            //* . * means anything that start with a word and end with something after the dot

            var FIlES = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (var files in FIlES)
            {


                Console.WriteLine($"{Path.GetFileName(files)}: GetCreationTime: {Directory.GetCreationTime(files)} , GetLastAccessTime: {Directory.GetLastAccessTime(files)}");
                try
                {
                    Console.WriteLine($"Deleting {Path.GetFileName(files)}");
                    File.Delete(files);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Cant Access some Folders Skipping.....");
                    Console.ForegroundColor = ConsoleColor.Green;
                    continue;
                }




            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                Console.WriteLine($"Deleting {dir}");
                try
                {
                    dir.Delete(true);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Cant Access some Folders Skipping.....");
                    Console.ForegroundColor = ConsoleColor.Green;
                    continue;
                }
            }
            Documents();
        }
         
            


    
        //public static void Trash()
        //{
        //    var path = @"::{645FF040-5081-101B-9F08-00AA002F954E}";
        //    DirectoryInfo di = new DirectoryInfo(path);

        //    DriveInfo[] allDrives = DriveInfo.GetDrives();
        //    foreach (var DriverType in allDrives)
        //    {
        //        {

        //            if (Directory.Exists(path))
        //            {
        //                //* . * means anything that start with a word and end with something after the dot

        //                var FIlES = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
        //                foreach (var files in FIlES)
        //                {

        //                    Console.WriteLine($"Deleting {Path.GetFileName(files)}");
        //                    try
        //                    {
        //                        Console.WriteLine($"{Path.GetFileName(files)}: GetCreationTime: {Directory.GetCreationTime(files)} , GetLastAccessTime: {Directory.GetLastAccessTime(files)}");//Print every file that is inside the path

        //                        File.Delete(files);
        //                    }
        //                    catch
        //                    {

        //                        continue;
        //                    }
        //                    int retry = 1;
        //                    if (retry == 1)
        //                    {
        //                        if (files.Length >= 1)
        //                        {
        //                            retry = 0;
        //                            return;
        //                        }

        //                    }
        //                    else
        //                    {
        //                        continue;
        //                    }





        //                }
        //                foreach (DirectoryInfo dir in di.GetDirectories())
        //                {
        //                    Console.WriteLine($"Deleting {dir}");
        //                    try
        //                    {
        //                        dir.Delete(true);
        //                    }
        //                    catch
        //                    {
        //                        Console.ForegroundColor = ConsoleColor.Red;

        //                        Console.WriteLine("Skipping some Files/Folders(No access).....");
        //                        Console.ForegroundColor = ConsoleColor.Green;
        //                        continue;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    Documents();

        //}
        public static void Documents()
        {
           
            var path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\OneDrive\Documents";


            DriveInfo[] allDrives = DriveInfo.GetDrives();
          

                   
                        //* . * means anything that start with a word and end with something after the dot

                        var FIlES = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
                        foreach (var files in FIlES)
                        {


                            Console.WriteLine($"{Path.GetFileName(files)}: GetCreationTime: {Directory.GetCreationTime(files)} , GetLastAccessTime: {Directory.GetLastAccessTime(files)}");
                            try
                            {
                                //Print every file that is inside the path
                                Console.WriteLine($"Deleting {Path.GetFileName(files)}");
                                File.Delete(files);
                            }
                            catch
                            {

                                continue;
                            }

                        }

                      
            WindowsTemp();
        }
        public static void WindowsTemp()
        {
            
            var path = @"C:\Windows\Temp";
            DirectoryInfo di = new DirectoryInfo(path);

            DriveInfo[] allDrives = DriveInfo.GetDrives();
         
                        //* . * means anything that start with a word and end with something after the dot

                        var FIlES = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                        foreach (var files in FIlES)
                        {


                            Console.WriteLine($"{Path.GetFileName(files)}: GetCreationTime: {Directory.GetCreationTime(files)} , GetLastAccessTime: {Directory.GetLastAccessTime(files)}");
                            try
                            {
                                Console.WriteLine($"Deleting {Path.GetFileName(files)}");

                                File.Delete(files);
                            }
                            catch
                            {

                                continue;
                            }







                        }
                        foreach (DirectoryInfo dir in di.GetDirectories())
                        {
                            Console.WriteLine($"Deleting {dir}");
                            try
                            {
                                dir.Delete(true);
                            }
                            catch
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                                Console.WriteLine("Skipping some Files/Folders(No access).....");
                                Console.ForegroundColor = ConsoleColor.Green;
                               
                            }
                        }
                    
            CMD();
        }
        public static void CMD()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.Start();
            Console.WriteLine("Writeing Cmd : WSReset.exe..........");
            Process[] p = Process.GetProcessesByName("cmd.exe");
            foreach (Process pro in p)
            {
                pro.Kill();

            }
            process.StartInfo.Arguments = "/k " + " WSReset.exe   ";
            Thread.Sleep(5000);

            process.StartInfo.FileName = "cmd.exe";
            process.Start();
            Console.WriteLine("Writeing Cmd : ipconfig /flushdns To clear ipconfig cache ");

            process.StartInfo.Arguments = "/k " + " ipconfig /flushdns  ";
            process.StartInfo.Arguments = "exit";
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Temp2();
        }
        public static void Temp2()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            var path = $@"C:\Windows\SoftwareDistribution\Download";
            DirectoryInfo di = new DirectoryInfo(path);

            DriveInfo[] allDrives = DriveInfo.GetDrives();
           
                    var FIlES = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                    foreach (var files in FIlES)
                    {

                        Console.WriteLine($"{Path.GetFileName(files)}: GetCreationTime: {Directory.GetCreationTime(files)} , GetLastAccessTime: {Directory.GetLastAccessTime(files)}");

                        try
                        {

                            Console.WriteLine($"Deleting {Path.GetFileName(files)}");
                            File.Delete(files);
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("Cant Access some Folders Skipping.....");
                            Console.ForegroundColor = ConsoleColor.Green;
                            continue;
                        }





                    }
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        Console.WriteLine($"Deleting {dir}");
                        try
                        {
                            dir.Delete(true);
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("Cant Access ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            continue;
                        }
                    }
                
            Pre(+0);
        }
        public static void Pre<de>(de timers)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            var path = $@"C:\Windows\Prefetch";
            DirectoryInfo di = new DirectoryInfo(path);

            DriveInfo[] allDrives = DriveInfo.GetDrives();

         
                var FIlES = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                foreach (var files in FIlES)
                {

                    Console.WriteLine($"{Path.GetFileName(files)}: GetCreationTime: {Directory.GetCreationTime(files)} , GetLastAccessTime: {Directory.GetLastAccessTime(files)}");

                    try
                    {

                        Console.WriteLine($"Deleting {Path.GetFileName(files)}");
                        File.Delete(files);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Cant Access some Folders Skipping.....");
                        Console.ForegroundColor = ConsoleColor.Green;
                        continue;
                    }





                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    Console.WriteLine($"Deleting {dir}");
                    try
                    {
                        dir.Delete(true);
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Cant Access ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        continue;
                    }
                }
            Program clean = new Program();
            Console.ForegroundColor = ConsoleColor.DarkRed;
           
            Console.WriteLine("Done...");
            Console.ReadKey();

        }

    }
          
        
    
}   
    


  


