using System.Collections.Generic;
using System.Linq;


public class AccountDatabase
{
    private readonly List<Account> accounts;
    public AccountDatabase()
    {
        accounts = new List<Account>();
    }

    public bool AddAccount(Account account)
    {
        if (accounts.Any(a => a.username == account.username))
        {
            return false; //account has already been created
        }

        accounts.Add(account);
        return true;
    }

    public bool RemoveAccount(string username)
    {
        return accounts.Remove(accounts.Find(a => a.username == username));
    }

}
