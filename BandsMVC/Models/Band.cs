﻿namespace BandsMVC.Models;

public class Band
{
    public Band(int id, string name, string description, string img)
    {
        Id = id;
        Name = name;
        Description = description;
        ImgUrl = img;
    }

    public int Id { get; set; }
    public String Name { get; set; }
    public string Description { get; set; }
    public string ImgUrl { get; set; }

    
}
