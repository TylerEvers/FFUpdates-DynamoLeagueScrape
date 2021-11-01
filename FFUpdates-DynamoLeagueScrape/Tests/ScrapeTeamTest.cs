using System;
using Xunit;
using HtmlAgilityPack;

namespace FFUpdatesDynamoLeagueScrape.Tests
{
    public class ScrapeTeamTest
    {
        [Fact]
        public void ScrapeTeam_AltoonaTunafish()
        {
            var expectedTeam = "Altoona Tunafish";
            HtmlDocument doc = DynamoLeagueScrape.Program.ScrapeTeam(4);

            Assert.Contains(expectedTeam, doc.Text);
        }

        [Fact]
        public void ScrapeTeam_CantFineThis()
        {
            var expectedTeam = "Can&#x27;t Fine This";
            HtmlDocument doc = DynamoLeagueScrape.Program.ScrapeTeam(5);

            Assert.Contains(expectedTeam, doc.Text);
        }

        [Fact]
        public void ScrapeTeam_FinkleEinhorn()
        {
            var expectedTeam = "Finkle Einhorn";
            HtmlDocument doc = DynamoLeagueScrape.Program.ScrapeTeam(6);

            Assert.Contains(expectedTeam, doc.Text);
        }

        [Fact]
        public void ScrapeTeam_JJMafia()
        {
            var expectedTeam = "J.J. Mafia";
            HtmlDocument doc = DynamoLeagueScrape.Program.ScrapeTeam(7);

            Assert.Contains(expectedTeam, doc.Text);
        }

        [Fact]
        public void ScrapeTeam_KnockinOnEvansDoor()
        {
            var expectedTeam = "Knockin&#x27; on Evan&#x27;s Door";
            HtmlDocument doc = DynamoLeagueScrape.Program.ScrapeTeam(2);

            Assert.Contains(expectedTeam, doc.Text);
        }

        [Fact]
        public void ScrapeTeam_MagicSKOLBus()
        {
            var expectedTeam = "Magic SKOL Bus";
            HtmlDocument doc = DynamoLeagueScrape.Program.ScrapeTeam(10);

            Assert.Contains(expectedTeam, doc.Text);
        }

        [Fact]
        public void ScrapeTeam_NattyLite()
        {
            var expectedTeam = "Natty Lite";
            HtmlDocument doc = DynamoLeagueScrape.Program.ScrapeTeam(8);

            Assert.Contains(expectedTeam, doc.Text);
        }

        [Fact]
        public void ScrapeTeam_SpaceForce()
        {
            var expectedTeam = "Space Force";
            HtmlDocument doc = DynamoLeagueScrape.Program.ScrapeTeam(1);

            Assert.Contains(expectedTeam, doc.Text);
        }

        [Fact]
        public void ScrapeTeam_StartsWithAW()
        {
            var expectedTeam = "Starts With a W";
            HtmlDocument doc = DynamoLeagueScrape.Program.ScrapeTeam(9);

            Assert.Contains(expectedTeam, doc.Text);
        }

        [Fact]
        public void ScrapeTeam_Str8CashHomie()
        {
            var expectedTeam = "Str8 Cash Homie";
            HtmlDocument doc = DynamoLeagueScrape.Program.ScrapeTeam(3);

            Assert.Contains(expectedTeam, doc.Text);
        }
    }
}
