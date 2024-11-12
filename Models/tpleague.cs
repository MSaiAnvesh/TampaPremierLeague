using System.ComponentModel.DataAnnotations;

namespace TampaPremierLeague.Models
{
    public class tpleague
    {
        [Key]
        public int Position { get; set; }
        public string TeamName { get; set; }
        public int Played { get; set; }
        public int Won { get; set; }
        public int Lost { get; set; }
        public int NoResult { get; set; }
        public double NetRunRate { get; set; }
        public int Points { get; set; }
        public string RecentForm { get; set; }
    }
}
