using System;
using System.Text;

namespace Basketball
{
    public class Player
    {
        private string name;
        private string position;
        private double rating;
        private int games;
        private bool retired;

        public Player(string name, string position, double rating, int games)
        {
            Name = name;
            Position = position;
            Rating = rating;
            Games = games;
        }

        public string Name { get; set; }
        public string Position { get; set; }
        public double Rating { get; set; }
        public int Games { get; set; }
        public bool Retired { get; set; }
        public override string ToString()
        {
            //            "-Player: {name}
            //--Position: { position}
            //            --Rating: { rating}
            //            --Games played: { games}
            //            "
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"-Player: {this.Name}");
            sb.AppendLine($"--Position: {this.Position}");
            sb.AppendLine($" --Rating: {this.Rating}");
            sb.AppendLine($" --Games played: {this.Games}");

            return sb.ToString().TrimEnd();
        }
    }
}
