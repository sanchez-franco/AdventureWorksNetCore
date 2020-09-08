using System.Linq;

namespace AdventureWorks.Data.Entity
{
    public partial class Person
    {
        public string FullName => string.Join(" ", (new string[] { FirstName, MiddleName, LastName }).Where(s => !string.IsNullOrEmpty(s)));
    }
}
