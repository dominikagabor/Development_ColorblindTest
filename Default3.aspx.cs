using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    static int pro = 0;
    static int deu = 0;
    static int czez = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        Sprawdz();
        Wynik();
        Zeruj();
    }

    private void Sprawdz()
    {

        for (int a = 0; a < 4; a++)
        {
            if (Class2.Goodscores[a] != Class2.Userscores[a])
            {
                pro++;
            }
        }

        for (int a = 4; a < 8; a++)
        {
            if (Class2.Goodscores[a] != Class2.Userscores[a])
            {
                deu++;
            }
        }

        for (int a = 8; a < 12; a++)
        {
            if (Class2.Goodscores[a] != Class2.Userscores[a])
            {
                czez++;
            }
        }
    }

    private void Wynik()
    {
        Label13.Text = pro.ToString();

        Label15.Text = deu.ToString();

        Label17.Text = czez.ToString();

        Label19.Text = (12 - pro - deu - czez).ToString();
    }
    private void Zeruj()
    {
        pro = 0;
        deu = 0;
        czez = 0;
    }

}