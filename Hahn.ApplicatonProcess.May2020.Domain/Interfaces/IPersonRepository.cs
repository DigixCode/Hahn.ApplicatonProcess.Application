﻿using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.May2020.Domain.Interfaces
{
    public interface IPersonRepository: IGenericRepository<Data.Models.Person>
    {
        
    }
}
