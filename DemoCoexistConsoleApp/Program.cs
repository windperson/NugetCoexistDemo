extern alias OldJsonUtil;
extern alias NewJsonUtil;
using DemoCoexistConsoleApp;

AppDomain.CurrentDomain.AssemblyResolve += CustomJsonLibResolver.OnAssemblyResolve;

var obj = new { Name = "Yabee", Price = "30" };

Console.WriteLine("Begin to serialize object:");
Console.WriteLine("\r\nOldJsonUtil:");
Console.WriteLine(OldJsonUtil.ClassLib_Old.SerializeTool.ToJson(obj));

Console.WriteLine("\r\nNewJsonUtil:");
Console.WriteLine(NewJsonUtil.ClassLibrary_New.SerializeTool.ToJson(obj));

Console.WriteLine("\r\nPress any key to exit...");
Console.ReadKey();