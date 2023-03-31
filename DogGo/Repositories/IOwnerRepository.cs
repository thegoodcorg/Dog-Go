using DogGo.Models;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    namespace DogGo.Repositories
    {
        public interface IOwnerRepository
        {
            List<Owner> GetAllOwners();
            Owner GetOwnerById(int id);
            public void AddOwner(Owner owner);
            public void DeleteOwner(int id);
            public void UpdateOwner(Owner owner);  

            public Owner GetOwnerByEmail(string email);

        }
    }
}
