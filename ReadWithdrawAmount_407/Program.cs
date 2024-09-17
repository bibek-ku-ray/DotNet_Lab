using System;

namespace ReadWithdrawAmount_407
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your balance: ");
                decimal balance = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter the amount to withdraw: ");
                decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());

                if (withdrawAmount > balance)
                {
                    throw new ApplicationException("Withdrawal amount exceeds the available balance.");
                }

                decimal remainingBalance = balance - withdrawAmount;
                Console.WriteLine($"Transaction successful! Your remaining balance is: {remainingBalance}");
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.ReadLine();
        }
    }
}
