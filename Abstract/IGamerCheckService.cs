using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamers gamers);
    }
}
