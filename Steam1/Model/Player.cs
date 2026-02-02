namespace Steam
{
    public class Player(string nickname, PlayerStatus status, Game? game = null, List<Player>? friends = null) : Profile(nickname, status, game)
    {
        public List<Player> Friends { get; set; } = friends ?? new List<Player>();
    }
}