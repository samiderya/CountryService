FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
EXPOSE 5201
COPY . /app/
ENTRYPOINT ["dotnet", "/app/CountryDemo.dll"]