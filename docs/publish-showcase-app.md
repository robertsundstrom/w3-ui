# Publish W3 UI Showcase

To set up the publish the showcase app, perform the following steps in the folder in which you have cloned the repo.

Assuming that you are using Bash.

### Setup
Set the ```dist``` folder up as the source GitHub repository.

```sh
$ dotnet publish -c Release
$ cd bin/Release/netstandard2.0/publish/W3.UI.Showcase/dist
$ git init
$ git remote add origin git@github.com:robertsundstrom/w3-ui-showcase
$ git fetch
$ git reset --hard origin/master
```
### Publish

```sh
# Publish from the project root
$ dotnet publish -c Release

# Go to the 'dist' folder, commit and push changes.
$ cd bin/Release/netstandard2.0/publish/W3.UI.Showcase/dist
$ git add .
$ git commit
$ git push
```

Changes should be available shortly after at: http://robertsundstrom.com/w3-ui-showcase/


**Note:** Make sure that the ```/_framework/_bin``` directory contains the necessary assemblies.
