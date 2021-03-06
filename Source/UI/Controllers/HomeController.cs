﻿#region LICENSE
// NemeStats is a free website for tracking the results of board games.
//     Copyright (C) 2015 Jacob Gordon
// 
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with this program.  If not, see <http://www.gnu.org/licenses/>
#endregion
using AutoMapper;
using BusinessLogic.Logic.GamingGroups;
using BusinessLogic.Logic.PlayedGames;
using BusinessLogic.Logic.Players;
using BusinessLogic.Models.Games;
using BusinessLogic.Models.GamingGroups;
using BusinessLogic.Models.Players;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using UI.Models.GamingGroup;
using UI.Models.Home;
using UI.Models.Players;
using UI.Transformations;
using UI.Transformations.PlayerTransformations;
using BusinessLogic.Logic.Nemeses;

namespace UI.Controllers
{
    public partial class HomeController : Controller
    {
        internal const int NUMBER_OF_TOP_PLAYERS_TO_SHOW = 5;
        internal const int NUMBER_OF_RECENT_PUBLIC_GAMES_TO_SHOW = 5;
        internal const int NUMBER_OF_RECENT_NEMESIS_CHANGES_TO_SHOW = 5;
        internal const int NUMBER_OF_TOP_GAMING_GROUPS_TO_SHOW = 15;

        private readonly IPlayerSummaryBuilder playerSummaryBuilder;
        private readonly ITopPlayerViewModelBuilder topPlayerViewModelBuilder;
        private readonly IPlayedGameRetriever playedGameRetriever;
        private readonly INemesisHistoryRetriever nemesisHistoryRetriever;
        private readonly INemesisChangeViewModelBuilder nemesisChangeViewModelBuilder;
        private readonly IGamingGroupRetriever gamingGroupRetriever;


        public HomeController(
            IPlayerSummaryBuilder playerSummaryBuilder, 
            ITopPlayerViewModelBuilder topPlayerViewModelBuilder,
            IPlayedGameRetriever playedGameRetriever, 
            INemesisHistoryRetriever nemesisHistoryRetriever, 
            INemesisChangeViewModelBuilder nemesisChangeViewModelBuilder, 
            IGamingGroupRetriever gamingGroupRetriever)
        {
            this.playerSummaryBuilder = playerSummaryBuilder;
            this.topPlayerViewModelBuilder = topPlayerViewModelBuilder;
            this.playedGameRetriever = playedGameRetriever;
            this.nemesisHistoryRetriever = nemesisHistoryRetriever;
            this.nemesisChangeViewModelBuilder = nemesisChangeViewModelBuilder;
            this.gamingGroupRetriever = gamingGroupRetriever;
        }

        public virtual ActionResult Index()
        {
            List<TopPlayer> topPlayers = playerSummaryBuilder.GetTopPlayers(NUMBER_OF_TOP_PLAYERS_TO_SHOW);
            List<TopPlayerViewModel> topPlayerViewModels = topPlayers.Select(
                topPlayer => this.topPlayerViewModelBuilder.Build(topPlayer)).ToList();

            List<PublicGameSummary> publicGameSummaries = playedGameRetriever
                .GetRecentPublicGames(NUMBER_OF_RECENT_PUBLIC_GAMES_TO_SHOW);

            List<NemesisChange> nemesisChanges = nemesisHistoryRetriever.GetRecentNemesisChanges(NUMBER_OF_RECENT_NEMESIS_CHANGES_TO_SHOW);

            var nemesisChangeViewModels = nemesisChangeViewModelBuilder.Build(nemesisChanges);

            var topGamingGroups = gamingGroupRetriever.GetTopGamingGroups(NUMBER_OF_TOP_GAMING_GROUPS_TO_SHOW);

            var topGamingGroupViewModels = topGamingGroups.Select(Mapper.Map<TopGamingGroupSummary, TopGamingGroupSummaryViewModel>).ToList();

            HomeIndexViewModel homeIndexViewModel = new HomeIndexViewModel()
            {
                TopPlayers = topPlayerViewModels,
                RecentPublicGames = publicGameSummaries,
                RecentNemesisChanges = nemesisChangeViewModels,
                TopGamingGroups = topGamingGroupViewModels
            };
            return View(MVC.Home.Views.Index, homeIndexViewModel);
        }

        public virtual ActionResult About()
        {
            return View();
        }

        public virtual ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}