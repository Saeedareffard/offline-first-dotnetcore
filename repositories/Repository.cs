// File: Repository.cs
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly ApplicationDbContext _context;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<T>> GetUnsyncedEntitiesAsync()
    {
        return await _context.Set<T>()
            .Where(entity => !entity.IsSynced)
            .ToListAsync();
    }

    public async Task UpdateEntitiesAsync(List<T> entities)
    {
        foreach (var entity in entities)
        {
            entity.IsSynced = true;
        }
        await _context.SaveChangesAsync();
    }
}
