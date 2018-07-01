using netwix.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace netwix.Infra.Api
{
    [Headers("Content-Type: Application/json")]
    public interface ITmdbApi
    {
        [Get("/tv/popular?api_key={apiKey}")]
        Task<SerieResponse> GetSerieResponseAsync(string apiKey);
    }
}
