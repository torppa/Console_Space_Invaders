﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Space_Invaders.Entities
{
    public class Enemy : Entity
    {
        public Enemy()
        {
            id = 2;
            image = "¤".ToCharArray();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
