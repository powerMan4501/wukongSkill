using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GSInputAxisKeyMapping", "UnrealExtent", UnrealModuleType.Game)]
public struct FGSInputAxisKeyMapping
{
	private static bool AxisName_IsValid;

	private static int AxisName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSInputAxisKeyMapping:AxisName")]
	public FName AxisName;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSInputAxisKeyMapping:Scale")]
	public float Scale;

	private static bool Key_IsValid;

	private static int Key_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.GSInputAxisKeyMapping:Key")]
	public FName Key;

	private static bool FGSInputAxisKeyMapping_IsValid;

	private static int FGSInputAxisKeyMapping_StructSize;

	public FGSInputAxisKeyMapping Copy()
	{
		return this;
	}

	public static FGSInputAxisKeyMapping FromNative(IntPtr nativeBuffer)
	{
		return new FGSInputAxisKeyMapping(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSInputAxisKeyMapping value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSInputAxisKeyMapping FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSInputAxisKeyMapping(nativeBuffer + arrayIndex * FGSInputAxisKeyMapping_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSInputAxisKeyMapping value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSInputAxisKeyMapping_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSInputAxisKeyMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSInputAxisKeyMapping");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AxisName_Offset), AxisName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Key_Offset), Key);
	}

	public FGSInputAxisKeyMapping(IntPtr nativeStruct)
	{
		if (!FGSInputAxisKeyMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.GSInputAxisKeyMapping");
			AxisName = default(FName);
			Scale = 0f;
			Key = default(FName);
		}
		else
		{
			AxisName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AxisName_Offset));
			Scale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			Key = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Key_Offset));
		}
	}

	static FGSInputAxisKeyMapping()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSInputAxisKeyMapping)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSInputAxisKeyMapping));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.GSInputAxisKeyMapping");
		FGSInputAxisKeyMapping_StructSize = NativeReflection.GetStructSize(intPtr);
		AxisName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AxisName");
		AxisName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AxisName", Classes.FNameProperty);
		Scale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Scale", Classes.FFloatProperty);
		Key_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Key");
		Key_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Key", Classes.FNameProperty);
		FGSInputAxisKeyMapping_IsValid = intPtr != IntPtr.Zero && AxisName_IsValid && Scale_IsValid && Key_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.GSInputAxisKeyMapping", FGSInputAxisKeyMapping_IsValid);
	}
}
