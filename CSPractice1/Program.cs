﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice1
{
    internal class Program
    {
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

            












        }
    }
}
