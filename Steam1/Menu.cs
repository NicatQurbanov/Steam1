using System;
using System.Collections.Generic;
using System.Text;

namespace Steam
{
    public class Menu(PlayerController playerController, GameController gameController, Player currPlayer)
    {
        public PlayerController PlayerCtrl { get; } = playerController;
        public GameController GameCtrl { get; } = gameController;
        public Player CurrPlayer { get; } = currPlayer;


        public void Start()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Steam Menu!\n1. Show users.\n2. Show all games\n3. Check friendlist. \n4.Enter as admin\nOr type \"e\" to leave");
            ConsoleKeyInfo menuSelection = Console.ReadKey(); Console.WriteLine();

            do
            {
                switch (menuSelection.KeyChar)
                {
                    case '1':
                        User();
                        break;
                    case '2':
                        GameCtrl.ShowGames();
                        Start();
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                }
            } while (menuSelection.KeyChar != 'e');
        }

        public void User()
        {
            Console.WriteLine("List users who is:\n1. Online\n2. Offline\n3. InGame\n4. Blocked\n");
            ConsoleKeyInfo menuSelection = Console.ReadKey(); Console.WriteLine();

            do
            {
                switch (menuSelection.KeyChar)
                {
                    case '1':
                        PlayerCtrl.ShowUsers(PlayerCtrl.ShowOnlineUsers());
                        Start();
                        break;
                    case '2':
                        PlayerCtrl.ShowUsers(PlayerCtrl.ShowOfflineUsers());
                        Start();
                        break;
                    case '3':
                        PlayerCtrl.ShowUsers(PlayerCtrl.ShowInGameUsers());
                        Start();
                        break;
                    case '4':
                        PlayerCtrl.ShowUsers(PlayerCtrl.ShowBlockedUsers());
                        Start();
                        break;
                }
            } while (menuSelection.KeyChar != 'e');
        }

        public void Friends()
        {
            Console.Clear();
            Console.WriteLine();
        }
    }
}