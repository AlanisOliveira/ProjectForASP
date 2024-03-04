using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Core.Entities
{
    //Classe base para todas as entidades, com objetivo de ser utilizada por todas as entidades
    public abstract class BaseEntity
    {
        
        public int Id { get; set; }
    }
}