namespace Praktika_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* List<Student> students = new List<Student>
            {
                new Student{Name= "Alice",Age=22,AverageGrade=8.5},
                new Student{Name= "Bob",Age=20,AverageGrade=6.3},
                new Student{Name= "Mike",Age=23,AverageGrade=7.8},
                new Student{Name= "Peter",Age=18,AverageGrade=9.7},
            };

            var studntsOver20 = students.Where(s => s.Age > 20).OrderByDescending(s => s.AverageGrade);
            foreach (var student in studntsOver20) 
            {
                Console.WriteLine($"{student.Name}: Age: {student.Age}, Average Grade {student.AverageGrade}");            
            }

            Console.WriteLine("\n\n");

            var hight = students.OrderByDescending(s => s.AverageGrade).First();
            Console.WriteLine($"{hight.Name}: Age: {hight.Age}, Average Grade {hight.AverageGrade}");

            Console.WriteLine("\n\n");

            var averageAge = students.Average(s => s.Age);
            Console.WriteLine($"Средний возраст {averageAge}");

            Console.WriteLine("\n\n");

            Console.WriteLine("Количество студентов " + students.Count);

            Console.WriteLine("\n\n");

            var hightAge = students.OrderByDescending(s => s.Age).First();
            Console.WriteLine(hightAge.Name);

            Console.WriteLine("\n\n");

            var studntsOver = students.Where(s => s.Age > 20 && s.AverageGrade>4.5);
            foreach (var student in studntsOver)
            {
                Console.WriteLine($"{student.Name}: Age: {student.Age}, Average Grade {student.AverageGrade}");
            }

            Console.WriteLine("\n\n");

            var studentHight = students.OrderByDescending(s => s.AverageGrade);
            foreach(var student in studentHight)
            {
                Console.WriteLine($"{student.Name}: Age: {student.Age}, Average Grade {student.AverageGrade}");
            }
           */

           /* BookStore<IBook> bookStore = new BookStore<IBook>();

            var book1 = new Book1
            {
                Title = "Book1",
                Autor = "Autor1",
                Genre = "Fiction",
                Price = 19.99,
                PublicationYear = 2020
            };

            var book2 = new Book2
            {
                Title = "Book2",
                Autor = "Autor2",
                Genre = "Non - Fiction",
                Price = 29.99,
                PublicationYear = 2018
            };
            bookStore.AddBook(book1);
            bookStore.AddBook(book2);

            var booksByAutor = bookStore.FindBookByAutor("Autor1");
            var booksByGenre = bookStore.FindBookByGenre("Fiction");

            Console.WriteLine("Books by Autor");
            foreach( var book in booksByAutor)
            {
                Console.WriteLine($"{book.Title} by {book.Autor}");
            }

            Console.WriteLine("\nBooks by Genre");
            foreach (var book in booksByGenre)
            {
                Console.WriteLine($"{book.Title} by {book.Genre}");
            }

            var sortedBooks = bookStore.GetBooksSortedBy(b => b.Price);
            Console.WriteLine("\nBooks sorted by Price");
            foreach(var book in sortedBooks)
            {
                Console.WriteLine($"{book.Title} - {book.Price}");
            }

            Console.WriteLine($"\nTotal price of all books {bookStore.CalculateOfPrice()}");

            var mostExpensiveBook = bookStore.GetMostExpensiveBook();
            Console.WriteLine($"\nMost expensive book: {mostExpensiveBook.Title} - {mostExpensiveBook.Price}");*/

           StudentCollection <IStudent> studentCollection1 = new StudentCollection<IStudent>();

           Student1 student1 = new Student1 
           { 
               Name = "Petya",
               Age = 19,
               Major = "Mechanic"
           };

            Student1 student2 = new Student1
            {
                Name = "Kolya",
                Age = 22,
                Major = "DJ"
            };

            Student1 student3 = new Student1
            {
                Name = "Vasya",
                Age = 20,
                Major = "Hacker"
            };

            studentCollection1.Add(student1);
            studentCollection1.Add(student2);
            studentCollection1.Add(student3);

            studentCollection1.PrintForAll();

            Console.WriteLine("\n\n");

            var studentByMajor = studentCollection1.FindForMajor("DJ");
            foreach(var student in studentByMajor)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine("\n\n");

            var stubentOld = studentCollection1.OldAge();
            Console.WriteLine(stubentOld.Name);

            Console.WriteLine("\n\n");

            var studentYoung = studentCollection1.YoungAge();
            Console.WriteLine(studentYoung.Name);

            Console.WriteLine("\n\n");

            var sortedOfAge = studentCollection1.SortAge();
            foreach(var student in sortedOfAge)
            {
                Console.WriteLine($"{student.Name}, {student.Age}");
            }




        }
    }
}
