using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Core.Models.User
{
    public class Stocks
    {
        [JsonProperty("stock_id")]
        int ID;
        [JsonProperty("total_shares")]
        int TotalShares;
        [JsonProperty("transactions")]
        Transaction transaction;
    }

    public class Transaction
    {
        [JsonProperty("shares")]
        int Shares;
        [JsonProperty("bought_price")]
        decimal BoughtPrice;
        [JsonProperty("time_bought")]
        string TimeBought;
    }
}