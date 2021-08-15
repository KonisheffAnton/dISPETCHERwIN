using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_stDispetcher
{
    class comand
    {
        public string Parameter1 { get; set; } = "0";
        public int Parameter2 { get; set; } = 0;
        public int Parameter3 { get; set; } = 0;


        public void parseParameters(string[] innerArgs)
        {
            try
            {
                Convert.ToInt32(innerArgs[1]);
                Convert.ToInt32(innerArgs[2]);

               foreach (string arg in innerArgs)
                { this.Parameter1 = innerArgs[0];
                  this.Parameter2 = Convert.ToInt32(innerArgs[1]);
                  this.Parameter3 = Convert.ToInt32(innerArgs[2]);
                }
            }
            catch
            {
                Console.WriteLine("Неверный формат аргументов");
            }
        }
    }
}
