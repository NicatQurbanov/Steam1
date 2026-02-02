namespace Steam
{
    public class Player(string nickname, PlayerStatus status, Game? game = null, List<Player>? friends = null) : Profile(nickname, status, game)
    {
        public List<Player> Friends { get; set; } = friends ?? new List<Player>();

        public void ShowFriends()
        {
            Console.WriteLine("List of friends: ");
            foreach (Player p in Friends) Console.WriteLine($"--{p.Nickname}");
        }

        public void SendRequestto()
        {

        }
    }
}