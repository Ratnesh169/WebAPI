using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    public class City_Master
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }
    }
}
