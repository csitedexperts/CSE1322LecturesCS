using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_CustomException
{
    class MismatchStudentNameException : Exception
    {
        public MismatchStudentNameException()
        {

        }

        public MismatchStudentNameException(string name)
            : base(String.Format("Mismatch Student Name: {0}", name))
        {

        }
    }
}
