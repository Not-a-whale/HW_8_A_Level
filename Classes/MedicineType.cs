// <copyright file="MedicineType.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hw8.Classes
{
    using Hw8.Enums;

    internal class MedicineType : Medicine
    {
        protected string pharmaGroup = "Other";

        public MedicineType(string name, double price, MedicineTypesEnum medicineType, string pharmaGroup)
            : base(name, price, medicineType)
        {
            this.PharmaGroup = pharmaGroup;
        }

        public virtual string PharmaGroup
        {
            get => this.pharmaGroup;
            set
            {
                this.pharmaGroup = this.Type == MedicineTypesEnum.Disposables ? value : "Other";
            }
        }
    }
}
