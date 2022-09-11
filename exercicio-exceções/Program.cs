/*
Fazer um programa para ler os dados de uma conta bancária e depois realizar um
saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de
saque da conta. Implemente a conta bancária conforme projeto abaixo:
*/

using System;
using System.Globalization;
using exercicio_exceções.Entities;
using exercicio_exceções.Entities.Exceptions;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Account account = new Account(number, holder, balance, limit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try 
            {
                account.Withdraw(amount);
                Console.WriteLine($"New balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (DomainException ex) 
            {
                Console.WriteLine($"Withdraw error: {ex.Message}");
            }
        }
    }
} 