using System;
using System.Collections.Generic;
using System.Text;

namespace Steam
{
    public class Admin(string nickname, PlayerStatus status, Game? game = null) : Profile(nickname, status, game)
    {
    }
}
