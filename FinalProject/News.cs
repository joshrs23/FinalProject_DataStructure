using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class News
    {
        private int ID; // Unique id for each news
        private DateTime Time; // Time of news publication which is based on EPOCH
        private string[] Keywords; // Keywords that best describe the content of news
        private string Content; // The content of news
        private int Hits; // Number of times that news has been retrieved

        public News(int iD, long time, string[] keywords, string content, int hits)
        {
            this.ID1  = iD;
            this.Time1 = time;
            this.Keywords1 = keywords;
            this.Content1 = content;
            this.Hits1 = hits;
        }

        public long Time1 { get => Time; set => Time = value; }
        public string[] Keywords1 { get => Keywords; set => Keywords = value; }
        public string Content1 { get => Content; set => Content = value; }
        public int Hits1 { get => Hits; set => Hits = value; }
        public int ID1 { get => ID; set => ID = value; }

        public override string ToString()
        {
            String keyword = "";
            string[] Keywords = this.Keywords1;
            for (int i = 0; i < Keywords.Length; i++)
            {
                keyword = keyword +" "+ Keywords[i];
            }
            return "Id :"+this.ID1+" Time : "+this.Time1+" Keywords: "+keyword+" Content: "+this.Content1+" Hits: "+this.Hits1;
        }
    }
}
