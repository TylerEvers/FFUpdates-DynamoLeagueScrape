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

        void IPlayersRepository.UpdateSingle(clsPlayers player)
        {
            string query = @$"UPDATE Players
                           SET TeamID = {player.TeamID}, PlayerImage = '{player.ImageURL}', contractThrough = {player.ContractThrough}, capSpace = {player.ContractValue}                      
                           WHERE PlayerName = '{player.FullName}'";

            this.db.ExecuteScalar(query);
        }
    }
}
