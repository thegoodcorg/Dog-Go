using DogGo.Models;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IDogRepository
    {
        void UpdateDog(Dog dog);
        Dog GetDogById(int id);
        void AddDog(Dog dog);
        List<Dog> GetAllDogs();
        List<Dog> GetDogsByOwnerId(int ownerId);
    }
}
