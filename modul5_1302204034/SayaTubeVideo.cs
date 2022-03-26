using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204034
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string b)
        {
            //5. contract
            //Contract.Requires(title != null);
            //Contract.Requires(title.Length < 100); 
            Random c = new Random();
            this.id = c.Next(0, 100000);
            this.title = b;
            playCount = 0;
        }

        public void IncreasePlayCount(int b)
        {
            // 5.try-catch 
            //try
            //{ 
            //    if (b >= 10000000) throw new Exception("angka melebihi batas");
            //    playCount = playCount + b;
            // }
            // catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            // }
            playCount += b;
        }
        public int GetPlaycount()
        {
            return playCount;
        }

        public string GetTitle()
        {
            return title;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("id :" + id);
            Console.WriteLine("Title :" + title);
            Console.WriteLine("PlayCount : " + playCount);
            Console.WriteLine();
        }
    }
}
