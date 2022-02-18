FROM mcr.microsoft.com/dotnet/core/sdk:3.1

RUN mkdir -p /usr/src
WORKDIR /usr/src

COPY Finbourne.Insights.Sdk.sln /usr/src/
COPY Finbourne.Insights.Sdk/Finbourne.Insights.Sdk.csproj /usr/src/Finbourne.Insights.Sdk/
RUN dotnet restore Finbourne.Insights.Sdk

ENV FBN_INSIGHTS_API_URL ${FBN_INSIGHTS_API_URL}

# ENTRYPOINT [ "/bin/bash" ]
ENTRYPOINT dotnet build --configuration Release --verbosity normal Finbourne.Insights.Sdk