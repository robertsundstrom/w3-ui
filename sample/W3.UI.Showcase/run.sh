dotnet build -c Release
rm -rf "bin/Debug" || true
dotnet run -c Release
