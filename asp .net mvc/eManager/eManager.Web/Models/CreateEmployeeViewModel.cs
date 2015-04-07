namespace eManager.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class CreateEmployeeViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Department { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

    }
}