using System;
using System.Collections.Generic;
using System.Text;

namespace Steam
{
    public class Profile(string nickname, PlayerStatus status, Game? game = null)
    {
        public string Nickname { get; set; } = nickname;

        public PlayerStatus Status { get; set; } = status;

        public Game? CurrentGame { get; set; } = game;
    }
}
