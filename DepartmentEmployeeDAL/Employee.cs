using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentEmployeeDAL
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="Enter the Name")]
        [StringLength(30,ErrorMessage ="Name should not exceed more then 30 chars")]
        public string Name { get; set; }
        public string Gender { get; set; }

        [DataType(DataType.Currency)]
        public int Salary { get; set; }
        [ForeignKey("DeptId")]
        public int DeptId { get; set; }

        public virtual Department Department { get; set; }
    }
}
