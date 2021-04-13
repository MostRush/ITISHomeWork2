using System;
using System.Collections.Generic;

namespace IndexatorTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            var carriages = new List<Carriage>();
            var stations = new List<Station>();

            carriages.Add(new Carriage("A-1"));
            carriages.Add(new Carriage("A-2"));
            carriages.Add(new Carriage("A-3"));
            carriages.Add(new Carriage("A-4"));

            var s1 = new Station();
            s1.Name = "Алматы";
            s1.TimeOfArrival = null;
            s1.TimeOfDeparture = DateTime.Now;

            var s2 = new Station();
            s2.Name = "Петропавлоск";
            s2.TimeOfArrival = s1.TimeOfDeparture + TimeSpan.FromHours(1);
            s2.TimeOfDeparture = s2.TimeOfArrival + TimeSpan.FromMinutes(10);

            var s3 = new Station();
            s3.Name = "ЕкатеренбурК";
            s3.TimeOfArrival = s2.TimeOfDeparture + TimeSpan.FromHours(1);
            s3.TimeOfDeparture = s3.TimeOfArrival + TimeSpan.FromMinutes(10);

            var s4 = new Station();
            s4.Name = "Казань";
            s4.TimeOfArrival = s3.TimeOfDeparture + TimeSpan.FromHours(1);
            s4.TimeOfDeparture = s4.TimeOfArrival + TimeSpan.FromMinutes(10);

            stations.AddRange(new Station[] { s1, s2, s3, s4 });

            var train = new Train(carriages, stations);
            train.Name = "A-10";
            train.Stations = stations;
            train.Carriages = carriages;

            Console.Clear();

            train.PrinTrainData();

            var st1 = train["Алматы"];

            Console.WriteLine();
            Console.WriteLine(st1.Name, st1.TimeOfArrival);
        }
    }
}
