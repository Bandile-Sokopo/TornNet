using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.services
{
    public interface ISelection
    {
        string key {set;}
        string endpoint {set;}
        string selection {set;}
        Task GetAsync(HttpClient sharedClient,string endpoint,string key,string selection);
    }
}