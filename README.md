# Victor Ops Grafana Datasource Backend

The VictorOps Grafana Datasource is a backend service created to overcome the VictorOps Api limitations and 
bring your teams, users and on call schedules into your Grafana dashboards.

## How does it work?

Run the VO Api Backend service and connect with [Victor Ops Api](https://help.victorops.com/knowledge-base/api/). Then 
use the [Grafana Simple Json Backend](https://github.com/grafana/simple-json-datasource) to visualize your Victor Ops data.

## How to use?

### Standalone

Standalone mode runs the backend as a single service, uses in-memory storage and no external broker is required for 
task coordination.

To run in standalone mode use the environment variable:
```

```

WIP

## Contributing

