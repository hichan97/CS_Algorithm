//[?] 주어진 데이터 중에서 가장 작은 [짝수] 값
using System;
using System.Linq;

class MinAlgorithm
{
    static void Main(string[] args)
    {
        //[1] Initialize
        int min = int.MaxValue; //정수 형식의 데이터 중 가장 작은 값으로 초기화

        //[2] Input
        int[] numbers = {0b0010, 0B_0101, 0b0011, 0B_0111, 0b0000_0001 }; //2진수로 표현된 숫자

        //[3] Process : Max
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min && numbers[i] % 2 == 0)
            {
                min = numbers[i];   //더 작은 값으로 할당
            }
        }

        //[4] Output
        //Console.WriteLine($"짝수 최솟값(식) : {numbers.Min()}");
        Console.WriteLine($"짝수 최솟값(식) : {numbers.Where(n => n % 2 == 0).Min()}"); //람다식
        Console.WriteLine($"짝수 최솟값(문) : {min}");
    }
}

