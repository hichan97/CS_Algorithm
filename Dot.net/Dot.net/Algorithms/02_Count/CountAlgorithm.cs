//[?] 1부터 1,000까지의 정수 중 13의 배수의 개수
using System;
using System.Linq;
/// <summary>
/// 개수 알고리즘(Count Algorithm): 주어진 범위에 주어진 조건에 해당하는 자료들의 개수
/// </summary>
class CountAlgorithm
{
    static void Main()
    {
        var _numbers = Enumerable.Range(1, 1_000).ToArray();     //1부터 1000까지의 배열을 만든다.

        int _count = 0;

        for (int i = 0; i < _numbers.Length; i++)
        {
            if(_numbers[i] % 13 == 0)
            {
                _count += 1;
            }
        }

        Console.WriteLine($"1부터 1,000까지의 정수 중 13의 배수의 개수 : {_count}");
    }
}

//Enumerable.Range(1, 1_000).ToArray().Where(n => n % 13 == 0).Count();
//76
//Enumerable.Range(1, 1_000).ToArray().Count(n => n % 13 == 0)
//76