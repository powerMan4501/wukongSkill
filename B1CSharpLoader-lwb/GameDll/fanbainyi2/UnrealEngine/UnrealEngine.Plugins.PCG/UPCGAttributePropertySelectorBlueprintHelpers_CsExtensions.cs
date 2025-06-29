using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

public static class UPCGAttributePropertySelectorBlueprintHelpers_CsExtensions
{
	public static bool SetPointProperty(this ref FPCGAttributePropertySelector Selector, EPCGPointProperties InPointProperty)
	{
		return UPCGAttributePropertySelectorBlueprintHelpers.SetPointProperty(ref Selector, InPointProperty);
	}

	public static bool SetExtraProperty(this ref FPCGAttributePropertySelector Selector, EPCGExtraProperties InExtraProperty)
	{
		return UPCGAttributePropertySelectorBlueprintHelpers.SetExtraProperty(ref Selector, InExtraProperty);
	}

	public static bool SetAttributeName(this ref FPCGAttributePropertySelector Selector, FName InAttributeName)
	{
		return UPCGAttributePropertySelectorBlueprintHelpers.SetAttributeName(ref Selector, InAttributeName);
	}

	public static EPCGAttributePropertySelection GetSelection(this FPCGAttributePropertySelector Selector)
	{
		return UPCGAttributePropertySelectorBlueprintHelpers.GetSelection(Selector);
	}

	public static EPCGPointProperties GetPointProperty(this FPCGAttributePropertySelector Selector)
	{
		return UPCGAttributePropertySelectorBlueprintHelpers.GetPointProperty(Selector);
	}

	public static FName GetName(this FPCGAttributePropertySelector Selector)
	{
		return UPCGAttributePropertySelectorBlueprintHelpers.GetName(Selector);
	}

	public static EPCGExtraProperties GetExtraProperty(this FPCGAttributePropertySelector Selector)
	{
		return UPCGAttributePropertySelectorBlueprintHelpers.GetExtraProperty(Selector);
	}

	public static List<string> GetExtraNames(this FPCGAttributePropertySelector Selector)
	{
		return UPCGAttributePropertySelectorBlueprintHelpers.GetExtraNames(Selector);
	}

	public static FName GetAttributeName(this FPCGAttributePropertySelector Selector)
	{
		return UPCGAttributePropertySelectorBlueprintHelpers.GetAttributeName(Selector);
	}

	public static FPCGAttributePropertyOutputSelector CopyAndFixSource(this FPCGAttributePropertyOutputSelector Selector, FPCGAttributePropertyInputSelector InSelector)
	{
		return UPCGAttributePropertySelectorBlueprintHelpers.CopyAndFixSource(Selector, InSelector);
	}

	public static FPCGAttributePropertyInputSelector CopyAndFixLast(this FPCGAttributePropertyInputSelector Selector, UPCGData InData)
	{
		return UPCGAttributePropertySelectorBlueprintHelpers.CopyAndFixLast(Selector, InData);
	}
}
