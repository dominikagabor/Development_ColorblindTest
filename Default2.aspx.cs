using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    static int jakis = 0;



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

    protected void Page_Load(object sender, EventArgs e)
    {
        Rysuj(jakis);
    }

    private void Rysuj(int kery)
    {
        Image1.ImageUrl = tablica[kery].URL;
        R1.Text = tablica[kery].R1;
        R2.Text = tablica[kery].R2;
        R3.Text = tablica[kery].R3;
        R4.Text = tablica[kery].R4;
        R5.Text = tablica[kery].R5;

        R1.Checked = false;
        R2.Checked = false;
        R3.Checked = false;
        R4.Checked = false;
        R5.Checked = false;

    }

    private void NoticeScore()
    {
        if (R1.Checked == true) { Class2.Userscores[jakis] = R1.Text; }
        if (R2.Checked == true) { Class2.Userscores[jakis] = R2.Text; }
        if (R3.Checked == true) { Class2.Userscores[jakis] = R3.Text; }
        if (R4.Checked == true) { Class2.Userscores[jakis] = R4.Text; }
        if (R5.Checked == true) { Class2.Userscores[jakis] = R5.Text; }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (R1.Checked || R2.Checked || R3.Checked || R4.Checked || R5.Checked)
        {
            NoticeScore();
            jakis++;
            if (jakis == 12)
            {
                jakis = 0;
                SummarySource();            
            }
            else
            {
                Rysuj(jakis);
            }
        }
       


    }

    private void SummarySource()
    {
        Response.Redirect("Default3.aspx");
    }

    protected void R1_CheckedChanged(object sender, EventArgs e)
    {
        R1.Checked = true;
    }

    protected void R2_CheckedChanged(object sender, EventArgs e)
    {
        R2.Checked = true;
    }

    protected void R3_CheckedChanged(object sender, EventArgs e)
    {
        R3.Checked = true;
    }

    protected void R4_CheckedChanged(object sender, EventArgs e)
    {
        R4.Checked = true;
    }

    protected void R5_CheckedChanged(object sender, EventArgs e)
    {
        R5.Checked = true;
    }
}