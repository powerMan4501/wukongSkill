using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;

namespace b1.UI.Comm;

public class FTextConfigCS
{
	public FAnchors Anchors;

	public FVector2D Alignment;

	public FVector2D Pos;

	public FSlateColor Color;

	public bool UseFontSize;

	public int FontSize;

	public bool UseLetterSpacing;

	public int LetterSpacing;

	public FVector2D ShadowOffset;

	public FLinearColor ShadowColor;

	public ETextJustify Justification;

	public FSlateFontInfo FontInfo;

	public Dictionary<ETextColorType, FSlateColor> ColorMap;
}
