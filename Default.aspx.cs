using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    static int protnaopia = 0;
    static int deuteranopia = 0;
    static int czerziel = 0;
    static int normalnie = 0;
    static int brakodp = 0;

    // 12 elementowa klasa
    private Class1[] tablica = { new Class1("http://calcoolator.pl/images/rozrywka/ishihara/02.png", "3", "8", "6", "5", "7"),
    new Class1("http://calcoolator.pl/images/rozrywka/ishihara/03.png", "16", "26", "5", "6", "45"),
    new Class1("http://calcoolator.pl/images/rozrywka/ishihara/04.png", "29", "18", "19", "25", "59"),
    new Class1("http://calcoolator.pl/images/rozrywka/ishihara/05.png", "61", "57", "73", "37", "94"),
    new Class1("http://calcoolator.pl/images/rozrywka/ishihara/06.png", "3", "6", "2", "5", "23"),
    new Class1("http://calcoolator.pl/images/rozrywka/ishihara/07.png", "3", "5", "8", "6", "9"),
    new Class1("http://calcoolator.pl/images/rozrywka/ishihara/08.png", "15", "75", "8", "17", "9"),
    new Class1("http://calcoolator.pl/images/rozrywka/ishihara/09.png", "72", "21", "24", "74", "45"),
    new Class1("http://calcoolator.pl/images/rozrywka/ishihara/14.png", "3", "4", "5", "6", "9"),
    new Class1("http://calcoolator.pl/images/rozrywka/ishihara/15.png", "4", "6", "1", "7", "9"),
    new Class1("http://calcoolator.pl/images/rozrywka/ishihara/16.png", "26", "16", "76", "45", "78"),
    new Class1("http://calcoolator.pl/images/rozrywka/ishihara/17.png", "73", "28", "19", "13", "21")
};

    // 1 bo po przycisku button2 zaczynamy od pierwszego elementu, zerowy byl w button1
    static int jakis = 0;




    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");
    }
}