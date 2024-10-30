namespace BandsMVC.Models;

public class DataService
{
    List<Band> bands = [

    new Band (1, "Amon Amart", "Swedish Viking death Metal band, from Tumba", "images/amon.jpg" ,new List<string> { "Twilight of the Thunder God", "Berserker", "Deceiver of the Gods" } ),
    new Band (2, "Rolling Stones", "Classic rock & Roll band from forever", "images/roll.jpg",new List<string> { "Hackney Diamonds", "Sticky Fingers", "The Rolling Stones" }),
    new Band (3, "Mora Träsk", "Epic musicgroup, fromed in 1971", "images/mora.jpg",new List<string> { "Mera Mora", "Sjung och lek med Mora Träsk", "FULL RULLE" }),
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