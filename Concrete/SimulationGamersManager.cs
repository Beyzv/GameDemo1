using GameDemo1.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1
{
    public class SimulationGamersManager : BaseGamersManager
    {
      //  private IGamerCheckService _gamerCheckService;
        public override void Add(Gamers gamers)
        {
            // if (_gamerCheckService.CheckIfRealPerson(gamers))
            // {
            //    base.Add(gamers);
            //}
            //else
            //{
            //    throw new Exception("Not a Valid person");
            //}
            base.Add(gamers);

        }

      
    }
}
