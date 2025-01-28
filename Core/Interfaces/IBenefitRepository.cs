using System;
using Core.Entities;

namespace Core.Interfaces;

public interface IBenefitRepository
{   Task<IReadOnlyList<Benefit>> GetBenfit();
    Task<Benefit> GetBenefitById(int id);
    bool BenefitExists(int id);
}
