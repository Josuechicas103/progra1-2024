using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joelcampos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;

namespace CRUDApp
    {
        class Program
        {
            static List<Student> students = new List<Student>();

            static void Main(string[] args)
            {
                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("Seleccione una opción:");
                    Console.WriteLine("1. Crear estudiante");
                    Console.WriteLine("2. Leer estudiantes");
                    Console.WriteLine("3. Actualizar estudiante");
                    Console.WriteLine("4. Eliminar estudiante");
                    Console.WriteLine("5. Salir");
                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            CreateStudent();
                            break;
                        case "2":
                            ReadStudents();
                            break;
                        case "3":
                            UpdateStudent();
                            break;
                        case "4":
                            DeleteStudent();
                            break;
                        case "5":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
            }

            static void CreateStudent()
            {
                Console.WriteLine("Ingrese el nombre del estudiante:");
                string name = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del estudiante:");
                int age = int.Parse(Console.ReadLine());

                Student student = new Student { Id = Guid.NewGuid(), Name = name, Age = age };
                students.Add(student);
                Console.WriteLine("Estudiante creado exitosamente.");
            }

            static void ReadStudents()
            {
                Console.WriteLine("Lista de estudiantes:");
                foreach (var student in students)
                {
                    Console.WriteLine($"ID: {student.Id}, Nombre: {student.Name}, Edad: {student.Age}");
                }
            }

            static void UpdateStudent()
            {
                Console.WriteLine("Ingrese el ID del estudiante a actualizar:");
                Guid id = Guid.Parse(Console.ReadLine());
                var student = students.Find(s => s.Id == id);

                if (student != null)
                {
                    Console.WriteLine("Ingrese el nuevo nombre del estudiante:");
                    student.Name = Console.ReadLine();
                    Console.WriteLine("Ingrese la nueva edad del estudiante:");
                    student.Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Estudiante actualizado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Estudiante no encontrado.");
                }
            }

            static void DeleteStudent()
            {
                Console.WriteLine("Ingrese el ID del estudiante a eliminar:");
                Guid id = Guid.Parse(Console.ReadLine());
                var student = students.Find(s => s.Id == id);

                if (student != null)
                {
                    students.Remove(student);
                    Console.WriteLine("Estudiante eliminado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Estudiante no encontrado.");
                }
            }
        }

        class Student
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }

}
    }
}
