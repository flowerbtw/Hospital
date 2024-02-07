using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Database
{
    static public class DbConnect
    {
        public static HospitalContext dB = new();
    }
}
