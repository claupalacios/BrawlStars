using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TC_Vehiculos.Models
{
    public partial class Player
    {
    public PlayerClub club { get; set; }
    public int victories3vs3 { get; set; }
    public bool isQualifiedFromChampionshipChallenge { get; set; }
    public PlayerIcon icon { get; set; }
    public string tag { get; set; }
    public string name { get; set; }
    public int trophies { get; set; }
    public int expLevel { get; set; }
    public int expPoints { get; set; }
    public int highestTrophies { get; set; }
    public int powerPlayPoints { get; set; }
    public int highestPowerPlayPoints { get; set; }
    public int soloVictories { get; set; }
    public int duoVictories { get; set; }
    public int bestRoboRumbleTime { get; set; }
    public int bestTimeAsBigBrawler { get; set; }
    public List<Brawlers> brawlers { get; set; }
    public string nameColor { get; set; }
}
}
