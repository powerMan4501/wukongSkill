using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

[StructLayout(LayoutKind.Sequential, Size = 8)]
[UStruct(Flags = 57857)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.ColorBufferPtr", "UnrealExtent", UnrealModuleType.Game)]
public struct FColorBufferPtr
{
	private static bool B_IsValid;

	private static int B_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.ColorBufferPtr:B")]
	public byte B;

	private static bool G_IsValid;

	private static int G_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.ColorBufferPtr:G")]
	public byte G;

	private static bool R_IsValid;

	private static int R_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.ColorBufferPtr:R")]
	public byte R;

	private static bool A_IsValid;

	private static int A_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.ColorBufferPtr:A")]
	public byte A;

	private static bool AlignmentDummy_IsValid;

	private static int AlignmentDummy_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.ColorBufferPtr:AlignmentDummy")]
	public int AlignmentDummy;

	private static int FColorBufferPtr_StructSize;

	public FColorBufferPtr Copy()
	{
		return this;
	}

	static FColorBufferPtr()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FColorBufferPtr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FColorBufferPtr));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/UnrealExtent.ColorBufferPtr");
		FColorBufferPtr_StructSize = NativeReflection.GetStructSize(unrealStruct);
		B_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "B");
		B_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "B", Classes.FByteProperty);
		G_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "G");
		G_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "G", Classes.FByteProperty);
		R_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "R");
		R_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "R", Classes.FByteProperty);
		A_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "A");
		A_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "A", Classes.FByteProperty);
		AlignmentDummy_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AlignmentDummy");
		AlignmentDummy_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AlignmentDummy", Classes.FIntProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FColorBufferPtr));
	}
}
