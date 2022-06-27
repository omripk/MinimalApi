using Microsoft.EntityFrameworkCore;
using SixMinApi.Models;

namespace SixMinApi.Data;

public class CommandRepo : ICommandRepo
{
    private readonly AppDbContext _context;

    public CommandRepo(AppDbContext context)
    {
        _context = context;

    }
    public async Task CreateCommand(Command command)
    {
        if (command == null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        await _context.Commands.AddAsync(command);
    }

    public void DeleteCommand(Command command)
    {
        if (command == null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        _context.Commands.Remove(command);
    }

    public async Task<IEnumerable<Command>> GetAllCommands()
    {
        return await _context.Commands!.ToListAsync();
    }

    public Task<Command?> GetCommandById(int id)
    {
        return _context.Commands.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }
}