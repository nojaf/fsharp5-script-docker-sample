# Minimal Package references for F# scripts sample

Spin up the container by running `run.ps1`.

This will start up an interactive container with the sample fsharp script.

> docker run --rm -it -v "${pwd}:/app" -w "/app" mcr.microsoft.com/dotnet/core/sdk:5.0.100-preview bash

Once inside the container, execute the script with:

> dotnet fsi --langversion:preview ./script.fsx

View the downloaded packages in the cache of the container:

> ls -la ~/.nuget/packages/