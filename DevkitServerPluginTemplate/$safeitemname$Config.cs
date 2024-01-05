using System.Text.Json.Serialization;

namespace $rootnamespace$;

// Implementing IDefaultable is not required.
public sealed class $safeitemname$Config : IDefaultable
{
    [JsonPropertyName("hello_property")]
    public string? HelloProperty { get; set; }
    public void SetDefaults()
    {
        HelloProperty = "hello";
    }
}
