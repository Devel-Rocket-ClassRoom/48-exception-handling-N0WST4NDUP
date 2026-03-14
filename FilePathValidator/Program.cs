using System;

FilePathValidator pv = new();
Console.WriteLine("=== 경로 검증 테스트 ===");
try
{
    string path = "C:/Users/data/report.txt";
    pv.ValidatePath(path);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
try
{
    pv.ValidatePath(null);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
try
{
    pv.ValidatePath("<");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
try
{
    pv.ValidatePath(new string('.', 261));
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("\n=== 확장자 검증 테스트 ===");

string[] allowed = { ".txt", ".csv" };

string[] testFiles =
{
                "report.txt",
                "data.csv",
                "virus.exe"
            };

foreach (var file in testFiles)
{
    try
    {
        pv.ValidateExtension(file, allowed);
    }
    catch (Exception e)
    {
        Console.WriteLine($"{e.Message}");
    }
}