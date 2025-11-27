using Mesclasse;

namespace EmployeeWeb.Models.Repositories
{
    public interface IDepartmentRepository
    {

        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int departmentId);

    }
}
