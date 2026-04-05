using System;
using System.Collections.Generic;
using System.Text;

namespace tpModul6_103082400034
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            this.title = title;
            playCount = 0;
            Random rnd = new Random();
            id = rnd.Next(10000, 100000);
        }

        public void IncreasePlayCount(int count)
        {
            playCount = count;

        }

        public void PrintVideoDetails()
        {

            Console.WriteLine($"Id: {id}, Title: {title}, Play Count: {playCount}");
        }
    }
}
