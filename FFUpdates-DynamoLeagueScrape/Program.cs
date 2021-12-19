﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;

namespace DynamoLeagueScrape
{
    class Program
    {
        static void Main(string[] args)
        {
            var teamsRepository = Teams.clsTeams.CreateTeamsRepository(FFUpdates_DynamoLeagueScrape.Properties.Resources.connString);
            var teams = teamsRepository.SelectAll();
            List<Players.clsPlayers> lstPlayers = new List<Players.clsPlayers>();

            foreach (Teams.clsTeams team in teams)
            {
                //Scrape teams
                HtmlDocument doc = ScrapeTeam(team.DynamoID);

                int tableIndex = 0;
                foreach (HtmlNode table in doc.DocumentNode.SelectNodes("//tbody"))
                {
                    if (table.SelectNodes("tr") != null)
                    {
                        foreach (HtmlNode row in table.SelectNodes("tr"))
                        {
                            //Add scraped player to list
                            lstPlayers.Add(
                                new DynamoLeagueScrape.Players.clsPlayers(
                                    row.SelectNodes("td")[0].InnerText.Trim(),
                                    team.ID,
                                    row.SelectNodes("td")[1].InnerText.Trim(),
                                    row.SelectNodes("td")[0].SelectSingleNode("img").Attributes[0].Value,
                                    Convert.ToInt16(row.SelectNodes("td")[2].InnerText.Trim()),
                                    Convert.ToInt16(row.SelectNodes("td")[3].InnerText.Trim()),
                                    GetStatus(tableIndex)
                                ));
                        }
                    }

                    tableIndex += 1;
                }
            }

            //Save Players List to DB
            var playersRepository = Players.clsPlayers.CreatePlayersRepository(FFUpdates_DynamoLeagueScrape.Properties.Resources.connString);
            foreach (Players.clsPlayers player in lstPlayers)
            {
                playersRepository.UpdateSingle(player);
            }

        }

        private static int GetStatus(int tableIndex)
        {
            switch (tableIndex)
            {
                case 0:
                    return 2; // Rostered
                case 1:
                    return 1; // Cut/FA
                case 2:
                    return 2; // Rostered (Unsigned)
                default:
                    return 4; // Unknown
            }
        }

        public static HtmlDocument ScrapeTeam(int teamID)
        {
            HtmlWeb web = new HtmlWeb();
            return web.Load(@$"https://dynamoleague.com/Team/Details?teamId={teamID}");
        }
    }
}
