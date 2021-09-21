using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamoLeagueScrape.Teams
{
    class clsTeams
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int DynamoID { get; set; }

        public static ITeamsRepository CreateTeamsRepository(string connString)
        {
            return new TeamsRepository(connString);
        }
    }
}
