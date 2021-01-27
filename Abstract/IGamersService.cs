using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1
{
    public interface IGamersService
    {
        void Add(Gamers gamers);
        void Delete(Gamers gamers);
        void Upgrade(Gamers gamers);
    }
} 
