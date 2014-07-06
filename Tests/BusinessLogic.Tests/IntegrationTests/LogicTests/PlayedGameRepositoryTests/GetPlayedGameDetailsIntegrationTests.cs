﻿using BusinessLogic.DataAccess;
using BusinessLogic.Logic;
using BusinessLogic.Models;
using NUnit.Framework;
using System.Linq;

namespace BusinessLogic.Tests.IntegrationTests.LogicTests.PlayedGameRepositoryTests
{
    [TestFixture]
    public class GetPlayedGameDetailsIntegrationTests : IntegrationTestBase
    {
        private UserContextBuilder userContextBuilder;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            userContextBuilder = new UserContextBuilderImpl();
        }

        private PlayedGame GetTestSubjectPlayedGame(NemeStatsDbContext dbContextToTestWith)
        {
            return new BusinessLogic.Models.PlayedGameRepository(dbContextToTestWith, userContextBuilder)
                .GetPlayedGameDetails(testPlayedGames[0].Id);
        }

        [Test]
        public void ItRetrievesThePlayedGame()
        {
            using(NemeStatsDbContext dbContext = new NemeStatsDbContext())
            {
                PlayedGame playedGame = GetTestSubjectPlayedGame(dbContext);
                Assert.NotNull(playedGame);
            }
        }

        [Test]
        public void ItEagerlyFetchesTheGameResults()
        {
            using(NemeStatsDbContext dbContext = new NemeStatsDbContext())
            {
                dbContext.Configuration.LazyLoadingEnabled = false;
                PlayedGame playedGame = GetTestSubjectPlayedGame(dbContext);
                Assert.GreaterOrEqual(testPlayedGames[0].PlayerGameResults.Count, playedGame.PlayerGameResults.Count());
            }
        }

        [Test]
        public void ItEagerlyFetchesTheGameDefinition()
        {
            using (NemeStatsDbContext dbContext = new NemeStatsDbContext())
            {
                dbContext.Configuration.LazyLoadingEnabled = false;
                PlayedGame playedGame = GetTestSubjectPlayedGame(dbContext);
                Assert.NotNull(playedGame.GameDefinition);
            }
        }

        [Test]
        public void ItReturnsNullIfNoPlayedGameFound()
        {
            using (NemeStatsDbContext dbContext = new NemeStatsDbContext())
            {
                PlayedGame notFoundPlayedGame = new PlayedGameRepository(dbContext, userContextBuilder).GetPlayedGameDetails(-1);
                Assert.Null(notFoundPlayedGame);
            }
        }
    }
}
