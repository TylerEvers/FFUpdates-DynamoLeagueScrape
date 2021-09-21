using HtmlAgilityPack;
using System;

namespace DynamoLeagueScrape
{
    class Program
    {
        static void Main(string[] args)
        {
            var teamsRepository = Teams.clsTeams.CreateTeamsRepository(Properties.Resources.connString);
            var teams = teamsRepository.SelectAll();

            foreach (Teams.clsTeams team in teams)
            {
                HtmlWeb web = new HtmlWeb();
                HtmlDocument doc = web.Load(@$"https://dynamoleague.com/Team/Details?teamId={team.DynamoID}");
                var HeaderNames = doc.DocumentNode.SelectNodes("//td[@class='sorting_1']");

                //for each player from scrape
                var playersRepository = Players.clsPlayers.CreatePlayersRepository(Properties.Resources.connString);
                //playersRepository.UpdateSingle(player.TeamID, player.imageURL, player.Name);
            }

        }
    }
}
