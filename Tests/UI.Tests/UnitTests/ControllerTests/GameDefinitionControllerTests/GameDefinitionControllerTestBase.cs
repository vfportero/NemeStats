﻿using BusinessLogic.DataAccess;
using BusinessLogic.DataAccess.Repositories;
using BusinessLogic.Logic.GameDefinitions;
using BusinessLogic.Models.User;
using NUnit.Framework;
using Rhino.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Controllers;
using UI.Controllers.Helpers;
using UI.Transformations;

namespace UI.Tests.UnitTests.ControllerTests.GameDefinitionControllerTests
{
    [TestFixture]
    public class GameDefinitionControllerTestBase
    {
        protected GameDefinitionController gameDefinitionControllerPartialMock;
        protected GameDefinitionRetriever gameDefinitionRetrieverMock;
        protected GameDefinitionViewModelBuilder gameDefinitionTransformationMock;
        protected ShowingXResultsMessageBuilder showingXResultsMessageBuilderMock;
        protected GameDefinitionCreator gameDefinitionCreatorMock;
        protected NemeStatsDataContext dataContextMock;
        protected ApplicationUser currentUser;

        [SetUp]
        public virtual void SetUp()
        {
            dataContextMock = MockRepository.GenerateMock<NemeStatsDataContext>();
            gameDefinitionRetrieverMock = MockRepository.GenerateMock<GameDefinitionRetriever>();
            gameDefinitionTransformationMock = MockRepository.GenerateMock<GameDefinitionViewModelBuilder>();
            showingXResultsMessageBuilderMock = MockRepository.GenerateMock<ShowingXResultsMessageBuilder>();
            gameDefinitionCreatorMock = MockRepository.GenerateMock<GameDefinitionCreator>();
            gameDefinitionControllerPartialMock = MockRepository.GeneratePartialMock<GameDefinitionController>(
                dataContextMock, 
                gameDefinitionRetrieverMock,
                gameDefinitionTransformationMock,
                showingXResultsMessageBuilderMock,
                gameDefinitionCreatorMock);
            currentUser = new ApplicationUser()
            {
                Id = "user id",
                CurrentGamingGroupId = 15151
            };
        }
    }
}
