using System;
using Core.Interfaces;

namespace Core.DTOs;

public class ItemRequest : IRequest
{
    public string APIKey(string key)
    {
        return key;
    }

    public string Endpoint()
    {
        return "items";
    }

    public int Id(int id)
    {
        throw new NotImplementedException();
    }
}
