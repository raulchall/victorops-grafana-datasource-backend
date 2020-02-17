# Victor Ops Grafana Datasource Backend

```
NOTE: This project is currently under development.
```

The VictorOps Grafana Datasource is a backend service created to overcome the VictorOps Api limitations and 
bring your teams, users and on call schedules into your Grafana dashboards.

## How does it work?

Run the VO Api Backend service and connect with [Victor Ops Api](https://help.victorops.com/knowledge-base/api/). Then 
use the [Grafana Simple Json Backend](https://github.com/grafana/simple-json-datasource) to visualize your Victor Ops data.

## How to use?

1. Run it in [Docker](https://hub.docker.com/repository/docker/raulchall/victorops-grafana-ds-backend)

```
docker run -e AppMode=standalone -e LogLevel=Error -e DatabaseName=VictorOpsMetadataDb -P raulchall/victorops-grafana-ds-backend
```

2. Build from source (Requires dotnet SDK 3.1)

```
cd victorops-api-backend/src
dotnet build
dotnet path/to/VictorOpsBackendApi.dll
```

### Standalone Mode

Standalone mode runs the backend as a single service, uses in-memory storage and no external broker is required for 
task coordination. To run in standalone mode pass in the environment variable `AppMode=standalone`.

### HA Mode (Beta)

HA mode allows you to run the VictorOps Grafana Datasource Backend with more than one instances. It requires a centralized
[PostgreSQL](https://www.postgresql.org/) database for storing the metadata retrieved from VictorOps and the
tasks each instance is required to run to keep this metada up to date. It also requires a Redis server that
serves as a remote broker for task locking coordination between multiple instances.

## Contributing

Same, same. Add [issues or feature requests](https://github.com/raulchall/victorops-grafana-datasource-backend/issues). Send me a PR. 

