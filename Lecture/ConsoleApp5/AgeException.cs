using System;
namespace ConsoleApp5
{
    class AgeException:ApplicationException
    {
        
        public override string Message
        {
            get
            {
                return "age should be between 20 - 60";
            }
        }
    }
}
