using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentEmployeeDAL
{
    public class DepartmentRepo : IDepartmentRepo
    {
        DepartmentEmployeeDbContext context=null;
        public DepartmentRepo(DepartmentEmployeeDbContext context1)
        {
            context=context1;
        }
        public Department AddNewDepartment(Department department)
        {
           context.Departments.Add(department);
            context.SaveChanges();
            return department;
        }

        public List<Department> GetAllDepartments()
        {
            return context.Departments.ToList();
        }
    }
}
