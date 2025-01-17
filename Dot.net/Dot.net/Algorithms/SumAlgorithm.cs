using System;

/// <summary>
// 합계 알고리즘 (Sum Algorithm) : 주어진 범위에 주어진 조건에 해당한느 자료들의 합계
/// <summary>

class SumAlgorithm
{
    static void Main()
    {
        //[1] Input : n명의 국어 점수
        //자료 구조
        int[] scores = { 100, 75, 50, 37, 90, 95 };
        int sum = 0;
        int standrad = 80;

        //[2] Process : 합계 알고리즘 : 주어진 범위에 주어진 조건
        //알고리즘
        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] >= standrad)
            {
                sum += scores[i];
            }
        }

        //[3] Output
        //UI
        Console.WriteLine($"{scores.Length}명의 점수 중 80 점 이상의 총점 : {sum}");
    }
}