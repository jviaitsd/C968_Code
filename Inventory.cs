using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_PerformanceAssessment
{
    static class Inventory
    {
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static BindingList<Product> Products = new BindingList<Product>();
        internal static readonly object AssociatedPart;

        // Part
        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public static Part lookUpPart(int partId)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartId == partId)
                {
                    return part;
                }
            }
            return null;
        }

        public static void updatePart(int partId, Part updatedPart)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartId == partId)
                {
                    AllParts[i] = updatedPart;
                }
            }
        }

        // Product
        public static void addProduct(Product product)
        {
            Products.Add(product);
        }
        public static bool removeProduct(int index)
        {
            Products.RemoveAt(index);
            return true;
        }
        public static Product lookUpProduct(int productId)
        {
            foreach (Product product in Products)
            {
                if (product.ProductId == productId)
                {
                    return product;
                }
            }
            return null;
        }
        public static void updateProduct(int productId, Product updatedProduct)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductId == productId)
                {
                    Products[i] = updatedProduct;
                }
            }
        }

        //Add preselected data into grid
        public static void build()
        {
            // Add Pre Parts Data
            Part part1 = new Inhouse
            {
                PartId = 1,
                Name = "Smooth Bore Tip",
                InStock = 25,
                Price = 55m,
                Min = 10,
                Max = 75,
                MachineId = 1,
        };

            Part part2 = new Outsourced
            {
                PartId = 2,
                Name = "Pistol Grip",
                InStock = 32,
                Price = 60m,
                Min = 20,
                Max = 40,
                CompanyName = "Grip Master"
            };

            Part part3 = new Inhouse
            {
                PartId = 3,
                Name = "Flow Handle",
                InStock = 22,
                Price = 50m,
                Min = 20,
                Max = 100,
                MachineId = 2
            };

            Part part4 = new Outsourced
            {
                PartId = 4,
                Name = "Housing - Nozzle",
                InStock = 55,
                Price = 75m,
                Min = 25,
                Max = 100,
                CompanyName = "Akron Brass"
            };

            Part part5 = new Outsourced
            {
                PartId = 5,
                Name = "Housing - Monitor",
                InStock = 20,
                Price = 343,
                Min = 5,
                Max = 25,
                CompanyName = "Akron Brass"
            };

            Part part6 = new Inhouse
            {
                PartId = 6,
                Name = "Combination - Tip",
                InStock = 23,
                Price = 75,
                Min = 5,
                Max = 20,
                MachineId = 3 
            };

            Part part7 = new Inhouse
            {
                PartId = 7,
                Name = "Hybrid - Tip",
                InStock = 14,
                Price = 85m,
                Min = 5,
                Max = 20,
                MachineId = 4
            };

            AllParts.Add(part1);
            AllParts.Add(part2);
            AllParts.Add(part3);
            AllParts.Add(part4);
            AllParts.Add(part5);
            AllParts.Add(part6);
            AllParts.Add(part7);

            // Add Pre Products Data
            Product product1 = new Product
            {
                ProductId = 1,
                Name = "Smooth Bore Nozzle",
                InStock = 22,
                Price = 125m,
                Min = 20,
                Max = 45
            };

            Product product2 = new Product
            {
                ProductId = 2,
                Name = "Combination Nozzle",
                InStock = 23,
                Price = 150m,
                Min = 5,
                Max = 35
            };

            Product product3 = new Product
            {
                ProductId = 3,
                Name = "Hybrid Nozzle",
                InStock = 15,
                Price = 175m,
                Min = 5,
                Max = 15
            };

            Product product4 = new Product
            {
                ProductId = 4,
                Name = " Ground Monitor",
                InStock = 20,
                Price = 1343m,
                Min = 5,
                Max = 20
            };

            Products.Add(product1);
            Products.Add(product2);
            Products.Add(product3);
            Products.Add(product4);
        }
    }
}
