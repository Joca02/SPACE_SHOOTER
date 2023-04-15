using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPACE_SHOOTER
{
    
    public class Spaceship
    {
        
        private int health;
        
        public bool isDead()
        {
            return health > 0;
        }
        
    }
}
