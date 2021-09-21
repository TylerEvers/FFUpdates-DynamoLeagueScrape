using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamoLeagueScrape.Teams
{
    interface ITeamsRepository
    {
        List<clsTeams> SelectAll();
    }
}
