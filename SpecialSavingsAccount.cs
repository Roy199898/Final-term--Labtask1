using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtaskfinal
{
    class SpecialSavingsAccount : Account
    {
        int trans = 0;
        public SpecialSavingsAccount(string name, string id, double balance) : base(name, id, balance)
        {

        }

        override public void transaction(double amount)
        {
            double temp = this.balance * 0.50;
            if (trans >= 7)
            {
                Console.WriteLine("Sorry The maximum transaction time commited");
            }
            else
            {
                if (this.balance - amount < temp)
                {
                    Console.WriteLine("Sorry transaction can't be completed . Because the remainning balance is less then 20% of balance ");
                }
                else
                {
                    this.balance = this.balance - amount;
                }

            }
            trans = trans + 1;
        }
        override public void ShowInfo()
        {
            Console.WriteLine("Name :" + name + " ID :" + id + "  Balance : " + this.balance);
        }
    }
}