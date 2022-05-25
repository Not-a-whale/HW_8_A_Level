// <copyright file="MedicamentTypeExtension.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Hw8.Classes
{
    using Hw8.Classes;
    using Hw8.Enums;

    public static class MedicamentTypeExtension
    {
        internal static int MedicinesCountByPharmaGroup(this MedicineType[] meTy, string pharmaGroup)
        {
            int count = 0;
            foreach (MedicineType meType in meTy)
            {
                if (meType.PharmaGroup == pharmaGroup)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
