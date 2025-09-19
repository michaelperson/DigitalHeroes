using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalHeroes.Models.Exceptions
{
    public class TooYoungException: Exception
    {
        public TooYoungException():base("Votre personnage est trop jeune (min 3 ans)")
        {
            
        }
         
    }
}
