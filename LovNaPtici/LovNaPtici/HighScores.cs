using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovNaPtici
{
    [Serializable]
    public class HighScores
    {
        public List<Player> players;
        public HighScores() {

            players = new List<Player>();
        
        }
        public void addPlayer(Player player)
        {
            players.Add(player);
            
        }



        public void sortScores()
        {
            List<Player> sorted = players.OrderBy(o=>o.score).ToList();
            players = sorted;

        }

        public void Save() {

            sortScores();
            string fileName = "Highscores.txt";
            string fpath = Path.GetFullPath(fileName);


         
            foreach (Player p in players)
            {

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(fpath, true))
                {
                    file.WriteLine(p.ToString());
                }

            }
                }
      
    }
}
