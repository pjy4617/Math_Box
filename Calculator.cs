using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTool
{
    
    class Calculator
    {
        //기본 계산시 프로그램 수정
        public int add(int a, int b)
        {
            return a + b;
        }
        public int subtract(int a, int b)
        {
            return a - b;
        }
        public int multipy(int a, int b) 
        {
            return a * b;
        }
        public int divide_new(int a, int b)
        {
            return a / b;
        }
        public int getMedian(int a, int b)
        {
            return (a + b) / 2;
        }
        public int getRemainder(int a, int b)
        {
            return a % b;
        }
        public int getAbs(int num)
        {
            if (num >= 0)
                return num;
            return -num;
        }
        public int getPercent(int a, int b)
        {
            return (a / b) * 100;
        }
    }
}
