using System.ComponentModel.DataAnnotations;
public class Leg
{
        [Display(Name = "Forward Squats")]
        public string ForwardSquats { get; set; }
        public string Squats { get; set; }
        public string LegCurls { get; set; }
        public string LegExtensions { get; set; }
        [Display(Name = "Rotary Calf")]
        public string RotaryCalf { get; set; }
        [Display(Name = "The Lady")]
        public string TheLady { get; set; }
        [Display(Name = "The Manspreader")]
        public string ManSpreader { get; set; }    
}