using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_C_
{
    public class StudentCollection<T> where T: IStudent
    {
        public List<T> students = new List<T>();

        public void Add (T student)
        {
            students.Add(student);
        }

        public void Remove(T student)
        {
            students.Remove(student);
        }

        public void PrintForAll()
        {
            foreach (T student in students)
            {
                Console.WriteLine($"{student.Name}, возраст: {student.Age}, специальность {student.Major}");
            }
        }

        public IEnumerable<T> FindForMajor(string major)
        {
            return students.Where(x => x.Major == major);
        }

        public T OldAge()
        {
            return students.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public T YoungAge()
        {
            return students.OrderBy(x => x.Age).FirstOrDefault();
        }

        public IEnumerable<T> SortAge()
        {
            return students.OrderByDescending(x => x.Age);
        }

    }
}
