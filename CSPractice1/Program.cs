﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice1
{
     class FirstClass
    {

    }


    internal class Program
    {
        class ThirdClass
        {

        }

        static void Main(string[] args)
        {
            // 컨텍스트 키워드
            var abc = "Hello World"; // OK
            /***  XML 주석  ***/
            /*
             *여러줄 주석 
             * 
             */
            //한 줄 주석

            // 출력
            Console.WriteLine("hello ");
            Console.Write("wolrd 개행x");

            // 정수
            Console.WriteLine(52 + 9 - 5);
            // 사칙 연산자 = 산술 연산자 = Arithmetic Operator
            // + - * / %

            // 실수(Real Number)
            Console.WriteLine(52.0);

            // 문자(Character)
            Console.WriteLine('A');
            Console.WriteLine('가');

            // 문자열(String)
            Console.WriteLine("Hello World!");
            // 이스케이프 문자
            Console.WriteLine("미\n\\림\t마\"고");
            // 문자열 연결 연산자(Concatenation Operator)
            Console.WriteLine("Hello" + " " + "World!");
            // 문자열 인덱스 접근 [ ]
            Console.WriteLine("Hello World"[4]);  // 'o'
            //Console.WriteLine("Hello World"[100]);  // 예외발생

            // 주의
            Console.WriteLine('가' + '힣'); // 문자열 연결 연산자x 덧셈 연산자로 인식

            // 논리(Boolean)
            Console.WriteLine(true);
            Console.WriteLine(false);
            // 비교 연산자(Comparison Operator)
            // == != > < >= <=

            //논리 연산자(Logical Operator)
            // && || !
            Console.WriteLine(!true);
            Console.WriteLine(true && false);
            Console.WriteLine(true || false);

            //#1 12-4. 변수
            string name = "문자열 자료형";

            //#1 12-5. 복합대입연산자
            // +- -= *= /= %=
            string output = "Hello";
            output += " World";
            Console.WriteLine(output);

            // #1 12-6. 증감 연산자
            int number = 10;
            Console.WriteLine(number++); //10
            Console.WriteLine(++number); //12
            Console.WriteLine(number--); //12
            Console.WriteLine(--number); //10

            // #1 12-7. var 키워드
            var varnumber = 20;  // 컴파일 시점에 int가 됨
            // var abc; // 에러 (선언과 동시에 반드시 초기화를 해야함)

            // #1 12-9. 입력
            string input = Console.ReadLine();
            Console.WriteLine(input);

            // #1 12-10. 자료형 변환
            // 굉장히 중요

            // #2 13-1. if 조건문
            bool condition = true;
            if(condition)
            {
                // true
            }
            else if (condition)
            {
                 // true2
            }
            else
            {
                // other
            }

            // #2 13-2. switch 조건문
            int v = 0;
            switch (v)
            {
                case 0:
                    // 0
                    break;
                default:
                    //other
                    break; // default에도 break를 써줘야함
            }

            // #2  13-6. 삼항 연산자
            Console.WriteLine(number % 2 != 1 ? "짝수" : "홀수");

            // #3 14-1. 반복문과 배열
            int[] intArray = new int[100];
            Console.WriteLine(intArray[99]);

            // #3 14-2. while 반복문
            int i = 0;
            int[] intArray2 = { 52, 273, 32 };
            while( i < intArray2.Length)
            {
                Console.WriteLine(intArray2[i]);
                i++; // 탈출을 위한 변수
            }

            // #3 14-6. foreach 반복문
            string[] foreachArray = { "사과", "배", "포도" };
            foreach (var item in foreachArray)
            {
                Console.WriteLine(item);
            }

            // #4 21-2. 클래스 사용
            Random random = new Random();
            Console.WriteLine(random.Next(1, 7)); // 1에서 6 사이 난수

            Console.WriteLine(Math.Abs(-9)); // 9
            Console.WriteLine(Math.Ceiling(52.273)); // 53
            Console.WriteLine(Math.Floor(52.273)); // 52
            Console.WriteLine(Math.Max(52, 273)); //273
            Console.WriteLine(Math.Max(52, 273)); //53
            Console.WriteLine(Math.Round(52.273)); // 52
            Console.WriteLine(Math.PI); // 3.14159265358979

            // #4 21-3. 클래스 생성

            // #4 21-4. 인스턴스 변수
            User user1 = new User();
            user1.name = "이미림";
            user1.phoneNumber = "010-1234-5678";

            Product p1 = new Product();
            p1.name = "어른폰";
            p1.price = 999999;

            Product p2 = new Product() { price = 10000, name = "아이폰" };
            Product p3 = new Product() { price = 10000};

            // #4 21-5. 클래스 변수
            Console.WriteLine(Product.TAX_RATIO);
            // Console.WriteLine(p1.TAX_RATIO); // java에서는 가능, C#은 x
    


        
        
        }
    }
}
