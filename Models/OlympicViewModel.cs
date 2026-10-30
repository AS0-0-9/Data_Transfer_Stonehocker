namespace Data_Transfer_Stonehocker.Models
{
    public class OlympicViewModel
    {
        public string Filter { get; set; } = "all-all";         
        public Filters Filters => new Filters(Filter);         
        public List<OlympicGame> Games { get; set; } = new();
    }
}
