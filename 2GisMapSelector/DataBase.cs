using System;
using System.Collections.Generic;

namespace GisSelector
{

    [Serializable()]
    public class Street
    {
        public string StreetName;
        private List<string> Buildings = new List<string>();

        public Street(string name)
        {
            StreetName = name;
        }

        public void AddBuilding(string b)
        {
            Buildings.Add(b);
        }

        public string[] GetBuildings()
        {
            return Buildings.ToArray();
        }

    }

    [Serializable()]
    public class City
    {
        public string Name;
        private List<Street> Streets = new List<Street>();

        public City(string name)
        {
            Name = name;
        }

        public void AddStreet(Street s)
        {
            Streets.Add(s);
        }

        public Street[] GetStreets()
        {
            return Streets.ToArray();
        }

    }

    [Serializable()]
    public class DataBase
    {
        private List<City> Cities = new List<City>();

        public void AddCity(City c)
        {
            Cities.Add(c);
        }

        public City[] GetCities()
        {
            return Cities.ToArray();
        }
    }
}
