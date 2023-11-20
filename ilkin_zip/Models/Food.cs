namespace ilkin_zip.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingridient { get; set; }
        public string ImageUrl { get; set; }
        public int İmageId { get; set; }
        public List<Image> İmages { get; set; }
    }
}
