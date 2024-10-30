namespace BandsMVC.Models;

public class Band
{
    public Band(int id, string name, string description, string img, string youtubeUrl)
    {
        Id = id;
        Name = name;
        Description = description;
        ImgUrl = img;
        YoutubeUrl = youtubeUrl;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImgUrl { get; set; }
    public string YoutubeUrl { get; set; }

}