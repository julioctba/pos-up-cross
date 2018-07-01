using netwix.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace netwix.Services
{
    public interface ISerieService
    {
        Task<SerieResponse> GetSeriesAsync();
    }
}
