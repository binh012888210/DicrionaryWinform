using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Eng_Vn_Dict
{
   public class Dict
    {
       public string word { get; set; }
        public string offset { get; set; }
        public string range  { get; set; }
        public string getMeaning(int offset, int range)
        {
            // Filename của từ điển
            string fileName = "anhviet.dict";
            string dataPath = Path.Combine(Environment.CurrentDirectory, @"EV\", fileName);
            // Ðọc từ điển để lấy nghĩa của từ
            using (FileStream fs = File.Open(dataPath, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                // Byte để giữ nghĩa của từ
                byte[] b = new byte[range];

                // Setup cái offset
                fs.Position = offset;

                // Ðọc [FileStream.Read(byte[] buffer, int offset, in length)
                // 0 tại mình đã setup cái offset ở line trên rồi
                fs.Read(b, 0, b.Length);

                // Chuyển byte[] qua unicode( utf-8 ) string, rồi return
                return System.Text.Encoding.UTF8.GetString(b);
            }
        }

    }


}
