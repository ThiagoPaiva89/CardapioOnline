namespace CardapioOnline.Dto
{
    public class UpdateRequest
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public double? Price { get; set; }
    }
}
