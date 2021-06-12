using System.ComponentModel.DataAnnotations;
namespace Lab3.Models
{
    public class Person
    {
        [Required]
        public string FirstName
        {
            get;
            set;
        }

        [Required]
        public string LastName
        {
            get;
            set;
        }

        [Required]
        public int Age
        {
            get;
            set;
        }

        [Required]
        [EmailAddress]
        public string EmailAddress
        {
            get; 
            set;
        }

        [Required]
        [DataType(DataType.Date)]
        public string Date

        {
            get;
            set;
        }

        [Required]
        public string Password
        {
            get;
            set;
        }

        [Required]
        public string Description
        {
            get; 
            set;
        }

        [Required]
        public int Bottle
        {
            get; 
            set;
        }

    }
}

