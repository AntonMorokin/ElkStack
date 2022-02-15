#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ElkStack/ElkStack.csproj", "ElkStack/"]
RUN dotnet restore "ElkStack/ElkStack.csproj"
COPY . .
WORKDIR "/src/ElkStack"
RUN dotnet build "ElkStack.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ElkStack.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ElkStack.dll"]