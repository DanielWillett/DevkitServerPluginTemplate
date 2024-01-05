Plugin Template for https://github.com/DanielWillett/DevkitServer

The API is very subject to change until final release.

To use:
* Clone repo (don't open the project yet).
* Delete the `.git` folder to unlink it from the repo.
* Open the `DevkitServerPluginTemplate.sln` file and find and replace `DevkitServerPluginTemplate` -> *Your plugin name*
* Find and replace all GUIDs **except for the ones in the `Project("xxx")` sections** with new unique GUIDs generated with a tool like https://www.guidgenerator.com/. There should be 3 total GUIDs needed.
  * Keep any GUIDs that are the same linked. So if you have to GUIDs that were the same they need to be the same after you're done.
* Rename `DevkitServerPluginTemplate/`,  `DevkitServerPluginTemplate.sln`, `DevkitServerPluginTemplate/DevkitServerPluginTemplate.csproj` to the name specified in the solution file.
* Replace `$safeitemname$` in the `$safeitemname$.cs` and `$safeitemname$Config.cs` file names with your plugin name.
* Open the solution in visual studio and find/replace the following values in all files:
  * `$safeitemname$` -> Your plugin name without spaces or special characters (example: DevkitServer)
  * `$username$` -> Your name (usually your GitHub name)
  * `$rootnamespace$` -> Your desired root namespace.
  * `$projectname$` -> The friendly readible name of your project (example: Devkit Server)
* Open the `.csproj` file and edit any sections with `TODO` over them.
  * `<TargetSide>` should match which platform(s) you plan to target. Both will create two separate builds for server and client.
  * You may have to restart visual studio after changing target sides.
* If needed, open `~/Paths.targets` and specify the correct paths to your unturned installations.
* Add your own icon and edit the readme if you want.

Make sure your configuration is synced with the project configuration (see the picture below) under `Build -> Configuration Manager`.
If you see `Current solution contains incorrect configuration mappings...` at the top, reload your project.

*Why isn't this a proper VS template?* Good question. I couldn't get it to work. Feel free to open a PR on the template if you do.
