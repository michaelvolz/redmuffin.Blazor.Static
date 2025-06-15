# Start the Blazor WebAssembly frontend
Start-Process pwsh -ArgumentList '-NoExit', '-Command', 'dotnet run --project "src/redmuffin.Blazor.StaticWeb"'

# Start the Azure Functions API backend
Start-Process pwsh -ArgumentList '-NoExit', '-Command', 'dotnet run --project "src/redmuffin.Blazor.StaticWeb.Api"'

# Wait a few seconds to ensure both projects are running
Start-Sleep -Seconds 5

# Start Azure Static Web Apps CLI
swa start http://localhost:5233 --api-location http://localhost:7184/api
