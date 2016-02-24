using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBl
{
    public class MyBlCLass:MarshalByRefObject
    {
        //public int Sum(int i, int j)
        //{
        //    return i + j;
        //}
        static string msg;
        public void send(string s)
        {
            msg += s + Environment.NewLine;
        }
        public string GetMsg()
        {
            return msg;
        }
    }
}
