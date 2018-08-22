using System;
using System.Collections.Generic;
namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> otherList = new List<string>(){"Uranus", "Neptune"};
            planetList.AddRange(otherList);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            List<string> rockyBois = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");
            List<Dictionary<string,string>> spaceCrafts = new List<Dictionary<string,string>>();
            spaceCrafts.Add(new Dictionary<string,string>(){
                {"Mercury", "Viking"},
            }
            );
            spaceCrafts.Add(new Dictionary<string,string>(){
                {"Venus", "Spartan"},
            }
            );
            spaceCrafts.Add(new Dictionary<string,string>(){
                {"Earth", "Roman"},
            }
            );
            spaceCrafts.Add(new Dictionary<string,string>(){
                {"Mars", "Gladiator"},
            }
            );
            spaceCrafts.Add(new Dictionary<string,string>(){
                {"Jupiter", "Chicken"},
            }
            );
            spaceCrafts.Add(new Dictionary<string,string>(){
                {"Saturn", "Cow"},
            }
            );
            spaceCrafts.Add(new Dictionary<string,string>(){
                {"Uranus", "Whale"},
            }
            );
            spaceCrafts.Add(new Dictionary<string,string>(){
                {"Neptune", "Dolphin"},
            }
            );
            spaceCrafts.Add(new Dictionary<string,string>(){
                {"Neptune", "Cool"},
            }
            );
            foreach (string item in planetList)
            {
                foreach(Dictionary<string,string> killMe in spaceCrafts) {
                    foreach(KeyValuePair<string, string> please in killMe) {
                        if(please.Key == item) {
                            Console.WriteLine($"{item} has been visited by {please.Value}");
                        }
                    }
                }
            }
            foreach (string item in rockyBois)
            {
                Console.WriteLine(item);
            }
        }
    }
}
