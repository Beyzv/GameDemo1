﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1
{
    public class Gamers :IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public string NationalityId { get; set; }
        public string GameType { get; set; }
    }

   
}
    