using System;
using System.Runtime.InteropServices;

namespace HumansLib
{
    public class Humans
    {
        string _name;
        int _age;
        string _adress;
        string _descriptions;

        public Humans(string Name, int Age, string Adress, string Descriptions)
        {
            _name = Name;
            _age = Age;
            _adress = Adress;
            _descriptions = Descriptions;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public string Adress
        {
            get => _adress;
            set => _adress = value;
        }

        public string Descriptions
        {
            get => _descriptions;
            set => _descriptions = value;
        }
    }
}
