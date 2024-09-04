using FileBaseContext.Serializers;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FileBaseContext.Storage;

public interface IFileBaseContextFileManager
{
    void Init(IFileBaseContextScopedOptions _options);

    Dictionary<TKey, object[]> Load<TKey>(IEntityType _entityType, IRowDataSerializer serializer);

    void Save<TKey>(IEntityType _entityType, Dictionary<TKey, object[]> objectsMap, IRowDataSerializer serializer);
}