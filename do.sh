#!/bin/sh
export Port=50041
export Host=0.0.0.0
APP_NAME=${APP_NAME:-trajectoryserver}

start() {
    dotnet run
}

clean() {
    dotnet clean
}

build() {
    dotnet build
    dotnet restore
}

$*