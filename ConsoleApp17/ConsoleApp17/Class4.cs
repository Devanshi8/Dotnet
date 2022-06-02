using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;

using System.Threading.Tasks;
namespace ConsoleApp3
{
public interface IAccount
{
    decimal GetBalance();

}
public class Account : IAccount
{
    private string owner;
    private decimal balance;

    public Account(string owner, decimal balance)
    {
        this.owner = owner;
        this.balance = balance;
    }

    public string Getowner()
    {
        return owner;
    }
    public decimal GetBalance()
    {
        return balance;
    }

    public override string ToString()
    {
        return String.Format("Owner: {0},Balance: {1}", owner, balance);
    }

}
public class Bank
{
    List<Account> BankList = new List<Account>();
    public void AddAccount(params Account[] acc)
    {
        BankList.AddRange(acc);
        for (int i = 0; i < acc.Length; i++)
            Console.WriteLine("Have added: {0}", acc[i].ToString());
    }
    public override string ToString()
    {
        string str = "\nBalance in bank:\n";
        for (int i = 0; i < BankList.Count; i++)
            str += String.Format(BankList[i].ToString() + "\n");
        return str;
    }
}
    class extra
    {
        public static void Main2()
        {
            Account account1 = new Account("Jame Austen", 250.00);
            account1.GetBalance();
        }
    }

}