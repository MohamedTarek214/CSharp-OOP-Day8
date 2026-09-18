using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    public class Student 
    {
        #region Propertes
        public int Id { get; set; }
        public string Name { get; set; }
        public char Grade { get; set; }
        #endregion

        #region Constructor
        public Student(Student std)
        {
            this.Id = std.Id;
            this.Name = std.Name;
            this.Grade = std.Grade;
        }
        public Student()
        {

        } 
        #endregion


        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Grade = {Grade}";
        }
    }
}
