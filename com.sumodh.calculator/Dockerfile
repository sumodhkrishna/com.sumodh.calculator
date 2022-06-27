#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["com.sumodh.calculator/com.sumodh.calculator.csproj", "com.sumodh.calculator/"]
RUN dotnet restore "com.sumodh.calculator/com.sumodh.calculator.csproj"
COPY . .
WORKDIR "/src/com.sumodh.calculator"
RUN dotnet build "com.sumodh.calculator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "com.sumodh.calculator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "com.sumodh.calculator.dll"]