namespace HrProject.Business.Abstract;
public interface IDepartmentService
{
    void Create(string name);
    void Update (int id);
    void Delete (int id);
    List<IDepartment> GetAll();
    IDepartment GetById (int id);
    
}
