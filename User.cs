using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo
{
    public class User
    {
      
        public string Id { get; set; }
   
        public string Name { get; set; }
    
        public List<Task> Tasks { get; set; } = new List<Task>();

        public User(string id, string name, List<Task> tasks) 
        {
            Id = id;
            Name = name;
            Tasks = tasks;
        }
        public User() { }
        public override string ToString()
        {
            return "Usuario: " + Id + " " + Name ;
        }

    }
}
