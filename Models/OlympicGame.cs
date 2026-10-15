using Data_Transfer_Stonehocker.Models.Enums;

namespace Data_Transfer_Stonehocker.Models
{
    public class OlympicGame
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }
        public OlympicType TypeOfGame { get; set; }
        public SportType Sport { get; set; }
        public IndoorOutdoor IndoorOrOutdoor { get; set; }

    }
}
