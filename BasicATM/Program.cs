using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 1200, electricBill = 758, gasBill = 170, waterBill = 125, phoneBill = 92, bill, counter = 1, value = 0;
            string password;
            Console.WriteLine("Welcome");
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Enter your password: ");
                password = Console.ReadLine();
                if (password == "1234")
                {
                    Console.WriteLine("Password correct");
                    counter--;
                    break;
                }
                else if (password.Length != 4)
                {
                    Console.WriteLine("Password must consist of 4 digits!");
                    value++;
                }
                else
                {
                    Console.WriteLine("Wrong password.");
                    value++;
                }

                if (value == 3)
                    Console.WriteLine("Your card is blocked.");
            }
            while (counter == 0)
            {
                Console.Clear();
                Console.WriteLine("\n***** TRANSACTIONS *****\n");
                Console.WriteLine("1-DEPOSIT");
                Console.WriteLine("2-WITHDRAW");
                Console.WriteLine("3-CHECK BALANCE");
                Console.WriteLine("4-PAY BILL");
                Console.WriteLine("5-RETURN CARD");
                Console.WriteLine("Select Your Transaction");


                Console.WriteLine("\nSelect Your Transaction:");
                int transaction = Convert.ToInt32(Console.ReadLine());
            repeat:
                switch (transaction)
                {

                    case 2:
                        Console.WriteLine("Your Balance=" + balance);
                        Console.WriteLine("Enter the Amount You Want to Withdraw:");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        if (amount > balance)
                        {
                            Console.WriteLine("Insufficient Balance.");

                            goto repeat;
                        }
                        if (amount % 10 == 0)
                        {
                            balance -= amount;
                            Console.WriteLine("Your New Balance = {0}. Press 0 to return to the main menu.", balance);
                            counter = Convert.ToInt32(Console.ReadLine());
                            if (counter != 0)
                                Console.Clear();
                        }


                        else
                        {
                            Console.WriteLine("Withdraw in multiples of 10 only");
                            goto repeat;
                        }
                        break;

                    case 1:
                        Console.WriteLine("Your Balance =" + balance);
                        Console.WriteLine("Enter the Amount You Want to Deposit:");
                        amount = Convert.ToInt32(Console.ReadLine());
                        if (amount % 10 == 0)
                        {
                            balance += amount;
                            Console.WriteLine("Your New Balance = {0}. Press 0 to return to the main menu.", balance);
                            counter = Convert.ToInt32(Console.ReadLine());
                            if (counter != 0)
                                Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Deposit in multiples of 10 only");
                            goto case 1;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Your Balance = {0}. Press 0 to return to the main menu.", balance);
                        counter = Convert.ToInt32(Console.ReadLine());
                        if (counter != 0)
                            Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Which bill?");
                        Console.WriteLine("1-Phone bill - ${0}", phoneBill);
                        Console.WriteLine("2-Gas bill - ${0}", gasBill);
                        Console.WriteLine("3-Water bill - ${0}", waterBill);
                        Console.WriteLine("4-Electric bill - ${0}", electricBill);
                        bill = Convert.ToInt32(Console.ReadLine());
                        while (bill != 0)
                        {
                            switch (bill)
                            {
                                case 1:
                                    balance -= phoneBill;
                                    phoneBill = 0;
                                    Console.WriteLine("Your phone bill has been paid. Press 0 to return to the main menu or press the button for another bill payment");
                                    bill = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 2:
                                    balance -= gasBill;
                                    gasBill = 0;
                                    Console.WriteLine("Your gas bill has been paid. Press 0 to return to the main menu or press the button for another bill payment");
                                    bill = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 3:
                                    balance -= waterBill;
                                    waterBill = 0;
                                    Console.WriteLine("Your water bill has been paid. Press 0 to return to the main menu or press the button for another bill payment");
                                    bill = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 4:
                                    balance -= electricBill;
                                    electricBill = 0;
                                    Console.WriteLine("Your electric bill has been paid. Press 0 to return to the main menu or press the button for another bill payment");
                                    bill = Convert.ToInt32(Console.ReadLine());
                                    break;
                                default:
                                    Console.WriteLine("You Have Selected an Incorrect Transaction. Please Enter Again.");
                                    bill = Convert.ToInt32(Console.ReadLine());
                                    break;
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Please Don't Forget Your Card.");
                        counter = 1;

                        break;
                    default:
                        Console.WriteLine("You Have Selected an Incorrect Transaction. Please Enter Again.");
                        transaction = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.WriteLine("You Have Exited. Have a Good Day");
            Console.ReadLine();
        }
    }
}
