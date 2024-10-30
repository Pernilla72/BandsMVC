namespace BandsMVC.Models;

public class DataService
{
    List<Band> bands = [

    new Band (1, "Amon Amarth", "Swedish Viking death Metal band, from Tumba", "images/amon.jpg", "edBYB1VCV0k"),
    new Band (2, "Rolling Stones", "Classic rock & Roll band from forever", "images/roll.jpg", "nVrdXUHvsF0"),
    new Band (3, "Mora Träsk", "Epic musicgroup, fromed in 1971", "images/mora.jpg", "qajXgvnUEAA"),
    ];

    public Band GetBandById(int id)
    {
        var ret = bands.FirstOrDefault(o => o.Id == id);
        return ret;
    }
    public Band[] GetAllBands()
    {
        return bands.ToArray();
    }
}


//Källa uppgift 5b: https://learn.microsoft.com/en-us/aspnet/web-pages/overview/ui-layouts-and-themes/10-working-with-video