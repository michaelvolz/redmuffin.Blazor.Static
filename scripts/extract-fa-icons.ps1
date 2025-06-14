# Download Font Awesome CSS
$cssUrl = "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.7.0/css/all.min.css"
$cssContent = Invoke-WebRequest -Uri $cssUrl -UseBasicParsing | Select-Object -ExpandProperty Content

# Extract icon class names (e.g., fa-user, fa-home)
$iconPattern = '(?<=\.fa-)[a-z0-9-]+(?=:|,| )'
$matches = [regex]::Matches($cssContent, $iconPattern)

# Get unique icon names, sort alphabetically
$iconNames = $matches | ForEach-Object { $_.Value } | Sort-Object -Unique

# Output as C# string array
$iconArray = $iconNames | ForEach-Object { "`"fa-$_`"" }
Write-Output "new string[] { $($iconArray -join ', ') };"