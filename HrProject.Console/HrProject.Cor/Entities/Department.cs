﻿using HrProject.Cor.Interfaces;

namespace HrProject.Cor.Entities;

public class Department : IEntity<int>

{
    public int Id {  get; }
    public string Name { get; set; } = null!;

    private static int _id;

    public Department(string name)
    {
        Id = _id;
        Name = name;
    }

}
