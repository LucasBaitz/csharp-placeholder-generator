using Microsoft.AspNetCore.Mvc;
using PlaceholderAPI.Models;
using PlaceholderImageAPI.Models;

namespace PlaceholderImageAPI.Controllers
{
	[ApiController]
	[Route("[Controller]")]
	public class ImagesController : ControllerBase
	{
		[HttpGet]
		[Route("svg")]
		public IActionResult GetRectSvg([FromQuery] SvgParams svgRequest, [FromQuery] bool asContent = true)
		{
			var newSvg = new SVG()
			{
				Width = svgRequest.Width,
				Height = svgRequest.Height,
				BgColor = svgRequest.BgColor,
				BorderRadius = svgRequest.BorderRadius,
				TextColor = svgRequest.TextColor,
				TextContent = svgRequest.TextContent,
				FontSize = svgRequest.FontSize,
				StrokeColor = svgRequest.StrokeColor,
				StrokeThickness = svgRequest.StrokeThickness,
				FontWeight = svgRequest.FontWeight
			};
			return asContent ? Content(newSvg.SvgTag, "image/svg+xml") : Ok(newSvg.SvgTag);
		}

	}
}
