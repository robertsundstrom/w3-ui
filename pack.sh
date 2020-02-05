#!/usr/bin/env bash

set -eu

CYAN='\033[0;36m'
NC='\033[0m'

__exec() {
    local cmd=${1:0}
    shift
    echo -e "${CYAN} > $cmd $@${NC}"
    $cmd $@
}

rm -r artifacts/ || true
rm -r src/W3.UI/obj/ || true

__exec dotnet restore ./src/W3.UI/
__exec dotnet build -c Release ./src/W3.UI/
__exec dotnet pack -c Release ./src/W3.UI/

__exec dotnet restore ./src/W3.Extensions/
__exec dotnet build -c Release ./src/W3.Extensions/
__exec dotnet pack -c Release ./src/W3.Extensions/