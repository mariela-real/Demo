using System;

namespace Demo 
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Task> task = new List<Task>()
            {
                new Task("1", 2, "pending", "Hacer la primera hu para la truchita"),
            };
           // var task = new List<Task> { new Task("1", 2, "pending", "Hacer la primera hu para la truchita"), };
            var result = new User
            {
                Id = "1",
                Name = "Mariela",
                Tasks = task,
            };
           // Console.WriteLine(result );
            PrintUser(result);
        }
        public static void PrintUser(User persona)
        {
            Console.WriteLine(
                $"Persona ID: {persona.Id}" +
                $"Nombre: {persona.Name}"
            );

            foreach (var tarea in persona.Tasks)
            {
                Console.WriteLine($"Tarea ID: {tarea.Id}" +
                     $"Hora: {tarea.TimeEstimatedTime}" +
                     $"Estado actual: {tarea.ActualState}" +
                    $"descripcion: {tarea.Description}"
                   
                    );
            }
        }

    }

}