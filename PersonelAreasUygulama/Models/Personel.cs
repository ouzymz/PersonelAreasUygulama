namespace PersonelAreasUygulama.Models
{
    public class Personel
    {
        public int PersonelId { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Email { get; set; }

        public DateTime DogumGunu { get; set; }

        public decimal Maas { get; set; }
    }
}
