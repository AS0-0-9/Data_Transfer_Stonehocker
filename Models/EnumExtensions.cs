using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Data_Transfer_Stonehocker.Models
{
    public static class EnumExtensions
    {
        public static string DisplayName(this Enum value)
        {
            var member = value.GetType().GetMember(value.ToString()).First();
            return member.GetCustomAttribute<DisplayAttribute>()?.Name ?? value.ToString();
        }
    }
}
