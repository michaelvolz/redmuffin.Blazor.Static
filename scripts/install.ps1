$ErrorActionPreference = "Stop"

& "$PSScriptRoot/install-manifest.ps1"
if ($LastExitCode) {throw "Failed to install manifest. Maybe it already exists?"}

& "$PSScriptRoot/install-libman.ps1"
if ($LastExitCode) {throw "Failed to install libman!"}

& "$PSScriptRoot/install-webcompiler.ps1"
if ($LastExitCode) {throw "Failed to install webcompiler!"}
