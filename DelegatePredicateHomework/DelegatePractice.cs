using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePredicateHomework
{
    internal class DelegatePractice
    {
        //public delegate void CheckStr(string str);

        //public delegate int CalculateStr(string str, int num);

        public int StrLength(string str, int n)
        {
            return str.Length + n;
        }



        //public void StrToLower(string word)
        //{
        //    Console.WriteLine(word.ToLower());
        //}


        //public void StrToUpper(string word)
        //{
        //    Console.WriteLine(word.ToUpper());
        //}


        //public void ChangeStr(string str, Action<string> func)
        //{
        //    func(str);
        //}

        public void GetStrLength(string str, Func<string,int,int> func, int m)
        {
            var res = func(str,m);
            Console.WriteLine(res);
        }


        public void ShowResult()
        {
            //ChangeStr("salam", StrToUpper);

            //Action<string> action = StrToUpper;

            //action("sagol");

            //Func<string, int, int> func = StrLength;

            //Console.WriteLine(func("salamlar", 100));
        }
    }
}
