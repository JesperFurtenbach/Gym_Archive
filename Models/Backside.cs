using System.ComponentModel.DataAnnotations;

public class Back
{
        [Display(Name = "Lateral Pulley")]
        public string LatPulley { get; set; }
        [Display(Name = "Dumbell Row")]
        public string DumbellRow { get; set; }
        [Display(Name = "Lateral Pulldown F")]
        public string LateralPulldownsF { get; set; }
        [Display(Name = "Lateral Pulldown B")]
        public string LateralPulldownsB { get; set; }
        public string Bältet { get; set; }
        public string Chins { get; set; }
        [Display(Name = "Pilatus Prayer")]
        public string PilatusPrayer { get; set; }
}