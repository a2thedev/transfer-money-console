using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Simulation
    {
        public Simulation()
        {
            
        }

        public void RunSimulation()
        {
            Console.WriteLine("Starting simulation");

            Person tony = new Person("Tony",50);
            Person bologna = new Person("Bologna",60);
            //TODO 5: Instantiate two Person objects, with unique names and money amounts. Two lines.

            tony.DisplayInfo();
           bologna.DisplayInfo();
            //TODO 6: Call the .DisplayInfo() method on each person object, one at a time. This will show their initial money amount. Two lines.


            //TEST THE APPLICATION AFTER TODOS 5 AND 6!!

           tony.TransferMoney(bologna,20);
            
            //TODO 9: Call the .TransferMoney() method on one person object (giver), making sure to pass in the second person object (receiver), and the amount being transfered. One line.

            tony.DisplayInfo();
            bologna.DisplayInfo();
            //TODO 10: Call the .DisplayInfo() method on each person object again, showing that each person's balance has changed. Two lines.


            Console.WriteLine("Simulation complete.");
        }
    }
}
