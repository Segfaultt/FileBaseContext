using FileBaseContext.Extensions;
using FileBaseContext.Storage;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Query;

namespace FileBaseContext.Infrastructure;

public class FileBaseContextQueryContextFactory : IQueryContextFactory
{
    private readonly QueryContextDependencies _dependencies;
    private readonly IFileBaseContextStore _store;

    public FileBaseContextQueryContextFactory(
        QueryContextDependencies dependencies,
        IFileBaseContextStoreCache FileBaseContextStoreCache,
        IDbContextOptions contextOptions)
    {
        //_store = storeCache.GetStore(contextOptions);
        _dependencies = dependencies;
        _store = FileBaseContextStoreCache.GetStore(contextOptions);
    }

    public virtual QueryContext Create()
    {
        return new FileBaseContextQueryContext(_dependencies, _store);
    }
}