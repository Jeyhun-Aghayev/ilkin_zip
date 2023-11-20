namespace ilkin_zip.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int FoodId { get; set; }
        public List<Food> food { get; set; }
    }
}
