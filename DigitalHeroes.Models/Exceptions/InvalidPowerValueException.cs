using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalHeroes.Models.Exceptions
{
    public class InvalidPowerValueException:Exception
    {
        public InvalidPowerValueException():base("La puissance ne peut pas être négative ou dépasser la valeur de 100")
        {
            
        }
    }
}
