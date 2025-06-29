using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigCurve", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigCurve
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/ControlRig.RigElement:Name")]
	public FName Name;

	private static bool Index_IsValid;

	private static int Index_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/ControlRig.RigElement:Index")]
	public int Index;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/ControlRig.RigCurve:Value")]
	public float Value;

	private static bool FRigCurve_IsValid;

	private static int FRigCurve_StructSize;

	public FRigCurve Copy()
	{
		return this;
	}

	public static FRigCurve FromNative(IntPtr nativeBuffer)
	{
		return new FRigCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigCurve(nativeBuffer + arrayIndex * FRigCurve_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigCurve value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigCurve_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigCurve");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Index_Offset), Index);
	}

	public FRigCurve(IntPtr nativeStruct)
	{
		if (!FRigCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigCurve");
			Value = 0f;
			Name = default(FName);
			Index = 0;
		}
		else
		{
			Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Index = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Index_Offset));
		}
	}

	static FRigCurve()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigCurve));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigCurve");
		FRigCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		Index_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Index");
		Index_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Index", Classes.FIntProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FFloatProperty);
		FRigCurve_IsValid = intPtr != IntPtr.Zero && Value_IsValid && Name_IsValid && Index_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigCurve", FRigCurve_IsValid);
	}
}
