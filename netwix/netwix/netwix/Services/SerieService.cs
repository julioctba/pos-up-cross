using netwix.Infra;
using netwix.Infra.Api;
using netwix.Models;
using netwix.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace netwix.Services
{
    public class SerieService : ISerieService
    {
        readonly ITmdbApi _api;

        public SerieService(ITmdbApi api)
        {
            _api = api;
        }


        public async Task<SerieResponse> GetSeriesAsync()
        {
            return await _api.GetSerieResponseAsync(AppSetting.ApiKey);
        }
    }
}
