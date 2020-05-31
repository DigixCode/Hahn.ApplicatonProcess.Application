using Hahn.ApplicatonProcess.May2020.Data.Models;
using Hahn.ApplicatonProcess.May2020.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.May2020.Domain.Repositories
{
    public class PersonRepository :GenericRepository<Data.Models.Person>, IPersonRepository
    {
        public PersonRepository(DbContext context)
            :base(context)
        {
        }
    }
}
