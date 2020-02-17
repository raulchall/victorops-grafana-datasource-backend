#!/bin/bash -e

mkdir -p /var/lib/grafana/plugins/grafana-victorops-datasource
cp -r /grafana-victorops-datasource /var/lib/grafana/plugins/grafana-victorops-datasource/dist

/run.sh