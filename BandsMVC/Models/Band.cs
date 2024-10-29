﻿namespace BandsMVC.Models;

public class Band
{
    public Band(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public int Id { get; set; }
    public String Name { get; set; }
    public string Description { get; set; }

    
}
