namespace OnlineBerberRandevuSistemi.Models
{
    public class Service
    {
        public int Id { get; set; }
        public int BarberId { get; set; }
        public string ServiceName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Duration { get; set; } // in minutes
    }
}