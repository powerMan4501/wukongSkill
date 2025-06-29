using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

[StructLayout(LayoutKind.Sequential, Size = 8)]
[UStruct(Flags = 57857)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.IntPtr", "UnrealExtent", UnrealModuleType.Game)]
public struct FIntPtr
{
	private static bool LowerBits_IsValid;

	private static int LowerBits_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.IntPtr:LowerBits")]
	public int LowerBits;

	private static bool HigherBits_IsValid;

	private static int HigherBits_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.IntPtr:HigherBits")]
	public int HigherBits;

	private static int FIntPtr_StructSize;

	public FIntPtr Copy()
	{
		return this;
	}

	static FIntPtr()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FIntPtr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FIntPtr));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/UnrealExtent.IntPtr");
		FIntPtr_StructSize = NativeReflection.GetStructSize(unrealStruct);
		LowerBits_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LowerBits");
		LowerBits_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LowerBits", Classes.FIntProperty);
		HigherBits_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HigherBits");
		HigherBits_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HigherBits", Classes.FIntProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FIntPtr));
	}
}
