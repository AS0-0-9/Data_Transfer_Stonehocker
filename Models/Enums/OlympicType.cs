using System.ComponentModel.DataAnnotations;

namespace Data_Transfer_Stonehocker.Models.Enums
{
    public enum OlympicType
    {
        Summer,
        
        Winter,
        
        Paralympics,
        
        [Display(Name = "Youth Olympic Games")]
        YouthOlympic
    }
}
