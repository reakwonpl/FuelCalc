using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCalc
{
    class koszt
    {
        private double _dlugoscTrasy;
        private double _srednieSpalanie;
        private double _cenaPaliwa;

        public koszt(double dlugoscTrasy, double srednieSpalanie, double cenaPaliwa)
        {
            this._cenaPaliwa = cenaPaliwa;
            this._dlugoscTrasy = dlugoscTrasy;
            this._srednieSpalanie = srednieSpalanie;
        }
        public double dlugoscTrasy
        {
            get { return this._dlugoscTrasy; }
        }
        public double cenaPaliwa
        {
            get{return this._cenaPaliwa;}
        }
        public double srednieSpalanie
        {
            get { return this._srednieSpalanie; }
        }
        public double wynikKosztu
        {
            get
            {
             double indeksKoszt = (((this._dlugoscTrasy / 100) * this._srednieSpalanie) * this._cenaPaliwa);
             return indeksKoszt;
            }
        }
        public double iloscPaliwa
        {
            get
            {
                double indeksPaliwo = ((this._dlugoscTrasy / 100) * this._srednieSpalanie);
                return indeksPaliwo;
            }
        }
    }
    
}
