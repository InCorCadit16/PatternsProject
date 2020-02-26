using System;
using System.Collections.Generic;

namespace PatternsProject
{
    class ObserverExample
    {
        static void Main(string[] args)
        {
            WeatherData DataSource = new WeatherData();
            CurrentConditionsDisplay CCD = new CurrentConditionsDisplay(DataSource);
            DataSource.RegisterObserver(CCD);

            DataSource.SetMeasurments(22, 19, 875);
            DataSource.SetMeasurments(24, 29, 910);
            DataSource.SetMeasurments(17.4f, 45, 854);
        }
    }

    public interface ISubject {
        public void RegisterObserver(IObserver O);
        public void RemoveObserver(IObserver O);
        public void NotifyObservers();
        

    }

    public interface IObserver
    {
        public void Update(float Temperature, float Humidity, float Pressure);
    }

    public interface IDisplayable
    {
        public void Display();
    }

    public class WeatherData : ISubject
    {
        private IList<IObserver> Observers;
        private float _temperature, _humidity, _pressure;

        public WeatherData()
        {
            Observers = new List<IObserver>();
        }


        public void NotifyObservers()
        {
            foreach (IObserver O in Observers)
            {
                O.Update(_temperature, _humidity, _pressure);
            }
        }

        public void RegisterObserver(IObserver O)
        {
            Observers.Add(O);
        }

        public void RemoveObserver(IObserver O)
        {
            Observers.Remove(O);
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurments(float Temperature, float Humidity, float Pressure)
        {
            _temperature = Temperature;
            _humidity = Humidity;
            _pressure = Pressure;
            MeasurementsChanged();
        }
    }

    public class CurrentConditionsDisplay : IObserver, IDisplayable
    {
        private float _temperature;
        private float _humidity;
        private ISubject WeatherData;

        public CurrentConditionsDisplay(ISubject Subject)
        {
            WeatherData = Subject;
        }

        public void Display()
        {
            Console.WriteLine("\n-------");
            Console.WriteLine("CurrentConditionsDisplay");
            Console.WriteLine($"Temperature: {_temperature} deg.");
            Console.WriteLine($"Humidity: {_humidity}%");
            Console.WriteLine("-------\n");
        }

        public void Update(float Temperature, float Humidity, float Pressure)
        {
            _temperature = Temperature;
            _humidity = Humidity;
            Display();
        }
    }
}
