using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDLINQ2_407
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DataClasses1DataContext dbContext = new DataClasses1DataContext())
            {
                // CREATE - Insert a new student record
                Console.WriteLine("Insert Student:");
                CreateStudent(dbContext, "Ayush", 21, "Kathmandu");
                CreateStudent(dbContext, "Avishek", 22, "Lalitpur");

                // READ - Select all students
                Console.WriteLine("\nAll Students:");
                ReadStudents(dbContext);

                // UPDATE - Update a student's information
                Console.WriteLine("\nUpdate Student:");
                UpdateStudent(dbContext, 1, "Ayush", 23, "Pokhara");

                // Read after update
                Console.WriteLine("\nStudents after Update:");
                ReadStudents(dbContext);

                // DELETE - Remove a student record
                Console.WriteLine("\nDelete Student:");
                DeleteStudent(dbContext, 2);

                // Read after delete
                Console.WriteLine("\nStudents after Deletion:");
                ReadStudents(dbContext);
            }
        }

        // CREATE: Insert a new student record
        static void CreateStudent(DataClasses1DataContext dbContext, string name, int age, string address)
        {
            Student newStudent = new Student
            {
                Name = name,
                Age = age,
                Address = address
            };

            dbContext.Students.InsertOnSubmit(newStudent);
            dbContext.SubmitChanges();
            Console.WriteLine($"Student {name} inserted successfully.");
        }

        // READ: Select all students
        static void ReadStudents(DataClasses1DataContext dbContext)
        {
            var students = from student in dbContext.Students
                           select student;

            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Address: {student.Address}");
            }
        }

        // UPDATE: Update an existing student's information
        static void UpdateStudent(DataClasses1DataContext dbContext, int id, string name, int age, string address)
        {
            var studentToUpdate = dbContext.Students.SingleOrDefault(s => s.Id == id);

            if (studentToUpdate != null)
            {
                studentToUpdate.Name = name;
                studentToUpdate.Age = age;
                studentToUpdate.Address = address;

                dbContext.SubmitChanges();
                Console.WriteLine($"Student with Id {id} updated successfully.");
            }
            else
            {
                Console.WriteLine($"Student with Id {id} not found.");
            }
        }

        // DELETE: Delete a student record
        static void DeleteStudent(DataClasses1DataContext dbContext, int id)
        {
            var studentToDelete = dbContext.Students.SingleOrDefault(s => s.Id == id);

            if (studentToDelete != null)
            {
                dbContext.Students.DeleteOnSubmit(studentToDelete);
                dbContext.SubmitChanges();
                Console.WriteLine($"Student with Id {id} deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Student with Id {id} not found.");
            }
            Console.ReadLine();
        }
    }
}
