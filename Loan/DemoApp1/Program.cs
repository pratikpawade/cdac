using Loaning;

Loan Jill = new PersonalLoan(1500000,5);
Console.WriteLine($"EMI for Personal Loan {0}: ",Jill.EMI);

Loan Jack = new HomeLoan(2500000,3);
Console.WriteLine($"EMI for Home Loan : {0} ",Jack.EMI);

