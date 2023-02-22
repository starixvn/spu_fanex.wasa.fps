FROM hub.nexdev.net/base/dotnet/core/sdk:7.0 AS builder

WORKDIR /src

COPY ["./src/Fanex.WASA.FPS.Account.Service", "Fanex.WASA.FPS.Account.Service/"]

COPY ["./src/Fanex.WASA.FPS.Account.DataAccess", "Fanex.WASA.FPS.Account.DataAccess/"]

COPY ["./src/Fanex.WASA.FPS.Account.Model", "Fanex.WASA.FPS.Account.Model/"]

COPY ["./src/Fanex.WASA.FPS.Association.Service", "Fanex.WASA.FPS.Association.Service/"]

COPY ["./src/Fanex.WASA.FPS.Association.DataAccess", "Fanex.WASA.FPS.Association.DataAccess/"]

COPY ["./src/Fanex.WASA.FPS.Association.Model", "Fanex.WASA.FPS.Association.Model/"]

COPY ["./src/Fanex.WASA.FPS.Device.Service", "Fanex.WASA.FPS.Device.Service/"]

COPY ["./src/Fanex.WASA.FPS.Device.DataAccess", "Fanex.WASA.FPS.Device.DataAccess/"]

COPY ["./src/Fanex.WASA.FPS.Device.Model", "Fanex.WASA.FPS.Device.Model/"]

COPY ["./src/Fanex.WASA.FPS.DI.Service", "Fanex.WASA.FPS.DI.Service/"]

COPY ["./src/Fanex.WASA.FPS.DI.DataAccess", "Fanex.WASA.FPS.DI.DataAccess/"]

COPY ["./src/Fanex.WASA.FPS.DI.Model", "Fanex.WASA.FPS.DI.Model/"]

COPY ["./src/Fanex.WASA.FPS.Transaction.Service", "Fanex.WASA.FPS.Transaction.Service/"]

COPY ["./src/Fanex.WASA.FPS.Transaction.DataAccess", "Fanex.WASA.FPS.Transaction.DataAccess/"]

COPY ["./src/Fanex.WASA.FPS.Transaction.Model", "Fanex.WASA.FPS.Transaction.Model/"]

COPY ["./src/Fanex.WASA.FPS.DI.WebAPI/Fanex.WASA.FPS.DI.WebAPI.csproj", "Fanex.WASA.FPS.DI.WebAPI/"]

WORKDIR "/src/Fanex.WASA.FPS.DI.WebAPI"

RUN dotnet nuget add source http://nuget.nexdev.net/api/v2

RUN dotnet restore -v n

COPY ./src/Fanex.WASA.FPS.DI.WebAPI .

RUN dotnet publish -r linux-x64 --self-contained false -c Release -o /app

FROM hub.nexdev.net/base/dotnet/core/aspnet:7.0 AS base

WORKDIR /app

RUN sed -i 's/DEFAULT@SECLEVEL=2/DEFAULT@SECLEVEL=1/g' /etc/ssl/openssl.cnf
RUN sed -i 's/MinProtocol = TLSv1.2/MinProtocol = TLSv1/g' /etc/ssl/openssl.cnf
RUN sed -i 's/DEFAULT@SECLEVEL=2/DEFAULT@SECLEVEL=1/g' /usr/lib/ssl/openssl.cnf
RUN sed -i 's/MinProtocol = TLSv1.2/MinProtocol = TLSv1/g' /usr/lib/ssl/openssl.cnf

COPY --from=builder /app .

ENV TZ="America/La_Paz"

ENTRYPOINT ["dotnet", "Fanex.WASA.FPS.DI.WebAPI.dll"]
