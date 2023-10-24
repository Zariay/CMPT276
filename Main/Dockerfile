FROM mcr.microsoft.com/dotnet/aspnet:7.0-nanoserver-1809 AS base
WORKDIR /app
EXPOSE 5124

ENV ASPNETCORE_URLS=http://+:5124

FROM mcr.microsoft.com/dotnet/sdk:7.0-nanoserver-1809 AS build
ARG configuration=Release
WORKDIR /src
COPY ["Main/SampleProj.csproj", "Main/"]
RUN dotnet restore "Main\SampleProj.csproj"
COPY . .
WORKDIR "/src/Main"
RUN dotnet build "SampleProj.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "SampleProj.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SampleProj.dll"]
