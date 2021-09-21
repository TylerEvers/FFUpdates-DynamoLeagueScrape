using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamoLeagueScrape.Players
{
    class PlayersRepository : IPlayersRepository
    {
        private IDbConnection db;

        public PlayersRepository(string connString)
        {
            this.db = new SqlConnection(connString);
        }

        void IPlayersRepository.UpdateSingle(int teamID, string imageURL, string playerName)
        {
            string query = @$"UPDATE Players
                           SET TeamID = {teamID}, PlayerImage = {imageURL}                             
                           WHERE PlayerName = {playerName}";

            this.db.ExecuteScalar(query);
        }
    }
}
