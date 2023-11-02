﻿using System.Collections.Generic;

namespace ThreeCee
{
    internal class Vehicle
    {
        // Modell,
        // Kraftstoff,
        // geleast oder gekauft,
        // interne Bezeichnung,
        // Funktion
        // Bsp.: Volkswagen T6 Transporter, Diesel, geleast von [Leasing-Unternehmen], Lieferung

        public enum EFuelType
        {
            Gasoline, // Benzin
            Diesel,
            Electric
        }

        public enum EStatus
        {
            Bought, // gekauft
            Leased, // geleast
        }

        public string Model;
        public string Name;
        public EStatus Status;
        public EFuelType FuelType;
        public string Function;

        public Vehicle(string model, string name, EStatus status, EFuelType fuelType, string function)
        {
            Model = model;
            Name = name;
            Status = status;
            FuelType = fuelType;
            Function = function;
        }

        public static List<Vehicle> GetDummyVehicles() =>
            new List<Vehicle>
            {
                new Vehicle(
                    model: "VW T6 Transporter",
                    name: "Lieferwagen 1",
                    status: EStatus.Bought,
                    function: "Lieferung",
                    fuelType: EFuelType.Gasoline
                ),
                new Vehicle(
                    model: "VW T6 Transporter",
                    name: "Lieferwagen 2",
                    status: EStatus.Leased,
                    function: "Lieferung",
                    fuelType: EFuelType.Gasoline
                )
            };
    }
}
