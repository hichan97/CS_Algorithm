//[?] n명의 점ㅅ무 중에서 80점 이상 95점 이하인 점수의 평균
// 평균 알고리즘(Average Algorithm): 주어진 범위에 주어진 조건에 해당하는 자료들의 평균

using System;

class Average
{
    static void Main()
    {
        int[] data = { 90, 65, 78, 50, 95 };
        int sum = 0;
        int count = 0;

        for (int i = 0; i < data.Length; i++)
        {
            {
                if (data[i] >= 80 && data[i] <= 95)
                {
                    sum += data[i];
                    count++;
                }
            }
        }
        double avg = sum / (double)count;

        Console.WriteLine($"80점 이상 95점 이하인 자료의 평균 : {avg}"); ;
    }
}

//80점 이상 95점 이하인 자료의 평균 : 92.5