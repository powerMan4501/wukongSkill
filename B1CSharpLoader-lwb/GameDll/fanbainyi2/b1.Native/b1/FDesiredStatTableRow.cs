using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.DesiredStatTableRow", "b1", UnrealModuleType.Game)]
public struct FDesiredStatTableRow
{
	private static bool Label_IsValid;

	private static int Label_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/b1.DesiredStatTableRow:Label")]
	public string Label;

	private static bool Threshold_IsValid;

	private static int Threshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.DesiredStatTableRow:Threshold")]
	public float Threshold;

	private static bool FDesiredStatTableRow_IsValid;

	private static int FDesiredStatTableRow_StructSize;

	public FDesiredStatTableRow Copy()
	{
		return this;
	}

	public static FDesiredStatTableRow FromNative(IntPtr nativeBuffer)
	{
		return new FDesiredStatTableRow(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDesiredStatTableRow value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDesiredStatTableRow FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDesiredStatTableRow(nativeBuffer + arrayIndex * FDesiredStatTableRow_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDesiredStatTableRow value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDesiredStatTableRow_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDesiredStatTableRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.DesiredStatTableRow");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Label_Offset), Label);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Threshold_Offset), Threshold);
	}

	public FDesiredStatTableRow(IntPtr nativeStruct)
	{
		if (!FDesiredStatTableRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.DesiredStatTableRow");
			Label = FStringMarshaler.DefaultString;
			Threshold = 0f;
		}
		else
		{
			Label = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Label_Offset));
			Threshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Threshold_Offset));
		}
	}

	static FDesiredStatTableRow()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDesiredStatTableRow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDesiredStatTableRow));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.DesiredStatTableRow");
		FDesiredStatTableRow_StructSize = NativeReflection.GetStructSize(intPtr);
		Label_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Label");
		Label_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Label", Classes.FStrProperty);
		Threshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Threshold");
		Threshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Threshold", Classes.FFloatProperty);
		FDesiredStatTableRow_IsValid = intPtr != IntPtr.Zero && Label_IsValid && Threshold_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.DesiredStatTableRow", FDesiredStatTableRow_IsValid);
	}
}
