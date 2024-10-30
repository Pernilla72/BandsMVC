using System.Collections.Generic;

namespace BandsMVC.Models;

public class Band
{
    
    public Band(int id, string name, string description, string img, string youtubeUrl, List<string> albums)
    {
        Id = id;
        Name = name;
        Description = description;
        ImgUrl = img;
        YoutubeUrl = youtubeUrl;
        Albums = albums;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImgUrl { get; set; }
    public List<string> Albums { get; set; } // 5.A

    public string YoutubeUrl { get; set; }

}