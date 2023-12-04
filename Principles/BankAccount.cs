namespace SolidDesignPrinciples.Principles;
/// <summary>
/// This class aims to explain the Single Responsibility Principle through the example of a Bank account. 
/// </summary>
public class BankAccount
{
    /*Single Responsibility Principles states that a class should have one role.
     Meaning, a class should not have multiple responsibilities or one responsibility 
     should not be spread across multiple classes. This principle re-enforces loose coupling,
     making changes/updates to code seamless. 
    */

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }
    public double Balance { get; set; } = 0.00;
    
    /// <summary>
    /// Class Constructor
    /// </summary>
    /// <param name="fName">first name</param>
    /// <param name="lastName">last name</param>
    /// <param name="id">id</param>
    /// <param name="balance">balance</param>
    public BankAccount(string fName,string lastName,int id,double balance)
    {
        FirstName = fName;
        LastName = lastName;
        Id = id;
        Balance = balance;

    }

    /// <summary>
    /// This method returns the current account balance
    /// </summary>
    /// <param name="account">bank account</param>
    /// <returns>balance</returns>
    public double GetBalance(BankAccount account)
    {
        return account.Balance;
    }
/// <summary>
/// This method withdraws money from the bank account
/// </summary>
/// <param name="account">account</param>
/// <param name="withdrawAmount">the amount to withdraw</param>
/// <returns>New bank account balance</returns>
    public double Withdraw(BankAccount account, double withdrawAmount)
    {
        account.Balance -= withdrawAmount;
        return account.Balance;
    }

/// <summary>
/// This method deposits money from the bank account
/// </summary>
/// <param name="account">account</param>
/// <param name="depositAmount">deposit amount</param>
/// <returns>New bank account balance</returns>
    public double Deposit(BankAccount account, double depositAmount)
    {
        account.Balance += depositAmount;
        return account.Balance;
    }
}