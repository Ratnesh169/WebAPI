using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    public class Salary_Master
    {
        [Key]
        public int SalId { get; set; }
        public decimal StartingAmount { get; set; }
        public decimal EndAmount { get; set; }
        public string Designation { get; set; }
    }
}
