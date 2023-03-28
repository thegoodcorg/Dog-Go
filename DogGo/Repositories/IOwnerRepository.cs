﻿using DogGo.Models;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    namespace DogGo.Repositories
    {
        public interface IOwnerRepository
        {
            List<Owner> GetAllOwners();
            Owner GetOwnerById(int id);
        }
    }
}
