using System.Collections.Generic;
using System.Linq;

namespace TestInterview
{
    class Person
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Email { get; set; }


        ///<summary>
        /// Get the emails of the persons of the collection over 30, in alphabetical order
        ///</summary>
        public static IEnumerable<string> GetConcernedEmails(IEnumerable<Person> persons)
        {
            // Exercise 1 : complete in linq
            // return ....
            return persons.Where(x => x.Age > 30).Select(x => x.Email).OrderBy(x => x);
        }
    }
}