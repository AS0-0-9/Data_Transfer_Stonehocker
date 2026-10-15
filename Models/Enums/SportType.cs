using System.ComponentModel.DataAnnotations;

namespace Data_Transfer_Stonehocker.Models.Enums
{
    public enum SportType
    {
        Curling,
        
        Bobsleigh,

        Diving,

        [Display(Name = "Road Cycling")]
        RoadCycling,
        
        Cycling,
        
        Archery,
        
        [Display(Name = "Canoe Sprint")]
        CanoeSprint,
        
        Breakdancing,
                Skateboarding
    }
}
