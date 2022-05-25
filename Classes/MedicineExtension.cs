// <copyright file="MedicineExtension.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace hw8.Classes
{
    using System.Collections;
    using Hw8.Classes;
    using Hw8.Enums;

    public static class MedicineExtension
    {
        internal static Medicine[] MedicinesSortingByType(this Medicine[] me)
        {
            Medicine[] sortedArrayOfMedicines;

            Array.Sort(me, delegate(Medicine me1, Medicine me2)
            {
                return me1.Type.CompareTo(me2.Type);
            });

            sortedArrayOfMedicines = me;
            return sortedArrayOfMedicines;
        }

        internal static Medicine[] FindByName(this Medicine[] me, string name)
        {
            Medicine[] sortedArrayOfMedicines = new Medicine[1000];

            for (int i = 0; i < me.Length; i++)
            {
                if (me[i] != null)
                {
                    if (me[i].Name == name)
                    {
                        sortedArrayOfMedicines[i] = me[i];
                    }
                }
            }

            return sortedArrayOfMedicines;
        }
    }
}