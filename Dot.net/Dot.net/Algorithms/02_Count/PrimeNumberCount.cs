//[?] 정수 하나를 입력 받아, 2부터 해당 수까지에 존재하는 모든 소수를 찾아 출력
// 예 : 2 ~ 20 까지의 정수 : 2, 3, 5, 7, 11, 13, 17, 19 -> 8개
using System;
/// <summary>
/// 소수(Prime Nuber) 개수(Count) 구하기
/// </summary>
class PrimeNumberCount
{
    static void Main()
    {
        //[1]
        var count = 0;  //소수 개수
        var sw = true;  //소수(true)인지 확인하는 스위치 변수(flag)
        var number = 0; //2부터 n까지의 수 중 소수를 구함
        Console.Write("수입력 : _\b");
        number = Convert.ToInt32(Console.ReadLine());
        
        //[2] Process : Prime Nuber -> Count
        for (int i = 2; i <= number; i++)    //2부터 n까지 반복함
        {
            sw = true; //일단 모든 반복마다 소수를 놓고 시작

            //2부터 현재수 (i) -1까지 나누었을 떄 나누어 떨어지면 소수가 아님
            for (int j = 2; j < i; j++)
            {
                if(i % j == 0)
                {
                    sw = false;
                    break;
                }
            }

            if (sw)
            {
                Console.Write($"{i}\t");    //소수 출력
                count++;    //COUNT
                if(count % 5 == 0)
                {
                    Console.WriteLine();    //줄바꿈
                }
            }
        }

        if (number == 1)
        {
            Console.WriteLine("1을 입력하셨습니다.");
        }
        else
        {
            Console.WriteLine($"\n2부터 {number}까지의 소수의 개수 : {count}");
        }

        while(true)
        {
            //터미널 꺼짐 방지
        }
    }
}
