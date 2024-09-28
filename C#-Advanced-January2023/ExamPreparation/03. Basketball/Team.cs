using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        private string name;
        private int openPosition;
        private char group;
        private List<Player> players = new List<Player>();
        private int count;

        public Team(string name, int openPosition, char group)
        {
            Name = name;
            OpenPosition = openPosition;
            Group = group;
        }

        public string Name { get; set; }
        public int OpenPosition { get; set; }

        public char Group { get; set; }
        public int Count { get { return this.count; } }

       
        public string AddPlayer(Player player)
        {
            if (OpenPosition > 0 && player.Rating > 80 && player.Position != null && player.Position != string.Empty && player.Name != null && player.Name != string.Empty)
            {
                count++;
                players.Add(player);
                OpenPosition--;
                return $"Successfully added {player.Name} to the team. Remaining open positions: {this.OpenPosition}.";
            }
            else if (player.Name == null || player.Position == null || player.Position == string.Empty || player.Name == string.Empty)
            {
                return "Invalid player's information.";
            }
            else if (OpenPosition <= 0)
            {
                return "There are no more open positions.";
            }
            else if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }
            return null;
        }

        public bool RemovePlayer(string name)
        {
            int couter = 0;
            for (int i = 0; i < players.Count; i++)
            {

                if (players[i].Name == name)
                {
                    couter++;
                    count--;
                    players.Remove(players[i]);
                    OpenPosition++;
                   
                }
            }
            if (couter>0)
            {
                return true;
            }
            
            return false;
        }

        public int RemovePlayerByPosition(string position)
        {
            int counter = 0;

            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Position==position)
                {
                    counter++;
                    count--;
                    OpenPosition++;
                    players.Remove(players[i]);
                }

                

            }
            if (counter>0)
            {
                return counter;
            }
            return 0;
        }

        public Player RetirePlayer(string name)
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Name == name)
                {
                    
                    players[i].Retired = true;
                    return players[i];
                }
            }
            return null;
        }

        public List<Player> AwardPlayers(int games)
        {
            List<Player> result = new List<Player>();
            for (int i = 0; i < players.Count; i++)
            {

            
                if (players[i].Games >= games)
                {
                    result.Add(players[i]);
                }
            }
            return result;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Active players competing for Team {this.Name} from Group {this.Group}:");
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Retired == false)
                {



                    sb.AppendLine(players[i].ToString());
                }
            }
            return sb.ToString().TrimEnd();
        }

    }
}
