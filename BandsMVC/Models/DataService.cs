namespace BandsMVC.Models;

public class DataService
{
    List<Band> bands = [

    new Band (1, "Amon Amart", "Swedish Viking death Metal band, from Tumba"),
    new Band (2, "Rolling Stones", "Classic rock & Roll band from forever"),
    new Band (3, "Mora Träsk", "Epic musicgroup, fromed in 1971"),
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