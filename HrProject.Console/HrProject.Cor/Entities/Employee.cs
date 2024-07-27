using HrProject.Cor.Interfaces;

namespace HrProject.Cor.Entities;

public class Employee : IEntity<Guid>
{
    public Guid Id {  get; }
    public string Name { get; set; } = null!;
    public string? LastName { get; set; }
    public int? DepartmnetId { get; set; }
    public int? PositionId { get; set; }

    public Employee( string name, int departmentid, int positionid, string? lastname=null)
    {
        Name = name;
        LastName = lastname;
        DepartmnetId = departmentid;
        PositionId = positionid;
        Id = new Guid();

    }

}
