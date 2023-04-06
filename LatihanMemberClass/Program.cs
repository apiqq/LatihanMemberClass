using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PlaneTicket ticket1 = new PlaneTicket();
            PlaneTicket ticket2 = new PlaneTicket();

            // assign object ticket1
            ticket1.Origin = "JOGJA";
            ticket1.Destination = "PKU";
            ticket1.Currency = "USD";
            ticket1.Cost = 100;

            // assign object ticket2
            ticket2.Origin = "JKT";
            ticket2.Destination = "PKU";
            ticket2.Currency = "IDR";
            ticket2.Cost = 750000;

            // PRINT
            ticket1.PrintSummary();
            Console.WriteLine();
            ticket2.PrintSummary();
        }
    }
}
