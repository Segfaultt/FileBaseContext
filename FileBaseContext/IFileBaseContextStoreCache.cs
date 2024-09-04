using FileBaseContext.Storage;

namespace FileBaseContext;

public interface IFileBaseContextStoreCache
{
    IFileBaseContextStore GetStore(IFileBaseContextScopedOptions options);
}