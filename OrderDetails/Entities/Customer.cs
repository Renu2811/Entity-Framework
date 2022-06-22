using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace OrderDetails.Entities
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        [Key]
        public int ID { get; set; }

        public string FirstNAme { get; set; }

        public string? LastName { get; set; }


        public int Phone { get; set; }

        public int Email { get; set; }

        public ICollection<Customer>? customer { get; set; }


    }
}
