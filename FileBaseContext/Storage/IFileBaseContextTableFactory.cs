using Microsoft.EntityFrameworkCore.Metadata;

namespace FileBaseContext.Storage;

public interface IFileBaseContextTableFactory
{
    IFileBaseContextTable Create(IEntityType entityType, IFileBaseContextTable baseTable);
}