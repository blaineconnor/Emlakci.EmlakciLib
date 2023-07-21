namespace Emlakci.EmlakciLib
{
    public abstract class Ev
    {
        #region Fields

        private int odasayisi;
        private int katno;
        private string semt;
        private double alan;

        #endregion

        #region Constructors

        protected Ev()
        {

        }

        protected Ev(int odasayisi, int katno, string semt, double alan)
        {
            Odasayisi = odasayisi;
            Katno = katno;
            Semt = semt;
            Alan = alan;
        }

        #endregion

        #region Properties
        public int Odasayisi { get => odasayisi; set => odasayisi = Math.Abs(value); }
        public int Katno { get => katno; set => katno = value; }
        public string Semt
        {
            get => semt;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Semt bilgisi boş olamaz");
                }
                semt = value.Trim().ToUpper();
            }
        }
        public double Alan { get => alan; set => alan = Math.Abs(value); }

        #endregion

        #region Methods

        public virtual string EvBilgileriniGetir()
        {
            return $"Katno : {Katno}\nSemt : {Semt}\nOdasayısı : {Odasayisi}\nAlan : {Alan}";
        }

        #endregion
    }
}
