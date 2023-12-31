﻿using System.Collections.Generic;

namespace FirstCoreApp.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);

        List<Employee> GetAll();
        Employee Add(Employee employee);

    }
}
