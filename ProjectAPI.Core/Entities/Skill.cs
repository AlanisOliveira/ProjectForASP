using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Core.Entities
{
    public class Skill : BaseEntity
    {
        //Construtor para inicializar os atributos da classe
        public Skill(string description)
        {
            Description = description;
            CreatedAt = DateTime.Now;
        }
        public string Description { get; private set; } 
        //O private vai ajudar no acesso de escrita da propriedade, ou seja, só será possível alterar o valor da propriedade dentro da classe
        public DateTime CreatedAt { get; private set; }
    }
}