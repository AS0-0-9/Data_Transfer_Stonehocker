using Data_Transfer_Stonehocker.Models.Enums;

namespace Data_Transfer_Stonehocker.Models
{
    public class GameService
    {
        private readonly List<OlympicGame> _games = new List<OlympicGame>
        {
            new() { Id = 1,  Country = "Canada",        Code = "ca", TypeOfGame = OlympicType.Winter,       Sport = SportType.Curling,       IndoorOrOutdoor = IndoorOutdoor.Indoor },
            new() { Id = 2,  Country = "Sweden",        Code = "se", TypeOfGame = OlympicType.Winter,       Sport = SportType.Curling,       IndoorOrOutdoor = IndoorOutdoor.Indoor },
            new() { Id = 3,  Country = "Great Britain", Code = "gb", TypeOfGame = OlympicType.Winter,       Sport = SportType.Curling,       IndoorOrOutdoor = IndoorOutdoor.Indoor },
            new() { Id = 4,  Country = "Jamaica",       Code = "jm", TypeOfGame = OlympicType.Winter,       Sport = SportType.Bobsleigh,     IndoorOrOutdoor = IndoorOutdoor.Outdoor },
            new() { Id = 5,  Country = "Italy",         Code = "it", TypeOfGame = OlympicType.Winter,       Sport = SportType.Bobsleigh,     IndoorOrOutdoor = IndoorOutdoor.Outdoor },
            new() { Id = 6,  Country = "Japan",         Code = "jp", TypeOfGame = OlympicType.Winter,       Sport = SportType.Bobsleigh,     IndoorOrOutdoor = IndoorOutdoor.Outdoor },
            new() { Id = 7,  Country = "Germany",       Code = "de", TypeOfGame = OlympicType.Summer,       Sport = SportType.Diving,        IndoorOrOutdoor = IndoorOutdoor.Indoor },
            new() { Id = 8,  Country = "China",         Code = "cn", TypeOfGame = OlympicType.Summer,       Sport = SportType.Diving,        IndoorOrOutdoor = IndoorOutdoor.Indoor },
            new() { Id = 9,  Country = "Mexico",        Code = "mx", TypeOfGame = OlympicType.Summer,       Sport = SportType.Diving,        IndoorOrOutdoor = IndoorOutdoor.Indoor },
            new() { Id = 10, Country = "Brazil",        Code = "br", TypeOfGame = OlympicType.Summer,       Sport = SportType.RoadCycling,   IndoorOrOutdoor = IndoorOutdoor.Outdoor },
            new() { Id = 11, Country = "Netherlands",   Code = "nl", TypeOfGame = OlympicType.Summer,       Sport = SportType.Cycling,       IndoorOrOutdoor = IndoorOutdoor.Outdoor },
            new() { Id = 12, Country = "USA",           Code = "us", TypeOfGame = OlympicType.Summer,       Sport = SportType.RoadCycling,   IndoorOrOutdoor = IndoorOutdoor.Outdoor },
            new() { Id = 13, Country = "Thailand",      Code = "th", TypeOfGame = OlympicType.Paralympics,  Sport = SportType.Archery,       IndoorOrOutdoor = IndoorOutdoor.Indoor },
            new() { Id = 14, Country = "Uruguay",       Code = "uy", TypeOfGame = OlympicType.Paralympics,  Sport = SportType.Archery,       IndoorOrOutdoor = IndoorOutdoor.Indoor },
            new() { Id = 15, Country = "Ukraine",       Code = "ua", TypeOfGame = OlympicType.Paralympics,  Sport = SportType.Archery,       IndoorOrOutdoor = IndoorOutdoor.Indoor },
            new() { Id = 16, Country = "Austria",       Code = "at", TypeOfGame = OlympicType.Paralympics,  Sport = SportType.CanoeSprint,   IndoorOrOutdoor = IndoorOutdoor.Outdoor },
            new() { Id = 17, Country = "Pakistan",      Code = "pk", TypeOfGame = OlympicType.Paralympics,  Sport = SportType.CanoeSprint,   IndoorOrOutdoor = IndoorOutdoor.Outdoor },
            new() { Id = 18, Country = "Zimbabwe",      Code = "zw", TypeOfGame = OlympicType.Paralympics,  Sport = SportType.CanoeSprint,   IndoorOrOutdoor = IndoorOutdoor.Outdoor },
            new() { Id = 19, Country = "France",        Code = "fr", TypeOfGame = OlympicType.YouthOlympic, Sport = SportType.Breakdancing,  IndoorOrOutdoor = IndoorOutdoor.Indoor },
            new() { Id = 20, Country = "Cyprus",        Code = "cy", TypeOfGame = OlympicType.YouthOlympic, Sport = SportType.Breakdancing,  IndoorOrOutdoor = IndoorOutdoor.Indoor },
            new() { Id = 21, Country = "Russia",        Code = "ru", TypeOfGame = OlympicType.YouthOlympic, Sport = SportType.Breakdancing,  IndoorOrOutdoor = IndoorOutdoor.Indoor },
            new() { Id = 22, Country = "Finland",       Code = "fi", TypeOfGame = OlympicType.YouthOlympic, Sport = SportType.Skateboarding, IndoorOrOutdoor = IndoorOutdoor.Outdoor },
            new() { Id = 23, Country = "Slovakia",      Code = "sk", TypeOfGame = OlympicType.YouthOlympic, Sport = SportType.Skateboarding, IndoorOrOutdoor = IndoorOutdoor.Outdoor },
            new() { Id = 24, Country = "Portugal",      Code = "pt", TypeOfGame = OlympicType.YouthOlympic, Sport = SportType.Skateboarding, IndoorOrOutdoor = IndoorOutdoor.Outdoor },
        };
    

        public List<OlympicGame> GetAll() => _games;
    }
}
