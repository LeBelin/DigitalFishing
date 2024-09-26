using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFishing
{
    public class Pigiste
    {

        private string _nom;
        private double _salaire;

        public double Salaire
        {
            get { return _salaire; }
            set { _salaire = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public Pigiste(string nm, double sl)
        {
            _nom = nm;
            _salaire = sl;
        }

        public double calcRemu()
        {
            return _salaire * 0.8;
        }
    }
}