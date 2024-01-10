using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Role Role { get; set; }
        public ICollection<Task> Tasks { get; set; } = new List<Task>();       
    }
}
