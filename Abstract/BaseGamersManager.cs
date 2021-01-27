using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1.Abstract
{
    public abstract class BaseGamersManager : IGamersService
    {
        public virtual void Add(Gamers gamers)
        {
            Console.WriteLine("Gamers Added :" + gamers.FirstName); ;
        }

        public virtual void Delete(Gamers gamers)
        {
            Console.WriteLine("Gamers Deleted :" + gamers.FirstName); ;
        }
        public virtual void Upgrade(Gamers gamers)
        {
            Console.WriteLine("Gamers Upgraded:" + gamers.FirstName); ;
        }
    }
}
