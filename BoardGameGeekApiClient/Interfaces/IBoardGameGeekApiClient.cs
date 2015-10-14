﻿//
//  Adapted by @vfportero for NemeStats from the bgg-json project created by Erv Walter
//  Original source at https://github.com/ervwalter/bgg-json
//

using System.Collections.Generic;
using System.Threading.Tasks;
using BoardGameGeekApiClient.Models;

namespace BoardGameGeekApiClient.Interfaces
{
    interface IBoardGameGeekApiClient
    {
        Task<IEnumerable<SearchBoardGameResult>> SearchBoardGames(string query);
        Task<GameDetails> GetGameDetails(int gameId);
    }
}
