// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hw8
{
    using hw8.Classes;
    using Hw8.Classes;

    internal class Program
    {
        public static void Main(string[] args)
        {
            Medicine[] medicalGoods = new Medicine[0];
            MedicineType[] medicineTypes = new MedicineType[0];
            Medicine[] products = new Medicine[0];

            CreateMedicines(ref medicalGoods, new Medicine("Lozenges", 0, Enums.MedicineTypesEnum.Lozenges));
            CreateMedicines(ref medicalGoods, new Medicine("Disposables", 0, Enums.MedicineTypesEnum.Disposables));
            CreateMedicines(ref medicalGoods, new Medicine("Liquids", 0, Enums.MedicineTypesEnum.Liquids));
            CreateMedicines(ref medicalGoods, new Medicine("Pills", 0, Enums.MedicineTypesEnum.Pills));

            CreateMedicineTypes(ref medicineTypes, new MedicineType("Lozenges", 0, Enums.MedicineTypesEnum.Lozenges, "AntiCough"));
            CreateMedicineTypes(ref medicineTypes, new MedicineType("Lozenges", 0, Enums.MedicineTypesEnum.Lozenges, "SoreThroat"));
            CreateMedicineTypes(ref medicineTypes, new MedicineType("Disposables", 0, Enums.MedicineTypesEnum.Disposables, "Gauze"));
            CreateMedicineTypes(ref medicineTypes, new MedicineType("Disposables", 0, Enums.MedicineTypesEnum.Disposables, "BandAid"));
            CreateMedicineTypes(ref medicineTypes, new MedicineType("Liquids", 0, Enums.MedicineTypesEnum.Liquids, "Electrolite"));
            CreateMedicineTypes(ref medicineTypes, new MedicineType("Liquids", 0, Enums.MedicineTypesEnum.Liquids, "Rehyrdration"));
            CreateMedicineTypes(ref medicineTypes, new MedicineType("Pills", 0, Enums.MedicineTypesEnum.Pills, "Antipiretic"));
            CreateMedicineTypes(ref medicineTypes, new MedicineType("Pills", 0, Enums.MedicineTypesEnum.Pills, "APMedicine"));
            CreateMedicineTypes(ref medicineTypes, new MedicineType("Pills", 0, Enums.MedicineTypesEnum.Pills, "Homeopathy"));

            CreateMedicaments(ref products, new Antipiretic("Nurofen", 102.0, Enums.MedicineTypesEnum.Pills, "Antipiretic", true));
            CreateMedicaments(ref products, new Antipiretic("Aspirine", 94.0, Enums.MedicineTypesEnum.Pills, "Antipiretic", true));
            CreateMedicaments(ref products, new Antipiretic("Aspirine", 94.0, Enums.MedicineTypesEnum.Pills, "Antipiretic", true));
            CreateMedicaments(ref products, new Antipiretic("Paracetamol", 29.0, Enums.MedicineTypesEnum.Pills, "Antipiretic", true));
            CreateMedicaments(ref products, new APmedicine("Enalapril", 33.0, Enums.MedicineTypesEnum.Pills, "APMedicine", true));
            CreateMedicaments(ref products, new APmedicine("Labetalol", 21.0, Enums.MedicineTypesEnum.Pills, "APMedicine", true));
            CreateMedicaments(ref products, new APmedicine("Benzohexonium", 11.0, Enums.MedicineTypesEnum.Pills, "APMedicine", false));
            CreateMedicaments(ref products, new APmedicine("Nifedipine", 23.0, Enums.MedicineTypesEnum.Pills, "APMedicine", true));
            CreateMedicaments(ref products, new Homeopathy("VertigoHeel", 194.0, Enums.MedicineTypesEnum.Pills, "Antipiretic", true));
            CreateMedicaments(ref products, new Homeopathy("CrapHeel", 944.7, Enums.MedicineTypesEnum.Pills, "Antipiretic", true));
            CreateMedicaments(ref products, new Homeopathy("SnakeOil", 994.0, Enums.MedicineTypesEnum.Pills, "Antipiretic", true));
        }

        public static void PharmacyInterface(Medicine[] products)
        {
            int optionCounter = 3;
            Console.WriteLine(" Hi this is a Good Day Pharmacy");
            Console.WriteLine("\n");
            Console.WriteLine(" Let's look at our drugs!");
            Console.WriteLine("\n");
            Console.WriteLine(" Please choose what you need");
            Console.WriteLine(" You can choose from: ");
            Console.WriteLine("\n");
            Console.WriteLine("Please enter your choice: ");
            Console.WriteLine("\n");
            Console.WriteLine("1 - Sort by type;");
            Console.WriteLine("\n");
            Console.WriteLine("2 - Find an item by name;");
            Console.WriteLine("\n");
            Console.WriteLine("3 - Count items of each type(provide a name of a pharma-group);");
            Console.WriteLine("\n");
            string ingredientNumInput = Console.ReadLine();
            int n;
            bool isNumeric = int.TryParse(ingredientNumInput, out n);

            if (isNumeric && n <= optionCounter && n != 0 && ingredientNumInput != null)
            {
                if (n == 1)
                {
                    Medicine[] med = products.MedicinesSortingByType();
                    PharmacyInterface(med);
                }

                if (n == 2)
                {
                    Console.WriteLine("Please enter the name of the drug");
                    string name = Console.ReadLine();
                    if (name != null)
                    {
                        Medicine[] med = products.FindByName(name);

                        foreach (var medc in med)
                        {
                            if (medc != null)
                            {
                                Console.WriteLine(medc.Name);
                            }
                            else
                            {
                                WrongInput();
                                PharmacyInterface(products);
                            }
                        }
                    }
                    else
                    {
                        WrongInput();
                        PharmacyInterface(products);
                    }
                }

                if (n == 3)
                {
                    Console.WriteLine("Please enter the type of the drug");
                    string pharmaGroupName = Console.ReadLine();
                    if (pharmaGroupName != null)
                    {
                        MedicineType[] med = (MedicineType[])products;
                        int medsTypes = med.MedicinesCountByPharmaGroup(pharmaGroupName);

                        Console.WriteLine($"There are {medsTypes} items of the {pharmaGroupName} pharmacological type");
                    }
                    else
                    {
                        WrongInput();
                        PharmacyInterface(products);
                    }
                }
            }
            else
            {
                WrongInput();
            }

            PharmacyInterface(products);
        }

        public static void WrongInput()
        {
            Console.WriteLine("You've made a wrong input. Please try again.");
        }

        public static void ShowProducts(Medicine[] products)
        {
            foreach (Medicine product in products)
            {
                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"{products[i].Name} - {products[i].Price}");
                }
            }
        }

        public static void CreateMedicines(ref Medicine[] ingredientTypes, Medicine ingredientType)
        {
            ArrayPush(ref ingredientTypes, ingredientType);
        }

        public static void CreateMedicineTypes(ref MedicineType[] ingredientTypes, MedicineType ingredientType)
        {
            ArrayPush(ref ingredientTypes, ingredientType);
        }

        public static void CreateMedicaments(ref Medicine[] ingredientTypes, Medicine ingredientType)
        {
            ArrayPush(ref ingredientTypes, ingredientType);
        }

        public static void ArrayPush<T>(ref T[] table, object value)
        {
            Array.Resize(ref table, table.Length + 1); // Resizing the array for the cloned length (+-) (+1)
            table.SetValue(value, table.Length - 1); // Setting the value for the new element
        }
    }
}