FROM microsoft/dotnet:sdk

ADD . /opt/app
WORKDIR /opt/app

EXPOSE 5000

RUN ["dotnet", "restore"]

CMD ["dotnet", "run", "--urls", "http://localhost:5000"]