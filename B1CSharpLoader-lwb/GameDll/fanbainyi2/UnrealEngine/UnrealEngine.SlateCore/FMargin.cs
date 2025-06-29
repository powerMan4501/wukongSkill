using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[StructLayout(LayoutKind.Sequential, Size = 16)]
[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.Margin", "SlateCore", UnrealModuleType.Engine)]
public struct FMargin
{
	private static bool Left_IsValid;

	private static int Left_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.Margin:Left")]
	public float Left;

	private static bool Top_IsValid;

	private static int Top_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.Margin:Top")]
	public float Top;

	private static bool Right_IsValid;

	private static int Right_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.Margin:Right")]
	public float Right;

	private static bool Bottom_IsValid;

	private static int Bottom_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.Margin:Bottom")]
	public float Bottom;

	private static int FMargin_StructSize;

	public FMargin Copy()
	{
		return this;
	}

	static FMargin()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMargin)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMargin));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/SlateCore.Margin");
		FMargin_StructSize = NativeReflection.GetStructSize(unrealStruct);
		Left_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Left");
		Left_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Left", Classes.FFloatProperty);
		Top_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Top");
		Top_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Top", Classes.FFloatProperty);
		Right_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Right");
		Right_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Right", Classes.FFloatProperty);
		Bottom_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Bottom");
		Bottom_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Bottom", Classes.FFloatProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FMargin));
	}
}
