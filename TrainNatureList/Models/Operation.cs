namespace TrainNatureList.Models
{
    public class Operation
    {
        public int Id { get; set; }
        public OperationDirectory? LastOperation { get; set; } 
        public DateTime OperationDate { get; set; }
        public Station? LastStation { get; set; }

    }
}
