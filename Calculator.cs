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
        public int divide_free(int a, int b)
        {
            return a / b;
        }
        public int square(int a)
        {
            return a * a;
        }
    }
}
