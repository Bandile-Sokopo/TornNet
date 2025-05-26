using System;
using Core.Interfaces;

namespace Core.DTOs;

public class StockRequest : IRequest
{
    public string APIKey(string key)
    {
        return key;
    }

    public string Endpoint()
    {
        return "stocks";
    }

    public int Id(int id)
    {
        throw new NotImplementedException();
    }
}
