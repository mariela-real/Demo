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
        
        public string Id { get; set; }
        
        public int TimeEstimatedTime { get; set; }
        
        public string ActualState { get; set; }
        
        public string Description { get; set; }
   

        public Task(string id, int timeEstimatedTime, string actualState, string description) 
        {
            Id = id;
            TimeEstimatedTime = timeEstimatedTime;
            ActualState = actualState;
            Description = description;
        }

        public override string ToString()
        {

            return "Tareas: " + Id + " " + TimeEstimatedTime + "" + ActualState + "" + Description;
        }
    }
}
