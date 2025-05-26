using System;

namespace Core.Interfaces;

public interface IRequest
{
    string APIKey(string key);
    string Endpoint();
    int Id(int id);
}
