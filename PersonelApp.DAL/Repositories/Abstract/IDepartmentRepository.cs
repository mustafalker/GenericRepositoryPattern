﻿using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DAL.Repositories.Abstract
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        IEnumerable<Department> GetTopDepartment(int count);
        IEnumerable<Department> GetDepartmentsWithPersonels();
    }
}
