using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentEmployeeDAL
{
    public interface IDepartmentRepo
    {
        Department AddNewDepartment(Department department);
        List<Department> GetAllDepartments();
    }
}
