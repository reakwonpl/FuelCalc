using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCalc
{
    class DziennikKosztow
    {
        private string _typKosztu;
        public double _Zaplata;
        private string _nazwaKosztu;

        public DziennikKosztow(string typKosztu, string nazwaKosztu, double Zaplata)
        {
            this._nazwaKosztu = nazwaKosztu;
            this._typKosztu = typKosztu;
            this._Zaplata = Zaplata;
        }

        public string typKosztu
        {
            get { return this._typKosztu; }
        }

        public string nazwaKosztu
        {
            get { return this._nazwaKosztu; }
        }

        public double zaplata
        {
            get { return this._Zaplata; }
        }

        public double calkowityKoszt
        {
            get
            {
                double indeksCalkowityKoszt = +zaplata;
                return indeksCalkowityKoszt;
            }
        }
               
    }
}
