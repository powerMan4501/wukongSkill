using UnrealEngine.Runtime;

namespace b1;

public struct RichTextIconData
{
	public string Name;

	public FVector2D Size;

	public string ResourceObject;

	public RichTextIconData(string InName, FVector2D InSize, string InResourceObject)
	{
		Name = InName;
		Size = InSize;
		ResourceObject = InResourceObject;
	}

	public string ToJson()
	{
		return $"{{\"Name\": \"{Name}\", \"Brush\": {{ \"ImageSize\": {{ \"X\": {Size.X}, \"Y\": {Size.Y} }}, \"Margin\": {{ \"Left\": 0, \"Top\": 0, \"Right\": 0, \"Bottom\": 0 }}, \"Tint\": {{ \"R\": 1, \"G\": 1, \"B\": 1, \"A\": 1 }}, \"TintColor\": {{ \"SpecifiedColor\": {{ \"R\": 1, \"G\": 1, \"B\": 1, \"A\": 1 }}, \"ColorUseRule\": \"UseColor_Specified\" }}, \"OutlineSettings\": {{ \"CornerRadii\": {{ \"X\": 0, \"Y\": 0, \"Z\": 0, \"W\": 1 }}, \"Color\": {{ \"SpecifiedColor\": {{ \"R\": 0, \"G\": 0, \"B\": 0, \"A\": 0 }}, \"ColorUseRule\": \"UseColor_Specified\"}}, \"Width\": 0, \"RoundingType\": \"HalfHeightRadius\" }}, \"ResourceObject\": \"{ResourceObject}\", \"ResourceName\": \"None\", \"UVRegion\": {{ \"Min\": {{ \"X\": 0, \"Y\": 0 }}, \"Max\": {{ \"X\": 0, \"Y\": 0 }}, \"bIsValid\": 0 }}, \"DrawAs\": \"Image\", \"Tiling\": \"NoTile\", \"Mirroring\": \"NoMirror\", \"ImageType\": \"NoImage\", \"bIsDynamicallyLoaded\": false, \"bHasUObject\": false }} }},";
	}
}
