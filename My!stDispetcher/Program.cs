using System;
using System.Diagnostics;
using System.Threading;

namespace My_stDispetcher
{
    class Program
    {



        static void Main(string[] args)
        {
            comand newCommand = new comand();
            newCommand.parseParameters(args);
            TimerCallback tm = new TimerCallback(deleteProc);
            Timer timer = new Timer(tm, newCommand, 0, newCommand.Parameter3);
            Console.ReadLine();
        }

        public static void deleteProc(object sender)
        {
            comand newCommand = new comand();
            newCommand = (comand)sender;

            Process[] listprosecc = Process.GetProcesses();
            foreach (Process oneproc in listprosecc)
            {
                string ProsessName = oneproc.ProcessName;

                ProsessName = ProsessName.ToLower();
                if (ProsessName.Equals(newCommand.Parameter1))
                {
                    Console.WriteLine((DateTime.Now - oneproc.StartTime).TotalSeconds + " " + (DateTime.Now - oneproc.StartTime).TotalMinutes);
                   if ((DateTime.Now - oneproc.StartTime).TotalMinutes > newCommand.Parameter2){ oneproc.Kill(); }
                    
                }
            }
        }
    }
    }



           // int num = 0;
            // устанавливаем метод обратного вызова
          //  TimerCallback tm = new TimerCallback(delete);
            // создаем таймер
           // Timer timer = new Timer(tm, null, 0, 2000);

    
