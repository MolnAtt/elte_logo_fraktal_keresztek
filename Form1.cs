using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		
		void FELADAT()
		{
			Keresztek(200, 4);
		}

		void Keresztek(double hossz, int szint)
		{
			Balra_Vonalcsillag(hossz / 2, 3, 60, szint);

            for (int i = 0; i < 3; i++)//#ism#//
            {
				Szakasz(hossz, szint);
				Menj_ide_fraktálozni(hossz/2, hossz, szint);
				Balra(120);
            }
		}

        void Menj_ide_fraktálozni(double ide, double hossz, int szint)
        {
			Előre(ide);
			Fraktál(hossz, szint);
			Hátra(ide);
        }

        void Fraktál(double hossz, int szint)
        {
            if (szint>1)
            {
				Tollszín(szint);
				Balra_Vonalcsillag(hossz / 4, 4, 45, szint);
                for (int i = 0; i < 4; i++)//#ism#//
                {
					Szakasz(hossz / 2, szint);
					Menj_ide_fraktálozni(hossz / 4, hossz / 3, szint - 1);
					Balra(90);
				}
			}
        }

        void Vonalcsillag(double hossz, int db, int szint) { double fok = 360 / db; for (int i = 0; i < db; i++) { Szakasz(hossz, szint); Balra(fok); } }
        void Balra_Vonalcsillag(double hossz, int db, double fok, int szint) { Balra(fok); Vonalcsillag(hossz, db, szint); Jobbra(fok); }
		void Szakasz(double ennyit, int szint) { Tollszín(szint); Előre(ennyit); Hátra(ennyit); }
    }
}
