using System;
using Core.Entities;

namespace Core.Interfaces;

public interface IWorkStatRepository
{
    Task<IReadOnlyList<WorkStats>> GetWorkStats();
    Task<WorkStats> GetWorkStatById(int id);
    bool WorkStatExists(int id);
}
