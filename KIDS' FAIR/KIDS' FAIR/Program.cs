using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIDS__FAIR
{
    class Program
    {
        static void Main(string[] args)
        {
            /*New pet*/
            Pet petObjc = new Pet();
            petObjc.Start();

            Console.WriteLine("\nPress Enter to start next part!");
            Console.ReadLine();

            /*New album*/
            Album album = new Album();
            album.Start();

            /*New ticket seller*/
            TicketSeller ticketSeller = new TicketSeller(); 
            ticketSeller.Start();

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }

        static void PrepareConsolesLook()
        {
            Console.BackgroundColor= ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "KIDS' FAIR";
        }
    }
}
