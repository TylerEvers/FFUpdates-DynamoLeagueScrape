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

        public int TeamID { get; set; }

        public string FullName { get; set; }

        public string Team { get; set; }

        public string Position { get; set; }

        public string ImageURL { get; set; }

        public int ContractThrough { get; set; }

        public int ContractValue { get; set; }

        public clsPlayers()
        {

        }

        public clsPlayers(string name, int teamID, string position, string img, int contractThrough, int contractValue)
        {
            FullName = name;
            TeamID = teamID;
            Position = position;
            ImageURL = img;
            ContractThrough = contractThrough;
            ContractValue = contractValue;
        }

        public static IPlayersRepository CreatePlayersRepository(string connString)
        {
            return new PlayersRepository(connString);
        }
    }
}
