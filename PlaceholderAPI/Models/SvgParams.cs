using PlaceholderImageAPI.Helpers;

namespace PlaceholderImageAPI.Models
{
    public class SvgParams
	{
		public int Width { get; set; } = 500;
        public int Height { get; set; } = 500;
		public int BorderRadius { get; set; }
        public string BgColor { get; set; } = RandomColors.GenerateRandomHexColor();
        public string TextContent { get; set; } = string.Empty;
        public string TextColor { get; set; } = RandomColors.GenerateRandomHexColor();
		public int FontSize { get; set; } = 24;
		public string FontWeight { get; set; } = string.Empty;
		public string StrokeColor { get; set; } = RandomColors.GenerateRandomHexColor();
		public int StrokeThickness { get; set; } = 0;
	}
}
