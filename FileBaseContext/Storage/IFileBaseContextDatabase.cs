using Microsoft.EntityFrameworkCore.Storage;

namespace FileBaseContext.Storage;

public interface IFileBaseContextDatabase : IDatabase
{
    IFileBaseContextStore Store { get; }
}