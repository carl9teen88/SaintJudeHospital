using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class Parent
    {
        public Parent()
        {
        }

        public Parent(int age, string firstName, string lastName, string middleName, string occupation)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Occupation = occupation;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { set; get; }
        public int Age { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string MiddleName { set; get; }
        public string Occupation { set; get; }
    }
}
