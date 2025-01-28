using System;
using Core.Entities;

namespace Core.Interfaces;

public interface IItemRepository
{
    Task<IReadOnlyList<Items>> GetItems();
    Task<Items> GetItemById(int id);
    bool ItemExists(int id);
}
