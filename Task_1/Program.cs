using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main()
        {

            using (AppDbContext db = new AppDbContext())
            {


                Category category1 = new Category() { Name = "Фотоаппараты", Icon = @"С:\image1.jpg" };
                Category category2 = new Category() { Name = "Штативы", Icon = @"С:\image2.jpg" };
                Category category3 = new Category() { Name = "Микрофоны", Icon = @"С:\image3.jpg" };

                db.Categorys.AddRange(category1, category2, category3);

                db.SaveChanges();

                User user1 = new User()
                {
                    Name = "Рома",
                    Login = "Nub202",
                    Password = "hgjk6khjk4",
                    Email = "Nub202@gmail.com",
                };

                User user2 = new User()
                {
                    Name = "Саша",
                    Login = "Shashok12",
                    Password = "67igfj547",
                    Email = "Shashok12@gmail.com",
                };

                db.Users.AddRange(user1, user2);




                Product Product1 = new Product()
                {
                    Name = "Nikon AF-S Micro",
                    Price = 34345,
                    ActionPrice = 12345,
                    Description = "фотоаппарат для чегото",
                    Category = category1

                };

                Product Product2 = new Product()
                {
                    Name = "Freewell Variable",
                    Price = 35466,
                    ActionPrice = 3452,
                    Description = "Штатив для чегото",
                    Category = category2

                };


                Product Product3 = new Product()
                {
                    Name = "Photographic Solutions Eclipse",
                    Price = 34566,
                    ActionPrice = 1234,
                    Description = "штатив для чегото",
                    Category = category2

                };


                Product Product4 = new Product()
                {
                    Name = "JJC CL-3D",
                    Price = 5623,
                    ActionPrice = 3455,
                    Description = "микрофон для чегото",
                    Category = category3

                };

                Product Product5 = new Product()
                {
                    Name = "Nikon AF-S Micro",
                    Price = 222,
                    ActionPrice = 44,
                    Description = "штатив для чегото",
                    Category = category2

                };

                Product Product6 = new Product()
                {
                    Name = "Nikon AF-S Micro",
                    Price = 5434,
                    ActionPrice = 467,
                    Description = "микрофн для чегото",
                    Category = category3

                };

                Product Product7 = new Product()
                {
                    Name = "AF-S",
                    Price = 8463,
                    ActionPrice = 234,
                    Description = "фотоаппарат для чегото",
                    Category = category1

                };

                db.Products.AddRange(Product1, Product2, Product3, Product4, Product5, Product6, Product7);

                db.SaveChanges();




                Word word1 = new Word() { Header = "", KeyWord = "камера" };
                Word word2 = new Word() { Header = "", KeyWord = "фотоаппара" };
                Word word3 = new Word() { Header = "", KeyWord = "Штатив" };
                Word word4 = new Word() { Header = "", KeyWord = "Трипод" };
                Word word5 = new Word() { Header = "", KeyWord = "Звук" };
                Word word6 = new Word() { Header = "", KeyWord = "Аудио" };
                Word word7 = new Word() { Header = "", KeyWord = "Подставка" };

                Word word8 = new Word() { Header = "", KeyWord = "Вундервафля" };

                db.Words.AddRange(word1, word2, word3, word4, word5, word6, word7, word8);
                db.SaveChanges();

                KeyParams k1 = new KeyParams() { KeyWords = word1, Product = Product1 };
                KeyParams k2 = new KeyParams() { KeyWords = word2, Product = Product1 };
                KeyParams k3 = new KeyParams() { KeyWords = word3, Product = Product2 };
                KeyParams k4 = new KeyParams() { KeyWords = word4, Product = Product2 };
                KeyParams k5 = new KeyParams() { KeyWords = word5, Product = Product3 };
                KeyParams k6 = new KeyParams() { KeyWords = word4, Product = Product3 };
                KeyParams k7 = new KeyParams() { KeyWords = word3, Product = Product3 };
                KeyParams k8 = new KeyParams() { KeyWords = word2, Product = Product5 };
                KeyParams k9 = new KeyParams() { KeyWords = word6, Product = Product4 };
                KeyParams k10 = new KeyParams() { KeyWords = word7, Product = Product4 };
                KeyParams k11 = new KeyParams() { KeyWords = word7, Product = Product5 };
                KeyParams k12 = new KeyParams() { KeyWords = word3, Product = Product5 };
                KeyParams k13 = new KeyParams() { KeyWords = word1, Product = Product6 };
                KeyParams k14 = new KeyParams() { KeyWords = word2, Product = Product7 };

                db.KeyParamss.AddRange(k1, k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, k14);

                db.SaveChanges();




            };



            Console.WriteLine("е даныне внеенны");
            Console.ReadKey();



        }
    }
}
