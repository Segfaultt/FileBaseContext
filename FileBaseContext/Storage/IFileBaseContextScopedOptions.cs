﻿namespace FileBaseContext.Storage;

public interface IFileBaseContextScopedOptions
{
    string DatabaseName { get; }
    string Location { get; }
}