namespace BandsMVC.Models;

public class DataService
{
    List<FavoriteBand> favoriteBands = [

    new FavoriteBand (1, "Amon Amart", "Swedish Viking death Metal band, from Tumba"),
    new FavoriteBand (2, "Rolling Stones", "Classic rock & Roll band from forever"),
    new FavoriteBand (3, "Mora Träsk", "Epic musicgroup, fromed in 1971"),
    ];

    public FavoriteBand Get(int id)
    {
        var ret = favoriteBands.FirstOrDefault(o => o.Id == id);
        return ret;
    }



}
