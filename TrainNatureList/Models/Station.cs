using Microsoft.EntityFrameworkCore;

namespace TrainNatureList.Models
{
    [Index("Name")]
    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
