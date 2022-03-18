using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationNew
{
    class Program
    {
        private double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("enter valid amount");

                }
                else
                {
                    balance = value;
                }
            }
        }
        class test
        {

            static void Main(string[] args)
            {
                Program ob = new Program();
                ob.balance = 200;
                Console.WriteLine(ob.balance);
                ob.balance = -50;
                Console.WriteLine("press any key to exist");
                Console.ReadLine();
            }
        }
    }
}
