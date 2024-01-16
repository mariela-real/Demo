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
        public int Id { get; set; }
        public Role Role { get; set; }
        public Person? Person { get; set; }
        public ICollection<Task> Tasks { get; set; } = new List<Task>();
        
        public User() { }
       
        public User(int id, Role role, Person person, List<Task> tasks) 
        {
            Id = id;
            Role = role;
            Person = person;
            Tasks = tasks;
        }
    }
}
