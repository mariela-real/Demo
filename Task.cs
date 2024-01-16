using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo
{
    public class Task
    {
        public int Id { get; set; }
        public int Estimation { get; set; }
        public string ActualState { get; set; }
        public string Description { get; set; }
   
        public Task(int id, int estimation, string actualState, string description) 
        {
            Id = id;
            Estimation = estimation;
            ActualState = actualState;
            Description = description;
        }
    }
}
