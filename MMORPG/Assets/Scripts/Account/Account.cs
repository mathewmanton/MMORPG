using System.Collections.Generic;

public class Account
{
    //public Server lastServerSelected = null;
    //public bool isLoggedIn = false;
    public string username;
    public string password;
    //Dictionary<string, int> charactersCreated; //string = servername, int = number of characters created
   //public List<Characters> characters = new List<Characters>();

    public Account(string username, string password)
    {
        this.username = username;
        this.password = password;
    }


/*    public void AddCharacter(Server server)
    {
       if(charactersCreated.ContainsKey(server.serverName))
       {
           charactersCreated[server.name]++;
       }
       else
       {
           charactersCreated.Add(server.name, 1);
       }
    }*/

}

