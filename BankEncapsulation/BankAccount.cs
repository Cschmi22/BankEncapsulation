﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public void Deposit(double amount)
        {
            Console.WriteLine($"{amount, 0:c} has been deposited into your account. Not really though.");
            _balance = amount;

        }
        public double GetBalance() 
        {
            return _balance;
        }

    }
}
