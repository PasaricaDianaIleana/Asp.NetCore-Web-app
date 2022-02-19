using System.ComponentModel.DataAnnotations;

namespace OnlineStore.ViewsModel.ColorViewModels
{
    public class CreateColorViewModel
    {
        [Required]
        public string ColorName { get; set; }

        [Required]
        public string HexValue { get; set; }
    }
}
