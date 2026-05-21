FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY . .

RUN dotnet restore "PRN232.LMS.API/PRN232.LMS.API.csproj"
RUN dotnet publish "PRN232.LMS.API/PRN232.LMS.API.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080

ENTRYPOINT ["dotnet", "PRN232.LMS.API.dll"]