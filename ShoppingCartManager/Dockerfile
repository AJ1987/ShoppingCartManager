FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 62793
EXPOSE 44368

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["ShoppingCartManager/ShoppingCartManager.csproj", "ShoppingCartManager/"]
RUN dotnet restore "ShoppingCartManager/ShoppingCartManager.csproj"
COPY . .
WORKDIR "/src/ShoppingCartManager"
RUN dotnet build "ShoppingCartManager.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ShoppingCartManager.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ShoppingCartManager.dll"]