using Microsoft.EntityFrameworkCore;

namespace TrainNatureList.Models
{
    [Index("Name")]
    public class OperationDirectory
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
