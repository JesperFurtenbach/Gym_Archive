using System.ComponentModel.DataAnnotations;

public class Chest
{
        public string Bänk { get; set; }

        [Display(Name = "Negativ Bänk")]
        public string NegativBänk { get; set; }
        [Display(Name = "Lutande Bänk")]
        public string LutandeBänk { get; set; }
        [Display(Name = "Shyamaland Bearhug")]
        public string Shyamalan { get; set; }
        public string Chestflies { get; set; }
        [Display(Name = "Dumbell Bänk")]
        public string DumbellBänk { get; set; }
        [Display(Name = "Dumbell Pushups")]
        public string DumbellPushups { get; set; }
}
