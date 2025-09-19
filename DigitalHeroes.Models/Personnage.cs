using DigitalHeroes.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalHeroes.Models
{
    public class Personnage
    {
        private string _nom;
        private string _prenom;
        private DateOnly _dateDeNaissance;

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;
            }
        }

        public DateOnly DateDeNaissance
        {
            get
            {
                return _dateDeNaissance;
            }

            set
            {
                if (value > DateOnly.FromDateTime(DateTime.Now.AddYears(-3)))
                {
                    throw new TooYoungException();
                }
                    _dateDeNaissance = value;
            }
        }
    }
}
