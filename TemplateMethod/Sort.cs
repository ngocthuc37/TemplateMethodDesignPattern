using System; 
using System.Collections.Generic;  
using System.Collections;


namespace TemplateMethodDesignPattern
{
    class Sorter 
    {
        protected virtual bool Func1(int v1, int v2) 
        {
            return false;
        }
        public void Sort(int [] A, int N) 
        { 
            for (int i = 0; i < N - 1; i++)
                for (int j = i +1 ; j < N; j++)
                    if (Func1(A[i],A[j])) {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
        }
    }

    class SorterA : Sorter
    { 
        protected override bool Func1(int v1, int v2) 
        {
            return v1 > v2;
        }
    }

    class SorterB : Sorter
    { 
        protected override bool Func1(int v1, int v2) 
        {
            return Math.Abs(v1) < Math.Abs(v2);
        }
    }

    class SorterC : Sorter
    { 
        protected override bool Func1(int v1, int v2) 
        {
            if ((v1 % 2 == 0) && (v2 % 2 == 0) && (v1 < v2)) return true;
            if ((v1 % 2 == 1) && (v2 % 2 == 1) && (v1 > v2)) return true;
            if ((v1 % 2 == 1) && (v2 % 2 == 0))  return true;
            return false;
        }
    }

    class SorterD : Sorter
    { 
        protected override bool Func1(int v1, int v2) 
        {
            if ((v1 % 2 == 0) && (v2 % 2 == 0) && (v1 < v2)) return true;
            if ((v1 % 2 == 1) && (v2 % 2 == 1) && (v1 > v2)) return true;   
            return false;
        }
    }

}