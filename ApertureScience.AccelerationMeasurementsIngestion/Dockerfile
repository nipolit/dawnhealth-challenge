FROM mcr.microsoft.com/dotnet/nightly/sdk:8.0-jammy-aot AS build
ARG TARGETARCH
WORKDIR /source

ENV PROJECT_DIR="ApertureScience.AccelerationMeasurementsIngestion"

# copy csproj and restore as distinct layers
COPY "$PROJECT_DIR/*.csproj" ./
# RUN dotnet restore -a linux-$TARGETARCH

# copy and publish app and libraries
COPY "$PROJECT_DIR" .
# TODO fix build with --no-restore, reenable restore as a distinct layer
RUN dotnet publish -r linux-$TARGETARCH -o /app ApertureScience.AccelerationMeasurementsIngestion.csproj
RUN rm /app/*.dbg /app/*.Development.json


# final stage/image
FROM mcr.microsoft.com/dotnet/nightly/runtime-deps:8.0-jammy-chiseled-aot
WORKDIR /app
COPY --from=build /app .
USER $APP_UID
ENV ASPNETCORE_URLS http://+:5000
ENV DOTNET_URLS=http://+:5000
EXPOSE 5000
ENTRYPOINT ["./ApertureScience.AccelerationMeasurementsIngestion"]