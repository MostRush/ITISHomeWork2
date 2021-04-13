using System;
using System.Linq;
using System.Collections.Generic;

namespace IndexatorTrain
{
    class Train
    {
        public string Name { get; set; }
        public int CountOfVagons { get; set; }

        public List<Carriage> Carriages { get; set; }
        public List<Station> Stations { get; set; }

        public Train(List<Carriage> carriages, List<Station> stations)
        {
            Carriages = carriages;
            Stations = stations;

            CountOfVagons = Carriages.Count;
        }

        public Station this[string stationName]
        {
            get
            {
                return Stations.FirstOrDefault(x => x.Name == stationName);
            }

            set
            {
                Stations[Stations.FindIndex(x => x.Name == stationName)] = value;
            }
        }

        public void PrinTrainData()
        {
            Console.Write($"Поезд с номером: {Name}");
            
            Console.Write($"\n\tУ поезда {Name} есть вагоны {Carriages.Count}:");

            foreach (var c in Carriages)
            {
                Console.Write($"\n\tИмя: {c.Name}");
            }

            Console.Write($"\n\nСтанции {Stations.Count}:");

            foreach (var s in Stations)
            {
                Console.WriteLine($"\n\tСтанция:{s.Name}" +
                    $"\n\t\tВремя прибытия: {s.TimeOfArrival}" +
                    $"\n\t\tВремя отправления: {s.TimeOfDeparture}");
            }

            Console.Write("\n\nВремени пути между станциями:");

            Station lastStation = null;

            foreach (var s in Stations)
            {
                if (lastStation is null)
                {
                    lastStation = s;
                    continue;
                }

                var t = CalcTimeOnWay(lastStation, s);

                Console.Write($"\n\tВремени в пути между станцией {lastStation.Name} и {s.Name}: ");
                Console.Write($"{t.Value.Days} d {t.Value.Hours}:{t.Value.Minutes}:{t.Value.Seconds}");

                lastStation = s;
            }
        }

        public TimeSpan? CalcTimeOnWay(Station station1, Station station2)
        {
            return station2.TimeOfArrival - station1.TimeOfDeparture;
        }
    }
}
