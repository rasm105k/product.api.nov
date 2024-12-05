using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace InfinityElectronics.Shared.Models
{
    public class ProductApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("InfinityElectronicsDb");
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CreateCategories(modelBuilder);
            CreateProducts(modelBuilder);
        }

        private void CreateCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new List<Category>()
            {
                new Category
                {
                    Id = "cat-01",
                    Name = "Laptops",
                    Description = "Portable computers for all your computing needs."
                },
                new Category
                {
                    Id = "cat-02",
                    Name = "Smartphones",
                    Description = "Mobile devices to keep you connected."
                },
                new Category
                {
                    Id = "cat-03",
                    Name = "Tablets",
                    Description = "Compact and powerful devices for work and play."
                },
                new Category
                {
                    Id = "cat-04",
                    Name = "Wearables",
                    Description = "Smart devices you can wear, like watches and fitness trackers."
                },
                new Category
                {
                    Id = "cat-05",
                    Name = "Audio",
                    Description = "Devices for listening to music and other audio."
                },
                new Category
                {
                    Id = "cat-06",
                    Name = "Gaming",
                    Description = "Consoles, accessories, and other gaming equipment."
                },
                new Category
                {
                    Id = "cat-07",
                    Name = "Smart Home",
                    Description = "Devices to make your home smart and connected."
                },
                new Category
                {
                    Id = "cat-08",
                    Name = "Televisions",
                    Description = "TVs of various sizes and technologies."
                },
                new Category
                {
                    Id = "cat-09",
                    Name = "Cameras",
                    Description = "Devices for capturing photos and videos."
                },
                new Category
                {
                    Id = "cat-10",
                    Name = "Networking",
                    Description = "Routers, modems, and other networking equipment."
                },
                new Category
                {
                    Id = "cat-11",
                    Name = "E-Readers",
                    Description = "Devices designed for reading digital books."
                },
                new Category
                {
                    Id = "cat-12",
                    Name = "Appliances",
                    Description = "Household appliances with advanced features."
                },
                new Category
                {
                    Id = "cat-13",
                    Name = "Accessories",
                    Description = "Additional equipment for your electronic devices."
                },
                new Category
                {
                    Id = "cat-14",
                    Name = "VR and AR",
                    Description = "Virtual and augmented reality devices."
                },
                new Category
                {
                    Id = "cat-15",
                    Name = "Drones",
                    Description = "Remote-controlled aerial devices."
                },
                new Category
                {
                    Id = "cat-16",
                    Name = "Fitness",
                    Description = "Devices to monitor and improve your health."
                },
                new Category
                {
                    Id = "cat-17",
                    Name = "Transport",
                    Description = "Electric scooters and other personal transportation."
                },
                new Category
                {
                    Id = "cat-18",
                    Name = "Office",
                    Description = "Electronics designed for the office environment."
                },
                new Category
                {
                    Id = "cat-19",
                    Name = "Home Security",
                    Description = "Devices to keep your home secure."
                },
                new Category
                {
                    Id = "cat-20",
                    Name = "Charging",
                    Description = "Devices for charging your electronics."
                },
                new Category
                {
                    Id = "cat-21",
                    Name = "Power & Energy",
                    Description = "Equipment for powering electronic devices."
                },
                new Category
                {
                    Id = "cat-22",
                    Name = "Smart Mirrors",
                    Description = "Mirrors with smart technology."
                },
                new Category
                {
                    Id = "cat-23",
                    Name = "High-Speed Internet",
                    Description = "Devices to ensure fast internet connections."
                },
                new Category
                {
                    Id = "cat-24",
                    Name = "Wearable Tech",
                    Description = "Advanced technology you can wear."
                },
                new Category
                {
                    Id = "cat-25",
                    Name = "Bluetooth Devices",
                    Description = "Various devices that use Bluetooth technology."
                },
                new Category
                {
                    Id = "cat-26",
                    Name = "Health",
                    Description = "Devices focused on health and wellness."
                },
                new Category
                {
                    Id = "cat-27",
                    Name = "Smart Transportation",
                    Description = "Advanced transportation options."
                },
                new Category
                {
                    Id = "cat-28",
                    Name = "Electric Vehicles",
                    Description = "Environmentally-friendly transportation options."
                },
                new Category
                {
                    Id = "cat-29",
                    Name = "Computer Peripherals",
                    Description = "Additional devices for your computer."
                },
                new Category
                {
                    Id = "cat-30",
                    Name = "Virtual Assistants",
                    Description = "Devices with smart assistant technology."
                }
            });
        }
        private void CreateProducts(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(new List<Product>()
            {
                new Product
                {
                    Id = "el-01",
                    Name = "UltraThin Laptop",
                    Price = 999.99m,
                    Description = "A sleek and powerful laptop for all your computing needs.",
                    Category = "cat-01",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-02",
                    Name = "Smart Watch Pro",
                    Price = 199.99m,
                    Description = "Stay connected on the go with this smart watch.",
                    Category = "cat-04",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-03",
                    Name = "Noise Cancelling Headphones",
                    Price = 149.99m,
                    Description = "Experience music without distractions.",
                    Category = "cat-05",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-04",
                    Name = "4K UHD Television",
                    Price = 799.99m,
                    Description = "Enjoy your favorite shows in stunning 4K resolution.",
                    Category = "cat-08",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-05",
                    Name = "Smartphone XL",
                    Price = 899.99m,
                    Description = "A high-performance smartphone with a large display.",
                    Category = "cat-02",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-06",
                    Name = "Bluetooth Speaker",
                    Price = 49.99m,
                    Description = "Portable speaker with great sound quality.",
                    Category = "cat-05",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-07",
                    Name = "Tablet Pro",
                    Price = 599.99m,
                    Description = "A powerful tablet for work and play.",
                    Category = "cat-03",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-08",
                    Name = "Gaming Console X",
                    Price = 499.99m,
                    Description = "Next-gen gaming experience.",
                    Category = "cat-06",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-09",
                    Name = "Wireless Earbuds",
                    Price = 99.99m,
                    Description = "Convenient and compact wireless earbuds.",
                    Category = "cat-05",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-10",
                    Name = "Smart Home Hub",
                    Price = 129.99m,
                    Description = "Control all your smart home devices with ease.",
                    Category = "cat-07",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-11",
                    Name = "Digital Camera",
                    Price = 549.99m,
                    Description = "Capture stunning photos and videos.",
                    Category = "cat-09",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-12",
                    Name = "E-Reader",
                    Price = 129.99m,
                    Description = "Read your favorite books anywhere.",
                    Category = "cat-11",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-13",
                    Name = "Fitness Tracker",
                    Price = 79.99m,
                    Description = "Monitor your health and activities.",
                    Category = "cat-04",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-14",
                    Name = "VR Headset",
                    Price = 299.99m,
                    Description = "Immerse yourself in virtual reality.",
                    Category = "cat-06",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-15",
                    Name = "Smart Light Bulbs",
                    Price = 39.99m,
                    Description = "Control your lighting with your voice.",
                    Category = "cat-07",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-16",
                    Name = "Robot Vacuum",
                    Price = 199.99m,
                    Description = "Keep your floors clean effortlessly.",
                    Category = "cat-12",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-17",
                    Name = "Wireless Charger",
                    Price = 29.99m,
                    Description = "Charge your devices wirelessly.",
                    Category = "cat-13",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-18",
                    Name = "Smart Thermostat",
                    Price = 199.99m,
                    Description = "Control your home's temperature remotely.",
                    Category = "cat-07",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-19",
                    Name = "Drone Pro",
                    Price = 499.99m,
                    Description = "Capture aerial footage with ease.",
                    Category = "camera",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-20",
                    Name = "Gaming Mouse",
                    Price = 49.99m,
                    Description = "Precision and comfort for gamers.",
                    Category = "cat-06",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-21",
                    Name = "Electric Scooter",
                    Price = 299.99m,
                    Description = "Eco-friendly transportation.",
                    Category = "cat-17",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-22",
                    Name = "Bluetooth Keyboard",
                    Price = 59.99m,
                    Description = "Portable and convenient typing.",
                    Category = "cat-13",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-23",
                    Name = "Home Security Camera",
                    Price = 149.99m,
                    Description = "Keep an eye on your home.",
                    Category = "cat-07",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-24",
                    Name = "Portable Power Bank",
                    Price = 39.99m,
                    Description = "Charge your devices on the go.",
                    Category = "cat-13",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-25",
                    Name = "Smart Doorbell",
                    Price = 99.99m,
                    Description = "See who's at the door from anywhere.",
                    Category = "cat-07",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-26",
                    Name = "Electric Toothbrush",
                    Price = 79.99m,
                    Description = "Advanced dental care.",
                    Category = "cat-12",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-27",
                    Name = "Smart Plug",
                    Price = 29.99m,
                    Description = "Control any device from your phone.",
                    Category = "cat-07",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-28",
                    Name = "Smart Mirror",
                    Price = 499.99m,
                    Description = "A mirror that helps you stay connected.",
                    Category = "cat-07",
                    Image = "https://placehold.co/500x500"
                },
                new Product
                {
                    Id = "el-29",
                    Name = "High Speed Router",
                    Price = 199.99m,
                    Description = "Blazing fast internet speeds.",
                    Category = "cat-10",
                    Image = "https://placehold.co/500x500"
                }
            });
        }
    }
}
