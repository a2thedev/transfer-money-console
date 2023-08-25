using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Person
    {
        public string name;
        private Wallet wallet;

        public Person(string name, int cash)

        {
            this.name = name;
            //TODO 2: Assign the value of the 'name' parameter to the 'name' member variable. One line.
           wallet=new Wallet(cash); 
            //TODO 3: Instantiate a new 'Wallet' object, passing the 'cash' parameter into its constructor. Assign this new Wallet to the 'wallet' member variable. One line.

        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{name} has ${wallet.money}");
            //TODO 4: Use string interpolation in a ConsoleWriteLine to display the user's name and also the amount of money in their wallet (using dot notation). One line.

        }

        public void AcceptMoney(int amount)
        {
           wallet.money += amount;
            //TODO 7: Use an assignment operator to increase the amount of money in the person's wallet by the value of the 'amount' parameter. One line.

        }

        public bool TransferMoney(Person receiver, int amountToTransfer)
           
        {

            if (amountToTransfer < wallet.money)
            {

                wallet.money -= amountToTransfer;

                receiver.AcceptMoney(amountToTransfer);


           
                Console.WriteLine($"Tony gave Bologna $20");
            }

          else if (amountToTransfer > wallet.money)

            {

                Console.WriteLine("Not enough money to transfer.");
            }
            //TODO 8: Use a conditional to check if the 'amountToTransfer' parameter of this method is less than or equal to the amount of money in the wallet of the giver.
            //If the parameter is less than the amount in the wallet, subtract that amount from the wallet, then call the receiver's AcceptMoney() method and pass 'amountToTransfer' into it. Also use a Console.WriteLine to describe the transaction that occurred.
            //If the parameter is greater than the amount in the giver's wallet, do not transfer any money and instead print a message describing why the transfer failed.


            return true;
        }


    }
}
