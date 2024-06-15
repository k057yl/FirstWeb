﻿namespace FirstWeb.Models;

public class Food
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public int PetId { get; set; }
    public virtual Pet Pet { get; set; }
}