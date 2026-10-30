namespace Data_Transfer_Stonehocker.Models
{
    public class Filters
    {
        public Filters(string? filterstring)
        {
            FilterString = filterstring ?? "all-all";
            string[] parts = FilterString.Split('-');
            Category = parts[0];
            Type = parts.Length > 1 ? parts[1] : "all";
        }

        public string FilterString { get; }
        public string Category { get; }
        public string Type { get; }

        public bool HasCategory => Category.ToLower() != "all";
        public bool HasType => Type.ToLower() != "all";

        public string With(string? category = null, string? type = null) =>
            $"{category ?? Category}-{type ?? Type}";
    }
}
