using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalHeroes.Models
{
    public class Vilain : Heros
    {
        private List<Vilain> _acolytes;

        public List<Vilain> Acolytes
        {
            get
            {
                return _acolytes;
            }

            set
            {
                _acolytes = value;
            }
        }
    }
}
