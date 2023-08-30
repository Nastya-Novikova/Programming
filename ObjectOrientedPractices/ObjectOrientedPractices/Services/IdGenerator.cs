using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Services
{
    public class IdGenerator
    {
        private static int _id = 0;
        public static int GetNextId()
        {
            _id++;
            return _id;
        }
    }
}
