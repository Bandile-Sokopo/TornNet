using System;
using Core.Interfaces;

namespace Core.DTOs;

public class WorkRequest : IRequest
{
    public string APIKey(string key)
    {
        return key;
    }

    public string Endpoint()
    {
        return "workstats";
    }

    public int Id(int id)
    {
        throw new NotImplementedException();
    }
}
