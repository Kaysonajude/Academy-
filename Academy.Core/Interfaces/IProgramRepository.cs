using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Core.Entities;

namespace Academy.Core.Interfaces
{
    public interface IProgramRepository
    {
        Task<Program> Add(Program program);
        Task<Program> Update(Program program);
        Task<Program> GetById(Guid programId);
        Task <List<Program>> GetAll();
        Task<bool> Delete(Guid programId);
    }
}