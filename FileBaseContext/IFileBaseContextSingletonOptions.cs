using FileBaseContext.Infrastructure;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace FileBaseContext;

public interface IFileBaseContextSingletonOptions : ISingletonOptions
{
    FileBaseContextDatabaseRoot DatabaseRoot { get; }
    bool IsNullabilityCheckEnabled { get; }
}