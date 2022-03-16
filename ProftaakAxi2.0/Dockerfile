FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ProftaakAxi2.0/ProftaakAxi2.0.csproj", "ProftaakAxi2.0/"]
RUN dotnet restore "ProftaakAxi2.0/ProftaakAxi2.0.csproj"
COPY . .
WORKDIR "/src/ProftaakAxi2.0"
RUN dotnet build "ProftaakAxi2.0.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProftaakAxi2.0.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProftaakAxi2.0.dll"]
