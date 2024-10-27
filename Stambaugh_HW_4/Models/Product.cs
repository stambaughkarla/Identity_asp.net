using System.ComponentModel.DataAnnotations;

namespace Stambaugh_HW_4.Models


{   
    public enum ProductType {Hot, Cold, Packaged , Drink, Other}
    public class Product
    {

        public int ProductID { get; set; }

        [Display(Name = "What is the Name:")]
        public string Name { get; set; }

        [Display(Name = "What is the desciption")]
        public string Description { get; set; }


        [Display(Name = "What is the Price?")]
        public int Price { get; set; }

        [Display(Name= "What is the Product Type")]
        public ProductType ProductTypeSelection { get; set; }


    }
}
