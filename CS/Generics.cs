// using System.Collections.Generic;

// namespace LearningClasses
// {
//     public class Generic
//     {
//         //using list
//         void LearningList()
//         {
//             List<string> names = new List<string> { "Nitesh Khatri" };
//             names.Add("Nitesh Khatri");
//             names.Add("Nitesh Khatri");
//             names.Add("Nitesh Khatri");

//             var y = names.Find(y => y.StartsWith("Nit"));

//             // names.Remove("Khatri");

//             foreach (string name in names)
//             {
//                 Console.WriteLine(name);
//             }

//         }

//         void LearningDictionary()
//         {
//             Dictionary<string, string> countryCapitals = new Dictionary<string, string>();
//             countryCapitals.Add("Nepal", "Kathmandu");
//             countryCapitals.Add("China", "Beijing");

//             foreach (var countryCapital in countryCapitals)
//             {
//                 Console.WriteLine(countryCapital.Value);
//             }

//             // List<Country> countries = new List<Country>();
//             // countries.Add(new Country());
//         }
//     }
// }