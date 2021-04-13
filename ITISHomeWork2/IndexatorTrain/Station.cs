using System;

namespace IndexatorTrain
{
    class Station
    {
        public string Name { get; set; }

        private DateTime? timeOfArrival;
        private DateTime? timeOfDeparture;

        public DateTime? TimeOfArrival
        {
            get { return timeOfArrival; }

            set
            {
                timeOfArrival = timeOfDeparture is null ? value
                : value > timeOfArrival ? timeOfDeparture : value;
            }
        }

        public DateTime? TimeOfDeparture
        {
            get { return timeOfDeparture; }

            set
            {
                timeOfDeparture = timeOfArrival is null ? value
                : value < timeOfArrival ? timeOfDeparture : value;
            }
        }
    }
}
