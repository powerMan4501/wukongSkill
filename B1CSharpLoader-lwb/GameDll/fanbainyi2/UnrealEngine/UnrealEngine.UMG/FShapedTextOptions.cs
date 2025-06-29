using System;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/UMG.ShapedTextOptions", "UMG", UnrealModuleType.Engine)]
public struct FShapedTextOptions
{
	private static bool TextShapingMethod_IsValid;

	private static FFieldAddress TextShapingMethod_PropertyAddress;

	private static int TextShapingMethod_Offset;

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.ShapedTextOptions:TextShapingMethod")]
	public ETextShapingMethod TextShapingMethod;

	private static bool TextFlowDirection_IsValid;

	private static FFieldAddress TextFlowDirection_PropertyAddress;

	private static int TextFlowDirection_Offset;

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.ShapedTextOptions:TextFlowDirection")]
	public ETextFlowDirection TextFlowDirection;

	private static bool FShapedTextOptions_IsValid;

	private static int FShapedTextOptions_StructSize;

	public FShapedTextOptions Copy()
	{
		return this;
	}

	public static FShapedTextOptions FromNative(IntPtr nativeBuffer)
	{
		return new FShapedTextOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FShapedTextOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FShapedTextOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FShapedTextOptions(nativeBuffer + arrayIndex * FShapedTextOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FShapedTextOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FShapedTextOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FShapedTextOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.ShapedTextOptions");
			return;
		}
		EnumMarshaler<ETextShapingMethod>.ToNative(IntPtr.Add(nativeStruct, TextShapingMethod_Offset), 0, TextShapingMethod_PropertyAddress.Address, TextShapingMethod);
		EnumMarshaler<ETextFlowDirection>.ToNative(IntPtr.Add(nativeStruct, TextFlowDirection_Offset), 0, TextFlowDirection_PropertyAddress.Address, TextFlowDirection);
	}

	public FShapedTextOptions(IntPtr nativeStruct)
	{
		if (!FShapedTextOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.ShapedTextOptions");
			TextShapingMethod = ETextShapingMethod.Auto;
			TextFlowDirection = ETextFlowDirection.Auto;
		}
		else
		{
			TextShapingMethod = EnumMarshaler<ETextShapingMethod>.FromNative(IntPtr.Add(nativeStruct, TextShapingMethod_Offset), 0, TextShapingMethod_PropertyAddress.Address);
			TextFlowDirection = EnumMarshaler<ETextFlowDirection>.FromNative(IntPtr.Add(nativeStruct, TextFlowDirection_Offset), 0, TextFlowDirection_PropertyAddress.Address);
		}
	}

	static FShapedTextOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FShapedTextOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FShapedTextOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UMG.ShapedTextOptions");
		FShapedTextOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref TextShapingMethod_PropertyAddress, intPtr, "TextShapingMethod");
		TextShapingMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextShapingMethod");
		TextShapingMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextShapingMethod", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref TextFlowDirection_PropertyAddress, intPtr, "TextFlowDirection");
		TextFlowDirection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextFlowDirection");
		TextFlowDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextFlowDirection", Classes.FEnumProperty);
		FShapedTextOptions_IsValid = intPtr != IntPtr.Zero && TextShapingMethod_IsValid && TextFlowDirection_IsValid;
		NativeReflection.LogStructIsValid("/Script/UMG.ShapedTextOptions", FShapedTextOptions_IsValid);
	}
}
