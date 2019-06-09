dotnet publish -c Release
pushd "bin/Release/netstandard2.0/publish/W3.UI.Showcase/dist"
git add .
git commit -m "Update app"
git push
popd