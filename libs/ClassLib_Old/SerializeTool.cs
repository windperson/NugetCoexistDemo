using Newtonsoft.Json;

namespace ClassLib_Old;

// ReSharper disable once UnusedType.Global
public static class SerializeTool
{
    // ReSharper disable once UnusedMember.Global
    public static string ToJson(object obj)
    {
        //get json .net assembly version
        var version = typeof(JsonConvert).Assembly.GetName().Version;

        var payload = new { Data = obj, Serializer = $"Newtonsoft Json.NET version {version}" };
        var resultJsonString = JsonConvert.SerializeObject(payload, Formatting.Indented);

        //make it work slower
        Thread.Sleep(200);
        return resultJsonString;
    }
}