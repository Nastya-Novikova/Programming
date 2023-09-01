using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Services
{
    public static class IdGenerator
    {
        private static int _id;
        public static int GetNextId()
        {
            _id++;
            return _id;
        }
    }
}
