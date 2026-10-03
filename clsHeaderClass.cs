using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePresentationLayer
{
    internal  class clsHeaderClass
    {
         public static void DrawHeader (string Message , string user = "" )
        {
            Console.Clear();
            Console.WriteLine($"{"",-50}------------------------------------------           \n");
            Console.WriteLine($"{"",-60}{Message}");
            Console.WriteLine($"\n{"",-50}------------------------------------------           \n");
            Console.WriteLine($"{"",-50}User :  {user}");
            Console.WriteLine($"{"",-50}Date :  {DateTime.Now}\n");
        }
    

    }

}
