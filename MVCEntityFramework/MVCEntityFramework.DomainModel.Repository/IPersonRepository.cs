using MVCEntityFramework.EF.Entities;

namespace MVCEntityFramework.DomainModel.Repository
{
    public interface IPersonRepository : IRepository
    {
        Person GetPerson(int personID);
        void CreatePerson(Person person);
        void UpdatePerson(Person person);
    }
}
