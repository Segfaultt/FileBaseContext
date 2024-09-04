using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

namespace FileBaseContext.Infrastructure;

public class FileBaseContextConventionSetBuilder : ProviderConventionSetBuilder
{
    public FileBaseContextConventionSetBuilder(ProviderConventionSetBuilderDependencies dependencies) : base(dependencies)
    {
    }
}