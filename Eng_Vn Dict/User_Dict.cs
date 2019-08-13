using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Eng_Vn_Dict
{
    public class User_Dict
    {
        public string Word { get; set; }
        public string Meaning { get; set; }

        public string getfMeaning(string meaning)
        {
            string m = meaning.Replace('@', '\n');
            return m;
        }
    }
}
