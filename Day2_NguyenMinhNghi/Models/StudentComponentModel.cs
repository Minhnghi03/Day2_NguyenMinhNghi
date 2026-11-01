namespace Day2_NguyenMinhNghi.Models
{
    public class StudentComponentModel
    {
        public int? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int NumTimes { get; set; }
        public DateTime RenderedAt { get; set; }
        public List<string> Items { get; set; } = new();
    }
}
