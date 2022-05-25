// <copyright file="Medicine.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hw8.Classes
{
    using Hw8.Enums;

    internal class Medicine
    {
        public Medicine(string name, double price, MedicineTypesEnum medicineType)
        {
            this.Name = name;
            this.Price = price;
            this.Type = medicineType;
        }

        public MedicineTypesEnum Type { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }
    }
}
