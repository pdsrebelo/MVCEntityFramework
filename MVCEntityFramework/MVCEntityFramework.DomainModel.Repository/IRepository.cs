using MVCEntityFramework.EF.Entities;

namespace MVCEntityFramework.DomainModel.Repository
{
    public interface IRepository
    {
        void SetDbContext(AdventureWorks2014Context adventureWorks2014Context);
    }
}
