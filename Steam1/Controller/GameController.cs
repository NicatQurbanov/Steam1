using System;
using System.Collections.Generic;
using System.Text;

namespace Steam
{
    public class GameController(PlayerController playerController)
    {
        public List<Game> Games { get; private set; } = [];

        public PlayerController PlayerCtrl { get; } = playerController;

        public void ShowGames()
        {
            Console.WriteLine("Available Games:\n");
            foreach (Game g in Games)
            {
                Console.WriteLine($"--{g.Name}");
                int playersCount = 0;
                Console.Write("  Players in this game: -");
                foreach (Player p in PlayerCtrl.players)
                {
                    if (p.CurrentGame != null && p.CurrentGame.Name == g.Name)
                    {
                        playersCount++;
                        Console.Write($"{p.Nickname} ");
                    }
                }
                Console.WriteLine($"\n  Total Players: {(playersCount > 0 ? playersCount : "None")}\n");
            }
            Console.WriteLine("\nPress Enter to return to the main menu...");
            Console.ReadLine();

        }
    }
}