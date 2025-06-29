using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

[StructLayout(LayoutKind.Sequential, Size = 16)]
[UStruct(Flags = 583739)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.IntVector4", "CoreUObject", UnrealModuleType.Engine)]
public struct FIntVector4
{
	private static bool X_IsValid;

	private static int X_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.IntVector4:X")]
	public int X;

	private static bool Y_IsValid;

	private static int Y_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.IntVector4:Y")]
	public int Y;

	private static bool Z_IsValid;

	private static int Z_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.IntVector4:Z")]
	public int Z;

	private static bool W_IsValid;

	private static int W_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.IntVector4:W")]
	public int W;

	private static int FIntVector4_StructSize;

	public FIntVector4 Copy()
	{
		return this;
	}

	static FIntVector4()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FIntVector4)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FIntVector4));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.IntVector4");
		FIntVector4_StructSize = NativeReflection.GetStructSize(unrealStruct);
		X_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "X");
		X_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "X", Classes.FIntProperty);
		Y_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Y");
		Y_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Y", Classes.FIntProperty);
		Z_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Z");
		Z_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Z", Classes.FIntProperty);
		W_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "W");
		W_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "W", Classes.FIntProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FIntVector4));
	}
}
