using GameDemo1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1.Concrete
{
    public class OnlineGamersManager : BaseGamersManager
    {
        public override void Add(Gamers gamers)
        {
            base.Add(gamers);
        }
        public override void Delete(Gamers gamers)
        {
            base.Delete(gamers);
        }
        public override void Upgrade(Gamers gamers)
        {
            base.Upgrade(gamers);
        }
    }
}
