using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1.Abstract
{
    public class GamersCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamers gamers)
        {
            return true;
        }
    }
}
