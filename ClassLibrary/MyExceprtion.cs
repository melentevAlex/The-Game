using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MyExceprtion : Exception
    {
        public override string Message
        {
            get
            {
                return "something went wrong";
            }
        }

    }
}
