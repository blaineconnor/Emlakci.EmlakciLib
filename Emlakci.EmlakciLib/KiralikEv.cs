using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlakci.EmlakciLib
{
    //Derived Base
    // public ve protected üyeler
    //is-a ilişkisi
    //KiralikEv is an Ev
    public class KiralikEv : Ev
    {
        #region Fields

        double depozito;
        double kira;

        #endregion

        #region Constructors

        public KiralikEv(int odasayisi, int katno, string semt, double alan, double depozito, double kira)
            : base(odasayisi, katno, semt, alan)
        {
            Depozito = depozito;
            Kira = kira;
        }

        public KiralikEv()
        {

        }

        #endregion

        #region Properties

        public double Depozito { get => depozito; set => depozito = value; }
        public double Kira { get => kira; set => kira = value; }

        #endregion

        #region Methods

        public override string EvBilgileriniGetir()
        {
            return $"{base.EvBilgileriniGetir()}\nDepozito : {Depozito}\nKira : {Kira}";
        }

        #endregion
    }
}
