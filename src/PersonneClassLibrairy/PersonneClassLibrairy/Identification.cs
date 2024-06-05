namespace PersonneClassLibrairy
{
    public class Identification
    {
        public string ID { get; set; }= Guid.NewGuid().ToString();
        public string? Name { get; set; }
        public DateOnly  ExpireOn { get; set; }
        public string? Note { get; set; }
    }
}
