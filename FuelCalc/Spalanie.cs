using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCalc
{
    class Spalanie
    {
        private double _iloscPaliwa;
        private double _przejechaneKilometry;
        

        public Spalanie(double iloscPaliwa, double przejchaneKilometry)
        {
            this._iloscPaliwa = iloscPaliwa;
            this._przejechaneKilometry = przejchaneKilometry;
           
        }
        public double iloscPaliwa
        {
            get  { return this._iloscPaliwa; }
        }
        

        public double  przejechaneKilometry
        {
            get{ return this._przejechaneKilometry; }
        }

        
        public double wynikSpalania
        {
            get
            {
                double indeksSpalania = ((this._iloscPaliwa / this._przejechaneKilometry) * 100);
                return indeksSpalania;
            }
        }
        
    }
    
}
