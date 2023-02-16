FROM hub.nexdev.net/base/dotnet/core/sdk:7.0-alpine AS builder

WORKDIR /src

COPY ["./fanex.wasa.fps/Fanex.WASA.FPS.DI.Service", "Fanex.WASA.FPS.DI.Service"]

COPY ["./fanex.wasa.fps/Fanex.WASA.FPS.WebAPI/Fanex.WASA.FPS.DI.WebAPI.csproj", "Fanex.WASA.FPS.WebAPI/"]

WORKDIR "/fanex.wasa.fps/Fanex.WASA.FPS.WebAPI"

RUN dotnet nuget add source http://nuget.nexdev.net/api/v2

RUN dotnet restore -v n

COPY ./fanex.wasa.fps/Fanex.WASA.FPS.WebAPI .

RUN dotnet publish -r linux-x64 --self-contained false -c Release -o /app

FROM hub.nexdev.net/base/dotnet/core/aspnet:7.0-alpine AS base

WORKDIR /app

RUN sed -i 's/DEFAULT@SECLEVEL=2/DEFAULT@SECLEVEL=1/g' /etc/ssl/openssl.cnf
RUN sed -i 's/MinProtocol = TLSv1.2/MinProtocol = TLSv1/g' /etc/ssl/openssl.cnf
RUN sed -i 's/DEFAULT@SECLEVEL=2/DEFAULT@SECLEVEL=1/g' /usr/lib/ssl/openssl.cnf
RUN sed -i 's/MinProtocol = TLSv1.2/MinProtocol = TLSv1/g' /usr/lib/ssl/openssl.cnf

COPY --from=builder /app .

ENV TZ="America/La_Paz"

ENTRYPOINT ["dotnet", "Fanex.WASA.FPS.WebAPI.dll"]
