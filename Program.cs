using System;
using System.Threading.Tasks;

namespace Demo
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
          
                /*int[] array2 = [0];
                int[] newArray = new int[array2.Length];
                for (int i = 0; array2.Length > i; i++)
                {
                    newArray[i] = array2[array2.Length - 1 - i];
                }*/
           
            TestArray investedArray = new TestArray();
            int[] newArray = investedArray.InvestedArray([1, 2, 3, 4]);

            Console.Write("[");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i]);
                if (i < newArray.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
            /*
            List<Task> tasks = new List<Task>()
            {
                new Task(1, 2, "pending", "Hacer la primera hu para la truchita"),
                new Task(2, 3, "Completed", "end"),
            };

            Person person_1 = new Person
            {
                Id = 1,
                Name = "Ruben",
                Age = 23,
                Location = "Av. 123",
            };
          
            var user_1 = new User
            {
                Id = 1,
                Person = person_1,
                Role = Role.Admin,
                Tasks = tasks,
            };
           
            PrintUser(user_1);
        }
        public static void PrintUser(User userEntity)
        {
            UserDTO userDTO = new UserDTO
            {
                Id = userEntity.Id,
                Name = userEntity.Person!.Name,
                Role = userEntity.Role,
                Tasks = userEntity.Tasks
            };

            Console.WriteLine(
                $"ID: {userDTO.Id} \n" +
                $"Nombre: {userDTO.Name} \n" +
                $"Rol: {userDTO.Role} \n" 
      
            );

            foreach (var task in userDTO.Tasks)
            {
                Console.WriteLine($"Tarea ID: {task.Id} \n" +
                    $"Hora: {task.Estimation} \n" +
                    $"Estado actual: {task.ActualState} \n" +
                    $"descripcion: {task.Description} \n"
                );
            }*/
        }

    }

}