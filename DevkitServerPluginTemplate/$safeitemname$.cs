using System.Reflection;

namespace $rootnamespace$;

public class $safeitemname$ : Plugin<$safeitemname$Config>
{
    /// <summary>
    /// The singleton instance of the <see cref="$safeitemname$"/> plugin.
    /// </summary>
    public static $safeitemname$? Instance { get; private set; }
    protected override void Load()
    {
        Instance = this;

        AssemblyName assemblyName = Assembly.Assembly.GetName();
        this.LogInfo(Translations.Translate("LoadText", assemblyName.Name, assemblyName.Version.ToString(3), "$username$"));

        this.LogInfo(Configuration.HelloProperty ?? "Hello config is null.");
    }
    protected override void Unload()
    {
        Instance = null;

        AssemblyName assemblyName = Assembly.Assembly.GetName();
        this.LogInfo(Translations.Translate("UnloadText", assemblyName.Name, assemblyName.Version.ToString(3), "$username$"));
    }

    protected override LocalDatDictionary DefaultLocalization => new LocalDatDictionary
    {
        { "LoadText", "Loaded {0} v{1} by {2}." },
        { "UnloadText", "Unloaded {0} v{1} by {2}." } 
    };

#if DEBUG
    public override bool DeveloperMode => true;
#else
    public override bool DeveloperMode => false;
#endif
}