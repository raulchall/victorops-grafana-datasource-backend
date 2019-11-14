#!/bin/bash

echo ${PWD}
docker run --rm -v ${PWD}/src:/local openapitools/openapi-generator-cli generate \
    -i local/clients/victorops-api-v1.yaml \
    -g csharp-netcore \
    -o /local/clients/netstandard
