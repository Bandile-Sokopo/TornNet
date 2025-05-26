using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.services.user
{
    public class WorkStatsSelection : ISelection
    {
        public string key {set {key = "";}}
        public string endpoint {set {key = "user";}}
        public string selection {set {key = "workstats";}}

        public Task GetAsync(HttpClient sharedClient, string endpoint, string key, string selection)
        {
            throw new NotImplementedException();
        }
    }
}