FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 6000
EXPOSE 6001

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["dotnet/MyAmigurumi.Identity.App/MyAmigurumi.Identity.App.csproj", "dotnet/MyAmigurumi.Identity.App/"]
RUN dotnet restore "dotnet/MyAmigurumi.Identity.App/MyAmigurumi.Identity.App.csproj"
COPY . .
WORKDIR "/src/dotnet/MyAmigurumi.Identity.App"
RUN dotnet build "./MyAmigurumi.Identity.App.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./MyAmigurumi.Identity.App.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyAmigurumi.Identity.App.dll"]
