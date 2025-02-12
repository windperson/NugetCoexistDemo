using Newtonsoft.Json;

namespace ClassLibrary_New;

// ReSharper disable once UnusedType.Global
public static class SerializeTool
{
    // ReSharper disable once UnusedMember.Global
    public static string ToJson(object obj)
    {
        //get json .net assembly version
        var version = typeof(JsonConvert).Assembly.GetName().Version;

        var payload = new { Data = obj, Serializer = $"Newtonsoft Json.NET version {version}" };
        var settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented
        };
        return JsonConvert.SerializeObject(payload, settings);
    }
}