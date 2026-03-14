using System;

SafeCalculator sc = new();
Console.WriteLine("=== 테스트 1: 정상 입력 ===");
try
{
    Console.WriteLine(sc.Divide("10", "2"));
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("계산기를 종료합니다.");
}

Console.WriteLine("=== 테스트 2: 0으로 나누기 ===");
try
{
    Console.WriteLine(sc.Divide("10", "0"));
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("계산기를 종료합니다.");
}

Console.WriteLine("=== 테스트 3: 잘못된 형식 ===");
try
{
    Console.WriteLine(sc.Divide("하하", "하하하"));
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("계산기를 종료합니다.");
}