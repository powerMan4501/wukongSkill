using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

[StructLayout(LayoutKind.Sequential, Size = 8)]
[UStruct(Flags = 57352)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.FrameRate", "CoreUObject", UnrealModuleType.Engine)]
public struct FFrameRate
{
	private static bool Numerator_IsValid;

	private static int Numerator_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.FrameRate:Numerator")]
	public int Numerator;

	private static bool Denominator_IsValid;

	private static int Denominator_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.FrameRate:Denominator")]
	public int Denominator;

	private static int FFrameRate_StructSize;

	public FFrameRate Copy()
	{
		return this;
	}

	static FFrameRate()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFrameRate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFrameRate));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.FrameRate");
		FFrameRate_StructSize = NativeReflection.GetStructSize(unrealStruct);
		Numerator_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Numerator");
		Numerator_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Numerator", Classes.FIntProperty);
		Denominator_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Denominator");
		Denominator_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Denominator", Classes.FIntProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FFrameRate));
	}
}
