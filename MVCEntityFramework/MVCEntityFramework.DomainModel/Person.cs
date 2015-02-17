using System;
using System.Collections.Generic;

namespace MVCEntityFramework.DomainModel
{
    /// <summary>
    /// This class represents a smaller version of the information we have in the database.
    /// </summary>
    public class Person
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; } // TODO: The types of addresses will have an enum associated
        public DateTime BirthDate { get; set; } // HumanResources.Employee.BirthDate
        public IEnumerable<string> EmailAddress { get; set; }
        public IEnumerable<string> Phone { get; set; } // TODO: The types of phones will have an enum associated
        #endregion
    }
}
