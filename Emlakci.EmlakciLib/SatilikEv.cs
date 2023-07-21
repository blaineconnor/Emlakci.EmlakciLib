using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlakci.EmlakciLib
{
    public class SatilikEv : Ev
    {
        #region Fields

        double fiyat;

        #endregion

        #region Constructors
        public SatilikEv()
        {

        }

        public SatilikEv(int odasayisi, int katno, string semt, double alan, double fiyat)
            : base(odasayisi, katno, semt, alan)
        {
            Fiyat = fiyat;
        }
        #endregion

        #region Properties

        public double Fiyat { get => fiyat; set => fiyat = Math.Abs(value); }

        #endregion

        #region Methods

        public override string EvBilgileriniGetir()
        {
            return $"{base.EvBilgileriniGetir()}\nFiyat : {Fiyat}";
        } 

        #endregion
    }
}
