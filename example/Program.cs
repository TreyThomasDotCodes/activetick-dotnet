// See https://aka.ms/new-console-template for more information
using TreyThomasCodes.ActiveTickDotNet;
using TreyThomasCodes.ActiveTickDotNet.Example;

Console.WriteLine("Hello world, welcome to ActiveTick Dotnet!");
Console.WriteLine();
var settings = new AppSettings();
var values = settings.ReadSection<ActiveTick>("ActiveTick");
var client = new ActiveTickClient(values.BaseUrl, values.Username, values.Password, values.ApiKey);

var snapshot = await client.GetSnapshotAsync("SPXW_231120C437500C_O U");
Console.WriteLine(snapshot.ToString());