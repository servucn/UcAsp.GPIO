FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY UcAsp.GPIO/UcAsp.GPIO.csproj UcAsp.GPIO/
RUN dotnet restore UcAsp.GPIO/UcAsp.GPIO.csproj
COPY . .
WORKDIR /src/UcAsp.GPIO
RUN dotnet build UcAsp.GPIO.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish UcAsp.GPIO.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "UcAsp.GPIO.dll"]
