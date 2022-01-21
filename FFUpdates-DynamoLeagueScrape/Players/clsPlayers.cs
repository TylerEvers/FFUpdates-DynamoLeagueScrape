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

        public int ContractThrough { get; set; }

        public int ContractValue { get; set; }

        public clsPlayers()
        {

        }

        public clsPlayers(string name, int teamID, string position, int contractValue, int contractThrough)
        {
            FullName = name;
            TeamID = teamID;
            Position = position;
            ContractThrough = contractThrough;
            ContractValue = contractValue;
        }

        public static IPlayersRepository CreatePlayersRepository(string connString)
        {
            return new PlayersRepository(connString);
        }
    }
}
