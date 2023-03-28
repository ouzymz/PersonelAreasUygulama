namespace PersonelAreasUygulama.Models.ViewModels
{
    public class PersonelVM
    {
        public PersonelVM()
        {
            pList = new List<PersonelDTO>();
        }
        public Personel Personel { get; set; }
        public List<PersonelDTO> pList { get; set; }

    }
}
