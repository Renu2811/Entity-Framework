using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails.Entities
{
    public class EmployeeOrganization
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]

        public int ID { get; set; }
        [Column(TypeName = "Varchar(50)")]
        public string? Name { get; set; }
        public string? Location { get; set; }

        public Employee Employee { get; set; }
    }
}

    

