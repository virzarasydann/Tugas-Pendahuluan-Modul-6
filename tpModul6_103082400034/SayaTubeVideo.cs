using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(title.Length <=100 && title != null, "Panjang Maksimal harus 100 atau tidak boleh null");
            this.title = title;
            playCount = 0;
            Random rnd = new Random();
            id = rnd.Next(10000, 100000);
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count >= 0 && count <= 10000000, "Penambahan play count maksimal 10 juta per panggilan dan tidak boleh negatif.");

            
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"\n[ERROR] Exception tertangkap: {ex.Message}");
                Console.WriteLine("Penambahan play count dibatalkan karena melebihi batas tertinggi integer.");
            }

        }

        public void PrintVideoDetails()
        {

            Console.WriteLine($"Id: {id}, Title: {title}, Play Count: {playCount}");
        }
    }
}
