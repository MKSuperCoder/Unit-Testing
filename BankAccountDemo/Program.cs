using BankAccount;

BankAccount.BankAccount ba =new BankAccount.BankAccount("Marcus", 100);
ba.deposit(40);
Console.WriteLine(ba.AccountHolder + " has a balance of " + ba.Balance);