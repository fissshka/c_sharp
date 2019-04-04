using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWPFTask
{
   public class Student
    {
            public string Name { get; set; }​

            public double Rate { get; set; }​

            public static ObservableCollection<Student> GetStudents()​

            {​

                ObservableCollection<Student> result = new ObservableCollection<Student>();​

                result.Add(new Student() { Name = "Andy Houp", Rate = 70 });​

                result.Add(new Student() { Name = "Mary First", Rate = 64});​

                result.Add(new Student() { Name = "John Miller", Rate = 30 });​

                result.Add(new Student() { Name = "Helen Best", Rate = 0 });​

                result.Add(new Student() { Name = "Ivan Stown", Rate = 29 });​

                result.Add(new Student() { Name = "Mishel Capoa", Rate = 91 });​

                return result;​

            }​
    }
}
