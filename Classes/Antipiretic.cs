// <copyright file="Antipiretic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hw8.Classes
{
    using Hw8.Enums;

    internal class Antipiretic : MedicineType
    {
        public Antipiretic(string name, double price, MedicineTypesEnum type, string pharmaGroup, bool isInStock)
            : base(name, price, type, pharmaGroup)
        {
            this.IsInStock = isInStock;
        }

        public override string PharmaGroup
        {
            get => this.pharmaGroup;
            set
            {
                this.pharmaGroup = "Antipiretics";
            }
        }

        private bool IsInStock { get; set; }
    }
}
