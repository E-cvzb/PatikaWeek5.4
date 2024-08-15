using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek5._4
{
    public  class MyException : Exception
    {
        
        public MyException(string text) :base(text) // benim tanımladığım hata mesajı
        {
          
        }
    }
}
