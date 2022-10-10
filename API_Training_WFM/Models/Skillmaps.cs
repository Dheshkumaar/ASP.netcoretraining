namespace API_Training_WFM.Models
{
    public class Skillmaps
    {
        public int employee_id { get; set; }
        public Employees employees { get; set; }
        public int skillid { get; set; }
        public Skills skills { get; set; }
    }
}
