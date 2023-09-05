using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Message
    {
        private readonly string _content;
        private readonly string _author;
        private readonly DateTime _time;
        private int _likes;

        public Message() { }

        public Message(string content, string author, DateTime time)
        {
            this._content = content;
            this._author = author;
            this._time = time;
        }

        public int Likes { get => _likes; }
        public DateTime Time { get => _time; }
        public string Author { get => _author; }
        public string Content { get => _content; }

        public void AddLike()
        {
            _likes++;
        }

        public double GetPopularity()
        {
            double elapsed = DateTime.Now.Subtract(this._time).TotalSeconds;
            if (elapsed == 0)
            {
                return _likes;
            }
            return _likes / elapsed;

        }
        public void Showmessage()
        {
            Console.WriteLine("Sisu: {0}\nAutor {1}",Content, Author);
        }
        public string popularinfo(double esimene, double teine)
        {
            string rezult = "";
            if (esimene > teine) { rezult = "Esimene sõnum on populaarsem kui teine"; };
            if (esimene < teine) { rezult = "Teine sõnum on populaarsem kui Esimene"; };
            if (esimene == teine) { rezult = "Nad sarnased"; };
            return rezult;
        }
        public string PopularInfon(List<Message> messages)
        {
            string rezult = "";
            double popularity = 0;
            for(int i =0; i < messages.Count; i++)
            {
                if (messages[i].GetPopularity() > popularity)
                {
                    rezult = messages[i].Content + " on kõige populaasrsem sõnum, seda kirjutas " + messages[i].Author;
                }
            }
            return rezult;
        }

    }
}
