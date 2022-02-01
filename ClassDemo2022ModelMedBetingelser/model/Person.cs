using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2022ModelMedBetingelser.model
{
    public class Person
    {
        private int _id;
        private string _name;
        private string _adresse;
        private int _alder;

        public Person():this(0,"","",0)
        {
        }

        public Person(int id, string name, string adresse, int alder)
        {
            _id = id;
            _name = name;
            _adresse = adresse;
            Alder = alder;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Adresse
        {
            get => _adresse;
            set => _adresse = value;
        }

        /*
         * Betingelse alder skal være fra 0-130
         */
        public int Alder
        {
            get => _alder;
            set
            {
                CheckAlder(value);
                _alder = value;
            }
        }

        private void CheckAlder(int alder)
        {
            if (alder < 0 || 130 < alder)
            {
                throw new ArgumentException("Alder must be between 0-130 but was " + alder);
            }

        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Adresse)}: {Adresse}, {nameof(Alder)}: {Alder}";
        }
    }
}
