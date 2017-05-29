using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovNaPtici
{
    [Serializable]
   public class Player
    {
        public string username { get; set; }
        public int score { get; set; }

        public Player() { }
        public Player(string username, int score)
        {
            this.username = username;
            this.score = score;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", username, score.ToString());
        }

    }
    
}
