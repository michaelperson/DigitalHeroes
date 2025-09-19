using DigitalHeroes.Models.Exceptions;

namespace DigitalHeroes.Models
{
    public class Heros
    {
        private string _nom;
        private string _prenom;
        private string _nomSuperHero;
        private DateOnly _dateDeNaissance;
        private DateOnly _dateTransformation;
        private string _circonstances;
        private List<string> _pointsFaibles;
        private int _force;

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

        public string NomSuperHero
        {
            get
            {
                return _nomSuperHero;
            }

            set
            {
                _nomSuperHero = value;
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
                _dateDeNaissance = value;
            }
        }

        public DateOnly DateTransformation
        {
            get
            {
                return _dateTransformation;
            }

            set
            {
                _dateTransformation = value;
            }
        }

        public string Circonstances
        {
            get
            {
                return _circonstances;
            }

            set
            {
                _circonstances = value;
            }
        }

        public List<string> PointsFaibles
        {
            get
            {
                return _pointsFaibles;
            }

            set
            {
                _pointsFaibles = value;
            }
        }

        public int Force
        {
            get
            {
                return _force;
            }

            set
            {
                if(value<0 || value>100)
                {
                    throw new InvalidPowerValueException();
                }
                _force = value;
            }
        }
    }
}
