using Emlakci.EmlakciLib;

namespace Emlakci.App
{
    class Program
    {
        static void Main()
        {
            //Ev ev1 = new Ev();

            //ev1.Alan = -120;
            //ev1.Semt = "yenimaHAlle";
            //ev1.Odasayisi = -4;
            //ev1.Katno = 3;

            //Ev ev1 = new Ev(-4, 3, "yenimaHAlle", -120);

            Ev ke1 = new KiralikEv
            {
                Kira = 5000,
                Depozito = 5000,
                Katno = 2,
                Semt = "BALGAT",
                Alan = 100,
                Odasayisi = 2
            };

            KiralikEv ke2 = new KiralikEv(2, 2, "Balgat", 100, 5000, 5000);

            SatilikEv se1 = new SatilikEv(2, 3, "ÇANKAYA", 90, 1500000);

            Console.WriteLine(se1.EvBilgileriniGetir());

        }
    }
}
