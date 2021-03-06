﻿using BoardGameGeekApiClient.Interfaces;
using BoardGameGeekApiClient.Service;
using NUnit.Framework;

namespace BoardGameGeekApiClient.Tests.IntegrationTests
{
    [Ignore("Integration Test")]
    public abstract class BaseBoardGameGeekApiClientIntegrationTest
    {
        public IBoardGameGeekApiClient ApiClient{ get; set; }

        [OneTimeSetUp]
        public virtual void FixtureSetUp()
        {
            ApiClient = new BoardGameGeekClient(new ApiDownloaderService());
        }
    }
}