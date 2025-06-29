using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/b1.GSFloatValueTableRow", "b1", UnrealModuleType.Game)]
public struct FGSFloatValueTableRow
{
	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSFloatValueTableRow:Value")]
	public float Value;

	private static bool FGSFloatValueTableRow_IsValid;

	private static int FGSFloatValueTableRow_StructSize;

	public FGSFloatValueTableRow Copy()
	{
		return this;
	}

	public static FGSFloatValueTableRow FromNative(IntPtr nativeBuffer)
	{
		return new FGSFloatValueTableRow(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSFloatValueTableRow value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSFloatValueTableRow FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSFloatValueTableRow(nativeBuffer + arrayIndex * FGSFloatValueTableRow_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSFloatValueTableRow value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSFloatValueTableRow_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSFloatValueTableRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSFloatValueTableRow");
		}
		else
		{
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		}
	}

	public FGSFloatValueTableRow(IntPtr nativeStruct)
	{
		if (!FGSFloatValueTableRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSFloatValueTableRow");
			Value = 0f;
		}
		else
		{
			Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
		}
	}

	static FGSFloatValueTableRow()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSFloatValueTableRow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSFloatValueTableRow));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.GSFloatValueTableRow");
		FGSFloatValueTableRow_StructSize = NativeReflection.GetStructSize(intPtr);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FFloatProperty);
		FGSFloatValueTableRow_IsValid = intPtr != IntPtr.Zero && Value_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.GSFloatValueTableRow", FGSFloatValueTableRow_IsValid);
	}
}
