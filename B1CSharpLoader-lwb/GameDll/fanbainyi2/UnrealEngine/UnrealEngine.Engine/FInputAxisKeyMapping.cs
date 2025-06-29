using System;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.InputAxisKeyMapping", "Engine", UnrealModuleType.Engine)]
public struct FInputAxisKeyMapping
{
	private static bool AxisName_IsValid;

	private static int AxisName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputAxisKeyMapping:AxisName")]
	public FName AxisName;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputAxisKeyMapping:Scale")]
	public float Scale;

	private static bool Key_IsValid;

	private static int Key_Offset;

	[UProperty(Flags = (PropFlags)6755399441055749uL)]
	[UMetaPath("/Script/Engine.InputAxisKeyMapping:Key")]
	public FKey Key;

	private static bool FInputAxisKeyMapping_IsValid;

	private static int FInputAxisKeyMapping_StructSize;

	public FInputAxisKeyMapping Copy()
	{
		return this;
	}

	public static FInputAxisKeyMapping FromNative(IntPtr nativeBuffer)
	{
		return new FInputAxisKeyMapping(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputAxisKeyMapping value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputAxisKeyMapping FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputAxisKeyMapping(nativeBuffer + arrayIndex * FInputAxisKeyMapping_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputAxisKeyMapping value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInputAxisKeyMapping_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInputAxisKeyMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputAxisKeyMapping");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AxisName_Offset), AxisName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		FKey.ToNative(IntPtr.Add(nativeStruct, Key_Offset), Key);
	}

	public FInputAxisKeyMapping(IntPtr nativeStruct)
	{
		if (!FInputAxisKeyMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputAxisKeyMapping");
			AxisName = default(FName);
			Scale = 0f;
			Key = default(FKey);
		}
		else
		{
			AxisName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AxisName_Offset));
			Scale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			Key = FKey.FromNative(IntPtr.Add(nativeStruct, Key_Offset));
		}
	}

	static FInputAxisKeyMapping()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInputAxisKeyMapping)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputAxisKeyMapping));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.InputAxisKeyMapping");
		FInputAxisKeyMapping_StructSize = NativeReflection.GetStructSize(intPtr);
		AxisName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AxisName");
		AxisName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AxisName", Classes.FNameProperty);
		Scale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Scale", Classes.FFloatProperty);
		Key_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Key");
		Key_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Key", Classes.FStructProperty);
		FInputAxisKeyMapping_IsValid = intPtr != IntPtr.Zero && AxisName_IsValid && Scale_IsValid && Key_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.InputAxisKeyMapping", FInputAxisKeyMapping_IsValid);
	}
}
