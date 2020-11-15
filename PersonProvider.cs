using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TestInterview
{
    /// Exercise 2: Messy code Identify the issues
    /// - the StreamerReader is not disposed
    /// - could use some linq to iterate on list
    /// - could use a better exception management
    /// - what if there are millions of persons in the file ? can use IEnumerable
    /// - what if GetNames and GetEmails are called very often ? can use a Lazy for the list content
    class MessyPersonProvider
    {
        private const string FileName = "persons.json";

        ///<summary>
        /// Get the names from the persons over 30 from the file
        ///</summary>
        public static List<string> GetNames()
        {
            var list = new List<string>();
            var reader = new StreamReader(FileName);
            var content = JsonSerializer.Deserialize<IEnumerable<Person>>(reader.ReadToEnd());
            foreach (var person in content)
            {
                if (person.Age > 30)
                {
                    list.Add(person.FirstName);
                }
            }
            return list;
        }

        ///<summary>
        /// Get the emails of the persons over 30 from the file
        ///</summary>
        public static List<string> GetEmails()
        {
            var list = new List<string>();
            var reader = new StreamReader(FileName);
            var content = JsonSerializer.Deserialize<IEnumerable<Person>>(reader.ReadToEnd());
            foreach (var person in content)
            {
                if (person.Age > 30)
                {
                    list.Add(person.Email);
                }
            }

            return list;
        }
    }
}