using System;

namespace humans
{
    public class Humans
    {
        string name;
        int age;
        string adress;
        string descriptions;
        public Humans(string name, int age, string adress, string descriptions)
        {
            this.name = name;
            this.age = age;
            this.adress = adress;
            this.descriptions = descriptions;
        }
        public string GetName() => name;
        public int GetAge() => age;
        public string GetAdress() => adress;
        public string GetDescriptions() => descriptions;
        public void SetName(string name) => this.name = name;
        public int SetAge(int age) => this.age = age;
        public string SetAdress(string adress) => this.adress = adress;
        public string SetDescriptions(string descriptions) => this.descriptions = descriptions;
    }
}
