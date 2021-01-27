using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1
{
    public abstract class BaseGameManager
    {
        public virtual void Add(Games games)
        {
            Console.WriteLine("Gamers Added :" + games.Name); ;
        }

        public virtual void Delete(Games games)
        {
            Console.WriteLine("Gamers Deleted :" + games.Name ); ;
        }
        public virtual void Upgrade(Games games)
        {
            Console.WriteLine("Gamers Upgraded:" + games.Name); ;
        }
    }
}
