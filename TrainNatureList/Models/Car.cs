namespace TrainNatureList.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int CarNumber { get; set; }
        public string InvoceNum { get; set; } = string.Empty;
        public Freight? Freight { get; set; }
        public decimal Weight { get; set; }
        public int Position { get; set; }
    }
}
