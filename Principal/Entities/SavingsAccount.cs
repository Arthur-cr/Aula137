﻿
namespace Principal.Entities
{
    class SavingsAccount : Account
    {
        public double InterestingRate { get; set; }
        
        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestingRate) : base(number, holder, balance)
        {
            InterestingRate = interestingRate;
        }

        public void UpdateBalance()
        {
            Balance = Balance * InterestingRate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
