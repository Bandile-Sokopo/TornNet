using System;
using Core.Interfaces;

namespace Core.DTOs;

public class BattleRequest : IRequest
{
    public string APIKey(string key)
    {
        return key;
    }

    public string Endpoint()
    {
        return "battlestats";
    }

    public int Id(int id)
    {
        throw new NotImplementedException();
    }
}
