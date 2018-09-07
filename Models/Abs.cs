using System.ComponentModel.DataAnnotations;

public class Abdominal
{
        [Display(Name = "Hängande Ben Twist")]
        public string HBT { get; set; }
        [Display(Name = "Ben Saxen")]
        public string BenSaxen { get; set; }
        [Display(Name = "Fot Paddel")]
        public string FotPaddel { get; set; }
        [Display(Name = "Liggande Cyckel")]
        public string LiggandeCyckel { get; set; }
        public string Pingvinen { get; set; }
        public string  AbCrunches { get; set; }

        [Display(Name = "Failed Felatio")]
        public string FailedFelaton { get; set; }
        

    
}
