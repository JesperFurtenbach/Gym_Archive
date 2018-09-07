using System.ComponentModel.DataAnnotations;

public class Biceps
    {
        public string Curls { get; set; }
        [Display(Name = "Neutral Curles")]
        public string Ncurls { get; set; }
        [Display(Name = "Twist Curls")]
        public string TwistCurls { get; set; }
        [Display(Name = "3 Part Curls")]
        public string ThreePartCurls { get; set; }
        [Display(Name = "Overhead Curls")]
        public string OverheadCurls { get; set; }
        public string RopeCurls { get; set; }
        [Display(Name = "Bicep Pulldowns")]
        public string BicepPulldowns { get; set; }


    }