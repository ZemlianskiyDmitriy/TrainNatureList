using Microsoft.EntityFrameworkCore;

namespace TrainNatureList.Models
{
    [Index("Number")]
    public class Train
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Index { get; set; }
        public string FullIndex { get; set; } = String.Empty;
        public Station? StationFrom { get; set; } 
        public Station? StationTo { get; set; }
        public List<Freight> Freights { get; set; } = new List<Freight>();
        
    }
}
