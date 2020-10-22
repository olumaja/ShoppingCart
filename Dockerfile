#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

#Download .Net sdk and create work directory
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app

#copy csproj file into the work directory /app and run donet restore
COPY . ./
RUN dotnet restore

#Copy project files and build our release
COPY . ./
RUN dotnet publish -c Release -o publish

#Generate run time image and expose port 5000
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
EXPOSE 80
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "UserAPI.dll"]