namespace PlaceholderAPI.Models
{
    public class SVG
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int BorderRadius { get; set; }
        public string BgColor { get; set; } = string.Empty;
        public string TextContent { get; set; } = string.Empty;
        public string TextColor { get; set; } = string.Empty;
        public string FontWeight { get; set; } = string.Empty;
        public int FontSize { get; set; }
        public string StrokeColor { get; set; } = string.Empty;
        public int StrokeThickness { get; set; }
        public string SvgTag => BuildSvg();

        private string BuildSvg()
        {
            return @$"
                <svg width=""{Width}"" height=""{Height}"" xmlns=""http://www.w3.org/2000/svg"">
                    <rect width=""100%"" height=""100%"" fill=""{BgColor}"" rx=""{BorderRadius}"" stroke=""{StrokeColor}"" stroke-width=""{StrokeThickness}"" />
					<text x=""50%"" y=""50%"" text-anchor=""middle"" font-weight=""{FontWeight}"" alignment-baseline=""middle"" fill=""{TextColor}"" font-size=""{FontSize}px"">{TextContent}</text>
                </svg>
            ";
        }

    }
}
