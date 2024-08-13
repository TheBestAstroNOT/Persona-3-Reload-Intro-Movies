# Set Working Directory
Split-Path $MyInvocation.MyCommand.Path | Push-Location
[Environment]::CurrentDirectory = $PWD

Remove-Item "$env:RELOADEDIIMODS/Persona_3_Reload_Intro_Movies/*" -Force -Recurse
dotnet publish "./Persona_3_Reload_Intro_Movies.csproj" -c Release -o "$env:RELOADEDIIMODS/Persona_3_Reload_Intro_Movies" /p:OutputPath="./bin/Release" /p:ReloadedILLink="true"

# Restore Working Directory
Pop-Location