using System;
using System.Collections.Generic;
using System.Text;

namespace Steam
{
    public class PlayerController
    {
        public List<Player> players { get; private set; } = [];

        public List<Player> ShowOnlineUsers()
        {
            return players.FindAll(p => p.Status == PlayerStatus.Online);
        }

        public List<Player> ShowOfflineUsers()
        {
            return players.FindAll(p => p.Status == PlayerStatus.Offline);
        }

        public List<Player> ShowInGameUsers()
        {
            return players.FindAll(p => p.Status == PlayerStatus.InGame);
        }

        public List<Player> ShowBlockedUsers()
        {
            return players.FindAll(p => p.Status == PlayerStatus.Blocked);
        }

        public void ShowUsers(List<Player> users)
        {
            Console.WriteLine($"{users[0].Status} Users:");
            foreach (Player u in users) Console.WriteLine($"{u.Nickname}.");
            Console.WriteLine("\nPress Enter to return to the main menu...");
            Console.ReadLine();
        }
    }
}