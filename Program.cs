// See https://aka.ms/new-console-template for more information


using System.Numerics;
using modul8_103022330070;

class Program
{
    public void Main(string[] args)
    {
        BankTransferConfig config = new BankTransferConfig();
        int total;

        if (config.lang == "en")
        {
            Console.WriteLine("please insert the amount of money to transfer: ");
            int money = Convert.ToInt32(Console.ReadLine());

            if (money <= config.transfer.threshold)
            {
                total = money * config.transfer.low_fee;
            }
            else
            {
                total = money * config.transfer.high_fee;
            }

            Console.WriteLine("Select transfer: ");
            for(int i =  0; i < config.methods.Count; i++)
            {
                Console.WriteLine((i + 1) + config.methods[i]);
            }
            int metode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Please type" + config.confirmation.en);

            string confirm = Convert.ToString(Console.ReadLine());
            if (confirm == )
            
        }
    }
}