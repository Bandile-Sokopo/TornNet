using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.services.user
{
    public class UserSelection : ISelection
    {
        public string key {set {key = "";}}
        public string endpoint {set {key = "user";}}
        public string selection {set {key = "";}}

        public Task GetAsync(HttpClient sharedClient, string endpoint, string key, string selection)
        {
            throw new NotImplementedException();
        }
    }
}