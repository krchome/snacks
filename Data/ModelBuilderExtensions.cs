using Snacks.Models;
using Microsoft.EntityFrameworkCore;
namespace Snacks.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder){
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Almond Cake",
                    Description = "A scrumptious almond cake encrusted with sliced almonds",
                    Price = 8.99m,
                    ImageName = "Almond_Cake.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Gobhi Curry",
                    Description = "A delicious curry of potato and cauliflower with Indian spices",
                    Price = 9.99m,
                    ImageName = "Alu-Gobhi_Curry.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Fish Cutlet",
                    Description = "Delectable savoury cutlet made from fish",
                    Price = 5.99m,
                    ImageName = "Fish_Cutlet.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Lamb Chhole",
                    Description = "Chickpeas made into delicious snack with lamb mutton",
                    Price = 1.49m,
                    ImageName = "Mutton_Chholay.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name = "Rasgulla",
                    Description = "A delectable fresh cheese dumpling embedded in Sugar Syrup",
                    Price = 5.99m,
                    ImageName = "Rasgulla.jpg"
                },
                new Product
                {
                    Id = 6,
                    Name = "Sambhar Vada",
                    Description = "Fried Besan Coated Lentil Fritters",
                    Price = 8.99m,
                    ImageName = "Sambhar_Vada.jpg"
                }
            );
            return modelBuilder;
        }
    }
}