using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204034
{
    public class SayaTubeUser
    {
        private int id;
        private string video;
        private string title;
        private string username;
        List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(string d)
        {
            Random shuffle = new Random();
            this.id = shuffle.Next(0, 100000);
            this.title = d;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (SayaTubeVideo video in this.uploadedVideos)
            {
                total += video.GetPlaycount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo d)
        {
            uploadedVideos.Add(d);
            this.video = this.video;
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User : " + title);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " Judul : " + this.uploadedVideos[i].GetTitle());
            }
        }
    }
}