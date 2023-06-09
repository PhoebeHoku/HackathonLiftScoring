﻿using System.ComponentModel.DataAnnotations;

namespace LiftScoring.Models;
public class LifterModel
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public bool isFemale { get; set; }
    public double DeadLift { get; set; }
    public double SquatLift { get; set; }
    public double BenchLift { get; set; }
    public double OverheadPressLift { get; set; }
    public double CurlLift { get; set; }
    public double RowLift { get; set; }

}