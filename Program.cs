using System;

namespace generics2
{
    public class Program
    {
        public static string searchValue(int value,Dictionary<string,int> Dict){
       
        foreach(KeyValuePair<string,int> item in Dict){
            if(item.Value == value){
                return item.Key;
            }
        }
        return "Item not Find" ;
        }
        public static void Main(string[] args)
        {
            var Dict = new Dictionary<string,int>();
            Dict["Atal Bihari Vajpayee"] = 1998;
            Dict["Narendra Modi"] = 2014;
            Dict["Manmohan Singh"] = 2004;
            //PM in 2004
            Console.WriteLine("Prime minister of {0} was {1}",2004,searchValue(2004,Dict));
            //Adding current PM
            Dict["Narendra Modi"] = 2019;
            Console.WriteLine("Current Prime Minister added");
            //list before Sorting
            Console.WriteLine("Before Sorting");
            foreach (var KeyValP in Dict)
            {
                Console.WriteLine("{0}, {1}", KeyValP.Key, KeyValP.Value);
            }
            //List after sorting
            Console.WriteLine("After Sorting");
            Dict = Dict.OrderBy(sort=>sort.Value).ToDictionary(sort=>sort.Key, sort=>sort.Value);
            foreach (var KeyValP in Dict)
            {
             Console.WriteLine("{0}, {1}", KeyValP.Key, KeyValP.Value);
            }
        }
    }
}
