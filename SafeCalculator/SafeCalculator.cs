using System;
using System.IO;

public class SafeCalculator
{
    public int Divide(string num1, string num2)
    {
        if (int.TryParse(num1, out int a) && int.TryParse(num2, out int b))
        {
            if (b == 0) throw new DivideByZeroException("0으로 나눌 수 없습니다.");

            return a / b;
        }
        else throw new FormatException("올바른 숫자를 입력하세요.");
    }
}