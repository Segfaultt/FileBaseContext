using FileBaseContext.Infrastructure;
using FileBaseContext.Storage;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace FileBaseContext.Extensions;

public static class FileBaseContextCacheExtensions
{
    public static IFileBaseContextStore GetStore(this IFileBaseContextStoreCache storeCache, IDbContextOptions options)
    {
        return storeCache.GetStore(options.Extensions.OfType<FileBaseContextOptionsExtension>().First().Options);
    }
}