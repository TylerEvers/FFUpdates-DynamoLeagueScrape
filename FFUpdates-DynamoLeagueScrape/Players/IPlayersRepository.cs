using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamoLeagueScrape.Players
{
    interface IPlayersRepository
    {
        void UpdateSingle(clsPlayers player);
    }
}
