using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class AgeException:ApplicationException
    {
        public override string Message
        {
            get {
                return "Age must be in between 20 to 60";
            }
        }
    }
}
