using MVCEntityFramework.EF.Entities;

namespace MVCEntityFramework.DomainModel.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private AdventureWorks2014Context _dbContext;

        public void SetDbContext(AdventureWorks2014Context adventureWorks2014Context)
        {
            _dbContext = adventureWorks2014Context;
        }

        public Person GetPerson(int personID)
        {
            throw new System.NotImplementedException();
        }

        public void CreatePerson(Person person)
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePerson(Person person)
        {
            throw new System.NotImplementedException();
        }
    }
}
