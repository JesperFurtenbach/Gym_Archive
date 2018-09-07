using System.ComponentModel.DataAnnotations;

public class Shoulders
{

        [Display(Name = "Militär Press F")]
        public string MilitärPressF { get; set; }
        [Display(Name = "Militär Press B")]
        public string MilitärpressB { get; set; }
        public string Axellyft { get; set; }
        [Display(Name = "Axellyft F")]
        public string AxellyftF { get; set; }

        [Display(Name = "Axellyft B")]
        public string AxellyftB { get; set; }
        [Display(Name = "Car Driver")]
        public string CarDriver { get; set; }
        [Display(Name = "Hovering Dragon")]
        public string HoveringDragon { get; set; }
        public string Sidlyft { get; set; }
        public string Fladderballe { get; set; }
        public string Fladderarsel { get; set; }
        [Display(Name = "Kabel Kross")]
        public string Kabelkross { get; set; }
        [Display(Name = "Flappy Scarecrow")]
        public string FlappyScarecrow { get; set; }
        [Display(Name = "Lateral Rise")]
        public string LateralRise { get; set; }
}
