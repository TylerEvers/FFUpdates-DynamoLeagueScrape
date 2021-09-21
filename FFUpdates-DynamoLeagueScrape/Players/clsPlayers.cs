using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamoLeagueScrape.Players
{
    class clsPlayers
    {
        public string PlayerID { get; set; }

        public string FullName { get; set; }

        public string Team { get; set; }

        public string Position { get; set; }

        public static IPlayersRepository CreatePlayersRepository(string connString)
        {
            return new PlayersRepository(connString);
        }
    }
}
