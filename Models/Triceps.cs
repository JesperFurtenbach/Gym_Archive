using System.ComponentModel.DataAnnotations;

public class Triceps
{
    public string Extensions { get; set; }    
    [Display(Name = "Forward Extensions")]
    public string FExtensions { get; set; }
    [Display(Name = "Overhead Rep Extensions")]
     public string OverheadRepExt { get; set; }
    [Display(Name = "Liggande Extensions")]
     public string LiggandeExt { get; set; }
     [Display(Name = "Triceps Pushups")]
     public string TricepPushups { get; set; }
    [Display(Name = "Overhead Dumbell Extensions")]
     public string OverheadDumbellExt { get; set; } 
}