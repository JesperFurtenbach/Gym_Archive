using System.ComponentModel.DataAnnotations;

public class Abdominal
{
public enum Abs
    {
        [Display(Name = "Hängande Ben Twist")]
        Hbt,
        [Display(Name = "Ben Saxen")]
        BenSaxen,
        [Display(Name = "Fot Paddel")]
        FotPaddel,
        [Display(Name = "Liggande Cycle")]
        LiggandeCyckle,
        Pingvingen,
        AbCrunches,

        [Display(Name = "Failed Felatio")]
        Failedfelatio

    }
}
