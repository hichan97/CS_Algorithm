//[?] 1부터 20까지의 정수 중 홀수의 합을 구하는 프로그램
//1. 3. 5. 7. 9, ...
using System;

/// <summary>
/// emdcktnduf(Arithmetic Sequence): 연속하는 두 수의 차이가 일정한 수열
/// </summary>

class ArithmeticSequence
{
    static void Main()
    {
        var sum = 0;

        for (int i = 0; i <= 20; i++) //범위
        { 
            if(i % 2 == 1) //필터링(홀수)
            {
                sum += i; // SUM
                Console.Write("{0, 2} ", i);    //{index, space) 0부터 두칸씩
            }
        }

        Console.WriteLine($"\n1부터 20까지의 홀수의 합 : {sum}");
    }
}