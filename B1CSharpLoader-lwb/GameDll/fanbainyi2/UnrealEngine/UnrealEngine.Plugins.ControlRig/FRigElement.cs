using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigElement", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigElement
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

	private static bool FRigElement_IsValid;

	private static int FRigElement_StructSize;

	public FRigElement Copy()
	{
		return this;
	}

	public static FRigElement FromNative(IntPtr nativeBuffer)
	{
		return new FRigElement(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigElement value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigElement FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigElement(nativeBuffer + arrayIndex * FRigElement_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigElement value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigElement_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigElement");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Index_Offset), Index);
	}

	public FRigElement(IntPtr nativeStruct)
	{
		if (!FRigElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigElement");
			Name = default(FName);
			Index = 0;
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Index = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Index_Offset));
		}
	}

	static FRigElement()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigElement)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigElement));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigElement");
		FRigElement_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		Index_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Index");
		Index_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Index", Classes.FIntProperty);
		FRigElement_IsValid = intPtr != IntPtr.Zero && Name_IsValid && Index_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigElement", FRigElement_IsValid);
	}
}
