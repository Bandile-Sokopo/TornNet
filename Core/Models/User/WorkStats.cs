using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Core.Models.User
{
    public class WorkStats
    {
        [JsonProperty("manual_labor")]
        int ManualLabor;
        [JsonProperty("intelligence")]
        int Intelligence;
        [JsonProperty("endurance")]
        int Endurance;
    }
}