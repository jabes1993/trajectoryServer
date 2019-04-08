#!/bin/sh
APP_NAME=${APP_NAME:-trajectoryserver}

start() {
    dotnet run
}

$*