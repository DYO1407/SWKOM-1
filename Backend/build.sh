#!/usr/bin/env bash
#
# Generated by: https://openapi-generator.tech
#

dotnet restore src/NPaperless.Services/ && \
    dotnet build src/NPaperless.Services/ && \
    echo "Now, run the following to start the project: dotnet run -p src/NPaperless.Services/NPaperless.Services.csproj --launch-profile web"
