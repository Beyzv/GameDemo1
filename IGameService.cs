using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1
{
   public interface IGameService
    {
        void Add(Games games);
        void Delete(Games games);
        void Upgrade(Games games);
    }
}
