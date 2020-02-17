ARG GRAFANA_VERSION="latest"
FROM grafana/grafana:${GRAFANA_VERSION}

# Copy the plugin into the grafana plugin folder
COPY ./plugins/grafana-victorops-datasource/dist /grafana-victorops-datasource

COPY ./run-cdp.sh /run-cdp.sh

USER grafana

ARG GF_INSTALL_PLUGINS=""

RUN if [ ! -z "${GF_INSTALL_PLUGINS}" ]; then \
    OLDIFS=$IFS; \
        IFS=','; \
    for plugin in ${GF_INSTALL_PLUGINS}; do \
        IFS=$OLDIFS; \
        grafana-cli --pluginsDir "$GF_PATHS_PLUGINS" plugins install ${plugin}; \
    done; \
fi

ENTRYPOINT ["/run-cdp.sh"]