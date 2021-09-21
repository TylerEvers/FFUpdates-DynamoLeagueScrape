using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DynamoLeagueScrape.Teams
{
    class TeamsRepository : ITeamsRepository
    {
        private IDbConnection db;

        public TeamsRepository(string connString)
        {
            this.db = new SqlConnection(connString);
        }

        List<clsTeams> ITeamsRepository.SelectAll()
        {
            string query = @$"SELECT ID, Name, DynamoID
                            FROM Teams
                            WHERE TeamType = 0";

            return db.Query<clsTeams>(query).ToList();
        }
    }
}
