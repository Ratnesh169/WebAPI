using System.ComponentModel.DataAnnotations;
namespace WebAPI.Model
{
    public class Emp_Master
    {
        [Key]
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public int CityID { get; set; }
        public DateTime JoiningDate { get; set; }
        public decimal salary { get; set; }
    }
}
