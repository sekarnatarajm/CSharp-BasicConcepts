

using OopsConcept;


BaseClass baseClass = new DerivedClass();
baseClass.Print();



EncapsulationAccount encapsulationAccount = new();
encapsulationAccount.Balance = 0;

encapsulationAccount.Deposit(1000);
encapsulationAccount.Withdraw(500);
encapsulationAccount.Deposit(1500);

Console.WriteLine("Balance Amount : " + encapsulationAccount.GetBalance());
Console.WriteLine("Hello, World!");
